using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico01Temperatura
{
    public class Temperatura
    {
        public Temperatura(Escala escala)
        {
            Escala = escala;
            Grados = ObtenerGrados(escala);
        }

        private int ObtenerGrados(Escala escala)
        {
            if (escala==Escala.Celsius)
            {
                return new Random(Guid.NewGuid().GetHashCode()).Next(-5, 30);
            }
            else
            {
                 return new Random(Guid.NewGuid().GetHashCode()).Next(14, 86);
               
            }
        }
        public double GetEquivalente()
        {
            if (Escala == Escala.Celsius)
            {
                return InformarFahrenheit();
            }
            else
            {
                return InformarCelsius();
            }
        }

        private double InformarCelsius()
        {
            return (Grados - 32)/1.8;
        }

        private double InformarFahrenheit()
        {
            return 1.8 * Grados + 32;
        }

        public int Grados { get; private set; }
        public Escala Escala { get; private set; }

    }
}
