using SisFarma.model.classes;
using System.Windows.Forms;

namespace SisFarma.view
{
    public partial class MostrarUsuarioView : Form
    {
        public MostrarUsuarioView(Usuario usuario)
        {
            InitializeComponent();
            nomeValorLabelText.Text = usuario.Nome;
            loginValorLabelText.Text = usuario.Login;
        }

        private void voltarButton_Click(object sender, System.EventArgs e)
        {
            this.Hide();
        }
    }
}
