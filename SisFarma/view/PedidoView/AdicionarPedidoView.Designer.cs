namespace SisFarma.view
{
    partial class PedidoView
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
            this.adicionarClienteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // adicionarClienteButton
            // 
            this.adicionarClienteButton.Location = new System.Drawing.Point(159, 314);
            this.adicionarClienteButton.Name = "adicionarClienteButton";
            this.adicionarClienteButton.Size = new System.Drawing.Size(184, 23);
            this.adicionarClienteButton.TabIndex = 0;
            this.adicionarClienteButton.Text = "Adicionar Cliente";
            this.adicionarClienteButton.UseVisualStyleBackColor = true;
            this.adicionarClienteButton.Click += new System.EventHandler(this.adicionarClienteButton_Click);
            // 
            // PedidoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.adicionarClienteButton);
            this.Name = "PedidoView";
            this.Text = "PedidoView";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button adicionarClienteButton;
    }
}