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
        private int rowSelected;
        public VisualizarPedidoView()
        {
            InitializeComponent();
            this.pedidoController = new PedidoController();
            this.current = new CurrentIdController();
            this.dt = new DataTable();
        }

        private void inicializarataTable()
        {
            dt.Columns.Add("Id");
            dt.Columns.Add("Data Pedido");
            dt.Columns.Add("Itens");
            dt.Columns.Add("Valor Total");            
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["Id"].Visible = false;
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
        }

        private int retornarId()
        {
            DataGridViewRow selectedRow = dataGridView1.Rows[rowSelected];
            return Convert.ToInt32(selectedRow.Cells["Id"].Value);
        }

    }
}
