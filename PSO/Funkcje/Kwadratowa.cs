using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSO.Funkcje
{
   public class Kwadratowa : IFunkcja
    {  
        public double Funkcja(double x)
        {
            return x * x;
        }
    }
}
