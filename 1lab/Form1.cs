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
        Pen pen = new Pen(Color.White, 2);
        List<Figure> listOfFigures = new List<Figure>();
        Figure curFigure;
        int x1, y1, x2, y2;

        public FormMain()
        {
            InitializeComponent();
            pb = pictureBox;
            g = pb.CreateGraphics();
            curFigure = new Line(pen, x1, y1, x2, y2);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
       //       g.Clear(pictureBox.BackColor);
              listOfFigures.Clear();            
        }

        private void pictureBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Bitmap myBitmap = new Bitmap(pictureBox.BackgroundImage);
            if (!(myBitmap.GetPixel(0,0) == myBitmap.GetPixel(e.X,e.Y)))
            {

            }

            int x, y;

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            if (!(listOfFigures.Count == 0))
            {
                Figure temp = listOfFigures[listOfFigures.Count - 1];
                Figure delited;
                delited = (Figure)Activator.CreateInstance(temp.GetType(), new Pen(pictureBox.BackColor,pen.Width), temp.x1, temp.y1, temp.x2, temp.y2);
                delited.Draw(g);
                listOfFigures.RemoveAt(listOfFigures.Count - 1);
            }
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

            curFigure = (Figure)Activator.CreateInstance(curFigure.GetType(), pen, x1,y1,x2,y2);
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
            curFigure = new Line(pen, x1,y1,x2,y2);
        }

        private void buttonSquare_Click(object sender, EventArgs e)
        {
            curFigure = new Square(pen, x1, y1, x2, y2);
        }

    private void buttonCircle_Click(object sender, EventArgs e)
        {
            curFigure = new Circle(pen, x1, y1, x2, y2);
        }

        private void buttonEllipse_Click(object sender, EventArgs e)
        {
            curFigure = new Ellipse(pen, x1, y1, x2, y2);
        }

        private void buttonRectangle_Click(object sender, EventArgs e)
        {
            curFigure = new Rectangle(pen, x1, y1, x2, y2);
        }

       
        private void buttonTriangle_Click(object sender, EventArgs e)
        {
            curFigure = new Triangle(pen, x1, y1, x2, y2);
        }
 
        ~FormMain()
        {
            g.Dispose();
            pen.Dispose();
        }

        private void buttonAllFigures_Click(object sender, EventArgs e)
        {
            listOfFigures.Add(new Line(pen, 10, 300, 200, 10));
            listOfFigures.Add(new Square(pen, 110, 100, 300, 290));
            listOfFigures.Add(new Circle(pen, 310, 10, 230, 130));
            listOfFigures.Add(new Rectangle(pen, 40, 80, 55, 195));
            listOfFigures.Add(new Ellipse(pen, 500, 5, 610, 60));
            listOfFigures.Add(new Triangle(pen, 500, 270, 600, 300));
            for (int i = 0; i < listOfFigures.Count; i++)
            {
                listOfFigures[i].Draw(g);
            }
        }
    }
}
