using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Devil_Cookies_3D.Forms;
using Devil_Cookies_3D.Logics._2DLogics;
using Devil_Cookies_3D.Models;

namespace Devil_Cookies_3D
{
    public partial class Form1 : Form
    {
        Drawing drawing2D;
        Drawing drawing3D;

        public Form1()
        {
            InitializeComponent();
            drawing2D = new Drawing(this.Width, this.Height);
        }

        private void switchTo2DToolStripMenuItem_Click(object sender, EventArgs e)
        {
            drawing2D = new Drawing(this.Width, this.Height);
            createRectangleToolStripMenuItem.Visible = true;
        }

        private void createRectangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetTreangular2D set2D = new SetTreangular2D();
            set2D.Visible = false;
            set2D.ShowDialog();
            if (set2D.DialogResult == DialogResult.OK)
            {
                var t = new Triangle(set2D.vec1, set2D.vec2, drawing2D);
                this.BackgroundImage = t.Lines();
            }
        }

        private void switchTo3DToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createRectangleToolStripMenuItem.Visible = false;
        }

        PixelC pixel1;
        PixelC pixel2;

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (pixel1 == null)
            {
                pixel1 = new PixelC() { X = e.X, Y = e.Y };
            }
            else if (pixel2 == null)
            {
                pixel2 = new PixelC() { X = e.X, Y = e.Y };
                var t = new Line(pixel1, pixel2, drawing2D);
                this.BackgroundImage = t.Lines();
            }
            else
            {
                var pixel3 = new PixelC() { X = e.X, Y = e.Y };
                var t = new Line(pixel3, pixel2, drawing2D);
                this.BackgroundImage = t.Lines();
                pixel2 = pixel3;
            }
        }
    }
}
