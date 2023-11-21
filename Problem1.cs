using System;
namespace BVP
{
	public class Problem1
	{
		public Problem1()
		{
		}
		public Vector myequations(Vector v, double t)
		{//u = v[0], m = v[1], v= v[2], n = v[3]
			Vector tmp = new Vector(4);
			tmp[0] = v[1];
			tmp[1] = -v[0] - 0.1 * t * Math.Sin(t);
			tmp[2] = v[3];
			tmp[3] = -v[2];
			return tmp;
		}
	}
}

