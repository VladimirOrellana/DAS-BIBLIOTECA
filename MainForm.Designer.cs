namespace DAS_BIBLIOTECA
{
    partial class MainForm
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
            this.btnAgregarLibro = new System.Windows.Forms.Button();
            this.btnRegistrarUsuario = new System.Windows.Forms.Button();
            this.btnRegistrarPrestamo = new System.Windows.Forms.Button();
            this.btnEstadisticas = new System.Windows.Forms.Button();
            this.dataGridViewLibros = new System.Windows.Forms.DataGridView();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Libros = new System.Windows.Forms.Button();
            this.Usuarios = new System.Windows.Forms.Button();
            this.Prestamos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLibros)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregarLibro
            // 
            this.btnAgregarLibro.Location = new System.Drawing.Point(39, 60);
            this.btnAgregarLibro.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarLibro.Name = "btnAgregarLibro";
            this.btnAgregarLibro.Size = new System.Drawing.Size(137, 80);
            this.btnAgregarLibro.TabIndex = 0;
            this.btnAgregarLibro.Text = "AgregarLibro";
            this.btnAgregarLibro.UseVisualStyleBackColor = true;
            this.btnAgregarLibro.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRegistrarUsuario
            // 
            this.btnRegistrarUsuario.Location = new System.Drawing.Point(423, 60);
            this.btnRegistrarUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistrarUsuario.Name = "btnRegistrarUsuario";
            this.btnRegistrarUsuario.Size = new System.Drawing.Size(135, 80);
            this.btnRegistrarUsuario.TabIndex = 4;
            this.btnRegistrarUsuario.Text = "Registrar Usuario";
            this.btnRegistrarUsuario.UseVisualStyleBackColor = true;
            this.btnRegistrarUsuario.Click += new System.EventHandler(this.btnRegistrarUsuario_Click);
            // 
            // btnRegistrarPrestamo
            // 
            this.btnRegistrarPrestamo.Location = new System.Drawing.Point(846, 130);
            this.btnRegistrarPrestamo.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistrarPrestamo.Name = "btnRegistrarPrestamo";
            this.btnRegistrarPrestamo.Size = new System.Drawing.Size(139, 67);
            this.btnRegistrarPrestamo.TabIndex = 5;
            this.btnRegistrarPrestamo.Text = "Registrar Préstamo";
            this.btnRegistrarPrestamo.UseVisualStyleBackColor = true;
            this.btnRegistrarPrestamo.Click += new System.EventHandler(this.btnRegistrarPrestamo_Click);
            // 
            // btnEstadisticas
            // 
            this.btnEstadisticas.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstadisticas.Location = new System.Drawing.Point(846, 60);
            this.btnEstadisticas.Margin = new System.Windows.Forms.Padding(4);
            this.btnEstadisticas.Name = "btnEstadisticas";
            this.btnEstadisticas.Size = new System.Drawing.Size(135, 62);
            this.btnEstadisticas.TabIndex = 6;
            this.btnEstadisticas.Text = "Estadísticas";
            this.btnEstadisticas.UseVisualStyleBackColor = true;
            this.btnEstadisticas.Click += new System.EventHandler(this.btnEstadisticas_Click);
            // 
            // dataGridViewLibros
            // 
            this.dataGridViewLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLibros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Editar,
            this.Eliminar});
            this.dataGridViewLibros.Location = new System.Drawing.Point(43, 249);
            this.dataGridViewLibros.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewLibros.Name = "dataGridViewLibros";
            this.dataGridViewLibros.RowHeadersWidth = 51;
            this.dataGridViewLibros.Size = new System.Drawing.Size(938, 286);
            this.dataGridViewLibros.TabIndex = 7;
            this.dataGridViewLibros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLibros_CellContentClick);
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.MinimumWidth = 6;
            this.Editar.Name = "Editar";
            this.Editar.Width = 125;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.MinimumWidth = 6;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Width = 125;
            // 
            // Libros
            // 
            this.Libros.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Libros.Location = new System.Drawing.Point(39, 148);
            this.Libros.Margin = new System.Windows.Forms.Padding(4);
            this.Libros.Name = "Libros";
            this.Libros.Size = new System.Drawing.Size(137, 80);
            this.Libros.TabIndex = 12;
            this.Libros.Text = "Libros";
            this.Libros.UseVisualStyleBackColor = true;
            this.Libros.Click += new System.EventHandler(this.Libros_Click);
            // 
            // Usuarios
            // 
            this.Usuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usuarios.Location = new System.Drawing.Point(423, 148);
            this.Usuarios.Margin = new System.Windows.Forms.Padding(4);
            this.Usuarios.Name = "Usuarios";
            this.Usuarios.Size = new System.Drawing.Size(135, 80);
            this.Usuarios.TabIndex = 13;
            this.Usuarios.Text = "Usuarios";
            this.Usuarios.UseVisualStyleBackColor = true;
            this.Usuarios.Click += new System.EventHandler(this.Usuarios_Click);
            // 
            // Prestamos
            // 
            this.Prestamos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Prestamos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Prestamos.Location = new System.Drawing.Point(846, 205);
            this.Prestamos.Margin = new System.Windows.Forms.Padding(4);
            this.Prestamos.Name = "Prestamos";
            this.Prestamos.Size = new System.Drawing.Size(135, 36);
            this.Prestamos.TabIndex = 14;
            this.Prestamos.Text = "Prestamos";
            this.Prestamos.UseVisualStyleBackColor = true;
            this.Prestamos.Click += new System.EventHandler(this.Prestamos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 22);
            this.label1.TabIndex = 15;
            this.label1.Text = "LIBROS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(436, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 22);
            this.label2.TabIndex = 16;
            this.label2.Text = "USUARIOS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(849, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 22);
            this.label3.TabIndex = 17;
            this.label3.Text = "PRESTAMOS";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DAS_BIBLIOTECA.Properties.Resources.AGREGARLIBROS;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1028, 550);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Prestamos);
            this.Controls.Add(this.Usuarios);
            this.Controls.Add(this.Libros);
            this.Controls.Add(this.dataGridViewLibros);
            this.Controls.Add(this.btnEstadisticas);
            this.Controls.Add(this.btnRegistrarPrestamo);
            this.Controls.Add(this.btnRegistrarUsuario);
            this.Controls.Add(this.btnAgregarLibro);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLibros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarLibro;
        private System.Windows.Forms.Button btnRegistrarUsuario;
        private System.Windows.Forms.Button btnRegistrarPrestamo;
        private System.Windows.Forms.Button btnEstadisticas;
        private System.Windows.Forms.DataGridView dataGridViewLibros;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
        private System.Windows.Forms.Button Libros;
        private System.Windows.Forms.Button Usuarios;
        private System.Windows.Forms.Button Prestamos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

