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
    public class UsuarioController
    {
        public Usuario Login(string nome, string senha)
        {

            SqlCommand command = new SqlCommand();
            command.Connection = Conexao.connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "logarUsuario";

            command.Parameters.AddWithValue("@Login_Usuario", nome);
            command.Parameters.AddWithValue("@Senha_Usuario", senha);

            Conexao.Conectar();


            var reader = command.ExecuteReader();

            Usuario usuario = null;

            try
            {
                while (reader.Read())
                {
                    usuario = new Usuario();

                    usuario.Id_Usuario = Convert.ToInt32(reader["Id_Usuario"]);
                    usuario.Nome_Usuario = reader["Nome_Usuario"].ToString();
                    usuario.Permissao_Usuario = Convert.ToChar(reader["Permissao_Usuario"]);
                    
                }

                return usuario;
            }
            catch (Exception e)
            {
                throw;
            }
            finally
            {
                Conexao.Desconectar();
            }

        }

        public DataTable ListarUsuarios(int id)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = Conexao.connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "listarUsuarios";

            command.Parameters.AddWithValue("@Id_Usuario", id);

            DataTable dtUsu = new DataTable();
            SqlDataAdapter daUsu = new SqlDataAdapter();
            try
            {
                daUsu.SelectCommand = command;

                Conexao.Conectar();

                daUsu.Fill(dtUsu);

                return dtUsu;
            }
            catch
            {
                throw;
            }
            finally
            {

            }
        }

        public int CadastrarUsuario(Usuario usuario)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = Conexao.connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "cadastrarUsuario";

            command.Parameters.AddWithValue("@Login_Usuario", usuario.Login_Usuario);
            command.Parameters.AddWithValue("@Senha_Usuario", usuario.Senha_Usuario);
            command.Parameters.AddWithValue("@Nome_Usuario", usuario.Nome_Usuario);
            command.Parameters.AddWithValue("@Nasc_Usuario", usuario.Nasc_Usuario);
            command.Parameters.AddWithValue("@Cpf_Usuario", usuario.Cpf_Usuario);
            command.Parameters.AddWithValue("@Email_Usuario", usuario.Email_Usuario);
            command.Parameters.AddWithValue("@Telefone_Usuario", usuario.Telefone_Usuario);
            command.Parameters.AddWithValue("@Celular_Usuario", usuario.Celular_Usuario);
            command.Parameters.AddWithValue("@Admissao_Usuario", usuario.Admissao_Usuario);
            command.Parameters.AddWithValue("@Permissao_Usuario", usuario.Permissao_Usuario);

            Conexao.Conectar();

            int var = 0;

            try
            {
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

        public int EditarUsuario(Usuario usuario)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = Conexao.connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "editarUsuario";

            command.Parameters.AddWithValue("@Id_Usuario", usuario.Id_Usuario);
            command.Parameters.AddWithValue("@Login_Usuario", usuario.Login_Usuario);
            command.Parameters.AddWithValue("@Senha_Usuario", usuario.Senha_Usuario);
            command.Parameters.AddWithValue("@Nome_Usuario", usuario.Nome_Usuario);
            command.Parameters.AddWithValue("@Nasc_Usuario", usuario.Nasc_Usuario);
            command.Parameters.AddWithValue("@Cpf_Usuario", usuario.Cpf_Usuario);
            command.Parameters.AddWithValue("@Email_Usuario", usuario.Email_Usuario);
            command.Parameters.AddWithValue("@Telefone_Usuario", usuario.Telefone_Usuario);
            command.Parameters.AddWithValue("@Celular_Usuario", usuario.Celular_Usuario);
            command.Parameters.AddWithValue("@Admissao_Usuario", usuario.Admissao_Usuario);
            command.Parameters.AddWithValue("@Permissao_Usuario", usuario.Permissao_Usuario);

            Conexao.Conectar();

            int var = 0;

            try
            {
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

        public Usuario ObterUsuarioId(int id)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = Conexao.connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "obterUsuarioId";

            command.Parameters.AddWithValue("@Id_Usuario", id);

            Usuario usuario = null;

            try
            {
                Conexao.Conectar();

                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    usuario = new Usuario();

                    usuario.Id_Usuario = Convert.ToInt32(reader["Id_Usuario"]);
                    usuario.Login_Usuario = reader["Login_Usuario"].ToString();
                    usuario.Senha_Usuario = reader["Senha_Usuario"].ToString();
                    usuario.Nome_Usuario = reader["Nome_Usuario"].ToString();
                    usuario.Nasc_Usuario = Convert.ToDateTime(reader["Nasc_Usuario"]);
                    usuario.Cpf_Usuario = reader["Cpf_Usuario"].ToString();
                    usuario.Email_Usuario = reader["Email_Usuario"].ToString();
                    usuario.Telefone_Usuario = reader["Telefone_Usuario"].ToString();
                    usuario.Celular_Usuario = reader["Celular_Usuario"].ToString();
                    usuario.Admissao_Usuario = Convert.ToDateTime(reader["Admissao_Usuario"]);
                    usuario.Permissao_Usuario = Convert.ToChar(reader["Permissao_Usuario"]);
                }
                
                return usuario;
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

        //usuario = new Usuario();

        //usuario.Id_Usuario = Convert.ToInt32(reader["Id_Usuario"]);
        //usuario.Login_Usuario = reader["Login_Usuario"].ToString();
        // usuario.Senha_Usuario = reader["Senha_Usuario"].ToString();
        // usuario.Nome_Usuario = reader["Nome_Usuario"].ToString();
        // usuario.Nasc_Usuario = reader["Nasc_Usuario"].ToString();
        //usuario.Cpf_Usuario = reader["Cpf_Usuario"].ToString();
        //usuario.Email_Usuario = reader["Email_Usuario"].ToString();
        // usuario.Telefone_Usuario = reader["Telefone_Usuario"].ToString();
        //usuario.Celular_Usuario = reader["Celular_Usuario"].ToString();
        // usuario.Admissao_Usuario = reader["Admissao_Usuario"].ToString();
        // usuario.QtdeReti_Usuario = reader["QtdeReti_Usuario"].ToString();
    }
}
