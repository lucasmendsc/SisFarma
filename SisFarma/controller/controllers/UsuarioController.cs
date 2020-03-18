using SisFarma.model.classes;
using SisFarma.model.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisFarma.controller.controllers
{
    class UsuarioController
    {
        UsuarioDAO usuarioDAO;

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
    }
}
