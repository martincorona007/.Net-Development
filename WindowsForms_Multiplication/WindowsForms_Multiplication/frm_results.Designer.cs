namespace WindowsForms_Multiplication
{
    partial class frm_results
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
            this.dGV_results = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_results)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Results";
            // 
            // dGV_results
            // 
            this.dGV_results.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_results.Location = new System.Drawing.Point(22, 54);
            this.dGV_results.Name = "dGV_results";
            this.dGV_results.Size = new System.Drawing.Size(240, 150);
            this.dGV_results.TabIndex = 1;
            this.dGV_results.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_results_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(187, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_results
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 266);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dGV_results);
            this.Controls.Add(this.label1);
            this.Name = "frm_results";
            this.Text = "frm_results";
            this.Load += new System.EventHandler(this.frm_results_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_results)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dGV_results;
        private System.Windows.Forms.Button button1;
    }
}