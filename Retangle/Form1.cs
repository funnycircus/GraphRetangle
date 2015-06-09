using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 矩形
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.pictureBox1.Invalidate();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            //GET Retangle x and y
            int rect_x = int.Parse(this.textBox1.Text);
            int rect_y = int.Parse(this.textBox2.Text);

            if (rect_x <= 0)
            {
                rect_x = 0;
                this.textBox1.Text = "0";
            }
            else if (rect_x > 300)
            {
                rect_x = 300;
                this.textBox1.Text = "300";
            }

            if (rect_y <= 0)
            {
                rect_y = 0;
                this.textBox2.Text = "0";
            }
            else if(rect_y > 180)
            {
                rect_y = 180;
                this.textBox2.Text = "180";
            }

            Graph drawer = new Graph(rect_x, rect_y);
            
            //draw Retangle on PictureBox
            drawer.DrawRectangleRectangle(e.Graphics, e);
        }
    }
}
