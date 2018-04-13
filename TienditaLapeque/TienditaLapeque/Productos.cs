using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TienditaLapeque
{
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
        }
   
        private void tbxPName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetterOrDigit(e.KeyChar)) && !(char.IsControl(e.KeyChar));
            if (e.Handled = !(char.IsLetterOrDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                MessageBox.Show("No se admiten caracteres");
            }
        }
        
        private void tbxPPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar)) && !(char.IsControl(e.KeyChar)) && !(char.IsPunctuation(e.KeyChar));
            if (e.Handled = !(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsPunctuation(e.KeyChar)))
            {
                MessageBox.Show("No se admiten caracteres");
            }
        }

        private void tbxPCant_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar)) && !(char.IsControl(e.KeyChar));
            if (e.Handled = !(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                MessageBox.Show("No se admiten caracteres");
            }
        }

        public void RefrescarTabla()
        {
            
        }
    }
}
