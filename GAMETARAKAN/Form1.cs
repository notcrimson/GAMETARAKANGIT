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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int prevTop = 0;
            int prevLeft = 0;
            if (e.KeyData == Keys.Up)
            {
                prevTop = pictureBox2.Location.X;
                prevLeft = pictureBox2.Location.Y;
                pictureBox2.Top = pictureBox2.Top - 3;
            }
            if (e.KeyData == Keys.Down)
            {
                prevTop = pictureBox2.Location.X;
                prevLeft = pictureBox2.Location.Y;
                pictureBox2.Top = pictureBox2.Top + 3;
            }
            if (e.KeyData == Keys.Left)
            {
                prevTop = pictureBox2.Location.X;
                prevLeft = pictureBox2.Location.Y;
                pictureBox2.Left = pictureBox2.Left - 3;
            }
            if (e.KeyData == Keys.Right)
            {
                prevTop = pictureBox2.Location.X;
                prevLeft = pictureBox2.Location.Y;
                pictureBox2.Left = pictureBox2.Left + 3;
            }
            foreach (Label lbl in this.Controls.OfType<Label>())
            {
                if (lbl.Tag.ToString() == "maze")
                {
                    if (pictureBox2.Bounds.IntersectsWith((lbl as Label).Bounds)) // pictureBox2.Bounds.IntersectsWith(label1.Bounds)
                    {
                        pictureBox2.SetBounds(prevTop, prevLeft, pictureBox2.Width, pictureBox2.Height);
                    }
                }

            }
        }
    }
}
