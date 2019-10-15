using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel.Class
{

    
    public class cls_connection
    {
        //database stuff
        private const String SERVER = "localhost";
        private const String DATABASE = "db_hotel";
        private const String ID = "root";
        private const String PASSWORD = "123456";
        private static MySqlConnection dbConn;
        private cls_rooms rooms;
        
  

        public static void InitializeDB()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = SERVER;
            builder.UserID = ID;
            builder.Password = PASSWORD;
            builder.Database = DATABASE;

            String connString = builder.ToString();

            builder = null;

            Console.WriteLine(connString);

            dbConn = new MySqlConnection(connString);
            
            Application.ApplicationExit += (sender, args) =>
            {
                if (dbConn != null)
                {
                    dbConn.Dispose();
                    dbConn = null;
                }
            };
        }
        public static MySqlConnection Connection
        {
            get { return dbConn; }
        }












        /*
         * 
      CREATE DATABASE db_hotel;
use db_hotel;
CREATE TABLE rooms(
  ID_r INT PRIMARY KEY AUTO_INCREMENT NOT NULL,
  name VARCHAR(40) NOT NULL,
  description VARCHAR(80),
  rate FLOAT NOT NULL,
  status VARCHAR(30)
);

CREATE TABLE reserve(
  ID_reserve INT PRIMARY KEY AUTO_INCREMENT NOT NULL,
  FK_ID_r INT NOT NULL,
  start_date DATETIME NOT NULL,
  end_date DATETIME,
  final_rate FLOAT
);
ALTER TABLE reserve ADD CONSTRAINT FOREIGN KEY(FK_ID_r) REFERENCES rooms(ID_r);


INSERT INTO `rooms` (`ID_r`, `name`, `description`, `rate`,`status`) VALUES (1, 'Taylor Huels', 'Velit enim maxime ', '850','Cleaning');
INSERT INTO `rooms` (`ID_r`, `name`, `description`, `rate`,`status`) VALUES (2, 'Laney Durgan', 'Voluptatum dolores ', '850','Free');
INSERT INTO `rooms` (`ID_r`, `name`, `description`, `rate`,`status`) VALUES (3, 'Miss Treva McCullough', 'Vel amet excepturi aut.', '250','Maintenance');
INSERT INTO `rooms` (`ID_r`, `name`, `description`, `rate`,`status`) VALUES (4, 'Christy Wiegand', 'Tempora sit aut ipsa.', '450','Free');
INSERT INTO `rooms` (`ID_r`, `name`, `description`, `rate`,`status`) VALUES (5, 'Prof. Landen Pfeffer MD', 'Vel omnistio quisquam odit.', '350','Busy');
INSERT INTO `rooms` (`ID_r`, `name`, `description`, `rate`,`status`) VALUES (6, 'Olen Donnelly', 'Eum molestiam nihil eaque.', '268','Free');
INSERT INTO `rooms` (`ID_r`, `name`, `description`, `rate`,`status`) VALUES (7, 'Elwin Mann II', 'Occaecatiquod.', '1682','Maintenance');
INSERT INTO `rooms` (`ID_r`, `name`, `description`, `rate`,`status`) VALUES (8, 'Rebecca Connelly', 'Ipsam porerum.', '1500','Free');
INSERT INTO `rooms` (`ID_r`, `name`, `description`, `rate`,`status`) VALUES (9, 'Kristin Ondricka', 'Qui dolores si corporis.', '2500','Cleaning');
INSERT INTO `rooms` (`ID_r`, `name`, `description`, `rate`,`status`) VALUES (10, 'Rosalind Von', 'Id itaque culpa ut beatae. Qdolor.', '3093','Free');
INSERT INTO `rooms` (`ID_r`, `name`, `description`, `rate`,`status`) VALUES (11, 'Kay Bailey', 'Quia at nostrum voluptatibus bio.', '1501','Free');
INSERT INTO `rooms` (`ID_r`, `name`, `description`, `rate`,`status`) VALUES (12, 'Dr. Moriah Cronin II', 'Et possimus perspiciatis vusto.', '10139','Free');
INSERT INTO `rooms` (`ID_r`, `name`, `description`, `rate`,`status`) VALUES (13, 'Andreanne Schamberger II', 'Eum beatae nemo qui s ut.', '6254','Free');
INSERT INTO `rooms` (`ID_r`, `name`, `description`, `rate`,`status`) VALUES (14, 'Britney Jacobi', 'Repellendus fugiat utro.', '4459','Maintenance');
INSERT INTO `rooms` (`ID_r`, `name`, `description`, `rate`,`status`) VALUES (15, 'Jefferey Walter', 'Voluptas et repellat neca.', '2800','Free');
INSERT INTO `rooms` (`ID_r`, `name`, `description`, `rate`,`status`) VALUES (16, 'Ms. Albina Nader', 'Iusto dolorumo rerum e.', '5540','Free');
INSERT INTO `rooms` (`ID_r`, `name`, `description`, `rate`,`status`) VALUES (17, 'Everett Connelly', 'Quidem veli qui i.', '2946','Cleaning');
INSERT INTO `rooms` (`ID_r`, `name`, `description`, `rate`,`status`) VALUES (18, 'Finn Wiza', 'Voluptas sit voluptate i.', '4800','Free');
INSERT INTO `rooms` (`ID_r`, `name`, `description`, `rate`,`status`) VALUES (19, 'Kayleigh Okuneva', 'Consequatur sed ores.', '7310','Free');
INSERT INTO `rooms` (`ID_r`, `name`, `description`, `rate`,`status`) VALUES (20, 'Prof. Alaina Turcotte', 'Totam commodi animi ut eum.', '5246','Cleaning');

        conclusions
        DataSet do not support biggest amount of data
        And {Failed to enable constraints. One or more rows contain values violating non-null, unique, or foreign-key constraints}
            Error is for the database type of data(big) primary key ect.
         
        */
    }

    class class_conection
    {
    }
}
