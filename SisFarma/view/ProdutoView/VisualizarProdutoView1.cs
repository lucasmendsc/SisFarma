using SisFarma.model.classes;
using System.Windows.Forms;

namespace SisFarma.view.ProdutoView
{
    public partial class VisualizarProdutoView1 : Form
    {
        private Produto produto;
        public VisualizarProdutoView1()
        {
            InitializeComponent();
        }

        public void instanciarProduto(Produto produto)
        {
            this.produto = produto;
        }

        private void visualizarProduto()
        {
            precoLabelText.Text = "asd";
        }
    }
}
