using MySql.Data.MySqlClient;

namespace KosuVeRutinTakip.Repositories
{
    public static class DbConnectionHelper
    {
        private static readonly string ConnectionString =
            "Server=localhost;Port=3306;Database=KosuVeRutinDB;Uid=root;Pwd=;";

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }
    }
}
