namespace SisFarma.view
{
    partial class AlterarProdutoView
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
            this.descLabelText = new System.Windows.Forms.Label();
            this.valorLabelText = new System.Windows.Forms.Label();
            this.descricaoTextBox = new System.Windows.Forms.TextBox();
            this.precoTextBox = new System.Windows.Forms.TextBox();
            this.alterarButton = new System.Windows.Forms.Button();
            this.voltarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // descLabelText
            // 
            this.descLabelText.AutoSize = true;
            this.descLabelText.Location = new System.Drawing.Point(242, 79);
            this.descLabelText.Name = "descLabelText";
            this.descLabelText.Size = new System.Drawing.Size(64, 13);
            this.descLabelText.TabIndex = 0;
            this.descLabelText.Text = "Descrição : ";
            // 
            // valorLabelText
            // 
            this.valorLabelText.AutoSize = true;
            this.valorLabelText.Location = new System.Drawing.Point(242, 165);
            this.valorLabelText.Name = "valorLabelText";
            this.valorLabelText.Size = new System.Drawing.Size(40, 13);
            this.valorLabelText.TabIndex = 1;
            this.valorLabelText.Text = "Valor : ";
            // 
            // descricaoTextBox
            // 
            this.descricaoTextBox.Location = new System.Drawing.Point(321, 72);
            this.descricaoTextBox.Name = "descricaoTextBox";
            this.descricaoTextBox.Size = new System.Drawing.Size(100, 20);
            this.descricaoTextBox.TabIndex = 0;
            // 
            // precoTextBox
            // 
            this.precoTextBox.Location = new System.Drawing.Point(321, 158);
            this.precoTextBox.Name = "precoTextBox";
            this.precoTextBox.Size = new System.Drawing.Size(100, 20);
            this.precoTextBox.TabIndex = 1;
            // 
            // alterarButton
            // 
            this.alterarButton.Location = new System.Drawing.Point(245, 213);
            this.alterarButton.Name = "alterarButton";
            this.alterarButton.Size = new System.Drawing.Size(75, 23);
            this.alterarButton.TabIndex = 2;
            this.alterarButton.Text = "Alterar";
            this.alterarButton.UseVisualStyleBackColor = true;
            this.alterarButton.Click += new System.EventHandler(this.alterarButton_Click);
            // 
            // voltarButton
            // 
            this.voltarButton.Location = new System.Drawing.Point(377, 213);
            this.voltarButton.Name = "voltarButton";
            this.voltarButton.Size = new System.Drawing.Size(75, 23);
            this.voltarButton.TabIndex = 3;
            this.voltarButton.Text = "Voltar";
            this.voltarButton.UseVisualStyleBackColor = true;
            this.voltarButton.Click += new System.EventHandler(this.voltarButton_Click);
            // 
            // AlterarProdutoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.voltarButton);
            this.Controls.Add(this.alterarButton);
            this.Controls.Add(this.precoTextBox);
            this.Controls.Add(this.descricaoTextBox);
            this.Controls.Add(this.valorLabelText);
            this.Controls.Add(this.descLabelText);
            this.Name = "AlterarProdutoView";
            this.Text = "AlterarProdutoView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label descLabelText;
        private System.Windows.Forms.Label valorLabelText;
        private System.Windows.Forms.TextBox descricaoTextBox;
        private System.Windows.Forms.TextBox precoTextBox;
        private System.Windows.Forms.Button alterarButton;
        private System.Windows.Forms.Button voltarButton;
    }
}