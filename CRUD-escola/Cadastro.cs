using CRUD_escola.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace CRUD_escola
{
    public partial class Cadastro : Form
    {
        private bool borda;

        public Cadastro()
        {
            InitializeComponent();

            pictureBoxCadastrar.Click += PictureBoxCadastrar_Click;
            pictureBoxExibirSenhaCadastro.Click += PictureBoxExibirSenhaCadastro_Click;


            textBoxNomeCadastro.Enter += TextBoxNomeCadastro_Enter;
            textBoxEmailCadastro.Enter += TextBoxEmailCadastro_Enter;
            textBoxSenhaCadastro.Enter += TextBoxSenhaCadastro_Enter;

            textBoxNomeCadastro.Leave += TextBoxNomeCadastro_Leave;
            textBoxEmailCadastro.Leave += TextBoxEmailCadastro_Leave;
            textBoxSenhaCadastro.Leave += TextBoxSenhaCadastro_Leave;

            panelNomeCadastro.Paint += PanelNomeCadastro_Paint;
            panelEmailCadastro.Paint += PanelEmailCadastro_Paint;
            panelSenhaCadastro.Paint += PanelSenhaCadastro_Paint;

            pictureBoxCadastrar.MouseEnter += PictureBoxCadastrar_MouseEnter;
            pictureBoxCadastrar.MouseLeave += PictureBoxCadastrar_MouseLeave;


            pictureBoxNomeCadastro.Click += PictureBoxNomeCadastro_Click;
            pictureBoxEmailCadastro.Click += PictureBoxEmailCadastro_Click;
            pictureBoxSenhaCadastro.Click += PictureBoxSenhaCadastro_Click;

            panelNomeCadastro.Click += PanelNomeCadastro_Click;
            panelEmailCadastro.Click += PanelEmailCadastro_Click;
            panelSenhaCadastro.Click += PanelSenhaCadastro_Click;


            textBoxNomeCadastro.TextChanged += TextBoxNomeCadastro_TextChanged;
            textBoxEmailCadastro.TextChanged += TextBoxEmailCadastro_TextChanged;
            textBoxSenhaCadastro.TextChanged += TextBoxSenhaCadastro_TextChanged;

            pictureBoxFecharJanela.Click += PictureBoxFecharJanela_Click;
            pictureBoxFecharJanela.MouseEnter += PictureBoxFecharJanela_MouseEnter;
            pictureBoxFecharJanela.MouseLeave += PictureBoxFecharJanela_MouseLeave;
            
            ActiveControl = labelLogin;

            borda = true;
        }

        private void PictureBoxCadastrar_Click(object? sender, EventArgs e)
        {
            string nome = textBoxNomeCadastro.Text;
            string email = textBoxEmailCadastro.Text;
            string senha = textBoxSenhaCadastro.Text;
            borda = false;

            pictureBoxCadastrar.Focus();
            textBoxNomeCadastro.ForeColor = Form1.cinza;
            Validacao.pintarBorda(panelNomeCadastro, Form1.cinza);
            pictureBoxNomeCadastro.Image = Resources.icone_pessoa;
            textBoxEmailCadastro.ForeColor = Form1.cinza;
            Validacao.pintarBorda(panelEmailCadastro, Form1.cinza);
            pictureBoxEmailCadastro.Image = Resources.icone_email;
            textBoxSenhaCadastro.ForeColor = Form1.cinza;
            Validacao.pintarBorda(panelSenhaCadastro, Form1.cinza);
            pictureBoxSenhaCadastro.Image = Resources.icone_senha;
            if (textBoxSenhaCadastro.Text != "Digite sua senha")
                textBoxSenhaCadastro.PasswordChar = '●';
            pictureBoxExibirSenhaCadastro.Image = Resources.button_exibir_senha_cinza;

            //verificar se nome é valido
            bool nomeValido = Validacao.validaNome(nome, labelErroNomeCadastro, panelNomeCadastro, pictureBoxNomeCadastro);

            //verificar se email é valido
            bool emailValido = Validacao.validaEmail(email, labelErroEmailCadastro, panelEmailCadastro, pictureBoxEmailCadastro);

            //verificar senha
            bool senhaValida = Validacao.validaSenha(senha, labelErroSenhaCadastro, textBoxSenhaCadastro, panelSenhaCadastro, pictureBoxSenhaCadastro, pictureBoxExibirSenhaCadastro);

            if(!nomeValido || !emailValido || !senhaValida)
                return;

            //verificar se email já existe no banco de dados
            bool emailExiste = Validacao.verificaEmail(email, labelErroEmailCadastro, textBoxEmailCadastro, panelEmailCadastro, pictureBoxEmailCadastro);
            
            if (nomeValido & emailValido && senhaValida && !emailExiste)
            {
                int codigo = gerarCodigo();
                Email.EnviarEmail(textBoxEmailCadastro.Text, codigo);
                ConfirmaCadastro confirma = new(nome, email, senha, codigo);
                confirma.ShowDialog();
            }
        }

        private void PictureBoxExibirSenhaCadastro_Click(object? sender, EventArgs e)
        {
            if (textBoxSenhaCadastro.Focused)
            {
                if (textBoxSenhaCadastro.PasswordChar == '\0')
                {
                    pictureBoxExibirSenhaCadastro.Image = Resources.button_exibir_senha;
                    textBoxSenhaCadastro.PasswordChar = '●';
                }
                else
                {
                    pictureBoxExibirSenhaCadastro.Image = Resources.button_esconder_senha;
                    textBoxSenhaCadastro.PasswordChar = '\0';
                }
            }
            else
            {
                if (textBoxSenhaCadastro.PasswordChar == '\0')
                {
                    pictureBoxExibirSenhaCadastro.Image = Resources.button_exibir_senha_cinza;
                    textBoxSenhaCadastro.PasswordChar = '●';
                }
                else
                {
                    pictureBoxExibirSenhaCadastro.Image = Resources.button_esconder_senha_cinza;
                    textBoxSenhaCadastro.PasswordChar = '\0';
                }
            }
        }

        private void TextBoxNomeCadastro_Enter(object? sender, EventArgs e)
        {
            pictureBoxNomeCadastro.Image = Resources.icone_pessoa_colorido;
            textBoxNomeCadastro.ForeColor = Form1.verde;
            if (textBoxNomeCadastro.Text == "Digite seu nome")
            {
                textBoxNomeCadastro.Text = string.Empty;
            }
            borda = false;
            Validacao.pintarBorda(panelNomeCadastro, Form1.verde);
        }


        private void TextBoxNomeCadastro_Leave(object? sender, EventArgs e)
        {
            textBoxNomeCadastro.ForeColor = Color.Silver;
            pictureBoxNomeCadastro.Image = Resources.icone_pessoa;
            if (textBoxNomeCadastro.Text == string.Empty)
            {
                textBoxNomeCadastro.Text = "Digite seu nome";
            }
            Validacao.pintarBorda(panelNomeCadastro, Form1.cinza);
        }

        private void TextBoxEmailCadastro_Enter(object? sender, EventArgs e)
        {
            pictureBoxEmailCadastro.Image = Resources.icone_email_colorido;
            textBoxEmailCadastro.ForeColor = Form1.verde;
            if (textBoxEmailCadastro.Text == "Digite seu email")
            {
                textBoxEmailCadastro.Text = string.Empty;
            }
            borda = false;
            Validacao.pintarBorda(panelEmailCadastro, Form1.verde);
        }

        private void TextBoxEmailCadastro_Leave(object? sender, EventArgs e)
        {
            textBoxEmailCadastro.ForeColor = Color.Silver;
            pictureBoxEmailCadastro.Image = Resources.icone_email;
            if (textBoxEmailCadastro.Text == string.Empty)
            {
                textBoxEmailCadastro.Text = "Digite seu email";
            }
            Validacao.pintarBorda(panelEmailCadastro, Form1.cinza);
        }

        private void TextBoxSenhaCadastro_Enter(object? sender, EventArgs e)
        {
            pictureBoxSenhaCadastro.Image = Resources.icone_senha_colorido;
            pictureBoxExibirSenhaCadastro.Image = Resources.button_exibir_senha;
            textBoxSenhaCadastro.ForeColor = Color.FromArgb(14, 201, 120);
            if (textBoxSenhaCadastro.Text == "Digite sua senha")
            {
                textBoxSenhaCadastro.PasswordChar = '●';
                textBoxSenhaCadastro.Text = string.Empty;
            }
            borda = false;
            Validacao.pintarBorda(panelSenhaCadastro, Form1.verde);
        }

        private void TextBoxSenhaCadastro_Leave(object? sender, EventArgs e)
        {
            textBoxSenhaCadastro.ForeColor = Color.Silver;
            pictureBoxSenhaCadastro.Image = Resources.icone_senha;
            if (textBoxSenhaCadastro.Text == string.Empty)
            {
                textBoxSenhaCadastro.Text = "Digite sua senha";
                textBoxSenhaCadastro.PasswordChar = '\0';
            }
            else
                textBoxSenhaCadastro.PasswordChar = '●';
            pictureBoxExibirSenhaCadastro.Image = Resources.button_exibir_senha_cinza;
            Validacao.pintarBorda(panelSenhaCadastro, Form1.cinza);
        }

        private void PanelNomeCadastro_Paint(object? sender, PaintEventArgs e)
        {
            if (borda)
            {
                Validacao.pintarBorda(panelNomeCadastro, Form1.cinza);
            }
        }

        private void PanelEmailCadastro_Paint(object? sender, PaintEventArgs e)
        {
            if (borda)
            {
                Validacao.pintarBorda(panelEmailCadastro, Form1.cinza);
            }
        }

        private void PanelSenhaCadastro_Paint(object? sender, PaintEventArgs e)
        {
            if (borda)
            {
                Validacao.pintarBorda(panelSenhaCadastro, Form1.cinza);
            }
        }

        private void PictureBoxCadastrar_MouseEnter(object? sender, EventArgs e)
        {
            pictureBoxCadastrar.Image = Resources.button_cadastrar;
        }

        private void PictureBoxCadastrar_MouseLeave(object? sender, EventArgs e)
        {
            pictureBoxCadastrar.Image = Resources.button_cadastrar_colorido;
        }

        private void PictureBoxNomeCadastro_Click(object? sender, EventArgs e)
        {
            textBoxNomeCadastro.Focus();
        }

        private void PictureBoxEmailCadastro_Click(object? sender, EventArgs e)
        {
            textBoxEmailCadastro.Focus();
        }

        private void PictureBoxSenhaCadastro_Click(object? sender, EventArgs e)
        {
            textBoxSenhaCadastro.Focus();
            pictureBoxExibirSenhaCadastro.Image = Resources.button_exibir_senha;
        }

        private void PanelNomeCadastro_Click(object? sender, EventArgs e)
        {
            textBoxNomeCadastro.Focus();
        }

        private void PanelEmailCadastro_Click(object? sender, EventArgs e)
        {
            textBoxEmailCadastro.Focus();
        }

        private void PanelSenhaCadastro_Click(object? sender, EventArgs e)
        {
            textBoxSenhaCadastro.Focus();
            pictureBoxExibirSenhaCadastro.Image = Resources.button_exibir_senha;
        }

        private void TextBoxNomeCadastro_TextChanged(object? sender, EventArgs e)
        {
            labelErroNomeCadastro.Visible = false;
            Validacao.pintarBorda(panelNomeCadastro, Form1.verde);
            if (textBoxNomeCadastro.Text != "Digite seu nome")
            {
                textBoxNomeCadastro.ForeColor = Form1.verde;
                pictureBoxNomeCadastro.Image = Resources.icone_pessoa_colorido;
            }
        }

        private void TextBoxEmailCadastro_TextChanged(object? sender, EventArgs e)
        {
            labelErroEmailCadastro.Visible = false;
            Validacao.pintarBorda(panelEmailCadastro, Form1.verde);
            if (textBoxEmailCadastro.Text != "Digite seu email")
            {
                textBoxEmailCadastro.ForeColor = Form1.verde;
                pictureBoxEmailCadastro.Image = Resources.icone_email_colorido;
            }
        }

        private void TextBoxSenhaCadastro_TextChanged(object? sender, EventArgs e)
        {
            labelErroSenhaCadastro.Visible = false;
            Validacao.pintarBorda(panelSenhaCadastro, Form1.verde);
            if (textBoxSenhaCadastro.Text != "Digite sua senha")
            {
                textBoxSenhaCadastro.ForeColor = Form1.verde;
                pictureBoxSenhaCadastro.Image = Resources.icone_senha_colorido;
                pictureBoxExibirSenhaCadastro.Image = Resources.button_exibir_senha;
            }
        }

        private void PictureBoxFecharJanela_Click(object? sender, EventArgs e)
        {
            Close();
        }

        private void PictureBoxFecharJanela_MouseLeave(object? sender, EventArgs e)
        {
            pictureBoxFecharJanela.Image = Resources.button_fechar_janela;
        }

        private void PictureBoxFecharJanela_MouseEnter(object? sender, EventArgs e)
        {
            pictureBoxFecharJanela.Image = Resources.button_fechar_janela_2;
        }

        private static int gerarCodigo()
        {
            Random random = new();
            return random.Next(100000, 999999);
        }
    }
}
