using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoFSI.Model
{
    public class MedicamentoRetirado
    {
        public int Id_Reti_Med { get; set; }
        public string Nome_Med { get; set; }
        public int Qtde_Reti_Med { get; set; }
        public int Id_Med { get; set; }
        public Medicamento medicamento { get; set; }
        public int Id_Usuario { get; set; }
        public Usuario usuario { get; set; }

        public MedicamentoRetirado()
        {
            Id_Reti_Med = 0;
            Nome_Med = "";
            Qtde_Reti_Med = 0;
            Id_Med = 0;
            Id_Usuario = 0;
        }
    }
}
