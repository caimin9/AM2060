namespace LotkaVoltera
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LV lv = new LV();


            lv.Num_Steps = 100;
            lv.StepSize = .01;
            lv.SetInit(20,20);
            lv.Solve();
            //lv.Excel();
        }
    }
}
