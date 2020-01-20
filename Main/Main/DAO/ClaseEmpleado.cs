using Main.Vistas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.DAO
{
    class ClaseEmpleado
    {

        private String id;
        private String primer_Nombre;
        private String segundo_Nombre;
        private String primer_Apellido;
        private String segundo_Apellido;
        private String email;
        private String telefono;
        private String celular;
        private String direccion;
        private String id_Municipio;

        public string Id { get => id; set => id = value; }
        public string Primer_Nombre { get => primer_Nombre; set => primer_Nombre = value; }
        public string Segundo_Nombre { get => segundo_Nombre; set => segundo_Nombre = value; }
        public string Primer_Apellido { get => primer_Apellido; set => primer_Apellido = value; }
        public string Segundo_Apellido { get => segundo_Apellido; set => segundo_Apellido = value; }
        public string Email { get => email; set => email = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Celular { get => celular; set => celular = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Id_Municipio { get => id_Municipio; set => id_Municipio = value; }

        public ClaseEmpleado(string id, string primer_Nombre, string segundo_Nombre, string primer_Apellido, string segundo_Apellido, string email, string telefono, string celular, string direccion, string id_Municipio)
        {
            Id = id;
            Primer_Nombre = primer_Nombre;
            Segundo_Nombre = segundo_Nombre;
            Primer_Apellido = primer_Apellido;
            Segundo_Apellido = segundo_Apellido;
            Email = email;
            Telefono = telefono;
            Celular = celular;
            Direccion = direccion;
            Id_Municipio = id_Municipio;
        }

        public ClaseEmpleado()
        {

        }

        
        
    }
}