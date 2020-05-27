using SisFarma.controller.controllers;
using SisFarma.controller.controllers.postgresql;
using SisFarma.model.classes;
using System;
using System.Windows.Forms;

namespace SisFarma.view
{
    public partial class AlterarProdutoView : Form
    {
        private ProdutoController pController;
        private ProdutoControllerPost produtoControllerPost;
        private Produto produto;
        public AlterarProdutoView(Produto produto)
        {
            this.pController = new ProdutoController();
            this.produtoControllerPost = new ProdutoControllerPost();
            this.produto = produto;
            InitializeComponent();
            this.inicializarCampos();
        }

        private void inicializarCampos()
        {
            descricaoTextBox.Text = produto.Descricao;
            precoTextBox.Text = produto.Valor.ToString();
        }

        private void alterarButton_Click(object sender, EventArgs e)
        {
            try
            {
                produto.Descricao = descricaoTextBox.Text;
                produto.Valor = Convert.ToDouble(precoTextBox.Text);
                produtoControllerPost.alterar(produto);
                MessageBox.Show("Produto alterado com sucesso!");
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao alterar um produto");
            }
           
        }

        private void voltarButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
