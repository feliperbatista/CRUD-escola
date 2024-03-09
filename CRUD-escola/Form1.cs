using BCrypt.Net;
using static BCrypt.Net.BCrypt;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CRUD_escola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            buttonLogin.Click += ButtonLogin_Click;
            buttonCadastrar.Click += ButtonCadastrar_Click;
            buttonExibirSenhaLogin.Click += ButtonExibirSenhaLogin_Click;
            buttonExibirSenhaCadastro.Click += ButtonExibirSenhaCadastro_Click;
        }

        private string mensagemErro = string.Empty;

        private void ButtonLogin_Click(object? sender, EventArgs e)
        {
            mensagemErro = string.Empty;
            labelMensagemLogin.ForeColor = Color.IndianRed;

            string email = textBoxEmailLogin.Text;
            string senha = textBoxSenhaLogin.Text;

            //verificar se email já existe no banco de dados
            bool emailExiste = verificaEmail(email, labelMensagemLogin, "login");

            //verificar se senha inserida corresponde ao email na base de dados
            //se corresponder, abre-se novo formulário

            /*
            if(emailExiste)
            {
                if (verificaSenha(email, senha))
                {
                    Alunos alunos = (Alunos)Application.OpenForms["alunos"];
                    if(alunos == null)
                    {
                        alunos = new()
                        {
                            Name = "alunos"
                        };
                        alunos.Show();
                        labelMensagemLogin.Visible = false;
                    }
                    else
                    {
                        alunos.BringToFront();
                    }
                }
            }
            */
            Alunos alunos = new();
            alunos.Show();
        }

        private void ButtonCadastrar_Click(object? sender, EventArgs e)
        {
            mensagemErro = string.Empty;
            labelMensagemCadastro.ForeColor = Color.IndianRed;

            string email = textBoxEmailCadastro.Text;
            string senha = textBoxSenhaCadastro.Text;

            //verificar se email é valido
            bool emailValido = validaEmail(email);
            
            //verificar se email já existe no banco de dados
            bool emailExiste = verificaEmail(email, labelMensagemCadastro, "cadastro");
            
            //verificar senha
            bool senhaValida = validaSenha(senha, labelMensagemCadastro);
            

            if (emailValido && senhaValida &&!emailExiste)
            {
                //fazer hash da senha
                string senhaHash = HashPassword(senha);

                //cadastrar usuario na base de dados
                Usuarios user = new (email, senhaHash);
                DbUsuarios.AddUser(user);
                if (!labelMensagemCadastro.Visible) labelMensagemCadastro.Visible = true;
                labelMensagemCadastro.ForeColor = Color.Green;
                labelMensagemCadastro.Text = "Cadastro realizado com sucesso!";
            }
        }

        private bool validaEmail(string email)
        {
            if (string.IsNullOrEmpty(email))
            {
                mensagemErro = "Insira seu email.";
                labelMensagemCadastro.Text = mensagemErro;
                labelMensagemCadastro.Visible = true;
                return false;
            };

            bool emailValido = System.Text.RegularExpressions.Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"); ;

            if (!emailValido)
            {
                mensagemErro = "Email inválido.";
                labelMensagemCadastro.Text = mensagemErro;
                labelMensagemCadastro.Visible = true;
            }
            return emailValido;
        }

        private bool verificaEmail(string email, Label label, string opcao)
        {
            if (string.IsNullOrEmpty(email))
            {
                mensagemErro = "Email incorreto.";
                label.Text = mensagemErro;
                label.Visible = true;
                return false;
            }
            bool emailExiste = DbUsuarios.verificaEmail(email);
            if (!emailExiste && opcao=="login")
            {
                mensagemErro = "Email incorreto.";
                label.Text = mensagemErro;
                label.Visible = true;
            }
            if (emailExiste && opcao == "cadastro")
            {
                mensagemErro = "Email já cadastrado.";
                label.Text = mensagemErro;
                label.Visible = true;
            }
            return emailExiste;
        }

        private bool validaSenha(string senha, Label label)
        {
            bool senhaValida = true;

            if (string.IsNullOrEmpty(senha))
            {
                mensagemErro += "\r\nInsira sua senha.";
                label.Text = mensagemErro;
                label.Visible = true;
                return senhaValida = false;
            }
            if (senha.Length < 3 || senha.Length > 50) senhaValida = false;

            if (!senhaValida)
            {
                if (string.IsNullOrEmpty(mensagemErro))
                {
                    mensagemErro += "\r\nSenha inválida: senha precisa ter entre 3 e 50 caracteres.";
                }
                else
                {
                    mensagemErro += "Senha inválida: senha precisa ter entre 3 e 50 caracteres.";
                }

                label.Text = mensagemErro;
                label.Visible = true;
            }
            return senhaValida;
        }

        private bool verificaSenha(string email, string senha)
        {
            if(string.IsNullOrEmpty(senha))
            {
                mensagemErro = "Insira sua senha.";
                labelMensagemLogin.Text = mensagemErro;
                labelMensagemLogin.Visible = true;
                return false;
            }
            bool senhaCorreta = DbUsuarios.verificaSenha(email, senha);
            if (!senhaCorreta)
            {
                labelMensagemLogin.Text = "Senha incorreta.";
                labelMensagemLogin.Visible = true;
            }
            return senhaCorreta;
        }

        private void ButtonExibirSenhaLogin_Click(object? sender, EventArgs e)
        {
            if (textBoxSenhaLogin.PasswordChar == '\0')
                textBoxSenhaLogin.PasswordChar = '*';
            else
                textBoxSenhaLogin.PasswordChar = '\0';
        }

        private void ButtonExibirSenhaCadastro_Click(object? sender, EventArgs e)
        {
            if (textBoxSenhaCadastro.PasswordChar == '\0')
                textBoxSenhaCadastro.PasswordChar = '*';
            else
                textBoxSenhaCadastro.PasswordChar = '\0';
        }
    }
}
