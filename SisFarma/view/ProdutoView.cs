using SisFarma.controller.controllers;
using SisFarma.model.classes;
using SisFarma.model.DAO;
using System;
using System.Data;
using System.Windows.Forms;

namespace SisFarma.view
{
    public partial class ProdutoView : Form
    {
        private ProdutoController pController;
        private CurrentIdController current;
        private DataTable dt;
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
        private void adicionarProdutoButton_Click(object sender, EventArgs e)
        {
            try
            {
                current.atualizarId(2);
                Produto produtoAdicionado = new Produto(current.recuperarId(2), descricaoTextBox.Text, 2.5, "");
                pController.adicionarProduto(produtoAdicionado);

                MessageBox.Show("Produto cadastrado com sucesso!");

            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao cadastar o produto ");
            }
        }

        private void recuperarPorDescButton_Click(object sender, EventArgs e)
        {
            try
            {
                Produto produto = pController.recuperarPorDescricao(descricaoTextBox.Text);
                MessageBox.Show(produto.Id + "");

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
                Produto produtoAdicionado = new Produto(4, descricaoTextBox.Text, 6.5, "222");
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
                Produto produtoAdicionado = new Produto(1, descricaoTextBox.Text, 2.5, "");
                pController.deletarProduto(produtoAdicionado);
                current.atualizarIdsDeletados(2);
                MessageBox.Show("Produto deletado com sucesso!");

            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao deletar o produto ");
            }
        }

        private void recuperarTodosButton_Click(object sender, EventArgs e)
        {
            foreach(Produto p in pController.recuperarTodos())
            {
                MessageBox.Show(p.Descricao);
            }
        }
    }
}
