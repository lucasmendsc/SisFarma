﻿using System;
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
        public CurrentId(int clienteId,int produtoId,int pedidoId,
            int itemPedidoId,int usuarioId)
        {
            this.clienteId = clienteId;
            this.produtoId = produtoId;
            this.pedidoId = pedidoId;
            this.itemPedidoId = itemPedidoId;
            this.usuarioId = usuarioId;
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
    }
}
