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
    public partial class frmRetiradaMed : Form
    {
        private int idMed;
        private int idUsu;
        private string nomeMed;
        private int qtdeMed;
        private frmPrincipal frmPrincipal;
        private MedicamentoRetirado medRetirado;
        private MedicamentoRetiradoController medRetiradoController;
        public frmRetiradaMed()
        {
            InitializeComponent();
        }

        public frmRetiradaMed(int iUsu, int iMed, string nMed, int qtde, frmPrincipal fPrincipal)
        {
            InitializeComponent();
            idMed = iMed;
            idUsu = iUsu;
            nomeMed = nMed;
            qtdeMed = qtde;
            frmPrincipal = fPrincipal;
        }

        private void btnRetirar_Click(object sender, EventArgs e)
        {
            if(txtQtde.Text == "" || string.IsNullOrEmpty(txtQtde.Text))
            {
                MessageBox.Show("Preencha o campo corretamente!");
                return;
            }

            medRetiradoController = new MedicamentoRetiradoController();

            int qtdeMedReti = Convert.ToInt32(txtQtde.Text);

            if (qtdeMed - qtdeMedReti < 0)
            {
                MessageBox.Show("Quantidade de remédios insuficiente. Quantidade restante: " + qtdeMed);
                return;
            }

            medRetirado = new MedicamentoRetirado
            {
                Nome_Med = txtNomeMed.Text,
                Qtde_Reti_Med = qtdeMedReti,
                Id_Med = idMed,
                Id_Usuario = idUsu
            };

            if (medRetiradoController.RetirarMedicamento(medRetirado) != 0)
            {
                MessageBox.Show("Retirada feita com sucesso!");
                frmPrincipal.CarregarMedicamentos();
                frmPrincipal.Focus();
                this.Close();
            }
            else
            {

            }
        }

        private void frmRetiradaMed_Load(object sender, EventArgs e)
        {
            txtNomeMed.Text = nomeMed;


        }

        private void frmRetiradaMed_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmPrincipal fPrincipal = new frmPrincipal();
            fPrincipal.Focus();
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
    }
}
