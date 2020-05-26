using Npgsql;

namespace SisFarma.model.DAO.PostgresqlDAO
{
    public class PostgreSqlCon
    {
        public static NpgsqlConnection getCon()
        { 
            return new NpgsqlConnection
                ("Server=127.0.0.1; Port=5432; User Id=postgres; Password=ifpe; Database=SisFarma;");
        }

    }
}
