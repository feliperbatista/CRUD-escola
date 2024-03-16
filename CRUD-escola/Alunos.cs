using CRUD_escola.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CRUD_escola
{
    public partial class Alunos : Form
    {
        public static DataSet ds = new();

        public Alunos()
        {
            InitializeComponent();

            Load += Alunos_Load;

            pictureBoxPesquisar.Click += PictureBoxPesquisar_Click;
            pictureBoxPesquisar.MouseEnter += PictureBoxPesquisar_MouseEnter;
            pictureBoxPesquisar.MouseLeave += PictureBoxPesquisar_MouseLeave;

            pictureBoxAdicionar.Click += PictureBoxAdicionar_Click;
            pictureBoxAdicionar.MouseEnter += PictureBoxAdicionar_MouseEnter;
            pictureBoxAdicionar.MouseLeave += PictureBoxAdicionar_MouseLeave;


            pictureBoxAtualizar.Click += PictureBoxAtualizar_Click;
            pictureBoxAtualizar.MouseEnter += PictureBoxAtualizar_MouseEnter;
            pictureBoxAtualizar.MouseLeave += PictureBoxAtualizar_MouseLeave;

            dataGridView1.CellContentClick += DataGridView1_CellContentClick;

            pictureBoxFecharJanela.Click += PictureBoxFecharJanela_Click;
            pictureBoxMinimizarJanela.Click += PictureBoxMinimizarJanela_Click;
            pictureBoxFecharJanela.MouseEnter += PictureBoxFecharJanela_MouseEnter;
            pictureBoxFecharJanela.MouseLeave += PictureBoxFecharJanela_MouseLeave;
            pictureBoxMinimizarJanela.MouseEnter += PictureBoxMinimizarJanela_MouseEnter;
            pictureBoxMinimizarJanela.MouseLeave += PictureBoxMinimizarJanela_MouseLeave;

        }

        private void Alunos_Load(object? sender, EventArgs e)
        {
            AtualizarLista();
            labelNome.Width = dataGridView1.Columns[0].Width + dataGridView1.Columns[1].Width;
            labelSobrenome.Width = dataGridView1.Columns[2].Width;
            labelTelefone.Width = dataGridView1.Columns[3].Width;
            labelMatricula.Width = dataGridView1.Columns[4].Width;
            labelIdade.Width = dataGridView1.Columns[5].Width;
            labelSerie.Width = dataGridView1.Columns[6].Width;
            labelTurma.Width = dataGridView1.Columns[7].Width;
        }

        private void PictureBoxPesquisar_Click(object? sender, EventArgs e)
        {
            if (dataGridView1.DataSource != null)
            {
                string filtro = comboBoxFiltro.Text;
                if (filtro != string.Empty)
                {
                    if (filtro == "Nome")
                        (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("Nome = '{0}'", textBoxPesquisar.Text);
                    if (filtro == "Sobrenome")
                        (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("Sobrenome = '{0}'", textBoxPesquisar.Text);
                    if (filtro == "Telefone")
                        (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("Telefone = '{0}'", textBoxPesquisar.Text);
                    if (filtro == "Matrícula")
                        (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("Matricula = '{0}'", textBoxPesquisar.Text);
                    if (filtro == "Idade")
                        (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("Idade = '{0}'", textBoxPesquisar.Text);
                    if (filtro == "Série")
                        (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("Serie = '{0}'", textBoxPesquisar.Text);
                    if (filtro == "Turma")
                        (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("Turma = '{0}'", textBoxPesquisar.Text);
                }
            }
        }

        private void PictureBoxPesquisar_MouseEnter(object? sender, EventArgs e)
        {
            pictureBoxPesquisar.Image = Resources.pesquisar_escuro;
        }

        private void PictureBoxPesquisar_MouseLeave(object? sender, EventArgs e)
        {
            pictureBoxPesquisar.Image = Resources.pesquisar;
        }

        private void PictureBoxAdicionar_Click(object? sender, EventArgs e)
        {
            NovoAluno novo = new(-1);
            novo.ShowDialog();
        }

        private void PictureBoxAdicionar_MouseEnter(object? sender, EventArgs e)
        {
            pictureBoxAdicionar.Image = Resources.adicionar_escuro;
        }

        private void PictureBoxAdicionar_MouseLeave(object? sender, EventArgs e)
        {
            pictureBoxAdicionar.Image = Resources.adicionar;
        }

        private void PictureBoxAtualizar_Click(object? sender, EventArgs e)
        {
            AtualizarLista();
            textBoxPesquisar.Text = string.Empty;
            comboBoxFiltro.Text = string.Empty;
        }

        private void PictureBoxAtualizar_MouseEnter(object? sender, EventArgs e)
        {
            pictureBoxAtualizar.Image = Resources.refresh_escuro;
        }

        private void PictureBoxAtualizar_MouseLeave(object? sender, EventArgs e)
        {
            pictureBoxAtualizar.Image = Resources.refresh;
        }

        private void PictureBoxFecharJanela_Click(object? sender, EventArgs e)
        {
            Close();
        }

        private void DataGridView1_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0 && dataGridView1[e.ColumnIndex, e.RowIndex].Value.ToString() == "Editar")
            {
                NovoAluno novo = new(e.RowIndex);
                novo.Text = dataGridView1[1, e.RowIndex].Value.ToString() + " " + dataGridView1[2, e.RowIndex].Value.ToString();
                novo.ShowDialog();
            }

            if (dataGridView1.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0 && dataGridView1[e.ColumnIndex, e.RowIndex].Value.ToString() == "Excluir")
            {
                DbAlunos.DeleteAlunos(Convert.ToInt32(dataGridView1[4, e.RowIndex].Value));
                AtualizarLista();
            }
        }



        private void PictureBoxMinimizarJanela_Click(object? sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void PictureBoxFecharJanela_MouseEnter(object? sender, EventArgs e)
        {
            pictureBoxFecharJanela.Image = Resources.button_fechar_janela_2;
        }

        private void PictureBoxFecharJanela_MouseLeave(object? sender, EventArgs e)
        {
            pictureBoxFecharJanela.Image = Resources.button_fechar_janela;
        }

        private void PictureBoxMinimizarJanela_MouseEnter(object? sender, EventArgs e)
        {
            pictureBoxMinimizarJanela.Image = Resources.button_minimizar_janela_2;
        }

        private void PictureBoxMinimizarJanela_MouseLeave(object? sender, EventArgs e)
        {
            pictureBoxMinimizarJanela.Image = Resources.button_minimizar_janela;
        }

        private void AtualizarLista()
        {
            dataGridView1.Columns.Clear();
            ds = DbAlunos.ReadAlunos();
            DataTable dt = new();

            dt.Columns.Add(new DataColumn("Foto", typeof(Bitmap)));

            int lastColumnIndex = ds.Tables[0].Columns.Count - 1;

            foreach (DataColumn dc in ds.Tables[0].Columns)
            {
                if ( dc != ds.Tables[0].Columns[lastColumnIndex])
                    dt.Columns.Add(dc.ColumnName, dc.DataType);
            }

            Font fonte = new("Calibri", 14, FontStyle.Bold);
            SolidBrush brush = new(Color.White);
            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;

            int i = 0;
            int a = 1;
            Image image = Resources.circulo1; ;
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                switch (a)
                {
                    case 1:
                        image = Resources.circulo1;
                        break;
                    case 2:
                        image = Resources.circulo2;
                        break;
                    case 3:
                        image = Resources.circulo3;
                        break;
                    case 4:
                        image = Resources.circulo4;
                        break;
                    case 5:
                        image = Resources.circulo5;
                        break;
                }

                Bitmap foto = new Bitmap(image);
                Graphics g = Graphics.FromImage(foto);
                Rectangle rectangle = new(0, 0, foto.Width, foto.Height);
                string inicial = ds.Tables[0].Rows[i].Field<string>(0).ToString();
                inicial = inicial.Substring(0, 1);

                g.DrawString(inicial, fonte, brush, rectangle, stringFormat);

                dt.Rows.Add(foto, ds.Tables[0].Rows[i].Field<string>(0), ds.Tables[0].Rows[i].Field<string>(1), ds.Tables[0].Rows[i].Field<string>(2), ds.Tables[0].Rows[i].Field<Int32>(3), ds.Tables[0].Rows[i].Field<Int32>(4), ds.Tables[0].Rows[i].Field<Int32>(5), ds.Tables[0].Rows[i].Field<string>(6));
                i++;
                a++;
                if (a == 6) a = 1;
            }
            dataGridView1.DataSource = dt;

            if (dataGridView1.ColumnCount == 10)
                return;

            DataGridViewButtonColumn dgvButtonEditar = new();
            dgvButtonEditar.Text = "Editar";
            dgvButtonEditar.UseColumnTextForButtonValue = true;
            dgvButtonEditar.CellTemplate.Style.ForeColor = Form1.verde;
            dgvButtonEditar.CellTemplate.Style.BackColor = Color.White;
            dgvButtonEditar.CellTemplate.Style.Font = new Font("Calibri", 10);
            dgvButtonEditar.CellTemplate.Style.SelectionBackColor = Color.White;
            dgvButtonEditar.CellTemplate.Style.SelectionForeColor = Form1.verde;
            dgvButtonEditar.FlatStyle = FlatStyle.Flat;

            DataGridViewButtonColumn dgvButtonExcluir = new();
            dgvButtonExcluir.Text = "Excluir";
            dgvButtonExcluir.UseColumnTextForButtonValue = true;
            dgvButtonExcluir.CellTemplate.Style.ForeColor = Form1.vermelho;
            dgvButtonExcluir.CellTemplate.Style.BackColor = Color.White;
            dgvButtonExcluir.CellTemplate.Style.Font = new Font("Calibri", 10);
            dgvButtonExcluir.CellTemplate.Style.SelectionBackColor = Color.White;
            dgvButtonExcluir.CellTemplate.Style.SelectionForeColor= Form1.vermelho;
            dgvButtonExcluir.FlatStyle = FlatStyle.Flat;

            dataGridView1.Columns.Insert(dataGridView1.ColumnCount, dgvButtonEditar);
            dataGridView1.Columns.Insert(dataGridView1.ColumnCount, dgvButtonExcluir);
        }
    }
}
