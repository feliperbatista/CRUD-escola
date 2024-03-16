using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using BCrypt.Net;
using static BCrypt.Net.BCrypt;

namespace CRUD_escola
{
    internal class DbUsuarios
    {
        public static MySqlConnection GetConnection()
        {
            string sql = Privado.sqlUsuario;
            MySqlConnection con = new MySqlConnection(sql);
            try
            {
                con.Open();
            } 
            catch (MySqlException)
            {
                MessageBox.Show("Não foi possível se conectar ao servidor.\r\nEntre em contato com feliperodriguesbatista@outlook.com", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return con;
        }

        public static async void AddUser(Usuarios user)
        {
            string sql = "INSERT INTO usuarios VALUES (NULL, @UsuarioNome, @UsuarioEmail, @UsuarioSenha, @Created_at)";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@UsuarioNome", MySqlDbType.VarString).Value = user.Nome;
            cmd.Parameters.Add("@UsuarioEmail", MySqlDbType.VarChar).Value = user.Email;
            cmd.Parameters.Add("@UsuarioSenha", MySqlDbType.VarChar).Value = user.Senha;
            cmd.Parameters.Add("@Created_at", MySqlDbType.Timestamp).Value = DateTime.Now;
            try
            {
                await cmd.ExecuteNonQueryAsync();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        public static bool verificaEmail(string email)
        {
            bool emailExiste = false;
            int i = 0;
            string sql = "SELECT * FROM usuarios WHERE email = @UsuarioEmail";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@UsuarioEmail", MySqlDbType.VarChar).Value = email;
            try
            {
                i = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                i += 1;
            }
            con.Close();
            if (i>0) emailExiste = true;
            return emailExiste;
        }

        public static bool verificaSenha(string email, string senha)
        {
            string senhaComHash = string.Empty;

            string sql = "SELECT SENHA FROM usuarios WHERE EMAIL = @UsuarioEmail";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new(sql, con);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@UsuarioEmail", MySqlDbType.VarChar).Value = email;
            try
            {
                MySqlDataReader reader = cmd.ExecuteReader();
                if(reader.HasRows) 
                {
                    reader.Read();
                    senhaComHash = reader.GetString(0); 
                }
                reader.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            bool senhaCorreta = Verify(senha, senhaComHash);
            return senhaCorreta;
        }

    }
}
