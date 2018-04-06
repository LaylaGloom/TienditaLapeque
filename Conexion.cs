using System;
using MySql.Data.MySqlClient;

namespace TienditaLapeque
{

    public class Conexion
    {
        MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();

        public void generar()
        {
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Port = 3307;
            builder.Password = "1234";
            builder.Database = "sistema";
        }

        public static String getConexion()
        {
            generar();
            return builder.ToString();
        }
    }

}
