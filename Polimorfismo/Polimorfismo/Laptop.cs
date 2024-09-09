using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public class Laptop : Computadora
    {
        public double TamañoPantalla { get; set; }

        public override string ObtenerInformacion()
        {
            return base.ObtenerInformacion() + $", Tamaño de pantalla: {TamañoPantalla} pulgadas";
        }
    }
}
