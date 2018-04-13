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

    public class Line : Figure
    {
        public Line(Pen pen, int x1, int y1, int x2, int y2) : base(pen, x1, y1, x2, y2) { }
        public override void Draw(Graphics g)
        {
            g.DrawLine(pen, x1, y1, x2, y2);
        }
    }

    public class Square : Figure
    {
        public Square(Pen pen, int x1, int y1, int x2, int y2) : base(pen, x1, y1, x2, y2) { }
        protected int h { get { return (y2 - y1); } set { } }
        public override void Draw(Graphics g)
        {
            g.DrawRectangle(pen, x1, y1, h, h);
        }
    }

    public class Circle : Square
    {
        public Circle(Pen pen, int x1, int y1, int x2, int y2) : base(pen, x1, y1, x2, y2) { }
        public override void Draw(Graphics g)
        {
            g.DrawEllipse(pen, x1, y1, h, h);
        }
    }

    public class Rectangle : Square
    {
        public Rectangle(Pen pen, int x1, int y1, int x2, int y2) : base(pen, x1, y1, x2, y2) { }
        public int w { get { return (x2 - x1); } set { } }
        public override void Draw(Graphics g)
        {
            g.DrawRectangle(pen, x1, y1, w, h);
        }
    }

    public class Ellipse : Rectangle
    {
        public Ellipse(Pen pen, int x1, int y1, int x2, int y2) : base(pen, x1, y1, x2, y2) { }
        public override void Draw(Graphics g)
        {
            g.DrawEllipse(pen, x1, y1, w, h);
        }
    }

    public class Triangle : Figure
    {
        public Triangle(Pen pen, int x1, int y1, int x2, int y2) : base(pen, x1, y1, x2, y2) { }
        public override void Draw(Graphics g)
        {
            g.DrawLine(pen, x1, y2, x2, y2);
            g.DrawLine(pen, x1, y2, (x1 + x2) / 2, y1);
            g.DrawLine(pen, (x1 + x2) / 2, y1, x2, y2);
        }

    }
}
