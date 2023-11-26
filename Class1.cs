using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    public class Class1
    {

        public delegate Vector vfunc(Vector v, double t);

        //I need to allow the user to set the step size
        //I need to allow the user to set the number of steps
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

        public Class1()
        {


        }

        private Vector init = new Vector(3);
        public void setInit(double s_input, double i_input, double r_input)
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

        //I had it taking in a vector init beofre 
        private double[,] results;

        public void Solve(vfunc f)
        {

            Vector vi, vip1;
            vi = init;
            results = new double[numSteps, vi.Size];

            int i = 0;
            Console.WriteLine("{0}", vi);
            for (i = 0; i < numSteps; i++)
            {
                vip1 = vi + stepsize * f(vi, 0);
                // Store the result of each step in the results array
                for (int j = 0; j < vi.Size; j++)
                {
                    results[i, j] = vip1[j];
                }

                Console.WriteLine("{0}", vip1);
                vi = vip1;
            }



        }

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

