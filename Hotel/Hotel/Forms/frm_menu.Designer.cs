namespace Hotel.Forms
{
    partial class frm_menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Reservation = new System.Windows.Forms.Button();
            this.btn_Insert_room = new System.Windows.Forms.Button();
            this.btn_Maintenance_service = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Reservation
            // 
            this.btn_Reservation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Reservation.Location = new System.Drawing.Point(67, 132);
            this.btn_Reservation.Name = "btn_Reservation";
            this.btn_Reservation.Size = new System.Drawing.Size(92, 35);
            this.btn_Reservation.TabIndex = 0;
            this.btn_Reservation.Text = "Reservation";
            this.btn_Reservation.UseVisualStyleBackColor = true;
            this.btn_Reservation.Click += new System.EventHandler(this.btn_Reservation_Click);
            // 
            // btn_Insert_room
            // 
            this.btn_Insert_room.Location = new System.Drawing.Point(208, 132);
            this.btn_Insert_room.Name = "btn_Insert_room";
            this.btn_Insert_room.Size = new System.Drawing.Size(118, 35);
            this.btn_Insert_room.TabIndex = 1;
            this.btn_Insert_room.Text = "Register Room";
            this.btn_Insert_room.UseVisualStyleBackColor = true;
            this.btn_Insert_room.Click += new System.EventHandler(this.btn_Insert_room_Click);
            // 
            // btn_Maintenance_service
            // 
            this.btn_Maintenance_service.Location = new System.Drawing.Point(358, 132);
            this.btn_Maintenance_service.Name = "btn_Maintenance_service";
            this.btn_Maintenance_service.Size = new System.Drawing.Size(137, 35);
            this.btn_Maintenance_service.TabIndex = 2;
            this.btn_Maintenance_service.Text = "Maintenance Service";
            this.btn_Maintenance_service.UseVisualStyleBackColor = true;
            this.btn_Maintenance_service.Click += new System.EventHandler(this.btn_Maintenance_service_Click);
            // 
            // frm_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(562, 292);
            this.Controls.Add(this.btn_Maintenance_service);
            this.Controls.Add(this.btn_Insert_room);
            this.Controls.Add(this.btn_Reservation);
            this.Name = "frm_menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_menu";
            this.Load += new System.EventHandler(this.frm_menu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Reservation;
        private System.Windows.Forms.Button btn_Insert_room;
        private System.Windows.Forms.Button btn_Maintenance_service;
    }
}