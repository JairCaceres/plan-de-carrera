using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public interface IDispositivo
    {
        void Encender();
        void Apagar();
        string ObtenerInformacion();
    }
}
