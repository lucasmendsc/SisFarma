using SisFarma.controller.controllers;
using SisFarma.model.classes;
using System;
using System.Windows.Forms;

namespace SisFarma.view
{
    public partial class AlterarClienteView : Form
    {
        private ClienteController clienteController;
        private Cliente cliente;
        public AlterarClienteView(Cliente cliente)
        {
            this.clienteController = new ClienteController();
            this.cliente = cliente;
            InitializeComponent();
            this.inicializarCampos();
        }

        private void inicializarCampos()
        {
            nomeTextBox.Text = cliente.Nome;
            cpfTextBox.Text = cliente.CPF;
            rgTextBox.Text = cliente.Rg;
            dateTimePicker1.Value = cliente.DataNasc;
            sexoTextBox.Text = cliente.Sexo;
            telefoneTextBox.Text = cliente.Telefone;
            cepTextBox.Text = cliente.CEP;
            cidadeTextBox.Text = cliente.Cidade;
            logradouroTextBox.Text = cliente.Logradouro;
        }
        private void alterarClienteButton_Click(object sender, EventArgs e)
        {
            try
            {
                cliente.Nome = nomeTextBox.Text;
                cliente.CPF = cpfTextBox.Text;
                cliente.Rg = rgTextBox.Text;
                cliente.DataNasc = dateTimePicker1.Value;
                cliente.Sexo = sexoTextBox.Text;
                cliente.Telefone = telefoneTextBox.Text;
                cliente.CEP = cepTextBox.Text;
                cliente.Cidade = cidadeTextBox.Text;
                cliente.Logradouro = logradouroTextBox.Text;

                clienteController.alterarCliente(cliente);
                MessageBox.Show("Cliente alterado com sucesso!");
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu algo inesperado ao alterar o cliente.");
            }
        }

        private void voltarButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
