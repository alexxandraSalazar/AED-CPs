namespace CPVI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int N = 0, Tam, i, Pos, x, x2;
        int[] Edad;
        int[] Id;
        string[] Nombres;

        void Limpiar()
        {
            txtId.Clear();
            txtNombre.Clear();
            txtCantidad.Clear();
        }

        int Busca(int x)
        {
            i = 0;

            while (i < N && Id[i] < x)
            {
                i++;
            }

            if (i >= N || Id[i] > x)
            {
                Pos = -i;
            }
            else
            {
                Pos = i;
            }

            return Pos;
        }

        void Eliminar(int x)
        {
            if (N > 0)
            {
                Pos = Busca(x);
                if (Pos <= -1)
                {
                    MessageBox.Show(x + " No esta registrado");
                }

                else
                {
                    for (i = Pos; i < N - 1; i++)
                    {
                        Id[i] = Id[i + 1];
                        Nombres[i] = Nombres[i + 1];
                        Edad[i] = Edad[i + 1];
                    }
                    N = N - 1;
                    MessageBox.Show("La persona con Id= " + x + " se ha eliminado");

                }
            }
            else
            {
                MessageBox.Show("No hay registros");
            }
        }

        void Insertar(int x)
        {

            if (N > 0)
            {
                if (N <= Tam - 1)
                {
                    Pos = Busca(x);
                    if (Pos > 0)
                    {
                        MessageBox.Show("El elemento ya existe");
                    }
                    else
                    {
                        Pos = Pos * -1;
                        for (i = N; i >= Pos + 1; i--)
                        {
                            Id[i] = Id[i - 1];
                            Edad[i] = Edad[i - 1];
                            Nombres[i] = Nombres[i - 1];
                        }
                        Id[Pos] = int.Parse(txtId.Text);
                        Edad[Pos] = int.Parse(txtEdad.Text);
                        Nombres[Pos] = txtNombre.Text;
                        N++;
                        MessageBox.Show("Elemento insertado");
                    }

                }
                else
                {
                    MessageBox.Show("No hay espacio");
                }
            }
            else
            {
                Id[Pos] = int.Parse(txtId.Text);
                Edad[Pos] = int.Parse(txtEdad.Text);
                Nombres[Pos] = txtNombre.Text;
                N++;
                MessageBox.Show("Elemento insertado");
            }
        }

        void Actualizar()
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnEstablecer_Click(object sender, EventArgs e)
        {
            Tam = int.Parse(txtCantidad.Text);
            Id = new int[Tam];
            Edad = new int[Tam];
            Nombres = new string[Tam];
            N = 0;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            x = int.Parse(txtId.Text);
            Insertar(x);
            Limpiar();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            x = int.Parse(txtId.Text);
            Eliminar(x);
            Limpiar();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            lbImprimir.Items.Clear();
            for (int i = 0; i < N; i++)
            {
                lbImprimir.Items.Add(Id[i] + "\t" + Nombres[i] + "\t" + Edad[i]);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (N > 0)
            {
                x2 = int.Parse(txtId.Text);
                Pos = Busca(x2);
                if (Pos <= -1)
                {
                    MessageBox.Show(x2 + " No esta ingresado");
                }
                else
                {

                    txtEdad.Text = Convert.ToString(Edad[Pos]);
                    txtNombre.Text = Nombres[Pos];
                    btnActualizar.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("No hay registros");
            }
        }


        private void btnActualizar_Click(object sender, EventArgs e)
        {
            x = int.Parse(txtId.Text);
            Eliminar(x);
            Insertar(x);
            Limpiar();

        }
    }
}
