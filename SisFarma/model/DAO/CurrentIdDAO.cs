using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using SisFarma.model.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisFarma.model.DAO
{
    class CurrentIdDAO
    {
        private IFirebaseClient clientFireBase;
        private IFirebaseConfig config;
        public CurrentId current;

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
        public int recuperarId(int id)
        {
            FirebaseResponse response = clientFireBase.Get("CurrentId");
            try
            {
                switch (id)
                {
                    case 1:
                        return response.ResultAs<CurrentId>().ClienteId;

                    case 2:
                        return response.ResultAs<CurrentId>().ProdutoId;
                }


            }
            catch (Exception)
            {

            }
            return 0;
        }
    }
}
