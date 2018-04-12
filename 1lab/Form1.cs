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

        public FormMain()
        {
            InitializeComponent();
            pb = pictureBox;
            g = pb.CreateGraphics();
         }

        private void Form1_Load(object sender, EventArgs e)
        {

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
        }

        ~FormMain()
        {
            g.Dispose();
        }
    }
}
