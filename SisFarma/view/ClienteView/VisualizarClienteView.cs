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
    public partial class VisualizarClienteView : Form
    {
        private ClienteController clienteController;
        private CurrentIdController current;
        private DataTable dt;
        public VisualizarClienteView()
        {
            clienteController = new ClienteController();
            current = new CurrentIdController();
            this.dt = new DataTable();
            InitializeComponent();
            this.inicializarDataTable();
        }

        private void inicializarDataTable()
        {
            dt.Columns.Add("Nome");
            dt.Columns.Add("Telefone");
            dt.Columns.Add("Cidade");
            dt.Columns.Add("Logradouro");

            dataGridView1.DataSource = dt;
            this.inicializarRows();
        }

        private void inicializarRows()
        {
            foreach (Cliente c in clienteController.recuperarTodos())
            {
                DataRow row = dt.NewRow();
                row["Nome"] = c.Nome;
                row["Telefone"] = c.Telefone;
                row["Cidade"] = c.Cidade;
                row["Logradouro"] = c.Logradouro;

                dt.Rows.Add(row);
            }
        }

        private void recuperarClienteButton_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente c = clienteController.recuperarPorNome
                                (recuperarClienteTextBox.Text);
                                        
                MessageBox.Show(c.Nome);

            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao recuperar o produto por descrição.");
            }
        }
    }
}
