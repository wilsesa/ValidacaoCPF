using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ValidacaoCPF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            string NumeroCPF = txtCPF.Text;
            if(NumeroCPF.Length < 11)
            {
                MessageBox.Show("Digite o CPF novamente");
                txtCPF.Text = string.Empty;
            }

            if (ValidacaoCPF.Verificar(NumeroCPF))
            {
                label1.Text = "CPF VÁLIDO";
            }
            else
            {
                label1.Text = "CPF INVÁLIDO";
            }
        }
    }
}
