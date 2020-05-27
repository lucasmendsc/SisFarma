using SisFarma.model.classes;
using SisFarma.model.DAO.PostgresqlDAO;
using System.Collections.Generic;

namespace SisFarma.controller.controllers.postgresql
{
    class ProdutoControllerPost
    {

            private ProdutoDAOPost produtoDaoPost;

            public ProdutoControllerPost()
            {
                this.produtoDaoPost = new ProdutoDAOPost();
            }

            public void inserir(Produto produto)
            {
                produtoDaoPost.inserir(produto);
            }

            public void alterar(Produto produto)
            {
                produtoDaoPost.alterar(produto);
            }

            public Produto recuperarPorId(int id)
            {
                return produtoDaoPost.recuperarPorId(id);
            }

            public Produto recuperarPorNome(string nome)
            {
                return produtoDaoPost.recuperarPorNome(nome);
            }

            public void deletar(int id)
            {
                produtoDaoPost.deletar(id);
            }

            public List<Produto> recuperarTodos()
            {
                return this.produtoDaoPost.recuperarTodos();
            }
        
    }
}
