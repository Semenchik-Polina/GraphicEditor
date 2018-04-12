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
        public int x1, y1;
        protected Pen pen = new Pen(Color.White);
        public abstract void Draw(Graphics g);
        ~Figure()
        {
            pen.Dispose();
        }
    }

    public class Line : Figure
    {
        public int x2, y2;
        public override void Draw(Graphics g)
        {
            g.DrawLine(pen, x1, y1, x2, y2);
        }
    }

    public class Square : Figure
    {
        public int h;
        public override void Draw(Graphics g)
        {
            g.DrawRectangle(pen, x1, y1, h, h);
        }
    }

    public class Circle : Square
    {
        public override void Draw(Graphics g)
        {
            g.DrawEllipse(pen, x1, y1, h, h);
        }
    }

    public class Rectangle : Square
    {
        public int w;
        public override void Draw(Graphics g)
        {
            g.DrawRectangle(pen, x1, y1, w, h);
        }
    }

    public class Ellipse : Rectangle
    {
        public override void Draw(Graphics g)
        {
            g.DrawEllipse(pen, x1, y1, w, h);
        }
    }

    public class Triangle : Line
    {
        public override void Draw(Graphics g)
        {
            g.DrawLine(pen, x1, y2, x2, y2);
            g.DrawLine(pen, x1, y2, (x1 + x2) / 2, y1);
            g.DrawLine(pen, (x1 + x2) / 2, y1, x2, y2);
        }

    }
}
