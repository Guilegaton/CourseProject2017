namespace CourseProject2017
{
    partial class AddOrder
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
            this.TimePCK = new System.Windows.Forms.DateTimePicker();
            this.AddBTN = new System.Windows.Forms.Button();
            this.DishNameLB = new System.Windows.Forms.Label();
            this.ChefLB = new System.Windows.Forms.Label();
            this.TimeLB = new System.Windows.Forms.Label();
            this.ChefCB = new System.Windows.Forms.ComboBox();
            this.DishNameCB = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // TimePCK
            // 
            this.TimePCK.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.TimePCK.Location = new System.Drawing.Point(110, 126);
            this.TimePCK.Name = "TimePCK";
            this.TimePCK.Size = new System.Drawing.Size(168, 20);
            this.TimePCK.TabIndex = 0;
            // 
            // AddBTN
            // 
            this.AddBTN.Location = new System.Drawing.Point(15, 193);
            this.AddBTN.Name = "AddBTN";
            this.AddBTN.Size = new System.Drawing.Size(75, 23);
            this.AddBTN.TabIndex = 3;
            this.AddBTN.Text = "Add";
            this.AddBTN.UseVisualStyleBackColor = true;
            this.AddBTN.Click += new System.EventHandler(this.AddBTN_Click);
            // 
            // DishNameLB
            // 
            this.DishNameLB.AutoSize = true;
            this.DishNameLB.Location = new System.Drawing.Point(12, 60);
            this.DishNameLB.Name = "DishNameLB";
            this.DishNameLB.Size = new System.Drawing.Size(57, 13);
            this.DishNameLB.TabIndex = 4;
            this.DishNameLB.Text = "Dish name";
            // 
            // ChefLB
            // 
            this.ChefLB.AutoSize = true;
            this.ChefLB.Location = new System.Drawing.Point(12, 91);
            this.ChefLB.Name = "ChefLB";
            this.ChefLB.Size = new System.Drawing.Size(16, 13);
            this.ChefLB.TabIndex = 5;
            this.ChefLB.Text = "Id";
            // 
            // TimeLB
            // 
            this.TimeLB.AutoSize = true;
            this.TimeLB.Location = new System.Drawing.Point(12, 126);
            this.TimeLB.Name = "TimeLB";
            this.TimeLB.Size = new System.Drawing.Size(30, 13);
            this.TimeLB.TabIndex = 6;
            this.TimeLB.Text = "Time";
            // 
            // ChefCB
            // 
            this.ChefCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ChefCB.FormattingEnabled = true;
            this.ChefCB.Location = new System.Drawing.Point(110, 82);
            this.ChefCB.Name = "ChefCB";
            this.ChefCB.Size = new System.Drawing.Size(168, 21);
            this.ChefCB.TabIndex = 9;
            // 
            // DishNameCB
            // 
            this.DishNameCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DishNameCB.FormattingEnabled = true;
            this.DishNameCB.Location = new System.Drawing.Point(110, 51);
            this.DishNameCB.Name = "DishNameCB";
            this.DishNameCB.Size = new System.Drawing.Size(168, 21);
            this.DishNameCB.TabIndex = 10;
            // 
            // AddOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 236);
            this.Controls.Add(this.DishNameCB);
            this.Controls.Add(this.ChefCB);
            this.Controls.Add(this.TimeLB);
            this.Controls.Add(this.ChefLB);
            this.Controls.Add(this.DishNameLB);
            this.Controls.Add(this.AddBTN);
            this.Controls.Add(this.TimePCK);
            this.MaximumSize = new System.Drawing.Size(306, 274);
            this.MinimumSize = new System.Drawing.Size(306, 274);
            this.Name = "AddOrder";
            this.Text = "Order";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker TimePCK;
        private System.Windows.Forms.Button AddBTN;
        private System.Windows.Forms.Label DishNameLB;
        private System.Windows.Forms.Label ChefLB;
        private System.Windows.Forms.Label TimeLB;
        private System.Windows.Forms.ComboBox ChefCB;
        private System.Windows.Forms.ComboBox DishNameCB;
    }
}