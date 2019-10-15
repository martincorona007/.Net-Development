using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel.Class
{
    class cls_rooms
    {

        private cls_connection cls_con;
        public int Id { get; private set; }
        public String Name { get; private set; }
        public String Descri { get; private set; }
        public float Rate { get; private set; }
        public String Status { get; private set; }
        Int32 t;
        
        private cls_rooms(int id, String name, String desrci,float rate,String s)
        {
            Id = id;
            Name = name;
            Descri = desrci;
            Rate = rate;
            Status = s;
        }
       


        public static List<cls_rooms> GetRooms_records()
        {
            List<cls_rooms> rooms = new List<cls_rooms>();

            String query = "SELECT * FROM rooms";

            MySqlCommand cmd = new MySqlCommand(query, cls_connection.Connection);

            
            cls_connection.Connection.Open();

            MySqlDataReader reader = cmd.ExecuteReader();
            
            while (reader.Read())
            {
                int id = (int)reader["ID_r"];
                String name = reader["name"].ToString();
                String des = reader["description"].ToString();
                float rate = (float)reader["rate"];
                String s = reader["status"].ToString();

                cls_rooms u = new cls_rooms(id, name, des,rate,s);

                rooms.Add(u);
            }

            reader.Close();
            
            cls_connection.Connection.Close();

            return rooms;
        }
        public static cls_rooms Insert( String n,string d,string r,string s)
        {
            String query = string.Format("INSERT INTO rooms(name,description, rate,status) VALUES ('{0}', '{1}','{2}','{3}')",n,d,r,s);

             MySqlCommand cmd = new MySqlCommand(query, cls_connection.Connection);

            cls_connection.Connection.Open();

            cmd.ExecuteNonQuery();
            int id = (int)cmd.LastInsertedId;
            float ra = float.Parse(r);

            cls_rooms user = new cls_rooms(id, n, d,ra,s);

            cls_connection.Connection.Close();

            return user;

        }
        
        public void Update(String n, string d, string r, string s,string id)
        {
            String query = string.Format("UPDATE rooms SET name='{0}', description='{1}', rate='{2}', status='{3}' WHERE ID_r={4}", n, d,r,s, id);

            MySqlCommand cmd = new MySqlCommand(query, cls_connection.Connection);

            cls_connection.Connection.Open();

            cmd.ExecuteNonQuery();

            cls_connection.Connection.Close();
        }
        

        public void Delete()
        {
            String query = string.Format("DELETE FROM users WHERE ID={0}", Id);

            MySqlCommand cmd = new MySqlCommand(query, cls_connection.Connection);

            cls_connection.Connection.Open();

           
            cls_connection.Connection.Close();
        }

        /*
        public int total_records()
        {
            String queryy = string.Format("SELECT COUNT(ID_r) FROM rooms");
            MySqlCommand cmd = new MySqlCommand(queryy, cls_connection.Connection);
            cls_connection.Connection.Open();
            t = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.ExecuteNonQuery();
            cls_connection.Connection.Close();
            return t;
        }*/

    }
}
