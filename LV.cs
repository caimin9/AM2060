using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    public class LV
    {
        private double gamma = 1;
        public double Gamma
        {
            get { return gamma; }
            set { gamma = value; }
        }

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


        private double delta = .1;
        public double Delta
        {
            get { return delta; }
            set { delta = value; }
        }
        public LV()
        {
        }
        public Vector LVFunc(Vector v, double t)
        {
            //x == v[0] & y ==v[1]
            Vector tmp = new Vector(v.Size);

            //tmp[0] represents the rate of change of the first species (prey).
            tmp[0] = alpha * v[0] - (beta * v[0] * v[1]);

            //tmp[1] represents the rate of change of the second species (predator).
            tmp[1] = (delta * v[0] * v[1]) - (gamma * v[1]);
            return tmp;
        }
    }


}
