﻿using SisFarma.model.DAO;
using System;
using System.Collections.Generic;

namespace SisFarma.controller.controllers
{
    class CurrentIdController
    {
        private CurrentIdDAO currentDAO;
        public CurrentIdController()
        {
            this.currentDAO = new CurrentIdDAO();
        }

        public void atualizarId(int cod)
        {
            try
            {
                currentDAO.atualizarId(cod);

            }catch(Exception exc)
            {
                Console.WriteLine("Ocorreu um erro ao atualizar os id's"
                     + "\n" + exc.Message);
            }
        }

        public int recuperarId(int cod)
        {
            try
            {
                return currentDAO.recuperarId(cod);

            }
            catch (Exception exc)
            {
                Console.WriteLine("Ocorreu um erro ao recuperar os id's"
                     + "\n" + exc.Message);
                return 0;
            }
        }

        public void zerarIds()
        {
            try
            {
                currentDAO.zerarIds();

            }
            catch (Exception exc)
            {
                Console.WriteLine("Ocorreu um erro ao zerar os id's"
                     + "\n" + exc.Message);
            }
        }

        public void atualizarIdsDeletados(int id)
        {
            try
            {
                currentDAO.atualizarDeletados(id);

            }
            catch (Exception exc)
            {
                Console.WriteLine("Ocorreu um erro ao zerar os id's"
                     + "\n" + exc.Message);
            }
        }
    }
}
