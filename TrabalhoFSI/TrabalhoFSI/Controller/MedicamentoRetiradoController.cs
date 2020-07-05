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
    public class MedicamentoRetiradoController
    {
        public int RetirarMedicamento(MedicamentoRetirado medRetirado)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = Conexao.connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "retirarMedicamento";

            command.Parameters.AddWithValue("@Nome_Med", medRetirado.Nome_Med);
            command.Parameters.AddWithValue("@Qtde_Reti_Med", medRetirado.Qtde_Reti_Med);
            command.Parameters.AddWithValue("@Id_Med", medRetirado.Id_Med);
            command.Parameters.AddWithValue("@Id_Usuario", medRetirado.Id_Usuario);

            Conexao.Conectar();

            int ver = 0;

            try
            {
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

        public List<MedicamentoRetirado> ListarMedicamentosRetirados(int id)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = Conexao.connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "listarMedicamentosRetirados";

            command.Parameters.AddWithValue("@Id_Usuario", id);

            try
            {
                Conexao.Conectar();

                var reader = command.ExecuteReader();
                var medRetirados = new List<MedicamentoRetirado>();

                while (reader.Read())
                {
                    var medRetirado = new MedicamentoRetirado();

                    medRetirado.Nome_Med = reader["Nome_Med"].ToString();
                    medRetirado.Qtde_Reti_Med = Convert.ToInt32(reader["Qtde_Reti_Med"]);

                    medRetirados.Add(medRetirado);
                }

                return medRetirados;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                Conexao.Desconectar();
            }
        }
    }
}
