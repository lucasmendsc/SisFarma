using SisFarma.model.classes;
using SisFarma.model.DAO.PostgresqlDAO;
using System.Collections.Generic;

namespace SisFarma.controller.controllers.postgresql
{
    class UsuarioControllerPost
    {
        private UsuarioDAOPost UsuarioDaoPost;

        public UsuarioControllerPost()
        {
            this.UsuarioDaoPost = new UsuarioDAOPost();
        }

        public void inserir(Usuario usuario)
        {
            UsuarioDaoPost.inserir(usuario);
        }

        public void alterar(Usuario usuario)
        {
            UsuarioDaoPost.alterar(usuario);
        }

        public Usuario recuperarPorId(int id)
        {
            return UsuarioDaoPost.recuperarPorId(id);
        }

        public Usuario recuperarPorNome(string nome)
        {
            return UsuarioDaoPost.recuperarPorNome(nome);
        }

        public void deletar(int id)
        {
            UsuarioDaoPost.deletar(id);
        }

        public List<Usuario> recuperarTodos()
        {
            return this.UsuarioDaoPost.recuperarTodos();
        }
    }

}
