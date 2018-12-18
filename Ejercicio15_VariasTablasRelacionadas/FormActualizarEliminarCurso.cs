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
    public partial class FormActualizarEliminarCurso : Form
    {
        public DataGridView _DatosCurso { get; set; }
        public string _Texto { get; set; }

        public FormActualizarEliminarCurso()
        {
            InitializeComponent();
        }

        public FormActualizarEliminarCurso(DataGridView datosCurso, string texto)
        {
            InitializeComponent();
            _DatosCurso = datosCurso;
            _Texto = texto;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //obtengo el indice de la fila seleccionada
            int i = _DatosCurso.SelectedCells[0].RowIndex;

            //editamos las filas con los valores de los textos
            _DatosCurso.Rows[i].Cells[0].Value = textBox1.Text;
            _DatosCurso.Rows[i].Cells[1].Value = dateTimePicker1.Text;
            _DatosCurso.Rows[i].Cells[2].Value = textBox3.Text;
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Estás seguro de eliminar los cursos seleccionados?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                foreach (DataGridViewRow i in _DatosCurso.SelectedRows)
                {
                    _DatosCurso.Rows.Remove(i);
                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
