using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClasePracticaArboles
{
    public partial class Form1 : Form
    {
        private InterfazArbol<int> _arbolDeBusquedaBinaria;
        public List<int> valoresInsertados;


        public Form1()
        {
            InitializeComponent();
        }

        private void CbRecorrido_SelectedIndexChanged(object sender, EventArgs e)
        {
            TbRecorrido.Text = "";
            lblRecorrido.Text = "Recorrido del arbol en " + CbRecorrido.Text + ":";
            var nodos = _arbolDeBusquedaBinaria.ObtenerNodos(CbRecorrido.SelectedIndex + 1)
                .Select(x => x.Valor).ToList();
            nodos.ForEach(nodo => TbRecorrido.Text += nodo.ToString() + " ");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _arbolDeBusquedaBinaria = new ArbolDeBusquedaBinaria<int>();
            valoresInsertados = new List<int>();
        }

        private void BtnInsertar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TbInsertar.Text))
            {
                MessageBox.Show("Debes ingresar un número", "Aviso");
                return;
            }
            if (!int.TryParse(TbInsertar.Text, out int value))
            {
                MessageBox.Show($"Se espera un valor de tipo {typeof(int)}", "Error");
                return;
            }

            _arbolDeBusquedaBinaria.Insertar(value);
            valoresInsertados.Add(value);

            TbValores.Text = " ";
            TbRecorrido.Text = " ";
            valoresInsertados.ForEach(valor => TbValores.Text += valor.ToString() + " ");
            TbRecorrido.Text = "";

            if (CbRecorrido.SelectedIndex != -1)
            {
                var nodos = _arbolDeBusquedaBinaria.ObtenerNodos(CbRecorrido.SelectedIndex + 1)
                               .Select(x => x.Valor).ToList();
                nodos.ForEach(nodo => TbRecorrido.Text += nodo.ToString() + " ");
            }

            MessageBox.Show("Valor insertado exitosamente");
        }

        private void BtnRemover_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TbRemover.Text))
            {
                MessageBox.Show("Debes ingresar un número", "Aviso");
                return;
            }
            if (!int.TryParse(TbRemover.Text, out int value))
            {
                MessageBox.Show($"Se espera un valor de tipo {typeof(int)}", "Error");
                return;
            }

            _arbolDeBusquedaBinaria.Remover(value);
            valoresInsertados.Remove(value);

            TbValores.Text = " ";
            valoresInsertados.ForEach(valor => TbValores.Text += valor.ToString() + " ");
            TbRecorrido.Text = "";

            if (CbRecorrido.SelectedIndex != -1)
            {
                var nodos = _arbolDeBusquedaBinaria.ObtenerNodos(CbRecorrido.SelectedIndex + 1)
                               .Select(x => x.Valor).ToList();
                nodos.ForEach(nodo => TbRecorrido.Text += nodo.ToString() + " ");
            }

            MessageBox.Show("Valor removido exitosamente");
        }
    }

    
}
