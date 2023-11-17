using System;
namespace Trap2023
{
	public delegate double function(double x);
	public class Trapezoidal
	{
        private double a = 0;
		public double A
		{
			get { return a; }
			set { a = value; }
		}
        private double b = 1;
		public double B
		{
			get { return b; }
			set { b = value; }
		}
        private int nints = 10;
		public int Nints
		{
			get { return nints;}
			set {
				if (value < 10)
					Console.WriteLine("Number of intervals not changed");
				else
					nints = value;
			}
		}

        public Trapezoidal()
		{
		}
		public double Solve(function f)
		{
			int i = 0;
			double h = (b - a) / nints;
			double sum = 0;
			sum += f(a) + f(b);
			for (i = 1; i < nints; i++)
				sum += 2 * f(a + i * h);
			sum *= 0.5 * h;
			return sum;
		}
	}
}

