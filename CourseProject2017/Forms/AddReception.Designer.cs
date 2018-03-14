namespace CourseProject2017.Forms
{
    partial class AddReception
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
            this.ProdIDLB = new System.Windows.Forms.Label();
            this.CountLB = new System.Windows.Forms.Label();
            this.NoTB = new System.Windows.Forms.TextBox();
            this.CountTB = new System.Windows.Forms.TextBox();
            this.ProdIDCB = new System.Windows.Forms.ComboBox();
            this.AddIngrBTN = new System.Windows.Forms.Button();
            this.AddBTN = new System.Windows.Forms.Button();
            this.IngrListLB = new System.Windows.Forms.Label();
            this.DeleteBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NoLB
            // 
            this.NoLB.AutoSize = true;
            this.NoLB.Location = new System.Drawing.Point(13, 67);
            this.NoLB.Name = "NoLB";
            this.NoLB.Size = new System.Drawing.Size(24, 13);
            this.NoLB.TabIndex = 0;
            this.NoLB.Text = "No.";
            // 
            // ProdIDLB
            // 
            this.ProdIDLB.AutoSize = true;
            this.ProdIDLB.Location = new System.Drawing.Point(13, 93);
            this.ProdIDLB.Name = "ProdIDLB";
            this.ProdIDLB.Size = new System.Drawing.Size(54, 13);
            this.ProdIDLB.TabIndex = 1;
            this.ProdIDLB.Text = "Ingredient";
            // 
            // CountLB
            // 
            this.CountLB.AutoSize = true;
            this.CountLB.Location = new System.Drawing.Point(12, 123);
            this.CountLB.Name = "CountLB";
            this.CountLB.Size = new System.Drawing.Size(68, 13);
            this.CountLB.TabIndex = 2;
            this.CountLB.Text = "Count (gr/ml)";
            // 
            // NoTB
            // 
            this.NoTB.Location = new System.Drawing.Point(88, 64);
            this.NoTB.Name = "NoTB";
            this.NoTB.ReadOnly = true;
            this.NoTB.Size = new System.Drawing.Size(100, 20);
            this.NoTB.TabIndex = 3;
            // 
            // CountTB
            // 
            this.CountTB.Location = new System.Drawing.Point(88, 120);
            this.CountTB.Name = "CountTB";
            this.CountTB.Size = new System.Drawing.Size(100, 20);
            this.CountTB.TabIndex = 5;
            // 
            // ProdIDCB
            // 
            this.ProdIDCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProdIDCB.FormattingEnabled = true;
            this.ProdIDCB.Location = new System.Drawing.Point(88, 93);
            this.ProdIDCB.Name = "ProdIDCB";
            this.ProdIDCB.Size = new System.Drawing.Size(100, 21);
            this.ProdIDCB.TabIndex = 6;
            // 
            // AddIngrBTN
            // 
            this.AddIngrBTN.Location = new System.Drawing.Point(227, 93);
            this.AddIngrBTN.Name = "AddIngrBTN";
            this.AddIngrBTN.Size = new System.Drawing.Size(85, 23);
            this.AddIngrBTN.TabIndex = 7;
            this.AddIngrBTN.Text = "Add Ingredient";
            this.AddIngrBTN.UseVisualStyleBackColor = true;
            this.AddIngrBTN.Click += new System.EventHandler(this.AddIngrBTN_Click);
            // 
            // AddBTN
            // 
            this.AddBTN.Location = new System.Drawing.Point(112, 166);
            this.AddBTN.Name = "AddBTN";
            this.AddBTN.Size = new System.Drawing.Size(85, 23);
            this.AddBTN.TabIndex = 8;
            this.AddBTN.Text = "Add reception";
            this.AddBTN.UseVisualStyleBackColor = true;
            this.AddBTN.Click += new System.EventHandler(this.AddBTN_Click);
            // 
            // IngrListLB
            // 
            this.IngrListLB.AutoSize = true;
            this.IngrListLB.Location = new System.Drawing.Point(13, 21);
            this.IngrListLB.Name = "IngrListLB";
            this.IngrListLB.Size = new System.Drawing.Size(0, 13);
            this.IngrListLB.TabIndex = 9;
            // 
            // DeleteBTN
            // 
            this.DeleteBTN.Location = new System.Drawing.Point(227, 123);
            this.DeleteBTN.Name = "DeleteBTN";
            this.DeleteBTN.Size = new System.Drawing.Size(85, 36);
            this.DeleteBTN.TabIndex = 10;
            this.DeleteBTN.Text = "Delete last ingredient";
            this.DeleteBTN.UseVisualStyleBackColor = true;
            this.DeleteBTN.Click += new System.EventHandler(this.DeleteBTN_Click);
            // 
            // AddReception
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 218);
            this.Controls.Add(this.DeleteBTN);
            this.Controls.Add(this.IngrListLB);
            this.Controls.Add(this.AddBTN);
            this.Controls.Add(this.AddIngrBTN);
            this.Controls.Add(this.ProdIDCB);
            this.Controls.Add(this.CountTB);
            this.Controls.Add(this.NoTB);
            this.Controls.Add(this.CountLB);
            this.Controls.Add(this.ProdIDLB);
            this.Controls.Add(this.NoLB);
            this.MaximumSize = new System.Drawing.Size(10000, 256);
            this.MinimumSize = new System.Drawing.Size(346, 256);
            this.Name = "AddReception";
            this.Text = "Reception";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NoLB;
        private System.Windows.Forms.Label ProdIDLB;
        private System.Windows.Forms.Label CountLB;
        private System.Windows.Forms.TextBox NoTB;
        private System.Windows.Forms.TextBox CountTB;
        private System.Windows.Forms.ComboBox ProdIDCB;
        private System.Windows.Forms.Button AddIngrBTN;
        private System.Windows.Forms.Button AddBTN;
        private System.Windows.Forms.Label IngrListLB;
        private System.Windows.Forms.Button DeleteBTN;
    }
}