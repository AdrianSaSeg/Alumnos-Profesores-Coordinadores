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
    public partial class FormInsertar : Form
    {
        public DataGridView _DatosEntidad { get; set; }
        public string _Texto { get; set; }

        public FormInsertar()
        {
            InitializeComponent();
        }

        public FormInsertar(DataGridView datosEntidad, string texto)
        {
            InitializeComponent();
            _DatosEntidad = datosEntidad;
            _Texto = texto;
        }

        private DataTable GetGridTable()
        {
            DataTable l_dtGridTable = new DataTable();          
            l_dtGridTable.Columns.Add("Nombre", typeof(string));

            return l_dtGridTable;
        }
    

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                _DatosEntidad.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, comboBox1.Text);
            }
            catch (FormatException ex)
            {

                MessageBox.Show(ex.Message + " Introduce un número en la casilla teléfono");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }   
    }
}
