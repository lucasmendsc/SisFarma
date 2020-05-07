using SisFarma.controller.controllers;
using SisFarma.model.classes;
using System;
using System.Windows.Forms;

namespace SisFarma.view
{
    public partial class AlterarProdutoView : Form
    {
        private ProdutoController pController;
        private Produto produto;
        public AlterarProdutoView(Produto produto)
        {
            this.pController = new ProdutoController();
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
                pController.alterarProduto(produto);
                MessageBox.Show("Produto alterado com sucesso!");
            }
            catch (Exception)
            {
                MessageBox.Show("Algo inesperado aconteceu");
            }
           
        }

        private void voltarButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
