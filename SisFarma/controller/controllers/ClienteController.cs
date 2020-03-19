using System;
using SisFarma.model.classes;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;
using SisFarma.model.DAO;
using System.Collections;

namespace SisFarma.controller.controllers
{
    class ClienteController
    {
        ClienteDAO clienteDAO;

        public ClienteController()
        {
            clienteDAO = new ClienteDAO();
        }
            public void adicionarCliente(Cliente cliente)
        {
            try
            {
                clienteDAO.adicionarCliente(cliente);

            }
            catch (Exception exc)
            {
                Console.WriteLine("Ocorreu um erro ao inserir um cliente" + "\n"
                    + exc.Message);
            }
        }

        public Cliente recuperarCliente(int id)
        {
            try
            {
                return clienteDAO.recuperarClienteId(id);
            }
            catch (Exception exc)
            {
                Console.WriteLine( exc.Message);
            }
            return null;
        }

        public void alterarCliente(Cliente cliente)
        {
            try
            {
                clienteDAO.alterarCliente(cliente);
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
                clienteDAO.deletarCliente(cliente);
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }
        }

        public ArrayList recuperarTodos()
        {
            return clienteDAO.recuperarTodos();
        }

        public Cliente recuperarPorNome(string nome)
        {
            return clienteDAO.recuperarPorNome(nome);
        }
    }
}
