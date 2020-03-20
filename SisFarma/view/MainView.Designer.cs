namespace SisFarma.view
{
    partial class MainView
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
            this.produtoViewButton = new System.Windows.Forms.Button();
            this.clienteViewButton = new System.Windows.Forms.Button();
            this.usuarioViewButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // produtoViewButton
            // 
            this.produtoViewButton.Location = new System.Drawing.Point(369, 251);
            this.produtoViewButton.Name = "produtoViewButton";
            this.produtoViewButton.Size = new System.Drawing.Size(75, 23);
            this.produtoViewButton.TabIndex = 0;
            this.produtoViewButton.Text = "ProdutoView";
            this.produtoViewButton.UseVisualStyleBackColor = true;
            this.produtoViewButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // clienteViewButton
            // 
            this.clienteViewButton.Location = new System.Drawing.Point(288, 251);
            this.clienteViewButton.Name = "clienteViewButton";
            this.clienteViewButton.Size = new System.Drawing.Size(75, 23);
            this.clienteViewButton.TabIndex = 1;
            this.clienteViewButton.Text = "ClienteView";
            this.clienteViewButton.UseVisualStyleBackColor = true;
            this.clienteViewButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // usuarioViewButton
            // 
            this.usuarioViewButton.Location = new System.Drawing.Point(450, 251);
            this.usuarioViewButton.Name = "usuarioViewButton";
            this.usuarioViewButton.Size = new System.Drawing.Size(94, 23);
            this.usuarioViewButton.TabIndex = 2;
            this.usuarioViewButton.Text = "Usuario View";
            this.usuarioViewButton.UseVisualStyleBackColor = true;
            this.usuarioViewButton.Click += new System.EventHandler(this.usuarioViewButton_Click);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.usuarioViewButton);
            this.Controls.Add(this.clienteViewButton);
            this.Controls.Add(this.produtoViewButton);
            this.Name = "MainView";
            this.Text = "MainView";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button produtoViewButton;
        private System.Windows.Forms.Button clienteViewButton;
        private System.Windows.Forms.Button usuarioViewButton;
    }
}