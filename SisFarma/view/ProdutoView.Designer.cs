﻿namespace SisFarma.view
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
            this.descricaoTextBox = new System.Windows.Forms.TextBox();
            this.descricaoLabel = new System.Windows.Forms.Label();
            this.precoLabel = new System.Windows.Forms.Label();
            this.precoTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            this.recuperarPorDescButton.Location = new System.Drawing.Point(12, 192);
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
            // descricaoTextBox
            // 
            this.descricaoTextBox.Location = new System.Drawing.Point(79, 26);
            this.descricaoTextBox.Name = "descricaoTextBox";
            this.descricaoTextBox.Size = new System.Drawing.Size(100, 20);
            this.descricaoTextBox.TabIndex = 0;
            // 
            // descricaoLabel
            // 
            this.descricaoLabel.AutoSize = true;
            this.descricaoLabel.Location = new System.Drawing.Point(12, 26);
            this.descricaoLabel.Name = "descricaoLabel";
            this.descricaoLabel.Size = new System.Drawing.Size(64, 13);
            this.descricaoLabel.TabIndex = 4;
            this.descricaoLabel.Text = "Descrição : ";
            // 
            // precoLabel
            // 
            this.precoLabel.AutoSize = true;
            this.precoLabel.Location = new System.Drawing.Point(35, 52);
            this.precoLabel.Name = "precoLabel";
            this.precoLabel.Size = new System.Drawing.Size(41, 13);
            this.precoLabel.TabIndex = 3;
            this.precoLabel.Text = "Preço :";
            // 
            // precoTextBox
            // 
            this.precoTextBox.Location = new System.Drawing.Point(79, 52);
            this.precoTextBox.Name = "precoTextBox";
            this.precoTextBox.Size = new System.Drawing.Size(100, 20);
            this.precoTextBox.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(229, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(559, 426);
            this.dataGridView1.TabIndex = 8;
            // 
            // ProdutoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.recuperarPorDescButton);
            this.Controls.Add(this.deletarProdutoButton);
            this.Controls.Add(this.alterarProdutoButton);
            this.Controls.Add(this.recuperarProdutoButton);
            this.Controls.Add(this.descricaoLabel);
            this.Controls.Add(this.precoLabel);
            this.Controls.Add(this.precoTextBox);
            this.Controls.Add(this.descricaoTextBox);
            this.Controls.Add(this.adicionarProdutoButton);
            this.Name = "ProdutoView";
            this.Text = "ProdutoView";
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
        private System.Windows.Forms.TextBox descricaoTextBox;
        private System.Windows.Forms.Label descricaoLabel;
        private System.Windows.Forms.Label precoLabel;
        private System.Windows.Forms.TextBox precoTextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}