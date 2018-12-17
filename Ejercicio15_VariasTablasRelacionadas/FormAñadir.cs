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
    public partial class FormAñadir : Form
    {
        public DataGridView _DatosUsuarios { get; set; }
        
        public FormAñadir()
        {
            InitializeComponent();
        }

        public FormAñadir(DataGridView datosUsuarios)
        {
            InitializeComponent();
            _DatosUsuarios = datosUsuarios; 
        }

        
    }
}
