using BCrypt.Net;
using CRUD_escola.Properties;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CRUD_escola
{
    public partial class Form1 : Form
    {
        public static Color cinza = Color.LightGray;
        public static Color vermelho = Color.IndianRed;
        public static Color verde = Color.FromArgb(14, 201, 120);
        private bool senhaVisivel = false;

        public Form1()
        {
            InitializeComponent();

            pictureBoxLogin.Click += PictureBoxLogin_Click;
            pictureBoxCadastrar.Click += PictureBoxCadastrar_Click;
            pictureBoxExibirSenhaLogin.Click += PictureBoxExibirSenhaLogin_Click;


            textBoxEmailLogin.Enter += TextBoxEmailLogin_Enter;
            textBoxEmailLogin.Leave += TextBoxEmailLogin_Leave;
            textBoxSenhaLogin.Enter += TextBoxSenhaLogin_Enter;
            textBoxSenhaLogin.Leave += TextBoxSenhaLogin_Leave;

            pictureBoxEmailLogin.Click += PictureBoxEmailLogin_Click;
            pictureBoxSenhaLogin.Click += PictureBoxSenhaLogin_Click;

            panelEmailLogin.Click += PanelEmailLogin_Click;
            panelSenhaLogin.Click += PanelSenhaLogin_Click;

            pictureBoxLogin.MouseEnter += PictureBoxLogin_MouseEnter;
            pictureBoxLogin.MouseLeave += PictureBoxLogin_MouseLeave;
            pictureBoxCadastrar.MouseEnter += PictureBoxCadastrar_MouseEnter;
            pictureBoxCadastrar.MouseLeave += PictureBoxCadastrar_MouseLeave;

            panelEmailLogin.Paint += PanelEmailLogin_Paint;
            panelSenhaLogin.Paint += PanelSenhaLogin_Paint;

            textBoxEmailLogin.TextChanged += TextBoxEmailLogin_TextChanged;
            textBoxSenhaLogin.TextChanged += TextBoxSenhaLogin_TextChanged;

            pictureBoxFecharJanela.Click += PictureBoxFecharJanela_Click;

            pictureBoxFecharJanela.MouseEnter += PictureBoxFecharJanela_MouseEnter;
            pictureBoxFecharJanela.MouseLeave += PictureBoxFecharJanela_MouseLeave;

            ActiveControl = label1;
        }

        private void PictureBoxLogin_Click(object? sender, EventArgs e)
        {
            string email = textBoxEmailLogin.Text;
            string senha = textBoxSenhaLogin.Text;
            Validacao.erroSenha = false;

            textBoxEmailLogin.ForeColor = cinza;
            Validacao.pintarBorda(panelEmailLogin, cinza);
            pictureBoxEmailLogin.Image = Resources.icone_email;
            textBoxSenhaLogin.ForeColor = cinza;
            Validacao.pintarBorda(panelSenhaLogin, cinza);
            pictureBoxSenhaLogin.Image = Resources.icone_senha;
            if(textBoxSenhaLogin.Text != "Digite sua senha")
                textBoxSenhaLogin.PasswordChar = '●';
            pictureBoxExibirSenhaLogin.Image = Resources.button_exibir_senha_cinza;

            //verificar se email já existe no banco de dados

            bool emailValido = Validacao.validaEmail(email, labelErroEmailLogin, panelEmailLogin, pictureBoxEmailLogin);
            bool senhaValida = Validacao.validaSenha(senha, labelErroSenhaLogin, textBoxSenhaLogin, panelSenhaLogin, pictureBoxSenhaLogin, pictureBoxExibirSenhaLogin);

            if (!emailValido || !senhaValida)
                return;
                

            bool emailExiste = Validacao.verificaEmail(email, labelErroEmailLogin, textBoxEmailLogin, panelEmailLogin, pictureBoxEmailLogin);

            //verificar se senha inserida corresponde ao email na base de dados
            //se corresponder, abre-se novo formulário

            
            if (emailExiste)
            {
                if (Validacao.verificaSenha(email, senha, labelErroSenhaLogin, panelSenhaLogin, pictureBoxSenhaLogin, pictureBoxExibirSenhaLogin))
                {
                    Alunos alunos = (Alunos)Application.OpenForms["alunos"];
                    if (alunos == null)
                    {
                        alunos = new()
                        {
                            Name = "alunos"
                        };
                        alunos.Show();
                    }
                    else
                    {
                        if(alunos.WindowState == FormWindowState.Minimized)
                            alunos.WindowState = FormWindowState.Normal;
                        alunos.BringToFront();
                    }
                }
            }
        }

        private void PictureBoxCadastrar_Click(object? sender, EventArgs e)
        {
            Cadastro cadastro = new();
            cadastro.Show();
        }

        private void PictureBoxExibirSenhaLogin_Click(object? sender, EventArgs e)
        {
            if (senhaVisivel)
                senhaVisivel = false;
            else
                senhaVisivel = true;
            if (textBoxSenhaLogin.Focused)
            {
                if (senhaVisivel)
                {
                    pictureBoxExibirSenhaLogin.Image = Resources.button_exibir_senha;
                    textBoxSenhaLogin.PasswordChar = '●';
                }
                else
                {
                    pictureBoxExibirSenhaLogin.Image = Resources.button_esconder_senha;
                    textBoxSenhaLogin.PasswordChar = '\0';
                }
            }
            else
            {
                if (senhaVisivel)
                {
                    textBoxSenhaLogin.PasswordChar = '●';
                    if (Validacao.erroSenha)
                        pictureBoxExibirSenhaLogin.Image = Resources.button_exibir_senha_erro;
                    else
                        pictureBoxExibirSenhaLogin.Image = Resources.button_exibir_senha_cinza;
                }
                else
                {
                    textBoxSenhaLogin.PasswordChar = '\0';
                    if(Validacao.erroSenha)
                        pictureBoxExibirSenhaLogin.Image = Resources.button_esconder_senha_erro;
                    else
                        pictureBoxExibirSenhaLogin.Image = Resources.button_esconder_senha_cinza;

                }
            }   
        }


        private void TextBoxEmailLogin_Enter(object? sender, EventArgs e)
        {
            pictureBoxEmailLogin.Image = Resources.icone_email_colorido;
            textBoxEmailLogin.ForeColor = verde;
            if (textBoxEmailLogin.Text == "Digite seu email")
            {
                textBoxEmailLogin.Text = string.Empty;
            }
            Validacao.pintarBorda(panelEmailLogin, verde);
        }

        private void TextBoxEmailLogin_Leave(object? sender, EventArgs e)
        {
            textBoxEmailLogin.ForeColor = Color.Silver;
            pictureBoxEmailLogin.Image = Resources.icone_email;
            if (textBoxEmailLogin.Text == string.Empty)
            {
                textBoxEmailLogin.Text = "Digite seu email";
            }
            Validacao.pintarBorda(panelEmailLogin, cinza);
        }

        private void TextBoxSenhaLogin_Enter(object? sender, EventArgs e)
        {
            textBoxSenhaLogin.BackColor = Color.White;
            pictureBoxSenhaLogin.Image = Resources.icone_senha_colorido;
            pictureBoxExibirSenhaLogin.Image = Resources.button_exibir_senha;
            textBoxSenhaLogin.ForeColor = verde;
            if (textBoxSenhaLogin.Text == "Digite sua senha")
            {
                textBoxSenhaLogin.PasswordChar = '●';
                textBoxSenhaLogin.Text = string.Empty;
            }
            Validacao.pintarBorda(panelSenhaLogin, verde);

        }

        private void TextBoxSenhaLogin_Leave(object? sender, EventArgs e)
        {
            textBoxSenhaLogin.ForeColor = Color.Silver;
            pictureBoxSenhaLogin.Image = Resources.icone_senha;
            if (textBoxSenhaLogin.Text == string.Empty)
            {
                textBoxSenhaLogin.Text = "Digite sua senha";
                textBoxSenhaLogin.PasswordChar = '\0';
            }
            else
                textBoxSenhaLogin.PasswordChar = '●';
            pictureBoxExibirSenhaLogin.Image = Resources.button_exibir_senha_cinza;
            Validacao.pintarBorda(panelSenhaLogin, cinza);
        }

        private void PanelEmailLogin_Paint(object? sender, PaintEventArgs e)
        {
            Validacao.pintarBorda(panelEmailLogin, cinza);
        }

        private void PanelSenhaLogin_Paint(object? sender, PaintEventArgs e)
        {
            Validacao.pintarBorda(panelSenhaLogin, cinza);
        }

        private void PictureBoxLogin_MouseEnter(object? sender, EventArgs e)
        {
            pictureBoxLogin.Image = Resources.buttonn_login_branco;
        }

        private void PictureBoxLogin_MouseLeave(object? sender, EventArgs e)
        {
            pictureBoxLogin.Image = Resources.button_login_colorido;
        }

        private void PictureBoxCadastrar_MouseEnter(object? sender, EventArgs e)
        {
            pictureBoxCadastrar.Image = Resources.button_cadastrar_inicio_colorido;
        }

        private void PictureBoxCadastrar_MouseLeave(object? sender, EventArgs e)
        {
            pictureBoxCadastrar.Image = Resources.button_cadastro_inicio;
        }


        private void PictureBoxEmailLogin_Click(object? sender, EventArgs e)
        {
            textBoxEmailLogin.Focus();
        }

        private void PictureBoxSenhaLogin_Click(object? sender, EventArgs e)
        {
            textBoxSenhaLogin.Focus();
            pictureBoxExibirSenhaLogin.Image = Resources.button_exibir_senha;
        }

        private void PanelEmailLogin_Click(object? sender, EventArgs e)
        {
            textBoxEmailLogin.Focus();
        }

        private void PanelSenhaLogin_Click(object? sender, EventArgs e)
        {
            textBoxSenhaLogin.Focus();
            pictureBoxExibirSenhaLogin.Image = Resources.button_exibir_senha;
        }


        private void TextBoxEmailLogin_TextChanged(object? sender, EventArgs e)
        {
            labelErroEmailLogin.Visible = false;
            Validacao.pintarBorda(panelEmailLogin, verde);
            if (textBoxEmailLogin.Text != "Digite seu email")
            {
                textBoxEmailLogin.ForeColor = verde;
                pictureBoxEmailLogin.Image = Resources.icone_email_colorido;
            }
        }

        private void TextBoxSenhaLogin_TextChanged(object? sender, EventArgs e)
        {
            labelErroSenhaLogin.Visible = false;
            Validacao.pintarBorda(panelSenhaLogin, verde);
            Validacao.erroSenha = false;
            if (textBoxSenhaLogin.Text != "Digite sua senha")
            {
                textBoxSenhaLogin.ForeColor = verde;
                pictureBoxSenhaLogin.Image = Resources.icone_senha_colorido;
                pictureBoxExibirSenhaLogin.Image = Resources.button_exibir_senha;
                textBoxSenhaLogin.PasswordChar = '●';
            }
        }

        private void PictureBoxFecharJanela_Click(object? sender, EventArgs e)
        {
            Close();
        }

        private void PictureBoxFecharJanela_MouseEnter(object? sender, EventArgs e)
        {
            pictureBoxFecharJanela.Image = Resources.button_fechar_janela_2;
        }

        private void PictureBoxFecharJanela_MouseLeave(object? sender, EventArgs e)
        {
            pictureBoxFecharJanela.Image = Resources.button_fechar_janela;
        }
    }
}
