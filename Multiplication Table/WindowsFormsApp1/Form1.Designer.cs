namespace WindowsFormsApp1
{
    partial class Form1
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
            this.btn_Acept = new System.Windows.Forms.Button();
            this.lbl_Number = new System.Windows.Forms.Label();
            this.listBo = new System.Windows.Forms.ListBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_Acept
            // 
            this.btn_Acept.Location = new System.Drawing.Point(166, 350);
            this.btn_Acept.Name = "btn_Acept";
            this.btn_Acept.Size = new System.Drawing.Size(75, 23);
            this.btn_Acept.TabIndex = 0;
            this.btn_Acept.Text = "Acept";
            this.btn_Acept.UseVisualStyleBackColor = true;
            this.btn_Acept.Click += new System.EventHandler(this.btn_Acept_Click);
            // 
            // lbl_Number
            // 
            this.lbl_Number.AutoSize = true;
            this.lbl_Number.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Number.Location = new System.Drawing.Point(12, 34);
            this.lbl_Number.Name = "lbl_Number";
            this.lbl_Number.Size = new System.Drawing.Size(118, 31);
            this.lbl_Number.TabIndex = 1;
            this.lbl_Number.Text = "Number:";
            this.lbl_Number.Click += new System.EventHandler(this.label1_Click);
            // 
            // listBo
            // 
            this.listBo.FormattingEnabled = true;
            this.listBo.Location = new System.Drawing.Point(18, 85);
            this.listBo.Name = "listBo";
            this.listBo.Size = new System.Drawing.Size(342, 238);
            this.listBo.TabIndex = 2;
            this.listBo.SelectedIndexChanged += new System.EventHandler(this.listBo_SelectedIndexChanged);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(265, 350);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(95, 21);
            this.btn_cancel.TabIndex = 4;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBox1.Location = new System.Drawing.Point(136, 44);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(224, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 393);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.listBo);
            this.Controls.Add(this.lbl_Number);
            this.Controls.Add(this.btn_Acept);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Acept;
        private System.Windows.Forms.Label lbl_Number;
        private System.Windows.Forms.ListBox listBo;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

