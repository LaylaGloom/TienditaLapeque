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


namespace TienditaLapeque
{
    public partial class Index : Form
        
    {
        Form1 padre;
        public Index(Form1 padre_)
        {
            InitializeComponent();
            dateHour.Enabled = true;
            padre = padre_;

        }

        

        private void btnVentas_Click(object sender, EventArgs e)
        {
            if (Globales.ventana!=1)
            {
               if(MessageBox.Show("Abrir ventana? Se perderán los cambios que no hayan sido guardados", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                {
                    var form = Application.OpenForms.OfType<Ventas>().FirstOrDefault();
                    Ventas hijo = form ?? new Ventas();
                    Globales.ventana = 1;
                    Index.ActiveForm.Width = Globales.tamañoInicial + 223;
                    Contenedor.Width = Globales.ContIndexInicial + 220;
                    AddFormInPanel(hijo);
                }
            }
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            if (Globales.ventana != 2)
            {
                if (MessageBox.Show("Abrir ventana? Se perderán los cambios que no hayan sigo guardados", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                {
                    var form = Application.OpenForms.OfType<Productos>().FirstOrDefault();
                    Productos hijo = form ?? new Productos();
                    Globales.ventana = 2;
                    Index.ActiveForm.Width = Globales.tamañoInicial;
                    Contenedor.Width = Globales.ContIndexInicial;
                    AddFormInPanel(hijo);
                }
            }
        }

        private void btnPrestamos_Click(object sender, EventArgs e)
        {
            if (Globales.ventana != 3)
            {
                if (MessageBox.Show("Abrir ventana? Se perderán los cambios que no hayan sigo guardados", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                {
                    var form = Application.OpenForms.OfType<Prestamos>().FirstOrDefault();
                    Prestamos hijo = form ?? new Prestamos();
                    Globales.ventana = 3;
                    Index.ActiveForm.Width = Globales.tamañoInicial;
                    Contenedor.Width = Globales.ContIndexInicial;
                    AddFormInPanel(hijo);
                }
            }   
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            if (Globales.ventana != 4)
            {
                if (MessageBox.Show("Abrir ventana? Se perderán los cambios que no hayan sigo guardados", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                {
                    var form = Application.OpenForms.OfType<Reportes>().FirstOrDefault();
                    Reportes hijo = form ?? new Reportes();
                    Globales.ventana = 4;
                    Index.ActiveForm.Width = Globales.tamañoInicial;
                    Contenedor.Width = Globales.ContIndexInicial;
                    AddFormInPanel(hijo);
                }
            }
                    
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            if (Globales.ventana != 5)
            {
                if (MessageBox.Show("Abrir ventana? Se perderán los cambios que no hayan sigo guardados", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                {
                    var form = Application.OpenForms.OfType<Usuarios>().FirstOrDefault();
                    Usuarios hijo = form ?? new Usuarios();
                    Globales.ventana = 5;
                    Index.ActiveForm.Width = Globales.tamañoInicial;
                    Contenedor.Width = Globales.ContIndexInicial;
                    AddFormInPanel(hijo);
                }
            }
                    
        }

        private void Index_Closing(object sender, FormClosingEventArgs e)
        {

            padre.Close();
            Application.Exit();
        }

        private void AddFormInPanel(Form formHijo)
        {
            if (this.Contenedor.Controls.Count > 0)
                this.Contenedor.Controls.RemoveAt(0);

            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            this.Contenedor.Controls.Add(formHijo);
            this.Contenedor.Tag = formHijo;
            formHijo.Show();
        }

        private void Index_Load(object sender, EventArgs e)
        {
            Globales.ventana = 0;
            Globales.tamañoInicial = this.Size.Width;
            Globales.ContIndexInicial = Contenedor.Width;
            if (Globales.idrango != 1)
            {
                btnUsuarios.Visible = false;
                btnUsuarios.Enabled = false;
            }
            this.Text = "Inicio - Usuario: " + Globales.usuario;
        }

       

        private void dateHour_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
            lblDate.Text= DateTime.Now.ToShortDateString();
            lblUser.Text = Globales.usuario;
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Form1 inde = new Form1();
            inde.Show();
            this.Close();
        }

       
    }
}
