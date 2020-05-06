using SisFarma.controller.controllers;
using SisFarma.model.classes;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace SisFarma.view.UsuarioView
{
    public partial class MainUsuarioView : Form
    {
        private UsuarioController usuarioController;
        private CurrentIdController current;
        private DataTable dt;
        private int rowSelected;
        public MainUsuarioView()
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
            try
            {
                Usuario usuario =
                    usuarioController.recuperarUsuarioPorNome(recuperarTextBox.Text);

            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao recuperar o usuário.");
            }

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {

                rowSelected = e.RowIndex;

                if (rowSelected < 0)
                {
                    MessageBox.Show("Selecione uma linha!");
                }

            }
        }

        private void deletarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                usuarioController.deletarUsuario
                      (usuarioController.recuperarUsuarioId(rowSelected + 1));
                current.atualizarIdsDeletados(5);
                MessageBox.Show("Usuario deletado com sucesso!");

            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao deletar o usuário. ");
            }
        }
    }
}
