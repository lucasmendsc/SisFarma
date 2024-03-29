﻿using SisFarma.controller.controllers;
using SisFarma.controller.controllers.postgresql;
using SisFarma.model.classes;
using System;
using System.Windows.Forms;

namespace SisFarma.view
{
    public partial class AlterarUsuarioView : Form
    {
        private UsuarioController usuarioController;
        private UsuarioControllerPost usuarioControllerPost;
        private Usuario usuario;
        public AlterarUsuarioView(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.usuarioControllerPost = new UsuarioControllerPost();
            this.usuarioController = new UsuarioController();
            this.inicializarCampos();
        }

        public void inicializarCampos()
        {
            nomeTextBox.Text = usuario.Nome;
            loginTextBox.Text = usuario.Login;
            senhaTextBox.Text = usuario.Senha;
        }

        private void alterarButton_Click(object sender, EventArgs e)
        {
            if (!(senhaTextBox.Text.Equals(confirmacaoSenhaTextBox.Text)))
            {
                MessageBox.Show("As senhas não são iguais");
            }
            else
            {
                try
                {
                    usuario.Nome = nomeTextBox.Text;
                    usuario.Login = loginTextBox.Text;
                    usuario.Senha = senhaTextBox.Text;
                    usuarioControllerPost.alterar(usuario);
                    MessageBox.Show("Usuario alterado com sucesso!");
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
        }

        private void voltarButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
