using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RAMDI
{
    public partial class frmPago : Form
    {
        public frmPago()
        {
            InitializeComponent();
        }

        private void Imprimir()
        {
            cbServicios.DataSource = null;
            cbServicios.DataSource = Declaraciones.Servicios;
            cbServicios.ValueMember = "IdServicio";
            cbServicios.DisplayMember = "Descripcion";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            int id = int.Parse(cbServicios.SelectedValue.ToString());

            foreach(var servicio in Declaraciones.Servicios)
                if(servicio.IdServicio  == id)
                {
                    MessageBox.Show($"El precio del servicio {servicio.Descripcion} es {servicio.Precio}");
                    break;
                }

        }

        private void frmPago_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                Imprimir();
            }
        }
    }
}
