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

namespace SisFarma.view.ClienteView
{
    public partial class AdicionarClienteView : Form
    {
        private ClienteController clienteController;
        private CurrentIdController current;
        public AdicionarClienteView()
        {
            clienteController = new ClienteController();
            current = new CurrentIdController();
            InitializeComponent();
        }

        private void adicionarClienteButton_Click(object sender, EventArgs e)
        {
           
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
                current.atualizarIdsDeletados(1);
                MessageBox.Show("Cliente deletado com sucesso!");
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao deletar o cliente.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Cliente cli in clienteController.recuperarTodos())
            {
                MessageBox.Show(cli.Nome);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
