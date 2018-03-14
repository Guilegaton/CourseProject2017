namespace CourseProject2017.Forms
{
    partial class AddMenuPoint
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
            this.DishNameLB = new System.Windows.Forms.Label();
            this.ReceprionLb = new System.Windows.Forms.Label();
            this.CostLB = new System.Windows.Forms.Label();
            this.WTimeLB = new System.Windows.Forms.Label();
            this.DishNameTB = new System.Windows.Forms.TextBox();
            this.CostTB = new System.Windows.Forms.TextBox();
            this.WTimeTB = new System.Windows.Forms.TextBox();
            this.ReceptionCB = new System.Windows.Forms.ComboBox();
            this.AddBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DishNameLB
            // 
            this.DishNameLB.AutoSize = true;
            this.DishNameLB.Location = new System.Drawing.Point(13, 43);
            this.DishNameLB.Name = "DishNameLB";
            this.DishNameLB.Size = new System.Drawing.Size(68, 13);
            this.DishNameLB.TabIndex = 0;
            this.DishNameLB.Text = "Dishes name";
            // 
            // ReceprionLb
            // 
            this.ReceprionLb.AutoSize = true;
            this.ReceprionLb.Location = new System.Drawing.Point(13, 69);
            this.ReceprionLb.Name = "ReceprionLb";
            this.ReceprionLb.Size = new System.Drawing.Size(73, 13);
            this.ReceprionLb.TabIndex = 1;
            this.ReceprionLb.Text = "Reception No";
            // 
            // CostLB
            // 
            this.CostLB.AutoSize = true;
            this.CostLB.Location = new System.Drawing.Point(13, 97);
            this.CostLB.Name = "CostLB";
            this.CostLB.Size = new System.Drawing.Size(28, 13);
            this.CostLB.TabIndex = 2;
            this.CostLB.Text = "Cost";
            // 
            // WTimeLB
            // 
            this.WTimeLB.AutoSize = true;
            this.WTimeLB.Location = new System.Drawing.Point(13, 123);
            this.WTimeLB.Name = "WTimeLB";
            this.WTimeLB.Size = new System.Drawing.Size(65, 13);
            this.WTimeLB.TabIndex = 3;
            this.WTimeLB.Text = "Waiting time";
            // 
            // DishNameTB
            // 
            this.DishNameTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DishNameTB.Location = new System.Drawing.Point(88, 43);
            this.DishNameTB.Name = "DishNameTB";
            this.DishNameTB.Size = new System.Drawing.Size(100, 20);
            this.DishNameTB.TabIndex = 4;
            // 
            // CostTB
            // 
            this.CostTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CostTB.Location = new System.Drawing.Point(88, 97);
            this.CostTB.Name = "CostTB";
            this.CostTB.Size = new System.Drawing.Size(100, 20);
            this.CostTB.TabIndex = 5;
            // 
            // WTimeTB
            // 
            this.WTimeTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WTimeTB.Location = new System.Drawing.Point(88, 124);
            this.WTimeTB.Name = "WTimeTB";
            this.WTimeTB.Size = new System.Drawing.Size(100, 20);
            this.WTimeTB.TabIndex = 6;
            // 
            // ReceptionCB
            // 
            this.ReceptionCB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ReceptionCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ReceptionCB.FormattingEnabled = true;
            this.ReceptionCB.Location = new System.Drawing.Point(88, 69);
            this.ReceptionCB.Name = "ReceptionCB";
            this.ReceptionCB.Size = new System.Drawing.Size(100, 21);
            this.ReceptionCB.TabIndex = 7;
            // 
            // AddBTN
            // 
            this.AddBTN.Location = new System.Drawing.Point(63, 180);
            this.AddBTN.Name = "AddBTN";
            this.AddBTN.Size = new System.Drawing.Size(75, 23);
            this.AddBTN.TabIndex = 8;
            this.AddBTN.Text = "Add";
            this.AddBTN.UseVisualStyleBackColor = true;
            this.AddBTN.Click += new System.EventHandler(this.AddBTN_Click);
            // 
            // AddMenuPoint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(211, 215);
            this.Controls.Add(this.AddBTN);
            this.Controls.Add(this.ReceptionCB);
            this.Controls.Add(this.WTimeTB);
            this.Controls.Add(this.CostTB);
            this.Controls.Add(this.DishNameTB);
            this.Controls.Add(this.WTimeLB);
            this.Controls.Add(this.CostLB);
            this.Controls.Add(this.ReceprionLb);
            this.Controls.Add(this.DishNameLB);
            this.MaximumSize = new System.Drawing.Size(1000, 253);
            this.MinimumSize = new System.Drawing.Size(227, 253);
            this.Name = "AddMenuPoint";
            this.Text = "Dishes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DishNameLB;
        private System.Windows.Forms.Label ReceprionLb;
        private System.Windows.Forms.Label CostLB;
        private System.Windows.Forms.Label WTimeLB;
        private System.Windows.Forms.TextBox DishNameTB;
        private System.Windows.Forms.TextBox CostTB;
        private System.Windows.Forms.TextBox WTimeTB;
        private System.Windows.Forms.ComboBox ReceptionCB;
        private System.Windows.Forms.Button AddBTN;
    }
}