﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibFactura.Entidades
{
    public class DetalleFactura
    {
        public string Descripcion { get; set; }

        public Factura Factura { get; set; }
        public Producto Producto { get; set; }
     }
}
