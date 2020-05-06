using SisFarma.model.classes;
using System.Windows.Forms;

namespace SisFarma.view
{
    public partial class MostrarProdutoView : Form
    {
        public MostrarProdutoView()
        {
        }

        public MostrarProdutoView(Produto p)
        {
            InitializeComponent();
            descricaoValorLabelText.Text = p.Descricao;
            precoValorLabelText.Text = p.Valor.ToString();
        }
    }
}
