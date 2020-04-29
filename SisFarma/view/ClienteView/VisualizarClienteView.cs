using SisFarma.controller.controllers;
using SisFarma.model.classes;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace SisFarma.view.ClienteView
{
    public partial class VisualizarClienteView : Form
    {
        private ClienteController clienteController;
        private CurrentIdController current;
        private DataTable dt;
        private int rowSelected;

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

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {

                rowSelected = dataGridView1.HitTest(e.X, e.Y).RowIndex;

                if (rowSelected >= 0)
                {
                    MessageBox.Show("Selecione uma linha!");
                }

            }
        }

        private void visualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void deletarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                clienteController.deletarCliente
                    (clienteController.recuperarCliente(rowSelected - 1));
                current.atualizarIdsDeletados(1);
                MessageBox.Show("Cliente deletado com sucesso!");

            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao deletar o cliente. ");
            }
        }
    }
}
