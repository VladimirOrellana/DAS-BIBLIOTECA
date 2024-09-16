namespace DAS_BIBLIOTECA
{
    partial class EditarPrestamoForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.textBoxLibroId = new System.Windows.Forms.TextBox();
            this.textBoxUsuarioId = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxTitulo = new System.Windows.Forms.TextBox();
            this.dateTimePickerFechaPrestamo = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFechaDevolucion = new System.Windows.Forms.DateTimePicker();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxLibroId
            // 
            this.textBoxLibroId.Location = new System.Drawing.Point(77, 48);
            this.textBoxLibroId.Name = "textBoxLibroId";
            this.textBoxLibroId.Size = new System.Drawing.Size(214, 20);
            this.textBoxLibroId.TabIndex = 0;
            this.textBoxLibroId.TextChanged += new System.EventHandler(this.textBoxLibroId_TextChanged);
            // 
            // textBoxUsuarioId
            // 
            this.textBoxUsuarioId.Location = new System.Drawing.Point(77, 74);
            this.textBoxUsuarioId.Name = "textBoxUsuarioId";
            this.textBoxUsuarioId.Size = new System.Drawing.Size(214, 20);
            this.textBoxUsuarioId.TabIndex = 1;
            this.textBoxUsuarioId.TextChanged += new System.EventHandler(this.textBoxUsuarioId_TextChanged);
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(77, 100);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(214, 20);
            this.textBoxNombre.TabIndex = 2;
            this.textBoxNombre.ReadOnly = true;
            // 
            // textBoxTitulo
            // 
            this.textBoxTitulo.Location = new System.Drawing.Point(77, 126);
            this.textBoxTitulo.Name = "textBoxTitulo";
            this.textBoxTitulo.Size = new System.Drawing.Size(214, 20);
            this.textBoxTitulo.TabIndex = 3;
            this.textBoxTitulo.ReadOnly = true;
            // 
            // dateTimePickerFechaPrestamo
            // 
            this.dateTimePickerFechaPrestamo.Location = new System.Drawing.Point(77, 202);
            this.dateTimePickerFechaPrestamo.Name = "dateTimePickerFechaPrestamo";
            this.dateTimePickerFechaPrestamo.Size = new System.Drawing.Size(214, 20);
            this.dateTimePickerFechaPrestamo.TabIndex = 4;
            // 
            // dateTimePickerFechaDevolucion
            // 
            this.dateTimePickerFechaDevolucion.Location = new System.Drawing.Point(77, 228);
            this.dateTimePickerFechaDevolucion.Name = "dateTimePickerFechaDevolucion";
            this.dateTimePickerFechaDevolucion.Size = new System.Drawing.Size(214, 20);
            this.dateTimePickerFechaDevolucion.TabIndex = 5;
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(77, 273);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(75, 23);
            this.buttonGuardar.TabIndex = 6;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(184, 273);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 7;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // EditarPrestamoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 450);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.dateTimePickerFechaDevolucion);
            this.Controls.Add(this.dateTimePickerFechaPrestamo);
            this.Controls.Add(this.textBoxTitulo);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.textBoxUsuarioId);
            this.Controls.Add(this.textBoxLibroId);
            this.Name = "EditarPrestamoForm";
            this.Text = "Editar Préstamo";
            this.Load += new System.EventHandler(this.EditarPrestamoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox textBoxLibroId;
        private System.Windows.Forms.TextBox textBoxUsuarioId;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxTitulo;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaPrestamo;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaDevolucion;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Button buttonCancelar;
    }
}
