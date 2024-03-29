﻿using SisFarma.controller.controllers;
using SisFarma.controller.controllers.postgresql;
using SisFarma.model.classes;
using System;
using System.Windows.Forms;

namespace SisFarma.view.ClienteView
{
    public partial class AdicionarClienteView : Form
    {
        private ClienteController clienteController;
        private ClienteControllerPost clienteControllerPost;
        private CurrentIdController current;
        public AdicionarClienteView()
        {
            this.clienteControllerPost = new ClienteControllerPost();
            clienteController = new ClienteController();
            current = new CurrentIdController();
            InitializeComponent();
        }

        private void adicionarClienteButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                
                clienteControllerPost.inserir
                    (new Cliente
                        (clienteControllerPost.recuperarTodos().Count + 1,nomeTextBox.Text,cpfTextBox.Text,
                        rgTextBox.Text,dateTimePicker1.Value,sexoTextBox.Text,
                        telefoneTextBox.Text,cepTextBox.Text,cidadeTextBox.Text,
                        logradouroTextBox.Text,Convert.ToInt32(numeroTextBox.Text)));
                MessageBox.Show("Cliente adicionado com sucesso!");
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao cadastrar um cliente.");
                this.Close();
            }

        }

        private void voltarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void numeroTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
                e.Handled = true;
        }
    }
}
