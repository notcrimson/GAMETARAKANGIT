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
    public partial class easy : Form
    {
        public Image a= GAMETARAKAN.Properties.Resources.down;
        Bitmap myBitmap = new Bitmap(GAMETARAKAN.Properties.Resources.maze2);
        bool goUp, goLeft, goRight, goDown;
        bool bitmapCheck=false;
        int playerSpeed = 3;

        public easy()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        //DIRECTION TEST
        public void test_direction() 
        {
            int pl_h = pictureBox1.Height; //player height
            int pl_w = pictureBox1.Width; //player width
            int j_p = 5; //jump pixels

            //checking if player can go in this direction
            bool top_check()
            {
                bool check = false;
                int p_x = pictureBox1.Location.X;
                int p_y = pictureBox1.Location.Y + 5;

                for (int i = p_x; i < (p_x + pl_w); i += j_p)
                {
                    Bitmap myBitmap = new Bitmap(BackgroundImage);
                    Color pxl = myBitmap.GetPixel(i,p_y);
                    if (pxl.A == 255 && pxl.R == 0 && pxl.G == 0 && pxl.B == 0)
                    {
                        break;
                    }
                    check = true;
                }
                return check;
            }

            bool bottom_check()
            {
                bool check = false;
                int p_x = pictureBox1.Location.X;
                int p_y = pictureBox1.Location.Y - pl_h - 5;

                for (int i = p_x; i < (p_x + pl_w); i += j_p)
                {
                    Bitmap myBitmap = new Bitmap(BackgroundImage);
                    Color pxl = myBitmap.GetPixel(i, p_y);
                    if (pxl.A == 255 && pxl.R == 0 && pxl.G == 0 && pxl.B == 0)
                    {
                        break;
                    }
                    check = true;
                }
                return check;
            }

            bool right_check()
            {
                bool check = false;
                int p_x = pictureBox1.Location.X + pl_w + 5;
                int p_y = pictureBox1.Location.Y;

                for (int i = p_y; i > (p_y - pl_h); i -= j_p)
                {
                    Bitmap myBitmap = new Bitmap(BackgroundImage);
                    Color pxl = myBitmap.GetPixel(p_x, i);
                    if (pxl.A == 255 && pxl.R == 0 && pxl.G == 0 && pxl.B == 0)
                    {
                        break;
                    }
                    check = true;
                }
                return check;
            }

            bool left_check()
            {
                bool check = false;
                int p_x = pictureBox1.Location.X - 5;
                int p_y = pictureBox1.Location.Y;

                for (int i = p_y; i > (p_y - pl_h); i -= j_p)
                {
                    Bitmap myBitmap = new Bitmap(BackgroundImage);
                    Color pxl = myBitmap.GetPixel(p_x, i);
                    if (pxl.A == 255 && pxl.R == 0 && pxl.G == 0 && pxl.B == 0)
                    {
                        break;
                    }
                    check = true;
                }
                return check;
            }

        }

        private void getColor_Click(object sender, EventArgs e)
        {
            Bitmap myBitmap = new Bitmap(BackgroundImage);
            Color blackPixel = myBitmap.GetPixel(pictureBox1.Location.X, pictureBox1.Location.Y);
            MessageBox.Show($"{blackPixel.ToString()}");
        }

        private void easy_Load(object sender, EventArgs e)
        {
            Bitmap myBitmap = new Bitmap(BackgroundImage);
        }

        private void easy_KeyDown(object sender, KeyEventArgs e)
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
        }

        private void easy_KeyUp(object sender, KeyEventArgs e)
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

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            Bitmap myBitmap = new Bitmap(BackgroundImage);

            int prevTop = 0;
            int prevLeft = 0;
            Color blackPixel = myBitmap.GetPixel(prevTop, prevLeft);

            prevTop = pictureBox1.Location.X;
            prevLeft = pictureBox1.Location.Y;
            if (goUp == true)
            {
                pictureBox1.Image = GAMETARAKAN.Properties.Resources.up;
                //prevTop = pictureBox1.Location.X;
                //prevLeft = pictureBox1.Location.Y;
                blackPixel = myBitmap.GetPixel(prevTop - pictureBox1.Width, prevLeft);
                pictureBox1.Top -= playerSpeed;
            }
            if (goDown == true)
            {
                pictureBox1.Image = GAMETARAKAN.Properties.Resources.down;
                //prevTop = pictureBox1.Location.X;
                //prevLeft = pictureBox1.Location.Y;
                blackPixel = myBitmap.GetPixel(prevTop + pictureBox1.Width, prevLeft);
                pictureBox1.Top += playerSpeed;
            }
            if (goLeft == true)
            {
                pictureBox1.Image = GAMETARAKAN.Properties.Resources.left;
                //prevTop = pictureBox1.Location.X;
                //prevLeft = pictureBox1.Location.Y;
                blackPixel = myBitmap.GetPixel(prevTop, prevLeft - pictureBox1.Height);
                pictureBox1.Left -= playerSpeed;
            }
            if (goRight == true)
            {
                pictureBox1.Image = GAMETARAKAN.Properties.Resources.right;
                //prevTop = pictureBox1.Location.X;
                //prevLeft = pictureBox1.Location.Y;
                blackPixel = myBitmap.GetPixel(prevTop, prevLeft + pictureBox1.Height);
                pictureBox1.Left += playerSpeed;
            }



            if (blackPixel.A == 255 && blackPixel.R == 0 && blackPixel.G == 0 && blackPixel.B == 0)
            {
                pictureBox1.SetBounds(prevTop, prevLeft, pictureBox1.Width, pictureBox1.Height);
            }


            foreach (Control x in this.Controls)
            {
                if (x is Label)
                {
                    if ((string)x.Tag == "maze")
                    {
                        if (pictureBox1.Bounds.IntersectsWith(x.Bounds))
                        {
                            //pictureBox1.Top = x.Top - pictureBox1.Height;
                        }
                    }
                }
            }
        }
    }
}
