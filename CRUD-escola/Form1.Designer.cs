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
            labelLogin = new Label();
            groupBoxLogin = new GroupBox();
            labelMensagemLogin = new Label();
            buttonLogin = new Button();
            textBoxSenhaLogin = new TextBox();
            label2 = new Label();
            textBoxEmailLogin = new TextBox();
            label1 = new Label();
            groupBoxCadastro = new GroupBox();
            labelMensagemCadastro = new Label();
            buttonCadastrar = new Button();
            textBoxSenhaCadastro = new TextBox();
            label3 = new Label();
            textBoxEmailCadastro = new TextBox();
            label4 = new Label();
            buttonExibirSenhaLogin = new Button();
            buttonExibirSenhaCadastro = new Button();
            groupBoxLogin.SuspendLayout();
            groupBoxCadastro.SuspendLayout();
            SuspendLayout();
            // 
            // labelLogin
            // 
            labelLogin.AutoSize = true;
            labelLogin.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelLogin.Location = new Point(354, 29);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(92, 41);
            labelLogin.TabIndex = 0;
            labelLogin.Text = "Login";
            // 
            // groupBoxLogin
            // 
            groupBoxLogin.Controls.Add(buttonExibirSenhaLogin);
            groupBoxLogin.Controls.Add(labelMensagemLogin);
            groupBoxLogin.Controls.Add(buttonLogin);
            groupBoxLogin.Controls.Add(textBoxSenhaLogin);
            groupBoxLogin.Controls.Add(label2);
            groupBoxLogin.Controls.Add(textBoxEmailLogin);
            groupBoxLogin.Controls.Add(label1);
            groupBoxLogin.Location = new Point(63, 95);
            groupBoxLogin.Name = "groupBoxLogin";
            groupBoxLogin.Size = new Size(318, 325);
            groupBoxLogin.TabIndex = 1;
            groupBoxLogin.TabStop = false;
            groupBoxLogin.Text = "Fazer login";
            // 
            // labelMensagemLogin
            // 
            labelMensagemLogin.AutoSize = true;
            labelMensagemLogin.ForeColor = Color.IndianRed;
            labelMensagemLogin.Location = new Point(6, 193);
            labelMensagemLogin.Name = "labelMensagemLogin";
            labelMensagemLogin.Size = new Size(36, 20);
            labelMensagemLogin.TabIndex = 5;
            labelMensagemLogin.Text = "Erro";
            labelMensagemLogin.Visible = false;
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(112, 266);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(94, 29);
            buttonLogin.TabIndex = 4;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = true;
            // 
            // textBoxSenhaLogin
            // 
            textBoxSenhaLogin.Location = new Point(6, 145);
            textBoxSenhaLogin.Name = "textBoxSenhaLogin";
            textBoxSenhaLogin.PasswordChar = '*';
            textBoxSenhaLogin.Size = new Size(269, 27);
            textBoxSenhaLogin.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 113);
            label2.Name = "label2";
            label2.Size = new Size(115, 20);
            label2.TabIndex = 2;
            label2.Text = "Insira sua senha:";
            // 
            // textBoxEmailLogin
            // 
            textBoxEmailLogin.Location = new Point(6, 76);
            textBoxEmailLogin.Name = "textBoxEmailLogin";
            textBoxEmailLogin.Size = new Size(306, 27);
            textBoxEmailLogin.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 44);
            label1.Name = "label1";
            label1.Size = new Size(114, 20);
            label1.TabIndex = 0;
            label1.Text = "Insira seu email:";
            // 
            // groupBoxCadastro
            // 
            groupBoxCadastro.Controls.Add(buttonExibirSenhaCadastro);
            groupBoxCadastro.Controls.Add(labelMensagemCadastro);
            groupBoxCadastro.Controls.Add(buttonCadastrar);
            groupBoxCadastro.Controls.Add(textBoxSenhaCadastro);
            groupBoxCadastro.Controls.Add(label3);
            groupBoxCadastro.Controls.Add(textBoxEmailCadastro);
            groupBoxCadastro.Controls.Add(label4);
            groupBoxCadastro.Location = new Point(419, 95);
            groupBoxCadastro.Name = "groupBoxCadastro";
            groupBoxCadastro.Size = new Size(318, 325);
            groupBoxCadastro.TabIndex = 2;
            groupBoxCadastro.TabStop = false;
            groupBoxCadastro.Text = "Fazer cadastro";
            // 
            // labelMensagemCadastro
            // 
            labelMensagemCadastro.ForeColor = Color.IndianRed;
            labelMensagemCadastro.Location = new Point(6, 193);
            labelMensagemCadastro.Name = "labelMensagemCadastro";
            labelMensagemCadastro.Size = new Size(306, 70);
            labelMensagemCadastro.TabIndex = 10;
            labelMensagemCadastro.Text = "Erro";
            labelMensagemCadastro.Visible = false;
            // 
            // buttonCadastrar
            // 
            buttonCadastrar.Location = new Point(112, 266);
            buttonCadastrar.Name = "buttonCadastrar";
            buttonCadastrar.Size = new Size(94, 29);
            buttonCadastrar.TabIndex = 9;
            buttonCadastrar.Text = "Cadastrar";
            buttonCadastrar.UseVisualStyleBackColor = true;
            // 
            // textBoxSenhaCadastro
            // 
            textBoxSenhaCadastro.Location = new Point(6, 145);
            textBoxSenhaCadastro.Name = "textBoxSenhaCadastro";
            textBoxSenhaCadastro.PasswordChar = '*';
            textBoxSenhaCadastro.Size = new Size(269, 27);
            textBoxSenhaCadastro.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 113);
            label3.Name = "label3";
            label3.Size = new Size(115, 20);
            label3.TabIndex = 7;
            label3.Text = "Insira sua senha:";
            // 
            // textBoxEmailCadastro
            // 
            textBoxEmailCadastro.Location = new Point(6, 76);
            textBoxEmailCadastro.Name = "textBoxEmailCadastro";
            textBoxEmailCadastro.Size = new Size(306, 27);
            textBoxEmailCadastro.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 44);
            label4.Name = "label4";
            label4.Size = new Size(114, 20);
            label4.TabIndex = 5;
            label4.Text = "Insira seu email:";
            // 
            // buttonExibirSenhaLogin
            // 
            buttonExibirSenhaLogin.Location = new Point(277, 145);
            buttonExibirSenhaLogin.Name = "buttonExibirSenhaLogin";
            buttonExibirSenhaLogin.Size = new Size(35, 27);
            buttonExibirSenhaLogin.TabIndex = 6;
            buttonExibirSenhaLogin.UseVisualStyleBackColor = true;
            // 
            // buttonExibirSenhaCadastro
            // 
            buttonExibirSenhaCadastro.Location = new Point(277, 145);
            buttonExibirSenhaCadastro.Name = "buttonExibirSenhaCadastro";
            buttonExibirSenhaCadastro.Size = new Size(35, 27);
            buttonExibirSenhaCadastro.TabIndex = 11;
            buttonExibirSenhaCadastro.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 487);
            Controls.Add(groupBoxCadastro);
            Controls.Add(groupBoxLogin);
            Controls.Add(labelLogin);
            MaximumSize = new Size(818, 534);
            MinimumSize = new Size(818, 534);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            groupBoxLogin.ResumeLayout(false);
            groupBoxLogin.PerformLayout();
            groupBoxCadastro.ResumeLayout(false);
            groupBoxCadastro.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelLogin;
        private GroupBox groupBoxLogin;
        private Label label1;
        private GroupBox groupBoxCadastro;
        private Button buttonLogin;
        private TextBox textBoxSenhaLogin;
        private Label label2;
        private TextBox textBoxEmailLogin;
        private Button buttonCadastrar;
        private TextBox textBoxSenhaCadastro;
        private Label label3;
        private TextBox textBoxEmailCadastro;
        private Label label4;
        private Label labelMensagemLogin;
        private Label labelMensagemCadastro;
        private Button buttonExibirSenhaLogin;
        private Button buttonExibirSenhaCadastro;
    }
}
