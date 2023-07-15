using System;
using System.Collections.Generic;

namespace WSventa2.Models
{
    public partial class Auto
    {
        public int Id { get; set; }
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public int? Precio { get; set; }
    }
}
