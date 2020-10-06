using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using CapaControlador;

namespace CapaVista
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AbrirFormEnPanel(object formhija)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();

        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new venta());
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new inicio());
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new inicio());
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new inicio());
        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new inicio());
        }

        private void btnFormulario_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new inicio());
        }
    }
}
