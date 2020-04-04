namespace SisFarma.view.UsuarioView
{
    partial class VisualizarUsuarioView
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.recuperarTextBox = new System.Windows.Forms.TextBox();
            this.recuperarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 391);
            this.dataGridView1.TabIndex = 0;
            // 
            // recuperarTextBox
            // 
            this.recuperarTextBox.Location = new System.Drawing.Point(12, 21);
            this.recuperarTextBox.Name = "recuperarTextBox";
            this.recuperarTextBox.Size = new System.Drawing.Size(645, 20);
            this.recuperarTextBox.TabIndex = 1;
            // 
            // recuperarButton
            // 
            this.recuperarButton.Location = new System.Drawing.Point(672, 21);
            this.recuperarButton.Name = "recuperarButton";
            this.recuperarButton.Size = new System.Drawing.Size(116, 23);
            this.recuperarButton.TabIndex = 2;
            this.recuperarButton.Text = "Recuperar";
            this.recuperarButton.UseVisualStyleBackColor = true;
            this.recuperarButton.Click += new System.EventHandler(this.recuperarButton_Click);
            // 
            // VisualizarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.recuperarButton);
            this.Controls.Add(this.recuperarTextBox);
            this.Controls.Add(this.dataGridView1);
            this.Name = "VisualizarUsuario";
            this.Text = "VisualizarUsuario";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox recuperarTextBox;
        private System.Windows.Forms.Button recuperarButton;
    }
}