namespace EditScreenshot
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
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.pic_box = new System.Windows.Forms.PictureBox();
            this.pen_B = new System.Windows.Forms.ToolStripButton();
            this.eraser_B = new System.Windows.Forms.ToolStripButton();
            this.clear_B = new System.Windows.Forms.ToolStripButton();
            this.line_B = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_box)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pen_B,
            this.eraser_B,
            this.clear_B,
            this.line_B,
            this.toolStripButton1});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(284, 25);
            this.toolStrip2.TabIndex = 0;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // pic_box
            // 
            this.pic_box.Location = new System.Drawing.Point(0, 28);
            this.pic_box.Name = "pic_box";
            this.pic_box.Size = new System.Drawing.Size(283, 233);
            this.pic_box.TabIndex = 1;
            this.pic_box.TabStop = false;
            this.pic_box.Click += new System.EventHandler(this.pic_box_Click);
            this.pic_box.DragOver += new System.Windows.Forms.DragEventHandler(this.pic_box_DragOver);
            this.pic_box.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pic_box_MouseClick);
            this.pic_box.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_box_MouseDown);
            this.pic_box.MouseLeave += new System.EventHandler(this.pic_box_MouseLeave);
            this.pic_box.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pic_box_MouseMove);
            this.pic_box.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pic_box_MouseUp);
            // 
            // pen_B
            // 
            this.pen_B.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pen_B.Image = global::EditScreenshot.Properties.Resources.pen;
            this.pen_B.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pen_B.Name = "pen_B";
            this.pen_B.Size = new System.Drawing.Size(23, 22);
            this.pen_B.Text = "toolStripButton1";
            this.pen_B.Click += new System.EventHandler(this.pen_B_Click);
            // 
            // eraser_B
            // 
            this.eraser_B.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.eraser_B.Image = global::EditScreenshot.Properties.Resources.eraser;
            this.eraser_B.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.eraser_B.Name = "eraser_B";
            this.eraser_B.Size = new System.Drawing.Size(23, 22);
            this.eraser_B.Text = "toolStripButton6";
            this.eraser_B.Click += new System.EventHandler(this.eraser_B_Click);
            // 
            // clear_B
            // 
            this.clear_B.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.clear_B.Image = global::EditScreenshot.Properties.Resources.clear;
            this.clear_B.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.clear_B.Name = "clear_B";
            this.clear_B.Size = new System.Drawing.Size(23, 22);
            this.clear_B.Text = "toolStripButton5";
            this.clear_B.Click += new System.EventHandler(this.clear_B_Click);
            // 
            // line_B
            // 
            this.line_B.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.line_B.Image = global::EditScreenshot.Properties.Resources.line;
            this.line_B.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.line_B.Name = "line_B";
            this.line_B.Size = new System.Drawing.Size(23, 22);
            this.line_B.Text = "toolStripButton7";
            this.line_B.Click += new System.EventHandler(this.line_B_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::EditScreenshot.Properties.Resources.text;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.pic_box);
            this.Controls.Add(this.toolStrip2);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton pen_B;
        private System.Windows.Forms.ToolStripButton clear_B;
        private System.Windows.Forms.ToolStripButton eraser_B;
        private System.Windows.Forms.ToolStripButton line_B;
        private System.Windows.Forms.PictureBox pic_box;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}

