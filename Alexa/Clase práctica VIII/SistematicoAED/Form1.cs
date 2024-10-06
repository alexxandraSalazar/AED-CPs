using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistematicoAED
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

        //Declaraciones globales 
        Queue<string> ColaNombre = new Queue<string>();

        void Imprimir(ListBox listbox)
        {
            listbox.Items.Clear();

            foreach(var item in ColaNombre)
            {
                listbox.Items.Add(item);
                listbox.Items.Add("--------------------------------------------------");
            }
        }

        void Agregar()
        {
            ColaNombre.Enqueue(txtElemento.Text);

            Imprimir(lbCola);

            txtElemento.Clear();
            txtElemento.Focus();
        }

        private void btnEnqueue_KeyPress(object sender, KeyPressEventArgs e)
        {
            Agregar();
        }

        private void txtElemento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
                Agregar();
        }

        private void btnCopiar_Click(object sender, EventArgs e)
        {
            Imprimir(lbCopia);
        }

        private void btnDequeue_Click(object sender, EventArgs e)
        {
            if (ColaNombre.Count == 0)
            {
                MessageBox.Show("No hay elementos en la cola");
                return;
            }
            lbImprimir.Items.Add("se ha desencolado: " + ColaNombre.Dequeue());
            Imprimir(lbCopia);
        }

        private void btnPeek_Click(object sender, EventArgs e)
        {
            lbImprimir.Items.Add("Sigiente elemento en cola: " + ColaNombre.Peek());

        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar != Keys.Enter)
                return;

            if (ColaNombre.Contains(txtBuscar.Text))
                MessageBox.Show("Existe el Elemento");
            else
                MessageBox.Show("No existe el elemento");

            txtBuscar.Clear();
            txtBuscar.Focus();
        }

        private void btnEnqueue_Click(object sender, EventArgs e)
        {
            Agregar();
        }

        private void lbImprimir_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
