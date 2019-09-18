namespace WindowsForms_Multiplication
{
    partial class frm_operation
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dGV_Matrix_1 = new System.Windows.Forms.DataGridView();
            this.dGV_Matrix_2 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Matrix_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Matrix_2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matrix 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(384, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Matrix 2";
            // 
            // dGV_Matrix_1
            // 
            this.dGV_Matrix_1.AllowUserToAddRows = false;
            this.dGV_Matrix_1.AllowUserToDeleteRows = false;
            this.dGV_Matrix_1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Matrix_1.Location = new System.Drawing.Point(12, 68);
            this.dGV_Matrix_1.Name = "dGV_Matrix_1";
            this.dGV_Matrix_1.ReadOnly = true;
            this.dGV_Matrix_1.Size = new System.Drawing.Size(240, 150);
            this.dGV_Matrix_1.TabIndex = 2;
            // 
            // dGV_Matrix_2
            // 
            this.dGV_Matrix_2.AllowUserToAddRows = false;
            this.dGV_Matrix_2.AllowUserToDeleteRows = false;
            this.dGV_Matrix_2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Matrix_2.Location = new System.Drawing.Point(295, 68);
            this.dGV_Matrix_2.Name = "dGV_Matrix_2";
            this.dGV_Matrix_2.ReadOnly = true;
            this.dGV_Matrix_2.Size = new System.Drawing.Size(240, 150);
            this.dGV_Matrix_2.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(71, 271);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Sum";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(238, 271);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Substration";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(372, 271);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Multiplication";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // frm_operation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 326);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dGV_Matrix_2);
            this.Controls.Add(this.dGV_Matrix_1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_operation";
            this.Text = "frm_operation";
            this.Load += new System.EventHandler(this.frm_operation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Matrix_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Matrix_2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dGV_Matrix_1;
        private System.Windows.Forms.DataGridView dGV_Matrix_2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}