using System;
namespace NM2023
{
	public class NM
	{
        private double tol = 0.0001;
        double guess = 0;
        public void SetInitGuess(double guess)
        {
            this.guess = guess;
           
        }
        public void Tabulate(double a, double b, int num)
        {
            double h = (b - a) / num;
            int i = 0;
            for (i = 0; i <= num; i++)
                Console.WriteLine("f({0:F2}) = {1:F2}", a + i * h, func(a + i * h));
        }

        public double Solve()
        {
            double xn, xnp1, diff = 1;
            xn = guess;
            while(diff > tol)
            {
                xnp1 = xn - func(xn) / funcd(xn);
                diff = Math.Abs(xnp1 - xn);
                xn = xnp1;
            }
            return xn;
        }

        public double func(double x)
        {
            return x * x * x - 2 * x * x - 5 * x + 6;
        }
        public double funcd(double x)
        {
            return 3 * x * x - 4 * x - 5;
        }
    }
}

