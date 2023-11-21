namespace BVP;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, rld!");
        BVPNumerical b = new BVPNumerical();
        b.a = 0;
        b.b = 10;
        b.alpha = 0;
        b.beta = 0;
        b.numSteps = 100;
        Problem1 p = new Problem1();
        Vector vinit = new Vector(4);
        vinit[0] = 0; vinit[1] = 0; vinit[2] = 0; vinit[3] = 1;
        b.Solve(vinit, p.myequations);
        b.OutputSolution();
        Console.ReadLine();
    }
}

