using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPMDI
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }
        frmPrestamo prestamo = new frmPrestamo();
        frmEmpleado empleado = new frmEmpleado();

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            empleado.MdiParent = this;
            empleado.Show();
            prestamo.Hide();
        }

        private void prestamoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            prestamo.MdiParent = this;
            prestamo.Show();
            empleado.Hide();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                "Estás seguro que desea salir?",
                "Salir",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                ) == DialogResult.Yes) 
            {
                this.Close();
            }
            
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenido");
        }
    }
}
