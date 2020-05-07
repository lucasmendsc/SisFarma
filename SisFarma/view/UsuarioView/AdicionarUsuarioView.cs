using SisFarma.controller.controllers;
using SisFarma.model.classes;
using System;
using System.Windows.Forms;

namespace SisFarma.view.UsuarioView
{
    public partial class AdicionarUsuarioView : Form
    {
        private CurrentIdController current;
        private UsuarioController usuarioController;
        public AdicionarUsuarioView()
        {
            this.current = new CurrentIdController();
            this.usuarioController = new UsuarioController();
            InitializeComponent();
        }

        private void adicionarButton_Click(object sender, System.EventArgs e)
        {
            if (!(senhaTextBox.Text.Equals(confirmacaoSenhaTextBox.Text)))
            {
                MessageBox.Show("As senhas não são iguais");
            }
            else
            {
                try
                {
                    usuarioController.adicionarUsuario
                        (new Usuario(current.recuperarId(5) + 1,nomeTextBox.Text,
                        loginTextBox.Text,senhaTextBox.Text));
                    current.atualizarId(5);
                    MessageBox.Show("Usuário cadastrado com sucesso!");
                }
                catch (Exception)
                {
                    MessageBox.Show("Ocorreu um erro ao cadastrar o usuário.");
                    this.Close();
                }
            }

        }

        private void voltarButton_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void senhaLabelText_Click(object sender, EventArgs e)
        {

        }

        private void loginLabelText_Click(object sender, EventArgs e)
        {

        }

        private void nomeLabelText_Click(object sender, EventArgs e)
        {

        }

        private void confirmacaoSenhaTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nomeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void senhaTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
