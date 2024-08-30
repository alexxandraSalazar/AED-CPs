using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase_prática
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Persona[] Instancia;
        int Tam, N;

        void Limpiar()
        {
            txtNombres.Clear();
            txtApellidos.Clear();
            txtAño.Clear();
            txtTelefono.Clear();
            txtNombres.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lbImprimir_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCantidad_Click(object sender, EventArgs e)
        {
            Tam = int.Parse(txtCantidad.Text);
            Instancia = new Persona[Tam];
            N = 0;

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (N <= Tam - 1)
            {
                Instancia[N] = new Persona();
                Instancia[N].Nombres = txtNombres.Text;
                Instancia[N].Apellidos = txtApellidos.Text;
                Instancia[N].Telefono = int.Parse(txtTelefono.Text);
                Instancia[N].Año = int.Parse(txtAño.Text);

                MessageBox.Show("Persona registrada");
                Limpiar();
                N = N + 1;
            }
            else
            {
                MessageBox.Show("No hay espacio");
            }

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            lbImprimir.Items.Clear();

            for (int i = 0; i < N; i++)
            {
                int edad = Instancia[i].Edad(Instancia[i].Año);
                lbImprimir.Items.Add(Instancia[i].Imprimir() + "\t" + edad);
            }

        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
