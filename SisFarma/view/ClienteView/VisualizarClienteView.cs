using SisFarma.controller.controllers;
using SisFarma.controller.controllers.postgresql;
using SisFarma.model.classes;
using SisFarma.model.DAO.PostgresqlDAO;
using System;
using System.Data;
using System.Windows.Forms;

namespace SisFarma.view.ClienteView
{
    public partial class VisualizarClienteView : Form
    {
        private ClienteController clienteController;
        private ClienteControllerPost clienteControllerPostgresql;
        private CurrentIdController current;
        private DataTable dt;
        private ClienteDAOPost clienteDAOPost;
        private int rowSelected;

        public VisualizarClienteView()
        {
            clienteController = new ClienteController();
            this.clienteControllerPostgresql = new ClienteControllerPost();
            current = new CurrentIdController();
            this.dt = new DataTable();
            clienteDAOPost = new ClienteDAOPost();
            InitializeComponent();
            this.inicializarDataTable();
        }

        private void inicializarDataTable()
        {         
            dataGridView1.DataSource = dt;
            dt.Columns.Add("Nome");
            dt.Columns.Add("Data de Nascimento");
            dt.Columns.Add("Telefone");
            dt.Columns.Add("Cidade");
            dt.Columns.Add("Logradouro");
            dt.Columns.Add("Id");
            dataGridView1.Columns["Id"].Visible = false;
            this.inicializarRows();
        }

        private void inicializarRows()
        {
            foreach (Cliente cli in clienteDAOPost.recuperarTodos())
            {
                DataRow row = dt.NewRow();
                row["Nome"] = cli.Nome;
                row["Data de Nascimento"] = cli.DataNasc;
                row["Telefone"] = cli.Telefone;
                row["Cidade"] = cli.Cidade;
                row["Logradouro"] = cli.Logradouro;
                row["Id"] = cli.Id;

                dt.Rows.Add(row);
            }
        }

        private void recuperarClienteButton_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente c = clienteControllerPostgresql.recuperarPorNome
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
            new MostrarClienteView(clienteControllerPostgresql.recuperarPorId(this.retornarId())).Show();

        }

        private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AlterarClienteView
                    (clienteControllerPostgresql.recuperarPorId
                        (this.retornarId())).Show();
        }

        private void deletarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                clienteControllerPostgresql.deletar(this.retornarId());
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
