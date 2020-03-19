using SisFarma.model.classes;
using SisFarma.model.DAO;
using System;

namespace SisFarma.controller.controllers
{
    class PedidoController
    {
        PedidoDAO pedidoDAO;

        public PedidoController()
        {
            pedidoDAO = new PedidoDAO();
        }

        public void adicionarPedido(Pedido pedido)
        {
            try
            {
                pedidoDAO.adicionarPedido(pedido);
            }
            catch (Exception exc)
            {
                Console.WriteLine("Ocorreu um erro ao inserir um pedido" + "\n"
                    + exc.Message);
            }
        }

        public void alterarPedido(Pedido pedido)
        {
            try
            {
                pedidoDAO.alterarPedido(pedido);
            }
            catch (Exception exc)
            {
                Console.WriteLine("Ocorreu um erro ao alterar um pedido" + "\n"
                    + exc.Message);
            }
        }

        public void deletarPedido(Pedido pedido)
        {
            try
            {
                pedidoDAO.deletarPedido(pedido);
            }
            catch (Exception exc)
            {
                Console.WriteLine("Ocorreu um erro ao deletar um pedido" + "\n"
                    + exc.Message);
            }
        }
    }
}
