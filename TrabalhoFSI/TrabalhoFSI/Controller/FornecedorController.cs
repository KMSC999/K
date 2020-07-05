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
    public class FornecedorController
    {
        public DataTable ListarFornecedores()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = Conexao.connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "listarFornecedores";

            DataTable dtForne = new DataTable();
            SqlDataAdapter daForne = new SqlDataAdapter();

            try
            {
                daForne.SelectCommand = command;

                Conexao.Conectar();

                daForne.Fill(dtForne);

                return dtForne;
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

        public List<Fornecedor> ListarFornecedoresCmb()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = Conexao.connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "listarFornecedores";
 
            try
            {
                Conexao.Conectar();

                var reader = command.ExecuteReader();
                var fornecedores = new List<Fornecedor>();

                while (reader.Read())
                {
                    var fornecedor = new Fornecedor();

                    fornecedor.Id_Fornecedor = Convert.ToInt32(reader["ID"]);
                    fornecedor.Nome_Fornecedor = reader["Nome do Fornecedor"].ToString();

                    fornecedores.Add(fornecedor);
                }

                return fornecedores;
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

        public int CadastrarFornecedor(Fornecedor fornecedor)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = Conexao.connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "cadastrarFornecedor";

            command.Parameters.AddWithValue("@Nome_Fornecedor", fornecedor.Nome_Fornecedor);
            command.Parameters.AddWithValue("@Tele_Fornecedor", fornecedor.Tele_Fornecedor);
            command.Parameters.AddWithValue("@Email_Fornecedor", fornecedor.Email_Fornecedor);

            int var = 0;

            try
            {
                Conexao.Conectar();
                var = command.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                Conexao.Desconectar();
            }

            return var;
        }

        public int EditarFornecedor(Fornecedor fornecedor)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = Conexao.connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "editarFornecedor";

            command.Parameters.AddWithValue("@Id_Fornecedor", fornecedor.Id_Fornecedor);
            command.Parameters.AddWithValue("@Nome_Fornecedor", fornecedor.Nome_Fornecedor);
            command.Parameters.AddWithValue("@Tele_Fornecedor", fornecedor.Tele_Fornecedor);
            command.Parameters.AddWithValue("@Email_Fornecedor", fornecedor.Email_Fornecedor);

            int var = 0;

            try
            {
                Conexao.Conectar();
                var = command.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                Conexao.Desconectar();
            }

            return var;
        }

        public Fornecedor FornecedorId(int id)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = Conexao.connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "fornecedorId";

            command.Parameters.AddWithValue("@Id_Fornecedor", id);

            Conexao.Conectar();

            Fornecedor fornecedor = null;

            try
            {
                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    fornecedor = new Fornecedor();

                    fornecedor.Id_Fornecedor = Convert.ToInt32(reader["Id_Fornecedor"]);
                    fornecedor.Nome_Fornecedor = reader["Nome_Fornecedor"].ToString();
                    fornecedor.Tele_Fornecedor = reader["Tele_Fornecedor"].ToString();
                    fornecedor.Email_Fornecedor = reader["Email_Fornecedor"].ToString();
                }

                return fornecedor;
            }
            catch
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
