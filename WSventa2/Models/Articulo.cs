using System;
using System.Collections.Generic;

namespace WSventa2.Models
{
    public partial class Articulo
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public string Marca { get; set; }
        public int Cantidad { get; set; }
        public int Precio { get; set; }
    }
}
