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

        private readonly int Index = 0;

        public NovoAluno(int index)
        {
            InitializeComponent();
            Index = index;

            ActiveControl = pictureBoxCadastrar;

            Load += NovoAluno_Load;

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

            textBoxNome.KeyDown += TextBoxNome_KeyDown;
            textBoxSobrenome.KeyDown += TextBoxSobrenome_KeyDown;
            maskedTextBoxTelefone.KeyDown += MaskedTextBoxTelefone_KeyDown;
            textBoxMatricula.KeyDown += TextBoxMatricula_KeyDown;
            textBoxIdade.KeyDown += TextBoxIdade_KeyDown;
            comboBoxSerie.SelectionChangeCommitted += ComboBoxSerie_SelectionChangeCommitted;
            comboBoxTurma.SelectionChangeCommitted += ComboBoxTurma_SelectionChangeCommitted;

            comboBoxSerie.KeyPress += ComboBoxSerie_KeyPress;
            comboBoxTurma.KeyPress += ComboBoxTurma_KeyPress;

            pictureBoxEditarFoto.Click += PictureBoxEditarFoto_Click;

            pictureBoxCadastrar.Click += PictureBoxCadastrar_Click;
            pictureBoxCadastrar.MouseEnter += PictureBoxCadastrar_MouseEnter;
            pictureBoxCadastrar.MouseLeave += PictureBoxCadastrar_MouseLeave;


            panelNome.Click += PanelNome_Click;
            panelSobrenome.Click += PanelSobrenome_Click;
            panelTelefone.Click += PanelTelefone_Click;
            panelMatricula.Click += PanelMatricula_Click;
            panelIdade.Click += PanelIdade_Click;
            panelSerie.Click += PanelSerie_Click;
            panelTurma.Click += PanelTurma_Click;

            pictureBoxNome.Click += PictureBoxNome_Click;
            pictureBoxSobrenome.Click += PictureBoxSobrenome_Click;
            pictureBoxTelefone.Click += PictureBoxTelefone_Click;
            pictureBoxMatricula.Click += PictureBoxMatricula_Click;
            pictureBoxIdade.Click += PictureBoxIdade_Click;
            pictureBoxSerie.Click += PictureBoxSerie_Click;
            pictureBoxTurma.Click += PictureBoxTurma_Click;

        }

        private void NovoAluno_Load(object? sender, EventArgs e)
        {
            if (Index != -1)
            {
                textBoxNome.Text = Alunos.ds.Tables[0].Rows[Index].Field<string>(0);
                textBoxSobrenome.Text = Alunos.ds.Tables[0].Rows[Index].Field<string>(1);
                maskedTextBoxTelefone.Text = Alunos.ds.Tables[0].Rows[Index].Field<string>(2);
                textBoxMatricula.Text = Alunos.ds.Tables[0].Rows[Index].Field<int>(3).ToString();
                textBoxIdade.Text = Alunos.ds.Tables[0].Rows[Index].Field<int>(4).ToString();
                comboBoxSerie.Text = Alunos.ds.Tables[0].Rows[Index].Field<int>(5).ToString();
                comboBoxTurma.Text = Alunos.ds.Tables[0].Rows[Index].Field<string>(6);
                byte[] imageEmByte = Alunos.ds.Tables[0].Rows[Index].Field<byte[]>(7);
                if (imageEmByte != null)
                {
                    var ms = new MemoryStream(imageEmByte);
                    Image imagem = Image.FromStream(ms);
                    pictureBoxFoto.Image = imagem;
                    pictureBoxFoto.BackgroundImage = null;
                }
            }
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
            corNome = IndicaEntrada(textBoxNome, "Nome", pictureBoxNome, Resources.icone_pessoa_colorido);
        }

        private void TextBoxSobrenome_Enter(object? sender, EventArgs e)
        {
            corSobrenome = IndicaEntrada(textBoxSobrenome, "Sobrenome", pictureBoxSobrenome, Resources.icone_pessoa_colorido);
        }

        private void MaskedTextBoxTelefone_Enter(object? sender, EventArgs e)
        {
            corTelefone = IndicaEntrada(maskedTextBoxTelefone, string.Empty, pictureBoxTelefone, Resources.icone_telefone_colorido);
        }

        private void TextBoxMatricula_Enter(object? sender, EventArgs e)
        {
            corMatricula = IndicaEntrada(textBoxMatricula, "Matrícula",  pictureBoxMatricula, Resources.icone_matricula_colorido);
        }

        private void TextBoxIdade_Enter(object? sender, EventArgs e)
        {
            corIdade = IndicaEntrada(textBoxIdade, "Idade", pictureBoxIdade, Resources.icone_idade_colorido);
        }

        private void ComboBoxSerie_Enter(object? sender, EventArgs e)
        {
            corSerie = IndicaEntrada(comboBoxSerie, "Série", pictureBoxSerie, Resources.icone_turma_colorido);
        }

        private void ComboBoxTurma_Enter(object? sender, EventArgs e)
        {
            corTurma = IndicaEntrada(comboBoxTurma, "Turma", pictureBoxTurma, Resources.icone_turma_colorido);
        }

        private void TextBoxNome_Leave(object? sender, EventArgs e)
        {
            corNome = IndicaSaida(textBoxNome, "Nome", pictureBoxNome, Resources.icone_turma);
        }

        private void TextBoxSobrenome_Leave(object? sender, EventArgs e)
        {
            corSobrenome = IndicaSaida(textBoxSobrenome, "Sobrenome", pictureBoxSobrenome, Resources.icone_pessoa);
        }

        private void MaskedTextBoxTelefone_Leave(object? sender, EventArgs e)
        {
            corTelefone = IndicaSaida(maskedTextBoxTelefone, string.Empty, pictureBoxTelefone, Resources.icone_telefone);
        }

        private void TextBoxMatricula_Leave(object? sender, EventArgs e)
        {
            corMatricula = IndicaSaida(textBoxMatricula, "Matrícula", pictureBoxMatricula, Resources.icone_matricula);
        }

        private void TextBoxIdade_Leave(object? sender, EventArgs e)
        {
            corIdade = IndicaSaida(textBoxIdade, "Idade", pictureBoxIdade, Resources.icone_idade);
        }

        private void ComboBoxSerie_Leave(object? sender, EventArgs e)
        {
            corSerie = IndicaSaida(comboBoxSerie, "Série", pictureBoxSerie, Resources.icone_turma);
        }

        private void ComboBoxTurma_Leave(object? sender, EventArgs e)
        {
            corTurma = IndicaSaida(comboBoxTurma, "Turma", pictureBoxTurma, Resources.icone_turma);
        }


        private void TextBoxNome_KeyDown(object? sender, KeyEventArgs e)
        {
            corNome = IndicaAlteracao(textBoxNome, pictureBoxNome, Resources.icone_pessoa_colorido);
            labelErroNome.Visible = false;
        }

        private void TextBoxSobrenome_KeyDown(object? sender, KeyEventArgs e)
        {
            corSobrenome = IndicaAlteracao(textBoxSobrenome, pictureBoxSobrenome, Resources.icone_pessoa_colorido);
            labelErroSobrenome.Visible = false;
        }

        private void MaskedTextBoxTelefone_KeyDown(object? sender, KeyEventArgs e)
        {
            corTelefone = IndicaAlteracao(maskedTextBoxTelefone, pictureBoxTelefone, Resources.icone_telefone_colorido);
            labelErroTelefone.Visible = false;
        }

        private void TextBoxMatricula_KeyDown(object? sender, KeyEventArgs e)
        {
            corMatricula = IndicaAlteracao(textBoxMatricula, pictureBoxMatricula, Resources.icone_matricula_colorido);
            labelErroMatricula.Visible = false;

            if (textBoxMatricula.Text == "Matrícula")
                return;

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

        private void TextBoxIdade_KeyDown(object? sender, KeyEventArgs e)
        {
            corIdade = IndicaAlteracao(textBoxIdade, pictureBoxIdade, Resources.icone_idade_colorido);
            labelErroIdade.Visible = false;

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

        private void ComboBoxSerie_SelectionChangeCommitted(object? sender, EventArgs e)
        {
            corSerie = IndicaAlteracao(comboBoxSerie, pictureBoxSerie, Resources.icone_turma_colorido);
            labelErroSerie.Visible = false;
        }

        private void ComboBoxTurma_SelectionChangeCommitted(object? sender, EventArgs e)
        {
            corTurma = IndicaAlteracao(comboBoxTurma, pictureBoxTurma, Resources.icone_turma_colorido);
            labelErroTurma.Visible = false;
        }

        private void ComboBoxSerie_KeyPress(object? sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void ComboBoxTurma_KeyPress(object? sender, KeyPressEventArgs e)
        {
            e.Handled = true;
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
                pictureBoxFoto.BackgroundImage = null;
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
                Close();
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

        private void PanelNome_Click(object? sender, EventArgs e)
        {
            textBoxNome.Focus();
        }

        private void PanelSobrenome_Click(object? sender, EventArgs e)
        {
            textBoxSobrenome.Focus();
        }

        private void PanelTelefone_Click(object? sender, EventArgs e)
        {
            maskedTextBoxTelefone.Focus();
        }

        private void PanelMatricula_Click(object? sender, EventArgs e)
        {
            textBoxMatricula.Focus();
        }

        private void PanelIdade_Click(object? sender, EventArgs e)
        {
            textBoxIdade.Focus();   
        }

        private void PanelSerie_Click(object? sender, EventArgs e)
        {
            comboBoxSerie.Focus();
        }

        private void PanelTurma_Click(object? sender, EventArgs e)
        {
            comboBoxTurma.Focus();
        }

        private void PictureBoxNome_Click(object? sender, EventArgs e)
        {
            textBoxNome.Focus();
        }

        private void PictureBoxSobrenome_Click(object? sender, EventArgs e)
        {
            textBoxSobrenome.Focus();
        }

        private void PictureBoxTelefone_Click(object? sender, EventArgs e)
        {
            maskedTextBoxTelefone.Focus();
        }

        private void PictureBoxMatricula_Click(object? sender, EventArgs e)
        {
            textBoxMatricula.Focus();
        }

        private void PictureBoxIdade_Click(object? sender, EventArgs e)
        {
            textBoxIdade.Focus();
        }

        private void PictureBoxSerie_Click(object? sender, EventArgs e)
        {
            comboBoxSerie.Focus();
        }

        private void PictureBoxTurma_Click(object? sender, EventArgs e)
        {
            comboBoxTurma.Focus();
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
                if(pictureBoxFoto.Image  != null)
                {
                    Bitmap bitmap = new Bitmap(pictureBoxFoto.Image);
                    bitmap.Save(ms, ImageFormat.Jpeg);
                    foto = ms.ToArray();
                }
                else
                    foto = null;
            }
            Aluno aluno = new(nome, sobrenome, contato, matricula, idade, serie, turma, foto);
            return aluno;
        }

        public void IndicaErro(Label label, string erro, Control control)
        {
            label.Text = erro;
            label.Visible = true;
            control.ForeColor = Form1.vermelho;
        }

        public Color IndicaEntrada(Control control, string texto, PictureBox pb, Image image)
        {
            if (control.Text == texto)
                control.Text = string.Empty;
            control.ForeColor = Form1.verde;
            pb.Image = image;
            return Form1.verde;
        }

        public Color IndicaSaida(Control control, string texto, PictureBox pb, Image image)
        {
            if (control.Text == string.Empty)
                control.Text = texto;
            control.ForeColor = Form1.cinza;
            pb.Image = image;
            return Form1.cinza;
        }

        public Color IndicaAlteracao(Control control, PictureBox pb, Image image )
        {
            control.ForeColor = Form1.verde;
            pb.Image = image;
            return Form1.verde;
        }
    }
}
