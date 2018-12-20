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
    public partial class FormBuscar : Form
    {
        public DataGridView _DatosTabla { get; set; }
        public string _Texto { get; set; }

        public FormBuscar()
        {
            InitializeComponent();
        }

        public FormBuscar (DataGridView dataGridView, string texto)
        {
            InitializeComponent();
            _DatosTabla = dataGridView;
            _Texto = texto;
            
        }

        /* private DataGridViewCell ObtenerCeldaConContenido(string searchText, DataGridView dataGridView, int columnIndex)
         {
             DataGridViewCell celdaDondeHayTexto = null;

             foreach (DataGridViewRow row in dataGridView.Rows)
             {

                 if (row.Cells[columnIndex].Value != null && searchText == row.Cells[columnIndex].Value.ToString())
                 {
                     // el texto searchText es igual al texto de la celda de la coolumna columnIndex.
                     celdaDondeHayTexto = row.Cells[columnIndex];

                     //añadir el elemento buscado al nuevo datagrid
                     dg_buscar.Rows.Add(_DatosTabla.Rows[row.Index].Cells[columnIndex].Value);
                     break;
                 }                
             }
             return celdaDondeHayTexto;
         }*/

        private void BuscarTextoSimilarEnCeldaDeDatagrid(TextBox t1, DataGridView dg, DataGridView result)
        {
            try
            {
                //Obtengo el valor del textbox
                string texto = t1.Text;

                //Recorro todas las filas del DataGridView
                for (int i = 0; i < dg.Rows.Count; i++)
                {
                    //Recorro todas las celdas de la primera columna de cada fila
                    for (int j = 0; j < dg.Rows[i].Cells.Count; j++)
                    {
                        //Obtengo el valor de cada celda
                        string str = Convert.ToString(dg.Rows[i].Cells[0].Value);

                        //Y lo comparo
                        if (str.Contains(texto))
                        {
                            dg.Rows[i].Cells[0].Style.BackColor = Color.GreenYellow;
                            result.Rows[i].Cells[0].Value = dg.Rows[i].Cells[0].Value;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"Criterio no encontrado = {e.Message}");
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            /*DataGridViewCell cell = ObtenerCeldaConContenido(textBox1.Text, _DatosTabla, 0);

            if (cell != null)
            {
                cell.Style = new DataGridViewCellStyle { ForeColor = Color.Red };
            }
            else
            {
                MessageBox.Show("No se encuentra el nombre buscado");
            }*/

            BuscarTextoSimilarEnCeldaDeDatagrid(textBox1, _DatosTabla, dg_buscar);
        }

        /*private void textBox1_TextChanged(object sender, EventArgs e)
        {
            BuscarTextoSimilarEnCeldaDeDatagrid(textBox1, _DatosTabla, dg_buscar);
        }*/
    }
}
