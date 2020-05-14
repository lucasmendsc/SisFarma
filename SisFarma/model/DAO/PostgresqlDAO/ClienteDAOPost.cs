using Npgsql;
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


        public void inserir(DateTime dataNasc, string nome, string cpf, string rg,
                    string sexo, string telefone, string cep, string cidade, string logradouro)
        {
            try
            {
                con.Open();
                cmd = new NpgsqlCommand
                        (@"select * from cli_insert('" + dataNasc + "','" + nome + "','" + cpf + "','" +
                            rg + "','" + sexo + "','" + telefone + "','" + cep + "','" + cidade + "','" + logradouro + "')", con);

                int result = (int)cmd.ExecuteScalar();

                MessageBox.Show("DSA");
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
        
    }
}
