using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public abstract class Computadora : IDispositivo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }

        // Implementación por defecto de los métodos de la interfaz
        public virtual void Encender()
        {
            Console.WriteLine("Encendiendo la computadora...");
        }

        public virtual void Apagar()
        {
            Console.WriteLine("Apagando la computadora...");
        }

        public virtual string ObtenerInformacion()
        {
            return $"Marca: {Marca}, Modelo: {Modelo}";
        }
    }
}
