using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SisFarma.model.classes;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;
using SisFarma.model.resouceBD;

namespace SisFarma.controller.controllers
{
    class ProdutoController
    {
        IFirebaseClient clientFireBase;

        public ProdutoController()
        {
            ConfigFireBase clientConfig = new ConfigFireBase();
            this.clientFireBase = clientConfig.getFireBaseCliente();
        }

        public async void adicionarProduto(Produto produto)
        {
            try
            {
                SetResponse response = await clientFireBase.SetTaskAsync("Produto/", produto);
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
