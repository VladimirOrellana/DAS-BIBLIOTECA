namespace DAS_BIBLIOTECA
{
    partial class RegistrarPrestamoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxLibroId
            // 
            this.textBoxLibroId.Location = new System.Drawing.Point(103, 89);
            this.textBoxLibroId.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLibroId.Name = "textBoxLibroId";
            this.textBoxLibroId.Size = new System.Drawing.Size(434, 22);
            this.textBoxLibroId.TabIndex = 0;
            this.textBoxLibroId.TextChanged += new System.EventHandler(this.textBoxLibroId_TextChanged);
            // 
            // textBoxUsuarioId
            // 
            this.textBoxUsuarioId.Location = new System.Drawing.Point(103, 136);
            this.textBoxUsuarioId.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxUsuarioId.Name = "textBoxUsuarioId";
            this.textBoxUsuarioId.Size = new System.Drawing.Size(434, 22);
            this.textBoxUsuarioId.TabIndex = 1;
            this.textBoxUsuarioId.TextChanged += new System.EventHandler(this.textBoxUsuarioId_TextChanged);
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(103, 178);
            this.textBoxNombre.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.ReadOnly = true;
            this.textBoxNombre.Size = new System.Drawing.Size(434, 22);
            this.textBoxNombre.TabIndex = 2;
            // 
            // textBoxTitulo
            // 
            this.textBoxTitulo.Location = new System.Drawing.Point(103, 224);
            this.textBoxTitulo.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTitulo.Name = "textBoxTitulo";
            this.textBoxTitulo.ReadOnly = true;
            this.textBoxTitulo.Size = new System.Drawing.Size(434, 22);
            this.textBoxTitulo.TabIndex = 3;
            // 
            // dateTimePickerFechaPrestamo
            // 
            this.dateTimePickerFechaPrestamo.Location = new System.Drawing.Point(103, 282);
            this.dateTimePickerFechaPrestamo.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerFechaPrestamo.Name = "dateTimePickerFechaPrestamo";
            this.dateTimePickerFechaPrestamo.Size = new System.Drawing.Size(434, 22);
            this.dateTimePickerFechaPrestamo.TabIndex = 4;
            this.dateTimePickerFechaPrestamo.ValueChanged += new System.EventHandler(this.dateTimePickerFechaPrestamo_ValueChanged);
            // 
            // dateTimePickerFechaDevolucion
            // 
            this.dateTimePickerFechaDevolucion.Location = new System.Drawing.Point(103, 312);
            this.dateTimePickerFechaDevolucion.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerFechaDevolucion.Name = "dateTimePickerFechaDevolucion";
            this.dateTimePickerFechaDevolucion.Size = new System.Drawing.Size(434, 22);
            this.dateTimePickerFechaDevolucion.TabIndex = 5;
            this.dateTimePickerFechaDevolucion.ValueChanged += new System.EventHandler(this.dateTimePickerFechaDevolucion_ValueChanged);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(103, 422);
            this.buttonGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(100, 28);
            this.buttonGuardar.TabIndex = 6;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click_1);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(245, 422);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(100, 28);
            this.buttonCancelar.TabIndex = 7;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "ID USUARIO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(100, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "label2";
            // 
            // RegistrarPrestamoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DAS_BIBLIOTECA.Properties.Resources.AGREGARLIBROS;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(605, 488);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.dateTimePickerFechaDevolucion);
            this.Controls.Add(this.dateTimePickerFechaPrestamo);
            this.Controls.Add(this.textBoxTitulo);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.textBoxUsuarioId);
            this.Controls.Add(this.textBoxLibroId);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RegistrarPrestamoForm";
            this.Text = "RegistrarPrestamoForm";
            this.Load += new System.EventHandler(this.RegistrarPrestamoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxLibroId;
        private System.Windows.Forms.TextBox textBoxUsuarioId;
        private System.Windows.Forms.TextBox textBoxNombre; // Agregado
        private System.Windows.Forms.TextBox textBoxTitulo; // Agregado
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaPrestamo;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaDevolucion;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
