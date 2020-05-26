using SisFarma.model.classes;
using SisFarma.model.DAO.PostgresqlDAO;
using System.Collections.Generic;

namespace SisFarma.controller.controllers.postgresql
{
    class ClienteControllerPost
    {
        private ClienteDAOPost clienteDaoPost;

        public ClienteControllerPost()
        {
            this.clienteDaoPost = new ClienteDAOPost();
        }

        public void inserir(Cliente cliente)
        {
            clienteDaoPost.inserir(cliente);
        }

        public void alterar(Cliente cliente)
        {
            clienteDaoPost.alterar(cliente);
        }

        public Cliente recuperarPorId(int id)
        {
            return clienteDaoPost.recuperarPorId(id);
        }

        public Cliente recuperarPorNome(string nome)
        {
            return clienteDaoPost.recuperarPorNome(nome);
        }

        public void deletar(int id)
        {
            clienteDaoPost.deletar(id);
        }

        public List<Cliente> recuperarTodos()
        {
            return this.clienteDaoPost.recuperarTodos();
        }
    }
}
