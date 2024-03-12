using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_escola
{
    internal class Aluno
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Contato { get; set; }
        public int Matricula { get; set; }
        public int Idade { get; set; }
        public int Serie { get; set; }
        public string Turma { get; set; }
        public byte[] Foto { get; set; }

        public Aluno(string nome, string sobrenome, string contato, int matricula, int idade, int serie, string turma, byte[] foto)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Contato = contato;
            Matricula = matricula;
            Idade = idade;
            Serie = serie;
            Turma = turma;
            Foto = foto;
        }
    }
}
