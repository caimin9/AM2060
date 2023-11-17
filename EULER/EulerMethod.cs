using System;
namespace EulerVector
{
	public delegate Vector vfunc(Vector v, double t);
	public class EulerMethod
	{
		private double stepSize = 0.1;
		public double StepSize
		{
			get { return stepSize; }
			set { stepSize = value; }
		}
		private int numSteps = 100;
		public int NumSteps
		{
			get { return numSteps; }
			set { numSteps = value; }
		}
		public EulerMethod()
		{
		}
		public void Solve(Vector init, vfunc f)
		{;
			Vector vi, vip1;
			vi = init;
			int i = 0;
            Console.WriteLine("{0}", vi);
            for (i = 0; i < numSteps; i++)
			{
				vip1 = vi + stepSize * f(vi, 0);
				Console.WriteLine("{0}", vip1);
				vi = vip1;
			}
		}
	}
}

