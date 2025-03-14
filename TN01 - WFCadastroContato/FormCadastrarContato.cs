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
        public void LimparFormulario()
        {
            txtNome.Clear();
            txtSobrenome.Clear();
            txtEmail.Clear();
            mkdTelefone.Clear();
            rdbComercial.Checked = false;
            rdbPessoal.Checked = false;
            rdbRecado.Checked = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string Nome = txtNome.Text;

            if (Nome == "")
            {
                MessageBox.Show("Falta preencher o nome!");
                return;
            }

            else
            {
                Nome = txtNome.Text;
            }

            string Sobrenome = txtSobrenome.Text;

            if (Sobrenome == "")
            {
                MessageBox.Show("Falta preencher o sobrenome!");
                return;
            }
            else
            {
                Sobrenome = txtSobrenome.Text;                
            }
            string DddTelefone = mkdTelefone.Text;

            if (DddTelefone == "")
            {
                MessageBox.Show("Falta preencher o telefone!");
                return;
            }
            else
            {
                DddTelefone = mkdTelefone.Text;                
            }
            string Email = txtEmail.Text;

            if (Email == "")
            {
                MessageBox.Show("Falta preencher o e-mail!");
                return;
            }
            else
            {
                Email = txtEmail.Text;               
            }
            ETipoTelefone tipoTelefone;

            if (rdbPessoal.Checked)
            {
                tipoTelefone = ETipoTelefone.Pessoal;
            }
            else if (rdbComercial.Checked)
            {
                tipoTelefone = ETipoTelefone.Comercial;
            }
            else if (rdbRecado.Checked)
            {
                tipoTelefone = ETipoTelefone.Recado;
            }
            else
            {
                MessageBox.Show("O Tipo de telefone não foi definido!");
                return;
            }

            //Jeito 1 (Retirando as máscaras do maskedTextBox)
            //string dddTelefone =
            //    "(" + mtbDddTelefone.Text.Substring(0, 2) + ") "
            //    + mtbDddTelefone.Text.Substring(2, 5) + "-"
            //    + mtbDddTelefone.Text.Substring(7);

            Contato c1 = new Contato();
            c1.Nome = txtNome.Text;
            c1.Email = txtEmail.Text;
            c1.Sobrenome = txtSobrenome.Text;
            c1.Codigo = 0;
            c1.TipoTelefone = tipoTelefone;
            c1.Ddd = mkdTelefone.Text.Substring(1, 2);
            c1.Telefone = mkdTelefone.Text.Substring(4);

            Contato.ListaContatos.Add(c1);

           
            MessageBox.Show("Cadastro realizado com sucesso!", "Info",
               MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
