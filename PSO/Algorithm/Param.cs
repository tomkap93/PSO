using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSO
{
  public  class Param
    {
        /// <summary>
        /// Maximum Number of Iterations
        /// </summary>
        public int MaxIterations { get; set; }
        /// <summary>
        /// Population Size (Swarm Size)
        /// </summary>
        public int nPop { get; set; }
        /// <summary>
        /// Intertia Coefficient
        /// </summary>
        public double w { get; set; }
        /// <summary>
        /// Damping Ratio of Inertia Coefficient
        /// </summary>
        public double wdamp { get; set; }
        /// <summary>
        /// Personal Acceleration Coefficient
        /// </summary>
        public double c1 { get; set; }
        /// <summary>
        /// Social Acceleration Coefficient
        /// </summary>
        public double c2 { get; set; }
    }
}
