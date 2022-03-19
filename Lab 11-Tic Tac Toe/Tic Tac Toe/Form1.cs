using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            player1WinCountBox.Text = Convert.ToString(0);

            player2WinCountBox.Text = Convert.ToString(0);

            DrawCountBox.Text = Convert.ToString(0);
        }

        public int i = 0;

        public int flag = 0;

        public int player1win = 0, player2win = 0, draw = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            i++;

            if (i % 2 == 1)
            {
                button1.Text = "X";
            }

            else
            {
                button1.Text = "O";
            }

            check_win();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            i++;

            if (i % 2 == 1)
            {
                button2.Text = "X";
            }

            else
            {
                button2.Text = "O";
            }

            check_win();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            i++;

            if (i % 2 == 1)
            {
                button3.Text = "X";
            }

            else
            {
                button3.Text = "O";
            }

            check_win();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            i++;

            if (i % 2 == 1)
            {
                button4.Text = "X";
            }

            else
            {
                button4.Text = "O";
            }

            check_win();


        }

        private void button5_Click(object sender, EventArgs e)
        {
            i++;

            if (i % 2 == 1)
            {
                button5.Text = "X";
            }

            else
            {
                button5.Text = "O";
            }

            check_win();


        }

        private void button6_Click(object sender, EventArgs e)
        {
            i++;

            if (i % 2 == 1)
            {
                button6.Text = "X";
            }

            else
            {
                button6.Text = "O";
            }

            check_win();


        }

        private void button7_Click(object sender, EventArgs e)
        {
            i++;

            if (i % 2 == 1)
            {
                button7.Text = "X";
            }

            else
            {
                button7.Text = "O";
            }

            check_win();


        }

        

        private void button8_Click(object sender, EventArgs e)
        {
            i++;

            if (i % 2 == 1)
            {
                button8.Text = "X";
            }

            else
            {
                button8.Text = "O";
            }

            check_win();


        }

        private void button9_Click(object sender, EventArgs e)
        {
            i++;

            if (i % 2 == 1)
            {
                button9.Text = "X";
            }

            else
            {
                button9.Text = "O";
            }

            check_win();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void PlayAgainButton_Click(object sender, EventArgs e)
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";

            i = 0;
        }

        public void check_win()
        {
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
            {
                MessageBox.Show("PLAYER1 WON");
                flag = 1;
                player1win++;

                player1WinCountBox.Text = Convert.ToString(player1win);
            }

            else if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
            {
                MessageBox.Show("PLAYER1 WON");
                flag = 1;
                player1win++;

                player1WinCountBox.Text = Convert.ToString(player1win);
            }

            else if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
            {
                MessageBox.Show("PLAYER1 WON");
                flag = 1;
                player1win++;

                player1WinCountBox.Text = Convert.ToString(player1win);
            }

            else if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
            {
                MessageBox.Show("PLAYER1 WON");
                flag = 1;
                player1win++;

                player1WinCountBox.Text = Convert.ToString(player1win);
            }

            else if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
            {
                MessageBox.Show("PLAYER1 WON");
                flag = 1;
                player1win++;

                player1WinCountBox.Text = Convert.ToString(player1win);
            }

            else if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
            {
                MessageBox.Show("PLAYER1 WON");
                flag = 1;
                player1win++;

                player1WinCountBox.Text = Convert.ToString(player1win);
            }

            else if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
            {
                MessageBox.Show("PLAYER1 WON");
                flag = 1;
                player1win++;

                player1WinCountBox.Text = Convert.ToString(player1win);
            }

            else if (button7.Text == "X" && button5.Text == "X" && button3.Text == "X")
            {
                MessageBox.Show("PLAYER1 WON");
                flag = 1;
                player1win++;

                player1WinCountBox.Text = Convert.ToString(player1win);
            }

            else if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
            {
                MessageBox.Show("PLAYER2 WON");
                flag = 1;
                player2win++;

                player2WinCountBox.Text = Convert.ToString(player2win);
            }

            else if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
            {
                MessageBox.Show("PLAYER2 WON");
                flag = 1;
                player2win++;

                player2WinCountBox.Text = Convert.ToString(player2win);
            }

            else if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
            {
                MessageBox.Show("PLAYER2 WON");
                flag = 1;
                player2win++;

                player2WinCountBox.Text = Convert.ToString(player2win);
            }

            else if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
            {
                MessageBox.Show("PLAYER2 WON");
                flag = 1;
                player2win++;

                player2WinCountBox.Text = Convert.ToString(player2win);
            }

            else if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
            {
                MessageBox.Show("PLAYER2 WON");
                flag = 1;
                player2win++;

                player2WinCountBox.Text = Convert.ToString(player2win);
            }

            else if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
            {
                MessageBox.Show("PLAYER2 WON");
                flag = 1;
                player2win++;

                player2WinCountBox.Text = Convert.ToString(player2win);
            }

            else if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
            {
                MessageBox.Show("PLAYER2 WON");
                flag = 1;
                player2win++;

                player2WinCountBox.Text = Convert.ToString(player2win);
            }

            else if (button7.Text == "O" && button5.Text == "O" && button3.Text == "O")
            {
                MessageBox.Show("PLAYER2 WON");
                flag = 1;
                player2win++;

                player2WinCountBox.Text = Convert.ToString(player2win);
            }

            else if (i % 9 == 0 )
            {
                MessageBox.Show("It's a DRAW!");
                draw++;

                DrawCountBox.Text = Convert.ToString(draw);
            }
        }
    }
}
