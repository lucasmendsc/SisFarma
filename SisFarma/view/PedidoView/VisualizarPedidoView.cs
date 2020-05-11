using SisFarma.controller.controllers;
using SisFarma.model.classes;
using System;
using System.Data;
using System.Windows.Forms;

namespace SisFarma.view.PedidoView
{
    public partial class VisualizarPedidoView : Form
    {
        private PedidoController pedidoController;
        private CurrentIdController current;
        private DataTable dt;
        private DataTable dt1;
        private DataTable dt2;
        private int rowSelected;
        public VisualizarPedidoView()
        {
            InitializeComponent();
            this.pedidoController = new PedidoController();
            this.current = new CurrentIdController();
            this.dt = new DataTable();
            this.dt1 = new DataTable();
            this.dt2 = new DataTable();
        }

        private void inicializarataTable()
        {
            dt.Columns.Add("Id");
            dt.Columns.Add("Data Pedido");
            dt.Columns.Add("Itens");
            dt.Columns.Add("Valor Total");            
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["Id"].Visible = false;

            dt1.Columns.Add("Id");
            dt1.Columns.Add("Data Pedido");
            dt1.Columns.Add("Itens");
            dt1.Columns.Add("Valor Total");
            dataGridView2.DataSource = dt1;
            dataGridView2.Columns["Id"].Visible = false;


            dt2.Columns.Add("Id");
            dt2.Columns.Add("Data Pedido");
            dt2.Columns.Add("Itens");
            dt2.Columns.Add("Valor Total");
            dataGridView3.DataSource = dt2;
            dataGridView3.Columns["Id"].Visible = false;

            this.inicializarRows();
        }

        private void inicializarRows()
        {
            foreach(Pedido p in pedidoController.recuperarTodos(1))
            {
                DataRow row = dt.NewRow();
                row["Id"] = p.Id;
                row["Data Pedido"] = p.DataPedido.ToString();
                row["Itens"] = "";
                row["Valor Total"] = p.ValorTotal;
                dt.Rows.Add(row);
            }

            foreach (Pedido p in pedidoController.recuperarTodos(2))
            {
                DataRow row = dt1.NewRow();
                row["Id"] = p.Id;
                row["Data Pedido"] = p.DataPedido.ToString();
                row["Itens"] = "";
                row["Valor Total"] = p.ValorTotal;
                dt1.Rows.Add(row);
            }

            foreach (Pedido p in pedidoController.recuperarTodos(3))
            {
                DataRow row = dt2.NewRow();
                row["Id"] = p.Id;
                row["Data Pedido"] = p.DataPedido.ToString();
                row["Itens"] = "";
                row["Valor Total"] = p.ValorTotal;
                dt2.Rows.Add(row);
            }
        }

        private int retornarId()
        {
            DataGridViewRow selectedRow = dataGridView1.Rows[rowSelected];
            return Convert.ToInt32(selectedRow.Cells["Id"].Value);
        }
    }
}
