using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chi_squared_test
{
    public class ChiSquaredTestResult
    {
        public double ChiSquaredValue { get; set; }
        public double PValue { get; set; }
        public double DegreesOfFreedom { get; set; }

        public double[] Expected { get; set; }

        public int[] Observed { get; set; }

        public ChiSquaredTestResult()
        {
            
        }
    }
}
