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
		//method models the dynamic of infectious disease
		public Vector SIRFunc(Vector v, double t)
		{
		//Just initialise vector to store results
			Vector tmp = new Vector(3);
	        //Calculating the rate of change of susceptible individuals (tmp[0]).
                //It decreases as susceptible individuals (v[0]) come into contact with infected individuals (v[1]).	
			tmp[0] = -beta * v[1] * v[0];
			
		 //Calculating the rate of change of infected individuals (tmp[1]).
                 //It increases as susceptible individuals become infected and decreases as infected individuals recover.
			tmp[1] = beta * v[1] * v[0] - gamma * v[1];

		//Calculating the rate of change of recovered individuals (tmp[2]).
                //It increases as infected individuals recover.	
			tmp[2] = gamma * v[1];
			return tmp;
		}
	}
}

