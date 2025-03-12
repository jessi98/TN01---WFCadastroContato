using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TN01___WFCadastroContato
{
    public partial class FormCadastrarContato : Form
    {
        public FormCadastrarContato()
        {
            InitializeComponent();
        }

        
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string Nome = txtNome.Text;

            if (Nome == "")
            {
                MessageBox.Show("Falta preencher o nome!");
            }

            else
            {
                Nome = txtNome.Text;
                return;
            }

            string Sobrenome = txtSobrenome.Text;

            if (Sobrenome == "")
            {
                MessageBox.Show("Falta preencher o sobrenome!");
            }
            else
            {
                Sobrenome = txtSobrenome.Text;
                return;
            }
            string DddTelefone = mkdTelefone.Text;

            if (DddTelefone == "")
            {
                MessageBox.Show("Falta preencher o telefone!");
            }
            else
            {
                DddTelefone = mkdTelefone.Text;
                return;
            }
            string Email = txtEmail.Text;

            if (Email == "")
            {
                MessageBox.Show("Falta preencher o e-mail!");
            }
            else
            {
                Email = txtEmail.Text;
                return;
            }
            char TipoTelefone;

            if (rdbPessoal.Checked)
            {
                TipoTelefone = 'P';
            }
            else if (rdbComercial.Checked)
            {
                TipoTelefone = 'C';
            }
            else if (rdbRecado.Checked)
            {
                TipoTelefone = 'R';
            }
            else
            {
                MessageBox.Show("O Tipo de telefone não foi definido!");
                return;
            }

            MessageBox.Show("Cadastro realizado com sucesso!", "Info",
               MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
