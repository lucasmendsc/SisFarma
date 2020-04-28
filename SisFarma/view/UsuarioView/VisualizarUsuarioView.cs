﻿using SisFarma.controller.controllers;
using SisFarma.model.classes;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace SisFarma.view.UsuarioView
{
    public partial class VisualizarUsuarioView : Form
    {
        private UsuarioController usuarioController;
        private CurrentIdController current;
        private DataTable dt;
        private int rowSelected;
        public VisualizarUsuarioView()
        {
            usuarioController = new UsuarioController();
            current = new CurrentIdController();
            this.dt = new DataTable();
            InitializeComponent();
            this.inicializarDataTable();
        }

        private void inicializarDataTable()
        {
            dt.Columns.Add("Nome");
            dt.Columns.Add("Login");

            dataGridView1.DataSource = dt;
            this.inicializarRows();
        }

        private void inicializarRows()
        {
            foreach (Usuario u in usuarioController.recuperarTodos())
            {
                DataRow row = dt.NewRow();
                row["Nome"] = u.Nome;
                row["Login"] = u.Login;

                dt.Rows.Add(row);
            }
        }

        private void recuperarButton_Click(object sender, EventArgs e)
        {

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