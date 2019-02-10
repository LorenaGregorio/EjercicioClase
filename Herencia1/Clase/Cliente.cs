using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia1
{
    public class Cliente : Producto 
    {

        public int CodigoCliente { get; set; }

        public string NombreCliente { get; set; }

        public string TipoCliente { get; set; }

        public bool EstadoCliente { get; set; }

    }

}

