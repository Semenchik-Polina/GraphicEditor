using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace _1lab
{
    public abstract class Figure
    {
        public int x1, y1, x2, y2;
        protected Pen pen = new Pen(Color.White, 2);
        public Figure(Pen pen, int x1, int y1, int x2,int y2)
        {
            this.pen = pen;
            this.x1 = x1;
            this.x2 = x2;
            this.y1 = y1;
            this.y2 = y2;
        }
        public abstract void Draw(Graphics g);
        ~Figure()
        {
            pen.Dispose();
        }
    }
}
