using System;
using System.Collections.Generic;

#nullable disable

namespace Prestamo.Domain.Entities
{
    public partial class Prestamo
    {
        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public int Edad { get; set; }
        public int Telefono { get; set; }
        public string Direccion { get; set; }
        public string Cedula { get; set; }
        public int PagoPrestamo { get; set; }
        public int InteresPrestamo { get; set; }
        public int MontoPrestamo { get; set; }
        public int TiempoPrestamo { get; set; }
        public int CuotaPrestamo { get; set; }
    }
}
