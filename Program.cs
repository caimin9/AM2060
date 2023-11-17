using System;

namespace EulerVector
{
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Vector v = new Vector(3);
        v[0] = 1;
        v[1] = 3;
        v[2] = -3;
        Vector w = new Vector(3);
        w[0] = 1.2;
        w[1] = -3.4;
        w[2] = 2;
        Vector c = w - .1 * v;
        //answer = {1.1, 2.66, -3.2}
        SIR s = new SIR();
        s.beta = 2.0 / 14;
            s.gamma = 1.0 / 14;
        EulerMethod e = new EulerMethod();
        //Vector v = new Vector(3);
        v[0] = 0.999;
        v[1] = 0.001;
        v[2] = 0;
            e.StepSize = .01;
            e.NumSteps = 2000;
         //e.Solve(v, s.SIRFunc);
            
            //Lokta-Volterra
            LV lv = new LV();
            lv.alpha = 2.0 / 3;
            lv.Beta = 4.0 / 3;
            lv.delta = 1;
            lv.gamma = 1;
            //initial condition
            Vector init = new Vector(2);
            init[0] = 1;
            init[1] = 1;
            e.StepSize = 0.1;
            e.NumSteps = 5000;
            e.Solve(init, lv.LVFunc);
            Console.ReadLine();
        }
}
}

