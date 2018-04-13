using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace _1lab
{
    public class Ellipse : Rectangle
    {
        public Ellipse(Pen pen, int x1, int y1, int x2, int y2) : base(pen, x1, y1, x2, y2) { }
        public override void Draw(Graphics g)
        {
            g.DrawEllipse(pen, x1, y1, w, h);
        }
    }
}
