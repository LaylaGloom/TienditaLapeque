using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using variablesGlobales;
using MySql.Data.MySqlClient;

namespace TienditaLapeque
{
    public partial class Reportes : Form
    {
        public Reportes()
        {
            InitializeComponent();
        }

        public MySqlConnection conexion = Conexion.getConexion();

        private void btnClose_Click(object sender, EventArgs e)
        {
            Globales.ventana = 0;
            this.Close();
        }

        private void dtpInicio_ValueChanged(object sender, EventArgs e)
        {
            Globales.fecha_ini= dtpInicio.Value.ToString("yyyy-MM-dd");
            label3.Text = Globales.fecha_ini;
        }

        private void dtpFin_ValueChanged(object sender, EventArgs e)
        {
            Globales.fecha_fin = dtpFin.Value.ToString("yyyy-MM-dd");
            label4.Text = Globales.fecha_fin;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Conexion.abrir();
            Globales.selectQuery = "SELECT * FROM ventas WHERE fecha_venta  BETWEEN '"+ Globales.fecha_ini + "' AND '"+ Globales.fecha_fin +"'";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(Globales.selectQuery, conexion);
            
                adapter.Fill(table);
                dgvReporte.DataSource = table;
            /*
            Globales.selectQuery= "SELECT SUM(subtotal) AS total FROM ventas WHERE fecha_venta BETWEEN '" + Globales.fecha_ini + "' AND '" + Globales.fecha_fin + "'";
            MySqlCommand variables = new MySqlCommand();
            variables.CommandText=Globales.selectQuery;
            Globales.tventa=Convert.ToDecimal(variables.ExecuteScalar());
            lblTVendido.Text = Globales.tventa.ToString();*/
        }
    }
}
