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
    public partial class frm_menu : Form
    {
        public frm_menu()
        {
            InitializeComponent();
            this.BackgroundImage = Properties.Resources.p1;
        }

        private void frm_menu_Load(object sender, EventArgs e)
        {

        }

        private void btn_Insert_room_Click(object sender, EventArgs e)
        {
            frm_rooms fr = new frm_rooms();
            fr.Show();
            this.Hide();
        }

        private void btn_Maintenance_service_Click(object sender, EventArgs e)
        {
            frm_maintenance_service fm = new frm_maintenance_service();
            fm.Show();
            this.Hide();

        }

        private void btn_Reservation_Click(object sender, EventArgs e)
        {
            frm_reservation fr = new frm_reservation();
            fr.Show();
            this.Hide();
        }
    }
}
