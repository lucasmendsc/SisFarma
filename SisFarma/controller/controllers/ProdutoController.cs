using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SisFarma.model.classes;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;
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

        public async void adicionarProduto(Produto produto)
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
    }
}
