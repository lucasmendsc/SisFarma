using SisFarma.controller.controllers;
using SisFarma.model.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisFarma.view
{
    public partial class ClienteView : Form
    {
        ClienteController clienteController;
        public ClienteView()
        {
            clienteController = new ClienteController();
            InitializeComponent();
        }

        private void adicionarClienteButton_Click(object sender, EventArgs e)
        {
            clienteController.adicionarCliente(
                new Cliente(1,nomeTextBox.Text,cpfTextBox.Text,rgTextBox.Text,
                DateTime.Now,sexoTextBox.Text,telefoneTextBox.Text,cepTextBox.Text,
                cidadeTextBox.Text,logTextBox.Text,5));
            MessageBox.Show("Cliente cadastrado com sucesso!");
        }

    }
}
