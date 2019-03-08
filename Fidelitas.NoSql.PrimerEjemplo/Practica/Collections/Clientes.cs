﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practica.Collections
{
    public class Clientes
    {
        public Int32 id { get; set; }

        public String nombre { get; set; }

        public int telefono { get; set; }

        public IList<Renta> renta { get; set; }

    }
}