using SisFarma.controller.controllers;
using SisFarma.controller.controllers.postgresql;
using SisFarma.model.classes;
using SisFarma.model.DAO.PostgresqlDAO;
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
            ClienteDAOPost c = new ClienteDAOPost();
            this.dt.Load(c.recuperarTodos());
            InitializeComponent();
            this.inicializarDataTable();
        }

        private void inicializarDataTable()
        {         
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["Id"].Visible = false;
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

                rowSelected = e.RowIndex;

                if (rowSelected < 0)
                {
                    MessageBox.Show("Selecione uma linha!");
                }

            }
        }

        private void visualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("" + retornarId());
            new MostrarClienteView(clienteController.recuperarCliente(this.retornarId())).Show();

        }

        private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AlterarClienteView
                    (clienteController.recuperarCliente
                        (this.retornarId())).Show();
        }

        private void deletarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                clienteController.deletarCliente
                    (clienteController.recuperarCliente
                        (this.retornarId()));

                current.atualizarIdsDeletados(1);
                MessageBox.Show("Cliente deletado com sucesso!");

            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao deletar o cliente. ");
            }
        }

        private int retornarId()
        {
            DataGridViewRow selectedRow = dataGridView1.Rows[rowSelected];
            return Convert.ToInt32(selectedRow.Cells["Id"].Value);
        }
    }
}
