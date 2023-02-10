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
    public partial class PvPTicTacToe : Form, TicTacToeInterface
    {
        int cond = 1;
        public void ButtonsPlaceHolder(int butno)
        {
            if (Buttons()[butno].Text == "O" || Buttons()[butno].Text == "X")
            {
                return;
            }
            else if (Chkwin() == true)
            {
                return;
            }
            if (cond % 2 == 0)
            {
                Buttons()[butno].ForeColor = System.Drawing.Color.Blue;
                Buttons()[butno].Text = "O";
                label1.Text = "Player 1 Turn";
            }
            else
            {
                Buttons()[butno].ForeColor = System.Drawing.Color.Red;
                Buttons()[butno].Text = "X";
                label1.Text = "Player 2 Turn";
            }
            cond++;
            if (Chkwin() == true)
            {
                Dbox(Chkwin());
                return;
            }
            else if (Chktie() == true)
            {
                TieBox(Chktie());
                return;
            }
        }
        public Button[] Buttons()
        {
            Button[] buttons = { button1, button2, button3, button4, button5, button6, button7, button8, button9 };
            return buttons;
        }
        public bool Chkwin()
        {
            //horizontal    
            if (button1.Text.Equals(button2.Text) && button2.Text.Equals(button3.Text))
            {
                return true;
            }
            else if (button4.Text == button5.Text && button5.Text == button6.Text)
            {
                return true;
            }
            else if (button7.Text == button8.Text && button8.Text == button9.Text)
            {
                return true;
            }
            //vertical
            if (button1.Text == button4.Text && button4.Text == button7.Text)
            {
                return true;
            }
            else if (button2.Text == button5.Text && button5.Text == button8.Text)
            {
                return true;
            }
            else if (button3.Text == button6.Text && button6.Text == button9.Text)
            {
                return true;
            }
            //diagonal
            if (button1.Text == button5.Text && button5.Text == button9.Text)
            {
                return true;
            }
            else if (button3.Text == button5.Text && button5.Text == button7.Text)
            {
                return true;
            }
            return false;
        }
        public bool Chktie()
        {
            for (int i = 0; i < 9; i++)
            {
                if (Buttons()[i].Text == "O" || Buttons()[i].Text == "X")
                {
                    if (i == 8)
                    {
                        return true;
                    }
                    continue;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
        public void Dbox(bool Popupchk)
        {
            if (Popupchk == true)
            {
                if (cond % 2 == 0)
                {
                    label1.Text = ("Player 1 won");
                }
                else if (cond % 2 != 0)
                {
                    label1.Text = ("Player 2 won");
                }
            }
        }
        public void TieBox(bool Popupchk)
        {
            if (Popupchk == true)
            {
                label1.Text = ("It's a TIE!!!");
            }

        }
        public PvPTicTacToe()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ButtonsPlaceHolder(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ButtonsPlaceHolder(1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ButtonsPlaceHolder(2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ButtonsPlaceHolder(3);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ButtonsPlaceHolder(4);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ButtonsPlaceHolder(5);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ButtonsPlaceHolder(6);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ButtonsPlaceHolder(7);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ButtonsPlaceHolder(8);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                if (Chkwin() == true)
                {
                    MainMenu MenForm = new MainMenu();
                    this.Hide();
                    MenForm.ShowDialog();
                    this.Close();
                }
                else
                {
                    throw new Exception("Game is still in process. You can not return to main menu.");
                }
            }
            catch (Exception msg)
            {
                WinningCondition.Text = msg.Message;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
