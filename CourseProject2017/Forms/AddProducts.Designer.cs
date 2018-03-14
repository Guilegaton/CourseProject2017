namespace CourseProject2017.Forms
{
    partial class AddProducts
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
            this.ProdNameLB = new System.Windows.Forms.Label();
            this.CountLB = new System.Windows.Forms.Label();
            this.TypeLB = new System.Windows.Forms.Label();
            this.ProdNameTB = new System.Windows.Forms.TextBox();
            this.CountTB = new System.Windows.Forms.TextBox();
            this.TypeTB = new System.Windows.Forms.TextBox();
            this.AddBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ProdNameLB
            // 
            this.ProdNameLB.AutoSize = true;
            this.ProdNameLB.Location = new System.Drawing.Point(13, 36);
            this.ProdNameLB.Name = "ProdNameLB";
            this.ProdNameLB.Size = new System.Drawing.Size(73, 13);
            this.ProdNameLB.TabIndex = 0;
            this.ProdNameLB.Text = "Product name";
            // 
            // CountLB
            // 
            this.CountLB.AutoSize = true;
            this.CountLB.Location = new System.Drawing.Point(13, 63);
            this.CountLB.Name = "CountLB";
            this.CountLB.Size = new System.Drawing.Size(35, 13);
            this.CountLB.TabIndex = 1;
            this.CountLB.Text = "Count";
            // 
            // TypeLB
            // 
            this.TypeLB.AutoSize = true;
            this.TypeLB.Location = new System.Drawing.Point(13, 90);
            this.TypeLB.Name = "TypeLB";
            this.TypeLB.Size = new System.Drawing.Size(31, 13);
            this.TypeLB.TabIndex = 2;
            this.TypeLB.Text = "Type";
            // 
            // ProdNameTB
            // 
            this.ProdNameTB.Location = new System.Drawing.Point(103, 33);
            this.ProdNameTB.Name = "ProdNameTB";
            this.ProdNameTB.Size = new System.Drawing.Size(100, 20);
            this.ProdNameTB.TabIndex = 3;
            // 
            // CountTB
            // 
            this.CountTB.Location = new System.Drawing.Point(103, 63);
            this.CountTB.Name = "CountTB";
            this.CountTB.Size = new System.Drawing.Size(100, 20);
            this.CountTB.TabIndex = 4;
            // 
            // TypeTB
            // 
            this.TypeTB.Location = new System.Drawing.Point(103, 90);
            this.TypeTB.Name = "TypeTB";
            this.TypeTB.Size = new System.Drawing.Size(100, 20);
            this.TypeTB.TabIndex = 5;
            // 
            // AddBTN
            // 
            this.AddBTN.Location = new System.Drawing.Point(54, 133);
            this.AddBTN.Name = "AddBTN";
            this.AddBTN.Size = new System.Drawing.Size(75, 23);
            this.AddBTN.TabIndex = 6;
            this.AddBTN.Text = "Add";
            this.AddBTN.UseVisualStyleBackColor = true;
            this.AddBTN.Click += new System.EventHandler(this.AddBTN_Click);
            // 
            // AddProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(216, 168);
            this.Controls.Add(this.AddBTN);
            this.Controls.Add(this.TypeTB);
            this.Controls.Add(this.CountTB);
            this.Controls.Add(this.ProdNameTB);
            this.Controls.Add(this.TypeLB);
            this.Controls.Add(this.CountLB);
            this.Controls.Add(this.ProdNameLB);
            this.MaximumSize = new System.Drawing.Size(232, 206);
            this.MinimumSize = new System.Drawing.Size(232, 206);
            this.Name = "AddProducts";
            this.Text = "Product";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ProdNameLB;
        private System.Windows.Forms.Label CountLB;
        private System.Windows.Forms.Label TypeLB;
        private System.Windows.Forms.TextBox ProdNameTB;
        private System.Windows.Forms.TextBox CountTB;
        private System.Windows.Forms.TextBox TypeTB;
        private System.Windows.Forms.Button AddBTN;
    }
}