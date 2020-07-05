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
    public partial class frmCadastroMed : Form
    {
        private frmPrincipal frmPrincipal;
        private Medicamento medicamento = null;
        private FornecedorController fornecedorController;
        List<Fornecedor> fornecedores;

        public frmCadastroMed()
        {
            InitializeComponent();
        }

        public frmCadastroMed(frmPrincipal frmP)
        {
            InitializeComponent();
            frmPrincipal = frmP;
        }

        public frmCadastroMed(frmPrincipal frmP, Medicamento med)
        {
            InitializeComponent();
            frmPrincipal = frmP;
            medicamento = med;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if(VerificarCampos() == true)
            {
                MedicamentoController medController = new MedicamentoController();
                medicamento = new Medicamento
                {
                    Nome_Med = txtNomeMed.Text,
                    Diluicao_Med = txtDiluicaoMed.Text,
                    Dose_Med = txtDoseMed.Text,
                    Armazena_Med = txtArmazenaMed.Text,
                    Incompa_Med = txtIncompaMed.Text,
                    Infusao_Med = txtInfusaoMed.Text,
                    Qtde_Med = Convert.ToInt32(txtQtdeMed.Text),
                    Preco_Med = Convert.ToDouble(txtPreco.Text),
                    Id_Fornecedor = Convert.ToInt32(lblIdFornecedor.Text)
                };

                if (medController.CadastrarMedicamento(medicamento) == 1)
                {
                    MessageBox.Show("Cadastro realizado com sucesso!");
                    frmPrincipal.CarregarMedicamentos();
                    frmPrincipal.Focus();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Não foi possível concluir o cadastro!");
                }
            }
            else
            {
                MessageBox.Show("Preencha os campos corretamente!");
                return;
            }

            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if(VerificarCampos() == true)
            {
                MedicamentoController medController = new MedicamentoController();
                medicamento = new Medicamento
                {
                    Id_Med = Convert.ToInt32(txtId.Text),
                    Nome_Med = txtNomeMed.Text,
                    Diluicao_Med = txtDiluicaoMed.Text,
                    Dose_Med = txtDoseMed.Text,
                    Armazena_Med = txtArmazenaMed.Text,
                    Incompa_Med = txtIncompaMed.Text,
                    Infusao_Med = txtInfusaoMed.Text,
                    Qtde_Med = Convert.ToInt32(txtQtdeMed.Text),
                    Preco_Med = Convert.ToDouble(txtPreco.Text),
                    Id_Fornecedor = Convert.ToInt32(lblIdFornecedor.Text)
                };



                if (medController.AlterarMedicamento(medicamento) == 1)
                {
                    MessageBox.Show("Alteração realizada com sucesso!");
                    frmPrincipal.CarregarMedicamentos();
                    frmPrincipal.Focus();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Não foi possível alterar o cadastro!");
                }
            }
            else
            {
                MessageBox.Show("Preencha os campos corretamente!");
                return;
            }

            
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            MedicamentoController medController = new MedicamentoController();

            int Id_Med = 2;


            if (medController.DeletarMedicamento(Id_Med) == 1)
            {
                MessageBox.Show("Deletado!");
            }
            else
            {
                MessageBox.Show("Não foi possível alterar o cadastro!");
            }
        }

        private void frmCadastroMed_Load(object sender, EventArgs e)
        {
            fornecedorController = new FornecedorController();

            fornecedores = new List<Fornecedor>();
            fornecedores = fornecedorController.ListarFornecedoresCmb();

            cmbFornecedor.DataSource = fornecedores;
            cmbFornecedor.ValueMember = "Id_Fornecedor";
            cmbFornecedor.DisplayMember = "Nome_Fornecedor";

            if (medicamento != null)
            {
                txtId.Text = medicamento.Id_Med.ToString();
                txtNomeMed.Text = medicamento.Nome_Med;
                txtDiluicaoMed.Text = medicamento.Diluicao_Med;
                txtDoseMed.Text = medicamento.Dose_Med;
                txtArmazenaMed.Text = medicamento.Armazena_Med;
                txtIncompaMed.Text = medicamento.Incompa_Med;
                txtInfusaoMed.Text = medicamento.Infusao_Med;
                txtQtdeMed.Text = medicamento.Qtde_Med.ToString();
                txtPreco.Text = medicamento.Preco_Med.ToString();
                lblIdFornecedor.Text = medicamento.Id_Fornecedor.ToString();

                cmbFornecedor.SelectedValue = medicamento.Id_Fornecedor;

                btnCadastrar.Enabled = false;
                this.Text = "Edição de um Medicamento";
            }
            else
            {
                btnEditar.Enabled = false;
                this.Text = "Cadastro de um novo medicamento";


            } 
      
        }

        private void cmbFornecedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblIdFornecedor.Text = cmbFornecedor.SelectedValue.ToString();
        }


        private bool VerificarCampos()
        {
            if(txtNomeMed.Text == "" || string.IsNullOrEmpty(txtNomeMed.Text))
            {
                return false;
            }

            if (txtQtdeMed.Text == "" || string.IsNullOrEmpty(txtQtdeMed.Text))
            {
                return false;
            }

            if (txtPreco.Text == "" || string.IsNullOrEmpty(txtPreco.Text))
            {
                return false;
            }

            string precoS = txtPreco.Text;
            double preco = 1.2;

            if (Double.TryParse(precoS, out preco) == false)
            {
                return false;
            }

            return true;
        }

        private void txtQtdeMed_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número e nem backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void txtPreco_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número e nem backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 44)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }
    }
}
