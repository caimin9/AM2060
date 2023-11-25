using System;
namespace EulerVector
{
	public class LV
	{
		private double beta = 0.2;
		public double Beta
		{
			get { return beta; }
			set { beta = value; }
		}
		
		private double alpha = 1;
		public double Alpha
		{
			get { return alpha; }
			set { alpha = value; }
		}
		
		private double delta = 0.1;
		public double Delta
		{
			get{return delta; }
			set{delta = value }
		}
		
		private double gamma = 1;
		public double Gamma
		{
			get{return gamma}
			set{gamma = value}
		}
			
		public LV()
		{
		}
		public Vector LVFunc(Vector v, double t)
		{//x is v[0] and y is v[1]
			//This is our lotka voltera formula
			Vector tmp = new Vector(v.Size);
			tmp[0] = alpha * v[0] - beta * v[0] * v[1];
			tmp[1]  = delta * v[0]*v[1] -gamma *v[1];
			return tmp;
		}
	}
}

