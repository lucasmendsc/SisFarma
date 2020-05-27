using Npgsql;
using SisFarma.model.classes;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SisFarma.model.DAO.PostgresqlDAO
{
    class ProdutoDAOPost
    {
        private NpgsqlConnection connection;

        public ProdutoDAOPost()
        {
            this.connection = PostgreSqlCon.getCon();
        }

        public void inserir(Produto Produto)
        {
            try
            {
                connection.Open();
                string inserirSql = String.Format("Insert Into Produtos" +
                    "(id,nome,descricao,valor,foto)" + " values('{0}','{1}','{2}','{3}','{4}')",
                    Produto.Id, Produto.Nome, Produto.Descricao, Produto.Valor, Produto.Foto);

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

        public void alterar(Produto Produto)
        {
            try
            {
                connection.Open();
                string alterarSql = String.Format("update produtos set nome = '" + Produto.Nome + "'"
                    + ",descricao = '" + Produto.Descricao + "'" + ",valor = '" + Produto.Valor + "'" + ",foto = '" + Produto.Foto + "'"
                    + "where id = '" + Produto.Id + "'");
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

        public Produto recuperarPorId(int id)
        {

            try
            {
                connection.Open();
                NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM Produtos where id= '" + id + "'", connection);
                NpgsqlDataReader dataReader = command.ExecuteReader();
                dataReader.Read();
                return new Produto(Convert.ToInt32(dataReader[0]), dataReader[1].ToString(), dataReader[2].ToString(),
                                        Convert.ToDouble(dataReader[3]), dataReader[4].ToString());
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

        public Produto recuperarPorNome(string nome)
        {

            try
            {
                connection.Open();
                NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM Produtos where nome= '" + nome + "'", connection);
                NpgsqlDataReader dataReader = command.ExecuteReader();
                dataReader.Read();
                return new Produto(Convert.ToInt32(dataReader[0]), dataReader[1].ToString(), dataReader[2].ToString(),
                                        Convert.ToDouble(dataReader[3]), dataReader[4].ToString());
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
                string deletarSql = String.Format("Delete from Produtos where id= '" + id + "'");

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

        public List<Produto> recuperarTodos()
        {
            List<Produto> Produtos = new List<Produto>();
            try
            {

                connection.Open();
                NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM Produtos", connection);
                NpgsqlDataReader dataReader = command.ExecuteReader();

                for (int i = 0; dataReader.Read(); i++)
                {
                    Produto p = new Produto(Convert.ToInt32(dataReader[0]), dataReader[1].ToString(), dataReader[2].ToString(),
                                        Convert.ToDouble(dataReader[3]), dataReader[4].ToString());
                    Produtos.Add(p);
                }

                return Produtos;
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
