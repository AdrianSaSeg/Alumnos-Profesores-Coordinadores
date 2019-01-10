using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Ejercicio15_VariasTablasRelacionadas
{
    public class BD
    {
        public MySqlConnection _connection { get; set; }
        public DataGridView _datagrid { get; set; }
        private static BD instance = null;


        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string pass;

        private string nombre;
        private string apellido;
        private string telefono;
        private string email;

        //Método que consigue la referencia o crea una nueva instancia (Patrón Singleton)
        public static BD GetInstance()
        {
            if (instance == null)
            {
                instance = new BD();
            }
            return instance;
        }

        //Inicializar constructor
        public BD()
        {
            Inicializar();
        }

        //Inicializar variables
        public void Inicializar()
        {
            server = "gestion-academia.mysql.database.azure.com";
            database = "aula";
            uid = "AdrianSS@gestion-academia";
            pass = "ABC.1234";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + pass + ";";

            connection = new MySqlConnection(connectionString);

            //almaceno la conexion en una propiedad pública para poder realizar todas las operaciones CRUD
            _connection = connection;
        }

        //Abrir conexion con la BD
        private bool AbrirConexion()
        {
            try
            {
                _connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.

                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("No se puede conectar con el servidor");
                        break;

                    case 1045:
                        MessageBox.Show("Usuario/Contraseña incorrecto/a");
                        break;
                }
                return false;
            }
        }

        //Cerrar la conexion con la BD
        private bool CerrarConexion()
        {
            try
            {
                _connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message);
                return false;
            }
        }

        //Creamos el metodo para recibir los datos de los datagrid del form1
        private void recibeDataGrid(DataGridView dg_recibe, string tabla)
        {
            // limpio el Grid donde recibiré los datos
            dg_recibe.Rows.Clear();

            // Defino la consulta a realizar ( CRUD ) Crear.. Leer... Actualizar... Borrar...
            string sql = $"SELECT * FROM {tabla}";

            // le indico cómo voy a enviar la instrucción ... mediante un String / Procedimiento_Almacenado de la Base datos
            MySqlCommand cmd = new MySqlCommand(sql, _connection);

            //OPEN CON,RETRIEVE,FILL DGVIEW
            try
            {
                // abrir la conexión 
                _connection.Open();

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                // creo un datatable para recibir los datos de la Base de datos
                DataTable dt = new DataTable();

                // lleno los datos en el DataTable
                adapter.Fill(dt);

                // Lleno el DataGrid con los datos del DataTable.. fila a fila
                foreach (DataRow row in dt.Rows)
                {
                    dg_recibe.Rows.Add(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString());
                }
                // cierro la conexión
                _connection.Close();

                // limpio los datos del datatable
                dt.Rows.Clear();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                _connection.Close();
            }
        }

        //Insertar en la BD
        public void InsertarEnBD(DataGridView dg_origen)
        {            
            for (int i = 0; i < dg_origen.RowCount; i++)
            {     
                nombre = Convert.ToString(dg_origen.Rows[i].Cells[0].Value);
                apellido = Convert.ToString(dg_origen.Rows[i].Cells[1].Value);
                telefono = Convert.ToString(dg_origen.Rows[i].Cells[2].Value);
                email = Convert.ToString(dg_origen.Rows[i].Cells[3].Value);
                
                String query = $"INSERT INTO Aula_alumnos (nombre, apellido, telefono, email) VALUES ('{nombre}', '{apellido}', '{telefono}', '{email}')";

                if (AbrirConexion() == true)
                {
                    //create command and assign the query and connection from the constructor
                    MySqlCommand cmd = new MySqlCommand(query, _connection);

                    //Execute command
                    cmd.ExecuteNonQuery();
                    //close connection
                    CerrarConexion();
                }
            }
        }

        //Actualizar en la BD
        public void ActualizarBD(DataGridView dg_origen)
        {
            String query = $"UPDATE Aula_alumnos SET nombre='Lucho' WHERE nombre='Luis'";
            // Open connection            if (this.AbrirConexion() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = _connection;
                //Execute query
                cmd.ExecuteNonQuery();
                //close connection
                this.CerrarConexion();
            }
        }
    }
}
