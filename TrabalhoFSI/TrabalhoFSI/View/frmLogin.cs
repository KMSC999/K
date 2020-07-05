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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string senha = txtSenha.Text;

            //string nome = "K";
            //string senha = "1234";

            if (nome == "" || senha == "")
            {
                MessageBox.Show("Preencha dos campos corretamente!");
                return;
            }

            if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(senha))
            {
                MessageBox.Show("Preencha dos campos corretamente!");
                return;
            }

            Usuario usuario = new Usuario();
            UsuarioController usuarioController = new UsuarioController();

            try
            {
                usuario = usuarioController.Login(nome, senha);
                if (usuario != null)
                {
                    frmPrincipal frmPrincipal = new frmPrincipal(usuario.Nome_Usuario.ToString(), Convert.ToInt32(usuario.Id_Usuario), usuario.Permissao_Usuario);
                    frmPrincipal.Show();
                    this.Visible = false;
                } else
                {
                    MessageBox.Show("Usuário não encontrado!");
                }

            }
            catch
            {

            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
