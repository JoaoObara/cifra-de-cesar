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
    public partial class Criptoanalise : Form
    {
        String texto1;
        String texto2;
        String resultado = ""; // Variavel com lista de resultados
        int t = 10; //número de tentativas
        int k = 1;
        int numChar = 0;
        int palavra = 0;

        public Criptoanalise()
        {
            InitializeComponent();
        }

        private void BtDesencriptar_Click(object sender, EventArgs e)
        {
            //Limpar botão
            texto2 = "";
            resultado = "";
            k = 1;

            //Carregar variaveis
            texto1 = TxDesencriptar.Text;
            numChar = texto1.Length;
            t = Convert.ToInt32(TxT.Text);

            for (int m = 0; m < t; m++)
            {
                //Desencriptar
                for (int i = 0; i < numChar; i++)
                {
                    palavra = Convert.ToInt32(texto1[i]) - k;
                    texto2 += Convert.ToChar(palavra);
                }

                //Exibir
                resultado = resultado + texto2 + "(" + (m + 1) + ") || ";
                TxResult.Text = resultado;

                //Preparar prossimo ciclo
                k++;
                texto2 = null;
            }
        }

        private void TxT_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Somente números
            base.OnKeyPress(e);
            if (e.KeyChar == 8) return;
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxT_Leave(object sender, EventArgs e)
        {
            if (TxT.Text != "") { k = Convert.ToInt32(TxT.Text); }
            else { TxT.Text = "10"; k = 10; };
        }
    }
}
