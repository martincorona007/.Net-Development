using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_Multiplication
{
    public partial class frm_operation : Form
    {
        int get_data1;
        int get_data2;
        int get_data3;
        int get_date4;

        int[,] matrix_A;
        int[,] get_matrix_A;


        int[,] matrix_B;
        int[,] get_matrix_B;

        int[,] res_matrix;
        int[,] res_matrix_sum;
        int[,] res_matrix2_mult;
        int[,] res_matrix2_res;


        Random rand = new Random();
        public bool flag_1 = false;
        public bool flag_2 = false;
        public frm_operation()
        {
            InitializeComponent();
               
        }
        private void frm_operation_Load(object sender, EventArgs e)
        {
            get_data1 = frm_getData.d1;
            get_data2 = frm_getData.d2;
            get_data3 = frm_getData.d3;
            get_date4 = frm_getData.d4;
            
            for(int i = 1; i <= get_data1; i++)
            {
                dGV_Matrix_1.Columns.Add(i.ToString(), i.ToString());
                dGV_Matrix_2.Columns.Add(i.ToString(), i.ToString());
            }
            //how many rows I want?
            dGV_Matrix_1.Rows.Add(get_data1 * get_data2);
            dGV_Matrix_2.Rows.Add(get_data1 * get_data2);
            //fill the matrix
            get_matrix_A=read_matrix_A(get_data1, get_data2);
            get_matrix_B=read_matrix_B(get_data3, get_date4);

            res_matrix_sum = sum_matrix(get_matrix_A, get_matrix_B);
            res_matrix2_mult = multiplication_matrix(get_matrix_A, get_matrix_B);
            res_matrix2_res = subtration_matrix(get_matrix_A, get_matrix_B);

        }
        public int[,] read_matrix_A(int rows, int columns)
        {
            matrix_A = new int[rows, columns];
            int data;
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    data = rand.Next(0, 100);
                    Console.WriteLine("Matrix [{0},{1}]= {2}", r, c, data);
                    matrix_A[r, c] = data;
                    dGV_Matrix_1[r, c].Value = data;
                }
            }
            return matrix_A;

        }
        public int[,] read_matrix_B(int rows, int columns)
        {
            matrix_B = new int[rows, columns];
            int data;
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    data = rand.Next(0, 100);
                    Console.WriteLine("Matrix [{0},{1}]= {2}", r, c, data);
                    matrix_B[r, c] = data;
                    dGV_Matrix_2[r, c].Value = data;
                }
            }
            return matrix_B;

        }
        public int[,] sum_matrix(int[,] a, int[,] b)
        {
            res_matrix = new int[a.GetLength(0), b.GetLength(1)];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    res_matrix[i, j] = a[i, j] + b[i, j];
                }
            }
            return res_matrix;
        }
        public int[,] multiplication_matrix(int[,] a, int[,] b)
        {
            res_matrix = new int[a.GetLength(0), b.GetLength(1)];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    res_matrix[i, j] = a[i, j] * b[i, j];
                }
            }
            return res_matrix;
        }
        public int[,] subtration_matrix(int[,] a, int[,] b)
        {
            res_matrix = new int[a.GetLength(0), b.GetLength(1)];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    res_matrix[i, j] = a[i, j] - b[i, j];
                }
            }
            return res_matrix;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            frm_results res = new frm_results();       
            res.Show();
            res.get_results(res_matrix_sum, get_data1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm_results res = new frm_results();
            res.Show();
            res.get_results(res_matrix2_res, get_data1);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            frm_results res = new frm_results();
            res.Show();
            res.get_results(res_matrix2_mult, get_data1);

        }



    }
}
