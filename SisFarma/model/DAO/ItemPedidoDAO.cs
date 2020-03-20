using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using SisFarma.model.classes;
using System;
using System.Collections;

namespace SisFarma.model.DAO
{
    class ItemPedidoDAO
    {
        private IFirebaseClient clientFireBase;
        private IFirebaseConfig config;
        public ItemPedidoDAO()
        {
            config = new FirebaseConfig();
            config.AuthSecret = "8q9WyVQfuvRecPJUNbYnl28QwNTosqxw1axFdWhu";
            config.BasePath = "https://sisfarmavitoria.firebaseio.com/SisFarma/ItensPedidos/";
            clientFireBase = new FireSharp.FirebaseClient(config);
        }

        public async void adicionarItemPedido(ItemPedido itemPedido)
        {
            try
            {
                SetResponse response = await clientFireBase.SetTaskAsync("I" + itemPedido.Id, itemPedido);
            }
            catch (Exception exc)
            {
                Console.WriteLine("Ocorreu um erro ao inserir um item Pedido" + "\n"
                    + exc.Message);
            }
        }

        public void alterarItemPedido(ItemPedido itemPedido)
        {
            try
            {
                clientFireBase.Update("I" + itemPedido.Id, itemPedido);
            }
            catch (Exception exc)
            {
                Console.WriteLine("Ocorreu um erro ao alterar um item Pedido" + "\n"
                    + exc.Message);
            }
        }

        public ItemPedido recuperarItemPedidoId(int id)
        {

            try
            {
                FirebaseResponse response = clientFireBase.Get("I" + id);
                return response.ResultAs<ItemPedido>();
            }
            catch (Exception exc)
            {
                Console.WriteLine("Ocorreu um erro ao recuperar um item Pedido " + exc.Message);
                return null;
            }

        }

        public void deletarItemPedido(ItemPedido pedido)
        {
            try
            {
                clientFireBase.Delete("I" + pedido.Id);
            }
            catch (Exception exc)
            {
                Console.WriteLine("Ocorreu um erro ao deletar um item Pedido" + "\n"
                    + exc.Message);
            }
        }

        public ArrayList recuperarTodos()
        {

            int i = 1;
            CurrentIdDAO currentId = new CurrentIdDAO();
            int cont = currentId.recuperarId(2);
            ArrayList itensPedidos = new ArrayList();
            while (true)
            {

                if (i >= cont - 1)
                {
                    break;
                }

                FirebaseResponse response = clientFireBase.Get("I" + i);
                ItemPedido itemProduto = response.ResultAs<ItemPedido>();

                itensPedidos.Add(itemProduto);

                i++;
            }

            return itensPedidos;
        }
    }
}
