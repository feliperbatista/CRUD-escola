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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            openFileDialog1 = new OpenFileDialog();
            panel1 = new Panel();
            label5 = new Label();
            pictureBoxMinimizarJanela = new PictureBox();
            pictureBoxFecharJanela = new PictureBox();
            splitContainer1 = new SplitContainer();
            panel2 = new Panel();
            label3 = new Label();
            pictureBoxAdicionar = new PictureBox();
            label2 = new Label();
            pictureBoxAtualizar = new PictureBox();
            pictureBox1 = new PictureBox();
            textBoxPesquisar = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMinimizarJanela).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFecharJanela).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAdicionar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAtualizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Calibri", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.GridColor = Color.Black;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 75;
            dataGridView1.ShowEditingIcon = false;
            dataGridView1.Size = new Size(1157, 675);
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
            label5.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(13, 202, 122);
            label5.Location = new Point(12, 14);
            label5.Name = "label5";
            label5.Size = new Size(251, 18);
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
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.FixedPanel = FixedPanel.Panel1;
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
            splitContainer1.Panel2.Controls.Add(dataGridView1);
            splitContainer1.Size = new Size(1157, 732);
            splitContainer1.SplitterDistance = 53;
            splitContainer1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(13, 202, 122);
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(724, 14);
            label3.Name = "label3";
            label3.Size = new Size(190, 24);
            label3.TabIndex = 6;
            label3.Text = "Adicionar novo aluno";
            // 
            // pictureBoxAdicionar
            // 
            pictureBoxAdicionar.Image = Properties.Resources.adicionar;
            pictureBoxAdicionar.Location = new Point(698, 15);
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
            label2.Location = new Point(591, 14);
            label2.Name = "label2";
            label2.Size = new Size(84, 24);
            label2.TabIndex = 4;
            label2.Text = "Atualizar";
            // 
            // pictureBoxAtualizar
            // 
            pictureBoxAtualizar.Image = Properties.Resources.refresh;
            pictureBoxAtualizar.Location = new Point(564, 16);
            pictureBoxAtualizar.Name = "pictureBoxAtualizar";
            pictureBoxAtualizar.Size = new Size(20, 20);
            pictureBoxAtualizar.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxAtualizar.TabIndex = 3;
            pictureBoxAtualizar.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(521, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(18, 34);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // textBoxPesquisar
            // 
            textBoxPesquisar.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxPesquisar.Location = new Point(139, 10);
            textBoxPesquisar.Name = "textBoxPesquisar";
            textBoxPesquisar.Size = new Size(371, 32);
            textBoxPesquisar.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(36, 14);
            label1.Name = "label1";
            label1.Size = new Size(97, 24);
            label1.TabIndex = 0;
            label1.Text = "Pesquisar:";
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
            ((System.ComponentModel.ISupportInitialize)pictureBoxAdicionar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAtualizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
    }
}