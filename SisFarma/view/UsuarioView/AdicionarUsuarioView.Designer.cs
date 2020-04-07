namespace SisFarma.view.UsuarioView
{
    partial class AdicionarUsuarioView
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
            this.senhaTextBox = new System.Windows.Forms.TextBox();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.confirmacaoSenhaTextBox = new System.Windows.Forms.TextBox();
            this.nomeLabelText = new System.Windows.Forms.Label();
            this.loginLabelText = new System.Windows.Forms.Label();
            this.senhaLabelText = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.adicionarButton = new System.Windows.Forms.Button();
            this.voltarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // senhaTextBox
            // 
            this.senhaTextBox.Location = new System.Drawing.Point(342, 133);
            this.senhaTextBox.Name = "senhaTextBox";
            this.senhaTextBox.Size = new System.Drawing.Size(100, 20);
            this.senhaTextBox.TabIndex = 2;
            // 
            // loginTextBox
            // 
            this.loginTextBox.Location = new System.Drawing.Point(342, 107);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(100, 20);
            this.loginTextBox.TabIndex = 1;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.Location = new System.Drawing.Point(342, 81);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(100, 20);
            this.nomeTextBox.TabIndex = 0;
            // 
            // confirmacaoSenhaTextBox
            // 
            this.confirmacaoSenhaTextBox.Location = new System.Drawing.Point(342, 159);
            this.confirmacaoSenhaTextBox.Name = "confirmacaoSenhaTextBox";
            this.confirmacaoSenhaTextBox.Size = new System.Drawing.Size(100, 20);
            this.confirmacaoSenhaTextBox.TabIndex = 3;
            // 
            // nomeLabelText
            // 
            this.nomeLabelText.AutoSize = true;
            this.nomeLabelText.Location = new System.Drawing.Point(292, 88);
            this.nomeLabelText.Name = "nomeLabelText";
            this.nomeLabelText.Size = new System.Drawing.Size(44, 13);
            this.nomeLabelText.TabIndex = 4;
            this.nomeLabelText.Text = "Nome : ";
            // 
            // loginLabelText
            // 
            this.loginLabelText.AutoSize = true;
            this.loginLabelText.Location = new System.Drawing.Point(294, 114);
            this.loginLabelText.Name = "loginLabelText";
            this.loginLabelText.Size = new System.Drawing.Size(42, 13);
            this.loginLabelText.TabIndex = 5;
            this.loginLabelText.Text = "Login : ";
            // 
            // senhaLabelText
            // 
            this.senhaLabelText.AutoSize = true;
            this.senhaLabelText.Location = new System.Drawing.Point(289, 140);
            this.senhaLabelText.Name = "senhaLabelText";
            this.senhaLabelText.Size = new System.Drawing.Size(47, 13);
            this.senhaLabelText.TabIndex = 6;
            this.senhaLabelText.Text = "Senha : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(214, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Confirmação de senha : ";
            // 
            // adicionarButton
            // 
            this.adicionarButton.Location = new System.Drawing.Point(297, 226);
            this.adicionarButton.Name = "adicionarButton";
            this.adicionarButton.Size = new System.Drawing.Size(75, 23);
            this.adicionarButton.TabIndex = 4;
            this.adicionarButton.Text = "Adicionar";
            this.adicionarButton.UseVisualStyleBackColor = true;
            this.adicionarButton.Click += new System.EventHandler(this.adicionarButton_Click);
            // 
            // voltarButton
            // 
            this.voltarButton.Location = new System.Drawing.Point(417, 226);
            this.voltarButton.Name = "voltarButton";
            this.voltarButton.Size = new System.Drawing.Size(75, 23);
            this.voltarButton.TabIndex = 5;
            this.voltarButton.Text = "Voltar";
            this.voltarButton.UseVisualStyleBackColor = true;
            this.voltarButton.Click += new System.EventHandler(this.voltarButton_Click);
            // 
            // AdicionarUsuarioView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.voltarButton);
            this.Controls.Add(this.adicionarButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.senhaLabelText);
            this.Controls.Add(this.loginLabelText);
            this.Controls.Add(this.nomeLabelText);
            this.Controls.Add(this.confirmacaoSenhaTextBox);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.senhaTextBox);
            this.Name = "AdicionarUsuarioView";
            this.Text = "Adicionar Usuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox senhaTextBox;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox confirmacaoSenhaTextBox;
        private System.Windows.Forms.Label nomeLabelText;
        private System.Windows.Forms.Label loginLabelText;
        private System.Windows.Forms.Label senhaLabelText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button adicionarButton;
        private System.Windows.Forms.Button voltarButton;
    }
}