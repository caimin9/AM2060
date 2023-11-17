namespace Trap2023;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Trapezoidal t = new Trapezoidal();
        t.A = -1;
        t.B = 1;
        t.Nints = 100;
        double res = t.Solve(normal);
        Console.WriteLine("The answer is {0:F4}", res);
        
        //advanced version withe normal class
        normal n = new normal();
        n.Mu = 1;
        n.Sigma = 2;
        res = t.Solve(n.Evaluate);
        Console.WriteLine("The answer is {0:F4}", res);
        Console.ReadLine();
    }
    public static double normal(double x)
    {
        double mu = 0;
        double sigma = 1;
        double val = 1 / (sigma * Math.Sqrt(2 * Math.PI)) * Math.Exp(-((x - mu) * (x - mu)) / (2 * sigma * sigma));
        return val;
    }
}

