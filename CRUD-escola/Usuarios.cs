using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_escola
{
    internal class Usuarios
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        public Usuarios(string nome, string email, string senha) 
        {
            Nome = nome;
            Email = email;
            Senha = senha;
        }
    }
}
