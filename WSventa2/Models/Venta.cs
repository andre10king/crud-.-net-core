﻿using System;
using System.Collections.Generic;

namespace WSventa2.Models
{
    public partial class Venta
    {
        public Venta()
        {
            Concepto = new HashSet<Concepto>();
        }

        public long Id { get; set; }
        public DateTime Fecha { get; set; }
        public decimal? Total { get; set; }
        public int? IdCliente { get; set; }

        public virtual Cliente IdClienteNavigation { get; set; }
        public virtual ICollection<Concepto> Concepto { get; set; }
    }
}
