namespace SisFarma.view
{
    partial class MostrarProdutoView
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
            this.descricaoLabelText = new System.Windows.Forms.Label();
            this.precoValorLabelText = new System.Windows.Forms.Label();
            this.descricaoValorLabelText = new System.Windows.Forms.Label();
            this.precoLabelText = new System.Windows.Forms.Label();
            this.voltarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // descricaoLabelText
            // 
            this.descricaoLabelText.AutoSize = true;
            this.descricaoLabelText.Location = new System.Drawing.Point(202, 79);
            this.descricaoLabelText.Name = "descricaoLabelText";
            this.descricaoLabelText.Size = new System.Drawing.Size(64, 13);
            this.descricaoLabelText.TabIndex = 0;
            this.descricaoLabelText.Text = "Descrição : ";
            // 
            // precoValorLabelText
            // 
            this.precoValorLabelText.AutoSize = true;
            this.precoValorLabelText.Location = new System.Drawing.Point(323, 134);
            this.precoValorLabelText.Name = "precoValorLabelText";
            this.precoValorLabelText.Size = new System.Drawing.Size(35, 13);
            this.precoValorLabelText.TabIndex = 1;
            this.precoValorLabelText.Text = "label2";
            // 
            // descricaoValorLabelText
            // 
            this.descricaoValorLabelText.AutoSize = true;
            this.descricaoValorLabelText.Location = new System.Drawing.Point(323, 79);
            this.descricaoValorLabelText.Name = "descricaoValorLabelText";
            this.descricaoValorLabelText.Size = new System.Drawing.Size(35, 13);
            this.descricaoValorLabelText.TabIndex = 2;
            this.descricaoValorLabelText.Text = "label1";
            // 
            // precoLabelText
            // 
            this.precoLabelText.AutoSize = true;
            this.precoLabelText.Location = new System.Drawing.Point(226, 134);
            this.precoLabelText.Name = "precoLabelText";
            this.precoLabelText.Size = new System.Drawing.Size(47, 13);
            this.precoLabelText.TabIndex = 3;
            this.precoLabelText.Text = "Preço  : ";
            // 
            // voltarButton
            // 
            this.voltarButton.Location = new System.Drawing.Point(205, 211);
            this.voltarButton.Name = "voltarButton";
            this.voltarButton.Size = new System.Drawing.Size(153, 23);
            this.voltarButton.TabIndex = 4;
            this.voltarButton.Text = "Voltar";
            this.voltarButton.UseVisualStyleBackColor = true;
            this.voltarButton.Click += new System.EventHandler(this.voltarButton_Click);
            // 
            // MostrarProdutoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 360);
            this.Controls.Add(this.voltarButton);
            this.Controls.Add(this.precoLabelText);
            this.Controls.Add(this.descricaoValorLabelText);
            this.Controls.Add(this.precoValorLabelText);
            this.Controls.Add(this.descricaoLabelText);
            this.Name = "MostrarProdutoView";
            this.Text = "MostrarProdutoView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label descricaoLabelText;
        private System.Windows.Forms.Label precoValorLabelText;
        private System.Windows.Forms.Label descricaoValorLabelText;
        private System.Windows.Forms.Label precoLabelText;
        private System.Windows.Forms.Button voltarButton;
    }
}