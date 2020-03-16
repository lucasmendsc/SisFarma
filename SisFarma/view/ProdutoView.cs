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

namespace SisFarma.view
{
    public partial class ProdutoView : Form
    {
        ProdutoController pController = new ProdutoController();
        public ProdutoView()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void adicionarProdutoButton_Click(object sender, EventArgs e)
        {
            try
            {
                Produto produtoAdicionado = new Produto(1, descricaoTextBox.Text, 2.5, "");
                pController.adicionarProduto(produtoAdicionado);

                MessageBox.Show("Produto cadastrado com sucesso!");

            }
            catch (Exception exc)
            {
                MessageBox.Show("Ocorreu um erro ao cadastar o produto " + exc.Message);
            }
        }

    }
}
