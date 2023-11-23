using System;
using System.Numerics;

namespace BVP
{
    public delegate Vector vfunc(Vector v, double t);
    public class Euler
	{
		public double a;
		public double b;
		public double alpha;
		public double beta;
        public double s; //guess at slope
        public int numSteps;
        public double[,] solution;
		public Euler()
		{
		}
        public void Solve(vfunc f)
        { 
            Vector vi, vip1;           
            solution = new double[numSteps+1, 3];            
            vi = new Vector(2);
            vi[0] = alpha;
            vi[1] = s;
            int i = 0;
            double time = a;
            double stepSize = (b - a) / numSteps;
            solution[0, 0] = vi[0];
            solution[0, 1] = vi[1]; //slope
            solution[0, 2] = a;
            for (i = 1; i < numSteps+1; i++)
            {
                vip1 = vi + stepSize * f(vi, time);
                time += stepSize;
                solution[i, 0] = vip1[0]; //y
                solution[i, 1] = vip1[1]; //v = y'
                solution[i, 2] = time;
                vi = vip1;
            }
            
        }
        public void OutputSolution()
        {
            int i;
            for (i = 0; i < numSteps + 1; i++)
                Console.WriteLine("{0,10:F3}, {1,10:F3}", solution[i, 0], solution[i, 2]);
        }
    }
}

