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
    public partial class frm_payment : Form
    {
        string id;
        string id2;
        string last_id_reservation;
        float rate, fina_rate;
        string aux1;
        string endDate,endDate1;
        public frm_payment(string t,string t1)
        {
            Id = t;
            Id2 = t1;
            cls_connection.InitializeDB();
            InitializeComponent();
            load_dataGiven2(t);
            load_dataGiven(t);
            
            endDate=DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss");
            txt_date2.Text = endDate;
            endDate1 = DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss");
            this.BackgroundImage = Properties.Resources.p6;
            method();
        }

        private void method()

        {
            // var yolo = txt_date1.Text - endDate;


            DateTime difer, differ;
            String k = txt_date1.Text;
            Console.WriteLine(k);
            difer = Convert.ToDateTime(endDate);
            differ=DateTime.Parse(txt_date2.Text);
            var d1= DateTime.Parse(txt_date1.Text);
            var d2= Convert.ToDateTime(endDate);
            Console.WriteLine(">"+d1);
            Console.WriteLine(">"+d2);
            double kk1 = d2.Subtract(d2).TotalDays;
           

            TimeSpan difer1 = d1-d2;
            
                        int d = difer1.Days;
            double kk = difer1.TotalDays;
            Console.WriteLine(d);
            Console.WriteLine(kk);
                        d *= -1;
                        d += 1;
                        rate = float.Parse(txt_rate.Text);
                        fina_rate = d * rate;

                        textBox1.Text = fina_rate.ToString();
                        
        }

        public string Id { get => id; set => id = value; }
        public string Id2 { get => id2; set => id2 = value; }
        public string Last_id_reservation { get => last_id_reservation; set => last_id_reservation = value; }

        private void btn_Reserve_Click(object sender, EventArgs e)
        {
            get_data();
        }

        private void get_data()
        {
            
            String querya = string.Format("UPDATE reserve SET end_date='{0}',final_rate='{1}' WHERE ID_reserve={2}", endDate1, textBox1.Text,Last_id_reservation);

            
            MySqlCommand cmd = new MySqlCommand(querya, cls_connection.Connection);
            cls_connection.Connection.Open();
            cmd.ExecuteNonQuery();
            cls_connection.Connection.Close();


            string s = "Cleaning";
            String query = string.Format("UPDATE rooms SET status='{0}' WHERE ID_r={1}", s,Id);
            MySqlCommand cmd1 = new MySqlCommand(query, cls_connection.Connection);
            cls_connection.Connection.Open();
            cmd1.ExecuteNonQuery();
            cls_connection.Connection.Close();
            frm_reservation fr = new frm_reservation();
            fr.Show();
            this.Hide();





        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            frm_reservation fr = new frm_reservation();
            fr.Show();
            this.Hide();
        }

        private void frm_payment_Load(object sender, EventArgs e)
        {

        }

        private void load_dataGiven(string last_ids)
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
            
            txt_name.Text = dt.Rows[it - 1][1].ToString();
            txt_rate.Text = dt.Rows[it - 1][3].ToString();
            rate = float.Parse(dt.Rows[it - 1][3].ToString());
            cls_connection.Connection.Close();
            /****************************/
            
            
            


        }
        private void load_dataGiven2(string t2)
        {
            string ts = t2;
            string aux;

          //  string query = "SELECT FK_ID_r,start_date FROM reserve WHERE ID_reserve={0}"  t2;
            String query = "SELECT * FROM reserve ";
          
            //for the datatable
            MySqlCommand cmd1 = new MySqlCommand(query, cls_connection.Connection);
            cls_connection.Connection.Open();
            var cmdss = new MySqlCommand(query, cls_connection.Connection);
            DataTable dtt = new DataTable();
            dtt.Load(cmdss.ExecuteReader());
            MySqlDataReader dataReader = cmd1.ExecuteReader();
            int count = 1;
            int count1 = 0;
            while (dataReader.Read())
            {

                if (count == 1)
                {
                    //Last_id_reservation= dataReader["ID_reserve"].ToString();
                    //Console.WriteLine("the last"+Last_id_reservation);
                    txt_date1.Text = dataReader["start_date"].ToString();
                    
                    //Console.WriteLine("opd"+dataReader["start_date"].ToString());
                  //  string Name = dataReader["Nama_Kategori"].ToString();
                }
                if (count1 == 0)
                {
                    Last_id_reservation = dataReader["ID_reserve"].ToString();
                   // Console.WriteLine("the last" + Last_id_reservation);
                    //txt_date1.Text = dataReader["start_date"].ToString();

                    //Console.WriteLine("opd" + dataReader["start_date"].ToString());
                    //  string Name = dataReader["Nama_Kategori"].ToString();
                }
               // count++;
            }
            //int itt = Int32.Parse(t2);
            //Console.WriteLine(itt);
            //Console.WriteLine(dtt.Rows);
            cls_connection.Connection.Close();
        }
    }
}
