﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace _1lab
{
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
