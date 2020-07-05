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

namespace TrabalhoFSI.View.ForneView
{
    public partial class frmCadFornecedor : Form
    {
        private frmPrincipal fPrincipal;
        private Fornecedor fornecedor;

        public frmCadFornecedor()
        {
            InitializeComponent();
        }

        public frmCadFornecedor(frmPrincipal f, Fornecedor forn)
        {
            InitializeComponent();
            fPrincipal = f;
            fornecedor = forn;
        }

        private void frmCadFornecedor_Load(object sender, EventArgs e)
        {

            if(fornecedor != null)
            {
                txtId.Text = fornecedor.Id_Fornecedor.ToString();
                txtNome.Text = fornecedor.Nome_Fornecedor;
                mskTelefone.Text = fornecedor.Tele_Fornecedor;
                txtEmail.Text = fornecedor.Email_Fornecedor;

                btnCadastrar.Enabled = false;
                this.Text = "Editar Fornecedor";
            }
            else
            {
                btnEditar.Enabled = false;
                this.Text = "Cadastrar Fornecedor";
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if(txtNome.Text == "" || string.IsNullOrEmpty(txtNome.Text))
            {
                MessageBox.Show("Preencha os campos corretamente!");
                return;
            }

            if (mskTelefone.Text.Length != 13)
            {
                MessageBox.Show("Preencha os campos corretamente!");
                return;
            }

            if (txtEmail.Text == "" || string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Preencha os campos corretamente!");
                return;
            }

            FornecedorController fornecedorController = new FornecedorController();
            fornecedor = new Fornecedor
            {
                Nome_Fornecedor = txtNome.Text,
                Tele_Fornecedor = mskTelefone.Text,
                Email_Fornecedor = txtEmail.Text
            };

            if(fornecedorController.CadastrarFornecedor(fornecedor) == 1)
            {
                MessageBox.Show("Fornecedor cadastrado com sucesso!");
                fPrincipal.CarregarFornecedores();
                fPrincipal.Focus();
                this.Close();
            }
            else
            {
                MessageBox.Show("Não foi possível cadastrar o fornecedor!");
                return;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "" || string.IsNullOrEmpty(txtNome.Text))
            {
                MessageBox.Show("Preencha os campos corretamente!");
                return;
            }

            if (mskTelefone.Text.Length != 13)
            {
                MessageBox.Show("Preencha os campos corretamente!");
                return;
            }

            if (txtEmail.Text == "" || string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Preencha os campos corretamente!");
                return;
            }

            FornecedorController fornecedorController = new FornecedorController();
            fornecedor = new Fornecedor
            {
                Id_Fornecedor = Convert.ToInt32(txtId.Text),
                Nome_Fornecedor = txtNome.Text,
                Tele_Fornecedor = mskTelefone.Text,
                Email_Fornecedor = txtEmail.Text
            };

            if (fornecedorController.EditarFornecedor(fornecedor) == 1)
            {
                MessageBox.Show("Fornecedor editado com sucesso!");
                fPrincipal.CarregarFornecedores();
                fPrincipal.Focus();
                this.Close();
            }
            else
            {
                MessageBox.Show("Não foi possível editar o fornecedor!");
                return;
            }
        }
    }
}
