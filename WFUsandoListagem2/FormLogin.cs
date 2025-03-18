using WFUsandoListagem2;

namespace WFUsandoListagem2
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            CarregarLista();
        }

        private void CarregarLista()
        {
            Usuario us = new Usuario();
            us.Codigo = 1000;
            us.Login = "user";
            us.Senha = "123456";
            us.DataCadastro = Convert.ToDateTime("10/01/2025 18:30");
            Usuario.ListaUsuarios.Add(us);
        }


        private void btnAcessar_Click(object sender, EventArgs e)
        {
            foreach (Usuario usuario in Usuario.ListaUsuarios)
            {
                if (usuario.Login == txtLogin.Text && usuario.Senha == txtSenha.Text)
                {
                    FormMain form = new FormMain();
                    form.ShowDialog();

                    this.txtLogin.Clear();
                    this.txtSenha.Clear();
                    return;
                }
            }

            MessageBox.Show("Senha ou Usuário Incorreto!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        private void txtLogin_KeyDown(object sender, KeyEventArgs e)
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
                btnAcessar_Click(sender, e);
            }

        }
    }
}