using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1lab
{
    public partial class FormMain : Form
    {
        Graphics g;
        PictureBox pb;
        List<Figure> listOfFigures = new List<Figure>();
        Figure curFigure;
        int x1, y1, x2, y2;
    //    private bool drawing = false;

        public FormMain()
        {
            InitializeComponent();
            pb = pictureBox;
            g = pb.CreateGraphics();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            g.Clear(pictureBox.BackColor);
            listOfFigures.Clear();
        }
        
        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            x1 = e.X;
            y1 = e.Y;
        }

        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            x2 = e.X;
            y2 = e.Y;
        //    curFigure.Draw(g);

            curFigure = (Figure)Activator.CreateInstance(curFigure.GetType(), new Pen(Color.White, 2), x1,y1,x2,y2);
            curFigure.Draw(g);           
            
            listOfFigures.Add(curFigure);
        }
             
        private void GetRandomPosition (object sender, Figure figure)
        {
            Random random = new Random();
            figure.x1 = random.Next(1, pictureBox.Width);
            figure.y1 = random.Next(1, pictureBox.Height);
            figure.x2 = random.Next(20, pictureBox.Width-20);
            figure.y2 = random.Next(20, pictureBox.Height-20);
        }

        private void buttonLine_Click(object sender, EventArgs e)
        {
            curFigure = new Line(new Pen(Color.White,2), x1,y1,x2,y2);
        }

        private void buttonSquare_Click(object sender, EventArgs e)
        {
            curFigure = new Square(new Pen(Color.White, 2), x1, y1, x2, y2);
        }

    private void buttonCircle_Click(object sender, EventArgs e)
        {
            curFigure = new Circle(new Pen(Color.White, 2), x1, y1, x2, y2);
        }

        private void buttonEllipse_Click(object sender, EventArgs e)
        {
            curFigure = new Ellipse(new Pen(Color.White, 2), x1, y1, x2, y2);
        }

        private void buttonRectangle_Click(object sender, EventArgs e)
        {
            curFigure = new Rectangle(new Pen(Color.White, 2), x1, y1, x2, y2);
        }

        private void buttonTriangle_Click(object sender, EventArgs e)
        {
            curFigure = new Triangle(new Pen(Color.White, 2), x1, y1, x2, y2);
        }
 
        ~FormMain()
        {
            g.Dispose();
        }

        private void buttonAllFigures_Click(object sender, EventArgs e)
        {
            listOfFigures.Add(new Line(new Pen(Color.White, 2), 10, 300, 200, 10));
            listOfFigures.Add(new Square(new Pen(Color.White, 2), 110, 100, 300, 290));
            listOfFigures.Add(new Circle(new Pen(Color.White, 2), 310, 10, 210, 110));
            listOfFigures.Add(new Rectangle(new Pen(Color.White, 2), 40, 80, 55, 195));
            listOfFigures.Add(new Ellipse(new Pen(Color.White, 2), 70, 55, 100, 5));
            listOfFigures.Add(new Triangle(new Pen(Color.White, 2), 500, 270, 600, 300));
            for (int i = 0; i < listOfFigures.Count; i++)
            {
                listOfFigures[i].Draw(g);
            }
        }
    }
}
