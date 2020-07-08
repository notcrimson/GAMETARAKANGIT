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
            Game game = new Game();
            Hide();
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

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
