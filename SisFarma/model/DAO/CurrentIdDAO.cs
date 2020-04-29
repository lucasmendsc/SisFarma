using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using SisFarma.model.classes;
using System;

namespace SisFarma.model.DAO
{
    class CurrentIdDAO
    {
        private IFirebaseClient clientFireBase;
        private IFirebaseConfig config;

        public CurrentIdDAO()
        {
            config = new FirebaseConfig();
            config.AuthSecret = "pYwmmuPIh0qsYJWrTOR6Go40JGhbS94zdr8MrzFR";
            config.BasePath = "https://appfarma-4fbcb.firebaseio.com/";
            clientFireBase = new FireSharp.FirebaseClient(config);
        }
        public async void atualizarId(int cod)
        {
            try
            {
                CurrentId current = this.recuperarCurrentIds();
                switch (cod)
                {
                    case 1:
                        current.ClienteId++;
                        current.QuantCliente++;
                        break;

                    case 2:
                        current.ProdutoId++;
                        current.QuantoProduto++;
                        break;
                    case 3:
                        current.ItemPedidoId++;
                        current.QuantItemPedido++;
                        break;
                    case 4:
                        current.PedidoId++;
                        current.QuantPedido++;
                        break;
                    case 5:
                        current.UsuarioId++;
                        current.QuantUsuario++;
                        break;
                }
                SetResponse response = await clientFireBase.SetTaskAsync("CurrentId/", current);

            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);

            }
        }

        private CurrentId recuperarCurrentIds()
        {
            FirebaseResponse response = clientFireBase.Get("CurrentId");
            return response.ResultAs<CurrentId>();
        }
        public int recuperarId(int cod)
        {
            FirebaseResponse response = clientFireBase.Get("CurrentId");
            try
            {
                switch (cod)
                {
                    case 1:
                        return response.ResultAs<CurrentId>().ClienteId;
                    case 2:
                        return response.ResultAs<CurrentId>().ProdutoId;
                    case 3:
                        return response.ResultAs<CurrentId>().ItemPedidoId;
                    case 4:
                        return response.ResultAs<CurrentId>().PedidoId;
                    case 5:
                        return response.ResultAs<CurrentId>().UsuarioId;
                }

            }
            catch (Exception)
            {

            }
            return 0;
        }

        public int recuperarQuantidade(int cod)
        {
            FirebaseResponse response = clientFireBase.Get("CurrentId");
            try
            {
                switch (cod)
                {
                    case 1:
                        return response.ResultAs<CurrentId>().QuantCliente;
                    case 2:
                        return response.ResultAs<CurrentId>().QuantoProduto;
                    case 3:
                        return response.ResultAs<CurrentId>().QuantItemPedido;
                    case 4:
                        return response.ResultAs<CurrentId>().QuantPedido;
                    case 5:
                        return response.ResultAs<CurrentId>().QuantUsuario;
                }

            }
            catch (Exception)
            {

            }
            return 0;
        }

        public async void atualizarDeletados(int cod)
        {
            try
            {
                CurrentId current = this.recuperarCurrentIds();
                switch (cod)
                {
                    case 1:
                        current.QuantCliente--;
                        break;

                    case 2:
                        current.QuantoProduto--;
                        break;
                    case 3:
                        current.QuantItemPedido--;
                        break;
                    case 4:
                        current.QuantPedido--;
                        break;
                    case 5:
                        current.QuantUsuario--;
                        break;
                }
                SetResponse response = await clientFireBase.SetTaskAsync("CurrentId/", current);

            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);

            }
        }

        public async void zerarIds()
        {
            CurrentId current = new CurrentId(0, 0, 0, 0, 0);
            SetResponse response = await clientFireBase.SetTaskAsync("CurrentId/", current);
        }
    }
}
