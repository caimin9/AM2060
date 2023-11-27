using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace SIR_EXAM
{
    public class EulerSIR
    {
        private Vector init = new Vector(3);

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

        public EulerSIR()
        {


        }
        public void SetInit(double s_input, double i_input, double r_input)
        {
            //All we're saying here is that we take in the user input in e.setInit() and assign it to our variables S,I,R
            init[0] = s_input;
            init[1] = i_input;
            init[2] = r_input;


            //Need to implement something to check that all 3 add up to 1
            if (s_input + i_input + r_input != 1)
            {
                throw new ArgumentException("The sum of S, I, and R should be equal to 1.");
            }

        }


        //Solve in here

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

        public Vector SIRFunc(Vector v, double t)
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

        public delegate Vector vfunc(Vector v, double t);




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
                vip1 = vi + stepsize * SIRFunc(vi, 0);
                // Store the result of each step in the results array
                for (int j = 0; j < vi.Size; j++)
                {
                    results[i, j] = vip1[j];
                }

                Console.WriteLine("{0}", vip1);
                vi = vip1;
            }
        }



        //Converts to Excel
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
