using Npgsql;
using SisFarma.model.classes;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SisFarma.model.DAO.PostgresqlDAO
{
    public class ClienteDAOPost
    {
        private NpgsqlConnection connection;

        public ClienteDAOPost()
        {
            this.connection = PostgreSqlCon.getCon(); 
        }

        public void inserir(Cliente cliente)
        {
            try
            {
                connection.Open();
                string inserirSql = String.Format("Insert Into clientes" +
                    "(id,nome,cpf,rg,data_nasc,sexo,telefone,cep,cidade,logradouro,numero)" +
                    " values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}')",
                    cliente.Id,cliente.Nome,cliente.CPF,cliente.Rg,cliente.DataNasc, cliente.Sexo,
                    cliente.Telefone,cliente.CEP,cliente.Cidade,cliente.Logradouro, cliente.Numero);

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

        public void alterar(Cliente cliente)
        {
            try
            {

                connection.Open();
                string alterarSql = String.Format("update clientes set nome = '" + cliente.Nome + "'"
                    + ",cpf = '" + cliente.CPF+ "'" + ",rg = '" + cliente.Rg + "'" + ",data_nasc = '" + cliente.DataNasc + "'"
                    + ",sexo = '" + cliente.Sexo + "'" + ",telefone = '" + cliente.Telefone + "',cep = '" + cliente.CEP + "'"
                    + ",cidade = '" + cliente.Cidade + "'" + ",logradouro = '" + cliente.Logradouro + "',numero = '" + cliente.Numero + "'" 
                    + "where id = '" + cliente.Id + "'");
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

        public Cliente recuperarPorId(int id)
        {

            try
            {
                connection.Open();
                NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM clientes where id= '" + id + "'", connection);
                NpgsqlDataReader dataReader = command.ExecuteReader();
                dataReader.Read();
                Cliente c = new Cliente(Convert.ToInt32(dataReader[0]), dataReader[1].ToString(), dataReader[2].ToString(),
                                        dataReader[3].ToString(), Convert.ToDateTime(dataReader[4]), dataReader[5].ToString(), dataReader[6].ToString(),
                                        dataReader[7].ToString(), dataReader[8].ToString(), dataReader[9].ToString(), Convert.ToInt32(dataReader[10].ToString()));
                return c;
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

        public Cliente recuperarPorNome(string nome)
        {

            try
            {
                connection.Open();
                NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM clientes where nome= '" + nome + "'", connection);
                NpgsqlDataReader dataReader = command.ExecuteReader();
                dataReader.Read();
                Cliente c = new Cliente(Convert.ToInt32(dataReader[0]), dataReader[1].ToString(), dataReader[2].ToString(),
                                        dataReader[3].ToString(), Convert.ToDateTime(dataReader[4]), dataReader[5].ToString(), dataReader[6].ToString(),
                                        dataReader[7].ToString(), dataReader[8].ToString(), dataReader[9].ToString(), Convert.ToInt32(dataReader[10].ToString()));
                return c;
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

        public void deletar(int id )
        {
            try
            {
                connection.Open();
                string deletarSql = String.Format("Delete from clientes where id= '" + id + "'");

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

        public List<Cliente> recuperarTodos()
        {
            List<Cliente> clientes = new List<Cliente>();
            try
            {               
                
                connection.Open();
                NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM clientes", connection);
                NpgsqlDataReader dataReader = command.ExecuteReader();

                for (int i = 0; dataReader.Read(); i++)
                {
                    Cliente cc = new Cliente(Convert.ToInt32(dataReader[0]),dataReader[1].ToString(),dataReader[2].ToString(),
                        dataReader[3].ToString(),Convert.ToDateTime(dataReader[4]),dataReader[5].ToString(),dataReader[6].ToString(),
                        dataReader[7].ToString(), dataReader[8].ToString(), dataReader[9].ToString(),Convert.ToInt32(dataReader[10].ToString()));
                    clientes.Add(cc);
                }
                
                return clientes;
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
