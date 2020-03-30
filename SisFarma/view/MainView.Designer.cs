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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarProdutoMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizarProdutoMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarClienteMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizarClienteMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.usuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarUsuarioMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizarUsuarioMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Info;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produtosToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.usuáriosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarProdutoMenu,
            this.visualizarProdutoMenu});
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.produtosToolStripMenuItem.Text = "Produtos";
            // 
            // cadastrarProdutoMenu
            // 
            this.cadastrarProdutoMenu.Name = "cadastrarProdutoMenu";
            this.cadastrarProdutoMenu.Size = new System.Drawing.Size(180, 22);
            this.cadastrarProdutoMenu.Text = "Cadastrar";
            this.cadastrarProdutoMenu.Click += new System.EventHandler(this.cadastrarToolStripMenuItem_Click);
            // 
            // visualizarProdutoMenu
            // 
            this.visualizarProdutoMenu.Name = "visualizarProdutoMenu";
            this.visualizarProdutoMenu.Size = new System.Drawing.Size(180, 22);
            this.visualizarProdutoMenu.Text = "Visualizar";
            this.visualizarProdutoMenu.Click += new System.EventHandler(this.visualizarToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarClienteMenu,
            this.visualizarClienteMenu});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // cadastrarClienteMenu
            // 
            this.cadastrarClienteMenu.Name = "cadastrarClienteMenu";
            this.cadastrarClienteMenu.Size = new System.Drawing.Size(180, 22);
            this.cadastrarClienteMenu.Text = "Cadastrar";
            this.cadastrarClienteMenu.Click += new System.EventHandler(this.cadastrarToolStripMenuItem1_Click);
            // 
            // visualizarClienteMenu
            // 
            this.visualizarClienteMenu.Name = "visualizarClienteMenu";
            this.visualizarClienteMenu.Size = new System.Drawing.Size(180, 22);
            this.visualizarClienteMenu.Text = "Visualizar";
            // 
            // usuáriosToolStripMenuItem
            // 
            this.usuáriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarUsuarioMenu,
            this.visualizarUsuarioMenu});
            this.usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            this.usuáriosToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.usuáriosToolStripMenuItem.Text = "Usuários";
            // 
            // cadastrarUsuarioMenu
            // 
            this.cadastrarUsuarioMenu.Name = "cadastrarUsuarioMenu";
            this.cadastrarUsuarioMenu.Size = new System.Drawing.Size(180, 22);
            this.cadastrarUsuarioMenu.Text = "Cadastrar";
            this.cadastrarUsuarioMenu.Click += new System.EventHandler(this.cadastrarToolStripMenuItem2_Click);
            // 
            // visualizarUsuarioMenu
            // 
            this.visualizarUsuarioMenu.Name = "visualizarUsuarioMenu";
            this.visualizarUsuarioMenu.Size = new System.Drawing.Size(180, 22);
            this.visualizarUsuarioMenu.Text = "Visualizar";
            this.visualizarUsuarioMenu.Click += new System.EventHandler(this.visualizarUsuarioToolStripMenuItem2_Click);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarProdutoMenu;
        private System.Windows.Forms.ToolStripMenuItem visualizarProdutoMenu;
        private System.Windows.Forms.ToolStripMenuItem cadastrarClienteMenu;
        private System.Windows.Forms.ToolStripMenuItem visualizarClienteMenu;
        private System.Windows.Forms.ToolStripMenuItem cadastrarUsuarioMenu;
        private System.Windows.Forms.ToolStripMenuItem visualizarUsuarioMenu;
    }
}