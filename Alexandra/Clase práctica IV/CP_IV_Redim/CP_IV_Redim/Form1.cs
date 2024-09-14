namespace CP_IV_Redim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Declarar arreglo global de tipo Persona
        Persona[] Instancia;
        // Variable N para llevar el conteo de las personas que han sido agregadas
        int N;

        /* Ya no se utilizara la variable "Tam" para darle el tamaño 
            ya que se le estara actualizando el tamaño conforme se vayan
            agregando mas datos */

        /* METODOS GLOBALES */

        // Metodo para limpiar las textboxs, y se le añade un Focus para que cada que se guarde
        // una persona, se posicione automaticamente en el nombre, esto ayuda al usuario a agilizar el proceso
        void Limpiar()
        {
            tbNombres.Clear();
            tbApellidos.Clear();
            tbTelefono.Clear();
            tbAño.Clear();
            tbNombres.Focus();
        }

        // Metodo para Agregar a las persona
        void Agregar()
        {
            /*  Funcion para actualizar el tamaño del arreglo cada vez que se va agregando una nueva persona
                toma como parametros una referencia, que en este caso es el arreglo, y el nuevo tamaño.
                
                Si N vale 0, Tomara 0 + 1 = 1 y asi sucesivamente cada que se vaya agregando un nuevo usuario
                Si N vale 1, sera: 1 + 1 = 2, esto lo que hace es crearle un espacio a la persona que se agregara al arreglo
                Si N es 1, abra una casilla que sera de indice 0, si N es 2, habra una casilla de indice 1...*/

            Array.Resize(ref Instancia, N + 1);
            Instancia[N] = new Persona(); // se realiza la instancia

            /*  Se van a ir guardando los datos ingresados por el usuario en cada textbox a los atributos del arreglo de tipo persona
                Si N = 0, se guardaran todos los datos en el indice 0
                Si N = 5, se guardaran todos los datos en el indice 5
                N representa el indice del arreglo  */

            Instancia[N].Nombres = tbNombres.Text;
            Instancia[N].Apellidos = tbApellidos.Text;
            Instancia[N].Telefono = int.Parse(tbTelefono.Text);
            Instancia[N].Año = int.Parse(tbAño.Text);

            /*  Se incrementa N, para asi si se llega a agregar a una Nueva Persona se guardara en el siguiente indice
                Pero antes de eso, se redimensionara el arreglo(Linea 42) para que se guarde correctamente  */
            N = N + 1;

            //  Se informa al usuario que fue guardado correctamente
            MessageBox.Show("Persona Ingresada Correctamente");

            //  Y Se manda a Limpiar los datos de los textboxs
            Limpiar();
        }

        /*  Metodo de Click del Boton Agregar  */
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Se manda a llamar la Funcion Agregar
            Agregar();
        }

        /*  Metodo de Click del Boton Imprimir  */
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            /*  Anteriormente se usaba un ciclo for para imprimir los datos
                existentes en el arreglo, sin embargo como se esta utilizando un
                DataGridView, no es necesario el uso del ciclo.
            
                dgvImprimir.DataSource = null;, primeramente se realiza esto para desconectar la fuente de datos
                lo que asegura que se muestre correctamente de nuevo lo que queremos que se vea 
            
                dgvImprimir.DataSource = Instancia;, es para pasarle la fuente de datos, en este caso es el arreglo
                de tipo Persona */

            dgvImprimir.DataSource = null;
            dgvImprimir.DataSource = Instancia;
        }

        /*  Metodo de KeyPress, para que cada vez que se de entener en el textBox de Año
            se agregue la persona, esto como se decia anteriormente, ayuda a agilizar la entrada de datos   */


        /*  Para activar esta funcion, se debe de ir primeramente al TextBox a la cual se le quiere dar esa funcion
            ir a las propiedades del boton, buscar los eventos(El rayito) en la categoria Key/Tecla, se debe de dar doble click
            donde dice KeyPress/Tecla Presionada*/
        private void tbAño_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Una condicional para ver si el usuario presiona enter, que en ascii es 13
            if (e.KeyChar == 13)
            {
                //  En caso que lo presione, mandar a llamar el metodo de agregar
                Agregar();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dgvImprimir_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
