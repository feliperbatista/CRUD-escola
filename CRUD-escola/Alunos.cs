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
        public Alunos()
        {
            InitializeComponent();

            pictureBoxFecharJanela.Click += PictureBoxFecharJanela_Click;
            pictureBoxMinimizarJanela.Click += PictureBoxMinimizarJanela_Click;

            textBoxPesquisar.TextChanged += TextBoxPesquisar_TextChanged;

            pictureBoxAdicionar.Click += PictureBoxAdicionar_Click;
            pictureBoxAtualizar.Click += PictureBoxAtualizar_Click;


        }

        private void TextBoxPesquisar_TextChanged(object? sender, EventArgs e)
        {
            if(dataGridView1.DataSource != null)
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("Nome = '{0}'", textBoxPesquisar.Text);
        }

        private void PictureBoxAdicionar_Click(object? sender, EventArgs e)
        {
            NovoAluno novo = new();
            novo.ShowDialog();
        }

        private void PictureBoxAtualizar_Click(object? sender, EventArgs e)
        {
            DataSet ds = DbAlunos.ReadAlunos();
            DataTable dt = new();
            dt.Columns.Add(new DataColumn("Foto", typeof(Bitmap)));
            foreach (DataColumn dc in ds.Tables[0].Columns)
            {
                dt.Columns.Add(dc.ColumnName, dc.DataType);
            }

            Font fonte = new("Calibri", 14, FontStyle.Bold);
            SolidBrush brush = new(Color.White);
            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;

            int i = 0;
            int a = 1;
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Image image = Image.FromFile($"C:\\Users\\batis\\source\\repos\\CRUD-escola\\CRUD-escola\\Resources\\circulo{a}.png");

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
            dgvButtonExcluir.FlatStyle = FlatStyle.Flat;

            dataGridView1.Columns.Insert(dataGridView1.ColumnCount, dgvButtonEditar);
            dataGridView1.Columns.Insert(dataGridView1.ColumnCount, dgvButtonExcluir);


        }

        private void PictureBoxFecharJanela_Click(object? sender, EventArgs e)
        {
            Close();
        }

        private void PictureBoxMinimizarJanela_Click(object? sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
