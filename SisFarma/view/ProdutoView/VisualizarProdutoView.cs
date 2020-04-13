using SisFarma.controller.controllers;
using SisFarma.model.classes;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace SisFarma.view
{
    public partial class ProdutoView : Form
    {
        private ProdutoController pController;
        private CurrentIdController current;
        private DataTable dt;
        private int rowSelected;
        public ProdutoView()
        {
            pController = new ProdutoController();
            current = new CurrentIdController();
            this.dt = new DataTable();
            InitializeComponent();
            this.inicializarDataTable();
        }

        private void inicializarDataTable()
        {
            dt.Columns.Add("Descrição");
            dt.Columns.Add("Preço");

            dataGridView1.DataSource = dt;
            this.inicializarRows();
        }

        private void inicializarRows()
        {
            foreach (Produto p in pController.recuperarTodos())
            {
                DataRow row = dt.NewRow();
                row["Descrição"] = p.Descricao;
                row["Preço"] = p.Valor;

                dt.Rows.Add(row);
            }
        }

        private void recuperarPorDescButton_Click(object sender, EventArgs e)
        {
            try
            {
                Produto produto = pController.recuperarPorDescricao
                                        (recuperarPorDescricaoTextBox.Text);
                MessageBox.Show(produto.Descricao);

            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao recuperar o produto por descrição.");
            }
        }

        private void alterarProdutoButton_Click(object sender, EventArgs e)
        {
            try
            {
                Produto produtoAdicionado = new Produto(4, "asd", 6.5, "222");
                pController.alterarProduto(produtoAdicionado);

                MessageBox.Show("Produto alterado com sucesso!");

            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao alterar o produto." );
            }
        }

        private void deletarProdutoButton_Click(object sender, EventArgs e)
        {
            try
            {
                Produto produtoAdicionado = new Produto(1," asd", 2.5, "");
                pController.deletarProduto(produtoAdicionado);
                current.atualizarIdsDeletados(2);
                MessageBox.Show("Produto deletado com sucesso!");

            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao deletar o produto ");
            }
        }

        private void adicionarProdutoButton_Click(object sender, EventArgs e)
        {
            new AdicionarProdutoView().Show();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenu menu = new ContextMenu();
                menu.MenuItems.Add(new MenuItem("Visualizar"));
                menu.MenuItems.Add(new MenuItem("Alterar"));
                menu.MenuItems.Add(new MenuItem("Deletar"));

                rowSelected = dataGridView1.HitTest(e.X, e.Y).RowIndex;

                if (rowSelected >= 0)
                {
                    MessageBox.Show("Selecione uma linha!");
                }

                menu.Show(dataGridView1, new Point(e.X + 80, e.Y + 15));

            }
        }
    }
}
