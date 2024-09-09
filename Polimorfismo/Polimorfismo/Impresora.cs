using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public class Impresora : IDispositivo
    {
        public string TipoTinta { get; set; }

        public void Encender()
        {
            Console.WriteLine("Encendiendo la impresora...");
        }

        public void Apagar()
        {
            Console.WriteLine("Apagando la impresora...");
        }

        public string ObtenerInformacion()
        {
            return $"Tipo de tinta: {TipoTinta}";
        }
    }
}
