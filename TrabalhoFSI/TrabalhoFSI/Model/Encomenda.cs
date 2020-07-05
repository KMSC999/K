using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoFSI.Model
{
    public class Encomenda
    {
        public int Id_Encomenda { get; set; }
        public string Nome_Fornecedor { get; set; }
        public string Med_Encomenda { get; set; }
        public int Qtde_Encomenda { get; set; }
        public double Preco_Encomenda { get; set; }
        public DateTime Data_Encomenda { get; set; }
        public DateTime Data_Entrega_Encomenda { get; set; }
        public string N_Lote_Encomenda { get; set; }
        public string Status_Encomenda { get; set; }
        public int Id_Usuario { get; set; }
        public Usuario usuario { get; set; }
        public int Id_Fornecedor { get; set; }
        public Fornecedor fornecedor { get; set; }

        public Encomenda()
        {
            Id_Encomenda = 0;
            Nome_Fornecedor = "";
            Med_Encomenda = "";
            Qtde_Encomenda = 0;
            Preco_Encomenda = 0;
            Data_Encomenda = Convert.ToDateTime("1900-01-01");
            Data_Entrega_Encomenda = Convert.ToDateTime("1900-01-01");
            N_Lote_Encomenda = "";
            Status_Encomenda = "";
            Id_Usuario = 0;
            Id_Fornecedor = 0;
            usuario = new Usuario();
            fornecedor = new Fornecedor();
        }
    }
}
