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
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
        }

        public MySqlConnection conexion = Conexion.getConexion();
      

        private void tbxPName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetterOrDigit(e.KeyChar)) && !(char.IsControl(e.KeyChar)) && !(char.IsWhiteSpace(e.KeyChar));
            if (e.Handled = !(char.IsLetterOrDigit(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar)))
            {
                MessageBox.Show("Sólo se admiten letras y números", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        
        private void tbxPPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar)) && !(char.IsControl(e.KeyChar)) && !(e.KeyChar=='.');
            if (e.Handled = !(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar) || e.KeyChar == '.'))
            {
                MessageBox.Show("No se admiten caracteres, letras ni números negativos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void tbxPCant_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar)) && !(char.IsControl(e.KeyChar));
            if (e.Handled = !(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                MessageBox.Show("No se admiten caracteres ni letras","Error",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void RefrescarTabla()
        {
            Conexion.abrir();
            string selectQuery = "SELECT * FROM productos";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, conexion);
            adapter.Fill(table);
            dgvProduct.DataSource = table;
        }

        public void LimpiarCampos()
        {
            lblCodP.Text = null;
            tbxPName.Text = null;
            tbxPCant.Text = null;
            tbxPPrice.Text = null;
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            RefrescarTabla();
            if (Globales.idrango != 1)
            {
                btnDelete.Visible = false;
                btnDelete.Enabled = false;
            } 
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            panelDatos.Visible = true;
            btnSaveChang.Visible = true;
            btnSaveChang.Enabled = true;
            btnSaveChang.BringToFront();
            lblCodP.Text = dgvProduct.CurrentRow.Cells[0].Value.ToString();
            tbxPName.Text = dgvProduct.CurrentRow.Cells[1].Value.ToString();
            tbxPPrice.Text = dgvProduct.CurrentRow.Cells[2].Value.ToString();
            tbxPCant.Text = dgvProduct.CurrentRow.Cells[3].Value.ToString();
        }

        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (panelDatos.Visible)
                panelDatos.Visible = false;
            btnEdit.Enabled = true;
            if (Globales.idrango == 1)
                btnDelete.Enabled = true;
            btnSaveChang.Visible = false;
            btnSaveChang.Enabled = false;
            btnSaveAdd.Visible = false;
            btnSaveAdd.Enabled = false;
        }

        private void btnSaveChang_Click(object sender, EventArgs e)
        {
            if (tbxPName.Text != "" && tbxPPrice.Text != "" && tbxPPrice.Text != "0" && tbxPCant.Text != "" && tbxPCant.Text != "0")
            {

                if (MessageBox.Show("¿Esta seguro de modificar este producto?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                {
                    string updateQuery = "UPDATE productos SET nom_producto='" + tbxPName.Text + "', precio='" + tbxPPrice.Text + "', cantidad='" + tbxPCant.Text + "' WHERE id_producto=" + int.Parse(lblCodP.Text) + "";
                    LimpiarCampos();
                    panelDatos.Visible = false;
                    if (Conexion.executeMyQuery(updateQuery))
                        RefrescarTabla();
                    else
                        MessageBox.Show("Error en la conexión, intente mas tarde", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Error, campos vacios o con valor nulo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            lblCodP.Text= dgvProduct.CurrentRow.Cells[0].Value.ToString();
            if (MessageBox.Show("¿Esta seguro de eliminar este producto?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                string deleteQuery = "DELETE FROM productos WHERE id_producto=" + int.Parse(lblCodP.Text) + "";
                if (Conexion.executeMyQuery(deleteQuery))
                    RefrescarTabla();
                else
                    MessageBox.Show("Error en la conexión, intente mas tarde", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            panelDatos.Visible = true;
            btnSaveAdd.Visible = true;
            btnSaveAdd.Enabled = true;
            btnSaveAdd.BringToFront();
        }

        private void btnSaveAdd_Click(object sender, EventArgs e)
        {
            if (tbxPName.Text != "" && tbxPPrice.Text != "" &&  tbxPPrice.Text != "0" && tbxPCant.Text != "" && tbxPCant.Text != "0")
            {
                if (MessageBox.Show("¿Esta seguro de agregar este producto?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                {
                    string insertQuery = "INSERT INTO productos(nom_producto, precio, cantidad)VALUES('" + tbxPName.Text + "', '" + tbxPPrice.Text + "', '" + tbxPCant.Text + "')";
                    LimpiarCampos();
                    panelDatos.Visible = false;
                    if (Conexion.executeMyQuery(insertQuery))
                        RefrescarTabla();
                    else
                        MessageBox.Show("Error en la conexión, intente mas tarde", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Error, campos vacios o con valor nulo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefrescarTabla();
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
                    dgvProduct.DataSource = table;
               
            }
            else
                MessageBox.Show("Por favor ingrese el nombre del producto para realizar la búsqueda");
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            if (tbxSearch.Text != "")
            {
                string searchQuery = "SELECT * FROM productos WHERE nom_producto LIKE '" + tbxSearch.Text + "%'";
                MySqlCommand command = new MySqlCommand(searchQuery, conexion);

                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(searchQuery, conexion);
                adapter.Fill(table);
                dgvProduct.DataSource = table;

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Globales.ventana = 0;
            this.Close();
        }
    }
}
