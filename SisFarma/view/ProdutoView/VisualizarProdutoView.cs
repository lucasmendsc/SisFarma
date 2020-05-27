using SisFarma.controller.controllers;
using SisFarma.controller.controllers.postgresql;
using SisFarma.model.classes;
using System;
using System.Data;
using System.Windows.Forms;

namespace SisFarma.view
{
    public partial class ProdutoView : Form
    {
        private ProdutoController pController;
        private ProdutoControllerPost produtoControllerPost;
        private CurrentIdController current;
        private DataTable dt;
        private int rowSelected;
        public ProdutoView()
        {
            InitializeComponent();
            this.produtoControllerPost = new ProdutoControllerPost();
            pController = new ProdutoController();
            current = new CurrentIdController();
            this.dt = new DataTable();
            this.inicializarDataTable();
        }

        private void inicializarDataTable()
        {
            dt.Columns.Add("Descrição");
            dt.Columns.Add("Preço");
            dt.Columns.Add("Id");
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["Id"].Visible = false;
            this.inicializarRows();
        }

        private void inicializarRows()
        {
            foreach (Produto p in produtoControllerPost.recuperarTodos())
            {
                DataRow row = dt.NewRow();
                row["Descrição"] = p.Descricao;
                row["Preço"] = p.Valor;
                row["Id"] = p.Id;

                dt.Rows.Add(row);
            }
        }

        private void recuperarPorDescButton_Click(object sender, EventArgs e)
        {
            try
            {
                Produto produto = produtoControllerPost.recuperarPorNome
                                        (recuperarTextBox.Text);
                MessageBox.Show(produto.Descricao);

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

        private void deletarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                pController.deletarProduto
                    (produtoControllerPost.recuperarPorId(this.retornarId()));
                MessageBox.Show("Produto deletado com sucesso!");

            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao deletar o produto. ");
            }
        }

        private void visualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new MostrarProdutoView
                    (produtoControllerPost.recuperarPorId
                            (this.retornarId())).Show();
        }

        private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            new AlterarProdutoView
                    (produtoControllerPost.recuperarPorId
                            (this.retornarId())).Show();
        }

        private int retornarId()
        {
            DataGridViewRow selectedRow = dataGridView1.Rows[rowSelected];
            return Convert.ToInt32(selectedRow.Cells["Id"].Value);
        }
    }
}