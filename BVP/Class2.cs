using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace BVP
{
    public class Vector
    {
        private double data[] = new double();


        private int NumSteps = 100;
        public int Numsteps
        {
            get { return NumSteps; }
            set { NumSteps = value; }
        }
        private double A = 0;
        public double a
        {
            get { return A; }
            set { A = value; }
        public Vector()
        {

        }
    }
}
