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
    public partial class Game : Form
    {
        bool goUp, goDown, goLeft, goRight;
        int playerSpeed = 3; //на сколько пикселей перемещается игрок
        int prevTop = 0;
        int prevLeft = 0;
        int seconds = 0;
        int minutes = 0;
        public static string endTime;
        Menu menu = new Menu();
        public Game()
        {
            InitializeComponent();
        }

        private void Game_Load(object sender, EventArgs e)
        {
            seconds = 0;
            minutes = 0;
            pictureBox2.Location = new Point (25,420);
            Time.Enabled = true;
        }

        private void Leave_MouseHover(object sender, EventArgs e)
        {
            LeaveGame.BackColor = Color.LightGray;
            LeaveGame.BorderStyle = BorderStyle.Fixed3D;
        }

        private void Leave_MouseLeave(object sender, EventArgs e)
        {
            LeaveGame.BackColor = Color.White;
            LeaveGame.BorderStyle = BorderStyle.None;
        }

        private void LeaveGame_Click(object sender, EventArgs e)
        {
            Hide();
            menu.FormClosed += (s, args) => this.Close();
            menu.Show();
        }

        private void Clock(object sender, EventArgs e)
        {
            if (pictureBox2.Bounds.IntersectsWith(Finish.Bounds))
            {
                Time.Enabled = false;
            }
            else
            {
                seconds++;
            }
            if (seconds >= 60)
            {
                minutes++;
                seconds = 0;
            }
            if (seconds >= 10)
            {
                Clock_label.Text = $"{minutes.ToString()}:{seconds.ToString()}";
            }
            else
            {
                Clock_label.Text = $"{minutes.ToString()}:0{seconds.ToString()}";
            }
            if (minutes>=60)
            {
                Time.Enabled = false;
                endTime = $"Ты просидел тут уже час...";
                var result = MessageBox.Show(endTime, "Конец игры", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
                if (result == DialogResult.Cancel)
                {
                    Hide();
                    menu.FormClosed += (s, args) => this.Close();
                    menu.Show();
                }
                else
                {
                    Game_Load(sender, e);
                }
            }
        }

        private void Game_KeyDown(object sender, KeyEventArgs e)
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
                }
            }

            if (pictureBox2.Bounds.IntersectsWith(Finish.Bounds))
            {
                timer1.Enabled = false;
                //do finish sign with time and leave to menu
                endTime = $"Ваше время: {minutes.ToString()}:{seconds.ToString()}";
                var result = MessageBox.Show(endTime, "Конец игры", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    Hide();
                    menu.FormClosed += (s, args) => this.Close();
                    menu.Show();
                }
            }
        }

        private void Game_KeyUp(object sender, KeyEventArgs e)
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
