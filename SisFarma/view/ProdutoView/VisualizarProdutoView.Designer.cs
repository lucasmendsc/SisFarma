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
            this.alterarProdutoButton = new System.Windows.Forms.Button();
            this.deletarProdutoButton = new System.Windows.Forms.Button();
            this.recuperarPorDescButton = new System.Windows.Forms.Button();
            this.recuperarProdutoButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.recuperarPorDescricaoTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // adicionarProdutoButton
            // 
            this.adicionarProdutoButton.Location = new System.Drawing.Point(23, 95);
            this.adicionarProdutoButton.Name = "adicionarProdutoButton";
            this.adicionarProdutoButton.Size = new System.Drawing.Size(75, 23);
            this.adicionarProdutoButton.TabIndex = 2;
            this.adicionarProdutoButton.Text = "Adicionar";
            this.adicionarProdutoButton.UseVisualStyleBackColor = true;
            this.adicionarProdutoButton.Click += new System.EventHandler(this.adicionarProdutoButton_Click);
            // 
            // alterarProdutoButton
            // 
            this.alterarProdutoButton.Location = new System.Drawing.Point(23, 124);
            this.alterarProdutoButton.Name = "alterarProdutoButton";
            this.alterarProdutoButton.Size = new System.Drawing.Size(75, 23);
            this.alterarProdutoButton.TabIndex = 4;
            this.alterarProdutoButton.Text = "Alterar";
            this.alterarProdutoButton.UseVisualStyleBackColor = true;
            this.alterarProdutoButton.Click += new System.EventHandler(this.alterarProdutoButton_Click);
            // 
            // deletarProdutoButton
            // 
            this.deletarProdutoButton.Location = new System.Drawing.Point(104, 124);
            this.deletarProdutoButton.Name = "deletarProdutoButton";
            this.deletarProdutoButton.Size = new System.Drawing.Size(75, 23);
            this.deletarProdutoButton.TabIndex = 5;
            this.deletarProdutoButton.Text = "Deletar";
            this.deletarProdutoButton.UseVisualStyleBackColor = true;
            this.deletarProdutoButton.Click += new System.EventHandler(this.deletarProdutoButton_Click);
            // 
            // recuperarPorDescButton
            // 
            this.recuperarPorDescButton.Location = new System.Drawing.Point(593, 24);
            this.recuperarPorDescButton.Name = "recuperarPorDescButton";
            this.recuperarPorDescButton.Size = new System.Drawing.Size(195, 23);
            this.recuperarPorDescButton.TabIndex = 7;
            this.recuperarPorDescButton.Text = "Recuperar Por Descrição";
            this.recuperarPorDescButton.UseVisualStyleBackColor = true;
            this.recuperarPorDescButton.Click += new System.EventHandler(this.recuperarPorDescButton_Click);
            // 
            // recuperarProdutoButton
            // 
            this.recuperarProdutoButton.Location = new System.Drawing.Point(104, 95);
            this.recuperarProdutoButton.Name = "recuperarProdutoButton";
            this.recuperarProdutoButton.Size = new System.Drawing.Size(75, 23);
            this.recuperarProdutoButton.TabIndex = 3;
            this.recuperarProdutoButton.Text = "Recuperar";
            this.recuperarProdutoButton.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(229, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(559, 386);
            this.dataGridView1.TabIndex = 8;
            // 
            // recuperarPorDescricaoTextBox
            // 
            this.recuperarPorDescricaoTextBox.Location = new System.Drawing.Point(229, 26);
            this.recuperarPorDescricaoTextBox.Name = "recuperarPorDescricaoTextBox";
            this.recuperarPorDescricaoTextBox.Size = new System.Drawing.Size(358, 20);
            this.recuperarPorDescricaoTextBox.TabIndex = 9;
            // 
            // ProdutoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.recuperarPorDescricaoTextBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.recuperarPorDescButton);
            this.Controls.Add(this.deletarProdutoButton);
            this.Controls.Add(this.alterarProdutoButton);
            this.Controls.Add(this.recuperarProdutoButton);
            this.Controls.Add(this.adicionarProdutoButton);
            this.Name = "ProdutoView";
            this.Text = "Visualizar Produtos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button adicionarProdutoButton;
        private System.Windows.Forms.Button alterarProdutoButton;
        private System.Windows.Forms.Button deletarProdutoButton;
        private System.Windows.Forms.Button recuperarPorDescButton;
        private System.Windows.Forms.Button recuperarProdutoButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox recuperarPorDescricaoTextBox;
    }
}