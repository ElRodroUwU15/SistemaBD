﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaRestaurante.Entidades
{
    public class DetallesVenta
    {
        public int idDetalleV { get; set; }
        public int idProductoV { get; set; }
        public double precioVenta { get; set; }
        public int cantidad { get; set; }
        public double totalProducto { get; set; }
        public int idVenta { get; set; }
    }
}