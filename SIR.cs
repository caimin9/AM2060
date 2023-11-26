using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    public class SIR
    {

        public SIR()
        {

        }

        private double beta = .2;
        public double Beta
        {
            get { return beta; }
            set { beta = value; }
        }

        private double gamma = 1 / 14;
        public double Gamma
        {
            get { return gamma; }
            set { gamma = value; }
        }


        Vector Solutions = new Vector(3);
        //Now need to implement model
        
        public Vector SIRFunc(Vector v ,double t)
        {
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

