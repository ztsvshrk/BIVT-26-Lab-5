using System.Linq;
using System.Runtime.InteropServices;

namespace Lab5
{
    public class Blue
    {
        public double[] Task1(int[,] matrix)
        {
            double[] answer = null;

            // code here
            int r = matrix.GetLength(0);
            int c = matrix.GetLength(1);
            answer = new double[r];
            for (int i = 0; i < r; i++)
            {
                double sum = 0;
                int cnt = 0;
                for (int j = 0; j < c; j++)
                {
                    if (matrix[i, j] > 0)
                    {
                        sum += matrix[i, j];
                        cnt++;
                    }
                }
                if (cnt > 0)
                {
                    answer[i] = sum / cnt;
                }
                else
                {
                    answer[i] = 0;
                }
            }
            // end

            return answer;
        }
        public int[,] Task2(int[,] matrix)
        {
            int[,] answer = null;

            // code here
            int r = matrix.GetLength(0);
            int c = matrix.GetLength(1);
            int maxi = 0;
            int maxj = 0;
            int max = matrix[0, 0];
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    if (matrix[i, j] > max)
                    {
                        max = matrix[i, j];
                        maxi = i;
                        maxj = j;
                    }
                }
            }
            answer = new int[r - 1, c - 1];
            int a = 0;
            for (int i = 0; i < r; i++)
            {
                if (i == maxi) continue;
                int b = 0;
                for (int j = 0; j < c; j++)
                {
                    if (j == maxj) continue;
                    answer[a, b] = matrix[i, j];
                    b++;
                }
                a++;
            }
            // end

            return answer;
        }
        public void Task3(int[,] matrix)
        {

            // code here
            int r = matrix.GetLength(0);
            int c = matrix.GetLength(1);
            for (int i = 0; i < r; i++)
            {
                int maxj = 0;
                int max = matrix[i, 0];
                for (int j = 1; j < c; j++)
                {
                    if (matrix[i, j] > max)
                    {
                        max = matrix[i, j];
                        maxj = j;
                    }
                }
                int temp = matrix[i, maxj];
                for (int j = maxj; j < c - 1; j++)
                {
                    matrix[i, j] = matrix[i, j + 1];
                }
                matrix[i, c - 1] = temp;
            }
            // end

        }
        public int[,] Task4(int[,] matrix)
        {
            int[,] answer = null;

            // code here

            // end

            return answer;
        }
        public int[] Task5(int[,] matrix)
        {
            int[] answer = null;

            // code here

            // end

            return answer;
        }
        public void Task6(int[,] matrix, int k)
        {

            // code here

            // end

        }
        public void Task7(int[,] matrix, int[] array)
        {

            // code here

            // end

        }
        public void Task8(int[,] matrix)
        {

            // code here

            // end

        }
        public void Task9(int[,] matrix)
        {

            // code here

            // end

        }
        public void Task10(int[,] matrix)
        {

            // code here

            // end

        }
        public void Task11(int[,] matrix)
        {

            // code here

            // end

        }
        public int[][] Task12(int[][] array)
        {
            int[][] answer = null;

            // code here

            // end

            return answer;
        }
    }
}
