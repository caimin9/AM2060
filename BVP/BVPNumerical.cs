using System;
using System.Numerics;

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
		public BVPNumerical()
		{
		}
        public void Solve(Vector init, vfunc f)
        { 
            Vector vi, vip1;
            //the fourth entry is for the actual solution
            solution = new double[numSteps+1, 4];
            double c2;
            vi = init;
            int i = 0;
            double time = a;
            double stepSize = (b - a) / numSteps;
            solution[0, 0] = init[0];
            solution[0, 1] = init[2];
            solution[0, 2] = a;
            //Console.WriteLine("{0}", vi);
            for (i = 1; i < numSteps+1; i++)
            {
                vip1 = vi + stepSize * f(vi, time);
                //Console.WriteLine("{0}", vip1);
                time += stepSize;
                solution[i, 0] = vip1[0];
                solution[i, 1] = vip1[2];
                solution[i, 2] = time;
                
                vi = vip1;

            }
            //compute the constant
            c2 = (beta - solution[numSteps, 0]) / solution[numSteps, 1];
            //save the solution
            for (i = 0; i < numSteps+1; i++)
                solution[i, 3] = solution[i, 0] + c2 * solution[i, 1];
        }
        public void OutputSolution()
        {
            int i;
            for (i = 0; i < numSteps + 1; i++)
                Console.WriteLine("{0,10:F3}, {1,10:F3}", solution[i, 2], solution[i, 3]);
        }
    }
}

