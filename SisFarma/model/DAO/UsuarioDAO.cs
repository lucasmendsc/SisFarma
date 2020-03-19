using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using SisFarma.model.classes;
using System;

namespace SisFarma.model.DAO
{
    class UsuarioDAO
    {
        IFirebaseClient clientFireBase;
        IFirebaseConfig config;

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
                SetResponse response = await clientFireBase.SetTaskAsync("U" + usuario.Id, usuario);
            }
            catch (Exception exc)
            {
                Console.WriteLine("Ocorreu um erro ao inserir um usuario" + "\n"
                    + exc.Message);
            }
        }

        public void alterarUsuario(Usuario usuario)
        {
            try
            {
                clientFireBase.Update("P" + usuario.Id, usuario);
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
    }
}
