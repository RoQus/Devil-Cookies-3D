using Devil_Cookies_3D.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Devil_Cookies_3D.Forms
{
    public partial class SetTreangular2D : Form
    {
        public Vector<PixelC> vec1 = new Models.Vector<PixelC>();
        public Vector<PixelC> vec2 = new Models.Vector<PixelC>();

        public SetTreangular2D()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            vec1.Start = vec2.Start = new PixelC() { X = Convert.ToDouble(textBox1.Text), Y = Convert.ToDouble(textBox2.Text) };
            vec1.Finish = new PixelC() { X = Convert.ToDouble(textBox3.Text), Y = Convert.ToDouble(textBox4.Text) };
            vec2.Finish = new PixelC() { X = Convert.ToDouble(textBox5.Text), Y = Convert.ToDouble(textBox6.Text) };

            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
