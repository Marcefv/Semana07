using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practica.Collections
{
    public class Renta
    {
        public DateTime fecha_inicio { get; set; }
        public DateTime fecha_entrega { get; set; }

        public DateTime entrega_real { get; set; }

        public int dias_atraso { get; set; }

       
    }
}