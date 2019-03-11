using PSO.Funkcje.Metody;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSO.Funkcje
{
    public class Wielomian : IFunkcja
    { 

        public double Funkcja(double x)
        {
            return DoPotengiI.doPotengiI(x, 4) - 4 * DoPotengiI.doPotengiI(x, 3) + 5 * x - 1;
        }
    }
}
