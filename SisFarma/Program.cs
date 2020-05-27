using SisFarma.controller.controllers.postgresql;
using SisFarma.model.classes;
using SisFarma.model.DAO.PostgresqlDAO;
using SisFarma.view;
using System.Windows.Forms;

namespace UI
{
    static class Program
    {
        static void Main()
        {
            ProdutoControllerPost p = new ProdutoControllerPost();
            p.alterar(new Produto(2, "pppppppppppppp","ppppp",6,"ppppppp"));
            Application.EnableVisualStyles();
            Application.Run(new MainView());
        }
    }
}
