using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisFarma.model.classes
{
    class CurrentId
    {
        private int clienteId;
        private int produtoId;
        private int pedidoId;
        private int itemPedidoId;
        private int usuarioId;
        private int quantCliente;
        private int quantProduto;
        private int quantPedido;
        private int quantItemPedido;
        private int quantUsuario;
        public CurrentId(int clienteId,int produtoId,int pedidoId,
            int itemPedidoId,int usuarioId)
        {
            this.clienteId = clienteId;
            this.produtoId = produtoId;
            this.pedidoId = pedidoId;
            this.itemPedidoId = itemPedidoId;
            this.usuarioId = usuarioId;
            this.atualizarQuantidade();
        }
        public CurrentId()
        {
        }
        public int ClienteId
        {
            get { return this.clienteId; }
            set { clienteId = value; }
        }
        public int ProdutoId
        {
            get { return this.produtoId; }
            set { produtoId = value; }
        }

        public int PedidoId
        {
            get { return this.pedidoId; }
            set { pedidoId = value; }
        }
        
        public int ItemPedidoId
        {
            get { return this.itemPedidoId; }
            set { itemPedidoId = value; }
        }

        public int UsuarioId
        {
            get { return this.usuarioId; }
            set { usuarioId = value; }
        }

        public int QuantCliente
        {
            get { return this.quantCliente; }
            set { quantCliente = value; }
        }
        public int QuantoProduto
        {
            get { return this.quantProduto; }
            set { quantProduto = value; }
        }
        public int QuantPedido
        {
            get { return this.quantPedido; }
            set { quantPedido = value; }
        }
        public int QuantItemPedido
        {
            get { return this.quantItemPedido; }
            set { quantItemPedido = value; }
        }  
        
        public int QuantUsuario
        {
            get { return this.quantUsuario; }
            set { quantUsuario = value; }
        }

        private void atualizarQuantidade()
        {
            this.quantCliente = this.clienteId;
            this.quantProduto = this.produtoId;
            this.quantPedido = this.pedidoId;
            this.quantItemPedido = this.itemPedidoId;
            this.quantUsuario = this.usuarioId;
        }
    }
}
