using System;
using System.Collections.Generic;

namespace WSventa2.Models
{
    public partial class Empleado
    {
        public int Id { get; set; }
        public string TipoContrato { get; set; }
        public int? Sueldo { get; set; }
    }
}
