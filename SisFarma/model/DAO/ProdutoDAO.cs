using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using SisFarma.model.classes;

namespace SisFarma.model.DAO
{
    class ProdutoDAO
    {
        IFirebaseClient clientFireBase;
        IFirebaseConfig config;

        public ProdutoDAO()
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
            }
            catch (Exception exc)
            {
                Console.WriteLine("Ocorreu um erro ao inserir um produto" + "\n"
                    + exc.Message);
            }
        }
    }
}
