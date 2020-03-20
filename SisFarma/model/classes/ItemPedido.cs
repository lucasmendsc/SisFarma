namespace SisFarma.model.classes
{
    internal class ItemPedido
    {
        private int id;
        private Produto produto;
        private int quantidade;
        private double subTotal;

        public ItemPedido(int id,Produto produto,int quantidade,
            double subTotal)
        {
            this.id = id;
            this.produto = produto;
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

        public Produto Produto
        {
            get { return this.produto; }
            set { this.produto = value; }
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