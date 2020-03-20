namespace SisFarma.model.classes
{
    internal class ItemPedido
    {
        private int id;
        private int codProduto;
        private int quantidade;
        private double subTotal;

        public ItemPedido(int id,int codProduto, int quantidade,
            double subTotal)
        {
            this.id = id;
            this.codProduto = codProduto;
            this.quantidade = quantidade;
            this.subTotal = subTotal;
        }
        public ItemPedido()
        {

        }
        public int Id
        {
            get { return id; }
            set { this.id = value; }
        }

        public int CodProduto
        {
            get { return this.codProduto; }
            set { this.codProduto = value; }
        }

        public int Quantidade
        {
            get { return this.quantidade; }
            set { this.quantidade = value; }
        }
        public double SubTotal
        {
            get { return this.subTotal; }
            set { this.subTotal = value; }
        }
    }
}