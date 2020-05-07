namespace SisFarma.view
{
    partial class MostrarUsuarioView
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
            this.loginLabelText = new System.Windows.Forms.Label();
            this.nomeLabelText = new System.Windows.Forms.Label();
            this.voltarButton = new System.Windows.Forms.Button();
            this.nomeValorLabelText = new System.Windows.Forms.Label();
            this.loginValorLabelText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loginLabelText
            // 
            this.loginLabelText.AutoSize = true;
            this.loginLabelText.Location = new System.Drawing.Point(174, 137);
            this.loginLabelText.Name = "loginLabelText";
            this.loginLabelText.Size = new System.Drawing.Size(42, 13);
            this.loginLabelText.TabIndex = 8;
            this.loginLabelText.Text = "Login : ";
            // 
            // nomeLabelText
            // 
            this.nomeLabelText.AutoSize = true;
            this.nomeLabelText.Location = new System.Drawing.Point(172, 111);
            this.nomeLabelText.Name = "nomeLabelText";
            this.nomeLabelText.Size = new System.Drawing.Size(44, 13);
            this.nomeLabelText.TabIndex = 7;
            this.nomeLabelText.Text = "Nome : ";
            // 
            // voltarButton
            // 
            this.voltarButton.Location = new System.Drawing.Point(159, 194);
            this.voltarButton.Name = "voltarButton";
            this.voltarButton.Size = new System.Drawing.Size(172, 23);
            this.voltarButton.TabIndex = 10;
            this.voltarButton.Text = "Voltar";
            this.voltarButton.UseVisualStyleBackColor = true;
            this.voltarButton.Click += new System.EventHandler(this.voltarButton_Click);
            // 
            // nomeValorLabelText
            // 
            this.nomeValorLabelText.AutoSize = true;
            this.nomeValorLabelText.Location = new System.Drawing.Point(282, 111);
            this.nomeValorLabelText.Name = "nomeValorLabelText";
            this.nomeValorLabelText.Size = new System.Drawing.Size(35, 13);
            this.nomeValorLabelText.TabIndex = 11;
            this.nomeValorLabelText.Text = "Nome";
            // 
            // loginValorLabelText
            // 
            this.loginValorLabelText.AutoSize = true;
            this.loginValorLabelText.Location = new System.Drawing.Point(282, 137);
            this.loginValorLabelText.Name = "loginValorLabelText";
            this.loginValorLabelText.Size = new System.Drawing.Size(33, 13);
            this.loginValorLabelText.TabIndex = 12;
            this.loginValorLabelText.Text = "Login";
            // 
            // MostrarUsuarioView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 342);
            this.Controls.Add(this.loginValorLabelText);
            this.Controls.Add(this.nomeValorLabelText);
            this.Controls.Add(this.voltarButton);
            this.Controls.Add(this.loginLabelText);
            this.Controls.Add(this.nomeLabelText);
            this.Name = "MostrarUsuarioView";
            this.Text = "MostrarUsuarioView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loginLabelText;
        private System.Windows.Forms.Label nomeLabelText;
        private System.Windows.Forms.Button voltarButton;
        private System.Windows.Forms.Label nomeValorLabelText;
        private System.Windows.Forms.Label loginValorLabelText;
    }
}