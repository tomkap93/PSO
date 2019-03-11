using PSO.Funkcje.Metody;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSO.Funkcje
{
    class Wielomian2:IFunkcja
    {

        public double Funkcja(double x)
        {
            return (x + 3) * (x - 4) * x;
        }
    }
}
