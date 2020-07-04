using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GAMETARAKAN
{
    public partial class Form1 : Form
    {
        bool goUp, goDown, goLeft, goRight;
        int playerSpeed = 3;
        public Form1()
        {
            int i = 0;//test
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Up)
            {
                goUp = true;
                goLeft = false;
                goRight = false;

            }

            if (e.KeyData == Keys.Down)
            {
                goDown = true;
                goLeft = false;
                goRight = false;
            }

            if (e.KeyData == Keys.Left)
            {
                goLeft = true;
                goUp = false;
                goDown = false;
            }

            if (e.KeyData == Keys.Right)
            {
                goRight = true;
                goUp = false;
                goDown = false;
            }
            //foreach (Label lbl in this.Controls.OfType<Label>())
            //{
            //    if (lbl.Tag.ToString() == "maze")
            //    {
            //        if (pictureBox2.Bounds.IntersectsWith((lbl as Label).Bounds)) // pictureBox2.Bounds.IntersectsWith(label1.Bounds)
            //        {
            //            pictureBox2.SetBounds(prevTop, prevLeft, pictureBox2.Width, pictureBox2.Height);
            //        }
            //    }
            //}
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int prevTop = 0;
            int prevLeft = 0;

            if (goUp==true)
            {
                pictureBox2.Image = GAMETARAKAN.Properties.Resources.up;
                prevTop = pictureBox2.Location.X;
                prevLeft = pictureBox2.Location.Y;
                pictureBox2.Top -= playerSpeed; 
            }
            if (goDown == true)
            {
                pictureBox2.Image = GAMETARAKAN.Properties.Resources.down;
                prevTop = pictureBox2.Location.X;
                prevLeft = pictureBox2.Location.Y;
                pictureBox2.Top += playerSpeed;
            }
            if (goLeft == true)
            {
                pictureBox2.Image = GAMETARAKAN.Properties.Resources.left;
                prevTop = pictureBox2.Location.X;
                prevLeft = pictureBox2.Location.Y;
                pictureBox2.Left -= playerSpeed;
            }
            if (goRight == true)
            {
                pictureBox2.Image = GAMETARAKAN.Properties.Resources.right;
                prevTop = pictureBox2.Location.X;
                prevLeft = pictureBox2.Location.Y;
                pictureBox2.Left += playerSpeed;
            }
            foreach (Control x in this.Controls)
            {
                if (x is Label)
                {
                    if ((string)x.Tag =="maze")
                    {
                        if (pictureBox2.Bounds.IntersectsWith(x.Bounds))
                        {
                            pictureBox2.SetBounds(prevTop, prevLeft, pictureBox2.Width, pictureBox2.Height); //pictureBox2.Top = x.Top - pictureBox2.Height;
                        }
                    }
                }
            }
            //foreach (Label lbl in this.Controls.OfType<Label>())
            //{
            //    if (lbl.Tag.ToString() == "maze")
            //    {
            //        if (pictureBox2.Bounds.IntersectsWith((lbl as Label).Bounds)) // pictureBox2.Bounds.IntersectsWith(label1.Bounds)
            //        {
            //            //pictureBox2.SetBounds(prevTop, prevLeft, pictureBox2.Width, pictureBox2.Height);
            //        }
            //    }
            //}

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Up)
            {
                goUp = false;
            }
            if (e.KeyData == Keys.Down)
            {
                goDown = false;
            }
            if (e.KeyData == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyData == Keys.Right)
            {
                goRight = false;
            }
        }
    }
}
