using cifra_de_cesar.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cifra_de_cesar
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }


        //Navegação
        private void BtEnc_Click(object sender, EventArgs e)
        {
            Encriptar fr = new Encriptar(); //fr é o objeto do formulario encriptar
            fr.ShowDialog();
        }

        private void BtDes_Click(object sender, EventArgs e)
        {
            Desencriptar fr = new Desencriptar();
            fr.ShowDialog();
        }

        private void BtCri_Click(object sender, EventArgs e)
        {
            Criptoanalise fr = new Criptoanalise();
            fr.ShowDialog();
        }
    }
}
