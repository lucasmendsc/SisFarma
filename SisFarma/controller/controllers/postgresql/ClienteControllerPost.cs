using Npgsql;
using SisFarma.model.classes;
using SisFarma.model.DAO.PostgresqlDAO;

namespace SisFarma.controller.controllers.postgresql
{
    class ClienteControllerPost
    {
        private ClienteDAOPost clienteDAO;
        private static ClienteControllerPost instance;

        public ClienteControllerPost()
        {
            clienteDAO = new ClienteDAOPost();
            instance = getInstance();
        }

        public static ClienteControllerPost getInstance()
        {
            if (instance == null)
            {
                instance = new ClienteControllerPost();
            }
            return instance;
        }

        public void inserir(Cliente cliente)
        {
            this.clienteDAO.inserir(cliente);
        }

        public NpgsqlDataReader recuperarTodos()
        {
            return this.clienteDAO.recuperarTodos();
        }
    }
}
