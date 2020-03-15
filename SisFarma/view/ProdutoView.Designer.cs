namespace SisFarma.view
{
    partial class ProdutoView
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
            this.adicionarProdutoButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.precoLabel = new System.Windows.Forms.Label();
            this.descricaoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // adicionarProdutoButton
            // 
            this.adicionarProdutoButton.Location = new System.Drawing.Point(308, 269);
            this.adicionarProdutoButton.Name = "adicionarProdutoButton";
            this.adicionarProdutoButton.Size = new System.Drawing.Size(75, 23);
            this.adicionarProdutoButton.TabIndex = 0;
            this.adicionarProdutoButton.Text = "Adicionar";
            this.adicionarProdutoButton.UseVisualStyleBackColor = true;
            this.adicionarProdutoButton.Click += new System.EventHandler(this.adicionarProdutoButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(352, 108);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(352, 178);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            // 
            // precoLabel
            // 
            this.precoLabel.AutoSize = true;
            this.precoLabel.Location = new System.Drawing.Point(285, 181);
            this.precoLabel.Name = "precoLabel";
            this.precoLabel.Size = new System.Drawing.Size(41, 13);
            this.precoLabel.TabIndex = 3;
            this.precoLabel.Text = "Preço :";
            this.precoLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // descricaoLabel
            // 
            this.descricaoLabel.AutoSize = true;
            this.descricaoLabel.Location = new System.Drawing.Point(282, 111);
            this.descricaoLabel.Name = "descricaoLabel";
            this.descricaoLabel.Size = new System.Drawing.Size(64, 13);
            this.descricaoLabel.TabIndex = 4;
            this.descricaoLabel.Text = "Descrição : ";
            this.descricaoLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // ProdutoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.descricaoLabel);
            this.Controls.Add(this.precoLabel);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.adicionarProdutoButton);
            this.Name = "ProdutoView";
            this.Text = "ProdutoView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button adicionarProdutoButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label precoLabel;
        private System.Windows.Forms.Label descricaoLabel;
    }
}