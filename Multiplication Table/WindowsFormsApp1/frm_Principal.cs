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
    public partial class frm_Principal : Form
    {
        public frm_Principal()
        {
            InitializeComponent();
        }

        private void multiplicationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form1 frmtables=new Form1();
            frmtables.ShowDialog();

        }
    }
}
