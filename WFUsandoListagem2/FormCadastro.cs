using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFUsandoListagem2
{
    public partial class FormCadastro : Form
    {
        public FormCadastro()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string Login = txtLogin.Text;

            if (Login == "")
            {
                MessageBox.Show("Insira um Login");
                return;
            }

            else
            {
                Login = txtLogin.Text;
            }

            string Senha = txtSenha.Text;
            if (Senha == "")
            {
                MessageBox.Show("Insira uma senha");
                return;
            }

            else
            {
                Senha = txtSenha.Text;
            }

            string ConfirmarSenha = txtConfirmarSenha.Text;
            if (ConfirmarSenha != Senha)
            {
                MessageBox.Show("Senha não compatível");
                return;
            }

            else
            {
                ConfirmarSenha = txtConfirmarSenha.Text;
            }

            MessageBox.Show("Cadastro realizado com sucesso!", "Info",
              MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        
    }
}
