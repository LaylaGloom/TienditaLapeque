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
    public partial class Prestamos : Form
    {
        public Prestamos()
        {
            InitializeComponent();
        }

        public MySqlConnection conexion = Conexion.getConexion();

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            if (tbxSearch.Text != "")
            {
                string searchQuery = "SELECT * FROM prestamos WHERE nom_cliente LIKE '" + tbxSearch.Text + "%'";
                MySqlCommand command = new MySqlCommand(searchQuery, conexion);

                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(searchQuery, conexion);
                adapter.Fill(table);
                dgvClient.DataSource = table;

            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (tbxSearch.Text != null)
            {
                string searchQuery = "SELECT * FROM prestamos WHERE nom_cliente LIKE '" + tbxSearch.Text + "%'";
                MySqlCommand command = new MySqlCommand(searchQuery, conexion);

                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(searchQuery, conexion);
                adapter.Fill(table);
                dgvClient.DataSource = table;

            }
            else
                MessageBox.Show("Por favor ingrese el nombre del producto para realizar la búsqueda");
        }

        public void RefrescarTabla()
        {
            Conexion.abrir();
            string selectQuery = "SELECT * FROM prestamos";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, conexion);
            adapter.Fill(table);
            dgvClient.DataSource = table;
        }

        private void Prestamos_Load(object sender, EventArgs e)
        {
            RefrescarTabla();
            if (Globales.idrango != 1)
            {
                btnDelete.Visible = false;
                btnDelete.Enabled = false;
            }
        }

        private void tbxCName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar)) && !(char.IsControl(e.KeyChar)) && !(char.IsWhiteSpace(e.KeyChar));
            if (e.Handled = !(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar)))
            {
                MessageBox.Show("Sólo se admiten letras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void tbxCAdeudo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar)) && !(char.IsControl(e.KeyChar)) && !(e.KeyChar == '.');
            if (e.Handled = !(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar) || e.KeyChar == '.'))
            {
                MessageBox.Show("No se admiten caracteres, letras ni números negativos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void tbxCAbono_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar)) && !(char.IsControl(e.KeyChar)) && !(e.KeyChar == '.');
            if (e.Handled = !(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar) || e.KeyChar == '.'))
            {
                MessageBox.Show("No se admiten caracteres, letras ni números negativos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtAbonoEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar)) && !(char.IsControl(e.KeyChar)) && !(e.KeyChar == '.');
            if (e.Handled = !(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar) || e.KeyChar == '.'))
            {
                MessageBox.Show("No se admiten caracteres, letras ni números negativos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void dgvClient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (panelAdd.Visible)
                panelAdd.Visible = false;
            if (panelEdit.Visible)
                panelEdit.Visible = false;
            if (Globales.idrango == 1)
                btnDelete.Enabled = true;          
        }

        public void LimpiarCampos()
        {
            lblCodP.Text = null;
            tbxCName.Text = null;
            tbxCAbono.Text = null;
            tbxCAdeudo.Text = null;
            txtAbonoEdit.Text = null;
            lblCAdeudoEdit.Text = null;
            lblCNameEdit.Text = null;
            lblCodEdit.Text = null;
            lblEstado.Text = null;
            lblEstadoEdit.Text = null;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            panelAdd.Visible = true;
            panelAdd.BringToFront();
        }

        private void btnSaveAdd_Click(object sender, EventArgs e)
        {
            if (tbxCName.Text != "" && tbxCAdeudo.Text != "" && tbxCAdeudo.Text != "0" && tbxCAbono.Text !="")
            {
                if (Convert.ToDecimal(tbxCAbono.Text) >= Convert.ToDecimal(tbxCAdeudo.Text))
                {
                    MessageBox.Show("El monto del abono es mayor o igual al del adeudo, por favor revise la cantidad ingresada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (MessageBox.Show("¿Esta seguro de agregar este producto?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                {
                    Globales.insertQuery = "INSERT INTO prestamos(nom_cliente, monto_deuda, monto_abono)VALUES('" + tbxCName.Text + "', '" + tbxCAdeudo.Text + "', '" + tbxCAbono.Text + "')";
                    LimpiarCampos();
                    panelAdd.Visible = false;
                    if (Conexion.executeMyQuery(Globales.insertQuery))
                        RefrescarTabla();
                    else
                        MessageBox.Show("Error en la conexión, intente mas tarde", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Error,los campos no pueden quedar vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        
        
        private void btnSaveChang_Click(object sender, EventArgs e)
        {
            if (txtAbonoEdit.Text != "" || txtAbonoEdit.Text != "0")
            {
                Globales.deudaT = Convert.ToDecimal(dgvClient.CurrentRow.Cells[3].Value);
                Globales.abono= Convert.ToDecimal(dgvClient.CurrentRow.Cells[4].Value);
                Globales.restante =  Globales.deudaT- Globales.abono;
                if (Convert.ToDecimal(txtAbonoEdit.Text)>Globales.restante)
                {
                    MessageBox.Show("El monto del abono es mayor al del adeudo, por favor revise la cantidad ingresada"+Globales.restante.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (MessageBox.Show("¿Esta seguro de modificar esta deuda?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                {
                    if (Convert.ToDecimal(txtAbonoEdit.Text) == Globales.restante)
                    {
                        Globales.EP_pagado = true;
                        Globales.updateQuery = "UPDATE prestamos SET monto_abono= monto_abono + (monto_deuda - monto_abono) , estado= '" +"pagado" + "' WHERE id_prestamos=" + int.Parse(lblCodEdit.Text) + "";
                    }
                    else
                        Globales.updateQuery = "UPDATE prestamos SET monto_abono= monto_abono + '" + txtAbonoEdit.Text +  "' WHERE id_prestamos=" + int.Parse(lblCodEdit.Text) + "";
                    LimpiarCampos();
                    panelEdit.Visible = false;
                    if (Conexion.executeMyQuery(Globales.updateQuery))
                    {
                        RefrescarTabla();
                        if (Globales.EP_pagado)
                        {
                            MessageBox.Show("El cliente ha pagado la totalidad de la deuda");
                            Globales.EP_pagado = false;
                        }
                    }
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvClient.CurrentRow.Cells[5].Value.ToString() == "en deuda")
            {
                LimpiarCampos();
                panelAdd.Visible = false;
                panelAdd.SendToBack();
                panelEdit.Visible = true;
                panelEdit.BringToFront();
                lblCodEdit.Text = dgvClient.CurrentRow.Cells[0].Value.ToString();
                lblCNameEdit.Text = dgvClient.CurrentRow.Cells[1].Value.ToString();
                lblCAdeudoEdit.Text = dgvClient.CurrentRow.Cells[3].Value.ToString();
                txtAbonoEdit.Text = dgvClient.CurrentRow.Cells[4].Value.ToString();
                lblEstadoEdit.Text = dgvClient.CurrentRow.Cells[5].Value.ToString();
            }
            else
                MessageBox.Show("La deuda ha sido pagada, no se puede editar");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvClient.CurrentRow.Cells[5].Value.ToString() == "pagado")
            {
                lblCAdeudoEdit.Text = dgvClient.CurrentRow.Cells[0].Value.ToString();
                if (MessageBox.Show("¿Esta seguro de eliminar esta deuda?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                {
                    Globales.deleteQuery = "DELETE FROM prestamos WHERE id_prestamos = " + int.Parse(lblCAdeudoEdit.Text) + "";
                    if (Conexion.executeMyQuery(Globales.deleteQuery))
                        RefrescarTabla();
                    else
                        MessageBox.Show("Error en la conexión, intente mas tarde", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }  
            }
            else
            {
                MessageBox.Show("Deuda aun no saldada, favor de pagar en totalidad la deuda para eliminarla");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Globales.ventana = 0;
            this.Close();
        }
    }
}
