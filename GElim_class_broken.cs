using System;
namespace GE2023
{
	public class GElim
	{
		private double[,] A;
		private double[] b;
		private double[,] Aug;
		public GElim()
		{
		}
		public void SwapRows(int row1, int row2)
		{
			int i = 0;
			double tmp = 0;
			for(i=0;i < b.Length+1;i++)
			{
				tmp = Aug[row1, i];
				Aug[row1, i] = Aug[row2, i];
				Aug[row2, i] = tmp;
			}
		}
		public void ElementZero(int rowp, int rowe, double m)
		{
			int i = 0;
            for (i = 0; i < b.Length + 1; i++)
            {
				Aug[rowe, i] = Aug[rowe, i] + m * Aug[rowp,i];
            }
        }
		public void SetValues(double[,] A, double[] b)
		{
			//note we should not modify these values
			this.A = A;
			this.b = b;
			//we should check the sizes etc
			//create augmented matrix
			int rows = b.Length;
			int cols = rows + 1;
			Aug = new double[rows,cols];
			//fill in the values
			int i, j;
			for (i = 0; i < rows; i++)
				for (j = 0; j < rows; j++)
					Aug[i, j] = A[i, j];
			for (i = 0; i < rows; i++)
				Aug[i, cols - 1] = b[i];
			}
		public void DisplayMatrix()
		{
			int i, j;
			for(i=0; i < b.Length; i++)
			{
				for (j = 0; j < b.Length+1; j++)
					Console.Write("{0,10:F2}", Aug[i, j]);
				Console.Write("\n");
			}
			Console.Write("\n");
		}
		public double[] Solve()
		{
			int i, j;
			double pivot, rowvalue, m;
			double[] x = new double[b.Length];
			//go through the pivots
			for (i=0;i<b.Length-1;i++) 
			{
				pivot = Aug[i, i];
				for(j = i+1; j < b.Length; j++)
				{
					rowvalue = Aug[j, i];
					m = -rowvalue / pivot;
					ElementZero(i, j, m);
				}
				DisplayMatrix();
			}

			return x;
		}
	}
}

