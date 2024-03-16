using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static BCrypt.Net.BCrypt;


namespace CRUD_escola
{
    public partial class ConfirmaCadastro : Form
    {
        private string Nome = string.Empty;
        private string Email = string.Empty;
        private string Senha = string.Empty;
        private int Codigo = 0;

        public ConfirmaCadastro(string nome, string email, string senha, int codigo)
        {
            InitializeComponent();

            Nome = nome;
            Email = email;
            Senha = senha;
            Codigo = codigo;
       
            pictureBoxConfirmar.Click += PictureBoxConfirmar_Click;
        }

        private void PictureBoxConfirmar_Click(object? sender, EventArgs e)
        {
            if (textBoxCodigo.Text == Codigo.ToString())
            {
                //fazer hash da senha
                string senhaHash = HashPassword(Senha);

                //cadastrar usuario na base de dados
                Usuarios user = new(Nome, Email, senhaHash);
                DbUsuarios.AddUser(user);
                MessageBox.Show("Cadastro concluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
                MessageBox.Show("Código inválido");
        }
    }
}
