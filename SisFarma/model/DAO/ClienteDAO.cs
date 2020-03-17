using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using SisFarma.model.classes;

namespace SisFarma.model.DAO
{
    class ClienteDAO
    {
        private IFirebaseClient clientFireBase;
        private IFirebaseConfig config;
        private Cliente clienteRetorno;

        public ClienteDAO()
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
                SetResponse response = await clientFireBase.SetTaskAsync("C" + cliente.Id, cliente);

            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);

            }
        }

        private async void recuperarClienteBD(int id)
        {

            try
            {
                FirebaseResponse response = await clientFireBase.GetTaskAsync("C1");
                this.clienteRetorno = response.ResultAs<Cliente>();
            }
            catch (Exception exc)
            {
                Console.WriteLine("Ocorreu um erro ao recuperar um cliente " + exc.Message);
            }
            
        }

        public Cliente recuperarCliente(int id)
        {
            this.recuperarClienteBD(id);
            return this.clienteRetorno;
        }

        public void alterarCliente(Cliente cliente)
        {
            try
            {
                clientFireBase.Update("C" + cliente.Id, cliente);

            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);

            }
        }

        public void deletarCliente(Cliente cliente)
        {

            try
            {
                clientFireBase.Delete("C" + cliente.Id);

            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);

            }
        }

    }
}
