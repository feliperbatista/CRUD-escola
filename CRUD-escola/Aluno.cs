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
        public int Matricula { get; set; }
        public int Idade { get; set; }
        public string Turma { get; set; }
        public byte[] Foto { get; set; }

        public Aluno(string nome, int matricula, int idade, string turma, byte[] foto)
        {
            Nome = nome;
            Matricula = matricula;
            Idade = idade;
            Turma = turma;
            Foto = foto;
        }
    }
}
