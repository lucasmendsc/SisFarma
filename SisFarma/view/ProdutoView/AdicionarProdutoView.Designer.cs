﻿namespace SisFarma.view
{
    partial class AdicionarProdutoView
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
            this.adicionarButton = new System.Windows.Forms.Button();
            this.voltarButton = new System.Windows.Forms.Button();
            this.descricaoTextBox = new System.Windows.Forms.TextBox();
            this.valorTextBox = new System.Windows.Forms.TextBox();
            this.valorLabelText = new System.Windows.Forms.Label();
            this.descricaoLabelText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // adicionarButton
            // 
            this.adicionarButton.Location = new System.Drawing.Point(285, 232);
            this.adicionarButton.Name = "adicionarButton";
            this.adicionarButton.Size = new System.Drawing.Size(75, 23);
            this.adicionarButton.TabIndex = 0;
            this.adicionarButton.Text = "Adicionar";
            this.adicionarButton.UseVisualStyleBackColor = true;
            this.adicionarButton.Click += new System.EventHandler(this.adicionarButton_Click);
            // 
            // voltarButton
            // 
            this.voltarButton.Location = new System.Drawing.Point(396, 232);
            this.voltarButton.Name = "voltarButton";
            this.voltarButton.Size = new System.Drawing.Size(75, 23);
            this.voltarButton.TabIndex = 1;
            this.voltarButton.Text = "Voltar";
            this.voltarButton.UseVisualStyleBackColor = true;
            this.voltarButton.Click += new System.EventHandler(this.voltarButton_Click);
            // 
            // descricaoTextBox
            // 
            this.descricaoTextBox.Location = new System.Drawing.Point(340, 110);
            this.descricaoTextBox.Name = "descricaoTextBox";
            this.descricaoTextBox.Size = new System.Drawing.Size(100, 20);
            this.descricaoTextBox.TabIndex = 2;
            // 
            // valorTextBox
            // 
            this.valorTextBox.Location = new System.Drawing.Point(340, 159);
            this.valorTextBox.Name = "valorTextBox";
            this.valorTextBox.Size = new System.Drawing.Size(100, 20);
            this.valorTextBox.TabIndex = 3;
            this.valorTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.valorTextBox_KeyPress);
            // 
            // valorLabelText
            // 
            this.valorLabelText.AutoSize = true;
            this.valorLabelText.Location = new System.Drawing.Point(296, 166);
            this.valorLabelText.Name = "valorLabelText";
            this.valorLabelText.Size = new System.Drawing.Size(40, 13);
            this.valorLabelText.TabIndex = 4;
            this.valorLabelText.Text = "Valor : ";
            // 
            // descricaoLabelText
            // 
            this.descricaoLabelText.AutoSize = true;
            this.descricaoLabelText.Location = new System.Drawing.Point(270, 117);
            this.descricaoLabelText.Name = "descricaoLabelText";
            this.descricaoLabelText.Size = new System.Drawing.Size(64, 13);
            this.descricaoLabelText.TabIndex = 5;
            this.descricaoLabelText.Text = "Descrição : ";
            // 
            // AdicionarProdutoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.descricaoLabelText);
            this.Controls.Add(this.valorLabelText);
            this.Controls.Add(this.valorTextBox);
            this.Controls.Add(this.descricaoTextBox);
            this.Controls.Add(this.voltarButton);
            this.Controls.Add(this.adicionarButton);
            this.Name = "AdicionarProdutoView";
            this.Text = "Adicionar Produto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button adicionarButton;
        private System.Windows.Forms.Button voltarButton;
        private System.Windows.Forms.TextBox descricaoTextBox;
        private System.Windows.Forms.TextBox valorTextBox;
        private System.Windows.Forms.Label valorLabelText;
        private System.Windows.Forms.Label descricaoLabelText;
    }
}