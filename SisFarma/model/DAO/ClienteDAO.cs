using System;
using SisFarma.model.classes;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System.Collections;

namespace SisFarma.model.DAO
{
    class ClienteDAO
    {
        private IFirebaseClient clientFireBase;
        private IFirebaseConfig config;

        public ClienteDAO()
        {
            config = new FirebaseConfig();
            config.AuthSecret = "pYwmmuPIh0qsYJWrTOR6Go40JGhbS94zdr8MrzFR";
            config.BasePath = "https://appfarma-4fbcb.firebaseio.com/Clientes/";
            clientFireBase = new FireSharp.FirebaseClient(config);
        }
        public async void adicionarCliente(Cliente cliente)
        {
            try
            {
                SetResponse response = await clientFireBase.SetTaskAsync("C000" + cliente.Id, cliente);

            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);

            }
        }

        public Cliente recuperarClienteId(int id)
        {

            try
            {
                FirebaseResponse response = clientFireBase.Get("C000" + id);
                return response.ResultAs<Cliente>();
            }
            catch (Exception exc)
            {
                Console.WriteLine("Ocorreu um erro ao recuperar um cliente " + exc.Message);
                return null;
            }
            
        }

        public void alterarCliente(Cliente cliente)
        {
            try
            {
                clientFireBase.Update("C000" + cliente.Id, cliente);

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
                clientFireBase.Delete("C000" + cliente.Id);

            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);

            }
        }

        public ArrayList recuperarTodos()
        {

        int i = 1;
        CurrentIdDAO currentId = new CurrentIdDAO();
        int cont = currentId.recuperarQuantidade(1);
        ArrayList clientes = new ArrayList() ;

            while (true)
                {

                if (i == cont + 2)
                {
                    break;
                }

                try
                {
                    FirebaseResponse response = clientFireBase.Get("C000" + i);
                    clientes.Add(response.ResultAs<Cliente>());
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

            return clientes;
        }

        public Cliente recuperarPorNome(string nome)
        {
            ArrayList clientes = this.recuperarTodos();

            foreach(Cliente cli in clientes)
            {
                if (cli.Nome.Equals(nome))
                {
                    return cli;
                }
            }

            return null;
        }

    }
}
