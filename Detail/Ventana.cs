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
            EstudiantesBll.Guardar(new Entidades.Estudiantes()
            {
                EstudianteId = Convert.ToInt32(IdEsttextBox.Text),
                Nombres = NombreEstudianteTextBox.Text
            });
            EstudiantesComboBox.DataSource = EstudiantesBll.GetLista();
        }

        private void Ventana_Load(object sender, EventArgs e)
        {
            EstudiantesComboBox.DataSource = EstudiantesBll.GetLista();
            EstudiantesComboBox.DisplayMember = "Nombres";
            EstudiantesComboBox.ValueMember = "EstudianteId";
            
        }
        private Grupos grupos = new Grupos();

        private void AgregarBoton_Click(object sender, EventArgs e)
        {
            grupos.Estudiantes.Add(new Estudiantes((int)EstudiantesComboBox.SelectedValue, EstudiantesComboBox.Text));
            ListaGridView1.DataSource = null;
            ListaGridView1.DataSource = grupos.Estudiantes;

        }

        private void BuscarBoton_Click(object sender, EventArgs e)
        {
            var grupo = GruposBll.Buscar(Convert.ToInt32(IdTextBox.Text));
            if (grupo != null)
            {
                GrupoTextBox.Text = grupo.Nombre;
            }
        }

        private void GuardarGrupo_Click(object sender, EventArgs e)
        {
            GruposBll.Guardar(new Grupos()
            {
                GrupoId = Convert.ToInt32(IdTextBox.Text),
                Nombre = GrupoTextBox.Text
            });
        }

        private void BuscarEstudiante_Click(object sender, EventArgs e)
        {
            var student = EstudiantesBll.Buscar(Convert.ToInt32(IdEsttextBox.Text));
            if (student != null)
            {
                NombreEstudianteTextBox.Text = student.Nombres;
            }
        }

        private void consultaEstudianteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UI.Consultas.Consulta c = new UI.Consultas.Consulta();
            c.Show();
        }

        private void EliminarEstuBoton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(IdEsttextBox.Text);

            EstudiantesBll.Eliminar(id);
            MessageBox.Show("Eliminado !");
            EstudiantesComboBox.DataSource = EstudiantesBll.GetLista();
            Limpiar();
        }

        private void EliminarGupoBoton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(IdTextBox.Text);

            GruposBll.Eliminar(id);
            MessageBox.Show("Eliminado !");
            EstudiantesComboBox.DataSource = EstudiantesBll.GetLista();
            Limpiar();
        }

        public void Limpiar()
        {
            IdTextBox.Clear();
            NombreEstudianteTextBox.Clear();
            GrupoTextBox.Clear();
            IdEsttextBox.Clear();
        }

        private void NuevoEstBoton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void NuevoGrupoBoton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
