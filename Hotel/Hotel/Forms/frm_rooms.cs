using Hotel.Class;
using Hotel.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    public partial class frm_rooms : Form
    {
        private cls_connection cls_con;
        private cls_rooms cls_room;
        public frm_rooms()
        {
            InitializeComponent();
            cls_connection.InitializeDB();
            this.BackgroundImage = Properties.Resources.p2;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void btn_Update_Click(object sender, EventArgs e)
        {

        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            String u = textBox2.Text;
            String d = textBox3.Text;
            String r = textBox4.Text;
            
            if (String.IsNullOrEmpty(u) || String.IsNullOrEmpty(d) || String.IsNullOrEmpty(r))
            {
                MessageBox.Show("It's empty");
                return;
            }

            cls_room = cls_rooms.Insert(u,d,r,"Free");

            load_All();
        }

        private void btn_ShowAll_Click(object sender, EventArgs e)
        {
            load_All();
        }
        private void load_All()
        {
            List<cls_rooms> romi = cls_rooms.GetRooms_records();

            listView1.Items.Clear();

            foreach (cls_rooms u in romi)
            {

                ListViewItem item = new ListViewItem(new String[] { u.Id.ToString(), u.Name, u.Descri,u.Rate.ToString(),u.Status });
                item.Tag = u;

                listView1.Items.Add(item);

            }
        }

        private void btn_comeback_Click(object sender, EventArgs e)
        {
            frm_menu fm = new frm_menu();
            fm.Show();
            this.Hide();
        }

        private void frm_rooms_Load(object sender, EventArgs e)
        {

        }
    }
}
