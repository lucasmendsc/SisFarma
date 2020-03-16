using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SisFarma.model.classes;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;

namespace SisFarma.controller.controllers
{
    class ProdutoController
    {
        IFirebaseClient clientFireBase;
        IFirebaseConfig config;

        public ProdutoController()
        {
            config = new FirebaseConfig();
            config.AuthSecret = "8q9WyVQfuvRecPJUNbYnl28QwNTosqxw1axFdWhu";
            config.BasePath = "https://sisfarmavitoria.firebaseio.com/SisFarma/Produtos/";
            clientFireBase = new FireSharp.FirebaseClient(config);
        }

        public async void adicionarProduto(Produto produto)
        {
            try
            {
                SetResponse response = await clientFireBase.SetTaskAsync("P" + produto.Id, produto);
                Produto result = response.ResultAs<Produto>();
            }
            catch (Exception exc)
            {
                Console.WriteLine("Ocorreu um erro ao inserir um produto" + "\n"
                    + exc.Message);
            }
        }
    }
}
