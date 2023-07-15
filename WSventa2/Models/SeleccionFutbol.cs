using System;
using System.Collections.Generic;

namespace WSventa2.Models
{
    public partial class SeleccionFutbol
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int? Edad { get; set; }
    }
}
