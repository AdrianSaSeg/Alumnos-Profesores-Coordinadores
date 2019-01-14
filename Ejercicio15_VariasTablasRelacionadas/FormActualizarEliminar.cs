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
        public string _Tabla { get; set; }

        //creamos la propiedad donde guardar el valor anterior para actualizar en la BD
        public string _NombreAnterior { get; set; }
        
        public FormActualizarEliminar()
        {
            InitializeComponent();
        }

        public FormActualizarEliminar(DataGridView datosEntidad, string texto, string tabla)
        {
            InitializeComponent();
            _DatosEntidad = datosEntidad;
            _Texto = texto;
            _Tabla = tabla;
        }

        private void FormActualizarEliminar_Load(object sender, EventArgs e)
        {
            this.Text = _Texto;
            
            //obtengo el indice de la fila seleccionada
            int i = _DatosEntidad.SelectedCells[0].RowIndex;

            //cargamos los textbox del formulario con los datos de la fila seleccionada
            textBox1.Text = _DatosEntidad.Rows[i].Cells[0].Value.ToString();
            textBox2.Text = _DatosEntidad.Rows[i].Cells[1].Value.ToString();
            textBox3.Text = _DatosEntidad.Rows[i].Cells[2].Value.ToString();
            textBox4.Text = _DatosEntidad.Rows[i].Cells[3].Value.ToString();
            comboBox1.SelectedItem = comboBox1.Items.IndexOf("test1");

            _NombreAnterior = textBox1.Text;

        }

        private void button1_Click(object sender, EventArgs e)
        {
                        
            //obtengo el indice de la fila seleccionada
            int i = _DatosEntidad.SelectedCells[0].RowIndex;

            //editamos las filas con los valores de los textos
            _DatosEntidad.Rows[i].Cells[0].Value = textBox1.Text;
            _DatosEntidad.Rows[i].Cells[1].Value = textBox2.Text;
            _DatosEntidad.Rows[i].Cells[2].Value = textBox3.Text;
            _DatosEntidad.Rows[i].Cells[3].Value = textBox4.Text;
            _DatosEntidad.Rows[i].Cells[4].Value = comboBox1.SelectedItem;

            DialogResult dialogResult = MessageBox.Show("¿Quieres actualizar éste usuario tembién en la base de datos?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                //Añadimos también a la BD
                BD conexion = BD.GetInstance();

                conexion.ActualizarBD(_Tabla, _NombreAnterior, textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
               
            }        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Estás seguro de eliminar los usuarios seleccionados?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                foreach(DataGridViewRow i in _DatosEntidad.SelectedRows)
                {
                    _DatosEntidad.Rows.Remove(i);
                }

                BD conexion = BD.GetInstance();
                conexion.BorrarEnBD(_Tabla, _NombreAnterior);
            }           
        }       
    }
}
