using System;
using System.Collections;
using System.Collections.Generic;

namespace SisFarma.model.classes
{
    class Pedido
    {
        private int id;
        private DateTime dataPedido;
        private ArrayList itensPedido;
        private int codCliente;
        private double valorTotal;
        private string status;

        public Pedido()
        {

        }
        public Pedido(int id,DateTime dataPedido,ArrayList itensPedido,
            int codCliente, double valorTotal,string status)
        {
            this.id = id;
            this.dataPedido = dataPedido;
            this.itensPedido = itensPedido;
            this.codCliente = codCliente;
            this.valorTotal = valorTotal;
            this.status = status;
        }

        public int Id {
            get { return id; }
            set { this.id = value; }
        }

        public DateTime DataPedido
        {
            get { return dataPedido; }
            set { this.dataPedido = value; }
        }

        public ArrayList ItensPedido
        {
            get { return itensPedido; }
            set { this.itensPedido = value; }
        }

        public int CodCliente
        {
            get { return codCliente; }
            set { this.codCliente = value; }
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
