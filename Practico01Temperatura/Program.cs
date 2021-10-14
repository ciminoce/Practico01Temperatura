using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico01Temperatura
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Temperatura> lista = new List<Temperatura>();
            for (int i = 0; i < 5; i++)
            {
                Temperatura t = Termometro.GetInstancia().GetTemperatura(Escala.Fahrenheit);

                //Temperatura t = new Temperatura(Escala.Celsius);
                lista.Add(t);
                
            }

            foreach (var t in lista)
            {
                Console.WriteLine($"{t.Grados} - {t.GetEquivalente()}");
                
            }
            Console.ReadLine();
        }
    }
}
