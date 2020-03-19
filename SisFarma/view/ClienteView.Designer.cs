namespace SisFarma.view
{
    partial class ClienteView
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
            this.adicionarClienteButton = new System.Windows.Forms.Button();
            this.rgTextBox = new System.Windows.Forms.TextBox();
            this.sexoTextBox = new System.Windows.Forms.TextBox();
            this.telefoneTextBox = new System.Windows.Forms.TextBox();
            this.cepTextBox = new System.Windows.Forms.TextBox();
            this.cidadeTextBox = new System.Windows.Forms.TextBox();
            this.logradouroTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.cpfTextBox = new System.Windows.Forms.TextBox();
            this.nomeLabelText = new System.Windows.Forms.Label();
            this.cpfLabelText = new System.Windows.Forms.Label();
            this.rgLabelText = new System.Windows.Forms.Label();
            this.sexoLabelText = new System.Windows.Forms.Label();
            this.telefoneLabelText = new System.Windows.Forms.Label();
            this.cepLabelText = new System.Windows.Forms.Label();
            this.cidadeLabelText = new System.Windows.Forms.Label();
            this.logradouroLabelText = new System.Windows.Forms.Label();
            this.recuperarClienteButton = new System.Windows.Forms.Button();
            this.apagarClienteButton = new System.Windows.Forms.Button();
            this.alterarClienteButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // adicionarClienteButton
            // 
            this.adicionarClienteButton.Location = new System.Drawing.Point(335, 332);
            this.adicionarClienteButton.Name = "adicionarClienteButton";
            this.adicionarClienteButton.Size = new System.Drawing.Size(75, 23);
            this.adicionarClienteButton.TabIndex = 0;
            this.adicionarClienteButton.Text = "Adicionar";
            this.adicionarClienteButton.UseVisualStyleBackColor = true;
            this.adicionarClienteButton.Click += new System.EventHandler(this.adicionarClienteButton_Click);
            // 
            // rgTextBox
            // 
            this.rgTextBox.Location = new System.Drawing.Point(386, 160);
            this.rgTextBox.Name = "rgTextBox";
            this.rgTextBox.Size = new System.Drawing.Size(100, 20);
            this.rgTextBox.TabIndex = 1;
            // 
            // sexoTextBox
            // 
            this.sexoTextBox.Location = new System.Drawing.Point(386, 186);
            this.sexoTextBox.Name = "sexoTextBox";
            this.sexoTextBox.Size = new System.Drawing.Size(100, 20);
            this.sexoTextBox.TabIndex = 2;
            // 
            // telefoneTextBox
            // 
            this.telefoneTextBox.Location = new System.Drawing.Point(386, 212);
            this.telefoneTextBox.Name = "telefoneTextBox";
            this.telefoneTextBox.Size = new System.Drawing.Size(100, 20);
            this.telefoneTextBox.TabIndex = 3;
            // 
            // cepTextBox
            // 
            this.cepTextBox.Location = new System.Drawing.Point(386, 238);
            this.cepTextBox.Name = "cepTextBox";
            this.cepTextBox.Size = new System.Drawing.Size(100, 20);
            this.cepTextBox.TabIndex = 4;
            // 
            // cidadeTextBox
            // 
            this.cidadeTextBox.Location = new System.Drawing.Point(386, 264);
            this.cidadeTextBox.Name = "cidadeTextBox";
            this.cidadeTextBox.Size = new System.Drawing.Size(100, 20);
            this.cidadeTextBox.TabIndex = 5;
            // 
            // logradouroTextBox
            // 
            this.logradouroTextBox.Location = new System.Drawing.Point(386, 290);
            this.logradouroTextBox.Name = "logradouroTextBox";
            this.logradouroTextBox.Size = new System.Drawing.Size(100, 20);
            this.logradouroTextBox.TabIndex = 6;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.Location = new System.Drawing.Point(386, 108);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(100, 20);
            this.nomeTextBox.TabIndex = 7;
            // 
            // cpfTextBox
            // 
            this.cpfTextBox.Location = new System.Drawing.Point(386, 134);
            this.cpfTextBox.Name = "cpfTextBox";
            this.cpfTextBox.Size = new System.Drawing.Size(100, 20);
            this.cpfTextBox.TabIndex = 8;
            // 
            // nomeLabelText
            // 
            this.nomeLabelText.AutoSize = true;
            this.nomeLabelText.Location = new System.Drawing.Point(328, 108);
            this.nomeLabelText.Name = "nomeLabelText";
            this.nomeLabelText.Size = new System.Drawing.Size(41, 13);
            this.nomeLabelText.TabIndex = 9;
            this.nomeLabelText.Text = "Nome :";
            // 
            // cpfLabelText
            // 
            this.cpfLabelText.AutoSize = true;
            this.cpfLabelText.Location = new System.Drawing.Point(333, 134);
            this.cpfLabelText.Name = "cpfLabelText";
            this.cpfLabelText.Size = new System.Drawing.Size(36, 13);
            this.cpfLabelText.TabIndex = 10;
            this.cpfLabelText.Text = "CPF : ";
            // 
            // rgLabelText
            // 
            this.rgLabelText.AutoSize = true;
            this.rgLabelText.Location = new System.Drawing.Point(337, 160);
            this.rgLabelText.Name = "rgLabelText";
            this.rgLabelText.Size = new System.Drawing.Size(32, 13);
            this.rgLabelText.TabIndex = 11;
            this.rgLabelText.Text = "RG : ";
            // 
            // sexoLabelText
            // 
            this.sexoLabelText.AutoSize = true;
            this.sexoLabelText.Location = new System.Drawing.Point(331, 186);
            this.sexoLabelText.Name = "sexoLabelText";
            this.sexoLabelText.Size = new System.Drawing.Size(40, 13);
            this.sexoLabelText.TabIndex = 12;
            this.sexoLabelText.Text = "Sexo : ";
            // 
            // telefoneLabelText
            // 
            this.telefoneLabelText.AutoSize = true;
            this.telefoneLabelText.Location = new System.Drawing.Point(313, 212);
            this.telefoneLabelText.Name = "telefoneLabelText";
            this.telefoneLabelText.Size = new System.Drawing.Size(58, 13);
            this.telefoneLabelText.TabIndex = 13;
            this.telefoneLabelText.Text = "Telefone : ";
            // 
            // cepLabelText
            // 
            this.cepLabelText.AutoSize = true;
            this.cepLabelText.Location = new System.Drawing.Point(332, 238);
            this.cepLabelText.Name = "cepLabelText";
            this.cepLabelText.Size = new System.Drawing.Size(37, 13);
            this.cepLabelText.TabIndex = 14;
            this.cepLabelText.Text = "CEP : ";
            // 
            // cidadeLabelText
            // 
            this.cidadeLabelText.AutoSize = true;
            this.cidadeLabelText.Location = new System.Drawing.Point(322, 264);
            this.cidadeLabelText.Name = "cidadeLabelText";
            this.cidadeLabelText.Size = new System.Drawing.Size(49, 13);
            this.cidadeLabelText.TabIndex = 15;
            this.cidadeLabelText.Text = "Cidade : ";
            // 
            // logradouroLabelText
            // 
            this.logradouroLabelText.AutoSize = true;
            this.logradouroLabelText.Location = new System.Drawing.Point(299, 290);
            this.logradouroLabelText.Name = "logradouroLabelText";
            this.logradouroLabelText.Size = new System.Drawing.Size(70, 13);
            this.logradouroLabelText.TabIndex = 16;
            this.logradouroLabelText.Text = "Logradouro : ";
            // 
            // recuperarClienteButton
            // 
            this.recuperarClienteButton.Location = new System.Drawing.Point(457, 332);
            this.recuperarClienteButton.Name = "recuperarClienteButton";
            this.recuperarClienteButton.Size = new System.Drawing.Size(75, 23);
            this.recuperarClienteButton.TabIndex = 17;
            this.recuperarClienteButton.Text = "Recuperar";
            this.recuperarClienteButton.UseVisualStyleBackColor = true;
            this.recuperarClienteButton.Click += new System.EventHandler(this.recuperarClienteButton_Click);
            // 
            // apagarClienteButton
            // 
            this.apagarClienteButton.Location = new System.Drawing.Point(457, 377);
            this.apagarClienteButton.Name = "apagarClienteButton";
            this.apagarClienteButton.Size = new System.Drawing.Size(75, 23);
            this.apagarClienteButton.TabIndex = 18;
            this.apagarClienteButton.Text = "Apagar";
            this.apagarClienteButton.UseVisualStyleBackColor = true;
            this.apagarClienteButton.Click += new System.EventHandler(this.apagarClienteButton_Click);
            // 
            // alterarClienteButton
            // 
            this.alterarClienteButton.Location = new System.Drawing.Point(331, 377);
            this.alterarClienteButton.Name = "alterarClienteButton";
            this.alterarClienteButton.Size = new System.Drawing.Size(75, 23);
            this.alterarClienteButton.TabIndex = 19;
            this.alterarClienteButton.Text = "Alterar";
            this.alterarClienteButton.UseVisualStyleBackColor = true;
            this.alterarClienteButton.Click += new System.EventHandler(this.alterarClienteButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(401, 406);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ClienteView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.alterarClienteButton);
            this.Controls.Add(this.apagarClienteButton);
            this.Controls.Add(this.recuperarClienteButton);
            this.Controls.Add(this.logradouroLabelText);
            this.Controls.Add(this.cidadeLabelText);
            this.Controls.Add(this.cepLabelText);
            this.Controls.Add(this.telefoneLabelText);
            this.Controls.Add(this.sexoLabelText);
            this.Controls.Add(this.rgLabelText);
            this.Controls.Add(this.cpfLabelText);
            this.Controls.Add(this.nomeLabelText);
            this.Controls.Add(this.cpfTextBox);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(this.logradouroTextBox);
            this.Controls.Add(this.cidadeTextBox);
            this.Controls.Add(this.cepTextBox);
            this.Controls.Add(this.telefoneTextBox);
            this.Controls.Add(this.sexoTextBox);
            this.Controls.Add(this.rgTextBox);
            this.Controls.Add(this.adicionarClienteButton);
            this.Name = "ClienteView";
            this.Text = "ClienteView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button adicionarClienteButton;
        private System.Windows.Forms.TextBox rgTextBox;
        private System.Windows.Forms.TextBox sexoTextBox;
        private System.Windows.Forms.TextBox telefoneTextBox;
        private System.Windows.Forms.TextBox cepTextBox;
        private System.Windows.Forms.TextBox cidadeTextBox;
        private System.Windows.Forms.TextBox logradouroTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox cpfTextBox;
        private System.Windows.Forms.Label nomeLabelText;
        private System.Windows.Forms.Label cpfLabelText;
        private System.Windows.Forms.Label rgLabelText;
        private System.Windows.Forms.Label sexoLabelText;
        private System.Windows.Forms.Label telefoneLabelText;
        private System.Windows.Forms.Label cepLabelText;
        private System.Windows.Forms.Label cidadeLabelText;
        private System.Windows.Forms.Label logradouroLabelText;
        private System.Windows.Forms.Button recuperarClienteButton;
        private System.Windows.Forms.Button apagarClienteButton;
        private System.Windows.Forms.Button alterarClienteButton;
        private System.Windows.Forms.Button button1;
    }
}