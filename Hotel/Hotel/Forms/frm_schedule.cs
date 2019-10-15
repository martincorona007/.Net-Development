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
    public partial class frm_schedule : Form
    {
        private cls_connection cls_con;
        private cls_rooms cls_room;
        string todayDate;
       
        string last_ids;
        
        public string Last_ids { get => last_ids; set => last_ids = value; }

        public frm_schedule(String li)
        {
            InitializeComponent();
            cls_connection.InitializeDB();
            this.BackgroundImage = Properties.Resources.p4;
            todayDate = DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss");
            txt_date1.Text = todayDate;
            last_ids = li;
            load_dataGiven(last_ids);

        }

        private void load_dataGiven(string last_ids)
        {
            cls_connection.InitializeDB();
            string querys = "SELECT * FROM rooms";
            //for the datatable
            MySqlCommand cmd = new MySqlCommand(querys, cls_connection.Connection);
            cls_connection.Connection.Open();
            var cmds = new MySqlCommand(querys, cls_connection.Connection);
            DataTable dt = new DataTable();
            dt.Load(cmds.ExecuteReader());
            int it = Int32.Parse(last_ids);

            txt_name.Text = dt.Rows[it-1][1].ToString();
            txt_rate.Text = dt.Rows[it-1][3].ToString();
            cls_connection.Connection.Close();

        }

       /* private void monthCalendar2_DateSelected(object sender, DateRangeEventArgs e)
        {
            
            
            endDate= txt_date2.Text = monthCalendar2.SelectionStart.Year.ToString() + "-" + monthCalendar2.SelectionStart.Month.ToString() + "-" + monthCalendar2.SelectionStart.Day.ToString();
            */
            /*    DateTime t1 = monthCalendar1.SelectionEnd;
                DateTime t2 = monthCalendar2.SelectionEnd;
                TimeSpan difer = t1 - t2;
                int d = difer.Days;
                
                d *= -1;
                d += 1;
                fina_rate = d * rate;
                
                textBox1.Text = fina_rate.ToString();
                
              */  


            
       // }
        /*
        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            endDate = txt_date1.Text = monthCalendar1.SelectionStart.Month.ToString() + "/" + monthCalendar1.SelectionStart.Day.ToString() + "/" + monthCalendar1.SelectionStart.Year.ToString();
            if (DateTime.Parse(endDate) < DateTime.Parse(todayDate))
            {

                lbl_statusA.Text = "The date must be greater than the actual date";
                txt_date1.Text = "";
            }
            else
            {
                lbl_statusA.Text = "";
            }
        }*/


        private void frm_schedule_Load(object sender, EventArgs e)
        {

        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            frm_reservation fr = new frm_reservation();
            fr.Show();
            this.Hide();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void lbl_statusA_Click(object sender, EventArgs e)
        {

        }

        private void btn_Reserve_Click(object sender, EventArgs e)
        {
                optionA();
            
        }
        private void optionA()
        {
            String querya = string.Format("INSERT INTO reserve(FK_ID_r,start_date) VALUES ('{0}', '{1}')", last_ids, todayDate);

            /*
            String querya = string.Format("UPDATE rooms SET status='{0}' WHERE ID_r={1}", s, last_ids);
            */
            MySqlCommand cmd = new MySqlCommand(querya, cls_connection.Connection);
            cls_connection.Connection.Open();
                cmd.ExecuteNonQuery();
            cls_connection.Connection.Close();

            string s = "Busy";
            String query = string.Format("UPDATE rooms SET status='{0}' WHERE ID_r={1}", s, last_ids);
            MySqlCommand cmd1 = new MySqlCommand(query, cls_connection.Connection);
            cls_connection.Connection.Open();
            cmd1.ExecuteNonQuery();
            cls_connection.Connection.Close();

            // cls_reserv.Insert_reservation(last_ids, todayDate);
            frm_reservation fr = new frm_reservation();
            fr.Show();
            this.Hide();
        }
        

        
    }
}
