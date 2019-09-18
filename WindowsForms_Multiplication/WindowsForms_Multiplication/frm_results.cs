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
    public partial class frm_results : Form
    {
        public frm_results()
        {
            InitializeComponent();
        }

        private void frm_results_Load(object sender, EventArgs e)
        {
            
        }

        public void dGV_results_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void get_results(int[,] ax,int size)
        {
             for(int i = 1; i <= size; i++)
            {
                dGV_results.Columns.Add(i.ToString(), i.ToString());
            }
            dGV_results.Rows.Add(size * size);

            for(int j = 0; j < size; j++)
            {
                for(int k = 0; k < size; k++)
                {
                    dGV_results[j, k].Value = ax[j, k];
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
