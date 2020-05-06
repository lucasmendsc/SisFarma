namespace SisFarma.view.ProdutoView
{
    partial class VisualizarProdutoView1
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
            this.precoLabelText = new System.Windows.Forms.Label();
            this.precoValorText = new System.Windows.Forms.Label();
            this.descValorText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // descricaoLabelText
            // 
            this.descricaoLabelText.AutoSize = true;
            this.descricaoLabelText.Location = new System.Drawing.Point(112, 41);
            this.descricaoLabelText.Name = "descricaoLabelText";
            this.descricaoLabelText.Size = new System.Drawing.Size(64, 13);
            this.descricaoLabelText.TabIndex = 0;
            this.descricaoLabelText.Text = "Descrição : ";
            // 
            // precoLabelText
            // 
            this.precoLabelText.AutoSize = true;
            this.precoLabelText.Location = new System.Drawing.Point(112, 126);
            this.precoLabelText.Name = "precoLabelText";
            this.precoLabelText.Size = new System.Drawing.Size(44, 13);
            this.precoLabelText.TabIndex = 1;
            this.precoLabelText.Text = "Preço : ";
            // 
            // precoValorText
            // 
            this.precoValorText.AutoSize = true;
            this.precoValorText.Location = new System.Drawing.Point(234, 126);
            this.precoValorText.Name = "precoValorText";
            this.precoValorText.Size = new System.Drawing.Size(35, 13);
            this.precoValorText.TabIndex = 2;
            this.precoValorText.Text = "label3";
            // 
            // descValorText
            // 
            this.descValorText.AutoSize = true;
            this.descValorText.Location = new System.Drawing.Point(234, 41);
            this.descValorText.Name = "descValorText";
            this.descValorText.Size = new System.Drawing.Size(35, 13);
            this.descValorText.TabIndex = 3;
            this.descValorText.Text = "label4";
            // 
            // VisualizarProdutoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 265);
            this.Controls.Add(this.descValorText);
            this.Controls.Add(this.precoValorText);
            this.Controls.Add(this.precoLabelText);
            this.Controls.Add(this.descricaoLabelText);
            this.Name = "VisualizarProdutoView";
            this.Text = "VisualizarProdutoView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label descricaoLabelText;
        private System.Windows.Forms.Label precoLabelText;
        private System.Windows.Forms.Label precoValorText;
        private System.Windows.Forms.Label descValorText;
    }
}