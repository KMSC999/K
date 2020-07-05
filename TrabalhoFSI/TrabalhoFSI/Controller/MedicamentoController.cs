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
    public class MedicamentoController
    {
        public int CadastrarMedicamento(Medicamento med)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = Conexao.connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "cadastrarMedicamento";

            command.Parameters.AddWithValue("@Nome_Med", med.Nome_Med);
            command.Parameters.AddWithValue("@Diluicao_Med", med.Diluicao_Med);
            command.Parameters.AddWithValue("@Dose_Med", med.Dose_Med);
            command.Parameters.AddWithValue("@Armazena_Med", med.Armazena_Med);
            command.Parameters.AddWithValue("@Incompa_Med", med.Incompa_Med);
            command.Parameters.AddWithValue("@Infusao_Med", med.Infusao_Med);
            command.Parameters.AddWithValue("@Qtde_Med", med.Qtde_Med);
            command.Parameters.AddWithValue("@Preco_Med", med.Preco_Med);
            command.Parameters.AddWithValue("@Id_Fornecedor", med.Id_Fornecedor);

            Conexao.Conectar();

            int ver = 0;

            try
            {
                ver = command.ExecuteNonQuery();
            }
            catch(Exception)
            {

            }
            finally
            {
                Conexao.Desconectar();
            }

            return ver;
        }

        public int AlterarMedicamento(Medicamento med)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = Conexao.connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "alterarMedicamento";

            command.Parameters.AddWithValue("@Id_Med", med.Id_Med);
            command.Parameters.AddWithValue("@Nome_Med", med.Nome_Med);
            command.Parameters.AddWithValue("@Diluicao_Med", med.Diluicao_Med);
            command.Parameters.AddWithValue("@Dose_Med", med.Dose_Med);
            command.Parameters.AddWithValue("@Armazena_Med", med.Armazena_Med);
            command.Parameters.AddWithValue("@Incompa_Med", med.Incompa_Med);
            command.Parameters.AddWithValue("@Infusao_Med", med.Infusao_Med);
            command.Parameters.AddWithValue("@Qtde_Med", med.Qtde_Med);
            command.Parameters.AddWithValue("@Preco_Med", med.Preco_Med);
            command.Parameters.AddWithValue("@Id_Fornecedor", med.Id_Fornecedor);

            Conexao.Conectar();

            int ver = 0;

            try
            {
                ver = command.ExecuteNonQuery();
            }
            catch (Exception)
            {

            }
            finally
            {
                Conexao.Desconectar();
            }

            return ver;
        }

        public int DeletarMedicamento(int id_Med)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = Conexao.connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "deletarMedicamento";

            command.Parameters.AddWithValue("@Id_Med", id_Med);

            Conexao.Conectar();

            int ver = 0;

            try
            {
                ver = command.ExecuteNonQuery();
            }
            catch (Exception)
            {

            }
            finally
            {
                Conexao.Desconectar();
            }

            return ver;
        }

        public DataTable ListarMedicamentos()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = Conexao.connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "listarMedicamentos";

            DataTable dtMed = new DataTable();
            SqlDataAdapter daMed = new SqlDataAdapter();

            try
            {
                daMed.SelectCommand = command;

                Conexao.Conectar();

                daMed.Fill(dtMed);

                return dtMed;
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

        public Medicamento ObterMedicamentoId(int id)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = Conexao.connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "obterMedicamentoId";

            command.Parameters.AddWithValue("@id", id);

            Conexao.Conectar();

            var reader = command.ExecuteReader();

            Medicamento medicamento = null;

            try
            {
                while (reader.Read())
                {
                    medicamento = new Medicamento();

                    medicamento.Id_Med = Convert.ToInt32(reader["Id_Med"]);
                    medicamento.Nome_Med = reader["Nome_Med"].ToString();
                    medicamento.Diluicao_Med = reader["Diluicao_Med"].ToString();
                    medicamento.Dose_Med = reader["Dose_Med"].ToString();
                    medicamento.Armazena_Med = reader["Armazena_Med"].ToString();
                    medicamento.Incompa_Med = reader["Armazena_Med"].ToString();
                    medicamento.Infusao_Med = reader["Infusao_Med"].ToString();
                    medicamento.Qtde_Med = Convert.ToInt32(reader["Qtde_Med"]);
                    medicamento.Preco_Med = Convert.ToDouble(reader["Preco_Med"]);
                    medicamento.Id_Fornecedor = Convert.ToInt32(reader["Id_Fornecedor"]);
                }

                return medicamento;
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

        public List<Medicamento> ListarMedicamentosParaEncomenda()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = Conexao.connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "listarMedicamentosParaEncomenda";

            Conexao.Conectar();

            var reader = command.ExecuteReader();
            var medicamentos = new List<Medicamento>();

            try
            {
                

                while (reader.Read())
                {
                    var medicamento = new Medicamento();

                    medicamento.Nome_Med = reader["Nome_Med"].ToString();
                    medicamento.Preco_Med = Convert.ToDouble(reader["Preco_Med"]);
                    medicamento.Id_Fornecedor = Convert.ToInt32(reader["Id_Fornecedor"]);
                    medicamento.fornecedor.Nome_Fornecedor = reader["Nome_Fornecedor"].ToString();
                    
                    medicamentos.Add(medicamento);
                }

                return medicamentos;
                
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
