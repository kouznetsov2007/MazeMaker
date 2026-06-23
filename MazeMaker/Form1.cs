using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// based on https://www.youtube.com/watch?v=HyK_Q5rrcr4&t=1s
// there are 4 parts
// the algorithm is https://en.wikipedia.org/wiki/Maze_generation_algorithm#Randomized_depth-first_search
// note that this is the iterative version using a stack not recursion.

namespace MazeMaker
{
    public partial class Form1 : Form
    {
        int numCols, numRows;
        int cellWidth;
        List<Cell> grid = new List<Cell>();
        Stack<Cell> theStack = new Stack<Cell>();
        List<Label> labelList = new List<Label>();
        Cell current, next;
        Timer timer = new Timer();
        public Form1()
        {
            InitializeComponent();
            pbCanvas.Paint += PbCanvas_Paint;
            timer.Interval = 400; 
            timer.Tick += Timer_Tick;
            timer.Enabled = true;
            // Configure flowLayoutPanel1 to grow from the bottom upwards
            flowLayoutPanel1.FlowDirection = FlowDirection.BottomUp;
            flowLayoutPanel1.WrapContents = false;
            flowLayoutPanel1.AutoSize = false;
            cellWidth= tbCellWidth.Value;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            pbCanvas.Invalidate(); // call the paint event
        }

        private void PbCanvas_Paint(object sender, PaintEventArgs e)
        {
            current.Visited = true; 
            next = current.CheckNeighbours(grid, numCols); // step 1: check for unvisited neighbours
            if (next != null) // if there is an unvisited neighbour, go to it
            {
                next.Visited = true;
                // remove walls between current and next
                theStack.Push(current);
                //displaying the stack of cells in the labelStack
                Label thelabel = new Label();
                thelabel.BackColor = Color.LightBlue; thelabel.BorderStyle = BorderStyle.FixedSingle;
                thelabel.Text = $"Current: ({current.Row}, {current.Col}))";
                labelList.Add(thelabel);
                //RemoveWalls(current, next);
                current = next;
            }
            else if (theStack.Count > 0)
            {
                current = theStack.Pop();
                labelList.RemoveAt(labelList.Count - 1); // remove the last label from the list

            }
            DisplayTheStack();
            foreach (var item in grid)
            {
                item.Show(e.Graphics);
            }
            current.Highlight(e.Graphics);
        }

        private void DisplayTheStack()
        {
            flowLayoutPanel1.Controls.Clear();
            // Add the lablelist to the flow layout panel flowLayoutPanel1 
          
        }

        private void tbCellWidth_Scroll(object sender, EventArgs e)
        {
            cellWidth = tbCellWidth.Value;
            lblCellWidth.Text = $"Cell Width: {cellWidth}";
            //make the value divisible by the canvas width and height to avoid partial cells
            int canvasWidth = pbCanvas.Width;
            while (canvasWidth % cellWidth !=0)
            {
                cellWidth ++;
            }
            // restart the maze generation
            ResetMaze();
        }

        private void RemoveWalls(Cell current, Cell next)
        {
            int x = current.Col - next.Col; // check if the next cell is to the left or right of the current cell
            if (x == 1)
            {
                current.walls[3] = false;
                next.walls[1] = false;
            }
            // missing code here
            int y = current.Row - next.Row;
            if (y == 1)
            {
                current.walls[0] = false;
                next.walls[2] = false;
            }
            // missing code here
        }
        private void ResetMaze()
        {
            // clear previous state
            grid.Clear();
            theStack.Clear();
            labelList.Clear();
            flowLayoutPanel1.Controls.Clear();
            // avoid division by zero and ensure at least 1 column/row
            if (cellWidth <= 0) cellWidth = 1;
            numCols = Math.Max(1, pbCanvas.Width / cellWidth);
            numRows = Math.Max(1, pbCanvas.Height / cellWidth);

            for (int row = 0; row < numRows; row++)
            {
                for (int col = 0; col < numCols; col++)
                {
                    Cell cell = new Cell(row, col, cellWidth);
                    grid.Add(cell);
                }
            }

            current = grid.Count > 0 ? grid[0] : null;

            // force a redraw so the new grid appears immediately
            pbCanvas.Invalidate();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // set the form to maximized
            this.WindowState = FormWindowState.Maximized;

            pbCanvas.Width = 400;
            pbCanvas.Height = 400;
            numCols = pbCanvas.Width / cellWidth;
            numRows = pbCanvas.Height / cellWidth;
            for (int row = 0; row < numRows; row++)
            {
                for (int col = 0; col < numCols; col++)
                {
                    Cell cell = new Cell(row, col, cellWidth);
                    grid.Add(cell);
                }
            }
            // pbCanvas.Invalidate(); // call the paint event
            current = grid[0]; // start with the first cell
        }
    }
}
