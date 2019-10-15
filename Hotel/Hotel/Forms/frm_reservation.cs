using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

using Hotel.Class;
using System.Data.OleDb;
using MySql.Data.MySqlClient;

namespace Hotel.Forms
{
    public partial class frm_reservation : Form
    {
        private cls_connection cls_con;
        private cls_rooms cls_room;
        Color statusColor = Color.Gray;
        Button[] button = new Button[81];
        ToolTip[] toltip = new ToolTip[81];
        string name_color;
        string last_id;

        public frm_reservation()
        {
            InitializeComponent();
            
            cls_connection.InitializeDB();
            create_buttons();
            this.BackgroundImage = Properties.Resources.p3;
            
        }

        private void frm_reservation_Load(object sender, EventArgs e)
        {

        }
        //DINAMIC BUTTON
        public void create_buttons()
        {
            //cls_con.conectar();

            string querys = "SELECT * FROM rooms";
            int x = 50;
            int y = 50;
            int cta = 0;
            
            //for the datatable
            MySqlCommand cmd = new MySqlCommand(querys, cls_connection.Connection);
            cls_connection.Connection.Open();
            var cmds = new MySqlCommand(querys, cls_connection.Connection);
            DataTable dt = new DataTable();
            dt.Load(cmds.ExecuteReader());

            for (int pos = 0; pos < dt.Rows.Count; pos++)
            {
                button[pos] = new Button();
                button[pos].Name = dt.Rows[pos][0].ToString();//id
                button[pos].Text = dt.Rows[pos][1].ToString();//name
                button[pos].Height = 80;
                button[pos].Width = 80;

                switch (dt.Rows[pos][4].ToString())
                {
                    case "Free":
                        statusColor = Color.LightGreen;
                        break;
                    case "Busy":
                        statusColor = Color.LightBlue;
                        break;
                    case "Cleaning":
                        statusColor = Color.LightYellow;
                        break;
                    case "Maintenance":
                        statusColor = Color.DarkOrange;
                        break;

                }
                button[pos].BackColor = statusColor;
                toltip[pos] = new System.Windows.Forms.ToolTip();
                toltip[pos].SetToolTip(button[pos], dt.Rows[pos][2].ToString());

                if (pos % 6 == 0 && cta != 0)
                {
                    x = 50;
                    y = y + 85;
                    cta = 0;
                }
                Console.WriteLine("++"+y+"++"+(x+(cta*90))+"++");
                button[pos].Location = new Point(x + (cta * 170), y);
                cta++;
                button[pos].Click += new EventHandler(this.press_theButton_Click);
                this.Controls.Add(button[pos]);
                Console.WriteLine(pos);

            }
            

            

            cls_connection.Connection.Close();

            /*for (int pos = 0; pos < cls_room.total_records(); pos++)
            {
                butttons[pos] = new Button();
            }*/
        }

        private void press_theButton_Click(object sender, EventArgs e)
        {/*
            Button boton_press = (Button)sender;
            boton_press.BackColor=*/
            

            Button boton_press = (Button)sender;
            Console.WriteLine(boton_press.Name);
            last_id = boton_press.Name;
            Console.WriteLine(boton_press.Text);
            name_color = boton_press.BackColor.ToString();
            //Console.WriteLine(name_color);

            if (name_color == "Color [LightGreen]")
            {
                frm_schedule sc = new frm_schedule(boton_press.Name);//boton_press.Name Last ID from rooms data base
                sc.Show();
                this.Hide();

            }
            if (name_color == "Color [LightBlue]")
            {
                frm_payment scc = new frm_payment(boton_press.Name, boton_press.Name);
                scc.Show();
                this.Hide();

            }
            if (name_color == "Color [LightYellow]")
            {
                frm_cleaning cl = new frm_cleaning(boton_press.Name);
                cl.Show();
                this.Hide();
            }
            if (name_color == "Color [DarkOrange]") 
            {
                frm_maintenance clr = new frm_maintenance(boton_press.Name);
                clr.Show();
                this.Hide();
            }



        }
    }
}
