using System.Data.SqlClient;

namespace AtvFormsComp.db
{
    class AppSQLConnection
    {
        private static string connectionString = @"Server=localhost;Database=db_aula2;Trusted_Connection=True;AttachDbFileName=D:\bancoAula\dbAulaSQL2.mdf;";

        private static SqlConnection conn = null;

        public static SqlConnection GetConnection()
        {
            if (conn == null)
                conn = new SqlConnection(connectionString);
            if (conn.State == System.Data.ConnectionState.Closed)
                conn.Open();
            return conn;
        }


    }
}
