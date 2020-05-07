namespace SisFarma.model.classes
{
    public class Usuario
    {
        private int id;
        private string nome;
        private string login;
        private string senha;

        public Usuario()
        {

        }

        public Usuario(int id,string nome,string login,string senha)
        {
            this.id = id;
            this.nome = nome;
            this.login = login;
            this.senha = senha;

        }
        public int Id {
            get { return id; }
            set { this.id = value; }
        }

        public string Nome
        {
            get { return this.nome; }
            set { this.nome = value; }
        }

        public string Login
        {
            get { return this.login; }
            set { this.login = value; }
        }

        public string Senha
        {
            get { return this.senha; }
            set { this.senha = value; }
        }
    }
}
