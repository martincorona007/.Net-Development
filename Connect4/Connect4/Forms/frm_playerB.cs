using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Connect4.Forms
{
    public partial class frm_playerB : Form
    {

        int[,] x = new int[6, 7];
        Random rand = new Random();
        int ro = 6;
        int co = 7;
        int s1 = 5;
        int s2 = 5;
        int s3 = 5;
        int s4 = 5;
        int s5 = 5;
        int s6 = 5;
        int s7 = 5;
        int player = 1;
        int color;

        public frm_playerB()
        {
            InitializeComponent();
            //this.lbl_section_100.Image = Properties.Resources.rsz_p3_white;
            //this.lbl_section_201.Image = Properties.Resources.rsz_p3_white;
            for (int i = 0;i < x.GetLength(0); i++){
                 for(int j = 0; j < x.GetLength(1); j++)
                {
                    x[i, j] = 0;
                }
            }
            print();
        }

        private void frm_playerB_Load(object sender, EventArgs e)
        {
            //load_data(ro,co);
            //read_matrix_A(ro, co);
          //  delta();
        }

        private int delta()
        {
            if (player == 1)
            {
                Console.WriteLine("red 1");
                player = 2;//change player
                color = 1;//print color red where ever the boton is press 
            } else if (player == 2)
            {
                player = 1;//change player
                Console.WriteLine("blue 2");
                color = 2;//print color blue where ever the boton is press 
            }
            return color;
        }
        
        
        private void btn_section_1_Click(object sender, EventArgs e)
        {
            int aux = delta();
            if (aux == 1)//gamer 1
            {
                Console.WriteLine("Color Red out");
                if (s1 == 5)
                {
                    lbl_section_150.Image = Properties.Resources.rsz_p2_red;
                    x[5, 0] = 1;
                }
                if (s1 == 4)
                {
                    lbl_section_140.Image = Properties.Resources.rsz_p2_red;
                    x[4, 0] = 1;
                }
                if (s1 == 3)
                {
                    lbl_section_130.Image = Properties.Resources.rsz_p2_red;
                    x[3, 0] = 1;
                }
                if (s1 == 2)
                {
                    lbl_section_120.Image = Properties.Resources.rsz_p2_red;
                    x[2, 0] = 1;
                }
                if (s1 == 1)
                {
                    lbl_section_110.Image = Properties.Resources.rsz_p2_red;
                    x[1, 0] = 1;
                }
                if (s1 == 0)
                {
                    lbl_section_100.Image = Properties.Resources.rsz_p2_red;
                    x[0, 0] = 1;
                }
            }
            else if (aux == 2)//game 2
            {
                if (s1 == 5)
                {
                    lbl_section_150.Image = Properties.Resources.rsz_p1_blue;
                    x[5, 0] = 2;
                }
                if (s1 == 4)
                {
                    lbl_section_140.Image = Properties.Resources.rsz_p1_blue;
                    x[4, 0] = 2;
                }
                if (s1 == 3)
                {
                    lbl_section_130.Image = Properties.Resources.rsz_p1_blue;
                    x[3, 0] = 2;
                }
                if (s1 == 2)
                {
                    lbl_section_120.Image = Properties.Resources.rsz_p1_blue;
                    x[2, 0] = 2;
                }
                if (s1 == 1)
                {
                    lbl_section_110.Image = Properties.Resources.rsz_p1_blue;
                    x[1, 0] = 2;
                }
                if (s1 == 0)
                {
                    lbl_section_100.Image = Properties.Resources.rsz_p1_blue;
                    x[0, 0] = 2;
                }
                Console.WriteLine("Color Blue out");
            }
            
            s1 -= 1;
            print();
        }

        private void btn_section_2_Click(object sender, EventArgs e)
        {
            int aux = delta();
            if (aux == 1)
            {
                Console.WriteLine("Color Red out");
                if (s2 == 5)
                {
                    lbl_section_251.Image = Properties.Resources.rsz_p2_red;
                    x[5, 1] = 1;
                }
                if (s2 == 4)
                {
                    lbl_section_241.Image = Properties.Resources.rsz_p2_red;
                    x[4, 1] = 1;
                }
                if (s2 == 3)
                {
                    lbl_section_231.Image = Properties.Resources.rsz_p2_red;
                    x[3, 1] = 1;
                }
                if (s2 == 2)
                {
                    lbl_section_221.Image = Properties.Resources.rsz_p2_red;
                    x[2, 1] = 1;
                }
                if (s2 == 1)
                {
                    lbl_section_211.Image = Properties.Resources.rsz_p2_red;
                    x[1, 1] = 1;
                }
                if (s2 == 0)
                {
                    lbl_section_201.Image = Properties.Resources.rsz_p2_red;
                    x[0, 1] = 1;
                }
            }
            else if(aux==2)
            {
                Console.WriteLine("Color Blue out");
                if (s2 == 5)
                {
                    lbl_section_251.Image = Properties.Resources.rsz_p1_blue;
                    x[5, 1] = 2;
                }
                if (s2 == 4)
                {
                    lbl_section_241.Image = Properties.Resources.rsz_p1_blue;
                    x[4, 1] = 2;
                }
                if (s2 == 3)
                {
                    lbl_section_231.Image = Properties.Resources.rsz_p1_blue;
                    x[3, 1] = 2;
                }
                if (s2 == 2)
                {
                    lbl_section_221.Image = Properties.Resources.rsz_p1_blue;
                    x[2, 1] = 2;
                }
                if (s2 == 1)
                {
                    lbl_section_211.Image = Properties.Resources.rsz_p1_blue;
                    x[1, 1] = 2;
                }
                if (s2 == 0)
                {
                    lbl_section_201.Image = Properties.Resources.rsz_p1_blue;
                    x[0, 1] = 2;
                }
            }
            
            s2 -= 1;
            print();
        }

        private void btn_section_3_Click(object sender, EventArgs e)
        {
            int aux = delta();
            if (aux == 1)
            {
                if (s3 == 5)
                {
                    lbl_section_352.Image = Properties.Resources.rsz_p2_red;
                    x[5, 2] = 1;
                }
                if (s3 == 4)
                {
                    lbl_section_342.Image = Properties.Resources.rsz_p2_red;
                    x[4, 2] = 1;
                }
                if (s3 == 3)
                {
                    lbl_section_332.Image = Properties.Resources.rsz_p2_red;
                    x[3, 2] = 1;
                }
                if (s3 == 2)
                {
                    lbl_section_322.Image = Properties.Resources.rsz_p2_red;
                    x[2, 2] = 1;
                }
                if (s3 == 1)
                {
                    lbl_section_312.Image = Properties.Resources.rsz_p2_red;
                    x[1, 2] = 1;
                }
                if (s3 == 0)
                {
                    lbl_section_302.Image = Properties.Resources.rsz_p2_red;
                    x[0, 2] = 1;
                }
            }
            else if (aux == 2)
            {
                if (s3 == 5)
                {
                    lbl_section_352.Image = Properties.Resources.rsz_p1_blue;
                    x[5, 2] = 2;
                }
                if (s3 == 4)
                {
                    lbl_section_342.Image = Properties.Resources.rsz_p1_blue;
                    x[4, 2] = 2;
                }
                if (s3 == 3)
                {
                    lbl_section_332.Image = Properties.Resources.rsz_p1_blue;
                    x[3, 2] = 2;
                }
                if (s3 == 2)
                {
                    lbl_section_322.Image = Properties.Resources.rsz_p1_blue;
                    x[2, 2] = 2;
                }
                if (s3 == 1)
                {
                    lbl_section_312.Image = Properties.Resources.rsz_p1_blue;
                    x[1, 2] = 2;
                }
                if (s3 == 0)
                {
                    lbl_section_302.Image = Properties.Resources.rsz_p1_blue;
                    x[0, 2] = 2;
                }
            }
            
            s3 -= 1;
            print();
        }

        private void btn_section_4_Click(object sender, EventArgs e)
        {
            int aux = delta();
            if (aux == 1)
            {
                if (s4 == 5)
                {
                    lbl_section_453.Image = Properties.Resources.rsz_p2_red;
                    x[5, 3] = 1;
                }
                if (s4 == 4)
                {
                    lbl_section_443.Image = Properties.Resources.rsz_p2_red;
                    x[4, 3] = 1;
                }
                if (s4 == 3)
                {
                    lbl_section_433.Image = Properties.Resources.rsz_p2_red;
                    x[3, 3] = 1;
                }
                if (s4 == 2)
                {
                    lbl_section_423.Image = Properties.Resources.rsz_p2_red;
                    x[2, 3] = 1;
                }
                if (s4 == 1)
                {
                    lbl_section_413.Image = Properties.Resources.rsz_p2_red;
                    x[1, 3] = 1;
                }
                if (s4 == 0)
                {
                    lbl_section_403.Image = Properties.Resources.rsz_p2_red;
                    x[0, 3] = 1;
                }

            }
            else if (aux == 2)
            {
                if (s4 == 5)
                {
                    lbl_section_453.Image = Properties.Resources.rsz_p1_blue;
                    x[5, 3] = 2;
                }
                if (s4 == 4)
                {
                    lbl_section_443.Image = Properties.Resources.rsz_p1_blue;
                    x[4, 3] = 2;
                }
                if (s4 == 3)
                {
                    lbl_section_433.Image = Properties.Resources.rsz_p1_blue;
                    x[3, 3] = 2;
                }
                if (s4 == 2)
                {
                    lbl_section_423.Image = Properties.Resources.rsz_p1_blue;
                    x[2, 3] = 2;
                }
                if (s4 == 1)
                {
                    lbl_section_413.Image = Properties.Resources.rsz_p1_blue;
                    x[1, 3] = 2;
                }
                if (s4 == 0)
                {
                    lbl_section_403.Image = Properties.Resources.rsz_p1_blue;
                    x[0, 3] = 2;
                }
            }
            
            s4 -= 1;
            print();
        }

        private void btn_section_5_Click(object sender, EventArgs e)
        {
            int aux = delta();
            if (aux == 1)
            {
                if (s5 == 5)
                {
                    lbl_section_554.Image = Properties.Resources.rsz_p2_red;
                    x[5, 4] = 1;
                }
                if (s5 == 4)
                {
                    lbl_section_544.Image = Properties.Resources.rsz_p2_red;
                    x[4, 4] = 1;
                }
                if (s5 == 3)
                {
                    lbl_section_534.Image = Properties.Resources.rsz_p2_red;
                    x[3, 4] = 1;
                }
                if (s5 == 2)
                {
                    lbl_section_524.Image = Properties.Resources.rsz_p2_red;
                    x[2, 4] = 1;
                }
                if (s5 == 1)
                {
                    lbl_section_514.Image = Properties.Resources.rsz_p2_red;
                    x[1, 4] = 1;
                }
                if (s5 == 0)
                {
                    lbl_section_504.Image = Properties.Resources.rsz_p2_red;
                    x[0, 4] = 1;
                }
            }
            else if (aux == 2)
            {
                if (s5 == 5)
                {
                    lbl_section_554.Image = Properties.Resources.rsz_p1_blue;
                    x[5, 4] = 2;
                }
                if (s5 == 4)
                {
                    lbl_section_544.Image = Properties.Resources.rsz_p1_blue;
                    x[4, 4] = 2;
                }
                if (s5 == 3)
                {
                    lbl_section_534.Image = Properties.Resources.rsz_p1_blue;
                    x[3, 4] = 2;
                }
                if (s5 == 2)
                {
                    lbl_section_524.Image = Properties.Resources.rsz_p1_blue;
                    x[2, 4] = 2;
                }
                if (s5 == 1)
                {
                    lbl_section_514.Image = Properties.Resources.rsz_p1_blue;
                    x[1, 4] = 2;
                }
                if (s5 == 0)
                {
                    lbl_section_504.Image = Properties.Resources.rsz_p1_blue;
                    x[0, 4] = 2;
                }
            }
            
            s5 -= 1;
            print();
        }
        private void button42_Click(object sender, EventArgs e)
        {
            int aux = delta();
            if (aux == 1)
            {
                if (s6 == 5)
                {
                    lbl_section_655.Image = Properties.Resources.rsz_p2_red;
                    x[5, 5] = 1;
                }
                if (s6 == 4)
                {
                    lbl_section_645.Image = Properties.Resources.rsz_p2_red;
                    x[4, 5] = 1;
                }
                if (s6 == 3)
                {
                    lbl_section_635.Image = Properties.Resources.rsz_p2_red;
                    x[3, 5] = 1;
                }
                if (s6 == 2)
                {
                    lbl_section_625.Image = Properties.Resources.rsz_p2_red;
                    x[2, 5] = 1;
                }
                if (s6 == 1)
                {
                    lbl_section_615.Image = Properties.Resources.rsz_p2_red;
                    x[1, 5] = 1;
                }
                if (s6 == 0)
                {
                    lbl_section_605.Image = Properties.Resources.rsz_p2_red;
                    x[0, 5] = 1;
                }
            }
            else if (aux == 2)
            {
                if (s6 == 5)
                {
                    lbl_section_655.Image = Properties.Resources.rsz_p1_blue;
                    x[5, 5] = 2;
                }
                if (s6 == 4)
                {
                    lbl_section_645.Image = Properties.Resources.rsz_p1_blue;
                    x[4, 5] = 2;
                }
                if (s6 == 3)
                {
                    lbl_section_635.Image = Properties.Resources.rsz_p1_blue;
                    x[3, 5] = 2;
                }
                if (s6 == 2)
                {
                    lbl_section_625.Image = Properties.Resources.rsz_p1_blue;
                    x[2, 5] = 2;
                }
                if (s6 == 1)
                {
                    lbl_section_615.Image = Properties.Resources.rsz_p1_blue;
                    x[1, 5] = 2;
                }
                if (s6 == 0)
                {
                    lbl_section_605.Image = Properties.Resources.rsz_p1_blue;
                    x[0, 5] = 2;
                }
            }
            
            s6 -= 1;
            print();
        }
        
        private void btn_section_7_Click(object sender, EventArgs e)
        {
            int aux = delta();
            if (aux == 1)
            {
                if (s7 == 5)
                {
                    lbl_section_756.Image = Properties.Resources.rsz_p2_red;
                    x[5, 6] = 1;
                }
                if (s7 == 4)
                {
                    lbl_section_746.Image = Properties.Resources.rsz_p2_red;
                    x[4, 6] = 1;
                }
                if (s7 == 3)
                {
                    lbl_section_736.Image = Properties.Resources.rsz_p2_red;
                    x[3, 6] = 1;
                }
                if (s7 == 2)
                {
                    lbl_section_726.Image = Properties.Resources.rsz_p2_red;
                    x[2, 6] = 1;
                }
                if (s7 == 1)
                {
                    lbl_section_716.Image = Properties.Resources.rsz_p2_red;
                    x[1, 6] = 1;
                }
                if (s7 == 0)
                {
                    lbl_section_706.Image = Properties.Resources.rsz_p2_red;
                    x[0, 6] = 1;
                }
            }
            else if (aux == 2)
            {
                if (s7 == 5)
                {
                    lbl_section_756.Image = Properties.Resources.rsz_p1_blue;
                    x[5, 6] = 2;
                }
                if (s7 == 4)
                {
                    lbl_section_746.Image = Properties.Resources.rsz_p1_blue;
                    x[4, 6] = 2;
                }
                if (s7 == 3)
                {
                    lbl_section_736.Image = Properties.Resources.rsz_p1_blue;
                    x[3, 6] = 2;
                }
                if (s7 == 2)
                {
                    lbl_section_726.Image = Properties.Resources.rsz_p1_blue;
                    x[2, 6] = 2;
                }
                if (s7 == 1)
                {
                    lbl_section_716.Image = Properties.Resources.rsz_p1_blue;
                    x[1, 6] = 2;
                }
                if (s7 == 0)
                {
                    lbl_section_706.Image = Properties.Resources.rsz_p1_blue;
                    x[0, 6] = 2;
                }
            }
            s7 -= 1;
            print();
        }
        private void print()
        {
            for (int i = 0; i < x.GetLength(0); i++)
            {
                for (int j = 0; j < x.GetLength(1); j++)
                {
                    Console.Write("[" + x[i, j] + "]");
                }
                Console.WriteLine();
            }
        }

        /*  private void load_data(int get_data1, int get_data2)
          {
              for (int i = 1; i <= get_data2; i++)
              {
                  dGV_Matrix_1.Columns.Add(i.ToString(), i.ToString());

              }
              dGV_Matrix_1.Rows.Add(get_data1 );
          }
          public int[,] read_matrix_A(int rows, int columns)
          {
              matrix_A = new int[rows, columns];
              int data;
              for (int r = 0; r < rows; r++)
              {
                  for (int c = 0; c < columns; c++)
                  {
                     // data = rand.Next(1, 100);
                      //Console.WriteLine("Matrix A [{0},{1}]= {2}", r, c, data);
                      matrix_A[3, 4] = 4;

                      dGV_Matrix_1[3, 4].Value = 4;
                  }
              }
              return matrix_A;

          }*/

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
