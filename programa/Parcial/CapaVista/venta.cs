using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControlador;

namespace CapaVista
{
    public partial class venta : Form
    {
        public venta()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Cls_aplicacion app = new Cls_aplicacion();
            //app.variables(txt_nombre_aplicacion.Text, txt_informe_de_aplicacion.Text);
        }
    }
}
