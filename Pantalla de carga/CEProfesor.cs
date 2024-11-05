using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qmanager
{
    public class CEProfesor
    {
        public string Cedula { get; set; } // Cambiado a string
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Foto { get; set; }
        public string Password { get; set; }
        public CEProfesor() { }

        public CEProfesor(string cedula, string nombre, string apellido, string foto, string Password)
        {
            this.Cedula = cedula;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Foto = foto;
            this.Password = Password;
        }
    }
}
