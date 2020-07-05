using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoFSI.Model;

namespace TrabalhoFSI.Controller
{
    public class EncomendaController
    {
        public int RealizarEncomenda(Encomenda encomenda)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = Conexao.connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "realizarEncomenda";

            command.Parameters.AddWithValue("Nome_Fornecedor", encomenda.Nome_Fornecedor);
            command.Parameters.AddWithValue("Med_Encomenda", encomenda.Med_Encomenda);
            command.Parameters.AddWithValue("Qtde_Encomenda", encomenda.Qtde_Encomenda);
            command.Parameters.AddWithValue("Preco_Encomenda", encomenda.Preco_Encomenda);
            command.Parameters.AddWithValue("Data_Encomenda", encomenda.Data_Encomenda);
            command.Parameters.AddWithValue("Data_Entrega_Encomenda", encomenda.Data_Entrega_Encomenda);
            command.Parameters.AddWithValue("N_Lote_Encomenda", encomenda.N_Lote_Encomenda);
            command.Parameters.AddWithValue("Status_Encomenda", encomenda.Status_Encomenda);
            command.Parameters.AddWithValue("Id_Usuario", encomenda.Id_Usuario);
            command.Parameters.AddWithValue("Id_Fornecedor", encomenda.Id_Fornecedor);

            int ver = 0;

            try
            {
                Conexao.Conectar();

                ver = command.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                Conexao.Desconectar();
            }

            return ver;
        }
    }
}
