using System;
namespace EulerVector
{
	public class SIR
	{
		public double gamma = 1.0/14;
		public double beta = 2*1.0/14;
		public SIR()
		{
		}
		public Vector SIRFunc(Vector v, double t)
		{
			Vector tmp = new Vector(3);
			tmp[0] = -beta * v[1] * v[0];
			tmp[1] = beta * v[1] * v[0] - gamma * v[1];
			tmp[2] = gamma * v[1];
			return tmp;
		}
	}
}

