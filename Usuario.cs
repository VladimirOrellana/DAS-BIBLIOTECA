using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAS_BIBLIOTECA
{

    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Email { get; set; } // Nueva propiedad para el email
        public string TipoUsuario { get; set; } // Por ejemplo, Estudiante, Profesor, etc.
        public string RutaFoto { get; set; } // Nueva propiedad para almacenar la ruta de la foto

        // Constructor
        public Usuario(int id, string nombre, string direccion, string email, string tipoUsuario, string rutaFoto)
        {
            Id = id;
            Nombre = nombre;
            Direccion = direccion;
            Email = email;
            TipoUsuario = tipoUsuario;
            RutaFoto = rutaFoto;
        }
    }
}



