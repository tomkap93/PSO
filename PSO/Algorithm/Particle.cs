using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSO
{
    public struct Particle
    {
        public double Position { get; set; }
        public double Velocity { get; set; }
        public double Cost { get; set; }
        public BestPosition Best { get; set; }

    }
}
