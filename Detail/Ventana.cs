using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;
using Entidades;

namespace Detail
{
    public partial class Ventana : Form
    {
        public Ventana()
        {
            InitializeComponent();
        }

        private void AgregarEstBoton_Click(object sender, EventArgs e)
        {
           /* Estudiantes E = new Estudiantes( );

            if(EstudiantesBll.Guardar(E))
            {
                MessageBox.Show("Guardado");
            } */
        }

        private void EstudiantesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void Ventana_Load(object sender, EventArgs e)
        {
            EstudiantesComboBox.DataSource = EstudiantesBll.GetLista();
            EstudiantesComboBox.DisplayMember = "Nombres";
            EstudiantesComboBox.ValueMember = "EstudianteId";
        }

        private void ListaGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private Grupos grupos = new Grupos();

        private void AgregarBoton_Click(object sender, EventArgs e)
        {
           grupos.Estudiantes.Add(new Estudiantes((int)EstudiantesComboBox.SelectedValue, EstudiantesComboBox.Text));
            ListaGridView1.DataSource = null;
            ListaGridView1.DataSource = grupos.Estudiantes;
        }
    }
}
