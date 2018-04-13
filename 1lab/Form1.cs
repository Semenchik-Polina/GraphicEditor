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
        Boolean drawing = false;

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
        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e, Figure figure)
        {
            drawing = true;
            figure.x1 = e.X;
            figure.y1 = e.Y;
        }

        private void pictureBox_MouseUp(object sender, MouseEventArgs e, Figure figure)
        {
            figure.x2 = e.X;
            figure.y2 = e.Y;
        }
        
        private void buttonLine_Click(object sender, EventArgs e)
        {
            Line line = new Line();

            if (checkBoxAutoDraw.Checked == true)
            {
                Random random = new Random();
                line.x1 = random.Next(1, pictureBox.Width);
                line.x2 = random.Next(1, pictureBox.Width);
                line.y1 = random.Next(10, pictureBox.Height);
                line.y2 = random.Next(10, pictureBox.Height);
                line.Draw(g);
            }else
            {
                if (drawing == true)
                {
                    line.Draw(g);
                    drawing = false;
                }
            }
                     
            listOfFigures.Add(line);
        }

        private void buttonSquare_Click(object sender, EventArgs e)
        {
            Square square = new Square();
            Random random = new Random();
            square.x1 = random.Next(1, pictureBox.Width- 100);
            square.y1 = random.Next(1, pictureBox.Width- 100);
            square.x2 = random.Next(40, pictureBox.Width);
            square.y2 = random.Next(40, pictureBox.Width);
            square.Draw(g);
            listOfFigures.Add(square);
        }

        private void buttonCircle_Click(object sender, EventArgs e)
        {
            Circle circle = new Circle();
            Random random = new Random();
            circle.x1 = random.Next(1, pictureBox.Width - 100);
            circle.y1 = random.Next(1, pictureBox.Width - 100);
            circle.x2 = random.Next(40, pictureBox.Width);
            circle.y2 = random.Next(40, pictureBox.Width);
            circle.Draw(g);
            listOfFigures.Add(circle);
        }

        private void buttonEllipse_Click(object sender, EventArgs e)
        {
            Ellipse ellipse = new Ellipse();
            Random random = new Random();
            ellipse.x1 = random.Next(1, pictureBox.Width- 100);
            ellipse.x2 = random.Next(40, pictureBox.Width);
            ellipse.y1 = random.Next(1, pictureBox.Height- 100);
            ellipse.y2 = random.Next(40, pictureBox.Width);
            ellipse.Draw(g);
            listOfFigures.Add(ellipse);
        }

        private void buttonRectangle_Click(object sender, EventArgs e)
        {
            Rectangle rect = new Rectangle();
            Random random = new Random();
            rect.x1 = random.Next(1, pictureBox.Width - 100);
            rect.x2 = random.Next(40, pictureBox.Width);
            rect.y1 = random.Next(1, pictureBox.Height - 100);
            rect.y2 = random.Next(40, pictureBox.Width);
            rect.Draw(g);
            listOfFigures.Add(rect);
        }

        private void buttonTriangle_Click(object sender, EventArgs e)
        {
            Triangle triang = new Triangle();
            Random random = new Random();
            triang.x1 = random.Next(1, pictureBox.Width-100);
            triang.x2 = random.Next(40, pictureBox.Width);
            triang.y1 = random.Next(1, pictureBox.Height-100);
            triang.y2 = random.Next(40, pictureBox.Height);
            triang.Draw(g);
            listOfFigures.Add(triang);
        }

        ~FormMain()
        {
            g.Dispose();
        }
    }
}
