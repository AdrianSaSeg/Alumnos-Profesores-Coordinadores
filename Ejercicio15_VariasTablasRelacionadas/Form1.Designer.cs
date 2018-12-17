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
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.añadirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profesoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coordinadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cursoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dg_cursos = new System.Windows.Forms.DataGridView();
            this.Nombre_Curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria_Curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
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
            this.dg_profesores.Size = new System.Drawing.Size(545, 150);
            this.dg_profesores.TabIndex = 0;
            this.dg_profesores.DoubleClick += new System.EventHandler(this.dg_profesores_DoubleClick);
            // 
            // Nombre_Profesor
            // 
            this.Nombre_Profesor.HeaderText = "Nombre";
            this.Nombre_Profesor.Name = "Nombre_Profesor";
            // 
            // Apellido_Profesor
            // 
            this.Apellido_Profesor.HeaderText = "Apellido";
            this.Apellido_Profesor.Name = "Apellido_Profesor";
            // 
            // Teléfono_Profesor
            // 
            this.Teléfono_Profesor.HeaderText = "Teléfono";
            this.Teléfono_Profesor.Name = "Teléfono_Profesor";
            // 
            // Email_Profesor
            // 
            this.Email_Profesor.HeaderText = "Email";
            this.Email_Profesor.Name = "Email_Profesor";
            // 
            // Curso_Profesor
            // 
            this.Curso_Profesor.HeaderText = "Curso";
            this.Curso_Profesor.Name = "Curso_Profesor";
            // 
            // dg_alumnos
            // 
            this.dg_alumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_alumnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre_Alumno,
            this.Apellido_Alumno,
            this.Teléfono_Alumno,
            this.Email_Alumno,
            this.Curso_Alumno});
            this.dg_alumnos.Location = new System.Drawing.Point(8, 260);
            this.dg_alumnos.Name = "dg_alumnos";
            this.dg_alumnos.Size = new System.Drawing.Size(545, 150);
            this.dg_alumnos.TabIndex = 1;
            this.dg_alumnos.DoubleClick += new System.EventHandler(this.dg_alumnos_DoubleClick);
            // 
            // Nombre_Alumno
            // 
            this.Nombre_Alumno.HeaderText = "Nombre";
            this.Nombre_Alumno.Name = "Nombre_Alumno";
            // 
            // Apellido_Alumno
            // 
            this.Apellido_Alumno.HeaderText = "Apellido";
            this.Apellido_Alumno.Name = "Apellido_Alumno";
            // 
            // Teléfono_Alumno
            // 
            this.Teléfono_Alumno.HeaderText = "Teléfono";
            this.Teléfono_Alumno.Name = "Teléfono_Alumno";
            // 
            // Email_Alumno
            // 
            this.Email_Alumno.HeaderText = "Email";
            this.Email_Alumno.Name = "Email_Alumno";
            // 
            // Curso_Alumno
            // 
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
            this.dg_coordinadores.Size = new System.Drawing.Size(545, 150);
            this.dg_coordinadores.TabIndex = 2;
            this.dg_coordinadores.DoubleClick += new System.EventHandler(this.dg_coordinadores_DoubleClick);
            // 
            // Nombre_Coord
            // 
            this.Nombre_Coord.HeaderText = "Nombre";
            this.Nombre_Coord.Name = "Nombre_Coord";
            // 
            // Apellido_Coord
            // 
            this.Apellido_Coord.HeaderText = "Apellido";
            this.Apellido_Coord.Name = "Apellido_Coord";
            // 
            // Teléfono_Coord
            // 
            this.Teléfono_Coord.HeaderText = "Teléfono";
            this.Teléfono_Coord.Name = "Teléfono_Coord";
            // 
            // Email_Coord
            // 
            this.Email_Coord.HeaderText = "Email";
            this.Email_Coord.Name = "Email_Coord";
            // 
            // Curso_Coord
            // 
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
            this.añadirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(664, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.inicioToolStripMenuItem.Text = "Inicio";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(96, 22);
            this.toolStripMenuItem1.Text = "Salir";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
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
            // dg_cursos
            // 
            this.dg_cursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_cursos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre_Curso,
            this.Fecha_Curso,
            this.Categoria_Curso});
            this.dg_cursos.Location = new System.Drawing.Point(8, 657);
            this.dg_cursos.Name = "dg_cursos";
            this.dg_cursos.Size = new System.Drawing.Size(545, 150);
            this.dg_cursos.TabIndex = 7;
            // 
            // Nombre_Curso
            // 
            this.Nombre_Curso.HeaderText = "Nombre";
            this.Nombre_Curso.Name = "Nombre_Curso";
            // 
            // Fecha_Curso
            // 
            this.Fecha_Curso.HeaderText = "Fecha";
            this.Fecha_Curso.Name = "Fecha_Curso";
            // 
            // Categoria_Curso
            // 
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 810);
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
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem añadirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profesoresToolStripMenuItem;
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
        private System.Windows.Forms.ToolStripMenuItem alumnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coordinadoresToolStripMenuItem;
        private System.Windows.Forms.DataGridView dg_cursos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Curso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Curso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria_Curso;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem cursoToolStripMenuItem;
    }
}

