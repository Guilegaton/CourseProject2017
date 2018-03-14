namespace CourseProject2017.Forms
{
    partial class AddChek
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
            this.NoLB = new System.Windows.Forms.Label();
            this.OrderLB = new System.Windows.Forms.Label();
            this.CostLB = new System.Windows.Forms.Label();
            this.NoTB = new System.Windows.Forms.TextBox();
            this.CostTB = new System.Windows.Forms.TextBox();
            this.OrderCB = new System.Windows.Forms.ComboBox();
            this.AddOrderBTN = new System.Windows.Forms.Button();
            this.AddBTN = new System.Windows.Forms.Button();
            this.OrderListLB = new System.Windows.Forms.Label();
            this.DeleteBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NoLB
            // 
            this.NoLB.AutoSize = true;
            this.NoLB.Location = new System.Drawing.Point(13, 43);
            this.NoLB.Name = "NoLB";
            this.NoLB.Size = new System.Drawing.Size(24, 13);
            this.NoLB.TabIndex = 0;
            this.NoLB.Text = "No.";
            // 
            // OrderLB
            // 
            this.OrderLB.AutoSize = true;
            this.OrderLB.Location = new System.Drawing.Point(12, 76);
            this.OrderLB.Name = "OrderLB";
            this.OrderLB.Size = new System.Drawing.Size(33, 13);
            this.OrderLB.TabIndex = 1;
            this.OrderLB.Text = "Order";
            // 
            // CostLB
            // 
            this.CostLB.AutoSize = true;
            this.CostLB.Location = new System.Drawing.Point(13, 118);
            this.CostLB.Name = "CostLB";
            this.CostLB.Size = new System.Drawing.Size(54, 13);
            this.CostLB.TabIndex = 2;
            this.CostLB.Text = "Total cost";
            // 
            // NoTB
            // 
            this.NoTB.Location = new System.Drawing.Point(99, 35);
            this.NoTB.Name = "NoTB";
            this.NoTB.ReadOnly = true;
            this.NoTB.Size = new System.Drawing.Size(100, 20);
            this.NoTB.TabIndex = 3;
            // 
            // CostTB
            // 
            this.CostTB.Location = new System.Drawing.Point(99, 111);
            this.CostTB.Name = "CostTB";
            this.CostTB.ReadOnly = true;
            this.CostTB.Size = new System.Drawing.Size(100, 20);
            this.CostTB.TabIndex = 4;
            this.CostTB.Text = "0";
            // 
            // OrderCB
            // 
            this.OrderCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OrderCB.FormattingEnabled = true;
            this.OrderCB.Location = new System.Drawing.Point(99, 76);
            this.OrderCB.Name = "OrderCB";
            this.OrderCB.Size = new System.Drawing.Size(100, 21);
            this.OrderCB.TabIndex = 5;
            // 
            // AddOrderBTN
            // 
            this.AddOrderBTN.Location = new System.Drawing.Point(205, 76);
            this.AddOrderBTN.Name = "AddOrderBTN";
            this.AddOrderBTN.Size = new System.Drawing.Size(75, 23);
            this.AddOrderBTN.TabIndex = 6;
            this.AddOrderBTN.Text = "Add order";
            this.AddOrderBTN.UseVisualStyleBackColor = true;
            this.AddOrderBTN.Click += new System.EventHandler(this.AddOrderBTN_Click);
            // 
            // AddBTN
            // 
            this.AddBTN.Location = new System.Drawing.Point(99, 227);
            this.AddBTN.Name = "AddBTN";
            this.AddBTN.Size = new System.Drawing.Size(75, 23);
            this.AddBTN.TabIndex = 7;
            this.AddBTN.Text = "Add";
            this.AddBTN.UseVisualStyleBackColor = true;
            this.AddBTN.Click += new System.EventHandler(this.AddBTN_Click);
            // 
            // OrderListLB
            // 
            this.OrderListLB.AutoSize = true;
            this.OrderListLB.Location = new System.Drawing.Point(13, 164);
            this.OrderListLB.Name = "OrderListLB";
            this.OrderListLB.Size = new System.Drawing.Size(0, 13);
            this.OrderListLB.TabIndex = 8;
            // 
            // DeleteBTN
            // 
            this.DeleteBTN.Location = new System.Drawing.Point(205, 108);
            this.DeleteBTN.Name = "DeleteBTN";
            this.DeleteBTN.Size = new System.Drawing.Size(75, 36);
            this.DeleteBTN.TabIndex = 9;
            this.DeleteBTN.Text = "Delete last order";
            this.DeleteBTN.UseVisualStyleBackColor = true;
            this.DeleteBTN.Click += new System.EventHandler(this.DeleteBTN_Click);
            // 
            // AddChek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.DeleteBTN);
            this.Controls.Add(this.OrderListLB);
            this.Controls.Add(this.AddBTN);
            this.Controls.Add(this.AddOrderBTN);
            this.Controls.Add(this.OrderCB);
            this.Controls.Add(this.CostTB);
            this.Controls.Add(this.NoTB);
            this.Controls.Add(this.CostLB);
            this.Controls.Add(this.OrderLB);
            this.Controls.Add(this.NoLB);
            this.MaximumSize = new System.Drawing.Size(300, 300);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "AddChek";
            this.Text = "Chek";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NoLB;
        private System.Windows.Forms.Label OrderLB;
        private System.Windows.Forms.Label CostLB;
        private System.Windows.Forms.TextBox NoTB;
        private System.Windows.Forms.TextBox CostTB;
        private System.Windows.Forms.ComboBox OrderCB;
        private System.Windows.Forms.Button AddOrderBTN;
        private System.Windows.Forms.Button AddBTN;
        private System.Windows.Forms.Label OrderListLB;
        private System.Windows.Forms.Button DeleteBTN;
    }
}