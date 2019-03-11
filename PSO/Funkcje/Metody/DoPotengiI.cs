using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSO.Funkcje.Metody
{
   public class DoPotengiI
    {
        public static double doPotengiI(double x, int i)
        {
            if (i == 0)
            {
                return 0;
            }
            else if (i == 1)
            {
                return x;
            }
            else
            {
                return x * doPotengiI(x, --i);
            }
        }
    }
}
