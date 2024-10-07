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
    public partial class frmServicios : Form
    {
        public frmServicios()
        {
            InitializeComponent();
        }

        void Limpiar()
        {
            txtId.Clear();
            txtDescripcion.Clear(); 
            txtPrecio.Clear();  
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Declaraciones.Servicios.Add(new Servicio
            {
                IdServicio = int.Parse(txtId.Text),
                Descripcion = txtDescripcion.Text,
                Precio = decimal.Parse(txtPrecio.Text),
            });
            MessageBox.Show("Agregado exitosamente");
            Limpiar();  
        }

        private void frmServicios_Load(object sender, EventArgs e)
        {

        }
    }
}
