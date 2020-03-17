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
            try
            {
                clienteController.adicionarCliente(
                new Cliente(1, logradouroTextBox.Text, cidadeTextBox.Text, cepTextBox.Text,
                DateTime.Now, telefoneTextBox.Text, sexoTextBox.Text, rgTextBox.Text,
                nomeTextBox.Text, cpfTextBox.Text, 5));
                MessageBox.Show("Cliente cadastrado com sucesso!");
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao cadastrar um cliente.");
            }
            
        }

        private void recuperarClienteButton_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente clienteRecuperado = clienteController.recuperarCliente(1);
                MessageBox.Show(clienteRecuperado.Nome);
            }
            catch (Exception)
            {
                MessageBox.Show("ASD");
            }
        }

        private void alterarClienteButton_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente cliente = new Cliente();
                clienteController.alterarCliente(cliente);
                MessageBox.Show("Cliente alterado com sucesso!");
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao alterar o cliente.");
            }
        }

        private void apagarClienteButton_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente cliente = new Cliente();
                clienteController.deletarCliente(cliente);
                MessageBox.Show("Cliente deletado com sucesso!");
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao deletar o cliente.");
            }
        }
    }
}
