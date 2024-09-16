using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace DAS_BIBLIOTECA
{
    public class EditarUsuarioForm : Form
    {
        private int idUsuario;
        private TextBox txtNombre;
        private TextBox txtDireccion;
        private TextBox txtEmail;
        private ComboBox cmbTipoUsuario;
        private Button btnGuardar;
        private string rutaFotoSeleccionada; // Mantener la ruta de la foto, aunque no se muestre

        public EditarUsuarioForm(int id)
        {
            idUsuario = id;
            InicializarFormulario();
            CargarDatosUsuario();
        }

        private void InicializarFormulario()
        {
            // Configurar el formulario
            this.Text = "Editar Usuario";
            this.Size = new Size(400, 350);

            // Crear y configurar los controles
            Label lblNombre = new Label() { Text = "Nombre", Location = new Point(10, 20) };
            txtNombre = new TextBox() { Location = new Point(100, 20), Width = 200 };

            Label lblDireccion = new Label() { Text = "Dirección", Location = new Point(10, 60) };
            txtDireccion = new TextBox() { Location = new Point(100, 60), Width = 200 };

            Label lblEmail = new Label() { Text = "Email", Location = new Point(10, 100) };
            txtEmail = new TextBox() { Location = new Point(100, 100), Width = 200 };

            Label lblTipoUsuario = new Label() { Text = "Tipo Usuario", Location = new Point(10, 140) };
            cmbTipoUsuario = new ComboBox() { Location = new Point(100, 140), Width = 200 };
            cmbTipoUsuario.Items.AddRange(new string[] { "Estudiante", "Profesor", "Bibliotecario" });

            // Botón para subir foto, aunque no se muestre
            Button btnSubirFoto = new Button() { Text = "Subir Foto", Location = new Point(100, 180), Visible = false };
            btnSubirFoto.Click += BtnSubirFoto_Click;

            btnGuardar = new Button() { Text = "Guardar", Location = new Point(100, 220) };
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
            this.Controls.Add(btnSubirFoto); // Aunque es invisible, está presente en el formulario
            this.Controls.Add(btnGuardar);
        }

        private void CargarDatosUsuario()
        {
            // Cargar los datos del usuario con el idUsuario
            Usuario usuario = DataManager.CargarUsuarios().FirstOrDefault(u => u.Id == idUsuario);

            if (usuario != null)
            {
                txtNombre.Text = usuario.Nombre;
                txtDireccion.Text = usuario.Direccion;
                txtEmail.Text = usuario.Email;
                cmbTipoUsuario.SelectedItem = usuario.TipoUsuario;
                rutaFotoSeleccionada = usuario.RutaFoto; // Cargar la ruta de la foto
            }
        }

        private void BtnSubirFoto_Click(object sender, EventArgs e)
        {
            // No se muestra el botón para subir fotos
            // Esta función está aquí en caso de que necesites usarla en el futuro
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            // Validación del correo electrónico
            if (!ValidarEmail(txtEmail.Text))
            {
                MessageBox.Show("El correo electrónico debe contener un '@' válido.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Actualizar los datos del usuario
            Usuario usuarioActualizado = new Usuario(
                id: idUsuario,
                nombre: txtNombre.Text,
                direccion: txtDireccion.Text,
                email: txtEmail.Text,
                tipoUsuario: cmbTipoUsuario.SelectedItem?.ToString() ?? "",
                rutaFoto: rutaFotoSeleccionada // Mantener la ruta de la foto existente
            );

            // Actualizar el usuario en la lista de usuarios (puedes usar JSON para almacenar)
            List<Usuario> usuarios = DataManager.CargarUsuarios();
            Usuario usuarioExistente = usuarios.FirstOrDefault(u => u.Id == idUsuario);

            if (usuarioExistente != null)
            {
                usuarios.Remove(usuarioExistente);
                usuarios.Add(usuarioActualizado);
                DataManager.GuardarUsuarios(usuarios);
                MessageBox.Show("Usuario actualizado correctamente.");
            }
            else
            {
                MessageBox.Show("Usuario no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para validar si el correo tiene una "@" válida
        private bool ValidarEmail(string email)
        {
            return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // EditarUsuarioForm
            // 
            this.ClientSize = new System.Drawing.Size(544, 468);
            this.Name = "EditarUsuarioForm";
            this.Load += new System.EventHandler(this.EditarUsuarioForm_Load);
            this.ResumeLayout(false);

        }

        private void EditarUsuarioForm_Load(object sender, EventArgs e)
        {

        }
    }
}