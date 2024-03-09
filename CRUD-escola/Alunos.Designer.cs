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
            splitContainer1 = new SplitContainer();
            buttonDeletar = new Button();
            buttonAtualizar = new Button();
            buttonListar = new Button();
            buttonCriar = new Button();
            splitContainer2 = new SplitContainer();
            comboBoxTurma = new ComboBox();
            textBoxIdade = new TextBox();
            textBoxMatricula = new TextBox();
            textBoxNome = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            buttonFoto = new Button();
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            openFileDialog1 = new OpenFileDialog();
            labelNome = new Label();
            labelMatricula = new Label();
            labelIdade = new Label();
            labelTurma = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.FixedPanel = FixedPanel.Panel1;
            splitContainer1.IsSplitterFixed = true;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(buttonDeletar);
            splitContainer1.Panel1.Controls.Add(buttonAtualizar);
            splitContainer1.Panel1.Controls.Add(buttonListar);
            splitContainer1.Panel1.Controls.Add(buttonCriar);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer2);
            splitContainer1.Size = new Size(986, 953);
            splitContainer1.SplitterDistance = 266;
            splitContainer1.TabIndex = 0;
            // 
            // buttonDeletar
            // 
            buttonDeletar.Dock = DockStyle.Top;
            buttonDeletar.Location = new Point(0, 210);
            buttonDeletar.Name = "buttonDeletar";
            buttonDeletar.Size = new Size(266, 70);
            buttonDeletar.TabIndex = 3;
            buttonDeletar.Text = "Deletar";
            buttonDeletar.UseVisualStyleBackColor = true;
            // 
            // buttonAtualizar
            // 
            buttonAtualizar.Dock = DockStyle.Top;
            buttonAtualizar.Location = new Point(0, 140);
            buttonAtualizar.Name = "buttonAtualizar";
            buttonAtualizar.Size = new Size(266, 70);
            buttonAtualizar.TabIndex = 2;
            buttonAtualizar.Text = "Atualizar";
            buttonAtualizar.UseVisualStyleBackColor = true;
            // 
            // buttonListar
            // 
            buttonListar.Dock = DockStyle.Top;
            buttonListar.Location = new Point(0, 70);
            buttonListar.Name = "buttonListar";
            buttonListar.Size = new Size(266, 70);
            buttonListar.TabIndex = 1;
            buttonListar.Text = "Listar";
            buttonListar.UseVisualStyleBackColor = true;
            // 
            // buttonCriar
            // 
            buttonCriar.Dock = DockStyle.Top;
            buttonCriar.Location = new Point(0, 0);
            buttonCriar.Name = "buttonCriar";
            buttonCriar.Size = new Size(266, 70);
            buttonCriar.TabIndex = 0;
            buttonCriar.Text = "Criar";
            buttonCriar.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.FixedPanel = FixedPanel.Panel1;
            splitContainer2.IsSplitterFixed = true;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(labelTurma);
            splitContainer2.Panel1.Controls.Add(labelIdade);
            splitContainer2.Panel1.Controls.Add(labelMatricula);
            splitContainer2.Panel1.Controls.Add(labelNome);
            splitContainer2.Panel1.Controls.Add(comboBoxTurma);
            splitContainer2.Panel1.Controls.Add(textBoxIdade);
            splitContainer2.Panel1.Controls.Add(textBoxMatricula);
            splitContainer2.Panel1.Controls.Add(textBoxNome);
            splitContainer2.Panel1.Controls.Add(label4);
            splitContainer2.Panel1.Controls.Add(label3);
            splitContainer2.Panel1.Controls.Add(label2);
            splitContainer2.Panel1.Controls.Add(label1);
            splitContainer2.Panel1.Controls.Add(buttonFoto);
            splitContainer2.Panel1.Controls.Add(pictureBox1);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(dataGridView1);
            splitContainer2.Size = new Size(716, 953);
            splitContainer2.SplitterDistance = 317;
            splitContainer2.TabIndex = 0;
            // 
            // comboBoxTurma
            // 
            comboBoxTurma.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTurma.FormattingEnabled = true;
            comboBoxTurma.Items.AddRange(new object[] { "A", "B", "C" });
            comboBoxTurma.Location = new Point(368, 244);
            comboBoxTurma.Name = "comboBoxTurma";
            comboBoxTurma.Size = new Size(116, 28);
            comboBoxTurma.TabIndex = 10;
            // 
            // textBoxIdade
            // 
            textBoxIdade.Location = new Point(368, 174);
            textBoxIdade.Name = "textBoxIdade";
            textBoxIdade.Size = new Size(324, 27);
            textBoxIdade.TabIndex = 9;
            // 
            // textBoxMatricula
            // 
            textBoxMatricula.Location = new Point(368, 105);
            textBoxMatricula.Name = "textBoxMatricula";
            textBoxMatricula.Size = new Size(324, 27);
            textBoxMatricula.TabIndex = 8;
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(368, 38);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(324, 27);
            textBoxNome.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(283, 248);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 5;
            label4.Text = "Turma:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(283, 177);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 4;
            label3.Text = "Idade:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(283, 108);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 3;
            label2.Text = "Matrícula:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(283, 41);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 2;
            label1.Text = "Nome:";
            // 
            // buttonFoto
            // 
            buttonFoto.Location = new Point(222, 276);
            buttonFoto.Name = "buttonFoto";
            buttonFoto.Size = new Size(44, 29);
            buttonFoto.TabIndex = 1;
            buttonFoto.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icone_perfil;
            pictureBox1.Location = new Point(21, 41);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(245, 224);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(716, 632);
            dataGridView1.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.ForeColor = Color.IndianRed;
            labelNome.Location = new Point(368, 75);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(78, 20);
            labelNome.TabIndex = 11;
            labelNome.Text = "Erro nome";
            labelNome.Visible = false;
            // 
            // labelMatricula
            // 
            labelMatricula.AutoSize = true;
            labelMatricula.ForeColor = Color.IndianRed;
            labelMatricula.Location = new Point(368, 143);
            labelMatricula.Name = "labelMatricula";
            labelMatricula.Size = new Size(102, 20);
            labelMatricula.TabIndex = 12;
            labelMatricula.Text = "Erro matrícula";
            labelMatricula.Visible = false;
            // 
            // labelIdade
            // 
            labelIdade.AutoSize = true;
            labelIdade.ForeColor = Color.IndianRed;
            labelIdade.Location = new Point(368, 211);
            labelIdade.Name = "labelIdade";
            labelIdade.Size = new Size(78, 20);
            labelIdade.TabIndex = 13;
            labelIdade.Text = "Erro idade";
            labelIdade.Visible = false;
            // 
            // labelTurma
            // 
            labelTurma.AutoSize = true;
            labelTurma.ForeColor = Color.IndianRed;
            labelTurma.Location = new Point(368, 285);
            labelTurma.Name = "labelTurma";
            labelTurma.Size = new Size(79, 20);
            labelTurma.TabIndex = 14;
            labelTurma.Text = "Erro turma";
            labelTurma.Visible = false;
            // 
            // Alunos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(986, 953);
            Controls.Add(splitContainer1);
            MaximumSize = new Size(1004, 1000);
            MinimumSize = new Size(1004, 1000);
            Name = "Alunos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Alunos";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel1.PerformLayout();
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Button buttonDeletar;
        private Button buttonAtualizar;
        private Button buttonListar;
        private Button buttonCriar;
        private SplitContainer splitContainer2;
        private DataGridView dataGridView1;
        private TextBox textBoxIdade;
        private TextBox textBoxMatricula;
        private TextBox textBoxNome;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button buttonFoto;
        private PictureBox pictureBox1;
        private OpenFileDialog openFileDialog1;
        private ComboBox comboBoxTurma;
        private Label labelMatricula;
        private Label labelNome;
        private Label labelTurma;
        private Label labelIdade;
    }
}