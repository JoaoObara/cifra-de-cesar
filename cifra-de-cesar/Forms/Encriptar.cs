using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cifra_de_cesar.Forms
{
    public partial class Encriptar : Form
    {
        String texto1;
        String texto2;
        int k = 3;
        int numChar = 0;
        int palavra = 0;

        public Encriptar()
        {
            InitializeComponent();
        }

        private void BtEncriptar_Click(object sender, EventArgs e)
        {
            //Limpar botão
            texto2 = "";

            //Carregar variaveis
            texto1 = TxEncriptar.Text;
            numChar = texto1.Length;

            //Encriptar
            for (int i= 0; i < numChar; i++)
            {
                palavra = Convert.ToInt32(texto1[i]) + k;// OBS:  | A = 65 ; Z = 90 | a = 97; z = 122

                //Tirar caracteres especiais
                if (palavra >=91 && palavra <=96)
                {
                    palavra = (palavra - 90) + 64; 
                }
                else if (palavra >= 123 && palavra <= 145)
                {
                    palavra = (palavra - 122) + 96;
                }

                texto2 += Convert.ToChar(palavra); 
            }

            //Exibir
            TxResult.Text = texto2;
        }

        private void TxK_Leave(object sender, EventArgs e)
        {
            if (TxK.Text != "") { k = Convert.ToInt32(TxK.Text); }
            else { TxK.Text = "3"; k = 3; };
        }

        private void TxK_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Somente números
            base.OnKeyPress(e);
            if (e.KeyChar == 8) return;
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
