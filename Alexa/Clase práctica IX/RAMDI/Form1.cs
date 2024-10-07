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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        frmServicios frmServ = new frmServicios();
        frmPago frmPag = new frmPago();

        private void serviciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmServ.MdiParent = this;
            frmServ.Show(); 
            frmPag.Hide();
        }

        private void pagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPag.MdiParent = this;
            frmServ.Hide();
            frmPag.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
