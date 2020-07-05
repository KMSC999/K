using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoFSI.Model
{
    public class Usuario
    {
        public int Id_Usuario { get; set; }
        public string Login_Usuario { get; set; }
        public string Senha_Usuario { get; set; }
        public string Nome_Usuario { get; set; }
        public DateTime Nasc_Usuario { get; set; }
        public string Cpf_Usuario { get; set; }
        public string Email_Usuario { get; set; }
        public string Telefone_Usuario { get; set; }
        public string Celular_Usuario { get; set; }
        public DateTime Admissao_Usuario { get; set; }
        public char Permissao_Usuario { get; set; }

        public Usuario()
        {
            Id_Usuario = 0;
            Login_Usuario = "";
            Senha_Usuario = "";
            Nome_Usuario = "";
            Nasc_Usuario = Convert.ToDateTime("1900-01-01");
            Cpf_Usuario = "";
            Email_Usuario = "";
            Telefone_Usuario = "";
            Celular_Usuario = "";
            Admissao_Usuario = Convert.ToDateTime("1900-01-01");
            Permissao_Usuario = Convert.ToChar(" ");
        }
    }
}
