namespace MazeMaker
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbCanvas = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tbCellWidth = new System.Windows.Forms.TrackBar();
            this.lblCellWidth = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbCanvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCellWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // pbCanvas
            // 
            this.pbCanvas.BackColor = System.Drawing.Color.Black;
            this.pbCanvas.Location = new System.Drawing.Point(142, 130);
            this.pbCanvas.Margin = new System.Windows.Forms.Padding(4);
            this.pbCanvas.Name = "pbCanvas";
            this.pbCanvas.Size = new System.Drawing.Size(1128, 752);
            this.pbCanvas.TabIndex = 0;
            this.pbCanvas.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1372, 90);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(6);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(400, 752);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // tbCellWidth
            // 
            this.tbCellWidth.Location = new System.Drawing.Point(350, 12);
            this.tbCellWidth.Maximum = 80;
            this.tbCellWidth.Minimum = 10;
            this.tbCellWidth.Name = "tbCellWidth";
            this.tbCellWidth.Size = new System.Drawing.Size(517, 90);
            this.tbCellWidth.TabIndex = 2;
            this.tbCellWidth.Value = 80;
            this.tbCellWidth.Scroll += new System.EventHandler(this.tbCellWidth_Scroll);
            // 
            // lblCellWidth
            // 
            this.lblCellWidth.AutoSize = true;
            this.lblCellWidth.Location = new System.Drawing.Point(669, 12);
            this.lblCellWidth.Name = "lblCellWidth";
            this.lblCellWidth.Size = new System.Drawing.Size(24, 25);
            this.lblCellWidth.TabIndex = 3;
            this.lblCellWidth.Text = "_";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 914);
            this.Controls.Add(this.tbCellWidth);
            this.Controls.Add(this.lblCellWidth);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.pbCanvas);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbCanvas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCellWidth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCanvas;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TrackBar tbCellWidth;
        private System.Windows.Forms.Label lblCellWidth;
    }
}

