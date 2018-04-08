using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using variablesGlobales;

namespace TienditaLapeque
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tiempo.Enabled = true;

        }
        
        public MySqlConnection conexion = Conexion.getConexion();
        private void Form1_Load(object sender, EventArgs e)
        {
            tbxPass.UseSystemPasswordChar = true;
            conexion.Open();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (tbxPass.Text == null || tbxUsername.Text == null)
            {
                MessageBox.Show("Ambos campos son requeridos, por favor completelos.");
            }
            else
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM usuarios WHERE nombre='" + tbxUsername.Text + "' AND contrasena='" + tbxPass.Text + "'", conexion);
                MySqlDataReader leer = cmd.ExecuteReader();
                Globales.usuario = tbxUsername.Text;
                Globales.constraseña = tbxPass.Text;
                if (leer.Read()) //Si el usuario es correcto nos abrira la otra ventana.
                {
                    Index inde = new Index(this);
                    Globales.idrango = Convert.ToInt16(leer["id_rango"]);
                    inde.Show();
                    this.Hide();

                }
                else //Si no lo es mostrara este mensaje.
                    MessageBox.Show("Error - Ingrese sus datos correctamente");
            }
        }

        private void tbxUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetterOrDigit(e.KeyChar)) && !(char.IsControl(e.KeyChar));
            if(e.Handled =!((char.IsLetterOrDigit(e.KeyChar)) || (char.IsControl(e.KeyChar)) ))
            {
                MessageBox.Show("No se admiten caracteres");
            }
            
        }

        private void tiempo_Tick(object sender, EventArgs e)
        {
            lblhora.Text = DateTime.Now.ToLongTimeString();
        }

        private void tbxPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (tbxPass.Text == null || tbxUsername.Text == null)
                {
                    MessageBox.Show("Ambos campos son requeridos, por favor completelos.");
                }
                else
                {
                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM usuarios WHERE nombre='" + tbxUsername.Text + "' AND contrasena='" + tbxPass.Text + "'", conexion);
                    MySqlDataReader leer = cmd.ExecuteReader();
                    Globales.usuario = tbxUsername.Text;
                    Globales.constraseña = tbxPass.Text;
                    if (leer.Read()) //Si el usuario es correcto nos abrira la otra ventana.
                    {
                        Index inde = new Index(this);
                        Globales.idrango = Convert.ToInt16(leer["id_rango"]);
                        inde.Show();
                        this.Hide();

                    }
                    else //Si no lo es mostrara este mensaje.
                        MessageBox.Show("Error - Ingrese sus datos correctamente");
                }
            }
        }
    }
}
