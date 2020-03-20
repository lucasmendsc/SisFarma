using SisFarma.model.classes;
using SisFarma.model.DAO;
using SisFarma.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            PedidoDAO pedidoD = new PedidoDAO();
            pedidoD.adicionarPedido(new Pedido());
             Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainView());

        }
    }
}
