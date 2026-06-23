using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;

namespace MazeMaker
{

    class Cell
    {
        static Random rand = new Random();
        public int Row { get; set; }
        public int Col { get; set; }
        public bool Visited { get; set; }
        public int Size { get; set; }
     
        public List<bool> walls = new List<bool>() { true, true, true , true }; // top, right, bottom, left
        public Cell(int row, int col, int size)
        {
            Row = row;
            Col = col;
            Size = size;
            Visited = false;
            
        }
        
        internal void Show(Graphics g)
        {
            int x = Col * Size;
            int y = Row * Size;
            if (Visited)
            {
                g.FillRectangle(Brushes.Purple, x, y, Size, Size);

            }
            if (walls[0])
            {
                g.DrawLine(Pens.White, x, y, x + Size, y); // top
            }
            if (walls[1])
            {
                g.DrawLine(Pens.White, x + Size, y, x + Size, y + Size); // right
            }
            if (walls[2])
            {
                g.DrawLine(Pens.White, x + Size, y + Size, x, y + Size); // bottom
            }
            if (walls[3])
            {
                g.DrawLine(Pens.White, x, y + Size, x, y); // left
            }
        }

        public int Index(int row, int col,int numCols)
        {

            if (row < 0 || col < 0 || row >= numCols || col >= numCols)
            {
                return -1;
            }
            return row * numCols + col ; 
        }

        internal Cell CheckNeighbours(List<Cell> grid, int numCols)
        {
            List<Cell> neighbours = new List<Cell>();
            Cell top = Index(Row -1, Col, numCols) != -1 ? grid[Index(Row -1, Col, numCols)] : null;
            Cell right = Index(Row, Col + 1, numCols) != -1 ? grid[Index(Row, Col + 1 , numCols)] : null;
            Cell bottom = Index(Row + 1, Col, numCols) != -1 ? grid[Index(Row + 1, Col, numCols)] : null;
            Cell left = Index(Row, Col - 1, numCols) != -1 ? grid[Index(Row, Col - 1, numCols)] : null;
            if (top != null && !top.Visited)
            {
                neighbours.Add(top);
            }
            if (right != null && !right.Visited)
            {
                neighbours.Add(right);
            }
            if (bottom != null && !bottom.Visited)
            {
                neighbours.Add(bottom);
            }
            if (left != null && !left.Visited)
            {
                neighbours.Add(left);
            }
            if (neighbours.Count >0)
            {
                return neighbours[rand.Next(neighbours.Count)];
            }
            return null;
        }

        internal void Highlight(Graphics graphics)
        {
            int x = Col * Size;
            int y = Row * Size;
            // the line below is not finished, it should highlight the current cell in a different color to the purple used for the other cells
            //graphics.FillRectangle(Brushes.BlueViolet, );
        }
    }
}

