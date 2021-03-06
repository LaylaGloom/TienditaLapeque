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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace TienditaLapeque
{
    public partial class Ventas : Form
    {
        public Ventas()
        {
            InitializeComponent();
            generarPdf();
        }

        public MySqlConnection conexion = Conexion.getConexion();
        public MySqlCommand query;
    
        private void Ventas_Load(object sender, EventArgs e)
        {
            RefrescarTabla();
            dgvInventario.Columns[0].Width = 30;
            dgvInventario.Columns[0].HeaderText = "#";
            dgvInventario.Columns[1].HeaderText = "Producto";
            dgvInventario.Columns[1].Width = 200;
            dgvInventario.Columns[2].Width = 60;
            dgvInventario.Columns[2].HeaderText = "Precio";
            dgvInventario.Columns[3].Width = 70;
            dgvInventario.Columns[3].HeaderText = "Cantidad";
        }
        public void generarPdf()
        {
            Globales.document = new Document();
            PdfWriter.GetInstance(Globales.document, new FileStream("Ticket.pdf", FileMode.OpenOrCreate));
            iTextSharp.text.Rectangle docSize = new iTextSharp.text.Rectangle(250f, 400f);
            Globales.document.SetPageSize(docSize);
            Globales.document.Open();
            iTextSharp.text.Paragraph parrafo1 = new Paragraph("/Tienda de Abarrotes la peque/");
            parrafo1.Alignment = Element.ALIGN_CENTER;
            Globales.document.Add(parrafo1);
            Globales.document.Add(new Paragraph("Lo atendio: " + Globales.usuario));
            Globales.document.Add(new Paragraph("Fecha de compra: " + DateTime.Now.ToLongDateString()));
            Globales.document.Add(new Paragraph("Ticket de compra"));
        }
        private void tbxPCant_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar)) && !(char.IsControl(e.KeyChar));
            if (e.Handled = !(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                MessageBox.Show("No se admiten caracteres ni letras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void RefrescarTabla()
        {
            Conexion.abrir();
            string selectQuery = "SELECT * FROM productos";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, conexion);
            adapter.Fill(table);
            dgvInventario.DataSource = table;
        }

        public void LimpiarCampos()
        {
            lblCodP.Text = null;
            lblPName.Text = null;
            tbxPCant.Text = null;
            lblPPrice.Text = null;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (tbxSearch.Text != null)
            {
                string searchQuery = "SELECT * FROM productos WHERE nom_producto LIKE '" + tbxSearch.Text + "%'";
                MySqlCommand command = new MySqlCommand(searchQuery, conexion);

                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(searchQuery, conexion);
                adapter.Fill(table);
                dgvInventario.DataSource = table;

            }
            else
                MessageBox.Show("Por favor ingrese el nombre del producto para realizar la búsqueda");
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            panelDatos.Visible = true;
            btnSaveAdd.Visible = true;
            btnSaveAdd.Enabled = true;
            lblCodP.Text = dgvInventario.CurrentRow.Cells[0].Value.ToString();
            lblPName.Text = dgvInventario.CurrentRow.Cells[1].Value.ToString();
            lblPPrice.Text = dgvInventario.CurrentRow.Cells[2].Value.ToString();
            tbxPCant.Text = dgvInventario.CurrentRow.Cells[3].Value.ToString();
            
        }

        private void dgvInventario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSelect.Enabled = true;
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            if (tbxSearch.Text != null)
            {
                string searchQuery = "SELECT * FROM productos WHERE nom_producto LIKE '" + tbxSearch.Text + "%'";
                MySqlCommand command = new MySqlCommand(searchQuery, conexion);

                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(searchQuery, conexion);
                adapter.Fill(table);
                dgvInventario.DataSource = table;

            }
        }

        private void btnSaveAdd_Click(object sender, EventArgs e)
        {
            Globales.cantidad= dgvInventario.CurrentRow.Cells[3].Value.ToString();
            if (tbxPCant.Text == "" || Convert.ToInt16(tbxPCant.Text) == 0)
            {
                MessageBox.Show("El campo cantidad no puede quedar vacio,ingrese un numero mayor a 0");
            }
            else if (Convert.ToInt16(tbxPCant.Text) <= Convert.ToInt16(Globales.cantidad))
            {
                dgvVenta.
                if (Convert.ToInt16(tbxPCant.Text) == Convert.ToInt16(Globales.cantidad))
                    MessageBox.Show("Se ha vendido la totalidad de la existencia del producto en almacén");

                //Globales.document.Add(new Paragraph("Producto:     " + lblPName.Text + "   Precio: " + lblPPrice.Text));

            }
            else
            {
                MessageBox.Show("Error, la cantidad seleccionada supera la cantidad en almacén");
            }
        }

        private void btnTicket_Click(object sender, EventArgs e)
        {
            Globales.document.Add(new Paragraph("Total de la compra:" + Globales.totalventas));

            Globales.document.Close();
            System.Diagnostics.Process.Start("Ticket.pdf");
        }

        private void btnFinCompra_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Globales.ventana = 0;
            this.Close();
        }

        /*public void ActualizarCantidad()
        {
            query = new MySqlCommand("SELECT  cantidad as cant  from productos where nom_producto='" + tbxPCant.Text + "'", conexion);
            MySqlDataReader leer = query.ExecuteReader();
            if (leer.Read())
            {
                if (leer["cant"].ToString() != "")
                    Globales.cantidad = Convert.ToString(leer["cant"]);
            }
        }*/

    }
}
