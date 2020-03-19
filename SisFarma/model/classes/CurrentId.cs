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

        public CurrentId(int clienteId,int produtoId)
        {
            this.clienteId = clienteId;
            this.produtoId = produtoId;
        }

        public CurrentId(int clienteId)
        {
            this.clienteId = clienteId;
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
    }
}
