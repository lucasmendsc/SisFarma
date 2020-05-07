using SisFarma.model.classes;
using System.Windows.Forms;

namespace SisFarma.view
{
    public partial class MostrarClienteView : Form
    {
        public MostrarClienteView(Cliente cliente)
        {
            InitializeComponent();
            nomeValorLabelText.Text = cliente.Nome;
            cpfValorLabelText.Text = cliente.CPF;
            rgValorLabelText.Text = cliente.Rg;
            dataNascimentoValorLabelText.Text = cliente.DataNasc.ToString();
            sexoValorLabelText.Text = cliente.Sexo;
            telefoneValorLabelText.Text = cliente.Telefone;
            cepValorLabelText.Text = cliente.CEP;
            cidadeValorLabelText.Text = cliente.Cidade;
            logradouroValorLabelText.Text = cliente.Logradouro;           
        }

        private void voltarButton_Click(object sender, System.EventArgs e)
        {
            this.Hide();
        }
    }
}
