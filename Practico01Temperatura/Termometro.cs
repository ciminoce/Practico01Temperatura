using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico01Temperatura
{
    public class Termometro
    {
        public static Termometro instancia = null;
        public static Termometro GetInstancia()
        {
            if (instancia==null)
            {
                instancia = new Termometro();
            }

            return instancia;
        }

        private Termometro()
        {
            
        }

        public Temperatura GetTemperatura(Escala escala)
        {
            return new Temperatura(escala);
            
        }


    }
}
