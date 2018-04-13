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
        protected Pen pen = new Pen(Color.White);
        public abstract void Draw(Graphics g);
        ~Figure()
        {
            pen.Dispose();
        }
    }

    public class Line : Figure
    {
        public override void Draw(Graphics g)
        {
            g.DrawLine(pen, x1, y1, x2, y2);
        }
    }

    public class Square : Figure
    {
        protected int h { get { return Math.Abs(y2 - y1); } set { } }
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
        public int w { get { return Math.Abs(x2 - x1); } set { } }
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

    public class Triangle : Figure
    {
        public override void Draw(Graphics g)
        {
            g.DrawLine(pen, x1, y2, x2, y2);
            g.DrawLine(pen, x1, y2, (x1 + x2) / 2, y1);
            g.DrawLine(pen, (x1 + x2) / 2, y1, x2, y2);
        }

    }
}
