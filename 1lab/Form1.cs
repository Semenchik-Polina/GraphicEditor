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
  /*      ShapeList<Figure> listFigures;

        public class ShapeList<T>: List<T>
            where T: Figure
        { }
 */
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

        }

        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {

        }
        
        private void buttonLine_Click(object sender, EventArgs e)
        {
            Line line = new Line();
            Random random = new Random();
            line.x1 = random.Next(1, pictureBox.Width);
            line.x2 = random.Next(1, pictureBox.Width);
            line.y1 = random.Next(1, pictureBox.Height);
            line.y2 = random.Next(1, pictureBox.Height);
            line.Draw(g);
            listOfFigures.Add(line);
        }

        private void buttonSquare_Click(object sender, EventArgs e)
        {
            Square square = new Square();
            Random random = new Random();
            square.x1 = random.Next(1, pictureBox.Width-100);
            square.y1 = random.Next(1, pictureBox.Width-100);
            square.h = random.Next(20, pictureBox.Height-200);
            square.Draw(g);
            listOfFigures.Add(square);
        }

        private void buttonCircle_Click(object sender, EventArgs e)
        {
            Circle circle = new Circle();
            Random random = new Random();
            circle.x1 = random.Next(1, pictureBox.Width - 100);
            circle.y1 = random.Next(1, pictureBox.Width - 100);
            circle.h = random.Next(20, pictureBox.Height - 200);
            circle.Draw(g);
            listOfFigures.Add(circle);
        }

        private void buttonEllipse_Click(object sender, EventArgs e)
        {
            Ellipse ellipse = new Ellipse();
            Random random = new Random();
            ellipse.x1 = random.Next(1, pictureBox.Width-100);
            ellipse.w = random.Next(20, pictureBox.Width-200);
            ellipse.y1 = random.Next(1, pictureBox.Height-100);
            ellipse.h = random.Next(20, pictureBox.Height-200);
            ellipse.Draw(g);
            listOfFigures.Add(ellipse);
        }

        private void buttonRectangle_Click(object sender, EventArgs e)
        {
            Rectangle rect = new Rectangle();
            Random random = new Random();
            rect.x1 = random.Next(1, pictureBox.Width - 100);
            rect.w = random.Next(20, pictureBox.Width - 200);
            rect.y1 = random.Next(1, pictureBox.Height - 100);
            rect.h = random.Next(20, pictureBox.Height - 200);
            rect.Draw(g);
            listOfFigures.Add(rect);
        }

        private void buttonTriangle_Click(object sender, EventArgs e)
        {
            Triangle triang = new Triangle();
            Random random = new Random();
            triang.x1 = random.Next(1, pictureBox.Width);
            triang.x2 = random.Next(40, pictureBox.Width);
            triang.y1 = random.Next(1, pictureBox.Height);
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
