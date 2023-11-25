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

		//This just initialises the object
		public LV()
		{
		}

        	//method is intended to model the interaction between two species.
		public Vector LVFunc(Vector v, double t)
		{
		//x is v[0] and y is v[1]
			Vector tmp = new Vector(v.Size);
            	// This represents the rate of change of the first species (prey).
			tmp[0] = alpha * v[0] - beta * v[0] * v[1];
		// This represents the rate of change of the second species (predator).
			tmp[1]  = delta * v[0]*v[1] -gamma *v[1];

			//Give us back the the 2 rates of change in a vector
			return tmp;
		}
	}
}

