using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 矩形
{
    class Graph
    {
        private int rect_x = 0;
        private int rect_y = 0;

        public Graph(int x, int y) {
            if (x <= 0)
            {
                this.rect_x = 0;
            }
            else if (x > 300)
            {
                this.rect_x = 300;
            }
            else 
            {
                this.rect_x = x;
            }

            if (y <= 0)
            {
                this.rect_y = 0;
            }
            else if (y > 180) 
            {
                this.rect_y = 180;
            }
            else
            {
                this.rect_y = y;
            }
        }

        
        public void DrawRectangleRectangle(System.Drawing.Graphics graphics, System.Windows.Forms.PaintEventArgs e)
        {

            // Create pen.
            System.Drawing.Pen blackPen = new System.Drawing.Pen(System.Drawing.Color.Black, 3);

            // Create rectangle.
            System.Drawing.Rectangle rect = new System.Drawing.Rectangle(0, 0, this.rect_x, this.rect_y);

            // Draw rectangle to screen.
            e.Graphics.DrawRectangle(blackPen, rect);
        }

    }
}
