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
            config.AuthSecret = "pYwmmuPIh0qsYJWrTOR6Go40JGhbS94zdr8MrzFR";
            config.BasePath = "https://appfarma-4fbcb.firebaseio.com/Pedidos/";
            clientFireBase = new FireSharp.FirebaseClient(config);
        }

        public async void adicionarPedido(Pedido pedido)
        {
            try
            {
                SetResponse response = await clientFireBase.SetTaskAsync("P000" + pedido.Id, pedido);
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
                clientFireBase.Update("P000" + pedido.Id, pedido);
            }
            catch (Exception exc)
            {
                Console.WriteLine("Ocorreu um erro ao alterar um pedido" + "\n"
                    + exc.Message);
            }
        }

        public Pedido recuperarProdutoId(int id)
        {

            try
            {
                FirebaseResponse response = clientFireBase.Get("P000" + id);
                return response.ResultAs<Pedido>();
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
                clientFireBase.Delete("P000" + pedido.Id);
            }
            catch (Exception exc)
            {
                Console.WriteLine("Ocorreu um erro ao deletar um pedido" + "\n"
                    + exc.Message);
            }
        }

        public ArrayList recuperarTodos(int opcao)
        {

            int i = 1;
            CurrentIdDAO currentId = new CurrentIdDAO();
            int cont = currentId.recuperarQuantidade(4);
            ArrayList produtos = new ArrayList();
            while (true)
            {

                if (i == cont - 1)
                {
                    break;
                }

                try
                {
                    FirebaseResponse response = clientFireBase.Get("P000" + i);
                    if (opcao == 1)
                    {
                        produtos.Add(response.ResultAs<Pedido>());
                    }else if(opcao == 2)
                    {
                        if(response.ResultAs<Pedido>().Status == 1)
                        produtos.Add(response.ResultAs<Pedido>());
                    }
                    else
                    {
                        if (response.ResultAs<Pedido>().Status == 2)
                            produtos.Add(response.ResultAs<Pedido>());
                    }
                    
                }
                catch (Exception)
                {
                    continue;
                }
                finally
                {
                    i++;
                }
               
            }

            return produtos;
        }
    }
}
