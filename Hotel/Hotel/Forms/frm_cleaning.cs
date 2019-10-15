using Hotel.Class;
using MySql.Data.MySqlClient;
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
    public partial class frm_cleaning : Form
    {
        private cls_connection cls_con;
        private cls_rooms cls_room;
        int get_id;
        public frm_cleaning(string d1)
        {
            Get_id =Int32.Parse(d1);
            InitializeComponent();
            cls_connection.InitializeDB();
            load_data(d1);

            this.BackgroundImage = Properties.Resources.p6;
        }

        public int Get_id { get => get_id; set => get_id = value; }

        private void btn_Updatey_Click(object sender, EventArgs e)
        {
            String n = textBox1.Text;
            String d = textBox2.Text;
            String r = textBox3.Text;
            String s = comboBox1.Text;
            
            String query = string.Format("UPDATE rooms SET name='{0}', description='{1}', rate='{2}', status='{3}' WHERE ID_r={4}", n, d, r, s, Get_id.ToString());

            MySqlCommand cmd = new MySqlCommand(query, cls_connection.Connection);
            cls_connection.Connection.Open();
            cmd.ExecuteNonQuery();
            cls_connection.Connection.Close();

            frm_reservation frm = new frm_reservation();
            frm.Show();
            this.Hide();



        }

        private void load_data(string last_ids)
        {
            string sb = last_ids;
            cls_connection.InitializeDB();
            string querys = "SELECT * FROM rooms";
            //for the datatable
            MySqlCommand cmd = new MySqlCommand(querys, cls_connection.Connection);
            cls_connection.Connection.Open();
            var cmds = new MySqlCommand(querys, cls_connection.Connection);
            DataTable dt = new DataTable();
            dt.Load(cmds.ExecuteReader());


            int it = Int32.Parse(sb);

            textBox1.Text = dt.Rows[it - 1][1].ToString();
            textBox2.Text = dt.Rows[it - 1][2].ToString();
            textBox3.Text = dt.Rows[it - 1][3].ToString();
            comboBox1.Text= dt.Rows[it - 1][4].ToString();
            //rate = float.Parse(dt.Rows[it - 1][3].ToString());
            cls_connection.Connection.Close();
        }

        private void btn_comeback_Click(object sender, EventArgs e)
        {
            frm_reservation frm = new frm_reservation();
            frm.Show();
            this.Hide();
        }
    }
}
