using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Acept_Click(object sender, EventArgs e)
        {
            try
            {
                listBo.Items.Clear();
                int tabla = Convert.ToInt32(comboBox1.Text);
                for (int i = 1; i <= 10; i++)
                {
                    listBo.Items.Add(tabla + " * " + i + " = " + tabla * i);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Multiplication");
            }
            
         
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            //txt_Number.Clear();
            //txt_Number.Text = "";
            listBo.Items.Clear();
            //txt_Number.Focus();
        }

        private void listBo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        

        private void txt_Number_Action(object sender, KeyPressEventArgs e)
        {/*
            int t = Convert.ToInt32(txt_Number.Text);
            if (t>1 && t < 1000)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    listBo.Items.Clear();
                    int tabla = Convert.ToInt32(txt_Number.Text);
                    for (int i = 1; i < 10; i++)
                    {
                        listBo.Items.Add(tabla + " * " + i + " = " + tabla * i);
                    }
                }
            }*/
            
            
        }

        private void txt_keyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Acept_Click(this, new EventArgs());
            }
        }

        private void txt_Number_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
