using System;
using MySql.Data.MySqlClient;

namespace TienditaLapeque
{

    public class Conexion
    {
        static MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();

        public static MySqlConnection getConexion()
        {
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Port = 3307;
            builder.Password = "1234";
            builder.Database = "sistema";
            MySqlConnection conexion = new MySqlConnection(builder.ToString());
            return conexion;
        }
    }

}
