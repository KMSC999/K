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

namespace TrabalhoFSI.View.Med
{
    public partial class frmEncomenda : Form
    {
        private int idUsuario;
        private List<Medicamento> medicamentos;
        private List<Encomenda> encomendas = new List<Encomenda>();

        private Encomenda encomenda;

        private MedicamentoController medicamentoController;
        private EncomendaController encomendaController;

        private frmPrincipal frmPrincipal;
        public frmEncomenda()
        {
            InitializeComponent();
        }

        public frmEncomenda(int iDu, frmPrincipal f)
        {
            InitializeComponent();
            idUsuario = iDu;
            frmPrincipal = f;
        }

        private void frmEncomenda_Load(object sender, EventArgs e)
        {

            medicamentoController = new MedicamentoController();

            medicamentos = new List<Medicamento>();
            medicamentos = medicamentoController.ListarMedicamentosParaEncomenda();

            cmbMedicamento.DataSource = medicamentos;    
            cmbMedicamento.DisplayMember = "Nome_Med";
            cmbMedicamento.ValueMember = "Id_Fornecedor";

            txtFornecedor.Text = medicamentos[cmbMedicamento.SelectedIndex].fornecedor.Nome_Fornecedor;
            txtPreco.Text = medicamentos[cmbMedicamento.SelectedIndex].Preco_Med.ToString();
            lblIdFornecedor.Text = cmbMedicamento.SelectedValue.ToString();

            btnFinalizar.Enabled = false;

        }

        private void cmbMedicamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPreco.Text = medicamentos[cmbMedicamento.SelectedIndex].Preco_Med.ToString();
            txtFornecedor.Text = medicamentos[cmbMedicamento.SelectedIndex].fornecedor.Nome_Fornecedor.ToString();
            lblIdFornecedor.Text = cmbMedicamento.SelectedValue.ToString();      
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {

            for(int i = 0; i < encomendas.Count; i++)
            {
                if(encomendas[i].Med_Encomenda == cmbMedicamento.Text)
                {
                    MessageBox.Show("Medicamento já adicionado");
                    return;
                }
            }

            if (txtQtde.Text == "" || string.IsNullOrEmpty(txtQtde.Text))
            {
                MessageBox.Show("Digite uma quantidade!");
                return;
            }

            double preco = Convert.ToInt32(txtQtde.Text) * Convert.ToDouble(txtPreco.Text);

            btnFinalizar.Enabled = true;

            encomenda = new Encomenda
            {
                Nome_Fornecedor = txtFornecedor.Text,
                Med_Encomenda = cmbMedicamento.Text.ToString(),
                Qtde_Encomenda = Convert.ToInt32(txtQtde.Text),
                Preco_Encomenda = preco,
                Data_Encomenda = DateTime.Now,
                Data_Entrega_Encomenda = Convert.ToDateTime("1900-01-01"),
                N_Lote_Encomenda = "",
                Id_Usuario = idUsuario,
                Id_Fornecedor = Convert.ToInt32(lblIdFornecedor.Text)
            };
            
            encomendas.Add(encomenda);

            lstCompras.Items.Add(ConstruirLinha(encomenda));

            var total = encomendas.Sum(i => i.Preco_Encomenda);
            lblTotal.Text = total.ToString("0.00");

        }

        private string ConstruirLinha(Encomenda e)
        {
            string preco = "R$" + e.Preco_Encomenda.ToString("0.00");
            return e.Med_Encomenda + new string(' ', 35 - e.Med_Encomenda.Length - preco.Length) + preco;
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            int r = 0;

            for (int i = 0; i < encomendas.Count; i++)
            {
                encomendaController = new EncomendaController();
                encomenda = new Encomenda 
                {
                    Nome_Fornecedor = encomendas[i].Nome_Fornecedor,
                    Med_Encomenda = encomendas[i].Med_Encomenda,
                    Qtde_Encomenda = encomendas[i].Qtde_Encomenda,
                    Preco_Encomenda = encomendas[i].Preco_Encomenda,
                    Data_Encomenda = encomendas[i].Data_Encomenda,
                    Data_Entrega_Encomenda = encomendas[i].Data_Entrega_Encomenda,
                    N_Lote_Encomenda = encomendas[i].N_Lote_Encomenda,
                    Status_Encomenda = encomendas[i].Status_Encomenda,
                    Id_Usuario = encomendas[i].Id_Usuario,
                    Id_Fornecedor = encomendas[i].Id_Fornecedor
                };

                r += encomendaController.RealizarEncomenda(encomenda);
                

            }

            if(r == encomendas.Count)
            {
                MessageBox.Show("Compras realizadas com sucesso!");
                //lstCompras.Items.Clear();
                //encomendas = new List<Encomenda>();
                frmPrincipal.Focus();
                this.Close();        
            }
        }

        private void txtQtde_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número e nem backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void frmEncomenda_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmPrincipal.Focus();
        }

        private void frmEncomenda_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmPrincipal.Focus();
        }
    }
}
