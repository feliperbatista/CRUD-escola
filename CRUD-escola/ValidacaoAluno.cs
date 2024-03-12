using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_escola
{
    internal class ValidacaoAluno
    {
        public static string ValidaNome(string nome)
        {
            if(nome == string.Empty || nome == "Nome")
                return "Preencha o nome do aluno.";
            if (!System.Text.RegularExpressions.Regex.IsMatch(nome, "^[a-zA-Z ]"))
                return "Nome inválido.";
            if (nome.Length < 3 || nome.Length > 50)
                return "Nome precisa ter 3 e 50 caracteres.";
            return string.Empty;
        }

        public static string ValidaSobrenome(string sobrenome)
        {
            if (sobrenome == string.Empty || sobrenome == "Sobrenome")
                return "Preencha o sobrenome do aluno.";
            if (!System.Text.RegularExpressions.Regex.IsMatch(sobrenome, "^[a-zA-Z ]"))
                return "Sobrenome inválido.";
            if (sobrenome.Length < 3 || sobrenome.Length > 50)
                return "Sobrenome precisa ter 3 e 50 caracteres.";
            return string.Empty;
        }

        public static string ValidaTelefone(string telefone)
        {
            if (telefone == string.Empty)
                return "Preencha o sobrenome do aluno.";
            if (!System.Text.RegularExpressions.Regex.IsMatch(telefone, "^\\([1-9]{2}\\) (?:[2-8]|9[0-9])[0-9]{3}\\-[0-9]{4}$"))
                return "Telefone inválido.";
            return string.Empty;
        }

        public static string ValidaMatricula(string matricula)
        {
            if (matricula == string.Empty)
                return "Preencha a matrícula do aluno.";
            if (matricula.Length != 6)
                return "Matrícula deve ter seis dígitos.";
            try
            {
                int matriculaInt = Convert.ToInt32(matricula);
            }
            catch(Exception)
            {
                return "Matrícula deve conter apenas números.";
            }
            return string.Empty;
        }

        public static string ValidaIdade(string idade)
        {
            if (idade == string.Empty || idade == "Idade")
                return "Preencha o idade do aluno.";
            if (idade.Length != 2)
                return "Insira uma idade válida.";
            try
            {
                int matriculaInt = Convert.ToInt32(idade);
            }
            catch (Exception)
            {
                return "Idade deve conter apenas números.";
            }
            return string.Empty;
        }

        public static string ValidaSerie(string serie)
        {
            if (serie == string.Empty || serie == "Série")
                return "Indique a série do aluno.";
            return string.Empty;
        }

        public static string ValidaTurma(string turma)
        {
            if (turma == string.Empty || turma == "Turma")
                return "Indique a turma do aluno.";
            return string.Empty;
        }

        public static string ValidaFoto(Image imagem)
        {
            imagem.Save("arquivo");
            var fileSizeInBytes = new FileInfo("arquivo").Length;
            if (fileSizeInBytes > 2000000)
            {
                return "Tamanho do arquivo de imagem inválido";
            }
            return string.Empty;
        }
    }
}
