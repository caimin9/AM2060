using System;
using System.Transactions;

namespace BVP
{
	public class BVPNonlin
	{
		public Euler e = new Euler();
		public BVPNonlin()
		{
		}
		public void Solve(double s)
		{
			
			e.a = 1;
			e.alpha = 17;
			e.b = 3;
			e.beta = 43.0 / 3;
			e.s = s;
			e.numSteps = 1000;			
			e.Solve(Nonlinfunc);
			//e.OutputSolution();
			

		}
		public void Tabulate(double froms, double tos, int steps)
		{
			int i = 0;
			double delta = (tos- froms)/steps;
			double s;
			for(i = 0; i < steps+1; i++)
			{
				s = froms + i * delta;
				Solve(s);
				Console.WriteLine("slope s = {0}, y(b)-beta = {1:F3}", s,e.solution[e.numSteps,0]-e.beta);
			}
		}
		public Vector Nonlinfunc(Vector v, double t)
		{ //v[0] is y, v[1] is y' = v
			Vector tmp = new Vector(2);
			tmp[0] = v[1];
			tmp[1] = 1.0 / 8.0 * (32.0 + 2.0 * t * t * t - v[0] * v[1]);
			return tmp;
		}
	}
}

