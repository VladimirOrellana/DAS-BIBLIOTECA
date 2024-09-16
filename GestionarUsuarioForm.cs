using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace DAS_BIBLIOTECA
{
    public class GestionarUsuarioForm : Form
    {
        private TextBox txtNombre;
        private TextBox txtDireccion;
        private TextBox txtEmail;
        private ComboBox cmbTipoUsuario;
        private Button btnSubirFoto;
        private Button btnGuardar;
        private Label label1;
        private string rutaFotoSeleccionada;

        public GestionarUsuarioForm()
        {
            InicializarFormulario();
        }

        private void InicializarFormulario()
        {
            // Configurar el formulario
            this.Text = "Gestión de Usuario";
            this.Size = new Size(400, 500);

            // Configurar imagen de fondo
            this.BackgroundImage = Properties.Resources.AGREGARLIBROS; // Imagen que agregaste en Resources
            this.BackgroundImageLayout = ImageLayout.Stretch; // Ajustar la imagen al tamaño del formulario

            // Crear y configurar los controles
            Label lblNombre = new Label() { Text = "Nombre", Location = new Point(10, 20) };
            txtNombre = new TextBox() { Location = new Point(120, 20), Width = 200 };

            Label lblDireccion = new Label() { Text = "Dirección", Location = new Point(10, 60) };
            txtDireccion = new TextBox() { Location = new Point(120, 60), Width = 200 };

            Label lblEmail = new Label() { Text = "Email", Location = new Point(10, 100) };
            txtEmail = new TextBox() { Location = new Point(120, 100), Width = 200 };

            Label lblTipoUsuario = new Label() { Text = "Tipo Usuario", Location = new Point(10, 140) };
            cmbTipoUsuario = new ComboBox() { Location = new Point(120, 140), Width = 200 };
            cmbTipoUsuario.Items.AddRange(new string[] { "Estudiante", "Profesor", "Bibliotecario" });




            btnGuardar = new Button() { Text = "Guardar", Location = new Point(100, 300) };
            btnGuardar.Click += BtnGuardar_Click;

            // Agregar los controles al formulario
            this.Controls.Add(lblNombre);
            this.Controls.Add(txtNombre);
            this.Controls.Add(lblDireccion);
            this.Controls.Add(txtDireccion);
            this.Controls.Add(lblEmail);
            this.Controls.Add(txtEmail);
            this.Controls.Add(lblTipoUsuario);
            this.Controls.Add(cmbTipoUsuario);

            this.Controls.Add(btnSubirFoto);
            this.Controls.Add(btnGuardar);
        }


        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            // Validación del correo electrónico
            if (!ValidarEmail(txtEmail.Text))
            {
                MessageBox.Show("El correo electrónico debe contener un '@' válido.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Crear un nuevo usuario con los datos ingresados
            Usuario nuevoUsuario = new Usuario(
                id: GenerarNuevoId(), // Método para generar un nuevo ID
                nombre: txtNombre.Text,
                direccion: txtDireccion.Text,
                email: txtEmail.Text,
                tipoUsuario: cmbTipoUsuario.SelectedItem?.ToString() ?? "",
                rutaFoto: rutaFotoSeleccionada // Guardar la ruta de la foto seleccionada
            );

            // Guardar el usuario en la lista de usuarios (puedes usar JSON para almacenar)
            List<Usuario> usuarios = DataManager.CargarUsuarios();
            usuarios.Add(nuevoUsuario);
            DataManager.GuardarUsuarios(usuarios);

            MessageBox.Show("Usuario guardado correctamente.");
        }

        // Método para validar si el correo tiene una "@" válida
        private bool ValidarEmail(string email)
        {
            return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }

        private int GenerarNuevoId()
        {
            // Lógica para generar un nuevo ID
            List<Usuario> usuarios = DataManager.CargarUsuarios();
            return usuarios.Count > 0 ? usuarios.Max(u => u.Id) + 1 : 1;
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(193, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // GestionarUsuarioForm
            // 
            this.BackgroundImage = global::DAS_BIBLIOTECA.Properties.Resources.AGREGARLIBROS;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(574, 376);
            this.Controls.Add(this.label1);
            this.Name = "GestionarUsuarioForm";
            this.Load += new System.EventHandler(this.GestionarUsuarioForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void GestionarUsuarioForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}