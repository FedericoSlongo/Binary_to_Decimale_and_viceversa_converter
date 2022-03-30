using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversione_da_e_verso_binario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void converti_Click(object sender, EventArgs e)
        {
            int[] numeri_binari, numeri_decimali;
            int numero_convertito = 0, numero;
            string risultato = "", string_temp = "";

            if (txb_binario.Text == "" && txb_decimale.Text == "")
            {
                MessageBox.Show("Inserire un valore", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (txb_binario.Text == "")
            {
                numeri_decimali = new int[txb_decimale.Text.Length];
                numero = Convert.ToInt32(txb_decimale.Text);

                for (int i = 0; numero > 0; i++)
                {
                    risultato += numero % 2;
                    numero /= 2;
                }
                for (int i = risultato.Length - 1; i >= 0; i--)
                {
                    string_temp += risultato[i];
                }
                risultato = string_temp;
                txb_binario.Text += $"{risultato}";
            } else
            {
                numeri_binari = new int[txb_binario.Text.Length];
                for (int i = 0; i < txb_binario.Text.Length; i++)
                {
                    if (txb_binario.Text[i] == '0')
                    {
                        numeri_binari[i] = 0;
                    }
                    else
                    {
                        numeri_binari[i] = 1;
                    }
                }

                for (int i = 0; i < numeri_binari.Length; i++)
                {
                    if (numeri_binari[i] != 0)
                    {
                        numero_convertito += (int)Math.Pow(2, numeri_binari.Length-1-i);
                    }
                }

                txb_decimale.Text = $"{numero_convertito}";
            }
        }

        private void one_Click(object sender, EventArgs e)
        {
            txb_binario.Text += "1";
        }

        private void zero_Click(object sender, EventArgs e)
        {
            txb_binario.Text += "0";
        }

        private void reset_Click(object sender, EventArgs e)
        {
            txb_binario.Text = "";
            txb_decimale.Text = "";
        }

        private void del_Click(object sender, EventArgs e)
        {
            if (txb_binario.Text == "" && txb_decimale.Text == "")
            {
                MessageBox.Show("Inserire un valore", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (txb_binario.Text == "")
            {
                string temp = txb_decimale.Text, temp_2 = "";
                for (int i = 0; i < (txb_decimale.Text.Length - 1); i++)
                {
                    temp_2 += temp[i];
                }
                txb_decimale.Text = temp_2;
            }
            else
            {
                string temp = txb_binario.Text, temp_2 = "";
                for (int i = 0; i < (txb_binario.Text.Length - 1); i++)
                {
                    temp_2 += temp[i];
                }
                txb_binario.Text = temp_2;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            if (rnd.Next(0,100) > 30)
            {
                pictureBox1.Image = Image.FromFile(@"blank_tradingcard.jpg");
            }
            else if (rnd.Next(0, 100) > 30)
            {
                pictureBox1.Image = Image.FromFile(@"33e7d0e2bc57e86475806c7a18084d45.jpg");
            }
            else
            {
                pictureBox1.Image = Image.FromFile(@"blank_tradingcard (1).jpg");
            }
        }
    }
}
