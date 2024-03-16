namespace CRUD_escola
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            labelLogin = new Label();
            textBoxSenhaLogin = new TextBox();
            textBoxEmailLogin = new TextBox();
            panelEmailLogin = new Panel();
            pictureBoxEmailLogin = new PictureBox();
            panelCadastro = new Panel();
            labelFelipe = new Label();
            pictureBoxFecharJanela = new PictureBox();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            pictureBoxCadastrar = new PictureBox();
            label1 = new Label();
            pictureBoxExibirSenhaLogin = new PictureBox();
            panelSenhaLogin = new Panel();
            pictureBoxSenhaLogin = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            pictureBoxLogin = new PictureBox();
            panelAcesso = new Panel();
            pictureBox1 = new PictureBox();
            labelErroSenhaLogin = new Label();
            labelErroEmailLogin = new Label();
            toolTip1 = new ToolTip(components);
            panelEmailLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxEmailLogin).BeginInit();
            panelCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFecharJanela).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCadastrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxExibirSenhaLogin).BeginInit();
            panelSenhaLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSenhaLogin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogin).BeginInit();
            panelAcesso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // labelLogin
            // 
            labelLogin.AutoSize = true;
            labelLogin.Font = new Font("Calibri", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelLogin.ForeColor = Color.FromArgb(13, 202, 122);
            labelLogin.Location = new Point(146, 86);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(259, 41);
            labelLogin.TabIndex = 0;
            labelLogin.Text = "Acesse sua conta";
            // 
            // textBoxSenhaLogin
            // 
            textBoxSenhaLogin.BorderStyle = BorderStyle.None;
            textBoxSenhaLogin.Font = new Font("Calibri", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxSenhaLogin.ForeColor = Color.Silver;
            textBoxSenhaLogin.Location = new Point(44, 10);
            textBoxSenhaLogin.Name = "textBoxSenhaLogin";
            textBoxSenhaLogin.Size = new Size(215, 22);
            textBoxSenhaLogin.TabIndex = 3;
            textBoxSenhaLogin.Text = "Digite sua senha";
            // 
            // textBoxEmailLogin
            // 
            textBoxEmailLogin.BorderStyle = BorderStyle.None;
            textBoxEmailLogin.Font = new Font("Calibri", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxEmailLogin.ForeColor = Color.Silver;
            textBoxEmailLogin.Location = new Point(44, 9);
            textBoxEmailLogin.Name = "textBoxEmailLogin";
            textBoxEmailLogin.Size = new Size(256, 22);
            textBoxEmailLogin.TabIndex = 1;
            textBoxEmailLogin.Text = "Digite seu email";
            // 
            // panelEmailLogin
            // 
            panelEmailLogin.CausesValidation = false;
            panelEmailLogin.Controls.Add(pictureBoxEmailLogin);
            panelEmailLogin.Controls.Add(textBoxEmailLogin);
            panelEmailLogin.Location = new Point(120, 170);
            panelEmailLogin.Name = "panelEmailLogin";
            panelEmailLogin.Size = new Size(310, 42);
            panelEmailLogin.TabIndex = 9;
            // 
            // pictureBoxEmailLogin
            // 
            pictureBoxEmailLogin.BackColor = Color.White;
            pictureBoxEmailLogin.Image = Properties.Resources.icone_email;
            pictureBoxEmailLogin.Location = new Point(8, 6);
            pictureBoxEmailLogin.Name = "pictureBoxEmailLogin";
            pictureBoxEmailLogin.Size = new Size(30, 31);
            pictureBoxEmailLogin.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxEmailLogin.TabIndex = 13;
            pictureBoxEmailLogin.TabStop = false;
            // 
            // panelCadastro
            // 
            panelCadastro.BackgroundImage = Properties.Resources.panel_bg;
            panelCadastro.Controls.Add(labelFelipe);
            panelCadastro.Controls.Add(pictureBoxFecharJanela);
            panelCadastro.Controls.Add(pictureBox2);
            panelCadastro.Controls.Add(label2);
            panelCadastro.Controls.Add(pictureBoxCadastrar);
            panelCadastro.Controls.Add(label1);
            panelCadastro.Dock = DockStyle.Right;
            panelCadastro.Location = new Point(550, 0);
            panelCadastro.Name = "panelCadastro";
            panelCadastro.Size = new Size(398, 487);
            panelCadastro.TabIndex = 10;
            // 
            // labelFelipe
            // 
            labelFelipe.AutoSize = true;
            labelFelipe.BackColor = Color.Transparent;
            labelFelipe.Font = new Font("Calibri", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelFelipe.ForeColor = Color.White;
            labelFelipe.Location = new Point(148, 463);
            labelFelipe.Name = "labelFelipe";
            labelFelipe.Size = new Size(238, 15);
            labelFelipe.TabIndex = 18;
            labelFelipe.Text = "Desenvolvido por Felipe Rodrigues Batista";
            // 
            // pictureBoxFecharJanela
            // 
            pictureBoxFecharJanela.BackColor = Color.Transparent;
            pictureBoxFecharJanela.Image = Properties.Resources.button_fechar_janela;
            pictureBoxFecharJanela.Location = new Point(364, 12);
            pictureBoxFecharJanela.Name = "pictureBoxFecharJanela";
            pictureBoxFecharJanela.Size = new Size(22, 22);
            pictureBoxFecharJanela.TabIndex = 11;
            pictureBoxFecharJanela.TabStop = false;
            toolTip1.SetToolTip(pictureBoxFecharJanela, "Fechar");
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.traco_branco;
            pictureBox2.Location = new Point(169, 183);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(61, 17);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 17;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(91, 219);
            label2.Name = "label2";
            label2.Size = new Size(216, 53);
            label2.TabIndex = 13;
            label2.Text = "Faça seu cadastro para ter acesso ao sistema.";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBoxCadastrar
            // 
            pictureBoxCadastrar.BackColor = Color.Transparent;
            pictureBoxCadastrar.Image = Properties.Resources.button_cadastro_inicio;
            pictureBoxCadastrar.Location = new Point(109, 292);
            pictureBoxCadastrar.Name = "pictureBoxCadastrar";
            pictureBoxCadastrar.Size = new Size(183, 52);
            pictureBoxCadastrar.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBoxCadastrar.TabIndex = 12;
            pictureBoxCadastrar.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Calibri", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(91, 143);
            label1.Name = "label1";
            label1.Size = new Size(217, 41);
            label1.TabIndex = 11;
            label1.Text = "Crie sua conta";
            // 
            // pictureBoxExibirSenhaLogin
            // 
            pictureBoxExibirSenhaLogin.Image = Properties.Resources.button_esconder_senha_cinza;
            pictureBoxExibirSenhaLogin.Location = new Point(265, 7);
            pictureBoxExibirSenhaLogin.Name = "pictureBoxExibirSenhaLogin";
            pictureBoxExibirSenhaLogin.Size = new Size(42, 28);
            pictureBoxExibirSenhaLogin.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBoxExibirSenhaLogin.TabIndex = 12;
            pictureBoxExibirSenhaLogin.TabStop = false;
            toolTip1.SetToolTip(pictureBoxExibirSenhaLogin, "Exibir/ocultar senha");
            // 
            // panelSenhaLogin
            // 
            panelSenhaLogin.Controls.Add(pictureBoxSenhaLogin);
            panelSenhaLogin.Controls.Add(pictureBoxExibirSenhaLogin);
            panelSenhaLogin.Controls.Add(textBoxSenhaLogin);
            panelSenhaLogin.Location = new Point(120, 258);
            panelSenhaLogin.Name = "panelSenhaLogin";
            panelSenhaLogin.Size = new Size(310, 42);
            panelSenhaLogin.TabIndex = 13;
            // 
            // pictureBoxSenhaLogin
            // 
            pictureBoxSenhaLogin.BackColor = Color.White;
            pictureBoxSenhaLogin.Image = Properties.Resources.icone_senha;
            pictureBoxSenhaLogin.Location = new Point(8, 6);
            pictureBoxSenhaLogin.Name = "pictureBoxSenhaLogin";
            pictureBoxSenhaLogin.Size = new Size(30, 31);
            pictureBoxSenhaLogin.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxSenhaLogin.TabIndex = 13;
            pictureBoxSenhaLogin.TabStop = false;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 10;
            // 
            // pictureBoxLogin
            // 
            pictureBoxLogin.BackColor = Color.Transparent;
            pictureBoxLogin.Image = Properties.Resources.button_login_colorido;
            pictureBoxLogin.Location = new Point(184, 348);
            pictureBoxLogin.Name = "pictureBoxLogin";
            pictureBoxLogin.Size = new Size(183, 52);
            pictureBoxLogin.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBoxLogin.TabIndex = 13;
            pictureBoxLogin.TabStop = false;
            // 
            // panelAcesso
            // 
            panelAcesso.Controls.Add(pictureBox1);
            panelAcesso.Controls.Add(labelErroSenhaLogin);
            panelAcesso.Controls.Add(labelErroEmailLogin);
            panelAcesso.Controls.Add(pictureBoxLogin);
            panelAcesso.Controls.Add(labelLogin);
            panelAcesso.Controls.Add(panelSenhaLogin);
            panelAcesso.Controls.Add(panelEmailLogin);
            panelAcesso.Dock = DockStyle.Fill;
            panelAcesso.Location = new Point(0, 0);
            panelAcesso.Name = "panelAcesso";
            panelAcesso.Size = new Size(550, 487);
            panelAcesso.TabIndex = 11;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.traco;
            pictureBox1.Location = new Point(245, 126);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(61, 17);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // labelErroSenhaLogin
            // 
            labelErroSenhaLogin.AutoSize = true;
            labelErroSenhaLogin.BackColor = Color.Transparent;
            labelErroSenhaLogin.Font = new Font("Calibri", 9F);
            labelErroSenhaLogin.ForeColor = Color.IndianRed;
            labelErroSenhaLogin.Location = new Point(124, 313);
            labelErroSenhaLogin.Name = "labelErroSenhaLogin";
            labelErroSenhaLogin.Size = new Size(73, 18);
            labelErroSenhaLogin.TabIndex = 15;
            labelErroSenhaLogin.Text = "Erro senha";
            labelErroSenhaLogin.Visible = false;
            // 
            // labelErroEmailLogin
            // 
            labelErroEmailLogin.AutoSize = true;
            labelErroEmailLogin.BackColor = Color.Transparent;
            labelErroEmailLogin.Font = new Font("Calibri", 9F);
            labelErroEmailLogin.ForeColor = Color.IndianRed;
            labelErroEmailLogin.Location = new Point(123, 225);
            labelErroEmailLogin.Name = "labelErroEmailLogin";
            labelErroEmailLogin.Size = new Size(71, 18);
            labelErroEmailLogin.TabIndex = 14;
            labelErroEmailLogin.Text = "Erro email";
            labelErroEmailLogin.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(948, 487);
            Controls.Add(panelAcesso);
            Controls.Add(panelCadastro);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panelEmailLogin.ResumeLayout(false);
            panelEmailLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxEmailLogin).EndInit();
            panelCadastro.ResumeLayout(false);
            panelCadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFecharJanela).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCadastrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxExibirSenhaLogin).EndInit();
            panelSenhaLogin.ResumeLayout(false);
            panelSenhaLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSenhaLogin).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogin).EndInit();
            panelAcesso.ResumeLayout(false);
            panelAcesso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label labelLogin;
        private TextBox textBoxSenhaLogin;
        private TextBox textBoxEmailLogin;
        private Label labelMensagemCadastro;
        private Label labelMensagemLogin;
        private Panel panelEmailLogin;
        private Panel panelCadastro;
        private Label label1;
        private PictureBox pictureBoxCadastrar;
        private PictureBox pictureBoxFecharJanela;
        private PictureBox pictureBoxExibirSenhaLogin;
        private PictureBox pictureBoxEmailLogin;
        private Panel panelSenhaLogin;
        private PictureBox pictureBoxSenhaLogin;
        private System.Windows.Forms.Timer timer1;
        private PictureBox pictureBoxLogin;
        private Panel panelAcesso;
        private Label label2;
        private Label labelErroSenhaLogin;
        private Label labelErroEmailLogin;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private ToolTip toolTip1;
        private Label labelFelipe;
    }
}
