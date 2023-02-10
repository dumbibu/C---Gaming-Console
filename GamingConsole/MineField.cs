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
    public partial class MineField : Form
    {
        public void RandomCheck()
        {
            while (true)
            {
                if (rndno == rndno2 && rndno == rndno3 && rndno == rndno4)
                {
                    rndno = rnd.Next(0, 24);
                }
                else
                {
                    break;
                }
            }
            while (true)
            {
                if (rndno2 == rndno && rndno2 == rndno3 && rndno2 == rndno4)
                {
                    rndno2 = rnd.Next(0, 24);
                }
                else
                {
                    break;
                }
            }
            while (true)
            {
                if (rndno3 == rndno && rndno3 == rndno2 && rndno3 == rndno4)
                {
                    rndno3 = rnd.Next(0, 24);
                }
                else
                {
                    break;
                }
            }
            while (true)
            {
                if (rndno4 == rndno && rndno4 == rndno2 && rndno4 == rndno3)
                {
                    rndno4 = rnd.Next(0, 24);
                }
                else
                {
                    break;
                }
            }
            
        }
        static Random rnd = new Random();
        int rndno = rnd.Next(0, 24);
        int rndno2 = rnd.Next(0, 24);
        int rndno3 = rnd.Next(0, 24);
        int rndno4 = rnd.Next(0, 24);
        int cond = 2;

        public void ButtonsPlaceHolder(int btno)
        {
            RandomCheck();
            if (Checking()[btno].Text == " " || Checking()[btno].Text == "B")
            {
                return;
            }
            if (btno == rndno || btno == rndno2 || btno == rndno3 || btno == rndno4)
            {
                Checking()[btno].ForeColor = System.Drawing.Color.Red;
                Checking()[btno].Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                Checking()[btno].Text = "B";
                label3.ForeColor = System.Drawing.Color.Red;
                --cond;
                label3.Text = "You have only " + cond + " try left.";
            }
            else
            {
                Checking()[btno].Text = " ";
            }
            if (Chkloss() == true)
            {
                label4.ForeColor = System.Drawing.Color.Red;
                label4.Text = "You lost!!!";
            }
            if (Chkwin() == true)
            {
                Dbox(Chkwin());
            }
        }
        public bool Chkloss()
        {
            if (cond == 0)
            {
                for (int i = 0; i < 25; i++)
                {
                    if (Checking()[i].Text != "B")
                    {
                        Checking()[i].Enabled = false;
                    }
                }
                return true;
            }
            return false;
        }
        public bool Chkwin()
        {
            for (int i = 0; i < 25; i++)
            {
                if (Checking()[i].Text == " " || Checking()[i].Text == "B")
                {
                    if (i == 24)
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
        public void Dbox(bool Popchk)
        {
            if (Popchk == true)
            {
                label1.Text = ("You won.");
                for (int i = 0; i < 25; i++)
                {
                    if (Checking()[i].Text != "B")
                    {
                        Checking()[i].Enabled = false;
                    }
                }
            }
        }
        public Button[] Checking()
        {
            Button[] buttons = { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25 };
            return buttons;
        }
        public MineField()
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
            ButtonsPlaceHolder(9);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            ButtonsPlaceHolder(10);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            ButtonsPlaceHolder(11);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            ButtonsPlaceHolder(12);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            ButtonsPlaceHolder(13);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            ButtonsPlaceHolder(14);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            ButtonsPlaceHolder(15);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            ButtonsPlaceHolder(16);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            ButtonsPlaceHolder(17);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            ButtonsPlaceHolder(18);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            ButtonsPlaceHolder(19);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            ButtonsPlaceHolder(20);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            ButtonsPlaceHolder(21);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            ButtonsPlaceHolder(22);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            ButtonsPlaceHolder(23);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            ButtonsPlaceHolder(24);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            try
            {
                if (Chkwin() == true || Chkloss() == true)
                {
                    MainMenu MenForm = new MainMenu();
                    this.Hide();
                    MenForm.ShowDialog();
                    this.Close();
                }
                else
                {
                    throw new Exception("Game is still in process.\nYou can not return to main menu.");
                }
            }
            catch(Exception msg)
            {
                label1.Text = msg.Message;
            }
        }
    }
}
