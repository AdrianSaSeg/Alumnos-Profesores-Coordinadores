namespace Ejercicio15_VariasTablasRelacionadas
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dg_profesores = new System.Windows.Forms.DataGridView();
            this.Nombre_Profesor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido_Profesor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Teléfono_Profesor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email_Profesor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Curso_Profesor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg_alumnos = new System.Windows.Forms.DataGridView();
            this.Nombre_Alumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido_Alumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Teléfono_Alumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email_Alumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Curso_Alumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg_coordinadores = new System.Windows.Forms.DataGridView();
            this.Nombre_Coord = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido_Coord = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Teléfono_Coord = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email_Coord = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Curso_Coord = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profesoresAbrirExcel = new System.Windows.Forms.ToolStripMenuItem();
            this.alumnosAbrirExcel = new System.Windows.Forms.ToolStripMenuItem();
            this.coordinadoresAbrirExcel = new System.Windows.Forms.ToolStripMenuItem();
            this.cursosAbrirExcel = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profesoresGuardarExcel = new System.Windows.Forms.ToolStripMenuItem();
            this.alumnosGuardarExcel = new System.Windows.Forms.ToolStripMenuItem();
            this.coordinadoresGuardarExcel = new System.Windows.Forms.ToolStripMenuItem();
            this.cursosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profesoresImprimirDataGrid = new System.Windows.Forms.ToolStripMenuItem();
            this.alumnosImprimirDataGrid = new System.Windows.Forms.ToolStripMenuItem();
            this.coordinadoresImprimirDataGrid = new System.Windows.Forms.ToolStripMenuItem();
            this.cursosImprimirDataGrid = new System.Windows.Forms.ToolStripMenuItem();
            this.importarDesdeBDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importarProfesoresDesdeBDToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.alumnosImportarDesdeBDToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.coordinadoresToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.insertarEnBDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profesoresToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.alumnosInsertarEnBDToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.coordinadoresToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.cursosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarBDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profesoresToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.alumnosActualizarBDToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.coordinadoresToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.cursosToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarEnBDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profesoresToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.alumnosBorrarEnBDToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.coordinadoresToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.cursosToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.añadirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profesoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coordinadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cursoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profesoresBuscar = new System.Windows.Forms.ToolStripMenuItem();
            this.alumnosBuscar = new System.Windows.Forms.ToolStripMenuItem();
            this.coordinadoresBuscar = new System.Windows.Forms.ToolStripMenuItem();
            this.cursosToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.dg_cursos = new System.Windows.Forms.DataGridView();
            this.Nombre_Curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria_Curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dg_profesores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_alumnos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_coordinadores)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_cursos)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_profesores
            // 
            this.dg_profesores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_profesores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre_Profesor,
            this.Apellido_Profesor,
            this.Teléfono_Profesor,
            this.Email_Profesor,
            this.Curso_Profesor});
            this.dg_profesores.Location = new System.Drawing.Point(8, 62);
            this.dg_profesores.Name = "dg_profesores";
            this.dg_profesores.Size = new System.Drawing.Size(732, 150);
            this.dg_profesores.TabIndex = 0;
            this.dg_profesores.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dg_profesores_RowHeaderMouseDoubleClick);
            // 
            // Nombre_Profesor
            // 
            this.Nombre_Profesor.DataPropertyName = "Nombre";
            this.Nombre_Profesor.HeaderText = "Nombre";
            this.Nombre_Profesor.Name = "Nombre_Profesor";
            // 
            // Apellido_Profesor
            // 
            this.Apellido_Profesor.DataPropertyName = "Apellido";
            this.Apellido_Profesor.HeaderText = "Apellido";
            this.Apellido_Profesor.Name = "Apellido_Profesor";
            // 
            // Teléfono_Profesor
            // 
            this.Teléfono_Profesor.DataPropertyName = "Telefono";
            this.Teléfono_Profesor.HeaderText = "Teléfono";
            this.Teléfono_Profesor.Name = "Teléfono_Profesor";
            // 
            // Email_Profesor
            // 
            this.Email_Profesor.DataPropertyName = "Email";
            this.Email_Profesor.HeaderText = "Email";
            this.Email_Profesor.Name = "Email_Profesor";
            // 
            // Curso_Profesor
            // 
            this.Curso_Profesor.DataPropertyName = "Curso";
            this.Curso_Profesor.HeaderText = "Curso";
            this.Curso_Profesor.Name = "Curso_Profesor";
            // 
            // dg_alumnos
            // 
            this.dg_alumnos.AllowUserToAddRows = false;
            this.dg_alumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_alumnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre_Alumno,
            this.Apellido_Alumno,
            this.Teléfono_Alumno,
            this.Email_Alumno,
            this.Curso_Alumno});
            this.dg_alumnos.Location = new System.Drawing.Point(8, 260);
            this.dg_alumnos.Name = "dg_alumnos";
            this.dg_alumnos.Size = new System.Drawing.Size(732, 150);
            this.dg_alumnos.TabIndex = 1;
            this.dg_alumnos.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dg_alumnos_RowHeaderMouseDoubleClick);
            // 
            // Nombre_Alumno
            // 
            this.Nombre_Alumno.DataPropertyName = "Nombre";
            this.Nombre_Alumno.HeaderText = "Nombre";
            this.Nombre_Alumno.Name = "Nombre_Alumno";
            // 
            // Apellido_Alumno
            // 
            this.Apellido_Alumno.DataPropertyName = "Apellido";
            this.Apellido_Alumno.HeaderText = "Apellido";
            this.Apellido_Alumno.Name = "Apellido_Alumno";
            // 
            // Teléfono_Alumno
            // 
            this.Teléfono_Alumno.DataPropertyName = "Telefono";
            this.Teléfono_Alumno.HeaderText = "Teléfono";
            this.Teléfono_Alumno.Name = "Teléfono_Alumno";
            // 
            // Email_Alumno
            // 
            this.Email_Alumno.DataPropertyName = "Email";
            this.Email_Alumno.HeaderText = "Email";
            this.Email_Alumno.Name = "Email_Alumno";
            // 
            // Curso_Alumno
            // 
            this.Curso_Alumno.DataPropertyName = "Curso";
            this.Curso_Alumno.HeaderText = "Curso";
            this.Curso_Alumno.Name = "Curso_Alumno";
            // 
            // dg_coordinadores
            // 
            this.dg_coordinadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_coordinadores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre_Coord,
            this.Apellido_Coord,
            this.Teléfono_Coord,
            this.Email_Coord,
            this.Curso_Coord});
            this.dg_coordinadores.Location = new System.Drawing.Point(8, 452);
            this.dg_coordinadores.Name = "dg_coordinadores";
            this.dg_coordinadores.Size = new System.Drawing.Size(732, 150);
            this.dg_coordinadores.TabIndex = 2;
            this.dg_coordinadores.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dg_coordinadores_RowHeaderMouseDoubleClick);
            // 
            // Nombre_Coord
            // 
            this.Nombre_Coord.DataPropertyName = "Nombre";
            this.Nombre_Coord.HeaderText = "Nombre";
            this.Nombre_Coord.Name = "Nombre_Coord";
            // 
            // Apellido_Coord
            // 
            this.Apellido_Coord.DataPropertyName = "Apellido";
            this.Apellido_Coord.HeaderText = "Apellido";
            this.Apellido_Coord.Name = "Apellido_Coord";
            // 
            // Teléfono_Coord
            // 
            this.Teléfono_Coord.DataPropertyName = "Telefono";
            this.Teléfono_Coord.HeaderText = "Teléfono";
            this.Teléfono_Coord.Name = "Teléfono_Coord";
            // 
            // Email_Coord
            // 
            this.Email_Coord.DataPropertyName = "Email";
            this.Email_Coord.HeaderText = "Email";
            this.Email_Coord.Name = "Email_Coord";
            // 
            // Curso_Coord
            // 
            this.Curso_Coord.DataPropertyName = "Curso";
            this.Curso_Coord.HeaderText = "Curso";
            this.Curso_Coord.Name = "Curso_Coord";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Listado de Profesores";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Listado de Alumnos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 424);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(259, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Listado de Coordinadores";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.añadirToolStripMenuItem,
            this.buscarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(969, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.guardarToolStripMenuItem,
            this.imprimirToolStripMenuItem,
            this.importarDesdeBDToolStripMenuItem,
            this.insertarEnBDToolStripMenuItem,
            this.actualizarBDToolStripMenuItem,
            this.salirToolStripMenuItem,
            this.borrarEnBDToolStripMenuItem});
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.inicioToolStripMenuItem.Text = "Inicio";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profesoresAbrirExcel,
            this.alumnosAbrirExcel,
            this.coordinadoresAbrirExcel,
            this.cursosAbrirExcel});
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            // 
            // profesoresAbrirExcel
            // 
            this.profesoresAbrirExcel.Name = "profesoresAbrirExcel";
            this.profesoresAbrirExcel.Size = new System.Drawing.Size(152, 22);
            this.profesoresAbrirExcel.Text = "Profesores";
            this.profesoresAbrirExcel.Click += new System.EventHandler(this.profesoresAbrirExcel_Click);
            // 
            // alumnosAbrirExcel
            // 
            this.alumnosAbrirExcel.Name = "alumnosAbrirExcel";
            this.alumnosAbrirExcel.Size = new System.Drawing.Size(152, 22);
            this.alumnosAbrirExcel.Text = "Alumnos";
            this.alumnosAbrirExcel.Click += new System.EventHandler(this.alumnosAbrirExcel_Click);
            // 
            // coordinadoresAbrirExcel
            // 
            this.coordinadoresAbrirExcel.Name = "coordinadoresAbrirExcel";
            this.coordinadoresAbrirExcel.Size = new System.Drawing.Size(152, 22);
            this.coordinadoresAbrirExcel.Text = "Coordinadores";
            this.coordinadoresAbrirExcel.Click += new System.EventHandler(this.coordinadoresAbrirExcel_Click);
            // 
            // cursosAbrirExcel
            // 
            this.cursosAbrirExcel.Name = "cursosAbrirExcel";
            this.cursosAbrirExcel.Size = new System.Drawing.Size(152, 22);
            this.cursosAbrirExcel.Text = "Cursos";
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profesoresGuardarExcel,
            this.alumnosGuardarExcel,
            this.coordinadoresGuardarExcel,
            this.cursosToolStripMenuItem1});
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.guardarToolStripMenuItem.Text = "Guardar";
            // 
            // profesoresGuardarExcel
            // 
            this.profesoresGuardarExcel.Name = "profesoresGuardarExcel";
            this.profesoresGuardarExcel.Size = new System.Drawing.Size(152, 22);
            this.profesoresGuardarExcel.Text = "Profesores";
            this.profesoresGuardarExcel.Click += new System.EventHandler(this.profesoresGuardarExcel_Click);
            // 
            // alumnosGuardarExcel
            // 
            this.alumnosGuardarExcel.Name = "alumnosGuardarExcel";
            this.alumnosGuardarExcel.Size = new System.Drawing.Size(152, 22);
            this.alumnosGuardarExcel.Text = "Alumnos";
            this.alumnosGuardarExcel.Click += new System.EventHandler(this.alumnosGuardarExcel_Click);
            // 
            // coordinadoresGuardarExcel
            // 
            this.coordinadoresGuardarExcel.Name = "coordinadoresGuardarExcel";
            this.coordinadoresGuardarExcel.Size = new System.Drawing.Size(152, 22);
            this.coordinadoresGuardarExcel.Text = "Coordinadores";
            this.coordinadoresGuardarExcel.Click += new System.EventHandler(this.coordinadoresGuardarExcel_Click);
            // 
            // cursosToolStripMenuItem1
            // 
            this.cursosToolStripMenuItem1.Name = "cursosToolStripMenuItem1";
            this.cursosToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.cursosToolStripMenuItem1.Text = "Cursos";
            // 
            // imprimirToolStripMenuItem
            // 
            this.imprimirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profesoresImprimirDataGrid,
            this.alumnosImprimirDataGrid,
            this.coordinadoresImprimirDataGrid,
            this.cursosImprimirDataGrid});
            this.imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
            this.imprimirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.imprimirToolStripMenuItem.Text = "Imprimir";
            // 
            // profesoresImprimirDataGrid
            // 
            this.profesoresImprimirDataGrid.Name = "profesoresImprimirDataGrid";
            this.profesoresImprimirDataGrid.Size = new System.Drawing.Size(152, 22);
            this.profesoresImprimirDataGrid.Text = "Profesores";
            this.profesoresImprimirDataGrid.Click += new System.EventHandler(this.profesoresImprimirDataGrid_Click);
            // 
            // alumnosImprimirDataGrid
            // 
            this.alumnosImprimirDataGrid.Name = "alumnosImprimirDataGrid";
            this.alumnosImprimirDataGrid.Size = new System.Drawing.Size(152, 22);
            this.alumnosImprimirDataGrid.Text = "Alumnos";
            this.alumnosImprimirDataGrid.Click += new System.EventHandler(this.alumnosImprimirDataGrid_Click);
            // 
            // coordinadoresImprimirDataGrid
            // 
            this.coordinadoresImprimirDataGrid.Name = "coordinadoresImprimirDataGrid";
            this.coordinadoresImprimirDataGrid.Size = new System.Drawing.Size(152, 22);
            this.coordinadoresImprimirDataGrid.Text = "Coordinadores";
            this.coordinadoresImprimirDataGrid.Click += new System.EventHandler(this.coordinadoresImprimirDataGrid_Click);
            // 
            // cursosImprimirDataGrid
            // 
            this.cursosImprimirDataGrid.Name = "cursosImprimirDataGrid";
            this.cursosImprimirDataGrid.Size = new System.Drawing.Size(152, 22);
            this.cursosImprimirDataGrid.Text = "Cursos";
            this.cursosImprimirDataGrid.Click += new System.EventHandler(this.cursosImprimirDataGrid_Click);
            // 
            // importarDesdeBDToolStripMenuItem
            // 
            this.importarDesdeBDToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importarProfesoresDesdeBDToolStripMenuItem1,
            this.alumnosImportarDesdeBDToolStripMenuItem1,
            this.coordinadoresToolStripMenuItem1});
            this.importarDesdeBDToolStripMenuItem.Name = "importarDesdeBDToolStripMenuItem";
            this.importarDesdeBDToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.importarDesdeBDToolStripMenuItem.Text = "Importar desde BD";
            // 
            // importarProfesoresDesdeBDToolStripMenuItem1
            // 
            this.importarProfesoresDesdeBDToolStripMenuItem1.Name = "importarProfesoresDesdeBDToolStripMenuItem1";
            this.importarProfesoresDesdeBDToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.importarProfesoresDesdeBDToolStripMenuItem1.Text = "Profesores";
            // 
            // alumnosImportarDesdeBDToolStripMenuItem1
            // 
            this.alumnosImportarDesdeBDToolStripMenuItem1.Name = "alumnosImportarDesdeBDToolStripMenuItem1";
            this.alumnosImportarDesdeBDToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.alumnosImportarDesdeBDToolStripMenuItem1.Text = "Alumnos";
            this.alumnosImportarDesdeBDToolStripMenuItem1.Click += new System.EventHandler(this.alumnosImportarDesdeBDToolStripMenuItem1_Click);
            // 
            // coordinadoresToolStripMenuItem1
            // 
            this.coordinadoresToolStripMenuItem1.Name = "coordinadoresToolStripMenuItem1";
            this.coordinadoresToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.coordinadoresToolStripMenuItem1.Text = "Coordinadores";
            // 
            // insertarEnBDToolStripMenuItem
            // 
            this.insertarEnBDToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profesoresToolStripMenuItem1,
            this.alumnosInsertarEnBDToolStripMenuItem2,
            this.coordinadoresToolStripMenuItem2,
            this.cursosToolStripMenuItem});
            this.insertarEnBDToolStripMenuItem.Name = "insertarEnBDToolStripMenuItem";
            this.insertarEnBDToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.insertarEnBDToolStripMenuItem.Text = "Insertar en BD";
            // 
            // profesoresToolStripMenuItem1
            // 
            this.profesoresToolStripMenuItem1.Name = "profesoresToolStripMenuItem1";
            this.profesoresToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.profesoresToolStripMenuItem1.Text = "Profesores";
            // 
            // alumnosInsertarEnBDToolStripMenuItem2
            // 
            this.alumnosInsertarEnBDToolStripMenuItem2.Name = "alumnosInsertarEnBDToolStripMenuItem2";
            this.alumnosInsertarEnBDToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.alumnosInsertarEnBDToolStripMenuItem2.Text = "Alumnos";
            this.alumnosInsertarEnBDToolStripMenuItem2.Click += new System.EventHandler(this.alumnosInsertarEnBDToolStripMenuItem2_Click);
            // 
            // coordinadoresToolStripMenuItem2
            // 
            this.coordinadoresToolStripMenuItem2.Name = "coordinadoresToolStripMenuItem2";
            this.coordinadoresToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.coordinadoresToolStripMenuItem2.Text = "Coordinadores";
            // 
            // cursosToolStripMenuItem
            // 
            this.cursosToolStripMenuItem.Name = "cursosToolStripMenuItem";
            this.cursosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cursosToolStripMenuItem.Text = "Cursos";
            // 
            // actualizarBDToolStripMenuItem
            // 
            this.actualizarBDToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profesoresToolStripMenuItem2,
            this.alumnosActualizarBDToolStripMenuItem2,
            this.coordinadoresToolStripMenuItem3,
            this.cursosToolStripMenuItem3});
            this.actualizarBDToolStripMenuItem.Name = "actualizarBDToolStripMenuItem";
            this.actualizarBDToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.actualizarBDToolStripMenuItem.Text = "Actualizar BD";
            // 
            // profesoresToolStripMenuItem2
            // 
            this.profesoresToolStripMenuItem2.Name = "profesoresToolStripMenuItem2";
            this.profesoresToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.profesoresToolStripMenuItem2.Text = "Profesores";
            // 
            // alumnosActualizarBDToolStripMenuItem2
            // 
            this.alumnosActualizarBDToolStripMenuItem2.Name = "alumnosActualizarBDToolStripMenuItem2";
            this.alumnosActualizarBDToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.alumnosActualizarBDToolStripMenuItem2.Text = "Alumnos";
            this.alumnosActualizarBDToolStripMenuItem2.Click += new System.EventHandler(this.alumnosActualizarBDToolStripMenuItem2_Click);
            // 
            // coordinadoresToolStripMenuItem3
            // 
            this.coordinadoresToolStripMenuItem3.Name = "coordinadoresToolStripMenuItem3";
            this.coordinadoresToolStripMenuItem3.Size = new System.Drawing.Size(152, 22);
            this.coordinadoresToolStripMenuItem3.Text = "Coordinadores";
            // 
            // cursosToolStripMenuItem3
            // 
            this.cursosToolStripMenuItem3.Name = "cursosToolStripMenuItem3";
            this.cursosToolStripMenuItem3.Size = new System.Drawing.Size(152, 22);
            this.cursosToolStripMenuItem3.Text = "Cursos";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // borrarEnBDToolStripMenuItem
            // 
            this.borrarEnBDToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profesoresToolStripMenuItem3,
            this.alumnosBorrarEnBDToolStripMenuItem2,
            this.coordinadoresToolStripMenuItem4,
            this.cursosToolStripMenuItem4});
            this.borrarEnBDToolStripMenuItem.Name = "borrarEnBDToolStripMenuItem";
            this.borrarEnBDToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.borrarEnBDToolStripMenuItem.Text = "Borrar en BD";
            // 
            // profesoresToolStripMenuItem3
            // 
            this.profesoresToolStripMenuItem3.Name = "profesoresToolStripMenuItem3";
            this.profesoresToolStripMenuItem3.Size = new System.Drawing.Size(152, 22);
            this.profesoresToolStripMenuItem3.Text = "Profesores";
            // 
            // alumnosBorrarEnBDToolStripMenuItem2
            // 
            this.alumnosBorrarEnBDToolStripMenuItem2.Name = "alumnosBorrarEnBDToolStripMenuItem2";
            this.alumnosBorrarEnBDToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.alumnosBorrarEnBDToolStripMenuItem2.Text = "Alumnos";
            this.alumnosBorrarEnBDToolStripMenuItem2.Click += new System.EventHandler(this.alumnosBorrarEnBDToolStripMenuItem2_Click);
            // 
            // coordinadoresToolStripMenuItem4
            // 
            this.coordinadoresToolStripMenuItem4.Name = "coordinadoresToolStripMenuItem4";
            this.coordinadoresToolStripMenuItem4.Size = new System.Drawing.Size(152, 22);
            this.coordinadoresToolStripMenuItem4.Text = "Coordinadores";
            // 
            // cursosToolStripMenuItem4
            // 
            this.cursosToolStripMenuItem4.Name = "cursosToolStripMenuItem4";
            this.cursosToolStripMenuItem4.Size = new System.Drawing.Size(152, 22);
            this.cursosToolStripMenuItem4.Text = "Cursos";
            // 
            // añadirToolStripMenuItem
            // 
            this.añadirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profesoresToolStripMenuItem,
            this.alumnosToolStripMenuItem,
            this.coordinadoresToolStripMenuItem,
            this.cursoToolStripMenuItem});
            this.añadirToolStripMenuItem.Name = "añadirToolStripMenuItem";
            this.añadirToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.añadirToolStripMenuItem.Text = "Añadir";
            // 
            // profesoresToolStripMenuItem
            // 
            this.profesoresToolStripMenuItem.Name = "profesoresToolStripMenuItem";
            this.profesoresToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.profesoresToolStripMenuItem.Text = "Profesores";
            this.profesoresToolStripMenuItem.Click += new System.EventHandler(this.profesoresToolStripMenuItem_Click);
            // 
            // alumnosToolStripMenuItem
            // 
            this.alumnosToolStripMenuItem.Name = "alumnosToolStripMenuItem";
            this.alumnosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.alumnosToolStripMenuItem.Text = "Alumnos";
            this.alumnosToolStripMenuItem.Click += new System.EventHandler(this.alumnosToolStripMenuItem_Click);
            // 
            // coordinadoresToolStripMenuItem
            // 
            this.coordinadoresToolStripMenuItem.Name = "coordinadoresToolStripMenuItem";
            this.coordinadoresToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.coordinadoresToolStripMenuItem.Text = "Coordinadores";
            this.coordinadoresToolStripMenuItem.Click += new System.EventHandler(this.coordinadoresToolStripMenuItem_Click);
            // 
            // cursoToolStripMenuItem
            // 
            this.cursoToolStripMenuItem.Name = "cursoToolStripMenuItem";
            this.cursoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cursoToolStripMenuItem.Text = "Curso";
            this.cursoToolStripMenuItem.Click += new System.EventHandler(this.cursoToolStripMenuItem_Click);
            // 
            // buscarToolStripMenuItem
            // 
            this.buscarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profesoresBuscar,
            this.alumnosBuscar,
            this.coordinadoresBuscar,
            this.cursosToolStripMenuItem2});
            this.buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            this.buscarToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.buscarToolStripMenuItem.Text = "Buscar";
            // 
            // profesoresBuscar
            // 
            this.profesoresBuscar.Name = "profesoresBuscar";
            this.profesoresBuscar.Size = new System.Drawing.Size(152, 22);
            this.profesoresBuscar.Text = "Profesores";
            this.profesoresBuscar.Click += new System.EventHandler(this.profesoresBuscar_Click);
            // 
            // alumnosBuscar
            // 
            this.alumnosBuscar.Name = "alumnosBuscar";
            this.alumnosBuscar.Size = new System.Drawing.Size(152, 22);
            this.alumnosBuscar.Text = "Alumnos";
            this.alumnosBuscar.Click += new System.EventHandler(this.alumnosBuscar_Click);
            // 
            // coordinadoresBuscar
            // 
            this.coordinadoresBuscar.Name = "coordinadoresBuscar";
            this.coordinadoresBuscar.Size = new System.Drawing.Size(152, 22);
            this.coordinadoresBuscar.Text = "Coordinadores";
            // 
            // cursosToolStripMenuItem2
            // 
            this.cursosToolStripMenuItem2.Name = "cursosToolStripMenuItem2";
            this.cursosToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.cursosToolStripMenuItem2.Text = "Cursos";
            // 
            // dg_cursos
            // 
            this.dg_cursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_cursos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre_Curso,
            this.Fecha_Curso,
            this.Categoria_Curso});
            this.dg_cursos.Location = new System.Drawing.Point(8, 657);
            this.dg_cursos.Name = "dg_cursos";
            this.dg_cursos.Size = new System.Drawing.Size(732, 150);
            this.dg_cursos.TabIndex = 7;
            this.dg_cursos.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dg_cursos_RowHeaderMouseDoubleClick);
            // 
            // Nombre_Curso
            // 
            this.Nombre_Curso.DataPropertyName = "Nombre";
            this.Nombre_Curso.HeaderText = "Nombre";
            this.Nombre_Curso.Name = "Nombre_Curso";
            // 
            // Fecha_Curso
            // 
            this.Fecha_Curso.DataPropertyName = "Fecha";
            this.Fecha_Curso.HeaderText = "Fecha";
            this.Fecha_Curso.Name = "Fecha_Curso";
            // 
            // Categoria_Curso
            // 
            this.Categoria_Curso.DataPropertyName = "Categoria";
            this.Categoria_Curso.HeaderText = "Categoría";
            this.Categoria_Curso.Name = "Categoria_Curso";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 629);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Listado de Cursos";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage_1);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 810);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dg_cursos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dg_coordinadores);
            this.Controls.Add(this.dg_alumnos);
            this.Controls.Add(this.dg_profesores);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Academia";
            ((System.ComponentModel.ISupportInitialize)(this.dg_profesores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_alumnos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_coordinadores)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_cursos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_profesores;
        private System.Windows.Forms.DataGridView dg_alumnos;
        private System.Windows.Forms.DataGridView dg_coordinadores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem añadirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profesoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alumnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coordinadoresToolStripMenuItem;
        private System.Windows.Forms.DataGridView dg_cursos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem cursoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profesoresAbrirExcel;
        private System.Windows.Forms.ToolStripMenuItem alumnosAbrirExcel;
        private System.Windows.Forms.ToolStripMenuItem coordinadoresAbrirExcel;
        private System.Windows.Forms.ToolStripMenuItem cursosAbrirExcel;
        private System.Windows.Forms.ToolStripMenuItem profesoresGuardarExcel;
        private System.Windows.Forms.ToolStripMenuItem alumnosGuardarExcel;
        private System.Windows.Forms.ToolStripMenuItem coordinadoresGuardarExcel;
        private System.Windows.Forms.ToolStripMenuItem cursosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem importarDesdeBDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profesoresBuscar;
        private System.Windows.Forms.ToolStripMenuItem alumnosBuscar;
        private System.Windows.Forms.ToolStripMenuItem coordinadoresBuscar;
        private System.Windows.Forms.ToolStripMenuItem cursosToolStripMenuItem2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Profesor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido_Profesor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Teléfono_Profesor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email_Profesor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Curso_Profesor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Alumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido_Alumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Teléfono_Alumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email_Alumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Curso_Alumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Coord;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido_Coord;
        private System.Windows.Forms.DataGridViewTextBoxColumn Teléfono_Coord;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email_Coord;
        private System.Windows.Forms.DataGridViewTextBoxColumn Curso_Coord;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Curso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Curso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria_Curso;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.ToolStripMenuItem profesoresImprimirDataGrid;
        private System.Windows.Forms.ToolStripMenuItem alumnosImprimirDataGrid;
        private System.Windows.Forms.ToolStripMenuItem coordinadoresImprimirDataGrid;
        private System.Windows.Forms.ToolStripMenuItem cursosImprimirDataGrid;
        private System.Windows.Forms.ToolStripMenuItem importarProfesoresDesdeBDToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem alumnosImportarDesdeBDToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem coordinadoresToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem insertarEnBDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profesoresToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem alumnosInsertarEnBDToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem coordinadoresToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem cursosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarBDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profesoresToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem alumnosActualizarBDToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem coordinadoresToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem cursosToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem borrarEnBDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profesoresToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem alumnosBorrarEnBDToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem coordinadoresToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem cursosToolStripMenuItem4;
    }
}

