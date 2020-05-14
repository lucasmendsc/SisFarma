using SisFarma.model.DAO.PostgresqlDAO;
using SisFarma.view;
using System;
using System.Windows.Forms;

namespace UI
{
    static class Program
    {
        static void Main()
        {
            ClienteDAOPost c = new ClienteDAOPost();
            c.inserir(DateTime.Now,"nome1","cpf", "rg",
                    "sexo", "telefone","cep", "cidade", "logradouro");
            Application.EnableVisualStyles();
            Application.Run(new MainView());
        }
    }
}
