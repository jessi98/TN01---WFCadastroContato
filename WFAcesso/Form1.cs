using Microsoft.VisualBasic.Logging;

namespace WFAcesso
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CarregarLista();
        }

        private void CarregarLista()
        {
            Usuario us = new Usuario();
            us.Codigo = 001;
            us.Login = "admin";
            us.Senha = "admin";
            us.DataCadastro = Convert.ToDateTime("01/01/2000");
            Usuario.ListaUsuarios.Add(us);


            us = new Usuario();
            us.Codigo = 002;
            us.Login = "user";
            us.Senha = "user";
            us.DataCadastro = Convert.ToDateTime("01/01/2010");
            Usuario.ListaUsuarios.Add(us);
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            foreach (Usuario usuario in Usuario.ListaUsuarios)
            {
                if (usuario.Login == txtUsuario.Text && usuario.Senha == txtSenha.Text)
                {
                    MessageBox.Show("Login efetuado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            MessageBox.Show("Senha ou Usuário Incorreto!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtSenha.Focus();
            }
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogar_Click(sender, e);
            }
        }
    }
}
