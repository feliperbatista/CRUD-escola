namespace CRUD_escola
{
    partial class NovoAluno
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
            pictureBoxFoto = new PictureBox();
            panelNome = new Panel();
            textBoxNome = new TextBox();
            pictureBoxNome = new PictureBox();
            labelErroNome = new Label();
            labelErroSobrenome = new Label();
            labelErroTelefone = new Label();
            panelMatricula = new Panel();
            textBoxMatricula = new TextBox();
            pictureBoxMatricula = new PictureBox();
            labelErroIdade = new Label();
            panelTurma = new Panel();
            comboBoxTurma = new ComboBox();
            pictureBoxTurma = new PictureBox();
            labelErroMatricula = new Label();
            panelSerie = new Panel();
            comboBoxSerie = new ComboBox();
            pictureBoxSerie = new PictureBox();
            panelIdade = new Panel();
            textBoxIdade = new TextBox();
            pictureBoxIdade = new PictureBox();
            pictureBoxEditarFoto = new PictureBox();
            labelErroSerie = new Label();
            labelErroTurma = new Label();
            pictureBoxCadastrar = new PictureBox();
            panelSobrenome = new Panel();
            textBoxSobrenome = new TextBox();
            pictureBoxSobrenome = new PictureBox();
            panelTelefone = new Panel();
            maskedTextBoxTelefone = new MaskedTextBox();
            pictureBoxTelefone = new PictureBox();
            openFileDialog1 = new OpenFileDialog();
            labelErroFoto = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFoto).BeginInit();
            panelNome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxNome).BeginInit();
            panelMatricula.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMatricula).BeginInit();
            panelTurma.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTurma).BeginInit();
            panelSerie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSerie).BeginInit();
            panelIdade.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIdade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxEditarFoto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCadastrar).BeginInit();
            panelSobrenome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSobrenome).BeginInit();
            panelTelefone.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTelefone).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxFoto
            // 
            pictureBoxFoto.BackgroundImage = Properties.Resources.icone_pessoa;
            pictureBoxFoto.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxFoto.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxFoto.Location = new Point(18, 17);
            pictureBoxFoto.Name = "pictureBoxFoto";
            pictureBoxFoto.Size = new Size(260, 316);
            pictureBoxFoto.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxFoto.TabIndex = 0;
            pictureBoxFoto.TabStop = false;
            // 
            // panelNome
            // 
            panelNome.BackColor = Color.White;
            panelNome.CausesValidation = false;
            panelNome.Controls.Add(textBoxNome);
            panelNome.Controls.Add(pictureBoxNome);
            panelNome.Location = new Point(305, 17);
            panelNome.Name = "panelNome";
            panelNome.Size = new Size(251, 42);
            panelNome.TabIndex = 0;
            // 
            // textBoxNome
            // 
            textBoxNome.BorderStyle = BorderStyle.None;
            textBoxNome.Font = new Font("Calibri", 10.8F);
            textBoxNome.ForeColor = Color.Silver;
            textBoxNome.Location = new Point(44, 10);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(195, 22);
            textBoxNome.TabIndex = 14;
            textBoxNome.Text = "Nome";
            // 
            // pictureBoxNome
            // 
            pictureBoxNome.BackColor = Color.Transparent;
            pictureBoxNome.Image = Properties.Resources.icone_pessoa;
            pictureBoxNome.Location = new Point(8, 6);
            pictureBoxNome.Name = "pictureBoxNome";
            pictureBoxNome.Size = new Size(30, 31);
            pictureBoxNome.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxNome.TabIndex = 13;
            pictureBoxNome.TabStop = false;
            // 
            // labelErroNome
            // 
            labelErroNome.AutoSize = true;
            labelErroNome.BackColor = Color.Transparent;
            labelErroNome.Font = new Font("Calibri", 9F);
            labelErroNome.ForeColor = Color.IndianRed;
            labelErroNome.Location = new Point(305, 74);
            labelErroNome.Name = "labelErroNome";
            labelErroNome.Size = new Size(72, 18);
            labelErroNome.TabIndex = 29;
            labelErroNome.Text = "Erro nome";
            labelErroNome.Visible = false;
            // 
            // labelErroSobrenome
            // 
            labelErroSobrenome.AutoSize = true;
            labelErroSobrenome.BackColor = Color.Transparent;
            labelErroSobrenome.Font = new Font("Calibri", 9F);
            labelErroSobrenome.ForeColor = Color.IndianRed;
            labelErroSobrenome.Location = new Point(577, 74);
            labelErroSobrenome.Name = "labelErroSobrenome";
            labelErroSobrenome.Size = new Size(107, 18);
            labelErroSobrenome.TabIndex = 31;
            labelErroSobrenome.Text = "Erro sobrenome";
            labelErroSobrenome.Visible = false;
            // 
            // labelErroTelefone
            // 
            labelErroTelefone.AutoSize = true;
            labelErroTelefone.BackColor = Color.Transparent;
            labelErroTelefone.Font = new Font("Calibri", 9F);
            labelErroTelefone.ForeColor = Color.IndianRed;
            labelErroTelefone.Location = new Point(305, 164);
            labelErroTelefone.Name = "labelErroTelefone";
            labelErroTelefone.Size = new Size(90, 18);
            labelErroTelefone.TabIndex = 33;
            labelErroTelefone.Text = "Erro telefone";
            labelErroTelefone.Visible = false;
            // 
            // panelMatricula
            // 
            panelMatricula.BackColor = Color.White;
            panelMatricula.CausesValidation = false;
            panelMatricula.Controls.Add(textBoxMatricula);
            panelMatricula.Controls.Add(pictureBoxMatricula);
            panelMatricula.Location = new Point(305, 197);
            panelMatricula.Name = "panelMatricula";
            panelMatricula.Size = new Size(523, 42);
            panelMatricula.TabIndex = 3;
            // 
            // textBoxMatricula
            // 
            textBoxMatricula.BorderStyle = BorderStyle.None;
            textBoxMatricula.Font = new Font("Calibri", 10.8F);
            textBoxMatricula.ForeColor = Color.Silver;
            textBoxMatricula.Location = new Point(44, 10);
            textBoxMatricula.Name = "textBoxMatricula";
            textBoxMatricula.Size = new Size(466, 22);
            textBoxMatricula.TabIndex = 14;
            textBoxMatricula.Text = "Matrícula";
            // 
            // pictureBoxMatricula
            // 
            pictureBoxMatricula.BackColor = Color.Transparent;
            pictureBoxMatricula.Image = Properties.Resources.icone_matricula;
            pictureBoxMatricula.Location = new Point(8, 6);
            pictureBoxMatricula.Name = "pictureBoxMatricula";
            pictureBoxMatricula.Size = new Size(30, 31);
            pictureBoxMatricula.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxMatricula.TabIndex = 13;
            pictureBoxMatricula.TabStop = false;
            // 
            // labelErroIdade
            // 
            labelErroIdade.AutoSize = true;
            labelErroIdade.BackColor = Color.Transparent;
            labelErroIdade.Font = new Font("Calibri", 9F);
            labelErroIdade.ForeColor = Color.IndianRed;
            labelErroIdade.Location = new Point(305, 344);
            labelErroIdade.Name = "labelErroIdade";
            labelErroIdade.Size = new Size(71, 18);
            labelErroIdade.TabIndex = 38;
            labelErroIdade.Text = "Erro idade";
            labelErroIdade.Visible = false;
            // 
            // panelTurma
            // 
            panelTurma.BackColor = Color.White;
            panelTurma.CausesValidation = false;
            panelTurma.Controls.Add(comboBoxTurma);
            panelTurma.Controls.Add(pictureBoxTurma);
            panelTurma.Location = new Point(669, 287);
            panelTurma.Name = "panelTurma";
            panelTurma.Size = new Size(159, 42);
            panelTurma.TabIndex = 6;
            // 
            // comboBoxTurma
            // 
            comboBoxTurma.FlatStyle = FlatStyle.Flat;
            comboBoxTurma.Font = new Font("Calibri", 10.8F);
            comboBoxTurma.ForeColor = Color.Silver;
            comboBoxTurma.FormattingEnabled = true;
            comboBoxTurma.Items.AddRange(new object[] { "A", "B", "C" });
            comboBoxTurma.Location = new Point(44, 6);
            comboBoxTurma.Name = "comboBoxTurma";
            comboBoxTurma.Size = new Size(102, 30);
            comboBoxTurma.TabIndex = 14;
            comboBoxTurma.Text = "Turma";
            // 
            // pictureBoxTurma
            // 
            pictureBoxTurma.BackColor = Color.Transparent;
            pictureBoxTurma.Image = Properties.Resources.icone_turma;
            pictureBoxTurma.Location = new Point(8, 6);
            pictureBoxTurma.Name = "pictureBoxTurma";
            pictureBoxTurma.Size = new Size(30, 31);
            pictureBoxTurma.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxTurma.TabIndex = 13;
            pictureBoxTurma.TabStop = false;
            // 
            // labelErroMatricula
            // 
            labelErroMatricula.AutoSize = true;
            labelErroMatricula.BackColor = Color.Transparent;
            labelErroMatricula.Font = new Font("Calibri", 9F);
            labelErroMatricula.ForeColor = Color.IndianRed;
            labelErroMatricula.Location = new Point(305, 254);
            labelErroMatricula.Name = "labelErroMatricula";
            labelErroMatricula.Size = new Size(94, 18);
            labelErroMatricula.TabIndex = 36;
            labelErroMatricula.Text = "Erro matricula";
            labelErroMatricula.Visible = false;
            // 
            // panelSerie
            // 
            panelSerie.BackColor = Color.White;
            panelSerie.CausesValidation = false;
            panelSerie.Controls.Add(comboBoxSerie);
            panelSerie.Controls.Add(pictureBoxSerie);
            panelSerie.Location = new Point(487, 287);
            panelSerie.Name = "panelSerie";
            panelSerie.Size = new Size(159, 42);
            panelSerie.TabIndex = 5;
            // 
            // comboBoxSerie
            // 
            comboBoxSerie.FlatStyle = FlatStyle.Flat;
            comboBoxSerie.Font = new Font("Calibri", 10.8F);
            comboBoxSerie.ForeColor = Color.Silver;
            comboBoxSerie.FormattingEnabled = true;
            comboBoxSerie.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            comboBoxSerie.Location = new Point(44, 6);
            comboBoxSerie.Name = "comboBoxSerie";
            comboBoxSerie.Size = new Size(102, 30);
            comboBoxSerie.TabIndex = 14;
            comboBoxSerie.Text = "Série";
            // 
            // pictureBoxSerie
            // 
            pictureBoxSerie.BackColor = Color.Transparent;
            pictureBoxSerie.Image = Properties.Resources.icone_turma;
            pictureBoxSerie.Location = new Point(8, 6);
            pictureBoxSerie.Name = "pictureBoxSerie";
            pictureBoxSerie.Size = new Size(30, 31);
            pictureBoxSerie.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxSerie.TabIndex = 13;
            pictureBoxSerie.TabStop = false;
            // 
            // panelIdade
            // 
            panelIdade.BackColor = Color.White;
            panelIdade.CausesValidation = false;
            panelIdade.Controls.Add(textBoxIdade);
            panelIdade.Controls.Add(pictureBoxIdade);
            panelIdade.Location = new Point(305, 287);
            panelIdade.Name = "panelIdade";
            panelIdade.Size = new Size(159, 42);
            panelIdade.TabIndex = 4;
            // 
            // textBoxIdade
            // 
            textBoxIdade.BorderStyle = BorderStyle.None;
            textBoxIdade.Font = new Font("Calibri", 10.8F);
            textBoxIdade.ForeColor = Color.Silver;
            textBoxIdade.Location = new Point(44, 10);
            textBoxIdade.Name = "textBoxIdade";
            textBoxIdade.Size = new Size(102, 22);
            textBoxIdade.TabIndex = 14;
            textBoxIdade.Text = "Idade";
            // 
            // pictureBoxIdade
            // 
            pictureBoxIdade.BackColor = Color.Transparent;
            pictureBoxIdade.Image = Properties.Resources.icone_idade;
            pictureBoxIdade.Location = new Point(8, 6);
            pictureBoxIdade.Name = "pictureBoxIdade";
            pictureBoxIdade.Size = new Size(30, 31);
            pictureBoxIdade.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxIdade.TabIndex = 13;
            pictureBoxIdade.TabStop = false;
            // 
            // pictureBoxEditarFoto
            // 
            pictureBoxEditarFoto.Image = Properties.Resources.icone_editar;
            pictureBoxEditarFoto.Location = new Point(243, 339);
            pictureBoxEditarFoto.Name = "pictureBoxEditarFoto";
            pictureBoxEditarFoto.Size = new Size(35, 23);
            pictureBoxEditarFoto.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxEditarFoto.TabIndex = 39;
            pictureBoxEditarFoto.TabStop = false;
            // 
            // labelErroSerie
            // 
            labelErroSerie.AutoSize = true;
            labelErroSerie.BackColor = Color.Transparent;
            labelErroSerie.Font = new Font("Calibri", 9F);
            labelErroSerie.ForeColor = Color.IndianRed;
            labelErroSerie.Location = new Point(487, 344);
            labelErroSerie.Name = "labelErroSerie";
            labelErroSerie.Size = new Size(67, 18);
            labelErroSerie.TabIndex = 40;
            labelErroSerie.Text = "Erro serie";
            labelErroSerie.Visible = false;
            // 
            // labelErroTurma
            // 
            labelErroTurma.AutoSize = true;
            labelErroTurma.BackColor = Color.Transparent;
            labelErroTurma.Font = new Font("Calibri", 9F);
            labelErroTurma.ForeColor = Color.IndianRed;
            labelErroTurma.Location = new Point(669, 344);
            labelErroTurma.Name = "labelErroTurma";
            labelErroTurma.Size = new Size(73, 18);
            labelErroTurma.TabIndex = 41;
            labelErroTurma.Text = "Erro turma";
            labelErroTurma.Visible = false;
            // 
            // pictureBoxCadastrar
            // 
            pictureBoxCadastrar.BackColor = Color.Transparent;
            pictureBoxCadastrar.Image = Properties.Resources.button_cadastrar_colorido;
            pictureBoxCadastrar.Location = new Point(645, 376);
            pictureBoxCadastrar.Name = "pictureBoxCadastrar";
            pictureBoxCadastrar.Size = new Size(183, 52);
            pictureBoxCadastrar.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBoxCadastrar.TabIndex = 42;
            pictureBoxCadastrar.TabStop = false;
            // 
            // panelSobrenome
            // 
            panelSobrenome.BackColor = Color.White;
            panelSobrenome.CausesValidation = false;
            panelSobrenome.Controls.Add(textBoxSobrenome);
            panelSobrenome.Controls.Add(pictureBoxSobrenome);
            panelSobrenome.Location = new Point(577, 17);
            panelSobrenome.Name = "panelSobrenome";
            panelSobrenome.Size = new Size(251, 42);
            panelSobrenome.TabIndex = 1;
            // 
            // textBoxSobrenome
            // 
            textBoxSobrenome.BorderStyle = BorderStyle.None;
            textBoxSobrenome.Font = new Font("Calibri", 10.8F);
            textBoxSobrenome.ForeColor = Color.Silver;
            textBoxSobrenome.Location = new Point(44, 10);
            textBoxSobrenome.Name = "textBoxSobrenome";
            textBoxSobrenome.Size = new Size(195, 22);
            textBoxSobrenome.TabIndex = 14;
            textBoxSobrenome.Text = "Sobrenome";
            // 
            // pictureBoxSobrenome
            // 
            pictureBoxSobrenome.BackColor = Color.Transparent;
            pictureBoxSobrenome.Image = Properties.Resources.icone_pessoa;
            pictureBoxSobrenome.Location = new Point(8, 6);
            pictureBoxSobrenome.Name = "pictureBoxSobrenome";
            pictureBoxSobrenome.Size = new Size(30, 31);
            pictureBoxSobrenome.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxSobrenome.TabIndex = 13;
            pictureBoxSobrenome.TabStop = false;
            // 
            // panelTelefone
            // 
            panelTelefone.BackColor = Color.White;
            panelTelefone.CausesValidation = false;
            panelTelefone.Controls.Add(maskedTextBoxTelefone);
            panelTelefone.Controls.Add(pictureBoxTelefone);
            panelTelefone.Location = new Point(305, 107);
            panelTelefone.Name = "panelTelefone";
            panelTelefone.Size = new Size(523, 42);
            panelTelefone.TabIndex = 2;
            // 
            // maskedTextBoxTelefone
            // 
            maskedTextBoxTelefone.BorderStyle = BorderStyle.None;
            maskedTextBoxTelefone.Font = new Font("Calibri", 10.8F);
            maskedTextBoxTelefone.ForeColor = Color.Silver;
            maskedTextBoxTelefone.Location = new Point(44, 10);
            maskedTextBoxTelefone.Mask = "(99) 00000-0000";
            maskedTextBoxTelefone.Name = "maskedTextBoxTelefone";
            maskedTextBoxTelefone.Size = new Size(466, 22);
            maskedTextBoxTelefone.TabIndex = 14;
            // 
            // pictureBoxTelefone
            // 
            pictureBoxTelefone.BackColor = Color.Transparent;
            pictureBoxTelefone.Image = Properties.Resources.icone_telefone;
            pictureBoxTelefone.Location = new Point(8, 6);
            pictureBoxTelefone.Name = "pictureBoxTelefone";
            pictureBoxTelefone.Size = new Size(30, 31);
            pictureBoxTelefone.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxTelefone.TabIndex = 13;
            pictureBoxTelefone.TabStop = false;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // labelErroFoto
            // 
            labelErroFoto.AutoSize = true;
            labelErroFoto.BackColor = Color.Transparent;
            labelErroFoto.Font = new Font("Calibri", 9F);
            labelErroFoto.ForeColor = Color.IndianRed;
            labelErroFoto.Location = new Point(18, 344);
            labelErroFoto.Name = "labelErroFoto";
            labelErroFoto.Size = new Size(62, 18);
            labelErroFoto.TabIndex = 44;
            labelErroFoto.Text = "Erro foto";
            labelErroFoto.Visible = false;
            // 
            // NovoAluno
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(840, 440);
            Controls.Add(labelErroFoto);
            Controls.Add(panelTelefone);
            Controls.Add(panelSobrenome);
            Controls.Add(pictureBoxCadastrar);
            Controls.Add(labelErroTurma);
            Controls.Add(labelErroSerie);
            Controls.Add(pictureBoxEditarFoto);
            Controls.Add(labelErroIdade);
            Controls.Add(panelTurma);
            Controls.Add(labelErroMatricula);
            Controls.Add(panelSerie);
            Controls.Add(panelIdade);
            Controls.Add(labelErroTelefone);
            Controls.Add(panelMatricula);
            Controls.Add(labelErroSobrenome);
            Controls.Add(labelErroNome);
            Controls.Add(panelNome);
            Controls.Add(pictureBoxFoto);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximumSize = new Size(858, 487);
            Name = "NovoAluno";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Novo aluno";
            ((System.ComponentModel.ISupportInitialize)pictureBoxFoto).EndInit();
            panelNome.ResumeLayout(false);
            panelNome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxNome).EndInit();
            panelMatricula.ResumeLayout(false);
            panelMatricula.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMatricula).EndInit();
            panelTurma.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxTurma).EndInit();
            panelSerie.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxSerie).EndInit();
            panelIdade.ResumeLayout(false);
            panelIdade.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIdade).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxEditarFoto).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCadastrar).EndInit();
            panelSobrenome.ResumeLayout(false);
            panelSobrenome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSobrenome).EndInit();
            panelTelefone.ResumeLayout(false);
            panelTelefone.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTelefone).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxFoto;
        private Panel panelNome;
        private PictureBox pictureBoxNome;
        private Panel panel1;
        private PictureBox pictureBox1;
        private TextBox textBoxNome;
        private Label labelErroNome;
        private Label labelErroSobrenome;
        private Panel panel2;
        private PictureBox pictureBox2;
        private Label labelErroTelefone;
        private Panel panelMatricula;
        private PictureBox pictureBoxMatricula;
        private Label labelErroIdade;
        private Panel panelTurma;
        private PictureBox pictureBoxTurma;
        private Label labelErroMatricula;
        private Panel panelSerie;
        private PictureBox pictureBoxSerie;
        private Panel panelIdade;
        private PictureBox pictureBoxIdade;
        private TextBox textBoxSobrenome;
        private PictureBox pictureBoxEditarFoto;
        private Label labelErroSerie;
        private Label labelErroTurma;
        private PictureBox pictureBoxCadastrar;
        //private MaskedTextBox maskedTextBoxTelefone;
        private Panel panelSobrenome;
        private PictureBox pictureBoxSobrenome;
        private Panel panelTelefone;
        private PictureBox pictureBoxTelefone;
        private OpenFileDialog openFileDialog1;
        private Label labelErroFoto;
        private TextBox textBoxMatricula;
        private ComboBox comboBoxTurma;
        private ComboBox comboBoxSerie;
        private TextBox textBoxIdade;
        private MaskedTextBox maskedTextBoxTelefone;
    }
}