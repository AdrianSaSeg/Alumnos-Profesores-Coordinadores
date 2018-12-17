using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio15_VariasTablasRelacionadas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void profesoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAñadir formAñadirProfesor = new FormAñadir(dg_profesores);
            formAñadirProfesor.ShowDialog();
        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAñadir formAñadirAlumno = new FormAñadir(dg_alumnos);
            formAñadirAlumno.ShowDialog();
        }

        private void coordinadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAñadir formAñadirCoordinador = new FormAñadir(dg_coordinadores);
            formAñadirCoordinador.ShowDialog();
        }
    }
}
