using System;
using System.Collections;
using SisFarma.model.classes;
using SisFarma.model.DAO;

namespace SisFarma.controller.controllers
{
    class ProdutoController
    {
        ProdutoDAO produtoDAO;

        public ProdutoController()
        {
            produtoDAO = new ProdutoDAO();
        }

        public void adicionarProduto(Produto produto)
        {
            try
            {
                produtoDAO.adicionarProduto(produto);
            }
            catch (Exception exc)
            {
                Console.WriteLine("Ocorreu um erro ao inserir um produto" + "\n"
                    + exc.Message);
            }
        }
        public Produto recuperarPorId(int id)
        {
            try
            {
                return produtoDAO.recuperarProdutoId(id);
            }
            catch (Exception exc)
            {
                Console.WriteLine("Ocorreu um erro ao recuperar um pedido" + "\n"
                    + exc.Message);
                return null;
            }
        }
        public Produto recuperarPorDescricao(string descricao)
        {
            try
            {
                return produtoDAO.recuperarPorDescricao(descricao);
            }
            catch (Exception exc)
            {
                Console.WriteLine("Ocorreu um erro ao recuperar um pedido" + "\n"
                    + exc.Message);
                return null;
            }
        }
        public void alterarProduto(Produto produto)
        {
            try
            {
                produtoDAO.alterarProduto(produto);
            }
            catch (Exception exc)
            {
                Console.WriteLine("Ocorreu um erro ao alterar um produto" + "\n"
                    + exc.Message);
            }
        }

        public void deletarProduto(Produto produto)
        {
            try
            {
                produtoDAO.deletarProduto(produto);
            }
            catch (Exception exc)
            {
                Console.WriteLine("Ocorreu um erro ao deletar um produto" + "\n"
                    + exc.Message);
            }
        }

        public ArrayList recuperarTodos()
        {
            return produtoDAO.recuperarTodos();
        }
    }
}
