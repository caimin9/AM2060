namespace BVP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, world!");
            BVPNonlin b = new BVPNonlin();
            //b.Solve();
            b.Tabulate(-20, 20, 10);
            Console.ReadLine();
        }
    }
}

