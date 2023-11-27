using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace LotkaVoltera
{
    public class LV
    {

        private double stepsize = 0.1;

        public double StepSize
        {   //all this does is let us change the number of steps with ease in our main
            get { return stepsize; }
            set { stepsize = value; }
        }

        //Need to put in number of steps aswell
        private int numSteps = 100;

        public int Num_Steps
        {
            get { return numSteps; }
            set { numSteps = value; }
        }

        private Vector init = new Vector(2);
        public void SetInit(double predator, double prey)
        {
            //All we're saying here is that we take in the user input in e.setInit() and assign it to our variables S,I,R
            init[0] = predator;
            init[1] = prey;

        }



        public LV()
        {

        }


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




        private double[,] results;

        public void Solve()
        {

            Vector vi, vip1;
            vi = init;
            results = new double[numSteps, vi.Size];

            int i = 0;
            Console.WriteLine("{0}", vi);
            for (i = 0; i < numSteps; i++)
            {
                vip1 = vi + stepsize * LVFunc(vi, 0);
                // Store the result of each step in the results array
                for (int j = 0; j < vi.Size; j++)
                {
                    results[i, j] = vip1[j];
                }

                Console.WriteLine("{0}", vip1);
                vi = vip1;
            }



        }


        //Excel Output

        public void Excel(string path)
        {
            using (StreamWriter sw = new StreamWriter(path))
            {
                for (int i = 0; i < results.GetLength(0); i++)
                {
                    for (int j = 0; j < results.GetLength(1); j++)
                    {
                        sw.Write(results[i, j].ToString("F3"));
                        if (j < results.GetLength(1) - 1)
                        {
                            sw.Write(", ");
                        }
                    }
                    sw.WriteLine();
                }
            }

        }
    }

}
