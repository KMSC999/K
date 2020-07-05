using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabalhoFSI.Controller;
using TrabalhoFSI.Model;

namespace TrabalhoFSI.View
{
    public partial class frmCadastroUsuario : Form
    {
        private frmPrincipal fPrincipal;
        private Usuario usuario;
        public frmCadastroUsuario()
        {
            InitializeComponent();
        }

        public frmCadastroUsuario(frmPrincipal fP, Usuario u)
        {
            InitializeComponent();
            fPrincipal = fP;
            usuario = u;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            UsuarioController usuarioController = new UsuarioController();
            Usuario usuario = new Usuario();

            usuario.Login_Usuario = txtLogin.Text;
            usuario.Senha_Usuario = txtSenha.Text;
            usuario.Nome_Usuario = txtNome.Text;
            usuario.Nasc_Usuario = Convert.ToDateTime(mskDataNasc.Text);
            usuario.Cpf_Usuario = mskCpf.Text;
            usuario.Email_Usuario = txtEmail.Text;
            usuario.Telefone_Usuario = mskTelefone.Text;
            usuario.Celular_Usuario = mskCelular.Text;
            usuario.Admissao_Usuario = Convert.ToDateTime(mskDataAd.Text);

            if(usuarioController.CadastrarUsuario(usuario) == 1)
            {
                MessageBox.Show("Cadastro de Usuário realizado com sucesso!");
                fPrincipal.CarregarFuncionarios();
                fPrincipal.Focus();
                this.Dispose();
            }
            else
            {

            }

        }

        private void frmCadastroUsuario_Load(object sender, EventArgs e)
        {
            if(usuario != null)
            {
                txtId.Text = usuario.Id_Usuario.ToString();
                txtLogin.Text = usuario.Login_Usuario;
                txtSenha.Text = usuario.Senha_Usuario;
                txtNome.Text = usuario.Nome_Usuario;
                mskDataNasc.Text = usuario.Nasc_Usuario.ToString();
                mskCpf.Text = usuario.Cpf_Usuario;
                txtEmail.Text = usuario.Email_Usuario;
                mskTelefone.Text = usuario.Telefone_Usuario;
                mskCelular.Text = usuario.Celular_Usuario;
                mskDataAd.Text = usuario.Admissao_Usuario.ToString();

                btnCadastrar.Enabled = false;
                this.Text = "Edição de um Usuário";

                if(usuario.Permissao_Usuario == 'A')
                {
                    rdbAdmin.Checked = true;
                    rdbFuncionario.Checked = false;
                }
                else
                {
                    rdbAdmin.Checked = false;
                    rdbFuncionario.Checked = true;
                }
            }
            else
            {
                btnEditar.Enabled = false;
                this.Text = "Cadastro de um novo Usuário";
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            char permissao = ' ';
            if(rdbAdmin.Checked == true)
            {
                permissao = 'A';
            }
            else
            {
                permissao = 'F';
            }
            UsuarioController usuarioController = new UsuarioController();
            Usuario usuario = new Usuario
            {
                Id_Usuario = Convert.ToInt32(txtId.Text),
                Login_Usuario = txtLogin.Text,
                Senha_Usuario = txtSenha.Text,
                Nome_Usuario = txtNome.Text,
                Nasc_Usuario = Convert.ToDateTime(mskDataNasc.Text),
                Cpf_Usuario = mskCpf.Text,
                Email_Usuario = txtEmail.Text,
                Telefone_Usuario = mskTelefone.Text,
                Celular_Usuario = mskCelular.Text,
                Admissao_Usuario = Convert.ToDateTime(mskDataAd.Text),
                Permissao_Usuario = permissao
            };

            if (usuarioController.EditarUsuario(usuario) == 1)
            {
                MessageBox.Show("Edição de Usuário realizado com sucesso!");
                fPrincipal.CarregarFuncionarios();
                fPrincipal.Focus();
                this.Dispose();
            }
            else
            {

            }
        }
    }
}
