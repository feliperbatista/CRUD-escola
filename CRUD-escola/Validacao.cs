using CRUD_escola.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_escola
{
    internal class Validacao
    {
        public static bool erroSenha;

        public static bool validaNome(string nome, Label label, Panel panel, PictureBox pb)
        {
            if (nome == "Digite seu nome" || string.IsNullOrEmpty(nome))
            {
                label.Text = "Insira seu nome";
                label.Visible = true;
                pintarBorda(panel, Form1.vermelho);
                pb.Image = Resources.icone_pessoa_erro;
                foreach(Control control in panel.Controls)
                {
                    control.ForeColor = Form1.vermelho;
                }
                return false;
            }
            return true;    
        }

        public static bool validaEmail(string email, Label label, Panel panel, PictureBox pb)
        {
            if (email == "Digite seu email" || email == string.Empty)
            {
                label.Text = "Insira seu email";
                label.Visible = true;
                pintarBorda(panel, Form1.vermelho);
                pb.Image = Resources.icone_email_erro;
                foreach (Control control in panel.Controls)
                {
                    control.ForeColor = Form1.vermelho;
                }
                return false;
            }
            bool emailValido = System.Text.RegularExpressions.Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"); ;

            if (!emailValido)
            {
                label.Text = "Insira um email válido";
                label.Visible = true;
                pintarBorda(panel, Form1.vermelho);
                pb.Image = Resources.icone_email_erro;
                foreach (Control control in panel.Controls)
                {
                    control.ForeColor = Form1.vermelho;
                }
            }
            return emailValido;
        }

        public static bool verificaEmail(string email, Label label, TextBox opcao, Panel panel, PictureBox pb)
        {
            bool emailExiste = DbUsuarios.verificaEmail(email);
            if (!emailExiste && opcao.Name == "login")
            {
                label.Text = "Email não encontrado";
                label.Visible = true;
                pintarBorda(panel, Form1.vermelho);
                pb.Image = Resources.icone_email_erro;
                foreach (Control control in panel.Controls)
                {
                    control.ForeColor = Form1.vermelho;
                }
                return emailExiste;
            }
            if (emailExiste && opcao.Name == "textBoxEmailCadastro")
            {
                label.Text = "Email já cadastrado";
                label.Visible = true;
                pintarBorda(panel, Form1.vermelho);
                pb.Image = Resources.icone_email_erro;
                foreach (Control control in panel.Controls)
                {
                    control.ForeColor = Form1.vermelho;
                }
            }
            return emailExiste;
        }

        public static bool validaSenha(string senha, Label label, TextBox opcao, Panel panel, PictureBox pbIcone, PictureBox pbSenha)
        {
            bool senhaValida = true;

            if (senha == "Digite sua senha" || senha == string.Empty)
            {
                label.Text = "Insira sua senha";
                label.Visible = true;
                pintarBorda(panel, Form1.vermelho);
                pbIcone.Image = Resources.icone_senha_erro;
                pbSenha.Image = Resources.button_exibir_senha_erro;
                foreach (Control control in panel.Controls)
                {
                    control.ForeColor = Form1.vermelho;
                }
                erroSenha = true;
                return false;
            }
            if (senha.Length < 3 || senha.Length > 50) 
            {
                label.Text = "A senha deve possuir entre 3 e 50 dígitos";
                label.Visible = true;
                pintarBorda(panel, Form1.vermelho);
                pbIcone.Image = Resources.icone_senha_erro;
                pbSenha.Image = Resources.button_exibir_senha_erro;
                foreach (Control control in panel.Controls)
                {
                    control.ForeColor = Form1.vermelho;
                }
                erroSenha = true;    
                return false;
            } 
            return senhaValida;
        }

        public static bool verificaSenha(string email, string senha, Label label, Panel panel,PictureBox pbIcone, PictureBox pbSenha)
        {
            bool senhaCorreta = DbUsuarios.verificaSenha(email, senha);
            if (!senhaCorreta)
            {
                label.Text = "Senha incorreta.";
                label.Visible = true;
                pintarBorda(panel, Form1.vermelho);
                pbIcone.Image = Resources.icone_senha_erro;
                pbSenha.Image = Resources.button_exibir_senha_erro;
                foreach (Control control in panel.Controls)
                {
                    control.ForeColor = Form1.vermelho;
                }
                erroSenha = true;
            }
            return senhaCorreta;
        }

        public static void pintarBorda(Panel panel, Color cor)
        {
            Graphics g = panel.CreateGraphics();
            Pen pen = new(new SolidBrush(cor), 5);
            g.DrawRectangle(pen, -1, -1, panel.Width + 1, panel.Height + 1);
        }
    }
}
