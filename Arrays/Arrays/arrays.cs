using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class arrays
    {
        int[,] matrix;
        int[] vector;
        int[,] matrix_A;
        int[,] matrix_B;
        int[,] res_matrix;
        int data;
        /*NUMBER PERFECT*/
        Random rand = new Random();
        public bool calc_perfect(int n)
        {
            int sum = 0;
            for (int divisor = 1; divisor < n; divisor++)
            {
                if (n % divisor == 0)
                    sum += divisor;
            }
            if (sum == n)
                return true;
            else
                return false;

        }
        public int[] read_vector(int n)
        {
            vector = new int[n];
            for (int i = 0; i < n; i++)
            {
                data = rand.Next(0, 100);
                Console.WriteLine("Vector[{0}]= {1}", i,data);
                vector[i] = data;
                /*
                Console.Write("Vector[{0}]= ", i);
                vector[i] = Convert.ToInt32(Console.ReadLine());*/

            }

            return vector;
        }
        public int[,] read_matrix(int rows, int columns)
        {
            matrix = new int[rows, columns];
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    data = rand.Next(0, 100);
                    Console.WriteLine("Matrix [{0},{1}]= {2}", r, c,data);
                    matrix[r, c] = data;
                }
            }
            return matrix;

        }
        public int[,] read_matrix_A(int rows,int columns)
        {
            matrix_A = new int[rows, columns];
            for(int r = 0; r < rows; r++)
            {
                for(int c = 0; c < columns; c++)
                {
                    data = rand.Next(0, 100);
                    Console.WriteLine("Matrix [{0},{1}]= {2}", r, c, data);
                    matrix_A[r, c] = data;
                }
            }
            return matrix_A;
        }
        public int[,] read_matrix_B(int rows, int columns)
        {
            matrix_B = new int[rows, columns];
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    data = rand.Next(0, 100);
                    Console.WriteLine("Matrix [{0},{1}]= {2}", r, c, data);
                    matrix_B[r, c] = data;
                }
            }
            return matrix_B;
        }
        /*******************************************************************************/
        public int[,] multiplication_matrix(int[,] a, int[,] b)
        {
            res_matrix = new int[a.GetLength(0), b.GetLength(1)];
            for(int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    res_matrix[i, j] = a[i, j] * b[i, j];
                }
            }
            return res_matrix;
        }
        public int sum_vector(int[] v)
        {
            int sum = 0;
            for (int i = 0; i < v.Length; i++)
            {
                sum += v[i];
            }
            return sum;
        }
        public int sum_matrix(int[,] m)
        {
            int sum = 0;
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    sum += m[i, j];
                }
            }
            return sum;
        }
        /******************************************************************************/
        public void print_vector(int[] v)
        {
            for (int i = 0; i < v.Length; i++)
            {
                Console.Write(v[i] + " ");
            }
        }
        public void print_matrix(int[,] m)
        {
            for (int x = 0; x < m.GetLength(0); x++)
            {
                for (int y = 0; y < m.GetLength(1); y++)
                {
                    Console.Write("[{0}]", m[x, y]);
                }
                Console.WriteLine();
            }
        }
    }
}
