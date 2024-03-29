﻿using System;
using System.Collections;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using SisFarma.model.classes;

namespace SisFarma.model.DAO
{
    class ProdutoDAO
    {
        private IFirebaseClient clientFireBase;
        private IFirebaseConfig config;
        public ProdutoDAO()
        {
            config = new FirebaseConfig();
            config.AuthSecret = "pYwmmuPIh0qsYJWrTOR6Go40JGhbS94zdr8MrzFR";
            config.BasePath = "https://appfarma-4fbcb.firebaseio.com/Produtos/";
            clientFireBase = new FireSharp.FirebaseClient(config);
        }

        public async void adicionarProduto(Produto produto)
        {
            try
            {
                SetResponse response = await clientFireBase.SetTaskAsync("P000" + produto.Id, produto);
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
                FirebaseResponse response = clientFireBase.Get("P000" + id);
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
                clientFireBase.Update("P000" + produto.Id, produto);
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
                clientFireBase.Delete("P000" + produto.Id);
            }
            catch (Exception exc)
            {
                Console.WriteLine("Ocorreu um erro ao deletar um produto" + "\n"
                    + exc.Message);
            }
        } 

        public ArrayList recuperarTodos()
        {

            int i = 1;
            CurrentIdDAO currentId = new CurrentIdDAO();
            int cont = currentId.recuperarQuantidade(2);
            ArrayList produtos = new ArrayList();

            while (true)
            {

                if (i == cont + 1)
                {
                    break;
                }

                try
                {
                    FirebaseResponse response = clientFireBase.Get("P000" + i);
                    produtos.Add(response.ResultAs<Produto>());
                }
                catch (Exception)
                {
                    continue;
                }
                finally
                {
                    i++;
                }
                
            }

            return produtos;
        }
    }
}
