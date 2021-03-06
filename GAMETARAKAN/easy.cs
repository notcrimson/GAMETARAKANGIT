﻿using System;
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
        public static Bitmap myBitmap = new Bitmap(GAMETARAKAN.Properties.Resources.maze2);
        bool goUp, goLeft, goRight, goDown;
        int playerSpeed = 3;
        int j_p=3;

        public easy()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        //DIRECTION TEST




        private void getColor_Click(object sender, EventArgs e)
        {
            Color blackPixel = myBitmap.GetPixel(pictureBox1.Location.X, pictureBox1.Location.Y);
            MessageBox.Show($"{blackPixel.ToString()}");
        }

        private void easy_Load(object sender, EventArgs e)
        {
          
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"X:{pictureBox1.Location.X} \n Y:{pictureBox1.Location.Y}");
        }



        List<int> listTopCheck = new List<int>();
        public bool top_check()
        {
            bool check = false;
            int p_x = pictureBox1.Location.X;
            int p_y = pictureBox1.Location.Y - 5;


            for (int i = p_x; i < (p_x + pictureBox1.Width); i += j_p)
            {
                listTopCheck.Add(i);
                //Color pxl = myBitmap.GetPixel(i, p_y);
                //if (pxl.R != 255 && pxl.G != 255 && pxl.B != 255)
                //{
                //    break;
                //}
                //check = true;
            }
            foreach (var t in listTopCheck)
            {
                Color pxl = myBitmap.GetPixel(t, p_y);
                if (pxl.R != 255 && pxl.G != 255 && pxl.B != 255)
                {
                    break;
                }
            }
            return check;
        }
        public bool bottom_check()
        {
            bool check = false;
            int p_x = pictureBox1.Location.X;
            int p_y = pictureBox1.Location.Y + pictureBox1.Height + 5;

            for (int i = p_x; i < (p_x + pictureBox1.Width); i += j_p)
            {
                Color pxl = myBitmap.GetPixel(i, p_y);
                if (pxl.R != 255 && pxl.G != 255 && pxl.B != 255)
                {
                    break;
                }
                check = true;
            }
            return check;
        }
        public bool right_check()
        {
            bool check = false;
            int p_x = pictureBox1.Location.X + pictureBox1.Width + 5;
            int p_y = pictureBox1.Location.Y;

            for (int i = p_y; i < (p_y + pictureBox1.Height); i += j_p)
            {
                Color pxl = myBitmap.GetPixel(p_x, i);
                if (pxl.R != 255 && pxl.G != 255 && pxl.B != 255)
                {
                    break;
                }
                check = true;
            }
            return check;
        }

        public bool left_check()
        {
            bool check = false;
            int p_x = pictureBox1.Location.X - 5;
            int p_y = pictureBox1.Location.Y;

            for (int i = p_y; i < (p_y + pictureBox1.Height); i += j_p)
            {
                Color pxl = myBitmap.GetPixel(p_x, i);
                if (pxl.R != 255 && pxl.G != 255 && pxl.B != 255)
                {
                    break;
                }
                check = true;
            }
            return check;
        }






        private void easy_KeyDown(object sender, KeyEventArgs e)
        {
            //testD.top_check();
            //var testD = new test_direction();
            if (e.KeyData == Keys.Up)
            {
                //timer1.Enabled = true;
                top_check();
                goUp = true;
                goLeft = false;
                goRight = false;

            }

            if (e.KeyData == Keys.Down)
            {
                //timer1.Enabled = true;
                bottom_check();
                goDown = true;
                goLeft = false;
                goRight = false;
            }

            if (e.KeyData == Keys.Left)
            {
                //timer1.Enabled = true;
                left_check();
                goLeft = true;
                goUp = false;
                goDown = false;
            }

            if (e.KeyData == Keys.Right)
            {
                //timer1.Enabled = true;
                right_check();
                goRight = true;
                goUp = false;
                goDown = false;
            }
        }

        private void easy_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Up)
            {
                //timer1.Enabled = false;
                goUp = false;
            }
            if (e.KeyData == Keys.Down)
            {
                //timer1.Enabled = false;
                goDown = false;
            }
            if (e.KeyData == Keys.Left)
            {
                //timer1.Enabled = false;
                goLeft = false;
            }
            if (e.KeyData == Keys.Right)
            {
                //timer1.Enabled = false;
                goRight = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //int prevTop = 0;
            //int prevLeft = 0;

            //Color blackPixel = myBitmap.GetPixel(prevTop, prevLeft);

            //prevTop = pictureBox1.Location.X;
            //prevLeft = pictureBox1.Location.Y;

            if (goUp == true)
            {
                
                if (top_check()==true)
                {
                    pictureBox1.Image = GAMETARAKAN.Properties.Resources.up;
                    //blackPixel = myBitmap.GetPixel(prevTop - pictureBox1.Width, prevLeft);
                    pictureBox1.Top -= playerSpeed;
                }
            }
            if (goDown == true)
            {
                
                if (bottom_check()==true)
                {
                    pictureBox1.Image = GAMETARAKAN.Properties.Resources.down;
                    //blackPixel = myBitmap.GetPixel(prevTop + pictureBox1.Width, prevLeft);
                    pictureBox1.Top += playerSpeed;
                }
            }
            if (goLeft == true)
            {
               
                if (left_check() == true)
                {
                    pictureBox1.Image = GAMETARAKAN.Properties.Resources.left;
                    //blackPixel = myBitmap.GetPixel(prevTop, prevLeft - pictureBox1.Height);
                    pictureBox1.Left -= playerSpeed;
                }
            }
            if (goRight == true)
            {
                
                if (right_check()==true)
                {
                    pictureBox1.Image = GAMETARAKAN.Properties.Resources.right;
                    //blackPixel = myBitmap.GetPixel(prevTop, prevLeft + pictureBox1.Height);
                    pictureBox1.Left += playerSpeed;
                }
            }



            //if (blackPixel.A == 255 && blackPixel.R == 0 && blackPixel.G == 0 && blackPixel.B == 0)
            //{
            //    pictureBox1.SetBounds(prevTop, prevLeft, pictureBox1.Width, pictureBox1.Height);
            //}


            //foreach (Control x in this.Controls)
            //{
            //    if (x is Label)
            //    {
            //        if ((string)x.Tag == "maze")
            //        {
            //            if (pictureBox1.Bounds.IntersectsWith(x.Bounds))
            //            {
            //                //pictureBox1.Top = x.Top - pictureBox1.Height;
            //            }
            //        }
            //    }
            //}
            Invalidate();
        }
    }
}

