using System.Numerics;

namespace Euler
{
    public class Program
    {
        static void Main(string[] args)
        {

            Class1 e = new Class1();
            Vector v = new Vector(3);
            
            /*
             v[0] = 1;
            v[1] = 3;
            v[2] = -3;
            */
            
            /*
            Vector w = new Vector(3);
            w[0] = 1.2;
            w[1] = -3.4;
            w[2] = 2;
            Vector c = w - .1 * v;
            */
            //answer = {1.1, 2.66, -3.2}
            SIR s = new SIR();
            s.Beta = 2.0 / 14;
            s.Gamma = 1.0 / 14;
            //Sets initial conditions
            e.setInit(.999, .001, 0);

            //v[0] = 0.999;
            //v[1] = 0.001;
            //v[2] = 0;
            e.StepSize = .01;
            e.Num_Steps = 1000;

            e.Solve(s.SIRFunc);
            //This works for csv files but not xlsx
            //Also remember to put \\ instead of \
            e.Excel("C:\\Users\\caimi\\Downloads\\Test_C.csv");
            

            //Lokta-Volterra
           
           LV lv = new LV();
           lv.Alpha = 2.0 / 3;
           lv.Beta = 4.0 / 3;
           lv.Delta = 1;
           lv.Gamma = 1;
           //initial condition
           e.StepSize = 0.1;
           e.Num_Steps = 5000;
           e.Solve(lv.LVFunc);
           
            Console.ReadLine();
            e.Excel("C:\\Users\\caimi\\Downloads\\Test_C.csv");







        }
    }
}
