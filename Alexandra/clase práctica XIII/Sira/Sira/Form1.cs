using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sira
{
    public partial class Form1 : Form
    {
        private readonly EstudianteMCN _metodos;
        public Form1()
        {
            InitializeComponent();
            _metodos = new EstudianteMCN();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Imprimir();
        }

        void Imprimir()
        {
            dgvImprimir.DataSource = _metodos;
            dgvImprimir.DataSource = _metodos.Imprimir();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                EstudianteCN est = new EstudianteCN 
            
                {
                
                    Carnet = int.Parse(tbCarnet.Text),
                    Nombres = tbNombres.Text,
                    Apellidos = tbApellidos.Text,
                    FechaNacimiento =  dtpFechaNacimiento.Value,
                    Nota = int.Parse(tbNota.Text),
                };

                _metodos.Insertar(est);
                MessageBox.Show("Se ha registrado exitosamente el estudiante");
                Imprimir();
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error");
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            Imprimir();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            _metodos.Eliminar(int.Parse(tbCarnet.Text));
            Imprimir();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            _metodos.Modificar(new EstudianteCN
            {
                Carnet = int.Parse(tbCarnet.Text),
                Nombres = tbNombres.Text,
                Apellidos = tbApellidos.Text,
                FechaNacimiento = dtpFechaNacimiento.Value,
                Nota = int.Parse(tbNota.Text)
            });
            Imprimir();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            EstudianteCN est = _metodos.Mostrar(int.Parse(tbCarnet.Text));
            tbCarnet.Text = est.Carnet.ToString();
            tbNombres.Text = est.Nombres;
            tbApellidos.Text = est.Apellidos;
            tbNota.Text = est.Nota.ToString();
            dtpFechaNacimiento.Value = est.FechaNacimiento.Value;

            dgvImprimir.DataSource = null;
            dgvImprimir.DataSource = new List<EstudianteCN> { est };
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}