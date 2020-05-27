using SisFarma.controller.controllers;
using SisFarma.controller.controllers.postgresql;
using SisFarma.model.classes;
using System;
using System.Windows.Forms;

namespace SisFarma.view
{
    public partial class AdicionarProdutoView : Form
    {
        private CurrentIdController current;
        private ProdutoController pController;
        private ProdutoControllerPost produtoControllerPost;
        public AdicionarProdutoView()
        {
            this.current = new CurrentIdController();
            this.pController = new ProdutoController();
            this.produtoControllerPost = new ProdutoControllerPost();
            InitializeComponent();
        }

        private void adicionarButton_Click(object sender, EventArgs e)
        {
            try
            {
                
                produtoControllerPost.inserir(
                    new Produto
                            (3,nomeTextBox.Text, descricaoTextBox.Text, 
                                Convert.ToDouble(valorTextBox.Text), ""));
                
                MessageBox.Show("Produto cadastrado com sucesso!");
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao cadastar o produto ");
            }
        }

        private void voltarButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void valorTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ',')
            {
                e.Handled = false;
                return;
            }

            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
                e.Handled = true;
        }
    }
}
