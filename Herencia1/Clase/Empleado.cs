using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia1
{
    public class Empleado : Factura
    {

        public int Carne { get; set; }

        public string Nombre { get; set; }

        public string Apellidos { get; set; }

        public string Direccion { get; set; }

        public int Telefono { get; set; }

        public string Email { get; set; }

        public List <Habilidad> Habilidades  { get; set; }
    }

}


