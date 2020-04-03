using SisFarma.view.ClienteView;
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
            new view.ClienteView.AdicionarClienteView().Show();
        }

        private void visualizarClienteMenu_Click(object sender, EventArgs e)
        {
            new view.ClienteView.VisualizarClienteView().Show();
        }

        private void cadastrarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            new AdicionarProdutoView().Show();
        }

        private void visualizarUsuarioToolStripMenuItem2_Click(object sender, EventArgs e)
        {
        }

        private void cadastrarPedidoMenuItem_Click(object sender, EventArgs e)
        {

        }


    }
}
