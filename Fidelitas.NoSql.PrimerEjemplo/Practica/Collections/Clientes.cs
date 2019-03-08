using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practica.Collections
{
    public class Clientes
    {
        public int id { get; set; }

        public String nombre { get; set; }

        public int telefono { get; set; }

        public Renta renta { get; set; }
    }
}