using System;
using System.Collections;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using SisFarma.model.classes;

namespace SisFarma.model.DAO
{
    class ProdutoDAO
    {
        IFirebaseClient clientFireBase;
        IFirebaseConfig config;
        public ProdutoDAO()
        {
            config = new FirebaseConfig();
            config.AuthSecret = "8q9WyVQfuvRecPJUNbYnl28QwNTosqxw1axFdWhu";
            config.BasePath = "https://sisfarmavitoria.firebaseio.com/SisFarma/Produtos/";
            clientFireBase = new FireSharp.FirebaseClient(config);
        }

        public async void adicionarProduto(Produto produto)
        {
            try
            {
                SetResponse response = await clientFireBase.SetTaskAsync("P" + produto.Id, produto);
            }
            catch (Exception exc)
            {
                Console.WriteLine("Ocorreu um erro ao inserir um produto" + "\n"
                    + exc.Message);
            }
        }

        public Produto recuperarProdutoId(int id)
        {
            try
            {
                FirebaseResponse response = clientFireBase.Get("P" + id);
                return response.ResultAs<Produto>();

            }catch(Exception exc)
            {
                Console.WriteLine("Ocorreu um erro ao recuperar um produto" + "\n"
                    + exc.Message);
                return null;
            }
        }

        public Produto recuperarPorDescricao(string descricao)
        {
            ArrayList produtos = this.recuperarTodos();

            foreach (Produto prod in produtos)
            {
                if (prod.Descricao.Equals(descricao))
                {
                    return prod;
                }
            }

            return null;
        }

        public void alterarProduto(Produto produto)
        {
            try
            {
                clientFireBase.Update("P" + produto.Id, produto);
            }
            catch (Exception exc)
            {
                Console.WriteLine("Ocorreu um erro ao alterar um produto" + "\n"
                    + exc.Message);
            }
        }

        public void deletarProduto(Produto produto)
        {
            try
            {
                clientFireBase.Delete("P" + produto.Id);
            }
            catch (Exception exc)
            {
                Console.WriteLine("Ocorreu um erro ao deletar um produto" + "\n"
                    + exc.Message);
            }
        } 

        public ArrayList recuperarTodos()
        {

            int i = 0;
            CurrentIdDAO currentId = new CurrentIdDAO();
            int cont = currentId.recuperarId(2);
            ArrayList produtos = new ArrayList();
            while (true)
            {

                if (i >= cont - 1)
                {
                    break;
                }

                FirebaseResponse response = clientFireBase.Get("P" + i);
                Produto prod = response.ResultAs<Produto>();

                produtos.Add(prod);

                i++;
            }

            return produtos;
        }
    }
}
