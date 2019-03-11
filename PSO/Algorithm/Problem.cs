using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSO
{
    public class Problem
    {
        /// <summary>
        /// Number of Unknown (Decision) Variables
        /// </summary>
        public int nVar { get; set; }
        /// <summary>
        /// Lower Bound of Decision Variables
        /// </summary>
        public int VarMin { get; set; }
        /// <summary>
        /// LUpper Bound of Decision Variables
        /// </summary>
        public int VarMax{ get; set;}
    }
}
