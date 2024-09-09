using System;
using System.Collections.Generic;
using Polimorfismo;

// Importando los espacios de nombres de nuestras clases
using PolimorfismoComputadoras;

namespace PolimorfismoComputadoras
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IDispositivo> dispositivos = new List<IDispositivo>
            {
                new Escritorio { Marca = "Dell", Modelo = "XPS", NumeroDePuertosUSB = 6 },
                new Laptop { Marca = "MacBook", Modelo = "Pro", TamañoPantalla = 16 },
                new Impresora { TipoTinta = "Láser" }
            };

            foreach (var dispositivo in dispositivos)
            {
                dispositivo.Encender();
                Console.WriteLine(dispositivo.ObtenerInformacion());
                dispositivo.Apagar();
                Console.WriteLine();
            }
        }
    }
}