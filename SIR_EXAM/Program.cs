namespace SIR_EXAM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EulerSIR e = new EulerSIR();
            e.Num_Steps = 100;
            e.StepSize = .01;
            e.SetInit(.999, .001, 0);
            e.Solve();
            //Takes in directory of csv file as input
            //e.Excel();
        }
    }
}