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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void NewGame_Click(object sender, EventArgs e)
        {
            Hide();
            Game game = new Game();
            game.FormClosed += (s, args) => this.Close();
            game.Show();
        }

        private void NewGame_MouseHover(object sender, EventArgs e)
        {
            NewGame.BackColor = Color.LightGray;
            NewGame.BorderStyle = BorderStyle.Fixed3D;
        }

        private void NewGame_MouseLeave(object sender, EventArgs e)
        {
            NewGame.BackColor = Color.White;
            NewGame.BorderStyle = BorderStyle.None;
        }


        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Exit_MouseHover(object sender, EventArgs e)
        {
            Exit.BackColor = Color.LightGray;
            Exit.BorderStyle = BorderStyle.Fixed3D;
        }

        private void Exit_MouseLeave(object sender, EventArgs e)
        {
            Exit.BackColor = Color.White;
            Exit.BorderStyle = BorderStyle.None;
        }
    }
}
