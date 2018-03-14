namespace CourseProject2017
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainGrid = new System.Windows.Forms.DataGridView();
            this.AddBtn = new System.Windows.Forms.Button();
            this.RefreshBtn = new System.Windows.Forms.Button();
            this.ChangeTableBTN = new System.Windows.Forms.Button();
            this.TablesCB = new System.Windows.Forms.ComboBox();
            this.ChangeRecordBTN = new System.Windows.Forms.Button();
            this.MenuDishNameBTN = new System.Windows.Forms.Button();
            this.DeleteBTN = new System.Windows.Forms.Button();
            this.OrdStateBTN = new System.Windows.Forms.Button();
            this.MenCostBTN = new System.Windows.Forms.Button();
            this.MenTimeBTN = new System.Windows.Forms.Button();
            this.ProdCountBTN = new System.Windows.Forms.Button();
            this.ProdTypeBTN = new System.Windows.Forms.Button();
            this.ChefSalBTN = new System.Windows.Forms.Button();
            this.ChefBirthBTN = new System.Windows.Forms.Button();
            this.ChekFileBTN = new System.Windows.Forms.Button();
            this.SaveChek = new System.Windows.Forms.SaveFileDialog();
            this.OrdStateFiltBTN = new System.Windows.Forms.Button();
            this.ChefPozFilterBTN = new System.Windows.Forms.Button();
            this.ChefPozFilterTB = new System.Windows.Forms.TextBox();
            this.MenuDishNameTB = new System.Windows.Forms.TextBox();
            this.ProductNameTB = new System.Windows.Forms.TextBox();
            this.ProductNameBTN = new System.Windows.Forms.Button();
            this.SaveProd = new System.Windows.Forms.SaveFileDialog();
            this.ProductSaveBTN = new System.Windows.Forms.Button();
            this.ChefSalaryBTN = new System.Windows.Forms.Button();
            this.SaveSalaty = new System.Windows.Forms.SaveFileDialog();
            this.FreeSqlRequestBTN = new System.Windows.Forms.Button();
            this.PrognozMS = new System.Windows.Forms.MenuStrip();
            this.showPrognozToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCostFilterBTN = new System.Windows.Forms.Button();
            this.MenuCostFilterTB = new System.Windows.Forms.TextBox();
            this.MenuCostFilterCB = new System.Windows.Forms.ComboBox();
            this.ChefSalaryFilterBTN = new System.Windows.Forms.Button();
            this.ChefSalaryFilterTB = new System.Windows.Forms.TextBox();
            this.ChefSalaryFilterCB = new System.Windows.Forms.ComboBox();
            this.BTNHighestPriceMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MainGrid)).BeginInit();
            this.PrognozMS.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainGrid
            // 
            this.MainGrid.AllowUserToAddRows = false;
            this.MainGrid.AllowUserToDeleteRows = false;
            this.MainGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainGrid.Location = new System.Drawing.Point(12, 51);
            this.MainGrid.Name = "MainGrid";
            this.MainGrid.ReadOnly = true;
            this.MainGrid.Size = new System.Drawing.Size(533, 150);
            this.MainGrid.TabIndex = 0;
            this.MainGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MainGrid_CellContentClick);
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(12, 267);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(75, 23);
            this.AddBtn.TabIndex = 2;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.Location = new System.Drawing.Point(12, 22);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(75, 23);
            this.RefreshBtn.TabIndex = 3;
            this.RefreshBtn.Text = "Refresh";
            this.RefreshBtn.UseVisualStyleBackColor = true;
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // ChangeTableBTN
            // 
            this.ChangeTableBTN.Location = new System.Drawing.Point(458, 22);
            this.ChangeTableBTN.Name = "ChangeTableBTN";
            this.ChangeTableBTN.Size = new System.Drawing.Size(87, 23);
            this.ChangeTableBTN.TabIndex = 4;
            this.ChangeTableBTN.Text = "Change table";
            this.ChangeTableBTN.UseVisualStyleBackColor = true;
            this.ChangeTableBTN.Click += new System.EventHandler(this.ChangeTableBTN_Click);
            // 
            // TablesCB
            // 
            this.TablesCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TablesCB.FormattingEnabled = true;
            this.TablesCB.Items.AddRange(new object[] {
            "Chefs",
            "Menu",
            "Orders",
            "Products",
            "Reception",
            "Cheks"});
            this.TablesCB.Location = new System.Drawing.Point(331, 22);
            this.TablesCB.Name = "TablesCB";
            this.TablesCB.Size = new System.Drawing.Size(121, 21);
            this.TablesCB.TabIndex = 5;
            // 
            // ChangeRecordBTN
            // 
            this.ChangeRecordBTN.Location = new System.Drawing.Point(248, 267);
            this.ChangeRecordBTN.Name = "ChangeRecordBTN";
            this.ChangeRecordBTN.Size = new System.Drawing.Size(75, 23);
            this.ChangeRecordBTN.TabIndex = 6;
            this.ChangeRecordBTN.Text = "Change";
            this.ChangeRecordBTN.UseVisualStyleBackColor = true;
            this.ChangeRecordBTN.Click += new System.EventHandler(this.ChangeRecordBTN_Click);
            // 
            // MenuDishNameBTN
            // 
            this.MenuDishNameBTN.Location = new System.Drawing.Point(144, 236);
            this.MenuDishNameBTN.Name = "MenuDishNameBTN";
            this.MenuDishNameBTN.Size = new System.Drawing.Size(98, 23);
            this.MenuDishNameBTN.TabIndex = 7;
            this.MenuDishNameBTN.Text = "Find dish";
            this.MenuDishNameBTN.UseVisualStyleBackColor = true;
            this.MenuDishNameBTN.Click += new System.EventHandler(this.MenuDishNameBNT_Click);
            // 
            // DeleteBTN
            // 
            this.DeleteBTN.Location = new System.Drawing.Point(470, 265);
            this.DeleteBTN.Name = "DeleteBTN";
            this.DeleteBTN.Size = new System.Drawing.Size(75, 23);
            this.DeleteBTN.TabIndex = 8;
            this.DeleteBTN.Text = "Delete";
            this.DeleteBTN.UseVisualStyleBackColor = true;
            this.DeleteBTN.Click += new System.EventHandler(this.DeleteBTN_Click);
            // 
            // OrdStateBTN
            // 
            this.OrdStateBTN.Location = new System.Drawing.Point(104, 22);
            this.OrdStateBTN.Name = "OrdStateBTN";
            this.OrdStateBTN.Size = new System.Drawing.Size(91, 23);
            this.OrdStateBTN.TabIndex = 9;
            this.OrdStateBTN.Text = "Sort by State";
            this.OrdStateBTN.UseVisualStyleBackColor = true;
            this.OrdStateBTN.Click += new System.EventHandler(this.OrdStateBTN_Click);
            // 
            // MenCostBTN
            // 
            this.MenCostBTN.Location = new System.Drawing.Point(104, 22);
            this.MenCostBTN.Name = "MenCostBTN";
            this.MenCostBTN.Size = new System.Drawing.Size(91, 23);
            this.MenCostBTN.TabIndex = 10;
            this.MenCostBTN.Text = "Sort by cost";
            this.MenCostBTN.UseVisualStyleBackColor = true;
            this.MenCostBTN.Click += new System.EventHandler(this.MenCostBTN_Click);
            // 
            // MenTimeBTN
            // 
            this.MenTimeBTN.Location = new System.Drawing.Point(263, 235);
            this.MenTimeBTN.Name = "MenTimeBTN";
            this.MenTimeBTN.Size = new System.Drawing.Size(81, 23);
            this.MenTimeBTN.TabIndex = 11;
            this.MenTimeBTN.Text = "Sort by time";
            this.MenTimeBTN.UseVisualStyleBackColor = true;
            this.MenTimeBTN.Click += new System.EventHandler(this.MenTimeBTN_Click);
            // 
            // ProdCountBTN
            // 
            this.ProdCountBTN.Location = new System.Drawing.Point(104, 22);
            this.ProdCountBTN.Name = "ProdCountBTN";
            this.ProdCountBTN.Size = new System.Drawing.Size(91, 23);
            this.ProdCountBTN.TabIndex = 12;
            this.ProdCountBTN.Text = "Sort by count";
            this.ProdCountBTN.UseVisualStyleBackColor = true;
            this.ProdCountBTN.Click += new System.EventHandler(this.ProdCountBTN_Click);
            // 
            // ProdTypeBTN
            // 
            this.ProdTypeBTN.Location = new System.Drawing.Point(263, 236);
            this.ProdTypeBTN.Name = "ProdTypeBTN";
            this.ProdTypeBTN.Size = new System.Drawing.Size(81, 22);
            this.ProdTypeBTN.TabIndex = 13;
            this.ProdTypeBTN.Text = "Sort by type";
            this.ProdTypeBTN.UseVisualStyleBackColor = true;
            this.ProdTypeBTN.Click += new System.EventHandler(this.ProdTypeBTN_Click);
            // 
            // ChefSalBTN
            // 
            this.ChefSalBTN.Location = new System.Drawing.Point(104, 22);
            this.ChefSalBTN.Name = "ChefSalBTN";
            this.ChefSalBTN.Size = new System.Drawing.Size(91, 23);
            this.ChefSalBTN.TabIndex = 14;
            this.ChefSalBTN.Text = "Sort by salary";
            this.ChefSalBTN.UseVisualStyleBackColor = true;
            this.ChefSalBTN.Click += new System.EventHandler(this.ChefSalBTN_Click);
            // 
            // ChefBirthBTN
            // 
            this.ChefBirthBTN.Location = new System.Drawing.Point(248, 236);
            this.ChefBirthBTN.Name = "ChefBirthBTN";
            this.ChefBirthBTN.Size = new System.Drawing.Size(96, 23);
            this.ChefBirthBTN.TabIndex = 15;
            this.ChefBirthBTN.Text = "Sort by birthday";
            this.ChefBirthBTN.UseVisualStyleBackColor = true;
            this.ChefBirthBTN.Click += new System.EventHandler(this.ChefBirthBTN_Click);
            // 
            // ChekFileBTN
            // 
            this.ChekFileBTN.Location = new System.Drawing.Point(206, 22);
            this.ChekFileBTN.Name = "ChekFileBTN";
            this.ChekFileBTN.Size = new System.Drawing.Size(117, 23);
            this.ChekFileBTN.TabIndex = 16;
            this.ChekFileBTN.Text = "Save chek";
            this.ChekFileBTN.UseVisualStyleBackColor = true;
            this.ChekFileBTN.Click += new System.EventHandler(this.PrintCheck);
            // 
            // OrdStateFiltBTN
            // 
            this.OrdStateFiltBTN.Location = new System.Drawing.Point(206, 22);
            this.OrdStateFiltBTN.Name = "OrdStateFiltBTN";
            this.OrdStateFiltBTN.Size = new System.Drawing.Size(117, 21);
            this.OrdStateFiltBTN.TabIndex = 17;
            this.OrdStateFiltBTN.Text = "Filter by state";
            this.OrdStateFiltBTN.UseVisualStyleBackColor = true;
            this.OrdStateFiltBTN.Click += new System.EventHandler(this.OrdStateFiltBTN_Click);
            // 
            // ChefPozFilterBTN
            // 
            this.ChefPozFilterBTN.Location = new System.Drawing.Point(144, 236);
            this.ChefPozFilterBTN.Name = "ChefPozFilterBTN";
            this.ChefPozFilterBTN.Size = new System.Drawing.Size(98, 23);
            this.ChefPozFilterBTN.TabIndex = 18;
            this.ChefPozFilterBTN.Text = "Filter by pozition";
            this.ChefPozFilterBTN.UseVisualStyleBackColor = true;
            this.ChefPozFilterBTN.Click += new System.EventHandler(this.ChefPozFilterBTN_Click);
            // 
            // ChefPozFilterTB
            // 
            this.ChefPozFilterTB.Location = new System.Drawing.Point(12, 236);
            this.ChefPozFilterTB.Name = "ChefPozFilterTB";
            this.ChefPozFilterTB.Size = new System.Drawing.Size(113, 20);
            this.ChefPozFilterTB.TabIndex = 19;
            // 
            // MenuDishNameTB
            // 
            this.MenuDishNameTB.Location = new System.Drawing.Point(12, 236);
            this.MenuDishNameTB.Name = "MenuDishNameTB";
            this.MenuDishNameTB.Size = new System.Drawing.Size(112, 20);
            this.MenuDishNameTB.TabIndex = 20;
            // 
            // ProductNameTB
            // 
            this.ProductNameTB.Location = new System.Drawing.Point(12, 236);
            this.ProductNameTB.Name = "ProductNameTB";
            this.ProductNameTB.Size = new System.Drawing.Size(111, 20);
            this.ProductNameTB.TabIndex = 21;
            // 
            // ProductNameBTN
            // 
            this.ProductNameBTN.Location = new System.Drawing.Point(144, 236);
            this.ProductNameBTN.Name = "ProductNameBTN";
            this.ProductNameBTN.Size = new System.Drawing.Size(98, 23);
            this.ProductNameBTN.TabIndex = 22;
            this.ProductNameBTN.Text = "Find product";
            this.ProductNameBTN.UseVisualStyleBackColor = true;
            this.ProductNameBTN.Click += new System.EventHandler(this.ProductNameBTN_Click);
            // 
            // ProductSaveBTN
            // 
            this.ProductSaveBTN.Location = new System.Drawing.Point(206, 22);
            this.ProductSaveBTN.Name = "ProductSaveBTN";
            this.ProductSaveBTN.Size = new System.Drawing.Size(119, 23);
            this.ProductSaveBTN.TabIndex = 23;
            this.ProductSaveBTN.Text = "Save a product list";
            this.ProductSaveBTN.UseVisualStyleBackColor = true;
            this.ProductSaveBTN.Click += new System.EventHandler(this.PrintProducts);
            // 
            // ChefSalaryBTN
            // 
            this.ChefSalaryBTN.Location = new System.Drawing.Point(206, 22);
            this.ChefSalaryBTN.Name = "ChefSalaryBTN";
            this.ChefSalaryBTN.Size = new System.Drawing.Size(119, 23);
            this.ChefSalaryBTN.TabIndex = 24;
            this.ChefSalaryBTN.Text = "Save salary";
            this.ChefSalaryBTN.UseVisualStyleBackColor = true;
            this.ChefSalaryBTN.Click += new System.EventHandler(this.PrintChefSalary);
            // 
            // FreeSqlRequestBTN
            // 
            this.FreeSqlRequestBTN.Location = new System.Drawing.Point(470, 235);
            this.FreeSqlRequestBTN.Name = "FreeSqlRequestBTN";
            this.FreeSqlRequestBTN.Size = new System.Drawing.Size(75, 23);
            this.FreeSqlRequestBTN.TabIndex = 25;
            this.FreeSqlRequestBTN.Text = "sql form";
            this.FreeSqlRequestBTN.UseVisualStyleBackColor = true;
            this.FreeSqlRequestBTN.Click += new System.EventHandler(this.FreeSqlRequestBTN_Click);
            // 
            // PrognozMS
            // 
            this.PrognozMS.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.PrognozMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showPrognozToolStripMenuItem});
            this.PrognozMS.Location = new System.Drawing.Point(0, 0);
            this.PrognozMS.Name = "PrognozMS";
            this.PrognozMS.Size = new System.Drawing.Size(556, 24);
            this.PrognozMS.TabIndex = 26;
            this.PrognozMS.Text = "menuStrip1";
            // 
            // showPrognozToolStripMenuItem
            // 
            this.showPrognozToolStripMenuItem.Name = "showPrognozToolStripMenuItem";
            this.showPrognozToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.showPrognozToolStripMenuItem.Text = "Show prognoz";
            this.showPrognozToolStripMenuItem.Click += new System.EventHandler(this.showPrognozToolStripMenuItem_Click);
            // 
            // MenuCostFilterBTN
            // 
            this.MenuCostFilterBTN.Location = new System.Drawing.Point(144, 207);
            this.MenuCostFilterBTN.Name = "MenuCostFilterBTN";
            this.MenuCostFilterBTN.Size = new System.Drawing.Size(98, 23);
            this.MenuCostFilterBTN.TabIndex = 27;
            this.MenuCostFilterBTN.Text = "Filter by cost";
            this.MenuCostFilterBTN.UseVisualStyleBackColor = true;
            this.MenuCostFilterBTN.Click += new System.EventHandler(this.MenuCostFilterBTN_Click);
            // 
            // MenuCostFilterTB
            // 
            this.MenuCostFilterTB.Location = new System.Drawing.Point(81, 207);
            this.MenuCostFilterTB.Name = "MenuCostFilterTB";
            this.MenuCostFilterTB.Size = new System.Drawing.Size(42, 20);
            this.MenuCostFilterTB.TabIndex = 28;
            // 
            // MenuCostFilterCB
            // 
            this.MenuCostFilterCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MenuCostFilterCB.FormattingEnabled = true;
            this.MenuCostFilterCB.Items.AddRange(new object[] {
            "<=",
            "=",
            ">=",
            "<>"});
            this.MenuCostFilterCB.Location = new System.Drawing.Point(12, 207);
            this.MenuCostFilterCB.Name = "MenuCostFilterCB";
            this.MenuCostFilterCB.Size = new System.Drawing.Size(43, 21);
            this.MenuCostFilterCB.TabIndex = 29;
            // 
            // ChefSalaryFilterBTN
            // 
            this.ChefSalaryFilterBTN.Location = new System.Drawing.Point(144, 207);
            this.ChefSalaryFilterBTN.Name = "ChefSalaryFilterBTN";
            this.ChefSalaryFilterBTN.Size = new System.Drawing.Size(98, 23);
            this.ChefSalaryFilterBTN.TabIndex = 30;
            this.ChefSalaryFilterBTN.Text = "Filter by salary";
            this.ChefSalaryFilterBTN.UseVisualStyleBackColor = true;
            this.ChefSalaryFilterBTN.Click += new System.EventHandler(this.ChefSalaryFilterBTN_Click);
            // 
            // ChefSalaryFilterTB
            // 
            this.ChefSalaryFilterTB.Location = new System.Drawing.Point(81, 207);
            this.ChefSalaryFilterTB.Name = "ChefSalaryFilterTB";
            this.ChefSalaryFilterTB.Size = new System.Drawing.Size(44, 20);
            this.ChefSalaryFilterTB.TabIndex = 31;
            // 
            // ChefSalaryFilterCB
            // 
            this.ChefSalaryFilterCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ChefSalaryFilterCB.FormattingEnabled = true;
            this.ChefSalaryFilterCB.Items.AddRange(new object[] {
            "<=",
            "=",
            ">=",
            "<>"});
            this.ChefSalaryFilterCB.Location = new System.Drawing.Point(13, 207);
            this.ChefSalaryFilterCB.Name = "ChefSalaryFilterCB";
            this.ChefSalaryFilterCB.Size = new System.Drawing.Size(42, 21);
            this.ChefSalaryFilterCB.TabIndex = 32;
            // 
            // BTNHighestPriceMenu
            // 
            this.BTNHighestPriceMenu.Location = new System.Drawing.Point(206, 22);
            this.BTNHighestPriceMenu.Margin = new System.Windows.Forms.Padding(2);
            this.BTNHighestPriceMenu.Name = "BTNHighestPriceMenu";
            this.BTNHighestPriceMenu.Size = new System.Drawing.Size(119, 24);
            this.BTNHighestPriceMenu.TabIndex = 33;
            this.BTNHighestPriceMenu.Text = "Highest price";
            this.BTNHighestPriceMenu.UseVisualStyleBackColor = true;
            this.BTNHighestPriceMenu.Click += new System.EventHandler(this.BTNHighestPriceMenu_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 301);
            this.Controls.Add(this.BTNHighestPriceMenu);
            this.Controls.Add(this.ChefSalaryFilterCB);
            this.Controls.Add(this.ChefSalaryFilterTB);
            this.Controls.Add(this.ChefSalaryFilterBTN);
            this.Controls.Add(this.MenuCostFilterCB);
            this.Controls.Add(this.MenuCostFilterTB);
            this.Controls.Add(this.MenuCostFilterBTN);
            this.Controls.Add(this.FreeSqlRequestBTN);
            this.Controls.Add(this.ChefSalaryBTN);
            this.Controls.Add(this.ProductSaveBTN);
            this.Controls.Add(this.ProductNameBTN);
            this.Controls.Add(this.ProductNameTB);
            this.Controls.Add(this.MenuDishNameTB);
            this.Controls.Add(this.ChefPozFilterTB);
            this.Controls.Add(this.ChefPozFilterBTN);
            this.Controls.Add(this.OrdStateFiltBTN);
            this.Controls.Add(this.ChekFileBTN);
            this.Controls.Add(this.ChefBirthBTN);
            this.Controls.Add(this.ChefSalBTN);
            this.Controls.Add(this.ProdTypeBTN);
            this.Controls.Add(this.ProdCountBTN);
            this.Controls.Add(this.MenTimeBTN);
            this.Controls.Add(this.MenCostBTN);
            this.Controls.Add(this.OrdStateBTN);
            this.Controls.Add(this.DeleteBTN);
            this.Controls.Add(this.MenuDishNameBTN);
            this.Controls.Add(this.ChangeRecordBTN);
            this.Controls.Add(this.TablesCB);
            this.Controls.Add(this.ChangeTableBTN);
            this.Controls.Add(this.RefreshBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.MainGrid);
            this.Controls.Add(this.PrognozMS);
            this.MaximumSize = new System.Drawing.Size(572, 339);
            this.MinimumSize = new System.Drawing.Size(572, 339);
            this.Name = "MainForm";
            this.Text = "UBDB";
            ((System.ComponentModel.ISupportInitialize)(this.MainGrid)).EndInit();
            this.PrognozMS.ResumeLayout(false);
            this.PrognozMS.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView MainGrid;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button RefreshBtn;
        private System.Windows.Forms.Button ChangeTableBTN;
        private System.Windows.Forms.ComboBox TablesCB;
        private System.Windows.Forms.Button ChangeRecordBTN;
        private System.Windows.Forms.Button MenuDishNameBTN;
        private System.Windows.Forms.Button DeleteBTN;
        private System.Windows.Forms.Button OrdStateBTN;
        private System.Windows.Forms.Button MenCostBTN;
        private System.Windows.Forms.Button MenTimeBTN;
        private System.Windows.Forms.Button ProdCountBTN;
        private System.Windows.Forms.Button ProdTypeBTN;
        private System.Windows.Forms.Button ChefSalBTN;
        private System.Windows.Forms.Button ChefBirthBTN;
        private System.Windows.Forms.Button ChekFileBTN;
        private System.Windows.Forms.SaveFileDialog SaveChek;
        private System.Windows.Forms.Button OrdStateFiltBTN;
        private System.Windows.Forms.Button ChefPozFilterBTN;
        private System.Windows.Forms.TextBox ChefPozFilterTB;
        private System.Windows.Forms.TextBox MenuDishNameTB;
        private System.Windows.Forms.TextBox ProductNameTB;
        private System.Windows.Forms.Button ProductNameBTN;
        private System.Windows.Forms.SaveFileDialog SaveProd;
        private System.Windows.Forms.Button ProductSaveBTN;
        private System.Windows.Forms.Button ChefSalaryBTN;
        private System.Windows.Forms.SaveFileDialog SaveSalaty;
        private System.Windows.Forms.Button FreeSqlRequestBTN;
        private System.Windows.Forms.MenuStrip PrognozMS;
        private System.Windows.Forms.ToolStripMenuItem showPrognozToolStripMenuItem;
        private System.Windows.Forms.Button MenuCostFilterBTN;
        private System.Windows.Forms.TextBox MenuCostFilterTB;
        private System.Windows.Forms.ComboBox MenuCostFilterCB;
        private System.Windows.Forms.Button ChefSalaryFilterBTN;
        private System.Windows.Forms.TextBox ChefSalaryFilterTB;
        private System.Windows.Forms.ComboBox ChefSalaryFilterCB;
        private System.Windows.Forms.Button BTNHighestPriceMenu;
    }
}

