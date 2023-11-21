using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace BVP
{

    public delegate Vector vfunc(Vector v, double t);
       
    public class BVPNumerical
    {
        public double a;
        public double b;
        public double alpha;
        public double beta;
        public int numSteps;
        public double[,] solution;

        public  BVPNumerical()
        {
        }
        public void Solve(Vector init,vfunc f)
        {
            Vector vi, vip1;
            vi = init;
            int i = 0;
            double time = a;
            solution = new double[numSteps + 1, 3];
            double stepSize = (b - a) / numSteps;
            solution[i+1, 0] = vip[0];
            solution[i+1, 1] = vip[2];
            //This is our intial time
            solution[i+1, 2] = time;
            for (i = 0; i < numSteps; i++)
            {
                vip1 = vi + stepSize * f(vi, time);
                time += stepSize;
                vi = vip1;
            }
        }
    }
}
