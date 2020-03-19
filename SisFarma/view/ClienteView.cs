using SisFarma.controller.controllers;
using SisFarma.model.classes;
using SisFarma.model.DAO;
using System;
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
                CurrentIdDAO current = new CurrentIdDAO();
            current.atualizarId(1);
                clienteController.adicionarCliente(
                new Cliente(current.recuperarId(1), logradouroTextBox.Text, cidadeTextBox.Text, cepTextBox.Text,
                DateTime.Now, telefoneTextBox.Text, sexoTextBox.Text, rgTextBox.Text,
                nomeTextBox.Text, cpfTextBox.Text, 5));
                MessageBox.Show("Cliente cadastrado com sucesso!");
            
        }

        private void recuperarClienteButton_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente clienteRecuperado = clienteController.recuperarCliente(6);
                MessageBox.Show(clienteRecuperado.Nome);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao recuperar um cliente");
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

        private void button1_Click(object sender, EventArgs e)
        {
            foreach(Cliente cli in clienteController.recuperarTodos())
            {
                MessageBox.Show(cli.Nome);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cliente cli = clienteController.recuperarPorNome(nomeTextBox.Text);
            MessageBox.Show("" + cli.Id);
        }
    }
}
