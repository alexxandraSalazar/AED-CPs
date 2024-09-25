using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CP_Pilas

    /*  OBJETIVO PRINCIPAL DE LAS PILAS, METER Y SACAR  */
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //  DECLARACION DE LA PILA

        Stack<string> PilaNombre = new Stack<string>();

        void Imprimir(ListBox listBox)
        {
            //  Limpiar tb recibido
            listBox.Items.Clear();

            //  Recorrer elementos en Pila
            foreach (var item in PilaNombre)
            {
                //  insertar elemento actual
                listBox.Items.Add(item);
                listBox.Items.Add("____________________");
            }
        }

        void Agregar()
        {
            //  Agreagr a la pila el contenido del tb
            PilaNombre.Push(tbElementoAApilar.Text);

            //  Imprimiendo en el listbox "lbPila"
            Imprimir(lbPilaOriginal);

            //  Limpiar tb y establecer foco en el tb para ingresar otro
            tbElementoAApilar.Clear();
            tbElementoAApilar.Focus();
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnApilar_Click(object sender, EventArgs e)
        {
            Agregar();
        }

        private void btnCopiar_Click(object sender, EventArgs e)
        {
            //  Imprimir la pila en el lb "lbCopiaPila"
            Imprimir(lbCopiaPila);
        }

        private void btnDesapilar_Click(object sender, EventArgs e)
        {
            //  Verificar si el contador de la pila es == 0
            if(PilaNombre.Count == 0)
            {
                //  Imprimimos que no existe elemento en pila
                MessageBox.Show("No hay elementos en pila");
                //  Salir del metodo
                return;
            }

            //  Agregar en el lb de imprimir el elemento de la pila con el metodo pop
            lbImprimir.Items.Add("Popping / Desapilado: " + PilaNombre.Pop());

            //  Imprimimos la pila en "lbPilaCopia"
            Imprimir(lbPilaOriginal);
        }

        private void btnPrimeroEnFila_Click(object sender, EventArgs e)
        {
            if(PilaNombre.Count == 0)
            {
                MessageBox.Show("No hay elementos en la pila");
                return;
            }

            //  lbImprimir.Items.Clear();
            //  Agregar el primer elemento de la pila con el metodo Peek
            lbImprimir.Items.Add("Primer Elemento en Pila: " + PilaNombre.Peek());
        }

        private void tbElementoAApilar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter) 
             Agregar(); 
        }

    }
}
