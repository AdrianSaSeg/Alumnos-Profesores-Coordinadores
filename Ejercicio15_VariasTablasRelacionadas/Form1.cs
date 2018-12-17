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
            FormInsertar formInsertarProfesor = new FormInsertar(dg_profesores, "Nuevo Profesor");
            formInsertarProfesor.ShowDialog();
        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInsertar formInsertarAlumno = new FormInsertar(dg_alumnos, "Nuevo Alumno");
            formInsertarAlumno.ShowDialog();
        }

        private void coordinadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInsertar formInsertarCoordinador = new FormInsertar(dg_coordinadores, "Nuevo Coordinador");
            formInsertarCoordinador.ShowDialog();
        }

        private void cursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInsertarCurso formInsertarCurso = new FormInsertarCurso(dg_cursos, "Nuevo Curso");
            formInsertarCurso.ShowDialog();
        }       
        
        private void dg_profesores_DoubleClick(object sender, EventArgs e)
        {
            FormActualizarEliminar formActualizarEliminar = new FormActualizarEliminar(dg_profesores, "Actualizar/Eliminar Profesor");
            formActualizarEliminar.ShowDialog();
        }

        private void dg_alumnos_DoubleClick(object sender, EventArgs e)
        {
            FormActualizarEliminar formActualizarEliminar = new FormActualizarEliminar(dg_alumnos, "Actualizar/Eliminar Alumno");
            formActualizarEliminar.ShowDialog();
        }

        private void dg_coordinadores_DoubleClick(object sender, EventArgs e)
        {
            FormActualizarEliminar formActualizarEliminar = new FormActualizarEliminar(dg_coordinadores, "Actualizar/Eliminar Coordinador");
            formActualizarEliminar.ShowDialog();
        }
    }
}
