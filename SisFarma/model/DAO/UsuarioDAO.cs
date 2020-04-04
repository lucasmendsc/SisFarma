using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using SisFarma.model.classes;
using System;
using System.Collections;

namespace SisFarma.model.DAO
{
    class UsuarioDAO
    {
        private IFirebaseClient clientFireBase;
        private IFirebaseConfig config;

        public UsuarioDAO()
        {
            config = new FirebaseConfig();
            config.AuthSecret = "8q9WyVQfuvRecPJUNbYnl28QwNTosqxw1axFdWhu";
            config.BasePath = "https://sisfarmavitoria.firebaseio.com/SisFarma/Usuarios/";
            clientFireBase = new FireSharp.FirebaseClient(config);
        }

        public async void adicionarUsuario(Usuario usuario)
        {
            try
            {
                SetResponse response = await clientFireBase.SetTaskAsync("U000" + usuario.Id, usuario);
            }
            catch (Exception exc)
            {
                Console.WriteLine("Ocorreu um erro ao inserir um usuario" + "\n"
                    + exc.Message);
            }
        }

        public Usuario recuperarUsuarioId(int id)
        {
            try
            {
                FirebaseResponse response = clientFireBase.Get("U000" + id);
                return response.ResultAs<Usuario>();
            }
            catch (Exception exc)
            {
                Console.WriteLine("Ocorreu um erro ao alterar um usuario" + "\n"
                    + exc.Message);
                return null;
            }
        }

        public Usuario recuperarPorNome(string login)
        {
            ArrayList usuarios = this.recuperarTodos();

            foreach (Usuario user in usuarios)
            {
                if (user.Login.Equals(login))
                {
                    return user;
                }
            }

            return null;
        }

        public void alterarUsuario(Usuario usuario)
        {
            try
            {
                clientFireBase.Update("U" + usuario.Id, usuario);
            }
            catch (Exception exc)
            {
                Console.WriteLine("Ocorreu um erro ao alterar um usuario" + "\n"
                    + exc.Message);
            }
        }

        public void deletarUsuario(Usuario usuario)
        {
            try
            {
                clientFireBase.Delete("U" + usuario.Id);
            }
            catch (Exception exc)
            {
                Console.WriteLine("Ocorreu um erro ao deletar um usuario" + "\n"
                    + exc.Message);
            }
        }

        public ArrayList recuperarTodos()
        {

            int i = 1;
            CurrentIdDAO currentId = new CurrentIdDAO();
            int cont = currentId.recuperarQuantidade(5);
            ArrayList usuarios = new ArrayList();
            while (true)
            {

                if (i >= cont - 1)
                {
                    break;
                }

                try
                {
                    FirebaseResponse response = clientFireBase.Get("U" + i);
                    usuarios.Add(response.ResultAs<Usuario>());
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

            return usuarios;
        }

        public bool logar(string login, string senha)
        {
            ArrayList usuarios = this.recuperarTodos();

            foreach(Usuario user in usuarios)
            {
                if (user.Login.Equals(login) && user.Senha.Equals(senha))
                    return true;
            }
            return false;
        }

    }

}
