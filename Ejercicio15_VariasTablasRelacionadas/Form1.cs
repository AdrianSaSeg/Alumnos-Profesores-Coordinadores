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
using System.Data.OleDb;
using MySql.Data.MySqlClient;

namespace Ejercicio15_VariasTablasRelacionadas
{
    
    public partial class Form1 : Form
    {
        string fichero;
        public Bitmap _Bitmap { get; set; }
        BD bd = new BD();
        public Form1()
        {
            InitializeComponent();

        }

        private void AbrirExcel(DataGridView dataGrid)
        {
            string file = "";   //variable for the Excel File Location
            DataTable dt = new DataTable();   //container for our excel data
            DataRow row;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            DialogResult result = openFileDialog.ShowDialog();  // Show the dialog.
            if (result == DialogResult.OK)   // Check if Result == "OK".
            {
                file = openFileDialog.FileName; //get the filename with the location of the file
                try

                {
                    //Create Object for Microsoft.Office.Interop.Excel that will be use to read excel file

                    Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();

                    Microsoft.Office.Interop.Excel.Workbook excelWorkbook = excelApp.Workbooks.Open(file);

                    Microsoft.Office.Interop.Excel._Worksheet excelWorksheet = excelWorkbook.Sheets[1];

                    Microsoft.Office.Interop.Excel.Range excelRange = excelWorksheet.UsedRange;


                    int rowCount = excelRange.Rows.Count;  //get row count of excel data

                    int colCount = excelRange.Columns.Count; // get column count of excel data

                    //Get the first Column of excel file which is the Column Name                  

                    for (int i = 1; i <= rowCount; i++)
                    {
                        for (int j = 1; j <= colCount; j++)
                        {
                            dt.Columns.Add(excelRange.Cells[i, j].Value2.ToString());
                        }
                        break;
                    }
                    //Get Row Data of Excel              
                    int rowCounter;  //This variable is used for row index number
                    for (int i = 2; i <= rowCount; i++) //Loop for available row of excel data
                    {
                        row = dt.NewRow();  //assign new row to DataTable
                        rowCounter = 0;
                        for (int j = 1; j <= colCount; j++) //Loop for available column of excel data
                        {
                            //check if cell is empty
                            if (excelRange.Cells[i, j] != null && excelRange.Cells[i, j].Value2 != null)
                            {
                                row[rowCounter] = excelRange.Cells[i, j].Value2.ToString();
                            }
                            else
                            {
                                row[i] = "";
                            }

                            rowCounter++;
                        }
                        dt.Rows.Add(row); //add row to DataTable
                    }

                    dataGrid.DataSource = dt; //assign DataTable as Datasource for DataGridview
              
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void GuardarExcel(DataGridView dataGrid)
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
              
                // creamos un bucle para rellenar las cabeceras del excel con las cabeceras del datagrid
                for (int f = 0; f < dataGrid.Columns.Count; f++)
                {
                    hoja_trabajo.Cells[1, f + 1] = dataGrid.Columns[f].DataPropertyName;   //   
                }

                int g = 0;  // variable para controlar los valores del datagrid que tienen que ir uno por detrás de las filas
                            // del excel
                for (int i = 1; i < dataGrid.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGrid.Columns.Count; j++)
                    {
                        hoja_trabajo.Cells[i + 1, j + 1] = dataGrid.Rows[g].Cells[j].Value.ToString();

                    }
                    g++;  // incrementamos el valor del datagrid
                }
                libros_trabajo.SaveAs(saveFileDialog.FileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
                libros_trabajo.Close(true);
                aplicacion.Quit();
            }
        }
        
        private void ImprimirDataGrid(DataGridView dg)
         {
            Bitmap bitmap; 
            //Resize DataGridView to full height.
             int height = dg.Height;
             dg.Height = dg.RowCount * dg.RowTemplate.Height;

             //Create a Bitmap and draw the DataGridView on it.
             bitmap = new Bitmap(dg.Width, dg.Height);
             dg.DrawToBitmap(bitmap, new Rectangle(0, 0, dg.Width, dg.Height));

            //mapeo el bitmap creado con una propiedad global
            _Bitmap = bitmap;
            
            //Resize DataGridView back to original height.
             dg.Height = height;

             //Show the Print Preview Dialog.
             printPreviewDialog1.Document = printDocument1;
             printPreviewDialog1.PrintPreviewControl.Zoom = 1;
             printPreviewDialog1.ShowDialog();
         }

        

        //////////////EVENTOS/////////////////

        private void profesoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInsertar formInsertarProfesor = new FormInsertar(dg_profesores, dg_cursos, "Nuevo Profesor");
            formInsertarProfesor.ShowDialog();
        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInsertar formInsertarAlumno = new FormInsertar(dg_alumnos, dg_cursos, "Nuevo Alumno");
            formInsertarAlumno.ShowDialog();
        }

        private void coordinadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInsertar formInsertarCoordinador = new FormInsertar(dg_coordinadores, dg_cursos, "Nuevo Coordinador");
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
                          
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void profesoresBuscar_Click(object sender, EventArgs e)
        {
            FormBuscar formBuscar = new FormBuscar(dg_profesores, "Buscar en registro de Profesores");
            formBuscar.ShowDialog();
        }

        private void alumnosBuscar_Click(object sender, EventArgs e)
        {
            FormBuscar formBuscar = new FormBuscar(dg_alumnos, "Buscar en registro de Alumnos");
            formBuscar.ShowDialog();
        }

        private void coordinadoresBuscar_Click(object sender, EventArgs e)
        {
            FormBuscar formBuscar = new FormBuscar(dg_coordinadores, "Buscar en registro de Coordinadores");
            formBuscar.ShowDialog();
        }
            
        private void profesoresAbrirExcel_Click(object sender, EventArgs e)
        {
            AbrirExcel(dg_profesores);
        }
      
        private void alumnosAbrirExcel_Click(object sender, EventArgs e)
        {
            AbrirExcel(dg_alumnos);
        }

        private void coordinadoresAbrirExcel_Click(object sender, EventArgs e)
        {
            AbrirExcel(dg_coordinadores);
        }

        private void cursosAbrirExcel_Click(object sender, EventArgs e)
        {
            AbrirExcel(dg_cursos);
        }

        private void alumnosImprimirDataGrid_Click(object sender, EventArgs e)
        {
            ImprimirDataGrid(dg_alumnos);
        }

        private void coordinadoresImprimirDataGrid_Click(object sender, EventArgs e)
        {
            ImprimirDataGrid(dg_coordinadores);
        }

        private void cursosImprimirDataGrid_Click(object sender, EventArgs e)
        {
            ImprimirDataGrid(dg_cursos);
        }

        private void profesoresImprimirDataGrid_Click(object sender, EventArgs e)
        {
            ImprimirDataGrid(dg_profesores);
        }

        private void printDocument1_PrintPage_1(object sender, PrintPageEventArgs e)
        {
            //Print the contents.
            e.Graphics.DrawImage(_Bitmap, 0, 0);
        }
   
        /*private void alumnosInsertarEnBDToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            bd.InsertarEnBD(dg_alumnos);
        }*/

        /*private void alumnosActualizarBDToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            bd.ActualizarBD(dg_alumnos);
        }*/

        private void alumnosBorrarEnBDToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            bd.BorrarEnBD(dg_alumnos);
        }

        private void alumnosImportarDesdeBDToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            bd.recibeBD(dg_alumnos, "Aula_alumnos");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BD conexion = BD.GetInstance();

            if (conexion._connection != null)
            {
                label5.BackColor = Color.Green;
                label5.Text = "Conexión OK";
            }
            else
            {
                label5.BackColor = Color.Red;
                label5.Text = "No se ha establecido conexión con la Base de Datos";
            }
        }
    }
}
