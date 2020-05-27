using Npgsql;
using SisFarma.model.classes;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SisFarma.model.DAO.PostgresqlDAO
{
    class UsuarioDAOPost
    {
        private NpgsqlConnection connection;

        public UsuarioDAOPost()
        {
            this.connection = PostgreSqlCon.getCon();
        }

        public void inserir(Usuario usuario)
        {
            try
            {
                connection.Open();
                string inserirSql = String.Format("Insert Into Usuarios" +
                    "(id,nome,login,senha)" + " values('{0}','{1}','{2}','{3}')",
                    usuario.Id, usuario.Nome, usuario.Login, usuario.Senha);

                using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(inserirSql, connection))
                {
                    pgsqlcommand.ExecuteNonQuery();
                }

            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.ToString());
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        public void alterar(Usuario usuario)
        {
            try
            {
                connection.Open();
                string alterarSql = String.Format("update Usuarios set nome = '" + usuario.Nome + "'"
                    + ",login = '" + usuario.Login + "'" + ",senha = '" + usuario.Senha + "'"
                    + "where id = '" + usuario.Id + "'");
                using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(alterarSql, connection))
                {
                    pgsqlcommand.ExecuteNonQuery();
                }

            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.ToString());
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        public Usuario recuperarPorId(int id)
        {

            try
            {
                connection.Open();
                NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM Usuarios where id= '" + id + "'", connection);
                NpgsqlDataReader dataReader = command.ExecuteReader();
                dataReader.Read();
                return new Usuario(Convert.ToInt32(dataReader[0]), dataReader[1].ToString(), 
                                dataReader[2].ToString(), dataReader[3].ToString());

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                throw;
            }
            finally
            {
                connection.Close();
            }

        }

        public Usuario recuperarPorNome(string nome)
        {

            try
            {
                connection.Open();
                NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM Usuarios where nome= '" + nome + "'", connection);
                NpgsqlDataReader dataReader = command.ExecuteReader();
                dataReader.Read();
                return new Usuario(Convert.ToInt32(dataReader[0]), dataReader[1].ToString(),
                                dataReader[2].ToString(), dataReader[3].ToString());
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                throw;
            }
            finally
            {

                connection.Close();
            }

        }

        public void deletar(int id)
        {
            try
            {
                connection.Open();
                string deletarSql = String.Format("Delete from Usuarios where id= '" + id + "'");

                using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(deletarSql, connection))
                {
                    pgsqlcommand.ExecuteNonQuery();
                }

            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.ToString());
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        public List<Usuario> recuperarTodos()
        {
            List<Usuario> Usuarios = new List<Usuario>();
            try
            {

                connection.Open();
                NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM Usuarios", connection);
                NpgsqlDataReader dataReader = command.ExecuteReader();

                for (int i = 0; dataReader.Read(); i++)
                {
                    Usuario u = new Usuario(Convert.ToInt32(dataReader[0]), dataReader[1].ToString(),
                                dataReader[2].ToString(), dataReader[3].ToString());
                    Usuarios.Add(u);
                }

                return Usuarios;
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.ToString());
                throw;
            }
            finally
            {
                connection.Close();

            }
        }

    }
}
