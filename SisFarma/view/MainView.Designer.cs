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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
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
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produtosToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.usuáriosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.produtosToolStripMenuItem.Text = "Produtos";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // usuáriosToolStripMenuItem
            // 
            this.usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            this.usuáriosToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.usuáriosToolStripMenuItem.Text = "Usuários";
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.usuarioViewButton);
            this.Controls.Add(this.clienteViewButton);
            this.Controls.Add(this.produtoViewButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainView";
            this.Text = "MainView";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button produtoViewButton;
        private System.Windows.Forms.Button clienteViewButton;
        private System.Windows.Forms.Button usuarioViewButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuáriosToolStripMenuItem;
    }
}