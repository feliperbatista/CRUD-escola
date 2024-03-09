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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CRUD_escola
{
    public partial class Alunos : Form
    {
        public Alunos()
        {
            InitializeComponent();

            buttonCriar.Click += ButtonCriar_Click;
            buttonListar.Click += ButtonListar_Click;
            buttonAtualizar.Click += ButtonAtualizar_Click;
            buttonDeletar.Click += ButtonDeletar_Click;

            textBoxMatricula.TextChanged += TextBoxMatricula_TextChanged;
            textBoxIdade.TextChanged += TextBoxIdade_TextChanged;

            buttonFoto.Click += ButtonFoto_Click;

        }

        private void ButtonCriar_Click(object? sender, EventArgs e)
        {
            labelNome.Visible = false;
            labelMatricula.Visible = false;
            labelIdade.Visible = false;
            labelTurma.Visible = false;
            if (verificarCampos("criar")) DbAlunos.AddAluno(criarAluno());
        }

        private void ButtonListar_Click(object? sender, EventArgs e)
        {
            labelNome.Visible = false;
            labelMatricula.Visible = false;
            labelIdade.Visible = false;
            labelTurma.Visible = false;
            DbAlunos.ReadAlunos(dataGridView1);
        }

        private void ButtonAtualizar_Click(object? sender, EventArgs e)
        {
            labelNome.Visible = false;
            labelMatricula.Visible = false;
            labelIdade.Visible = false;
            labelTurma.Visible = false;
            if (verificarCampos("atualizar")) DbAlunos.UpdateAluno(criarAluno());
        }


        private void ButtonDeletar_Click(object? sender, EventArgs e)
        {
            labelNome.Visible = false;
            labelMatricula.Visible = false;
            labelIdade.Visible = false;
            labelTurma.Visible = false;
            if (!verificaMatricula("deletar")) DbAlunos.Delete(Convert.ToInt32(textBoxMatricula.Text));
        }

        private void ButtonFoto_Click(object? sender, EventArgs e)
        {
            openFileDialog1.Filter = "Arquivo de imagem | *.jpg; *.jpeg; *.png";
            openFileDialog1.Title = "Selecione uma foto";
            if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                if(verificaFoto()) pictureBox1.Image = new Bitmap(openFileDialog1.FileName);
            }
        }

        private Aluno criarAluno()
        {
            string nome = textBoxNome.Text;
            int matricula = Convert.ToInt32(textBoxMatricula.Text);
            int idade = Convert.ToInt16(textBoxIdade.Text);
            string turma = comboBoxTurma.Text;
            byte[] foto;
            using (MemoryStream ms = new MemoryStream())
            {
                Bitmap bitmap = new Bitmap(pictureBox1.Image);
                bitmap.Save(ms, ImageFormat.Jpeg);
                foto = ms.ToArray();
            }

            Aluno aluno = new(nome, matricula, idade, turma, foto);
            return aluno;
        }

        private bool verificarCampos(string opcao)
        {
            bool nomeVerificado = verificaNome();
            bool matriculaVerificada = verificaMatricula(opcao);
            bool idadeVerificada = verificaIdade();
            bool turmaVerificada = verificaTurma();

            bool verificado = false;

            if (nomeVerificado && matriculaVerificada && idadeVerificada && turmaVerificada && opcao == "criar")
            {
                verificado = true;
            }

            if (nomeVerificado && !matriculaVerificada && idadeVerificada && turmaVerificada && opcao == "atualizar")
            {
                verificado = true;
            }

            return verificado;
        }

        private bool verificaNome() 
        {
            if (string.IsNullOrEmpty(textBoxNome.Text))
            {
                labelNome.Text = "Insira o nome do(a) aluno(a).";
                labelNome.Visible = true;
                return false;
            }
            string nome = textBoxNome.Text;
            if(nome.Length<3 || nome.Length>50) 
            {
                labelNome.Text = "Nome precisa ter entre 3 e 50 caracteres.";
                labelNome.Visible = true;
                return false;
            }
            return true;
        }

        private bool verificaMatricula(string opcao)
        {
            if (string.IsNullOrEmpty(textBoxMatricula.Text))
            {
                labelMatricula.Text = "Insira a matrícula do(a) aluno(a).";
                labelMatricula.Visible = true;
                if (opcao == "deletar") return true;
                return false;
            }
            if (textBoxMatricula.Text.Length != 6)
            {
                labelMatricula.Text = "O campo de matrícula deve conter seis dígitos.";
                labelMatricula.Visible = true;
                if (opcao == "deletar") return true;
                return false;
            }
            int matricula;
            try
            {
                matricula = Convert.ToInt32(textBoxMatricula.Text);
            }
            catch
            {
                labelMatricula.Text = "O campo de matrícula deve conter somente números.";
                labelMatricula.Visible = true;
                if(opcao =="deletar") return true;
                return false;
            }
            if (DbAlunos.verificaMatricula(matricula) && opcao=="criar")
            {
                labelMatricula.Text = "A matrícula inserida já está cadastrada.";
                labelMatricula.Visible = true;
                return false;
            }
            if (!DbAlunos.verificaMatricula(matricula) && (opcao == "atualizar" || opcao =="deletar"))
            {
                labelMatricula.Text = "Matrícula não existe.";
                labelMatricula.Visible = true;
                return false;
            }
            return !DbAlunos.verificaMatricula(matricula);
        }

        private bool verificaIdade()
        {
            if (string.IsNullOrEmpty(textBoxIdade.Text))
            {
                labelIdade.Text = "Insira a idade do(a) aluno(a).";
                labelIdade.Visible = true;
                return false;
            }
            if (textBoxIdade.Text.Length>2)
            {
                labelIdade.Text = "Insira uma idade válida.";
                labelIdade.Visible = true;
                return false;
            }
            int idade;
            try
            {
                idade = Convert.ToInt32(textBoxIdade.Text);
            }
            catch
            {
                labelIdade.Text = "O campo de idade deve conter somente números.";
                labelIdade.Visible = true;
                return false;
            }
            return true;
        }

        private bool verificaTurma()
        {
            if(string.IsNullOrEmpty(comboBoxTurma.Text)) 
            {
                labelTurma.Text = "Selecione uma turma.";
                labelTurma.Visible = true;
                return false;
            }
            return true;
        }

        private bool verificaFoto()
        {
            pictureBox1.Image.Save("arquivo");
            var fileSizeInBytes = new FileInfo("arquivo").Length;
            if (fileSizeInBytes > 2000000)
            {
                MessageBox.Show("Tamanho do arquivo de imagem inválido", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }


        private void TextBoxMatricula_TextChanged(object? sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBoxMatricula.Text, "[^0-9]"))
            {
                textBoxMatricula.Text = textBoxMatricula.Text.Remove(textBoxMatricula.Text.Length-1);
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

    }
}
