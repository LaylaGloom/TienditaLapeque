﻿using System;
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
            timer1.Enabled = true;
            


        }

        public   index inde = new index();
       public MySqlConnection conexion = Conexion.getConexion();
        

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
            conexion.Open();


        }

        private void button1_Click(object sender, EventArgs e)
        {
           
           MySqlCommand cmd = new MySqlCommand("SELECT * FROM usuarios WHERE nombre='" + textBox1.Text + "' AND contrasena='" + textBox2.Text+"'",conexion);
           MySqlDataReader leer = cmd.ExecuteReader();
            Globales.usuario = textBox1.Text;
            Globales.constraseña = textBox2.Text;
            if (leer.Read()) //Si el usuario es correcto nos abrira la otra ventana.
           {
                
                Globales.idrango = Convert.ToInt16(leer["id_rango"]);
                inde.Show();
                this.Hide();
                          
           }
           else //Si no lo es mostrara este mensaje.
               MessageBox.Show("Error - Ingrese sus datos correctamente");

        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de cerrar la aplicacion?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblhora.Text = DateTime.Now.ToLongTimeString();
        }

        private void lblhora_Click(object sender, EventArgs e)
        {

        }
        

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                /*String con = Conexion.getConexion();
                MySqlConnection conexion = new MySqlConnection(con);
                conexion.Open();*/
                //conexion.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM usuarios WHERE nombre='" + textBox1.Text + "' AND contrasena='" + textBox2.Text + "'", conexion);
                MySqlDataReader leer = cmd.ExecuteReader();
                Globales.usuario = textBox1.Text;
                Globales.constraseña = textBox2.Text;
               // Globales.idrango = Convert.ToInt16(leer["id_rango"]);
                if (leer.Read()) //Si el usuario es correcto nos abrira la otra ventana.
                {
                    Globales.idrango = Convert.ToInt16(leer["id_rango"]);
                    inde.Show();
                    this.Hide();

                }
                else //Si no lo es mostrara este mensaje.
                    MessageBox.Show("Error - Ingrese sus datos correctamente");

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de salir del Sistema?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
