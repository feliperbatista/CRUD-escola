using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_escola
{
    internal class DbAlunos
    {
        public static MySqlConnection GetConnection()
        {
            string sql = "Server = localhost; Port = 3306; Database = escola; Uid = root; Pwd =";
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

        public static async void AddAluno(Aluno aluno)
        {
            string sql = "INSERT INTO alunos VALUES (NULL, @AlunoNome, @AlunoSobrenome, @AlunoContato, @AlunoMatricula, @AlunoIdade" +
                ", @AlunoSerie, @AlunoTurma, @AlunoFoto, NULL, NULL)";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@AlunoNome", MySqlDbType.VarChar).Value = aluno.Nome;
            cmd.Parameters.Add("@AlunoSobrenome", MySqlDbType.VarChar).Value = aluno.Sobrenome;
            cmd.Parameters.Add("@AlunoContato", MySqlDbType.VarChar).Value = aluno.Contato;
            cmd.Parameters.Add("@AlunoMatricula", MySqlDbType.Int64).Value = aluno.Matricula;
            cmd.Parameters.Add("@AlunoIdade", MySqlDbType.Int16).Value = aluno.Idade;
            cmd.Parameters.Add("@AlunoSerie", MySqlDbType.Int16).Value = aluno.Serie;
            cmd.Parameters.Add("@AlunoTurma", MySqlDbType.VarChar).Value = aluno.Turma;
            cmd.Parameters.Add("@AlunoFoto", MySqlDbType.LongBlob).Value = aluno.Foto;
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

        public static DataSet ReadAlunos()
        {
            string sql = "SELECT NOME, SOBRENOME, CONTATO, MATRICULA, IDADE, SERIE, TURMA FROM ALUNOS";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            try
            {
                using(MySqlDataAdapter adapter =  new MySqlDataAdapter(sql, con))
                {
                    DataSet dataSet = new DataSet();
                    adapter.Fill(dataSet);
                    return dataSet;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
            return null;
        }

        public static void UpdateAluno(Aluno aluno)
        {
            string sql = "UPDATE alunos SET NOME = @AlunoNome, SOBRENOME = @AlunoSobrenome, CONTATO = @AlunoContato, IDADE = @AlunoIdade," +
                "SERIE = @AlunoSerie, TURMA = @AlunoTurma, FOTO = @AlunoFoto, UPDATED_AT = @UpdatedAt WHERE MATRICULA = @AlunoMatricula";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@AlunoNome", MySqlDbType.VarChar).Value = aluno.Nome;
            cmd.Parameters.Add("@AlunoSobrenome", MySqlDbType.VarChar).Value = aluno.Sobrenome;
            cmd.Parameters.Add("@AlunoContato", MySqlDbType.VarChar).Value = aluno.Contato;
            cmd.Parameters.Add("@AlunoIdade", MySqlDbType.Int16).Value = aluno.Idade;
            cmd.Parameters.Add("@AlunoSerie", MySqlDbType.Int16).Value = aluno.Serie;
            cmd.Parameters.Add("@AlunoTurma", MySqlDbType.VarChar).Value = aluno.Turma;
            cmd.Parameters.Add("@AlunoFoto", MySqlDbType.LongBlob).Value = aluno.Foto;
            cmd.Parameters.Add("@UpdatedAt", MySqlDbType.Timestamp).Value = DateTime.Now;
            cmd.Parameters.Add("@AlunoMatricula", MySqlDbType.Int64).Value = aluno.Matricula;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        public static void DeleteAlunos(int matricula)
        {
            string sql = "DELETE FROM alunos WHERE MATRICULA = @AlunoMatricula";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@AlunoMatricula", MySqlDbType.Int32).Value = matricula;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        public static bool verificaMatricula(int matricula)
        {
            bool matriculaExiste = false;
            int i = 0;
            string sql = "SELECT * FROM alunos WHERE MATRICULA = @UsuarioMatricula";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@UsuarioMatricula", MySqlDbType.Int32).Value = matricula;
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
            if (i > 0) matriculaExiste = true;
            return matriculaExiste;
        }

        public static byte[] pegarFoto(int matricula)
        {
            string sql = "SELECT FOTO FROM alunos WHERE MATRICULA = @UsuarioMatricula";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@UsuarioMatricula", MySqlDbType.Int32).Value = matricula;

            try
            {
                byte[] foto = (byte[])(cmd.ExecuteScalar());
                return foto;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
            return null;
        }
    }
}
