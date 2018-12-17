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
    public partial class FormInsertarCurso : Form
    {
        public DataGridView _DatosCurso { get; set; }
        public string _Texto { get; set; }

        public FormInsertarCurso()
        {
            InitializeComponent();
        }

        public FormInsertarCurso(DataGridView datosCurso, string texto)
        {
            InitializeComponent();
            _DatosCurso = datosCurso;
            _Texto = texto;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            _DatosCurso.Rows.Add(textBox1.Text, dateTimePicker1.Value, textBox3.Text);
                        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
