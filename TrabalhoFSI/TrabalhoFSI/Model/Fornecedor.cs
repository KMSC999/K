using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoFSI.Model
{
    public class Fornecedor
    {
        public int Id_Fornecedor { get; set; }
        public string Nome_Fornecedor { get; set; }
        public string Tele_Fornecedor { get; set; }
        public string Email_Fornecedor { get; set; }

        public Fornecedor()
        {
            Id_Fornecedor = 0;
            Nome_Fornecedor = "";
            Tele_Fornecedor = "";
            Email_Fornecedor = "";
        }
    }
}
