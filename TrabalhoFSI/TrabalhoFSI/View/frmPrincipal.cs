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
using TrabalhoFSI.View.ForneView;
using TrabalhoFSI.View.Med;
using TrabalhoFSI.View.Med_Retirado;

namespace TrabalhoFSI.View
{
    public partial class frmPrincipal : Form
    {
        MedicamentoController medicamentoController;
        //private Usuario usuario;
        private string nome;
        private int idUsu;
        private char permissao;

        private Medicamento medicamento;
        private MedicamentoController medController;

        private Usuario usuario;
        private UsuarioController usuarioController;

        private Fornecedor fornecedor;
        private FornecedorController fornecedorController;

        private frmCadastroUsuario frmCadastroUsuario;
        private frmEncomenda frmEncomenda;
        private frmCadastroMed frmCadastroMed;
        private frmRetiradaMed frmRetirada;
        private frmMedicamentosRetirados frmMedRetirados;
        private frmCadFornecedor frmCadFornecedor;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        public frmPrincipal(string n, int i, char p)
        {
            InitializeComponent();       
            nome = n;
            idUsu = i;
            permissao = p;
        }

        public void CarregarFuncionarios()
        {
            usuarioController = new UsuarioController();
            DataTable dtUsu = new DataTable();

            dtUsu = usuarioController.ListarUsuarios(idUsu);

            dgvUsuarios.DataSource = dtUsu;
        }

        public void CarregarMedicamentos()
        {
            medController = new MedicamentoController();
            DataTable dtMed = new DataTable();

            dtMed = medController.ListarMedicamentos();

            dgvMedicamentos.DataSource = dtMed;
        }

        public void CarregarFornecedores()
        {
            fornecedorController = new FornecedorController();
            DataTable dtForne = new DataTable();

            dtForne = fornecedorController.ListarFornecedores();

            dgvFornecedores.DataSource = dtForne;
        }


        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if(Application.OpenForms["frmCadastroUsuario"] == null)
            {
                frmCadastroUsuario = new frmCadastroUsuario();
                frmCadastroUsuario.Show();
            }
            
        }

        private void btnCadastrarMed_Click(object sender, EventArgs e)
        {
            if(Application.OpenForms["frmCadastroMed"] == null)
            {
                frmCadastroMed = new frmCadastroMed(this);
                frmCadastroMed.Show();
            }
        }

        private void btnEditarMed_Click(object sender, EventArgs e)
        {
            if(Application.OpenForms["frmCadastroMed"] == null)
            {
                medicamento = new Medicamento();
                medicamentoController = new MedicamentoController();
                int id = Convert.ToInt32(dgvMedicamentos.SelectedRows[0].Cells[0].Value.ToString());
                medicamento = medicamentoController.ObterMedicamentoId(id);
                frmCadastroMed = new frmCadastroMed(this, medicamento);
                frmCadastroMed.Show();
            }
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            this.Text = nome;

            if (Char.ToString(permissao) == "A")
            {
                CarregarFuncionarios();
            }
            else
            {
                tbcPrincipal.TabPages.Remove(tbpFuncionarios);
            } 

            CarregarMedicamentos();
            CarregarFornecedores();
            PreencherCampos(idUsu);
            
        }

        private void btnRetirar_Click(object sender, EventArgs e)
        {
            if(Application.OpenForms["frmRetiradaMed"] == null)
            {
                int id = Convert.ToInt32(dgvMedicamentos.SelectedRows[0].Cells[0].Value.ToString());
                string nomeMed = dgvMedicamentos.SelectedRows[0].Cells[1].Value.ToString();
                int qtde = Convert.ToInt32(dgvMedicamentos.SelectedRows[0].Cells[7].Value.ToString());
                frmRetirada = new frmRetiradaMed(idUsu, id, nomeMed, qtde, this);
                frmRetirada.Show();
            }
        }

        private void btnEncomenda_Click(object sender, EventArgs e)
        {
            if(Application.OpenForms["frmEncomenda"] == null)
            {
                frmEncomenda = new frmEncomenda(idUsu, this);
                frmEncomenda.Show();
            }
        }

        private void btnCadastrarForne_Click(object sender, EventArgs e)
        {
            if(Application.OpenForms["frmCadFornecedor"] == null)
            {
                frmCadFornecedor = new frmCadFornecedor(this, null);
                frmCadFornecedor.Show();
            }       
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmCadastroUsuario"] == null)
            {
                usuario = new Usuario();
                usuarioController = new UsuarioController();
                int id = Convert.ToInt32(dgvUsuarios.SelectedRows[0].Cells[0].Value.ToString());
                usuario = usuarioController.ObterUsuarioId(id);
                frmCadastroUsuario = new frmCadastroUsuario(this, usuario);
                frmCadastroUsuario.Show();

            }
        }

        private void PreencherCampos(int id)
        {
            usuario = new Usuario();
            usuarioController = new UsuarioController();
            usuario = usuarioController.ObterUsuarioId(id);

            txtLogin.Text = usuario.Login_Usuario;
            txtSenha.Text = usuario.Senha_Usuario;
            txtNome.Text = usuario.Nome_Usuario;
            mskNasc.Text = usuario.Nasc_Usuario.ToString();
            mskCpf.Text = usuario.Cpf_Usuario;
            txtEmail.Text = usuario.Email_Usuario;
            mskTelefone.Text = usuario.Telefone_Usuario;
            mskCelular.Text = usuario.Celular_Usuario;
            mskAdmissao.Text = usuario.Admissao_Usuario.ToString();

            if(Char.ToString(usuario.Permissao_Usuario) == "A")
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

        private void dgvMedicamentos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEditarFornecedor_Click(object sender, EventArgs e)
        {
            //if(Application.OpenForms["frmCadFornecedor"] == null)
            {
                int id = Convert.ToInt32(dgvFornecedores.SelectedRows[0].Cells[0].Value.ToString());
                fornecedor = new Fornecedor();

                fornecedorController = new FornecedorController();
                fornecedor = fornecedorController.FornecedorId(id);

                frmCadFornecedor = new frmCadFornecedor(this, fornecedor);
                frmCadFornecedor.Show();
            }        
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvUsuarios.SelectedRows[0].Cells[0].Value.ToString());
            frmMedRetirados = new frmMedicamentosRetirados(id);
            frmMedRetirados.Show();
        }

        private void btnMedRetirados_Click(object sender, EventArgs e)
        {
            frmMedRetirados = new frmMedicamentosRetirados(idUsu);
            frmMedRetirados.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            char permissao = ' ';

            if (VerificarCamposUsuario() == true)
            {
                if (rdbAdmin.Checked == true)
                {
                    permissao = 'A';
                }
                else
                {
                    permissao = 'F';
                }
                usuarioController = new UsuarioController();
                usuario = new Usuario
                {
                    Id_Usuario = idUsu,
                    Login_Usuario = txtLogin.Text,
                    Senha_Usuario = txtSenha.Text,
                    Nome_Usuario = txtNome.Text,
                    Nasc_Usuario = Convert.ToDateTime(mskNasc.Text),
                    Cpf_Usuario = mskCpf.Text,
                    Email_Usuario = txtEmail.Text,
                    Telefone_Usuario = mskTelefone.Text,
                    Celular_Usuario = mskCelular.Text,
                    Admissao_Usuario = Convert.ToDateTime(mskAdmissao.Text),
                    Permissao_Usuario = permissao
                };

                if (usuarioController.EditarUsuario(usuario) == 1)
                {
                    MessageBox.Show("Edição de Usuário realizado com sucesso!");
                }
                else
                {
                    MessageBox.Show("Operação não pôde ser concluída!");
                }
            }

            else
            {
                MessageBox.Show("Preencha os campos corretamente");
                return;
            }

            
        }

        private bool VerificarCamposUsuario()
        {
            if(txtLogin.Text == "" || string.IsNullOrEmpty(txtLogin.Text))
            {
                return false;
            }

            if (txtSenha.Text == "" || string.IsNullOrEmpty(txtSenha.Text))
            {
                return false;
            }

            if (txtNome.Text == "" || string.IsNullOrEmpty(txtNome.Text))
            {
                return false;
            }

            if (mskNasc.Text.Length != 10)
            {
                return false;
            }

            if (mskCpf.Text.Length != 14)
            {
                return false;
            }

            if (mskTelefone.Text.Length != 13 && mskCelular.Text.Length != 14)
            {
                return false;
            }

            if (txtEmail.Text == "" || string.IsNullOrEmpty(txtNome.Text))
            {
                return false;
            }

            if (mskAdmissao.Text.Length != 10)
            {
                return false;
            }

            return true;
        }

        private void frmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
