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
            config.AuthSecret = "8q9WyVQfuvRecPJUNbYnl28QwNTosqxw1axFdWhu";
            config.BasePath = "https://sisfarmavitoria.firebaseio.com/SisFarma/";
            clientFireBase = new FireSharp.FirebaseClient(config);
        }
        public async void atualizarId(int id)
        {
            try
            {
                CurrentId current = this.recuperarCurrentIds();
                switch (id)
                {
                    case 1:
                        current.ClienteId++;
                        break;

                    case 2:
                        current.ProdutoId++;
                        break;
                    case 3:
                        current.ItemPedidoId++;
                        break;
                    case 4:
                        current.PedidoId++;
                        break;
                    case 5:
                        current.UsuarioId++;
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

        public async void zerarIds()
        {
            CurrentId current = new CurrentId(0, 0, 0, 0, 0);
            SetResponse response = await clientFireBase.SetTaskAsync("CurrentId/", current);
        }
    }
}
