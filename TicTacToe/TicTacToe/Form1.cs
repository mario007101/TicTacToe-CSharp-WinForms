using System;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int pocitadlo = 0;
        string[,] Pole = new string[3, 3];
        string Word;
        bool Vyhodnot = false;
        bool Vyhodnot2 = false;
        bool Vyhodnot3 = false;
        private void button1_Click(object sender, EventArgs e)
        {
            pocitadlo++;

            if ((pocitadlo % 2) == 0)
            {
                button1.Text = "X";
            }
            else
            {
                button1.Text = "O";
            }

            //Priradenie textu
            button1.Enabled = false;
            Word = button1.Text;
            Pole[0, 0] = Word;

            //Vyhodnotenie
            ZistenieFunkcie(Pole, out Vyhodnot, out Vyhodnot2, out Vyhodnot3);
            Vyhodnotenie(Vyhodnot, Vyhodnot2, Vyhodnot3, Pole);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            pocitadlo++;
            if ((pocitadlo % 2) == 0)
            {
                button2.Text = "X";
            }
            else button2.Text = "O";

            button2.Enabled = false;
            Word = button2.Text;
            Pole[0, 1] = Word;

            ZistenieFunkcie(Pole, out Vyhodnot, out Vyhodnot2, out Vyhodnot3);
            Vyhodnotenie(Vyhodnot, Vyhodnot2, Vyhodnot3, Pole);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pocitadlo++;
            if ((pocitadlo % 2) == 0)
            {
                button3.Text = "X";
            }
            else button3.Text = "O";

            button3.Enabled = false;
            Word = button3.Text;
            Pole[0, 2] = Word;

            ZistenieFunkcie(Pole, out Vyhodnot, out Vyhodnot2, out Vyhodnot3);
            Vyhodnotenie(Vyhodnot, Vyhodnot2, Vyhodnot3, Pole);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pocitadlo++;
            if ((pocitadlo % 2) == 0)
            {
                button6.Text = "X";
            }
            else button6.Text = "O";

            button6.Enabled = false;
            Word = button6.Text;
            Pole[1, 2] = Word;

            ZistenieFunkcie(Pole, out Vyhodnot, out Vyhodnot2, out Vyhodnot3);
            Vyhodnotenie(Vyhodnot, Vyhodnot2, Vyhodnot3, Pole);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pocitadlo++;
            if ((pocitadlo % 2) == 0)
            {
                button5.Text = "X";
            }
            else button5.Text = "O";

            button5.Enabled = false;
            Word = button5.Text;
            Pole[1, 1] = Word;

            ZistenieFunkcie(Pole, out Vyhodnot, out Vyhodnot2, out Vyhodnot3);
            Vyhodnotenie(Vyhodnot, Vyhodnot2, Vyhodnot3, Pole);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pocitadlo++;
            if ((pocitadlo % 2) == 0)
            {
                button4.Text = "X";
            }
            else button4.Text = "O";

            button4.Enabled = false;
            Word = button4.Text;
            Pole[1, 0] = Word;

            ZistenieFunkcie(Pole, out Vyhodnot, out Vyhodnot2, out Vyhodnot3);
            Vyhodnotenie(Vyhodnot, Vyhodnot2, Vyhodnot3, Pole);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            pocitadlo++;
            if ((pocitadlo % 2) == 0)
            {
                button9.Text = "X";
            }
            else button9.Text = "O";

            button9.Enabled = false;
            Word = button9.Text;
            Pole[2, 2] = Word;

            ZistenieFunkcie(Pole, out Vyhodnot, out Vyhodnot2, out Vyhodnot3);
            Vyhodnotenie(Vyhodnot, Vyhodnot2, Vyhodnot3, Pole);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            pocitadlo++;
            if ((pocitadlo % 2) == 0)
            {
                button8.Text = "X";
            }
            else button8.Text = "O";

            button8.Enabled = false;
            Word = button8.Text;
            Pole[2, 1] = Word;

            ZistenieFunkcie(Pole, out Vyhodnot, out Vyhodnot2, out Vyhodnot3);
            Vyhodnotenie(Vyhodnot, Vyhodnot2, Vyhodnot3, Pole);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            pocitadlo++;
            if ((pocitadlo % 2) == 0)
            {
                button7.Text = "X";
            }
            else button7.Text = "O";

            button7.Enabled = false;
            Word = button7.Text;
            Pole[2, 0] = Word;

            ZistenieFunkcie(Pole, out Vyhodnot, out Vyhodnot2, out Vyhodnot3);
            Vyhodnotenie(Vyhodnot, Vyhodnot2, Vyhodnot3, Pole);
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            //Application.Restart();     //Tiež možnosť

            pocitadlo = 0;

            //Vymazanie textu + zapnutie tlačidiel
            for (int i = 1; i < 10; i++)
            {
                this.Controls["button" + i].Text = " ";
            }

            for (int i = 1; i < 10; i++)
            {
                this.Controls["button" + i].Enabled = true;
            }

            //Nastavenie hodnôt poľa na žiadne
            for (int i = 0; i < 3; i++)
            {
                for (int c = 0; c < 3; c++)
                {
                    Pole[i, c] = null;
                }
            }
        }
        private void ZistenieFunkcie(string[,] Pole, out bool Vyhodnot, out bool Vyhodnot2, out bool Vyhodnot3)
        {
            Vyhodnot = false;
            Vyhodnot2 = false;
            Vyhodnot3 = false;

            //riadky
            if ((Vyhodnot != true) || (Vyhodnot2 != true))
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 1; j++)
                    {
                        if (((Pole[i, j]) == "X") && ((Pole[i, j + 1]) == "X") && ((Pole[i, j + 2]) == "X"))
                        {
                            Vyhodnot = true;
                        }
                        if (((Pole[i, j]) == "O") && ((Pole[i, j + 1]) == "O") && ((Pole[i, j + 2]) == "O"))
                        {
                            Vyhodnot2 = true;
                        }
                    }
                }

                //stĺpce
                int index = 0, index2 = 1, index3 = 2;
                int pocitadlo = 0;
                for (int i = 0; i < 3; i++)
                {
                    for (int c = 0; c < 3; c++)
                    {
                        if (((Pole[index, c]) == "X") && ((Pole[index2, c]) == "X") && ((Pole[index3, c]) == "X"))
                        {
                            Vyhodnot = true;
                            pocitadlo++;
                        }
                        if (((Pole[index, c]) == "O") && ((Pole[index2, c]) == "O") && ((Pole[index3, c]) == "O"))
                        {
                            Vyhodnot2 = true;
                            pocitadlo++;
                        }
                    }
                }

                //hlavná diagonála
                if (((Pole[0, 0]) == "X") && ((Pole[1, 1]) == "X") && ((Pole[2, 2]) == "X"))
                {
                    Vyhodnot = true;
                }
                if (((Pole[0, 0]) == "O") && ((Pole[1, 1]) == "O") && ((Pole[2, 2]) == "O"))
                {
                    Vyhodnot2 = true;
                }

                //sekundárna diagonála
                if (((Pole[0, 2]) == "X") && ((Pole[1, 1]) == "X") && ((Pole[2, 0]) == "X"))
                {
                    Vyhodnot = true;
                }
                if (((Pole[0, 2]) == "O") && ((Pole[1, 1]) == "O") && ((Pole[2, 0]) == "O"))
                {
                    Vyhodnot2 = true;
                }
            }

            //Remíza
            if(pocitadlo==9)
            {
                if ((Vyhodnot == false) && (Vyhodnot2 == false)) 
                 {
                    Vyhodnot3 = true;
                }
            }
                                     
        }

        static void Vyhodnotenie(bool Vyhodnot, bool Vyhodnot2, bool Vyhodnot3, string[,] Pole)
        {

            if (Vyhodnot == true)
            {
                MessageBox.Show("Vyhral hráč X");
            }

            if (Vyhodnot2 == true)
            {
                MessageBox.Show("Vyhral hráč O");
            }

            if (Vyhodnot3 == true)
            {
                MessageBox.Show("Remíza");           
            }           
        }
    }
}
