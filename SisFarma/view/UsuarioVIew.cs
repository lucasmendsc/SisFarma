using SisFarma.controller.controllers;
using SisFarma.model.classes;
using System;
using System.Windows.Forms;

namespace SisFarma.view
{
    public partial class UsuarioVIew : Form
    {
        private UsuarioController usuarioController;
        private CurrentIdController current;
        public UsuarioVIew()
        {
            this.usuarioController = new UsuarioController();
            this.current = new CurrentIdController();
            InitializeComponent();
        }

        private void adicionarUsuarioButton_Click(object sender, EventArgs e)
        {
            try
            {
                current.atualizarId(5);
                usuarioController.adicionarUsuario
                    (new Usuario(current.recuperarId(5),nomeTextBox.Text,loginTextBox.Text,
                    senhaTextBox.Text));

                MessageBox.Show("Usuario cadastrado com sucesso!");
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao cadastar o usuario");
            }
        }
    }
}
