using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public class Escritorio : Computadora
    {
        public int NumeroDePuertosUSB { get; set; }

        public override string ObtenerInformacion()
        {
            return base.ObtenerInformacion() + $", Puertos USB: {NumeroDePuertosUSB}";
        }
    }
}
