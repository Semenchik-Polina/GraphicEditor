using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace _1lab
{
    public class Square : Figure
    {
        public Square(Pen pen, int x1, int y1, int x2, int y2) : base(pen, x1, y1, x2, y2) { }
        protected int h {
            get {
                if (y2 < y1)
                {
                    int temp = y1;
                    y1 = y2;
                    y2 = temp;
                }
                return (y2 - y1);
            }
            set { }
        }
        public override void Draw(Graphics g)
        {
            g.DrawRectangle(pen, x1, y1, h, h);
        }
    }
}
