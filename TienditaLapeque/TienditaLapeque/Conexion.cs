using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace TienditaLapeque
{
    class Conexion
    {
        static MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
        static MySqlConnection conexion;

        public static MySqlConnection getConexion()
        {
            builder.Server = "localhost";
            builder.UserID = "Admin";
            builder.Port = 3307;
            builder.Password = "Admin1234";
            builder.Database = "sistema";
            conexion = new MySqlConnection(builder.ToString());
            return conexion;
        }

        public static void abrir()
        {

            if (conexion.State == ConnectionState.Closed)
            {
                conexion.Open();
            }
        }

        public static void cerrar()
        {
            if (conexion.State == ConnectionState.Open)
            {
                conexion.Close();
            }
        }


        public static bool executeMyQuery(string query)
        {
            try
            {
                MySqlCommand command = new MySqlCommand(query, conexion);

                if (command.ExecuteNonQuery() == 1)
                {
                    return true;
                }                
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            return false;
        }
    }
}
