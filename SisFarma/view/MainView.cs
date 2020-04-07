using SisFarma.view.ClienteView;
using System;
using System.Windows.Forms;

namespace SisFarma.view
{
    public partial class MainView : Form
    {
        public MainView()
        {
            InitializeComponent();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AdicionarProdutoView().Show();
        }

        private void visualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ProdutoView().Show();
        }

        private void cadastrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new AdicionarClienteView().Show();
        }

        private void visualizarClienteMenu_Click(object sender, EventArgs e)
        {
            new VisualizarClienteView().Show();
        }

        private void cadastrarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            new UsuarioView.AdicionarUsuarioView().Show();
        }

        private void visualizarUsuarioToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            new UsuarioView.VisualizarUsuarioView().Show();
        }

        private void cadastrarPedidoMenuItem_Click(object sender, EventArgs e)
        {
            new PedidoView.AdicionarPedidoView().Show();
        }

        private void visualizarPedidosMenuItem_Click(object sender, EventArgs e)
        {
            new PedidoView.VisualizarPedidoView().Show();
        }
    }
}
