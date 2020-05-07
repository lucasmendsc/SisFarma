using SisFarma.model.classes;
using System.Windows.Forms;

namespace SisFarma.view
{
    public partial class MostrarProdutoView : Form
    {
        public MostrarProdutoView(Produto produto)
        {
            InitializeComponent();
            descricaoValorLabelText.Text = produto.Descricao;
            precoValorLabelText.Text = produto.Valor.ToString();
        }

        private void voltarButton_Click(object sender, System.EventArgs e)
        {
            this.Hide();
        }
    }
}
