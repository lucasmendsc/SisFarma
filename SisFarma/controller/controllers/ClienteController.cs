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
    class ClienteController
    {
        IFirebaseClient clientFireBase;

        public ClienteController(){
            ConfigFireBase clientConfig = new ConfigFireBase();
            this.clientFireBase = clientConfig.getFireBaseCliente();
        }

        public async void adicionarCliente(Cliente cliente)
        {
            try
            {
                SetResponse response = await clientFireBase.SetTaskAsync("Cliente/", cliente);
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
