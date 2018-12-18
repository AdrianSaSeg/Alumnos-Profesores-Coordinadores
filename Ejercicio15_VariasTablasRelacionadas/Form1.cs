using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop;

namespace Ejercicio15_VariasTablasRelacionadas
{
    public partial class Form1 : Form
    {
        string fichero;

        public Form1()
        {
            InitializeComponent();
            
        }

        private void GuardarExcel (DataGridView dataGrid)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel (*xls)|*.xls";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Microsoft.Office.Interop.Excel.Application aplicacion;
                Microsoft.Office.Interop.Excel.Workbook libros_trabajo;
                Microsoft.Office.Interop.Excel.Worksheet hoja_trabajo;
                aplicacion = new Microsoft.Office.Interop.Excel.Application();
                libros_trabajo = aplicacion.Workbooks.Add();
                hoja_trabajo = (Microsoft.Office.Interop.Excel.Worksheet)libros_trabajo.Worksheets.get_Item(1);

                //Recorremos el DataGridView rellenando la hoja de trabajo
                for (int i = 0; i < dataGrid.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dataGrid.Columns.Count; j++)
                    {
                        hoja_trabajo.Cells[i + 1, j + 1] = dataGrid.Rows[i].Cells[j].Value.ToString();
                    }
                }
                libros_trabajo.SaveAs(saveFileDialog.FileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
                libros_trabajo.Close(true);
                aplicacion.Quit();
            }
        }

        private void Pd_PrintPage(object sender, PrintPageEventArgs e)
        {
            int pos;
            int líneas;
            StringFormat sf = StringFormat.GenericTypographic;

            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            e.Graphics.DrawString(fichero, Font, Brushes.Black, e.MarginBounds, sf);
            e.Graphics.MeasureString(fichero, Font, new SizeF(e.MarginBounds.Width, e.MarginBounds.Height), sf, out pos, out líneas);

            fichero = fichero.Substring(pos);
            e.HasMorePages = fichero.Trim().Length > 0;
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
                             
        private void dg_profesores_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            FormActualizarEliminar formActualizarEliminar = new FormActualizarEliminar(dg_profesores, "Actualizar/Eliminar Profesor");
            formActualizarEliminar.ShowDialog();
        }

        private void dg_alumnos_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            FormActualizarEliminar formActualizarEliminar = new FormActualizarEliminar(dg_alumnos, "Actualizar/Eliminar Alumno");
            formActualizarEliminar.ShowDialog();
        }

        private void dg_coordinadores_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            FormActualizarEliminar formActualizarEliminar = new FormActualizarEliminar(dg_coordinadores, "Actualizar/Eliminar Coordinador");
            formActualizarEliminar.ShowDialog();
        }

        private void dg_cursos_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            FormActualizarEliminarCurso formActualizarEliminarCurso = new FormActualizarEliminarCurso(dg_cursos, "Actualizar/Eliminar Curso");
            formActualizarEliminarCurso.ShowDialog();
        }

        private void profesoresGuardarExcel_Click(object sender, EventArgs e)
        {
            GuardarExcel(dg_profesores);
        }

        private void alumnosGuardarExcel_Click(object sender, EventArgs e)
        {
            GuardarExcel(dg_alumnos);
        }
      
        private void coordinadoresGuardarExcel_Click(object sender, EventArgs e)
        {
            GuardarExcel(dg_coordinadores);
        }

        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fichero = File.ReadAllText(@"C:\Users\Adrian Sanchez\Desktop\profesores.xls", Encoding.Default);

            PrintDocument pd = new PrintDocument();
            pd.PrintPage += Pd_PrintPage;
            pd.Print();
        }
              
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void profesoresBuscar_Click(object sender, EventArgs e)
        {
            FormBuscar formBuscar = new FormBuscar(dg_profesores, "Buscar en registro de Profesores");
            formBuscar.ShowDialog();
        }
    }
}
