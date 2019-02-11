using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia1
{
    public class Factura 
    {
        public string NIT { get; set; }

        public string DireccionFactura { get; set; }

        public DateTime Fecha { get; set; }

        public int NumeroFactura { get; set; }

        public string NombreEmpresa { get; set; }
    }
}
