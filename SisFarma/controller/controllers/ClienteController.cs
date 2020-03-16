using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SisFarma.model.classes;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;

namespace SisFarma.controller.controllers
{
    class ClienteController
    {
        IFirebaseClient clientFireBase;
        IFirebaseConfig config;

        public ClienteController()
        {
            config = new FirebaseConfig();
            config.AuthSecret = "8q9WyVQfuvRecPJUNbYnl28QwNTosqxw1axFdWhu";
            config.BasePath = "https://sisfarmavitoria.firebaseio.com/SisFarma/Clientes/";
            clientFireBase = new FireSharp.FirebaseClient(config);
        }
            public async void adicionarCliente(Cliente cliente)
        {
            try
            {
                SetResponse response = await clientFireBase.SetTaskAsync("C"+cliente.Id, cliente);
                Cliente result = response.ResultAs<Cliente>();

            }
            catch (Exception exc)
            {
                Console.WriteLine("Ocorreu um erro ao inserir um cliente" + "\n"
                    + exc.Message);
            }
        }
    }
}
