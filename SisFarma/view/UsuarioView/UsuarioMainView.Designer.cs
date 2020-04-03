namespace SisFarma.view
{
    partial class UsuarioVIew
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
            this.adicionarUsuarioButton = new System.Windows.Forms.Button();
            this.deletarButton = new System.Windows.Forms.Button();
            this.recuperarTodosButton = new System.Windows.Forms.Button();
            this.alterarButton = new System.Windows.Forms.Button();
            this.senhaTextBox = new System.Windows.Forms.TextBox();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.confirmacaoSenhaTextBox = new System.Windows.Forms.TextBox();
            this.loginLabel = new System.Windows.Forms.Label();
            this.senhaLabel = new System.Windows.Forms.Label();
            this.confirmacaoSenhaLabel = new System.Windows.Forms.Label();
            this.nomeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // adicionarUsuarioButton
            // 
            this.adicionarUsuarioButton.Location = new System.Drawing.Point(285, 348);
            this.adicionarUsuarioButton.Name = "adicionarUsuarioButton";
            this.adicionarUsuarioButton.Size = new System.Drawing.Size(75, 23);
            this.adicionarUsuarioButton.TabIndex = 4;
            this.adicionarUsuarioButton.Text = "Adicionar";
            this.adicionarUsuarioButton.UseVisualStyleBackColor = true;
            this.adicionarUsuarioButton.Click += new System.EventHandler(this.adicionarUsuarioButton_Click);
            // 
            // deletarButton
            // 
            this.deletarButton.Location = new System.Drawing.Point(447, 348);
            this.deletarButton.Name = "deletarButton";
            this.deletarButton.Size = new System.Drawing.Size(75, 23);
            this.deletarButton.TabIndex = 6;
            this.deletarButton.Text = "Deletar";
            this.deletarButton.UseVisualStyleBackColor = true;
            this.deletarButton.Click += new System.EventHandler(this.deletarButton_Click);
            // 
            // recuperarTodosButton
            // 
            this.recuperarTodosButton.Location = new System.Drawing.Point(285, 377);
            this.recuperarTodosButton.Name = "recuperarTodosButton";
            this.recuperarTodosButton.Size = new System.Drawing.Size(237, 23);
            this.recuperarTodosButton.TabIndex = 7;
            this.recuperarTodosButton.Text = "Recuperar Todos";
            this.recuperarTodosButton.UseVisualStyleBackColor = true;
            this.recuperarTodosButton.Click += new System.EventHandler(this.recuperarTodosButton_Click);
            // 
            // alterarButton
            // 
            this.alterarButton.Location = new System.Drawing.Point(366, 348);
            this.alterarButton.Name = "alterarButton";
            this.alterarButton.Size = new System.Drawing.Size(75, 23);
            this.alterarButton.TabIndex = 5;
            this.alterarButton.Text = "Alterar";
            this.alterarButton.UseVisualStyleBackColor = true;
            this.alterarButton.Click += new System.EventHandler(this.alterarButton_Click);
            // 
            // senhaTextBox
            // 
            this.senhaTextBox.Location = new System.Drawing.Point(341, 173);
            this.senhaTextBox.Name = "senhaTextBox";
            this.senhaTextBox.Size = new System.Drawing.Size(100, 20);
            this.senhaTextBox.TabIndex = 2;
            // 
            // loginTextBox
            // 
            this.loginTextBox.Location = new System.Drawing.Point(341, 147);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(100, 20);
            this.loginTextBox.TabIndex = 1;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.Location = new System.Drawing.Point(341, 121);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(100, 20);
            this.nomeTextBox.TabIndex = 0;
            // 
            // confirmacaoSenhaTextBox
            // 
            this.confirmacaoSenhaTextBox.Location = new System.Drawing.Point(341, 199);
            this.confirmacaoSenhaTextBox.Name = "confirmacaoSenhaTextBox";
            this.confirmacaoSenhaTextBox.Size = new System.Drawing.Size(100, 20);
            this.confirmacaoSenhaTextBox.TabIndex = 3;
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Location = new System.Drawing.Point(293, 154);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(42, 13);
            this.loginLabel.TabIndex = 8;
            this.loginLabel.Text = "Login : ";
            // 
            // senhaLabel
            // 
            this.senhaLabel.AutoSize = true;
            this.senhaLabel.Location = new System.Drawing.Point(288, 180);
            this.senhaLabel.Name = "senhaLabel";
            this.senhaLabel.Size = new System.Drawing.Size(47, 13);
            this.senhaLabel.TabIndex = 9;
            this.senhaLabel.Text = "Senha : ";
            // 
            // confirmacaoSenhaLabel
            // 
            this.confirmacaoSenhaLabel.AutoSize = true;
            this.confirmacaoSenhaLabel.Location = new System.Drawing.Point(213, 206);
            this.confirmacaoSenhaLabel.Name = "confirmacaoSenhaLabel";
            this.confirmacaoSenhaLabel.Size = new System.Drawing.Size(122, 13);
            this.confirmacaoSenhaLabel.TabIndex = 10;
            this.confirmacaoSenhaLabel.Text = "Confirmação de senha : ";
            // 
            // nomeLabel
            // 
            this.nomeLabel.AutoSize = true;
            this.nomeLabel.Location = new System.Drawing.Point(291, 128);
            this.nomeLabel.Name = "nomeLabel";
            this.nomeLabel.Size = new System.Drawing.Size(44, 13);
            this.nomeLabel.TabIndex = 11;
            this.nomeLabel.Text = "Nome : ";
            // 
            // UsuarioVIew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nomeLabel);
            this.Controls.Add(this.confirmacaoSenhaLabel);
            this.Controls.Add(this.senhaLabel);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.confirmacaoSenhaTextBox);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.senhaTextBox);
            this.Controls.Add(this.alterarButton);
            this.Controls.Add(this.recuperarTodosButton);
            this.Controls.Add(this.deletarButton);
            this.Controls.Add(this.adicionarUsuarioButton);
            this.Name = "UsuarioVIew";
            this.Text = "UsuarioVIew";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button adicionarUsuarioButton;
        private System.Windows.Forms.Button deletarButton;
        private System.Windows.Forms.Button recuperarTodosButton;
        private System.Windows.Forms.Button alterarButton;
        private System.Windows.Forms.TextBox senhaTextBox;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox confirmacaoSenhaTextBox;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label senhaLabel;
        private System.Windows.Forms.Label confirmacaoSenhaLabel;
        private System.Windows.Forms.Label nomeLabel;
    }
}