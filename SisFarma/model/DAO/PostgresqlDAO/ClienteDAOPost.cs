using Npgsql;
using SisFarma.model.classes;
using System;
using System.Windows.Forms;

namespace SisFarma.model.DAO.PostgresqlDAO
{
    public class ClienteDAOPost
    {
        private string connection;
        private NpgsqlConnection con;
        private NpgsqlCommand cmd;

        public ClienteDAOPost()
        {
            this.connection = String.Format("Server={0};Port={1};" +
                    "User Id={2};Password={3};Database={4};",
                    "localhost", 5432, "postgres",
                    "ifpe", "SisFarma");
            this.con = new NpgsqlConnection(connection);
        }


        public void inserir(Cliente cliente)
        {
            try
            {
                con.Open();
                cmd = new NpgsqlCommand
                        (@"select * from cli_insert('" + cliente.DataNasc + "','" + cliente.Nome + "','" + 
                            cliente.CPF + "','" + cliente.Rg + "','" + cliente.Sexo + "','" + cliente.Telefone + 
                                "','" + cliente.CEP + "','" + cliente.Cidade + "','" + cliente.Logradouro + "')", con);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                con.Close();
            }
            
        }

        public NpgsqlDataReader recuperarTodos()
        {

                con.Open();
                cmd = new NpgsqlCommand
                        (@"select * from cli_select()", con);
                return cmd.ExecuteReader();
        }
        
    }
}
