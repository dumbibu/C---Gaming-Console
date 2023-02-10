using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GamingConsole
{
    public partial class TicTacToeMenu : Form
    {
        public TicTacToeMenu()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PvPTicTacToe pvpttt = new PvPTicTacToe();
            this.Hide();
            pvpttt.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PvETicTacToe pvettt = new PvETicTacToe();
            this.Hide();
            pvettt.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MainMenu MenForm = new MainMenu();
            this.Hide();
            MenForm.ShowDialog();
            this.Close();
        }
        
    }
}
