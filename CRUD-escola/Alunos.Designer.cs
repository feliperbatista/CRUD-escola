namespace CRUD_escola
{
    partial class Alunos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            openFileDialog1 = new OpenFileDialog();
            panel1 = new Panel();
            label5 = new Label();
            pictureBoxMinimizarJanela = new PictureBox();
            pictureBoxFecharJanela = new PictureBox();
            splitContainer1 = new SplitContainer();
            panel2 = new Panel();
            pictureBoxPesquisar = new PictureBox();
            comboBoxFiltro = new ComboBox();
            pictureBoxFiltro = new PictureBox();
            label3 = new Label();
            pictureBoxAdicionar = new PictureBox();
            label2 = new Label();
            pictureBoxAtualizar = new PictureBox();
            pictureBox1 = new PictureBox();
            textBoxPesquisar = new TextBox();
            label1 = new Label();
            panel4 = new Panel();
            panel3 = new Panel();
            labelTurma = new Label();
            labelSerie = new Label();
            labelIdade = new Label();
            labelMatricula = new Label();
            labelTelefone = new Label();
            labelSobrenome = new Label();
            labelNome = new Label();
            toolTip1 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMinimizarJanela).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFecharJanela).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPesquisar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFiltro).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAdicionar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAtualizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Calibri", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.GridColor = Color.Black;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 75;
            dataGridView1.ShowEditingIcon = false;
            dataGridView1.Size = new Size(1157, 620);
            dataGridView1.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(pictureBoxMinimizarJanela);
            panel1.Controls.Add(pictureBoxFecharJanela);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1157, 38);
            panel1.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(13, 202, 122);
            label5.Location = new Point(12, 8);
            label5.Name = "label5";
            label5.Size = new Size(305, 22);
            label5.TabIndex = 26;
            label5.Text = "Sistema Integrado de Gestão de Alunos";
            // 
            // pictureBoxMinimizarJanela
            // 
            pictureBoxMinimizarJanela.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBoxMinimizarJanela.Image = Properties.Resources.button_minimizar_janela;
            pictureBoxMinimizarJanela.Location = new Point(1095, 12);
            pictureBoxMinimizarJanela.Name = "pictureBoxMinimizarJanela";
            pictureBoxMinimizarJanela.Size = new Size(22, 22);
            pictureBoxMinimizarJanela.TabIndex = 25;
            pictureBoxMinimizarJanela.TabStop = false;
            toolTip1.SetToolTip(pictureBoxMinimizarJanela, "Minimizar");
            // 
            // pictureBoxFecharJanela
            // 
            pictureBoxFecharJanela.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBoxFecharJanela.Image = Properties.Resources.button_fechar_janela;
            pictureBoxFecharJanela.Location = new Point(1123, 12);
            pictureBoxFecharJanela.Name = "pictureBoxFecharJanela";
            pictureBoxFecharJanela.Size = new Size(22, 22);
            pictureBoxFecharJanela.TabIndex = 24;
            pictureBoxFecharJanela.TabStop = false;
            toolTip1.SetToolTip(pictureBoxFecharJanela, "Fechar");
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.FixedPanel = FixedPanel.Panel1;
            splitContainer1.IsSplitterFixed = true;
            splitContainer1.Location = new Point(0, 38);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(panel2);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(panel4);
            splitContainer1.Panel2.Controls.Add(panel3);
            splitContainer1.Size = new Size(1157, 732);
            splitContainer1.SplitterDistance = 53;
            splitContainer1.SplitterWidth = 1;
            splitContainer1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(13, 202, 122);
            panel2.Controls.Add(pictureBoxPesquisar);
            panel2.Controls.Add(comboBoxFiltro);
            panel2.Controls.Add(pictureBoxFiltro);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(pictureBoxAdicionar);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBoxAtualizar);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(textBoxPesquisar);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1157, 53);
            panel2.TabIndex = 0;
            // 
            // pictureBoxPesquisar
            // 
            pictureBoxPesquisar.Image = Properties.Resources.pesquisar;
            pictureBoxPesquisar.Location = new Point(533, 16);
            pictureBoxPesquisar.Name = "pictureBoxPesquisar";
            pictureBoxPesquisar.Size = new Size(20, 20);
            pictureBoxPesquisar.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxPesquisar.TabIndex = 9;
            pictureBoxPesquisar.TabStop = false;
            // 
            // comboBoxFiltro
            // 
            comboBoxFiltro.BackColor = Color.White;
            comboBoxFiltro.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFiltro.Font = new Font("Calibri", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxFiltro.FormattingEnabled = true;
            comboBoxFiltro.Items.AddRange(new object[] { "Nome", "Sobrenome", "Telefone", "Matrícula", "Idade", "Série", "Turma" });
            comboBoxFiltro.Location = new Point(141, 12);
            comboBoxFiltro.Name = "comboBoxFiltro";
            comboBoxFiltro.Size = new Size(123, 30);
            comboBoxFiltro.TabIndex = 8;
            // 
            // pictureBoxFiltro
            // 
            pictureBoxFiltro.Image = Properties.Resources.filtro;
            pictureBoxFiltro.Location = new Point(115, 16);
            pictureBoxFiltro.Name = "pictureBoxFiltro";
            pictureBoxFiltro.Size = new Size(20, 20);
            pictureBoxFiltro.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxFiltro.TabIndex = 7;
            pictureBoxFiltro.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(766, 14);
            label3.Name = "label3";
            label3.Size = new Size(190, 24);
            label3.TabIndex = 6;
            label3.Text = "Adicionar novo aluno";
            // 
            // pictureBoxAdicionar
            // 
            pictureBoxAdicionar.Image = Properties.Resources.adicionar;
            pictureBoxAdicionar.Location = new Point(740, 15);
            pictureBoxAdicionar.Name = "pictureBoxAdicionar";
            pictureBoxAdicionar.Size = new Size(20, 22);
            pictureBoxAdicionar.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxAdicionar.TabIndex = 5;
            pictureBoxAdicionar.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(635, 14);
            label2.Name = "label2";
            label2.Size = new Size(84, 24);
            label2.TabIndex = 4;
            label2.Text = "Atualizar";
            // 
            // pictureBoxAtualizar
            // 
            pictureBoxAtualizar.Image = Properties.Resources.refresh;
            pictureBoxAtualizar.Location = new Point(608, 16);
            pictureBoxAtualizar.Name = "pictureBoxAtualizar";
            pictureBoxAtualizar.Size = new Size(20, 20);
            pictureBoxAtualizar.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxAtualizar.TabIndex = 3;
            pictureBoxAtualizar.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.divisor;
            pictureBox1.Location = new Point(568, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(18, 36);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // textBoxPesquisar
            // 
            textBoxPesquisar.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxPesquisar.Location = new Point(270, 10);
            textBoxPesquisar.Name = "textBoxPesquisar";
            textBoxPesquisar.Size = new Size(251, 32);
            textBoxPesquisar.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 14);
            label1.Name = "label1";
            label1.Size = new Size(97, 24);
            label1.TabIndex = 0;
            label1.Text = "Pesquisar:";
            // 
            // panel4
            // 
            panel4.Controls.Add(dataGridView1);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 58);
            panel4.Name = "panel4";
            panel4.Size = new Size(1157, 620);
            panel4.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(labelTurma);
            panel3.Controls.Add(labelSerie);
            panel3.Controls.Add(labelIdade);
            panel3.Controls.Add(labelMatricula);
            panel3.Controls.Add(labelTelefone);
            panel3.Controls.Add(labelSobrenome);
            panel3.Controls.Add(labelNome);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1157, 58);
            panel3.TabIndex = 1;
            // 
            // labelTurma
            // 
            labelTurma.BackColor = Color.White;
            labelTurma.Dock = DockStyle.Left;
            labelTurma.Font = new Font("Calibri", 12F, FontStyle.Bold);
            labelTurma.Location = new Point(1074, 0);
            labelTurma.Name = "labelTurma";
            labelTurma.Size = new Size(83, 58);
            labelTurma.TabIndex = 6;
            labelTurma.Text = "Turma";
            labelTurma.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelSerie
            // 
            labelSerie.BackColor = Color.White;
            labelSerie.Dock = DockStyle.Left;
            labelSerie.Font = new Font("Calibri", 12F, FontStyle.Bold);
            labelSerie.Location = new Point(895, 0);
            labelSerie.Name = "labelSerie";
            labelSerie.Size = new Size(179, 58);
            labelSerie.TabIndex = 5;
            labelSerie.Text = "Série";
            labelSerie.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelIdade
            // 
            labelIdade.BackColor = Color.White;
            labelIdade.Dock = DockStyle.Left;
            labelIdade.Font = new Font("Calibri", 12F, FontStyle.Bold);
            labelIdade.Location = new Point(716, 0);
            labelIdade.Name = "labelIdade";
            labelIdade.Size = new Size(179, 58);
            labelIdade.TabIndex = 4;
            labelIdade.Text = "Idade";
            labelIdade.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelMatricula
            // 
            labelMatricula.BackColor = Color.White;
            labelMatricula.Dock = DockStyle.Left;
            labelMatricula.Font = new Font("Calibri", 12F, FontStyle.Bold);
            labelMatricula.Location = new Point(537, 0);
            labelMatricula.Name = "labelMatricula";
            labelMatricula.Size = new Size(179, 58);
            labelMatricula.TabIndex = 3;
            labelMatricula.Text = "Matrícula";
            labelMatricula.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelTelefone
            // 
            labelTelefone.BackColor = Color.White;
            labelTelefone.Dock = DockStyle.Left;
            labelTelefone.Font = new Font("Calibri", 12F, FontStyle.Bold);
            labelTelefone.Location = new Point(358, 0);
            labelTelefone.Name = "labelTelefone";
            labelTelefone.Size = new Size(179, 58);
            labelTelefone.TabIndex = 2;
            labelTelefone.Text = "Telefone";
            labelTelefone.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelSobrenome
            // 
            labelSobrenome.BackColor = Color.White;
            labelSobrenome.Dock = DockStyle.Left;
            labelSobrenome.Font = new Font("Calibri", 12F, FontStyle.Bold);
            labelSobrenome.Location = new Point(179, 0);
            labelSobrenome.Name = "labelSobrenome";
            labelSobrenome.Size = new Size(179, 58);
            labelSobrenome.TabIndex = 1;
            labelSobrenome.Text = "Sobrenome";
            labelSobrenome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelNome
            // 
            labelNome.BackColor = Color.White;
            labelNome.Dock = DockStyle.Left;
            labelNome.Font = new Font("Calibri", 12F, FontStyle.Bold);
            labelNome.Location = new Point(0, 0);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(179, 58);
            labelNome.TabIndex = 0;
            labelNome.Text = "Nome";
            labelNome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Alunos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1157, 770);
            Controls.Add(splitContainer1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Alunos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Alunos";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMinimizarJanela).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFecharJanela).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPesquisar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFiltro).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAdicionar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAtualizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataGridView1;
        private OpenFileDialog openFileDialog1;
        private Panel panel1;
        private PictureBox pictureBoxMinimizarJanela;
        private PictureBox pictureBoxFecharJanela;
        private SplitContainer splitContainer1;
        private Label label5;
        private Panel panel2;
        private Label label3;
        private PictureBox pictureBoxAdicionar;
        private Label label2;
        private PictureBox pictureBoxAtualizar;
        private PictureBox pictureBox1;
        private TextBox textBoxPesquisar;
        private Label label1;
        private ToolTip toolTip1;
        private Panel panel3;
        private Label labelMatricula;
        private Label labelTelefone;
        private Label labelSobrenome;
        private Label labelNome;
        private Label labelTurma;
        private Label labelSerie;
        private Label labelIdade;
        private Panel panel4;
        private ComboBox comboBoxFiltro;
        private PictureBox pictureBoxFiltro;
        private PictureBox pictureBoxPesquisar;
    }
}