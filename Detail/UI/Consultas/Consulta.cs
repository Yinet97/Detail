using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;
using Entidades;

namespace Detail.UI.Consultas
{
    public partial class Consulta : Form
    {
        public Consulta()
        {
            InitializeComponent();
        }

        List<Estudiantes> lista = new List<Estudiantes>();

        private void ConsultarBoton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(searchTextBox.Text))
            {
                lista = EstudiantesBll.GetLista(Utilidades.stringToInt(searchTextBox.Text));
                
            }
            else
            {
                lista = EstudiantesBll.GetLista();
            }
            ListadoDataGridView.DataSource = lista;
        }
    }
}
