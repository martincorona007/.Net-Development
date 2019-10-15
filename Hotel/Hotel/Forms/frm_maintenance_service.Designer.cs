namespace Hotel.Forms
{
    partial class frm_maintenance_service
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
            this.listView_rooms = new System.Windows.Forms.ListView();
            this.clm_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clm_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clm_Des = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clm_Rate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clm_Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_LoadAll = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbstatus = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_Updatey = new System.Windows.Forms.Button();
            this.btn_comeback = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView_rooms
            // 
            this.listView_rooms.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clm_ID,
            this.clm_Name,
            this.clm_Des,
            this.clm_Rate,
            this.clm_Status});
            this.listView_rooms.HideSelection = false;
            this.listView_rooms.Location = new System.Drawing.Point(345, 6);
            this.listView_rooms.Name = "listView_rooms";
            this.listView_rooms.Size = new System.Drawing.Size(425, 342);
            this.listView_rooms.TabIndex = 13;
            this.listView_rooms.UseCompatibleStateImageBehavior = false;
            this.listView_rooms.View = System.Windows.Forms.View.Details;
            this.listView_rooms.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // clm_ID
            // 
            this.clm_ID.Text = "ID";
            // 
            // clm_Name
            // 
            this.clm_Name.Text = "Name";
            // 
            // clm_Des
            // 
            this.clm_Des.Text = "Description";
            // 
            // clm_Rate
            // 
            this.clm_Rate.Text = "Rate";
            // 
            // clm_Status
            // 
            this.clm_Status.Text = "Status";
            // 
            // btn_LoadAll
            // 
            this.btn_LoadAll.Location = new System.Drawing.Point(233, 264);
            this.btn_LoadAll.Name = "btn_LoadAll";
            this.btn_LoadAll.Size = new System.Drawing.Size(75, 23);
            this.btn_LoadAll.TabIndex = 14;
            this.btn_LoadAll.Text = "Load all";
            this.btn_LoadAll.UseVisualStyleBackColor = true;
            this.btn_LoadAll.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(104, 138);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(204, 20);
            this.textBox3.TabIndex = 20;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(104, 85);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(204, 20);
            this.textBox2.TabIndex = 19;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(104, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(204, 20);
            this.textBox1.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Rate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Name";
            // 
            // lbstatus
            // 
            this.lbstatus.AutoSize = true;
            this.lbstatus.Location = new System.Drawing.Point(29, 195);
            this.lbstatus.Name = "lbstatus";
            this.lbstatus.Size = new System.Drawing.Size(37, 13);
            this.lbstatus.TabIndex = 21;
            this.lbstatus.Text = "Status";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Free",
            "Busy",
            "Cleaning",
            "Maintenance"});
            this.comboBox1.Location = new System.Drawing.Point(104, 192);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(204, 21);
            this.comboBox1.TabIndex = 22;
            // 
            // btn_Updatey
            // 
            this.btn_Updatey.Location = new System.Drawing.Point(130, 264);
            this.btn_Updatey.Name = "btn_Updatey";
            this.btn_Updatey.Size = new System.Drawing.Size(75, 23);
            this.btn_Updatey.TabIndex = 23;
            this.btn_Updatey.Text = "Update";
            this.btn_Updatey.UseVisualStyleBackColor = true;
            this.btn_Updatey.Click += new System.EventHandler(this.btn_Updatey_Click);
            // 
            // btn_comeback
            // 
            this.btn_comeback.Location = new System.Drawing.Point(27, 264);
            this.btn_comeback.Name = "btn_comeback";
            this.btn_comeback.Size = new System.Drawing.Size(75, 23);
            this.btn_comeback.TabIndex = 24;
            this.btn_comeback.Text = "Back";
            this.btn_comeback.UseVisualStyleBackColor = true;
            this.btn_comeback.Click += new System.EventHandler(this.btn_comeback_Click);
            // 
            // frm_maintenance_service
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(782, 360);
            this.Controls.Add(this.btn_comeback);
            this.Controls.Add(this.btn_Updatey);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lbstatus);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_LoadAll);
            this.Controls.Add(this.listView_rooms);
            this.Name = "frm_maintenance_service";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_maintenance_service";
            this.Load += new System.EventHandler(this.frm_maintenance_service_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView_rooms;
        private System.Windows.Forms.ColumnHeader clm_ID;
        private System.Windows.Forms.ColumnHeader clm_Name;
        private System.Windows.Forms.ColumnHeader clm_Des;
        private System.Windows.Forms.ColumnHeader clm_Rate;
        private System.Windows.Forms.ColumnHeader clm_Status;
        private System.Windows.Forms.Button btn_LoadAll;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbstatus;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn_Updatey;
        private System.Windows.Forms.Button btn_comeback;
    }
}