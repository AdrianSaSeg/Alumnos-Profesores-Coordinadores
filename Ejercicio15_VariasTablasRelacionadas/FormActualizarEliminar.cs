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
    public partial class FormActualizarEliminar : Form
    {
        public DataGridView _DatosEntidad { get; set; }
        public string _Texto { get; set; }
        
        public FormActualizarEliminar()
        {
            InitializeComponent();
        }

        public FormActualizarEliminar(DataGridView datosEntidad, string texto)
        {
            InitializeComponent();
            _DatosEntidad = datosEntidad;
            _Texto = texto;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //obtengo el indice de la fila seleccionada
            int i = _DatosEntidad.SelectedCells[0].RowIndex;

            //editamos las filas con los valores de los textos
            _DatosEntidad.Rows[i].Cells[0].Value = textBox1.Text;
            _DatosEntidad.Rows[i].Cells[1].Value = textBox2.Text;
            _DatosEntidad.Rows[i].Cells[2].Value = textBox3.Text;
            _DatosEntidad.Rows[i].Cells[3].Value = comboBox1.SelectedItem;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
