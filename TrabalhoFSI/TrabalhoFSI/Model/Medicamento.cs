using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoFSI.Model
{
    public class Medicamento
    {
        public int Id_Med { get; set; }
        public string Nome_Med { get; set; }
        public string Diluicao_Med { get; set; }
        public string Dose_Med { get; set; }
        public string Armazena_Med { get; set; }
        public string Incompa_Med { get; set; }
        public string Infusao_Med { get; set; }
        public int Qtde_Med { get; set; }
        public double Preco_Med { get; set; }
        public int Id_Fornecedor { get; set; }
        public Fornecedor fornecedor { get; set; }

        public Medicamento()
        {
            Id_Med = 0;
            Nome_Med = "";
            Diluicao_Med = "";
            Dose_Med = "";
            Armazena_Med = "";
            Incompa_Med = "";
            Infusao_Med = "";
            Qtde_Med = 0;
            Preco_Med = 0;
            Id_Fornecedor = 0;
            fornecedor = new Fornecedor();
        }
    }
}
