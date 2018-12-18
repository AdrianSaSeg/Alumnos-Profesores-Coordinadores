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
            _DatosTabla = dataGridView;
            _Texto = texto;
        }

        private void FormBuscar_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _DatosTabla;
        }
    }
}
