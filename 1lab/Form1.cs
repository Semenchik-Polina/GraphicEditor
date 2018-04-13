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
        private bool drawing = false;

        public FormMain()
        {
            InitializeComponent();
            pb = pictureBox;
            g = pb.CreateGraphics();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            g.Clear(pictureBox.BackColor);
            listOfFigures.Clear();
        }
        
        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            curFigure.x1 = e.X;
            curFigure.y1 = e.Y;
        }

        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            curFigure.x2 = e.X;
            curFigure.y2 = e.Y;
            curFigure.Draw(g);
        //    listOfFigures.Add(curFigure);
        }
             
        private void GetRandomPosition (object sender, Figure figure)
        {
            Random random = new Random();
            figure.x1 = random.Next(1, pictureBox.Width);
            figure.y1 = random.Next(1, pictureBox.Height);
            figure.x2 = random.Next(20, pictureBox.Width-20);
            figure.y2 = random.Next(20, pictureBox.Height-20);
        }

   /*     private void buttonLine_Click(object sender, EventArgs e)
        {
            curFigure = new Line();
        }

        private void buttonSquare_Click(object sender, EventArgs e)
        {
            curFigure = new Square();
        }

    private void buttonCircle_Click(object sender, EventArgs e)
        {
            curFigure = new Circle();
        }

        private void buttonEllipse_Click(object sender, EventArgs e)
        {
            curFigure = new Ellipse();
        }

        private void buttonRectangle_Click(object sender, EventArgs e)
        {
            curFigure = new Rectangle();
        }

        private void buttonTriangle_Click(object sender, EventArgs e)
        {
            curFigure = new Triangle();
        }
        */
        ~FormMain()
        {
            g.Dispose();
        }

        private void buttonAllFigures_Click(object sender, EventArgs e)
        {
            listOfFigures.Add(new Line(new Pen(Color.White), 10, 300, 200, 10));
            listOfFigures.Add(new Square(new Pen(Color.White), 110, 100, 300, 290));
            listOfFigures.Add(new Circle(new Pen(Color.White), 310, 10, 210, 110));
            listOfFigures.Add(new Rectangle(new Pen(Color.White), 40, 80, 55, 195));
            listOfFigures.Add(new Ellipse(new Pen(Color.White), 70, 55, 100, 5));
            listOfFigures.Add(new Triangle(new Pen(Color.White), 500, 270, 600, 300));
            for (int i = 0; i < listOfFigures.Count; i++)
            {
                listOfFigures[i].Draw(g);
            }
        }
    }
}
