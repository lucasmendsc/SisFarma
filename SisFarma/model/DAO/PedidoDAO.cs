using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using SisFarma.model.classes;
using System;
using System.Collections;

namespace SisFarma.model.DAO
{
    class PedidoDAO
    {
        private IFirebaseClient clientFireBase;
        private IFirebaseConfig config;
        public PedidoDAO()
        {
            config = new FirebaseConfig();
            config.AuthSecret = "8q9WyVQfuvRecPJUNbYnl28QwNTosqxw1axFdWhu";
            config.BasePath = "https://sisfarmavitoria.firebaseio.com/SisFarma/Pedidos/";
            clientFireBase = new FireSharp.FirebaseClient(config);
        }

        public async void adicionarPedido(Pedido pedido)
        {
            try
            {
                SetResponse response = await clientFireBase.SetTaskAsync("P" + pedido.Id, pedido);
            }
            catch (Exception exc)
            {
                Console.WriteLine("Ocorreu um erro ao inserir um pedido" + "\n"
                    + exc.Message);
            }
        }

        public void alterarPedido(Pedido pedido)
        {
            try
            {
                clientFireBase.Update("P" + pedido.Id, pedido);
            }
            catch (Exception exc)
            {
                Console.WriteLine("Ocorreu um erro ao alterar um pedido" + "\n"
                    + exc.Message);
            }
        }

        public Produto recuperarProdutoId(int id)
        {

            try
            {
                FirebaseResponse response = clientFireBase.Get("P" + id);
                return response.ResultAs<Produto>();
            }
            catch (Exception exc)
            {
                Console.WriteLine("Ocorreu um erro ao recuperar um produto " + exc.Message);
                return null;
            }

        }

        public void deletarPedido(Pedido pedido)
        {
            try
            {
                clientFireBase.Delete("P" + pedido.Id);
            }
            catch (Exception exc)
            {
                Console.WriteLine("Ocorreu um erro ao deletar um pedido" + "\n"
                    + exc.Message);
            }
        }

        public ArrayList recuperarTodos()
        {

            int i = 1;
            CurrentIdDAO currentId = new CurrentIdDAO();
            int cont = currentId.recuperarId(4);
            ArrayList produtos = new ArrayList();
            while (true)
            {

                if (i >= cont - 1)
                {
                    break;
                }

                FirebaseResponse response = clientFireBase.Get("P" + i);
                Produto prod = response.ResultAs<Produto>();

                produtos.Add(prod);

                i++;
            }

            return produtos;
        }
    }
}
