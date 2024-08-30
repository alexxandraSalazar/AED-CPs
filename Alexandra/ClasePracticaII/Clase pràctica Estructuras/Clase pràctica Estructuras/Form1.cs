using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase_pràctica_Estructuras
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int Tam, N, i;

        public struct Fecha
        {
            public int Dia;
            public int Año;
            public string Mes;
        }

        public struct Datos
        {
            public String Carnet;
            public String Nombres;
            public String Apellidos;
            public String Sexo;
            public Fecha FechaNac;
        }

        Datos[] Registros;


        void Limpiar ()
        {
            txtCarnet.Clear();
            txtNombres.Clear();
            txtApellidos.Clear();
            txtAño.Clear();
            cbDia.SelectedIndex = -1; 
            cbMes.SelectedIndex = -1; 
            cbSexo.SelectedIndex = -1;
        }

        void Registrar()
        {
            if (N < Tam)
            {
                Registros[N].Carnet = txtCarnet.Text;
                Registros[N].Nombres = txtNombres.Text;
                Registros[N].Apellidos = txtApellidos.Text;
                Registros[N].Sexo = cbSexo.Text;
                Registros[N].FechaNac.Dia = int.Parse(cbDia.Text);
                Registros[N].FechaNac.Mes = cbMes.Text;
                Registros[N].FechaNac.Año = int.Parse(txtAño.Text);
                N++;

                MessageBox.Show("Registrado con éxito");
                Limpiar();
                txtCarnet.Focus();
            }

            else
            {
                MessageBox.Show("No hay espacio disponible");

            }
        }

        void Establecer()
        {
            Tam = int.Parse(txtCantidad.Text);
            Registros = new Datos[Tam];
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenido");
            cbSexo.Items.Add("F");
            cbSexo.Items.Add("M");

            for(int i = 1; i < 31; i ++)
            {
                cbDia.Items.Add(Convert.ToString(i));
            }

            cbMes.Items.Add("Enero");
            cbMes.Items.Add("Febrero");
            cbMes.Items.Add("Marzo");
            cbMes.Items.Add("Abril");
            cbMes.Items.Add("Mayo");
            cbMes.Items.Add("Junio");
            cbMes.Items.Add("Julio");
            cbMes.Items.Add("Agosto");
            cbMes.Items.Add("Septiembre");
            cbMes.Items.Add("Octubre");
            cbMes.Items.Add("Noviembre");
            cbMes.Items.Add("Diciembre");

        }



        private void btnBorrar_Click(object sender, EventArgs e)
        {
            int i = 0;
            string x = txtCarnet.Text;

            while(i < N && x != Registros[i].Carnet )
            {
                i ++;   
            }

            if(i >= N)
            {
                MessageBox.Show(x + " No está registrado");
            }
            else
            {
                for(int k = 1; k < N - 1; k++)
                {

                    Registros[k].Carnet = Registros[k + 1].Carnet;
                    Registros[k].Nombres = Registros[k + 1].Nombres;
                    Registros[k].Apellidos = Registros[k + 1].Apellidos;
                    Registros[k].Sexo = Registros[k + 1].Sexo;
                    Registros[k].FechaNac.Dia = Registros[k + 1].FechaNac.Dia;
                    Registros[k].FechaNac.Mes = Registros[k + 1].FechaNac.Mes;
                    Registros[k].FechaNac.Año = Registros[k + 1].FechaNac.Año;

                }    

                N = N - 1;
                MessageBox.Show("El estudiante con Carnet = " + x + " se ha eliminado");
            }

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            int i = 0;
            string x;
            x = txtCarnet.Text;


            while (i < N && x != Registros[i].Carnet)
            {
                i++;
            }

            if (i >= N)
            {
                MessageBox.Show(x + " No está registrado");
            }
            else
            {

                Registros[i].Carnet = txtCarnet.Text;
                Registros[i].Nombres = txtNombres.Text;
                Registros[i].Apellidos = txtApellidos.Text;
                Registros[i].Sexo = cbSexo.Text;
                Registros[i].FechaNac.Dia = int.Parse(cbDia.Text);
                Registros[i].FechaNac.Mes = cbMes.Text;
                Registros[i].FechaNac.Año = int.Parse(txtAño.Text);

                N = N - 1;
                MessageBox.Show("El estudiante con Carnet = " + x + " se ha actualizado");
            }

        }

        private void btnEstablecer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Establecer();
            }
        }



        private void btnEstablecer_Click(object sender, EventArgs e)
        {
            Establecer();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Registrar();
        }


        private void btnImprimir_Click(object sender, EventArgs e)
        {
            lbImprimir.Items.Clear();
            lbImprimir.Items.Add("Carnet" + "\t" + "Nombres" + "\t" + "Apellidos" + "\t" + "Sexo" + "\t" + "Dia" + "\t" + "Mes" + "\t" + "   Año");
                

            for (int i = 0; i < N; i++)
            {
                lbImprimir.Items.Add(Registros[i].Carnet + "\t" +
                                     Registros[i].Nombres + "\t" +
                                     Registros[i].Apellidos + "\t" +
                                     Registros[i].Sexo + "\t" +
                                     Registros[i].FechaNac.Dia + "\t" +
                                     Registros[i].FechaNac.Mes + "\t" +
                                     Registros[i].FechaNac.Año + "\t"
                    );
            }
         
        }


        private void txtAño_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar ==13)
            {
                Registrar();
            }
        }



    }
}
