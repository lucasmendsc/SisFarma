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

                rowSelected = dataGridView1.HitTest(e.X, e.Y).RowIndex;

                if (rowSelected >= 0)
                {
                    MessageBox.Show("Selecione uma linha!");
                }

            }
        }
}
