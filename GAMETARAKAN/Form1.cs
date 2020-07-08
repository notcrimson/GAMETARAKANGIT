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

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Up)
            {
                if (goUp == false)
                {
                    pictureBox2.Image = GAMETARAKAN.Properties.Resources.up;
                }
                goUp = true;
                goLeft = false;
                goRight = false;

            }
            else if (e.KeyData == Keys.Down)
            {
                if (goDown == false)
                {
                    pictureBox2.Image = GAMETARAKAN.Properties.Resources.down;
                }
                goDown = true;
                goLeft = false;
                goRight = false;
            }
            else if (e.KeyData == Keys.Left)
            {
                if (goLeft == false)
                {
                    pictureBox2.Image = GAMETARAKAN.Properties.Resources.left;
                }
                goLeft = true;
                goUp = false;
                goDown = false;
            }
            else if (e.KeyData == Keys.Right)
            {
                if (goRight == false)
                {
                    pictureBox2.Image = GAMETARAKAN.Properties.Resources.right;
                }
                goRight = true;
                goUp = false;
                goDown = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            prevTop = pictureBox2.Location.X;
            prevLeft = pictureBox2.Location.Y;

            if (goUp == true)
            {
                pictureBox2.Top -= playerSpeed;
            }
            else if (goDown == true)
            {
                pictureBox2.Top += playerSpeed;
            }
            else if (goLeft == true)
            {
                pictureBox2.Left -= playerSpeed;
            }
            else if (goRight == true)
            {
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
                            pictureBox2.SetBounds(prevTop, prevLeft, pictureBox2.Width, pictureBox2.Height);
                            break;
                        }
                    }
                    else if ((string)x.Tag == "finish")
                    {
                        //do finish sign with time and leave to menu
                        break;
                    }
                }
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Up)
            {
                goUp = false;
            }
            else if (e.KeyData == Keys.Down)
            {
                goDown = false;
            }
            else if (e.KeyData == Keys.Left)
            {
                goLeft = false;
            }
            else if (e.KeyData == Keys.Right)
            {
                goRight = false;
            }
        }
    }
}
