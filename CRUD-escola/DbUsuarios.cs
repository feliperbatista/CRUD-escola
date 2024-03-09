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
            string sql = "Server = localhost; Port = 3306; Database = users; Uid = root; Pwd = @Fb010299";
            MySqlConnection con = new MySqlConnection(sql);
            try
            {
                con.Open();
            } 
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return con;
        }

        public static async void AddUser(Usuarios user)
        {
            string sql = "INSERT INTO usuarios VALUES (NULL, @UsuarioEmail, @UsuarioSenha, NULL, NULL )";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@UsuarioEmail", MySqlDbType.VarChar).Value = user.Email;
            cmd.Parameters.Add("@UsuarioSenha", MySqlDbType.VarChar).Value = user.Senha;
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
            string sql = "SELECT * FROM usuarios WHERE EMAIL = @UsuarioEmail";
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
