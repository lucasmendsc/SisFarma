using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using SisFarma.model.classes;
using System;

namespace SisFarma.model.DAO
{
    class PedidoDAO
    {
        IFirebaseClient clientFireBase;
        IFirebaseConfig config;
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
    }
}
