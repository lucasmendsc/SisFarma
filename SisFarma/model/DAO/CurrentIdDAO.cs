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
        public async void atualizarClienteId()
        {
            try
            {
                CurrentId current = new CurrentId(2,3); 
                SetResponse response = await clientFireBase.SetTaskAsync("CurrentId/ClienteId",current);

            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);

            }
        }

        public async void atualizarProdutoId()
        {
            try
            {
                SetResponse response = await clientFireBase.SetTaskAsync("Produto", 1);

            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);

            }
        }
        public int recuperarId()
        {
            FirebaseResponse response = clientFireBase.Get("CurrentId");
            return response.ResultAs<CurrentId>().ClienteId;
        }
    }
}
