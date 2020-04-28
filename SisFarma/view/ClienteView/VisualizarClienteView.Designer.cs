namespace SisFarma.view.ClienteView
{
    partial class VisualizarClienteView
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.recuperarClienteTextBox = new System.Windows.Forms.TextBox();
            this.recuperarClienteButton = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.visualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deletarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 400);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // recuperarClienteTextBox
            // 
            this.recuperarClienteTextBox.Location = new System.Drawing.Point(12, 12);
            this.recuperarClienteTextBox.Name = "recuperarClienteTextBox";
            this.recuperarClienteTextBox.Size = new System.Drawing.Size(650, 20);
            this.recuperarClienteTextBox.TabIndex = 1;
            // 
            // recuperarClienteButton
            // 
            this.recuperarClienteButton.Location = new System.Drawing.Point(668, 9);
            this.recuperarClienteButton.Name = "recuperarClienteButton";
            this.recuperarClienteButton.Size = new System.Drawing.Size(120, 23);
            this.recuperarClienteButton.TabIndex = 2;
            this.recuperarClienteButton.Text = "Recuperar";
            this.recuperarClienteButton.UseVisualStyleBackColor = true;
            this.recuperarClienteButton.Click += new System.EventHandler(this.recuperarClienteButton_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visualizarToolStripMenuItem,
            this.alterarToolStripMenuItem,
            this.deletarToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 92);
            // 
            // visualizarToolStripMenuItem
            // 
            this.visualizarToolStripMenuItem.Name = "visualizarToolStripMenuItem";
            this.visualizarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.visualizarToolStripMenuItem.Text = "Visualizar";
            this.visualizarToolStripMenuItem.Click += new System.EventHandler(this.visualizarToolStripMenuItem_Click);
            // 
            // alterarToolStripMenuItem
            // 
            this.alterarToolStripMenuItem.Name = "alterarToolStripMenuItem";
            this.alterarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.alterarToolStripMenuItem.Text = "Alterar";
            // 
            // deletarToolStripMenuItem
            // 
            this.deletarToolStripMenuItem.Name = "deletarToolStripMenuItem";
            this.deletarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deletarToolStripMenuItem.Text = "Deletar";
            // 
            // VisualizarClienteView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.recuperarClienteButton);
            this.Controls.Add(this.recuperarClienteTextBox);
            this.Controls.Add(this.dataGridView1);
            this.Name = "VisualizarClienteView";
            this.Text = "Visualizar Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox recuperarClienteTextBox;
        private System.Windows.Forms.Button recuperarClienteButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem visualizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deletarToolStripMenuItem;
    }
}