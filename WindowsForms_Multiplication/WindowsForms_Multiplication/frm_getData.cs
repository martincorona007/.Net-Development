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
    public partial class frm_getData : Form
    {
        public frm_getData()
        {
            InitializeComponent();
        }
        public static int d1;
        public static int d2;
        public static int d3;
        public static int d4;
        static int[,] aux_A;
        static int[,] aux_B;
        public static int flag_A;
        public static int flag_B;
        private void button1_Click(object sender, EventArgs e)
        {
        
            try
            {
                d1 = Int32.Parse(textBox1.Text);
                d2 = Int32.Parse(textBox2.Text);
                d3 = Int32.Parse(textBox3.Text);
                d4 = Int32.Parse(textBox4.Text);
                if (((d1 >= 48 || d1 <= 57) && (d2 >= 48 || d2 <= 57))&& ((d3 >= 48 || d3 <= 57) && (d4 >= 48 || d4 <= 57)))
                {
                    if (d1 == d3 && d2 == d4)
                    {
                        flag_A = 1;
                        frm_operation frmk = new frm_operation();
                        frmk.Show();
                        
                        this.Hide();
                    }else if (d2==d3)
                    {
                        flag_B = 1;
                        frm_operation frmk = new frm_operation();
                        frmk.Show();
                        
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("ERROR Rows and Columns must be the same");
                        textBox1.Text = "";
                        textBox2.Text = "";
                        textBox3.Text = "";
                        textBox4.Text = "";

                    }
                }
            }catch (FormatException exx)
            {
                MessageBox.Show( "ERROR 666");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";

            }
            
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
