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
            this.lblSetSize = new System.Windows.Forms.Label();
            this.lblSetSpeed = new System.Windows.Forms.Label();
            this.tbSetSpeed = new System.Windows.Forms.TrackBar();
            this.cbPause = new System.Windows.Forms.CheckBox();
            this.cbCycle = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbCanvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCellWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSetSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // pbCanvas
            // 
            this.pbCanvas.BackColor = System.Drawing.Color.Black;
            this.pbCanvas.Location = new System.Drawing.Point(71, 68);
            this.pbCanvas.Margin = new System.Windows.Forms.Padding(2);
            this.pbCanvas.Name = "pbCanvas";
            this.pbCanvas.Size = new System.Drawing.Size(564, 391);
            this.pbCanvas.TabIndex = 0;
            this.pbCanvas.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(703, 57);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 391);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // tbCellWidth
            // 
            this.tbCellWidth.Location = new System.Drawing.Point(175, 6);
            this.tbCellWidth.Margin = new System.Windows.Forms.Padding(2);
            this.tbCellWidth.Maximum = 80;
            this.tbCellWidth.Minimum = 10;
            this.tbCellWidth.Name = "tbCellWidth";
            this.tbCellWidth.Size = new System.Drawing.Size(258, 45);
            this.tbCellWidth.TabIndex = 2;
            this.tbCellWidth.Value = 80;
            this.tbCellWidth.Scroll += new System.EventHandler(this.tbCellWidth_Scroll);
            // 
            // lblCellWidth
            // 
            this.lblCellWidth.AutoSize = true;
            this.lblCellWidth.Location = new System.Drawing.Point(334, 6);
            this.lblCellWidth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCellWidth.Name = "lblCellWidth";
            this.lblCellWidth.Size = new System.Drawing.Size(13, 13);
            this.lblCellWidth.TabIndex = 3;
            this.lblCellWidth.Text = "_";
            // 
            // lblSetSize
            // 
            this.lblSetSize.AutoSize = true;
            this.lblSetSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F);
            this.lblSetSize.Location = new System.Drawing.Point(4, 6);
            this.lblSetSize.Name = "lblSetSize";
            this.lblSetSize.Size = new System.Drawing.Size(166, 32);
            this.lblSetSize.TabIndex = 4;
            this.lblSetSize.Text = "Set cell size";
            // 
            // lblSetSpeed
            // 
            this.lblSetSpeed.AutoSize = true;
            this.lblSetSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.lblSetSpeed.Location = new System.Drawing.Point(439, 5);
            this.lblSetSpeed.Name = "lblSetSpeed";
            this.lblSetSpeed.Size = new System.Drawing.Size(170, 39);
            this.lblSetSpeed.TabIndex = 5;
            this.lblSetSpeed.Text = "Set speed";
            // 
            // tbSetSpeed
            // 
            this.tbSetSpeed.Location = new System.Drawing.Point(615, 6);
            this.tbSetSpeed.Maximum = 1000;
            this.tbSetSpeed.Minimum = 50;
            this.tbSetSpeed.Name = "tbSetSpeed";
            this.tbSetSpeed.Size = new System.Drawing.Size(258, 45);
            this.tbSetSpeed.TabIndex = 6;
            this.tbSetSpeed.Value = 400;
            this.tbSetSpeed.Scroll += new System.EventHandler(this.tbSetSpeed_Scroll);
            // 
            // cbPause
            // 
            this.cbPause.AutoSize = true;
            this.cbPause.Location = new System.Drawing.Point(641, 83);
            this.cbPause.Name = "cbPause";
            this.cbPause.Size = new System.Drawing.Size(56, 17);
            this.cbPause.TabIndex = 7;
            this.cbPause.Text = "Pause";
            this.cbPause.UseVisualStyleBackColor = true;
            this.cbPause.CheckedChanged += new System.EventHandler(this.cbPause_CheckedChanged);
            // 
            // cbCycle
            // 
            this.cbCycle.AutoSize = true;
            this.cbCycle.Location = new System.Drawing.Point(641, 107);
            this.cbCycle.Name = "cbCycle";
            this.cbCycle.Size = new System.Drawing.Size(52, 17);
            this.cbCycle.TabIndex = 8;
            this.cbCycle.Text = "Cycle";
            this.cbCycle.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 475);
            this.Controls.Add(this.cbCycle);
            this.Controls.Add(this.cbPause);
            this.Controls.Add(this.tbSetSpeed);
            this.Controls.Add(this.lblSetSpeed);
            this.Controls.Add(this.lblSetSize);
            this.Controls.Add(this.tbCellWidth);
            this.Controls.Add(this.lblCellWidth);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.pbCanvas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbCanvas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCellWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSetSpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCanvas;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TrackBar tbCellWidth;
        private System.Windows.Forms.Label lblCellWidth;
        private System.Windows.Forms.Label lblSetSize;
        private System.Windows.Forms.Label lblSetSpeed;
        private System.Windows.Forms.TrackBar tbSetSpeed;
        private System.Windows.Forms.CheckBox cbPause;
        private System.Windows.Forms.CheckBox cbCycle;
    }
}

