using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EditScreenshot
{
    public partial class Form1 : Form
    {
        private Point p1, p2;
        private Bitmap bitmap;
        string tool = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void pic_box_DragOver(object sender, DragEventArgs e)
        {
            
        }

        private void pic_box_MouseDown(object sender, MouseEventArgs e)
        {
            p1 = e.Location;
        }

        private void pic_box_MouseUp(object sender, MouseEventArgs e)
        {
            if (tool == "line" && e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                using (Graphics g = Graphics.FromImage(bitmap))
                    g.DrawLine(Pens.Black, p1, e.Location);
                p1 = e.Location;
                pic_box.Image = bitmap;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            set_initial_canvas();
        }
        private void set_initial_canvas()
        {
            bitmap = new Bitmap(pic_box.Width, pic_box.Height);
            using (Graphics g = Graphics.FromImage(bitmap))
                g.Clear(Color.White);
            pic_box.Image = bitmap;
        }
        private void pic_box_MouseMove(object sender, MouseEventArgs e)
        {
            if (tool=="pen")
            {
                if (e.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    using (Graphics g = Graphics.FromImage(bitmap))
                        g.DrawLine(Pens.Black, p1, e.Location);
                    p1 = e.Location;
                    pic_box.Image = bitmap;
                }
            }
        }

        private void pen_B_Click(object sender, EventArgs e)
        {
            tool = "pen";
        }

        private void clear_B_Click(object sender, EventArgs e)
        {
            set_initial_canvas();
        }

        private void eraser_B_Click(object sender, EventArgs e)
        {
            tool = "eraser";
        }

        private void line_B_Click(object sender, EventArgs e)
        {
            tool = "line";
        }

        private void pic_box_Click(object sender, EventArgs e)
        {
        }

        private void pic_box_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            tool = "text";
        }

        private void pic_box_MouseLeave(object sender, EventArgs e)
        {
        }
    }
}
