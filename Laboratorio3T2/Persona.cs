using System;

namespace Laboratorio3
{
    public class Persona
    {
        // Propiedades con encapsulamiento

        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Correo { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public decimal Salario { get; set; }
    }
}
