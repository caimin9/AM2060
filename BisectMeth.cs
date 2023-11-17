using System;
namespace Bisection
{
	public class BisectMeth
	{
		private double a = 0;
		private double b = 1;
		private double tol = 0.0001;
		public void SetInterval(double a, double b)
		{
			this.a = a;
			this.b = b;
		}
		public void Tabulate(int num)
		{
			double h = (b - a) / num;
			int i = 0;
			for (i = 0; i <= num; i++)
				Console.WriteLine("f({0:F2}) = {1:F2}", a + i * h, func(a+i*h));
		}

		public double Solve()
		{
			double mid;
			if(func(a)*func(b) > 0)
			{
				Console.WriteLine("Invalid interval");
				return 0;
			}
			while (b-a > tol)
			{
				mid = (a + b) / 2;
				if (func(a) * func(mid) < 0)
					b = mid;
				else
					a = mid;
			}
			return (a + b) / 2;
		}

		public double func(double x)
		{
			return x * x * x - 2 * x * x - 5 * x + 6;
		}
	}
}

