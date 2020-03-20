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

        private void button2_Click(object sender, EventArgs e)
        {
            new ClienteView().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new ProdutoView().Show();
            
        }

        private void usuarioViewButton_Click(object sender, EventArgs e)
        {
            new UsuarioVIew().Show();
        }
    }
}
