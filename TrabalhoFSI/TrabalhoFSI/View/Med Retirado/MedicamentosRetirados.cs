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

namespace TrabalhoFSI.View.Med_Retirado
{
    public partial class frmMedicamentosRetirados : Form
    {
        private int idUsu;
        private MedicamentoRetirado medReti;
        private MedicamentoRetiradoController medRetiController;
        public frmMedicamentosRetirados()
        {
            InitializeComponent();
        }

        public frmMedicamentosRetirados(int id)
        {
            InitializeComponent();
            idUsu = id;
        }

        private void frmMedicamentosRetirados_Load(object sender, EventArgs e)
        {
            medRetiController = new MedicamentoRetiradoController();
            List<MedicamentoRetirado> medicamentosRetirados = new List<MedicamentoRetirado>();
            medicamentosRetirados = medRetiController.ListarMedicamentosRetirados(idUsu);

            foreach (MedicamentoRetirado med in medicamentosRetirados)
            {
                lstMedRetirados.Items.Add(ConstruirLinha(med));
            }
        }

        private string ConstruirLinha(MedicamentoRetirado med)
        {
            string qtde = med.Qtde_Reti_Med.ToString();
            return med.Nome_Med + new string(' ', 30 - med.Nome_Med.Length - qtde.Length) + qtde;
        }

        private void frmMedicamentosRetirados_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmPrincipal fPrincipal = new frmPrincipal();
            fPrincipal.Focus();
        }
    }
}
