using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SolutionValidarCNPJ
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btValidaCNPJ_Click(object sender, EventArgs e)
        {
            // Declara variaveis
            string mensagem;
            MessageBoxIcon mIcon;

            // Verifica se CNPJ e valido
            if (ValidaDigitoCNPJ.ValidaCNPJ(txtCNPJ.Text))
            {
                mensagem = "CNPJ informado é valido";
                mIcon = MessageBoxIcon.Information;
            }
            else
            {
                mensagem = "CNPJ informado não é valido";
                mIcon = MessageBoxIcon.Error;

            }

            // Exibe mensagem da validade do CNPJ
            MessageBox.Show(mensagem, "Atenção", MessageBoxButtons.OK, mIcon);
            txtCNPJ.Focus();
        }
    }
}
