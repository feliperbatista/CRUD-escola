namespace CRUD_escola
{
    partial class ConfirmaCadastro
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pictureBoxConfirmar = new PictureBox();
            textBoxCodigo = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxConfirmar).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.traco;
            pictureBox1.Location = new Point(180, 160);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(61, 17);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Font = new Font("Calibri", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(13, 202, 122);
            label1.Location = new Point(45, 24);
            label1.Name = "label1";
            label1.Size = new Size(331, 133);
            label1.TabIndex = 27;
            label1.Text = "Preenhca o código de confirmação enviado em seu e-mail.";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBoxConfirmar
            // 
            pictureBoxConfirmar.BackColor = Color.Transparent;
            pictureBoxConfirmar.Image = Properties.Resources.button_cadastrar_colorido;
            pictureBoxConfirmar.Location = new Point(120, 286);
            pictureBoxConfirmar.Name = "pictureBoxConfirmar";
            pictureBoxConfirmar.Size = new Size(183, 52);
            pictureBoxConfirmar.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBoxConfirmar.TabIndex = 26;
            pictureBoxConfirmar.TabStop = false;
            // 
            // textBoxCodigo
            // 
            textBoxCodigo.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxCodigo.Location = new Point(148, 215);
            textBoxCodigo.Name = "textBoxCodigo";
            textBoxCodigo.Size = new Size(125, 32);
            textBoxCodigo.TabIndex = 29;
            // 
            // ConfirmaCadastro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(420, 362);
            Controls.Add(textBoxCodigo);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(pictureBoxConfirmar);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "ConfirmaCadastro";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxConfirmar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBoxConfirmar;
        private TextBox textBoxCodigo;
    }
}