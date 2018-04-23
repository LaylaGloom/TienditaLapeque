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
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
        }

        public MySqlConnection conexion = Conexion.getConexion();

        private void btnClose_Click(object sender, EventArgs e)
        {
            Globales.ventana = 0;
            this.Close();
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            RefrescarTabla();
            dgvUsers.Columns[0].Width = 45;
            dgvUsers.Columns[4].Width = 65;
            tbxPass.UseSystemPasswordChar = true;
            tbxConfPass.UseSystemPasswordChar = true;
            tbxPassEdit.UseSystemPasswordChar = true;
            tbxPassEditConf.UseSystemPasswordChar = true;
        }

        public void RefrescarTabla()
        {
            Conexion.abrir();
            string selectQuery = "SELECT id_usuario AS Id, nombre AS nombre,apepat AS Paterno, apemat AS Materno, id_rango AS Privilegios FROM usuarios ";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, conexion);
            adapter.Fill(table);
            dgvUsers.DataSource = table;
        }

        public void LimpiarDatos()
        {
            tbxName.Text = "";
            tbxPaterno.Text = "";
            tbxMaterno.Text = "";
            tbxMaterno.Text = "";
            tbxPass.Text = "";
            tbxConfPass.Text = "";
            lblCodP.Text = "";
            lblNombre.Text = "";
            lblPaterno.Text = "";
            lblMaterno.Text = "";
            tbxPassEdit.Text = "";
            tbxPassEditConf.Text = "";
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            if (tbxSearch.Text != "")
            {
                string searchQuery = "SELECT * FROM usuarios WHERE nombre LIKE '" + tbxSearch.Text + "%'";
                MySqlCommand command = new MySqlCommand(searchQuery, conexion);

                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(searchQuery, conexion);
                adapter.Fill(table);
                dgvUsers.DataSource = table;

            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (tbxSearch.Text != null)
            {
                string searchQuery = "SELECT * FROM usuarios WHERE nombre LIKE '" + tbxSearch.Text + "%'";
                MySqlCommand command = new MySqlCommand(searchQuery, conexion);

                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(searchQuery, conexion);
                adapter.Fill(table);
                dgvUsers.DataSource = table;

            }
            else
                MessageBox.Show("Por favor ingrese el nombre del producto para realizar la búsqueda");
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefrescarTabla();
        }

        private void tbxSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar)) && !(char.IsControl(e.KeyChar)) && !(char.IsWhiteSpace(e.KeyChar));
            if (e.Handled = !(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar)))
            {
                MessageBox.Show("Sólo se admiten letras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            LimpiarDatos();
            panelAdd.Visible = true;
            panelAdd.BringToFront();
        }

        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (panelAdd.Visible)
                panelAdd.Visible = false;
            if (panelContra.Visible)
                panelContra.Visible = false;
            LimpiarDatos();
        }

        private void tbxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar)) && !(char.IsControl(e.KeyChar)) && !(char.IsWhiteSpace(e.KeyChar));
            if (e.Handled = !(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar)))
            {
                MessageBox.Show("Sólo se admiten letras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void tbxPaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar)) && !(char.IsControl(e.KeyChar)) && !(char.IsWhiteSpace(e.KeyChar));
            if (e.Handled = !(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar)))
            {
                MessageBox.Show("Sólo se admiten letras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void tbxMaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar)) && !(char.IsControl(e.KeyChar)) && !(char.IsWhiteSpace(e.KeyChar));
            if (e.Handled = !(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar)))
            {
                MessageBox.Show("Sólo se admiten letras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void tbxPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetterOrDigit(e.KeyChar)) && !(char.IsControl(e.KeyChar));
            if (e.Handled = !((char.IsLetterOrDigit(e.KeyChar)) || (char.IsControl(e.KeyChar))))
            {
                MessageBox.Show("No se admiten caracteres");
            }
        }

        private void tbxConfPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetterOrDigit(e.KeyChar)) && !(char.IsControl(e.KeyChar));
            if (e.Handled = !((char.IsLetterOrDigit(e.KeyChar)) || (char.IsControl(e.KeyChar))))
            {
                MessageBox.Show("No se admiten caracteres");
            }
        }

        private void tbxPassEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetterOrDigit(e.KeyChar)) && !(char.IsControl(e.KeyChar));
            if (e.Handled = !((char.IsLetterOrDigit(e.KeyChar)) || (char.IsControl(e.KeyChar))))
            {
                MessageBox.Show("No se admiten caracteres");
            }
        }

        private void tbxPassEditConf_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetterOrDigit(e.KeyChar)) && !(char.IsControl(e.KeyChar));
            if (e.Handled = !((char.IsLetterOrDigit(e.KeyChar)) || (char.IsControl(e.KeyChar))))
            {
                MessageBox.Show("No se admiten caracteres");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            LimpiarDatos();
            panelAdd.Visible = false;
            panelAdd.SendToBack();
            panelContra.Visible = true;
            panelContra.BringToFront();
            lblCodP.Text= dgvUsers.CurrentRow.Cells[0].Value.ToString();
            lblNombre.Text= dgvUsers.CurrentRow.Cells[1].Value.ToString();
            lblPaterno.Text= dgvUsers.CurrentRow.Cells[2].Value.ToString();
            lblMaterno.Text= dgvUsers.CurrentRow.Cells[3].Value.ToString();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvUsers.CurrentRow.Cells[0].Value.ToString() != Globales.usuario)
            {
                if (MessageBox.Show("¿Esta seguro de eliminar este usuario? Una vez eliminado no tendrá accesoal sistema", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                {
                    Conexion.abrir();
                    lblCodP.Text = dgvUsers.CurrentRow.Cells[0].Value.ToString();
                    Globales.deleteQuery = "DELETE FROM usuarios WHERE id_usuario = " + int.Parse(lblCodP.Text) + "";
                    if (Conexion.executeMyQuery(Globales.deleteQuery))
                        RefrescarTabla();
                    else
                        MessageBox.Show("Error en la conexión, intente mas tarde", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    LimpiarDatos();
                    Conexion.cerrar();
                }
            }
            else
                MessageBox.Show("Error, el usuario que intenta eliminar es usted mismo");
        }

        private void btnChangPass_Click(object sender, EventArgs e)
        {
            if (tbxPassEdit.Text != "" && tbxPassEditConf.Text != "")
            {
                if (tbxPassEdit.Text.ToString() == tbxPassEditConf.Text.ToString())
                {
                    if (tbxPassEdit.Text.Length >= 8)
                    {
                        if (MessageBox.Show("¿Esta seguro de reestablecer la contraseña?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                        {
                            Conexion.abrir();
                            Globales.updateQuery = "UPDATE usuarios SET contrasena= '" + tbxPassEdit.Text + "' WHERE id_usuario= " +Convert.ToInt16(lblCodP.Text) + "";
                            LimpiarDatos();
                            panelAdd.Visible = false;
                            if (Conexion.executeMyQuery(Globales.updateQuery))
                            {
                                RefrescarTabla();
                                MessageBox.Show("Contraseña cambiada exitosamente");
                            }  
                            else
                                MessageBox.Show("Error en la conexión, intente mas tarde", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Conexion.cerrar();
                            panelContra.Visible = false;
                        }
                    }
                    else
                        MessageBox.Show("Las contraseñas deben tener un minimo de 8 caracteres");
                }
                else
                    MessageBox.Show("Las contraseñas no coinciden, verifiquelas y vuelva a intentar");
            }
            else
                MessageBox.Show("Campos vacios, verifiquelos");

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            
            if (tbxName.Text!="" && tbxPaterno.Text!="" && tbxMaterno.Text!="" && tbxPass.Text!="" &&(radAdmin.Checked==true || radEmpleado.Checked==true) && tbxConfPass.Text != "")
            {
                Conexion.cerrar();
                Conexion.abrir();
                Globales.selectQuery = "SELECT nombre AS username FROM usuarios WHERE nombre ='" + tbxName.Text +"'";
                MySqlCommand variables = new MySqlCommand(Globales.selectQuery, conexion);
                MySqlDataReader releer = variables.ExecuteReader();
                if (releer.Read())
                {
                    MessageBox.Show("Este nombre de usuario ya existe, elija otro nombre.");
                }
                else if (tbxPass.Text.ToString() == tbxConfPass.Text.ToString())
                {
                    if (tbxPass.Text.Length >= 8)
                    {
                        if (MessageBox.Show("¿Esta seguro de agregar este usuario?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                        {
                            Conexion.cerrar();
                            CatUsuario();
                            Globales.insertQuery = "INSERT INTO usuarios (nombre,apepat,apemat,id_rango,contrasena) VALUES('" + tbxName.Text + "', '" + tbxPaterno.Text + "', '" + tbxMaterno.Text + "', '" + Globales.idrango + "', '" + tbxPass.Text + "')";
                            LimpiarDatos();
                            panelAdd.Visible = false;
                            Conexion.abrir();
                            if (Conexion.executeMyQuery(Globales.insertQuery))
                                RefrescarTabla();
                            else
                                MessageBox.Show("Error en la conexión, intente mas tarde", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }  
                    else
                        MessageBox.Show("Las contraseñas deben tener un minimo de 8 caracteres");
                }
                else
                    MessageBox.Show("Las contraseñas no coinciden, verifiquelas y vuelva a intentar");
                Conexion.cerrar();
            }
            else
                MessageBox.Show("Ingrese todos los datos");
     
        }
        public void CatUsuario()
        {
            if (radEmpleado.Checked==true)
                Globales.idrango = 2;
            else if(radAdmin.Checked==true)
                Globales.idrango = 1;
        }
    }




}
