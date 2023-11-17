using System;
namespace Trap2023
{
	public class normal
	{
		private double mu = 0;
		public double Mu
		{
			get { return mu; }
			set { mu = value; }
		}
		private double sigma = 1;
		public double Sigma
		{
			get { return sigma; }
			set { sigma = value; }
		}
		public normal()
		{
		}
        public double Evaluate(double x)
        {
            double val = 1 / (sigma * Math.Sqrt(2 * Math.PI)) * Math.Exp(-((x - mu) * (x - mu)) / (2 * sigma * sigma));
            return val;
        }
    }
}

