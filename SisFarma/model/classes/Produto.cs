namespace SisFarma.model.classes
{
    public class Produto
    {
        private int id;
        private string descricao;
        private double valor;
        private string foto;

        public Produto()
        {

        }
        public Produto(int id,string descricao,double valor,string foto)
        {
            this.id = id;
            this.descricao = descricao;
            this.valor = valor;
            this.foto = foto;
        }
        public int Id
        {
            get { return id; }
            set { this.id = value; }
        }

        public string Descricao
        {
            get { return this.descricao; }
            set { this.descricao = value; }
        }

        public double Valor
        {
            get { return this.valor; }
            set { this.valor = value; }
        }

        public string Foto
        {
            get { return this.foto; }
            set { this.foto = value; }
        }

    }
}