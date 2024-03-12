using CRUD_escola.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_escola
{
    public partial class NovoAluno : Form
    {
        Color corNome = Form1.cinza;
        Color corSobrenome = Form1.cinza;
        Color corTelefone = Form1.cinza;
        Color corMatricula = Form1.cinza;
        Color corIdade = Form1.cinza;
        Color corSerie = Form1.cinza;
        Color corTurma = Form1.cinza;

        public NovoAluno()
        {
            InitializeComponent();

            ActiveControl = pictureBoxCadastrar;

            panelNome.Paint += PanelNome_Paint;
            panelSobrenome.Paint += PanelSobrenome_Paint;
            panelTelefone.Paint += PanelTelefone_Paint;
            panelMatricula.Paint += PanelMatricula_Paint;
            panelIdade.Paint += PanelIdade_Paint;
            panelSerie.Paint += PanelSerie_Paint;
            panelTurma.Paint += PanelTurma_Paint;

            textBoxNome.Enter += TextBoxNome_Enter;
            textBoxSobrenome.Enter += TextBoxSobrenome_Enter;
            maskedTextBoxTelefone.Enter += MaskedTextBoxTelefone_Enter;
            textBoxMatricula.Enter += TextBoxMatricula_Enter;
            textBoxIdade.Enter += TextBoxIdade_Enter;
            comboBoxSerie.Enter += ComboBoxSerie_Enter;
            comboBoxTurma.Enter += ComboBoxTurma_Enter;

            textBoxNome.Leave += TextBoxNome_Leave;
            textBoxSobrenome.Leave += TextBoxSobrenome_Leave;
            maskedTextBoxTelefone.Leave += MaskedTextBoxTelefone_Leave;
            textBoxMatricula.Leave += TextBoxMatricula_Leave;
            textBoxIdade.Leave += TextBoxIdade_Leave;
            comboBoxSerie.Leave += ComboBoxSerie_Leave;
            comboBoxTurma.Leave += ComboBoxTurma_Leave;

            pictureBoxEditarFoto.Click += PictureBoxEditarFoto_Click;

            pictureBoxCadastrar.Click += PictureBoxCadastrar_Click;
            pictureBoxCadastrar.MouseEnter += PictureBoxCadastrar_MouseEnter;
            pictureBoxCadastrar.MouseLeave += PictureBoxCadastrar_MouseLeave;

            pictureBoxCancelar.Click += PictureBoxCancelar_Click;
            pictureBoxCancelar.MouseEnter += PictureBoxCancelar_MouseEnter;
            pictureBoxCancelar.MouseLeave += PictureBoxCancelar_MouseLeave;

            textBoxMatricula.TextChanged += TextBoxMatricula_TextChanged;
            textBoxIdade.TextChanged += TextBoxIdade_TextChanged;

        }

        private void PanelNome_Paint(object? sender, PaintEventArgs e)
        {
           Validacao.pintarBorda(panelNome, corNome);
        }

        private void PanelSobrenome_Paint(object? sender, PaintEventArgs e)
        {
            Validacao.pintarBorda(panelSobrenome, corSobrenome);
        }

        private void PanelTelefone_Paint(object? sender, PaintEventArgs e)
        {
            Validacao.pintarBorda(panelTelefone, corTelefone);
        }

        private void PanelMatricula_Paint(object? sender, PaintEventArgs e)
        {
            Validacao.pintarBorda(panelMatricula, corMatricula);
        }

        private void PanelIdade_Paint(object? sender, PaintEventArgs e)
        {
            Validacao.pintarBorda(panelIdade, corIdade);
        }

        private void PanelSerie_Paint(object? sender, PaintEventArgs e)
        {
            Validacao.pintarBorda(panelSerie, corSerie);
        }

        private void PanelTurma_Paint(object? sender, PaintEventArgs e)
        {
            Validacao.pintarBorda(panelTurma, corTurma);
        }

        private void TextBoxNome_Enter(object? sender, EventArgs e)
        {
            corNome = Form1.verde;
            if(textBoxNome.Text == "Nome") 
                textBoxNome.Text = string.Empty;
            textBoxNome.ForeColor = Form1.verde;
            pictureBoxNome.Image = Resources.icone_pessoa_colorido;
            Validacao.pintarBorda(panelNome, Form1.verde);
        }

        private void TextBoxSobrenome_Enter(object? sender, EventArgs e)
        {
            corSobrenome = Form1.verde;
            if (textBoxSobrenome.Text == "Sobrenome")
                textBoxSobrenome.Text = string.Empty;
            textBoxSobrenome.ForeColor = Form1.verde;
            pictureBoxSobrenome.Image = Resources.icone_pessoa_colorido;
            Validacao.pintarBorda(panelSobrenome, Form1.verde);
        }

        private void MaskedTextBoxTelefone_Enter(object? sender, EventArgs e)
        {
            corTelefone = Form1.verde;
            maskedTextBoxTelefone.ForeColor = Form1.verde;
            pictureBoxTelefone.Image = Resources.icone_telefone_colorido;
            Validacao.pintarBorda(panelTelefone, Form1.verde);
        }

        private void TextBoxMatricula_Enter(object? sender, EventArgs e)
        {
            corMatricula = Form1.verde;
            if (textBoxMatricula.Text == "Matrícula")
                textBoxMatricula.Text = string.Empty;
            textBoxMatricula.ForeColor = Form1.verde;
            pictureBoxMatricula.Image = Resources.icone_matricula_colorido;
            Validacao.pintarBorda(panelMatricula, Form1.verde);
        }

        private void TextBoxIdade_Enter(object? sender, EventArgs e)
        {
            corIdade = Form1.verde;
            if (textBoxIdade.Text == "Idade")
                textBoxIdade.Text = string.Empty;
            textBoxIdade.ForeColor = Form1.verde;
            pictureBoxIdade.Image = Resources.icone_idade_colorido;
            Validacao.pintarBorda(panelIdade, Form1.verde);
        }

        private void ComboBoxSerie_Enter(object? sender, EventArgs e)
        {
            corSerie = Form1.verde;
            if (comboBoxSerie.Text == "Série")
                comboBoxSerie.Text = string.Empty;
            comboBoxSerie.ForeColor = Form1.verde;
            pictureBoxSerie.Image = Resources.icone_turma_colorido;
            Validacao.pintarBorda(panelSerie, Form1.verde);
        }

        private void ComboBoxTurma_Enter(object? sender, EventArgs e)
        {
            corTurma = Form1.verde;
            if(comboBoxTurma.Text == "Turma")
                comboBoxTurma.Text = string.Empty;
            comboBoxTurma.ForeColor = Form1.verde;
            pictureBoxTurma.Image = Resources.icone_turma_colorido;
            Validacao.pintarBorda(panelTurma, Form1.verde);
        }

        private void TextBoxNome_Leave(object? sender, EventArgs e)
        {
            if (textBoxNome.Text == string.Empty)
                textBoxNome.Text = "Nome";
            textBoxNome.ForeColor = Form1.cinza;
            pictureBoxNome.Image = Resources.icone_pessoa;
            corNome = Form1.cinza;
            Validacao.pintarBorda(panelNome, Form1.cinza);
        }

        private void TextBoxSobrenome_Leave(object? sender, EventArgs e)
        {
            if (textBoxSobrenome.Text == string.Empty)
                textBoxSobrenome.Text = "Sobrenome";
            textBoxSobrenome.ForeColor = Form1.cinza;
            pictureBoxSobrenome.Image = Resources.icone_pessoa;
            corSobrenome = Form1.cinza;
            Validacao.pintarBorda(panelSobrenome, Form1.cinza);
        }

        private void MaskedTextBoxTelefone_Leave(object? sender, EventArgs e)
        {
            maskedTextBoxTelefone.ForeColor = Form1.cinza;
            pictureBoxTelefone.Image = Resources.icone_telefone;
            corTelefone = Form1.cinza;
            Validacao.pintarBorda(panelTelefone, Form1.cinza);
        }

        private void TextBoxMatricula_Leave(object? sender, EventArgs e)
        {
            if (textBoxMatricula.Text == string.Empty)
                textBoxMatricula.Text = "Matrícula";
            textBoxMatricula.ForeColor = Form1.cinza;
            pictureBoxMatricula.Image = Resources.icone_matricula;
            corMatricula = Form1.cinza;
            Validacao.pintarBorda(panelMatricula, Form1.cinza);
        }

        private void TextBoxIdade_Leave(object? sender, EventArgs e)
        {
            if (textBoxIdade.Text == string.Empty)
                textBoxIdade.Text = "Idade";
            textBoxIdade.ForeColor = Form1.cinza;
            pictureBoxIdade.Image = Resources.icone_idade;
            corIdade = Form1.cinza;
            Validacao.pintarBorda(panelIdade, Form1.cinza);
        }

        private void ComboBoxSerie_Leave(object? sender, EventArgs e)
        {
            if (comboBoxSerie.Text == string.Empty)
                comboBoxSerie.Text = "Série";
            comboBoxSerie.ForeColor = Form1.cinza;
            pictureBoxSerie.Image = Resources.icone_turma;
            corSerie = Form1.cinza;
            Validacao.pintarBorda(panelSerie, Form1.cinza);
        }

        private void ComboBoxTurma_Leave(object? sender, EventArgs e)
        {
            if (comboBoxTurma.Text == string.Empty)
                comboBoxTurma.Text = "Turma";
            comboBoxTurma.ForeColor = Form1.cinza;
            pictureBoxTurma.Image = Resources.icone_turma;
            corTurma = Form1.cinza;
            Validacao.pintarBorda(panelTurma, Form1.cinza);
        }

        private void PictureBoxEditarFoto_Click(object? sender, EventArgs e)
        {
            openFileDialog1.Filter = "Arquivo de imagem | *.jpg; *.jpeg; *.png";
            openFileDialog1.Title = "Selecione uma foto";
            openFileDialog1.InitialDirectory = @"Imagens";
            openFileDialog1.FileName = string.Empty; 
            if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                Image imagem = new Bitmap(openFileDialog1.FileName);
                if (ValidacaoAluno.ValidaFoto(imagem) != string.Empty)
                {
                    labelErroFoto.Text = ValidacaoAluno.ValidaFoto(imagem);
                    labelErroFoto.Visible = true;
                    return;
                }
                pictureBoxFoto.Image = imagem;
            }
        }

        private void PictureBoxCadastrar_Click(object? sender, EventArgs e)
        {
            if (Validar())
            {
                DbAlunos.AddAluno(criarAluno());
                foreach(Panel panel in Controls.OfType<Panel>())
                {
                    Validacao.pintarBorda(panel, Form1.cinza);
                }
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

        private void PictureBoxCancelar_Click(object? sender, EventArgs e)
        {
            Close();
        }

        private void PictureBoxCancelar_MouseEnter(object? sender, EventArgs e)
        {
            pictureBoxCancelar.Image = Resources.button_cancelar_colorido;
        }

        private void PictureBoxCancelar_MouseLeave(object? sender, EventArgs e)
        {
            pictureBoxCancelar.Image = Resources.button_cancelar;
        }

        private Aluno criarAluno()
        {
            string nome = textBoxNome.Text;
            string sobrenome = textBoxSobrenome.Text;
            string contato = maskedTextBoxTelefone.Text;
            int matricula = Convert.ToInt32(textBoxMatricula.Text);
            int idade = Convert.ToInt16(textBoxIdade.Text);
            string turma = comboBoxTurma.Text;
            int serie = Convert.ToInt16(comboBoxSerie.Text);
            byte[] foto;
            using (MemoryStream ms = new MemoryStream())
            {
                Bitmap bitmap = new Bitmap(pictureBoxFoto.Image);
                bitmap.Save(ms, ImageFormat.Jpeg);
                foto = ms.ToArray();
            }
            Aluno aluno = new(nome, sobrenome, contato, matricula, idade, serie, turma, foto);
            return aluno;
        }

        private void TextBoxMatricula_TextChanged(object? sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBoxMatricula.Text, "[^0-9]"))
            {
                textBoxMatricula.Text = textBoxMatricula.Text.Remove(textBoxMatricula.Text.Length - 1);
                textBoxMatricula.Select(textBoxMatricula.Text.Length, 0);
            }
            if (textBoxMatricula.Text.Length > 6)
            {
                textBoxMatricula.Text = textBoxMatricula.Text.Remove(textBoxMatricula.Text.Length - 1);
                textBoxMatricula.Select(textBoxMatricula.Text.Length, 0);
            }
        }

        private void TextBoxIdade_TextChanged(object? sender, EventArgs e)
        {
            if (textBoxIdade.Text == "Idade")
                return;

            if (System.Text.RegularExpressions.Regex.IsMatch(textBoxIdade.Text, "[^0-9]"))
            {
                textBoxIdade.Text = textBoxIdade.Text.Remove(textBoxIdade.Text.Length - 1);
                textBoxIdade.Select(textBoxIdade.Text.Length, 0);
            }
            if (textBoxIdade.Text.Length > 2)
            {
                textBoxIdade.Text = textBoxIdade.Text.Remove(textBoxIdade.Text.Length - 1);
                textBoxIdade.Select(textBoxIdade.Text.Length, 0);
            }
        }

        public bool Validar()
        {
            bool valido = true;
            if (ValidacaoAluno.ValidaNome(textBoxNome.Text) != string.Empty)
            {
                IndicaErro(labelErroNome, ValidacaoAluno.ValidaNome(textBoxNome.Text), textBoxNome);
                pictureBoxNome.Image = Resources.icone_pessoa_erro;
                corNome = Form1.vermelho;
                valido = false;
            }
            if (ValidacaoAluno.ValidaSobrenome(textBoxSobrenome.Text) != string.Empty)
            {
                IndicaErro(labelErroSobrenome, ValidacaoAluno.ValidaSobrenome(textBoxSobrenome.Text), textBoxSobrenome);
                pictureBoxSobrenome.Image = Resources.icone_pessoa_erro;
                corSobrenome = Form1.vermelho;
                valido = false;
            }
            if (ValidacaoAluno.ValidaTelefone(maskedTextBoxTelefone.Text) != string.Empty)
            {
                IndicaErro(labelErroTelefone, ValidacaoAluno.ValidaTelefone(maskedTextBoxTelefone.Text), maskedTextBoxTelefone);
                pictureBoxTelefone.Image = Resources.icone_telefone_erro;
                corTelefone = Form1.vermelho;
                valido = false;
            }
            if (ValidacaoAluno.ValidaMatricula(textBoxMatricula.Text) != string.Empty)
            {
                IndicaErro(labelErroMatricula, ValidacaoAluno.ValidaMatricula(textBoxMatricula.Text), textBoxMatricula);
                pictureBoxMatricula.Image = Resources.icone_matricula_erro;
                corMatricula = Form1.vermelho;
                valido = false;
            }
            if (ValidacaoAluno.ValidaIdade(textBoxIdade.Text) != string.Empty)
            {
                IndicaErro(labelErroIdade, ValidacaoAluno.ValidaIdade(textBoxIdade.Text), textBoxIdade);
                pictureBoxIdade.Image = Resources.icone_idade_erro;
                corIdade = Form1.vermelho;
                valido = false;
            }
            if (ValidacaoAluno.ValidaSerie(comboBoxSerie.Text) != string.Empty)
            {
                IndicaErro(labelErroSerie, ValidacaoAluno.ValidaSerie(comboBoxSerie.Text), comboBoxSerie);
                pictureBoxSerie.Image = Resources.icone_turma_erro;
                corSerie = Form1.vermelho;
                valido = false;
            }
            if (ValidacaoAluno.ValidaTurma(comboBoxTurma.Text) != string.Empty)
            {
                IndicaErro(labelErroTurma, ValidacaoAluno.ValidaTurma(comboBoxTurma.Text), comboBoxTurma);
                pictureBoxTurma.Image = Resources.icone_turma_erro;
                corTurma = Form1.vermelho;
                valido = false;
            }
            return valido;
        }

        public void IndicaErro(Label label, string erro, Control control)
        {
            label.Text = erro;
            label.Visible = true;
            control.ForeColor = Form1.vermelho;
        }

    }
}
