using SisFarma.controller.controllers;
using SisFarma.model.classes;
using System.Collections;
using System.Data;
using System.Windows.Forms;

namespace SisFarma.view
{
    public partial class ProdutoMainView : Form
    {
        private DataTable dt;
        private ProdutoController produtoController;
        public ProdutoMainView()
        {
            dt = new DataTable();
            this.produtoController = new ProdutoController();
            InitializeComponent();
            this.inicializarDataTable();
        }

        private void inicializarDataTable()
        {
            dt.Columns.Add("Descrição");
            dt.Columns.Add("Preço");

            dataGridView2.DataSource = dt;
            this.inicializarRows();

        }

        private void inicializarRows()
        {
            foreach(Produto p in produtoController.recuperarTodos())
            {
                DataRow row = dt.NewRow();
                row["Descrição"] = p.Descricao;
                row["Preço"] = p.Valor;

                dt.Rows.Add(row);
            }
        }

    }
}
