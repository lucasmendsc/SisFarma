namespace SisFarma.view
{
    partial class AlterarUsuarioView
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
            this.voltarButton = new System.Windows.Forms.Button();
            this.alterarButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.senhaLabelText = new System.Windows.Forms.Label();
            this.loginLabelText = new System.Windows.Forms.Label();
            this.nomeLabelText = new System.Windows.Forms.Label();
            this.confirmacaoSenhaTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.senhaTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // voltarButton
            // 
            this.voltarButton.Location = new System.Drawing.Point(418, 245);
            this.voltarButton.Name = "voltarButton";
            this.voltarButton.Size = new System.Drawing.Size(75, 23);
            this.voltarButton.TabIndex = 14;
            this.voltarButton.Text = "Voltar";
            this.voltarButton.UseVisualStyleBackColor = true;
            this.voltarButton.Click += new System.EventHandler(this.voltarButton_Click);
            // 
            // alterarButton
            // 
            this.alterarButton.Location = new System.Drawing.Point(298, 245);
            this.alterarButton.Name = "alterarButton";
            this.alterarButton.Size = new System.Drawing.Size(75, 23);
            this.alterarButton.TabIndex = 12;
            this.alterarButton.Text = "Alterar";
            this.alterarButton.UseVisualStyleBackColor = true;
            this.alterarButton.Click += new System.EventHandler(this.alterarButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(215, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Confirmação de senha : ";
            // 
            // senhaLabelText
            // 
            this.senhaLabelText.AutoSize = true;
            this.senhaLabelText.Location = new System.Drawing.Point(290, 159);
            this.senhaLabelText.Name = "senhaLabelText";
            this.senhaLabelText.Size = new System.Drawing.Size(47, 13);
            this.senhaLabelText.TabIndex = 16;
            this.senhaLabelText.Text = "Senha : ";
            // 
            // loginLabelText
            // 
            this.loginLabelText.AutoSize = true;
            this.loginLabelText.Location = new System.Drawing.Point(295, 133);
            this.loginLabelText.Name = "loginLabelText";
            this.loginLabelText.Size = new System.Drawing.Size(42, 13);
            this.loginLabelText.TabIndex = 15;
            this.loginLabelText.Text = "Login : ";
            // 
            // nomeLabelText
            // 
            this.nomeLabelText.AutoSize = true;
            this.nomeLabelText.Location = new System.Drawing.Point(293, 107);
            this.nomeLabelText.Name = "nomeLabelText";
            this.nomeLabelText.Size = new System.Drawing.Size(44, 13);
            this.nomeLabelText.TabIndex = 13;
            this.nomeLabelText.Text = "Nome : ";
            // 
            // confirmacaoSenhaTextBox
            // 
            this.confirmacaoSenhaTextBox.Location = new System.Drawing.Point(343, 178);
            this.confirmacaoSenhaTextBox.Name = "confirmacaoSenhaTextBox";
            this.confirmacaoSenhaTextBox.Size = new System.Drawing.Size(100, 20);
            this.confirmacaoSenhaTextBox.TabIndex = 11;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.Location = new System.Drawing.Point(343, 100);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(100, 20);
            this.nomeTextBox.TabIndex = 8;
            // 
            // loginTextBox
            // 
            this.loginTextBox.Location = new System.Drawing.Point(343, 126);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(100, 20);
            this.loginTextBox.TabIndex = 9;
            // 
            // senhaTextBox
            // 
            this.senhaTextBox.Location = new System.Drawing.Point(343, 152);
            this.senhaTextBox.Name = "senhaTextBox";
            this.senhaTextBox.Size = new System.Drawing.Size(100, 20);
            this.senhaTextBox.TabIndex = 10;
            // 
            // AlterarUsuarioView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.voltarButton);
            this.Controls.Add(this.alterarButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.senhaLabelText);
            this.Controls.Add(this.loginLabelText);
            this.Controls.Add(this.nomeLabelText);
            this.Controls.Add(this.confirmacaoSenhaTextBox);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.senhaTextBox);
            this.Name = "AlterarUsuarioView";
            this.Text = "AlterarUsuarioView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button voltarButton;
        private System.Windows.Forms.Button alterarButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label senhaLabelText;
        private System.Windows.Forms.Label loginLabelText;
        private System.Windows.Forms.Label nomeLabelText;
        private System.Windows.Forms.TextBox confirmacaoSenhaTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TextBox senhaTextBox;
    }
}