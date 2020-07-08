using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace GAMETARAKAN
{
    public partial class Form1 : Form
    {
        bool goUp, goDown, goLeft, goRight;
        int playerSpeed = 3;
        int prevTop = 0;
        int prevLeft = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TARAKAN_Click(object sender, EventArgs e)
        {
            easy es = new easy();
            Hide();
            es.Show();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Up)
            { 
            
                pictureBox2.Image = GAMETARAKAN.Properties.Resources.up;
                goUp = true;
                goLeft = false;
                goRight = false;

            }
            if (e.KeyData == Keys.Down)
            {
                pictureBox2.Image = GAMETARAKAN.Properties.Resources.down;
                goDown = true;
                goLeft = false;
                goRight = false;
            }
            if (e.KeyData == Keys.Left)
            {
                pictureBox2.Image = GAMETARAKAN.Properties.Resources.left;
                goLeft = true;
                goUp = false;
                goDown = false;
            }
            if (e.KeyData == Keys.Right)
            {
                pictureBox2.Image = GAMETARAKAN.Properties.Resources.right;
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
            prevTop = pictureBox2.Location.X;
            prevLeft = pictureBox2.Location.Y;

            if (goUp == true)
            { 
            
                //prevTop = pictureBox2.Location.X;
                //prevLeft = pictureBox2.Location.Y;
                pictureBox2.Top -= playerSpeed;
            }
            if (goDown == true)
            {
                //prevTop = pictureBox2.Location.X;
                //prevLeft = pictureBox2.Location.Y;
                pictureBox2.Top += playerSpeed;
            }
            if (goLeft == true)
            {
                //prevTop = pictureBox2.Location.X;
                //prevLeft = pictureBox2.Location.Y;
                pictureBox2.Left -= playerSpeed;
            }
            if (goRight == true)
            {
                //prevTop = pictureBox2.Location.X;
                //prevLeft = pictureBox2.Location.Y;
                pictureBox2.Left += playerSpeed;
            }

            foreach (Control x in this.Controls)
            {
                if (x is Label)
                {
                    if ((string)x.Tag == "maze")
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
