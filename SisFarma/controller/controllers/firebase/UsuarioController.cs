using SisFarma.model.classes;
using SisFarma.model.DAO;
using System;
using System.Collections;

namespace SisFarma.controller.controllers
{
    class UsuarioController
    {
        private UsuarioDAO usuarioDAO;
        public UsuarioController()
        {
            usuarioDAO = new UsuarioDAO();
        }

        public void adicionarUsuario(Usuario usuario)
        {
            try
            {
                usuarioDAO.adicionarUsuario(usuario);
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
                usuarioDAO.alterarUsuario(usuario);
            }
            catch (Exception exc)
            {
                Console.WriteLine("Ocorreu um erro ao alterar um usuario" + "\n"
                    + exc.Message);
            }
        }

        public Usuario recuperarUsuarioId(int id)
        {
            try
            {
                return usuarioDAO.recuperarUsuarioId(id);
            }
            catch (Exception exc)
            {
                Console.WriteLine("Ocorreu um erro ao alterar um usuario" + "\n"
                    + exc.Message);
                return null;
            }
        }

        public Usuario recuperarUsuarioPorNome(string nome)
        {
            try
            {
                return usuarioDAO.recuperarPorNome(nome);
            }
            catch (Exception exc)
            {
                Console.WriteLine("Ocorreu um erro ao alterar um usuario" + "\n"
                    + exc.Message);
                return null;
            }
        }

        public void deletarUsuario(Usuario usuario)
        {
            try
            {
                usuarioDAO.deletarUsuario(usuario);
            }
            catch (Exception exc)
            {
                Console.WriteLine("Ocorreu um erro ao deletar um usuario" + "\n"
                    + exc.Message);
            }
        }

        public ArrayList recuperarTodos()
        {
            return usuarioDAO.recuperarTodos();
        }

        public bool logar(string login,string senha)
        {
            return usuarioDAO.logar(login, senha);
        }
    }
}
