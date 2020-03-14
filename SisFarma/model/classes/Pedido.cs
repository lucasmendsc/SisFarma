using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisFarma.model.classes
{
    class Pedido
    {
        private int id;
        private DateTime dataPedido;
        private List<ItemPedido> itensPedido;
        private Cliente cliente;
        private double valorTotal;
        private string status;

        public int Id {
            get { return id; }
            set { this.id = value; }
        }

        public DateTime DataPedido
        {
            get { return dataPedido; }
            set { this.dataPedido = value; }
        }

        public List<ItemPedido> ItensPedido
        {
            get { return itensPedido; }
            set { this.itensPedido = value; }
        }

        public Cliente Cliente
        {
            get { return cliente; }
            set { this.cliente = value; }
        }

        public double ValorTotal
        {
            get { return valorTotal; }
            set { this.valorTotal = value; }
        }

        public string Status
        {
            get { return status; }
            set { this.status = value; }
        }
    }
}
