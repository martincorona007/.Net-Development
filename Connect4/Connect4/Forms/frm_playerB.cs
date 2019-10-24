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
        
        bool res1;
        bool res2;
        bool res3;
        bool res4;
        bool res5;
        bool res6;
        bool res7;
        bool res8;
        bool res9;
        bool res10;
        bool res11;
        bool res12;

        public frm_playerB()
        {
            InitializeComponent();
            //this.lbl_section_100.Image = Properties.Resources.rsz_p3_white;
            //this.lbl_section_201.Image = Properties.Resources.rsz_p3_white;
            /*for (int i = 0;i < x.GetLength(0); i++){
                 for(int j = 0; j < x.GetLength(1); j++)
                {
                    x[i, j] = 0;
                }
            }*/
            print();
           // get_winner();
        }

        private void frm_playerB_Load(object sender, EventArgs e)
        {
            //load_data(ro,co);
            //read_matrix_A(ro, co);
            //  delta();
           // print();
            //get_winner();
        }
        private void get_winner()
        {
            Console.WriteLine("last player " + player);
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
            compare_h1();
            compare_h2();
            compare_h3();
            compare_h4();
            compare_v1();
            compare_v2();
            compare_v3();
            compare_D1();
            compare_D2();
            compare_D3();
            compare_D4();
            compare_D5();
            compare_D6();
            get_winner();
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
            compare_h1();
            compare_h2();
            compare_h3();
            compare_h4();
            compare_v1();
            compare_v2();
            compare_v3();
            compare_D1();
            compare_D2();
            compare_D3();
            compare_D4();
            compare_D5();
            compare_D6();
            get_winner();
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
            compare_h1();
            compare_h2();
            compare_h3();
            compare_h4();
            compare_v1();
            compare_v2();
            compare_v3();
            compare_D1();
            compare_D2();
            compare_D3();
            compare_D4();
            compare_D5();
            compare_D6();
            get_winner();
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
            compare_h1();
            compare_h2();
            compare_h3();
            compare_h4();
            compare_v1();
            compare_v2();
            compare_v3();
            compare_D1();
            compare_D2();
            compare_D3();
            compare_D4();
            compare_D5();
            compare_D6();
            get_winner();
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
            compare_h1();
            compare_h2();
            compare_h3();
            compare_h4();
            compare_v1();
            compare_v2();
            compare_v3();
            compare_D1();
            compare_D2();
            compare_D3();
            compare_D4();
            compare_D5();
            compare_D6();
            get_winner();
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
            compare_h1();
            compare_h2();
            compare_h3();
            compare_h4();
            compare_v1();
            compare_v2();
            compare_v3();
            compare_D1();
            compare_D2();
            compare_D3();
            compare_D4();
            compare_D5();
            compare_D6();
            get_winner();
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
            compare_h1();
            compare_h2();
            compare_h3();
            compare_h4();
            compare_v1();
            compare_v2();
            compare_v3();
            compare_D1();
            compare_D2();
            compare_D3();
            compare_D4();
            compare_D5();
            compare_D6();
            get_winner();
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
        private bool compare_h1()
        {

            for (int i = 0; i <= 5; i++)
            {
                if ((x[i, 0] == 0) && (x[i, 1] == 0) && (x[i, 2] == 0) && (x[i, 3] == 0))
                {
                    //Console.WriteLine("nopH1");
                }
                else if ((x[i, 0] == x[i, 1]) && (x[i, 2] == x[i, 3]) && (x[i, 0] == x[i, 2]) && (x[i, 1] == x[i, 3]))
                {
                    res1 = true;
                    Console.WriteLine("yesH1");
                }
                else
                {
                    //Console.WriteLine("nopH1");
                }
            }
            return res1;
        }
        private bool compare_h2()
        {
            for (int i = 0; i <= 5; i++)
            {
                if ((x[i, 1] == 0) && (x[i, 2] == 0) && (x[i, 3] == 0) && (x[i, 4] == 0))
                {
                    //    Console.WriteLine("nopV4");
                }
                else if ((x[i, 1] == x[i, 2]) && (x[i, 3] == x[i, 4]) && (x[i, 1] == x[i, 3]) && (x[i, 2] == x[i, 4]))
                {
                    res5 = true;
                    Console.WriteLine("yesh2");
                }
                else
                {
                    //Console.WriteLine("nopV4");
                }
            }
            return res2;
        }
        private bool compare_h3()
        {
            for (int i = 0; i <= 5; i++)
            {
                if ((x[i, 2] == 0) && (x[i, 3] == 0) && (x[i, 4] == 0) && (x[i, 5] == 0))
                {
                    //    Console.WriteLine("nopV4");
                }
                else if ((x[i, 2] == x[i, 3]) && (x[i, 4] == x[i, 5]) && (x[i, 2] == x[i, 4]) && (x[i, 3] == x[i, 5]))
                {
                    res5 = true;
                    Console.WriteLine("yesh3");
                }
                else
                {
                    //Console.WriteLine("nopV4");
                }
            }
            return res3;
        }
        private bool compare_h4()
        {
            for (int i = 0; i <= 5; i++)
            {
                if ((x[i, 3] == 0) && (x[i, 4] == 0) && (x[i, 5] == 0) && (x[i, 6] == 0))
                {
                    //    Console.WriteLine("nopV4");
                }
                else if ((x[i, 3] == x[i, 4]) && (x[i, 5] == x[i, 6]) && (x[i, 3] == x[i, 5]) && (x[i, 4] == x[i, 6]))
                {
                    res5 = true;
                    Console.WriteLine("yesh4");
                }
                else
                {
                    //Console.WriteLine("nopV4");
                }
            }
            return res5;
        }
        /**************************************************************************************/
        private bool compare_v1()
        {
            for (int i = 0; i <= 6; i++)
            {
                if ((x[0, i] == 0) && (x[1, i] == 0) && (x[2, i] == 0) && (x[3, i] == 0))
                {
                    //     Console.WriteLine("nopH2");
                }
                else if ((x[0, i] == x[1, i]) && (x[2, i] == x[3, i]) && (x[0, i] == x[2, i]) && (x[1, i] == x[3, i]))
                {
                    res3 = true;
                    Console.WriteLine("yesV1");
                }
                else
                {
                    // Console.WriteLine("nopH2");
                }
            }
            return res3;
        }
        private bool compare_v2()
        {
            for (int i = 0; i <= 6; i++)
            {
                if ((x[1, i] == 0) && (x[2, i] == 0) && (x[3, i] == 0) && (x[4, i] == 0))
                {
                    //     Console.WriteLine("nopH2");
                }
                else if ((x[1, i] == x[2, i]) && (x[3, i] == x[4, i]) && (x[1, i] == x[3, i]) && (x[2, i] == x[4, i]))
                {
                    res4 = true;
                    Console.WriteLine("yesV2");
                }
                else
                {
                    // Console.WriteLine("nopH2");
                }
            }
            
            return res4;
        }
        private bool compare_v3()
        {
            for (int i = 0; i <= 6; i++)
            {
                if ((x[2, i] == 0) && (x[3, i] == 0) && (x[4, i] == 0) && (x[5, i] == 0))
                {
                    //     Console.WriteLine("nopH2");
                }
                else if ((x[2, i] == x[3, i]) && (x[4, i] == x[5, i]) && (x[2, i] == x[4, i]) && (x[3, i] == x[5, i]))
                {
                    res5 = true;
                    Console.WriteLine("yesV3");
                }
                else
                {
                    // Console.WriteLine("nopH2");
                }
            }
            return res5;
        }
        
        /*****************************************************************************************/
        private bool compare_D1()
        {
            int i = 0, j = 1, k = 2, z = 3;

            for (int iter = 0; iter <= 5; iter++)
            {
                if ((i != 4 && j != 5 && k != 6 && z != 7))
                {
                    Console.WriteLine(" i" + i + " j" + j + " k" + k + " z" + z);
                    if ((x[0, i] == 0 && x[1, j] == 0) && (x[2, k] == 0 && x[3, z] == 0))
                    {

                    }
                    else
                    {
                        if (((x[0, i] == x[1, j]) && (x[2, k] == x[3, z])) && ((x[1, j] == x[2, k]) && (x[0, i] == x[3, z])))
                        {
                            Console.WriteLine("yesD1");
                            
                            res6 = true;
                        }
                        i+=1; j+=1; k+=1; z+=1;
                    }
                    
                }
                

            }
            /*for (int i = 0; i <= 3; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    for (int k = 2; k <= 5; k++)
                    {
                        for (int it = 3; it <= 6; it++)
                        {
                            if ((x[0, i] == 0 && x[1, j] == 0) && (x[2, k] == 0 && x[3, it] == 0))
                            {

                            }
                            else if (((x[0, i] == x[1, j]) && (x[2, k] == x[3, it])) && ((x[0, i] == x[2, k]) && (x[1, j] == x[3, it])))
                            {
                                Console.WriteLine("" + i, j, k, it);
                                Console.WriteLine("yesD1");
                                res6 = true;

                            }
                        }
                    }


                }
            }*/
            /* for (int j = 2; j <= 5; j++)
             {
                 for (int i = 0; i <= 3; i++)
                 {

                     if ((x[0, i] == 0 && x[1, i+1] == 0) && (x[2, j] == 0 && x[3, j+1] == 0))
                     {

                     }else if (((x[0,i]==x[1,i+1])&&(x[2,j]==x[3,j+1])) && ((x[0,i]==x[2,j])&&(x[1,i+1]==x[3,j+1])))
                     {
                             Console.WriteLine("yesD1");
                             res6 = true;

                     }

                 }
             }
             */
            /*int i = 0, j = 1, k = 2, z = 3;

            for (int iter = 0; iter <= 4; iter++)
            {
                if ((i != 3 && j != 4 && k != 5 && z != 6))
                {
                    if ((x[0, i] == 0 && x[1, j] == 0) && (x[2, k] == 0 && x[3, z] == 0))
                    {

                    }
                    else
                    {
                        if (((x[0, i] == x[1, j]) && (x[2, k] == x[3, z])) && ((x[1, j] == x[2, k]) && (x[0, i] == x[3, z])))
                        {
                            Console.WriteLine("yesD1");
                            res6 = true;
                        }
                        
                    }
                    i++; j++; k++; z++;
                }
                
            }
            */

            return res6;
        }
        private bool compare_D2()
        {
            /*for (int i = 0; i <= 3; i++)
            {
                for (int j = 2; j <= 5; j++)
                {
                    if ((x[1, i] == 0 && x[2, i + 1] == 0) && (x[3, j] == 0 && x[4, j + 1] == 0))
                    {

                    }
                    else
                    {
                        if (((x[1, i] == x[2, i + 1]) && (x[3, j] == x[4, j + 1])) && ((x[1, i] == x[4, j + 1]) && (x[2, i + 1] == x[3, j])))
                        {
                            Console.WriteLine("yesD2");
                            res6 = true;

                        }
                    }
                }
            }*/
            return res7;
        }
        private bool compare_D3()
        {
            int i = 0, j = 1, k = 2, z = 3;

            for (int iter = 0; iter <= 4; iter++)
            {
                if ((i != 3 && j != 4 && k != 5 && z != 6))
                {
                    if ((x[2, i] == 0 && x[3, j] == 0) && (x[4, k] == 0 && x[5, z] == 0))
                    {

                    }
                    else
                    {
                        if (((x[2, i] == x[3, j]) && (x[4, k] == x[5, z])) && ((x[3, j] == x[4, k]) && (x[2, i] == x[5, z])))
                        {
                            Console.WriteLine("yesD3");
                            res7 = true;
                        }
                        i++; j++; k++; z++;
                    }
                }
            }
            return res8;
        }
        private bool compare_D4()
        {
            int i = 3, j = 2, k = 1, z = 0;

            for (int iter = 0; iter <= 4; iter++)
            {
                if ((i != 6 && j != 5 && k != 4 && z != 3))
                {
                    if ((x[0, i] == 0 && x[1, j] == 0) && (x[2, k] == 0 && x[3, z] == 0))
                    {

                    }
                    else
                    {
                        if (((x[0, i] == x[1, j]) && (x[2, k] == x[3, z])) && ((x[1, j] == x[2, k]) && (x[0, i] == x[3, z])))
                        {
                            Console.WriteLine("yesD4");
                            res10 = true;
                        }
                        i++; j++; k++; z++;
                    }
                }
            }
            return res9;
        }
        private bool compare_D5()
        {
            bool flag =true;
            
            int i = 3, j = 2, k = 1, z = 0;

            for (int iter = 0; iter <= 4; iter++)
            {
                if ((i != 6 && j != 5 && k != 4 && z != 3))
                {
                    if ((x[1, i] == 0 && x[2, j] == 0) && (x[3, k] == 0 && x[4, z] == 0))
                    {

                    }
                    else
                    {
                        if (((x[1, i] == x[2, j]) && (x[3, k] == x[4, z])) && ((x[2, j] == x[3, k]) && (x[1, i] == x[4, z])))
                        {
                            Console.WriteLine("yesD5");
                            res10 = true;
                        }
                        i++; j++; k++; z++;
                    }
                }
            }
                
            
            return res10;

        }
        private bool compare_D6()
        {
            int i = 3, j = 2, k = 1, z = 0;
            

            for (int iter = 0; iter <= 4; iter++)
            {
                if ((i != 6 && j != 5 && k != 4 && z != 3))
                {
                    if ((x[2, i] == 0 && x[3, j] == 0) && (x[4, k] == 0 && x[5, z] == 0))
                    {

                    }
                    else
                    {
                        if (((x[2, i] == x[3, j]) && (x[4, k] == x[5, z])) && ((x[3, j] == x[4, k]) && (x[2, i] == x[5, z])))
                        {
                            Console.WriteLine("yesD6");
                            res11 = true;
                        }
                        i++; j++; k++; z++;
                    }
                }
            }


            return res11;
        }
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
