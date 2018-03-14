namespace CourseProject2017.Forms
{
    partial class SQLServerSelectionForm
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
            this.ServerNameLB = new System.Windows.Forms.Label();
            this.ServerNameTB = new System.Windows.Forms.TextBox();
            this.OkBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ServerNameLB
            // 
            this.ServerNameLB.AutoSize = true;
            this.ServerNameLB.Location = new System.Drawing.Point(13, 49);
            this.ServerNameLB.Name = "ServerNameLB";
            this.ServerNameLB.Size = new System.Drawing.Size(35, 13);
            this.ServerNameLB.TabIndex = 0;
            this.ServerNameLB.Text = "Server name";
           
            // 
            // ServerNameTB
            // 
            this.ServerNameTB.Location = new System.Drawing.Point(92, 50);
            this.ServerNameTB.Name = "ServerNameTB";
            this.ServerNameTB.Size = new System.Drawing.Size(100, 20);
            this.ServerNameTB.TabIndex = 5;
            // 
            // OkBTN
            // 
            this.OkBTN.Location = new System.Drawing.Point(58, 231);
            this.OkBTN.Name = "OkBTN";
            this.OkBTN.Size = new System.Drawing.Size(75, 23);
            this.OkBTN.TabIndex = 10;
            this.OkBTN.Text = "Ok";
            this.OkBTN.UseVisualStyleBackColor = true;
            this.OkBTN.Click += new System.EventHandler(this.OkBTN_Click);
            // 
            // SQLServerSelction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(203, 266);
            this.Controls.Add(this.OkBTN);
            this.Controls.Add(this.ServerNameTB);
            this.Controls.Add(this.ServerNameLB);
            this.MaximumSize = new System.Drawing.Size(219, 304);
            this.MinimumSize = new System.Drawing.Size(219, 304);
            this.Name = "SQLServerSelction";
            this.Text = "Input name of your SQL server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ServerNameLB;
        private System.Windows.Forms.TextBox ServerNameTB;
        private System.Windows.Forms.Button OkBTN;
    }
}