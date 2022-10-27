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
    public partial class Desencriptar : Form
    {
        String texto1;
        String texto2;
        int k = 3;
        int numChar = 0;
        int palavra = 0;

        public Desencriptar()
        {
            InitializeComponent();
        }

        private void BtDesencriptar_Click(object sender, EventArgs e)
        {
            //Limpar botão
            texto2 = "";

            //Carregar variaveis
            texto1 = TxDesencriptar.Text;
            numChar = texto1.Length;

            //Encriptar
            for (int i = 0; i < numChar; i++)
            {
                palavra = Convert.ToInt32(texto1[i]) - k;
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
