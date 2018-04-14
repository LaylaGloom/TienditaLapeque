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
            padre = padre_;

        }

        

        private void btnVentas_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<Ventas>().FirstOrDefault();
            Ventas hijo = form ?? new Ventas();
            AddFormInPanel(hijo);
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<Productos>().FirstOrDefault();
            Productos hijo = form ?? new Productos();
            AddFormInPanel(hijo);
        }

        private void btnPrestamos_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<Prestamos>().FirstOrDefault();
            Prestamos hijo = form ?? new Prestamos();
            AddFormInPanel(hijo);
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<Reportes>().FirstOrDefault();
            Reportes hijo = form ?? new Reportes();
            AddFormInPanel(hijo);
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<Usuarios>().FirstOrDefault();
            Usuarios hijo = form ?? new Usuarios();
            AddFormInPanel(hijo);
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
    }
}
