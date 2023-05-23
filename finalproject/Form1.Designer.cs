namespace finalproject
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
            this.button1 = new System.Windows.Forms.Button();
            this.lb = new System.Windows.Forms.Label();
            this.square = new System.Windows.Forms.Label();
            this.labelpoint = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::finalproject.Properties.Resources._2023_05_22_;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(978, 337);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 19);
            this.button1.TabIndex = 0;
            this.button1.Text = "creating";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_MouseClick);
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Location = new System.Drawing.Point(1024, 314);
            this.lb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(41, 13);
            this.lb.TabIndex = 1;
            this.lb.Text = "triangle";
            this.lb.Click += new System.EventHandler(this.triangle_Click);
            // 
            // square
            // 
            this.square.AutoSize = true;
            this.square.Location = new System.Drawing.Point(983, 314);
            this.square.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.square.Name = "square";
            this.square.Size = new System.Drawing.Size(39, 13);
            this.square.TabIndex = 2;
            this.square.Text = "square";
            this.square.Click += new System.EventHandler(this.square_Click);
            // 
            // labelpoint
            // 
            this.labelpoint.AutoSize = true;
            this.labelpoint.Location = new System.Drawing.Point(1024, 65);
            this.labelpoint.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelpoint.Name = "labelpoint";
            this.labelpoint.Size = new System.Drawing.Size(26, 13);
            this.labelpoint.TabIndex = 3;
            this.labelpoint.Text = "(x,y)";
            this.labelpoint.Click += new System.EventHandler(this.labelpoint_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::finalproject.Properties.Resources._2023_05_22_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1094, 425);
            this.Controls.Add(this.labelpoint);
            this.Controls.Add(this.square);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainForm_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.Label square;
        private System.Windows.Forms.Label labelpoint;
    }
}

