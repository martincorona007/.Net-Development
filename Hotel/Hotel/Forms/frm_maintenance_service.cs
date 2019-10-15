using Hotel.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel.Forms
{
    public partial class frm_maintenance_service : Form
    {
        private cls_connection cls_con;
        private cls_rooms cls_room;
        int get_id;
        DataTable dt = new DataTable();
        public frm_maintenance_service()
        {
            InitializeComponent();
            cls_connection.InitializeDB();
            this.BackgroundImage = Properties.Resources.p5;

        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            load_All();
        }
        private void load_All()
        {
            List<cls_rooms> romi = cls_rooms.GetRooms_records();

            listView_rooms.Items.Clear();

            foreach (cls_rooms u in romi)
            {

                ListViewItem item = new ListViewItem(new String[] { u.Id.ToString(), u.Name, u.Descri, u.Rate.ToString(), u.Status });
                item.Tag = u;

                listView_rooms.Items.Add(item);

            }

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView_rooms.SelectedItems.Count > 0)
            {
                ListViewItem item = listView_rooms.SelectedItems[0];
                 cls_room = (cls_rooms)item.Tag;

                get_id = cls_room.Id;
                
                String n = cls_room.Name;
                String d = cls_room.Descri;
                float r = cls_room.Rate;
                String s = cls_room.Status;

                textBox1.Text = n;
                textBox2.Text = d;
                textBox3.Text = r.ToString();
                comboBox1.Text = s;
               
            }
        }

        private void btn_Updatey_Click(object sender, EventArgs e)
        {
           
            String n = textBox1.Text;
            String d = textBox2.Text;
            String r = textBox3.Text;
            String s = comboBox1.Text;
            if (String.IsNullOrEmpty(n) || String.IsNullOrEmpty(d) || String.IsNullOrEmpty(r) || String.IsNullOrEmpty(s))
            {
                MessageBox.Show("It's empty");
                return;
            }

            cls_room.Update(n, d, r, s, get_id.ToString());

            load_All();
        }

        private void btn_comeback_Click(object sender, EventArgs e)
        {
            frm_menu fm = new frm_menu();
            fm.Show();
            this.Hide();
        }

        private void frm_maintenance_service_Load(object sender, EventArgs e)
        {
            
        }
    }
}
