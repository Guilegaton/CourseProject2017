namespace CourseProject2017.Forms
{
    partial class AddChef
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
            this.NameLB = new System.Windows.Forms.Label();
            this.SurnameLB = new System.Windows.Forms.Label();
            this.SalaryLB = new System.Windows.Forms.Label();
            this.BirthdayLB = new System.Windows.Forms.Label();
            this.PozitionLB = new System.Windows.Forms.Label();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.SurnameTB = new System.Windows.Forms.TextBox();
            this.SalaryTB = new System.Windows.Forms.TextBox();
            this.PozitionTB = new System.Windows.Forms.TextBox();
            this.BirthdayTP = new System.Windows.Forms.DateTimePicker();
            this.AddBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameLB
            // 
            this.NameLB.AutoSize = true;
            this.NameLB.Location = new System.Drawing.Point(13, 49);
            this.NameLB.Name = "NameLB";
            this.NameLB.Size = new System.Drawing.Size(35, 13);
            this.NameLB.TabIndex = 0;
            this.NameLB.Text = "Name";
            // 
            // SurnameLB
            // 
            this.SurnameLB.AutoSize = true;
            this.SurnameLB.Location = new System.Drawing.Point(12, 76);
            this.SurnameLB.Name = "SurnameLB";
            this.SurnameLB.Size = new System.Drawing.Size(49, 13);
            this.SurnameLB.TabIndex = 1;
            this.SurnameLB.Text = "Surname";
            // 
            // SalaryLB
            // 
            this.SalaryLB.AutoSize = true;
            this.SalaryLB.Location = new System.Drawing.Point(12, 107);
            this.SalaryLB.Name = "SalaryLB";
            this.SalaryLB.Size = new System.Drawing.Size(36, 13);
            this.SalaryLB.TabIndex = 2;
            this.SalaryLB.Text = "Salary";
            // 
            // BirthdayLB
            // 
            this.BirthdayLB.AutoSize = true;
            this.BirthdayLB.Location = new System.Drawing.Point(13, 136);
            this.BirthdayLB.Name = "BirthdayLB";
            this.BirthdayLB.Size = new System.Drawing.Size(45, 13);
            this.BirthdayLB.TabIndex = 3;
            this.BirthdayLB.Text = "Birthday";
            // 
            // PozitionLB
            // 
            this.PozitionLB.AutoSize = true;
            this.PozitionLB.Location = new System.Drawing.Point(13, 165);
            this.PozitionLB.Name = "PozitionLB";
            this.PozitionLB.Size = new System.Drawing.Size(73, 13);
            this.PozitionLB.TabIndex = 4;
            this.PozitionLB.Text = "Pozition name";
            // 
            // NameTB
            // 
            this.NameTB.Location = new System.Drawing.Point(92, 50);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(100, 20);
            this.NameTB.TabIndex = 5;
            // 
            // SurnameTB
            // 
            this.SurnameTB.Location = new System.Drawing.Point(92, 76);
            this.SurnameTB.Name = "SurnameTB";
            this.SurnameTB.Size = new System.Drawing.Size(100, 20);
            this.SurnameTB.TabIndex = 6;
            // 
            // SalaryTB
            // 
            this.SalaryTB.Location = new System.Drawing.Point(92, 100);
            this.SalaryTB.Name = "SalaryTB";
            this.SalaryTB.Size = new System.Drawing.Size(100, 20);
            this.SalaryTB.TabIndex = 7;
            // 
            // PozitionTB
            // 
            this.PozitionTB.Location = new System.Drawing.Point(92, 165);
            this.PozitionTB.Name = "PozitionTB";
            this.PozitionTB.Size = new System.Drawing.Size(100, 20);
            this.PozitionTB.TabIndex = 8;
            // 
            // BirthdayTP
            // 
            this.BirthdayTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.BirthdayTP.Location = new System.Drawing.Point(92, 130);
            this.BirthdayTP.Name = "BirthdayTP";
            this.BirthdayTP.Size = new System.Drawing.Size(100, 20);
            this.BirthdayTP.TabIndex = 9;
            // 
            // AddBTN
            // 
            this.AddBTN.Location = new System.Drawing.Point(58, 231);
            this.AddBTN.Name = "AddBTN";
            this.AddBTN.Size = new System.Drawing.Size(75, 23);
            this.AddBTN.TabIndex = 10;
            this.AddBTN.Text = "Add";
            this.AddBTN.UseVisualStyleBackColor = true;
            this.AddBTN.Click += new System.EventHandler(this.AddBTN_Click);
            // 
            // AddChef
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(203, 266);
            this.Controls.Add(this.AddBTN);
            this.Controls.Add(this.BirthdayTP);
            this.Controls.Add(this.PozitionTB);
            this.Controls.Add(this.SalaryTB);
            this.Controls.Add(this.SurnameTB);
            this.Controls.Add(this.NameTB);
            this.Controls.Add(this.PozitionLB);
            this.Controls.Add(this.BirthdayLB);
            this.Controls.Add(this.SalaryLB);
            this.Controls.Add(this.SurnameLB);
            this.Controls.Add(this.NameLB);
            this.MaximumSize = new System.Drawing.Size(219, 304);
            this.MinimumSize = new System.Drawing.Size(219, 304);
            this.Name = "AddChef";
            this.Text = "Chef";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLB;
        private System.Windows.Forms.Label SurnameLB;
        private System.Windows.Forms.Label SalaryLB;
        private System.Windows.Forms.Label BirthdayLB;
        private System.Windows.Forms.Label PozitionLB;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.TextBox SurnameTB;
        private System.Windows.Forms.TextBox SalaryTB;
        private System.Windows.Forms.TextBox PozitionTB;
        private System.Windows.Forms.DateTimePicker BirthdayTP;
        private System.Windows.Forms.Button AddBTN;
    }
}