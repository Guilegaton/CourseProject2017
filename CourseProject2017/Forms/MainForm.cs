using CourseProject2017.Classes;
using CourseProject2017.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using System.Configuration;

namespace CourseProject2017
{
    public partial class MainForm : Form
    {
        internal CafeContext db;
        private Type _currentTable;
        private List<Control> ChangebleCompontents = new List<Control>();
        private bool _filterFlag;


        public MainForm()
        {
            bool serverflag = false;
            do
            {
                SQLServerSelectionForm ConnectionStringForm = new SQLServerSelectionForm();
                ConnectionStringForm.ShowDialog();
                InitializeComponent();
                db = new CafeContext();
                try
                {
                    MainGrid.DataSource = db.Orders.ToList();
                    serverflag = true;
                }
                catch (System.Data.SqlClient.SqlException e)
                {
                    MessageBox.Show("Your server is invalid");
                }
            }
            while (!serverflag) ;
            _currentTable = db.Orders.GetType();
            HideBTN();
            OrdStateBTN.Visible = true;
            OrdStateFiltBTN.Visible = true;
            this.ChangebleCompontents.Add(BTNHighestPriceMenu);
            this.ChangebleCompontents.Add(ChefBirthBTN);
            this.ChangebleCompontents.Add(ChefSalaryBTN);
            this.ChangebleCompontents.Add(MenCostBTN);
            this.ChangebleCompontents.Add(MenTimeBTN);
            this.ChangebleCompontents.Add(ProdTypeBTN);
            this.ChangebleCompontents.Add(ProdCountBTN);
            this.ChangebleCompontents.Add(OrdStateBTN);
            this.ChangebleCompontents.Add(OrdStateFiltBTN);
            this.ChangebleCompontents.Add(ChekFileBTN);
            this.ChangebleCompontents.Add(ChefPozFilterBTN);
            this.ChangebleCompontents.Add(ChefPozFilterTB);
            this.ChangebleCompontents.Add(MenuDishNameTB);
            this.ChangebleCompontents.Add(MenuDishNameBTN);
            this.ChangebleCompontents.Add(ChefSalBTN);
            this.ChangebleCompontents.Add(ProductSaveBTN);
            this.ChangebleCompontents.Add(ProductNameTB);
            this.ChangebleCompontents.Add(ProductNameBTN);
            this.ChangebleCompontents.Add(MenuCostFilterCB);
            this.ChangebleCompontents.Add(MenuCostFilterTB);
            this.ChangebleCompontents.Add(MenuCostFilterBTN);
            this.ChangebleCompontents.Add(ChefSalaryFilterCB);
            this.ChangebleCompontents.Add(ChefSalaryFilterTB);
            this.ChangebleCompontents.Add(ChefSalaryFilterBTN);

        }

        private void MainGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (_currentTable.Equals(db.Orders.GetType()))
            {
                if (e.ColumnIndex == 1)
                {
                    AddMenuPoint VeiwMenuPointForm = new AddMenuPoint(
						db.Menu.Find
							(MainGrid.CurrentCell.Value)
						, this, true);
                    VeiwMenuPointForm.Show();
                }
                if (e.ColumnIndex == 2)
                {
                    AddChef VeiwChefForm = new AddChef(
						db.Chefs.Find
							(MainGrid.CurrentCell.Value)
						, true);
                    VeiwChefForm.Show();
                }
            }
             if (_currentTable.Equals(db.Menu.GetType()))
            {
                if (e.ColumnIndex == 2)
                {
                    int no = (int)MainGrid.CurrentCell.Value;
                    AddReception VeiwReceptionForm = new AddReception(
                        db.Receptions.Where
							(recept => recept.No == no).ToList()
						, this, true);
                    VeiwReceptionForm.Show();
                }
            }
             if (_currentTable.Equals(db.Receptions.GetType()))
            {
                if (e.ColumnIndex == 1)
                {
                    AddProducts VeiwProductFrom = new AddProducts(
						db.Products.Single
							(item => item.Id.ToString().Equals(MainGrid.CurrentCell.Value.ToString()))
						, true);
                    VeiwProductFrom.Show();
                }
            }
            if (_currentTable.Equals(db.Cheks.GetType()))
            {
                if (e.ColumnIndex == 1)
                {
                    AddOrder VeiwOrderForm = new AddOrder(
						db.Orders.Single
							(item => item.Id == (int)MainGrid.CurrentCell.Value)
						, this, true);
                    VeiwOrderForm.Show();
                }
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (_currentTable.Equals(db.Orders.GetType()))
            {
                AddOrder AddOrderForm = new AddOrder(this);
                AddOrderForm.ShowDialog();
                if (AddOrderForm.flag)
                {
                    try
                    {
                        Orders new_order = new Orders { DishID = AddOrderForm.DishID,
														ChefId = AddOrderForm.Chef,
														Time = AddOrderForm.time,
														State = AddOrderForm.state };
                        db.Orders.Add(new_order);
                        db.SaveChanges();
						AddOrderForm.Dispose();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

            }
            if (_currentTable.Equals(db.Chefs.GetType()))
            {
                AddChef AddChefForm = new AddChef();
                AddChefForm.ShowDialog();
                if (AddChefForm.flag)
                {
                    try
                    {
                        Chef new_chef = new Chef { Name = AddChefForm.name,
												   Surname = AddChefForm.surname,
												   Salary = AddChefForm.salary,
												   Birthday = AddChefForm.birthday,
												   Pozition_name = AddChefForm.pozition };
                        db.Chefs.Add(new_chef);
                        db.SaveChanges();
						AddChefForm.Dispose();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            if (_currentTable.Equals(db.Products.GetType()))
            {
                AddProducts AddProductForm = new AddProducts();
                AddProductForm.ShowDialog();
                if (AddProductForm.flag)
                {
                    try
                    {
                        Products new_product = new Products { ProductName = AddProductForm.ProdName,
															  Count = AddProductForm.Count,
															  Type = AddProductForm.Type };
                        db.Products.Add(new_product);
                        db.SaveChanges();
						AddProductForm.Dispose();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            if (_currentTable.Equals(db.Menu.GetType()))
            {
                AddMenuPoint AddMenuPointForm = new AddMenuPoint(this);
                AddMenuPointForm.ShowDialog();
                if (AddMenuPointForm.flag)
                {
                    try
                    {
                        Classes.Menu new_menu = new Classes.Menu { DishName = AddMenuPointForm.DishName,
																   ReceptionID = AddMenuPointForm.ReceptionID,
																   Cost = AddMenuPointForm.Cost,
																   WaitingTime_Min = AddMenuPointForm.WTime };
                        db.Menu.Add(new_menu);
                        db.SaveChanges();
						AddMenuPointForm.Dispose();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            if (_currentTable.Equals(db.Receptions.GetType()))
            {
                AddReception AddReceptionForm = new AddReception(this);
                AddReceptionForm.ShowDialog();
                if (AddReceptionForm.flag)
                {
                    try
                    {
                        db.Receptions.AddRange(AddReceptionForm.ReceptionList);
                        db.SaveChanges();
						AddReceptionForm.Dispose();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            if (_currentTable.Equals(db.Cheks.GetType()))
            {
                AddChek AddCheckForm = new AddChek(this);
                AddCheckForm.ShowDialog();
                if (AddCheckForm.flag)
                {
                    db.Cheks.AddRange(AddCheckForm.ChekList);
                    foreach (var CurrentOrder in AddCheckForm.ChosenOrder)
                    {
                        db.Orders.Find(CurrentOrder.Id).State = true;
                    }
                    foreach (var CurrentDish in AddCheckForm.ChosenDish)
                    {
                        foreach (var CurrentReception in db.Receptions.Where(item => item.No == CurrentDish.ReceptionID).ToList())
                        {
                            db.Products.ToList().Find(item => item.Id == CurrentReception.ProductId).Count -= CurrentReception.Count;
                        }
                    }
                    db.SaveChanges();
					AddCheckForm.Dispose();
                }
            }

            Refresh_Grid();
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            Refresh_Grid();
        }

        private void Refresh_Grid()
        {
            if (_currentTable.Equals(db.Orders.GetType()))
            {
                MainGrid.DataSource = db.Orders.ToList();
            }
             if (_currentTable.Equals(db.Chefs.GetType()))
            {
                MainGrid.DataSource = db.Chefs.ToList();
            }
             if (_currentTable.Equals(db.Products.GetType()))
            {
                MainGrid.DataSource = db.Products.ToList();
            }
             if (_currentTable.Equals(db.Menu.GetType()))
            {
                MainGrid.DataSource = db.Menu.ToList();
            }
             if (_currentTable.Equals(db.Receptions.GetType()))
            {
                MainGrid.DataSource = db.Receptions.ToList();
            }
             if (_currentTable.Equals(db.Cheks.GetType()))
            {
                MainGrid.DataSource = db.Cheks.ToList();
            }
        }

        private void ChangeTableBTN_Click(object sender, EventArgs e)
        {
            if (TablesCB.Text.Equals("Chefs"))
            {
                HideBTN();
                ChefBirthBTN.Visible = true;
                ChefSalBTN.Visible = true;
                ChefPozFilterBTN.Visible = true;
                ChefPozFilterTB.Visible = true;
                ChefSalaryBTN.Visible = true;
                ChefSalaryFilterCB.Visible = true;
                ChefSalaryFilterTB.Visible = true;
                ChefSalaryFilterBTN.Visible = true;
                MainGrid.DataSource = db.Chefs.ToList();
                _currentTable = db.Chefs.GetType();
            }
             if (TablesCB.Text.Equals("Menu"))
            {
                HideBTN();
                BTNHighestPriceMenu.Visible = true;
                MenuCostFilterCB.Visible = true;
                MenuCostFilterTB.Visible = true;
                MenuCostFilterBTN.Visible = true;
                MenuDishNameTB.Visible = true;
                MenuDishNameBTN.Visible = true;
                MainGrid.DataSource = db.Menu.ToList();
                _currentTable = db.Menu.GetType();
            }
             if (TablesCB.Text.Equals("Orders"))
            {
                HideBTN();
                OrdStateBTN.Visible = true;
                OrdStateFiltBTN.Visible = true;
                MainGrid.DataSource = db.Orders.ToList();
                _currentTable = db.Orders.GetType();
            }
             if (TablesCB.Text.Equals("Products"))
            {
                HideBTN();
                ProdTypeBTN.Visible = true;
                ProdCountBTN.Visible = true;
                ProductNameTB.Visible = true;
                ProductSaveBTN.Visible = true;
                ProductNameBTN.Visible = true;
                MainGrid.DataSource = db.Products.ToList();
                _currentTable = db.Products.GetType();
            }
             if (TablesCB.Text.Equals("Reception"))
            {
                HideBTN();
                _currentTable = db.Receptions.GetType();
                MainGrid.DataSource = db.Receptions.ToList();
            }
             if (TablesCB.Text.Equals("Cheks"))
            {
                HideBTN();
                ChekFileBTN.Visible = true;
                _currentTable = db.Cheks.GetType();
                MainGrid.DataSource = db.Cheks.ToList();
            }
        }

        private void HideBTN()
        {
            foreach(var item in this.ChangebleCompontents)
			{
				item.Visible = false;
			}
        }

        private void ChangeRecordBTN_Click(object sender, EventArgs e)
        {
			List<Form> changeForm =  new List<Form>();
            if (_currentTable.Equals(db.Orders.GetType()) && !db.Orders.Find(MainGrid.CurrentRow.Cells[0].Value).State)
            {
                AddOrder ChangeOrderForm = new AddOrder(db.Orders.Find(MainGrid.CurrentRow.Cells[0].Value) ,this);
                changeForm.Add(ChangeOrderForm);
				ChangeOrderForm.ShowDialog();
                if (ChangeOrderForm.flag)
                {
					
                    db.Orders.ToList().Find(item => item.Id == (int)MainGrid.CurrentRow.Cells[0].Value).DishID = ChangeOrderForm.DishID;
                    db.Orders.ToList().Find(item => item.Id == (int)MainGrid.CurrentRow.Cells[0].Value).ChefId = ChangeOrderForm.Chef;
                    db.Orders.ToList().Find(item => item.Id == (int)MainGrid.CurrentRow.Cells[0].Value).State = ChangeOrderForm.state;
                }
            }
             if (_currentTable.Equals(db.Chefs.GetType()))
            {
                AddChef ChangeChefForm = new AddChef(db.Chefs.ToList().Find(item => item.Id == (int)MainGrid.CurrentRow.Cells[0].Value));
                changeForm.Add(ChangeChefForm);
				ChangeChefForm.ShowDialog();
                if (ChangeChefForm.flag)
                {
                    db.Chefs.ToList().Find(item => item.Id == (int)MainGrid.CurrentRow.Cells[0].Value).Name = ChangeChefForm.name;
                    db.Chefs.ToList().Find(item => item.Id == (int)MainGrid.CurrentRow.Cells[0].Value).Surname = ChangeChefForm.surname;
                    db.Chefs.ToList().Find(item => item.Id == (int)MainGrid.CurrentRow.Cells[0].Value).Salary = ChangeChefForm.salary;
                    db.Chefs.ToList().Find(item => item.Id == (int)MainGrid.CurrentRow.Cells[0].Value).Birthday = ChangeChefForm.birthday;
                    db.Chefs.ToList().Find(item => item.Id == (int)MainGrid.CurrentRow.Cells[0].Value).Pozition_name = ChangeChefForm.pozition;
                }
            }
             if (_currentTable.Equals(db.Products.GetType()))
            {
                AddProducts ChangeProductForm = new AddProducts(db.Products.ToList().Find(item => item.Id == (int)MainGrid.CurrentRow.Cells[0].Value));
                changeForm.Add(ChangeProductForm);
				ChangeProductForm.ShowDialog();
                if (ChangeProductForm.flag)
                {
                    db.Products.ToList().Find(item => item.Id == (int)MainGrid.CurrentRow.Cells[0].Value).ProductName = ChangeProductForm.ProdName;
                    db.Products.ToList().Find(item => item.Id == (int)MainGrid.CurrentRow.Cells[0].Value).Type = ChangeProductForm.Type;
                    db.Products.ToList().Find(item => item.Id == (int)MainGrid.CurrentRow.Cells[0].Value).Count = ChangeProductForm.Count;
                }
            }
             if (_currentTable.Equals(db.Menu.GetType()))
            {
                AddMenuPoint ChangeMenuPointForm = new AddMenuPoint(db.Menu.ToList().Find(item => item.Id == (int)MainGrid.CurrentRow.Cells[0].Value), this);
                ChangeMenuPointForm.ShowDialog();
                if (ChangeMenuPointForm.flag)
                {
                    db.Menu.ToList().Find(item => item.Id == (int)MainGrid.CurrentRow.Cells[0].Value).DishName = ChangeMenuPointForm.DishName;
                    db.Menu.ToList().Find(item => item.Id == (int)MainGrid.CurrentRow.Cells[0].Value).Cost = ChangeMenuPointForm.Cost;
                    db.Menu.ToList().Find(item => item.Id == (int)MainGrid.CurrentRow.Cells[0].Value).ReceptionID = ChangeMenuPointForm.ReceptionID;
                    db.Menu.ToList().Find(item => item.Id == (int)MainGrid.CurrentRow.Cells[0].Value).WaitingTime_Min = ChangeMenuPointForm.WTime;
                }
            }
             if (_currentTable.Equals(db.Receptions.GetType()))
            {
                int no = Int32.Parse(MainGrid.CurrentRow.Cells[0].Value.ToString());
                AddReception ChangeReceptionForm = new AddReception(
                    db.Receptions.Where
                    (recept => recept.No == no).ToList()
                    , this);
				changeForm.Add(ChangeReceptionForm);
                ChangeReceptionForm.ShowDialog();
                if (ChangeReceptionForm.flag)
                {
                    db.Receptions.RemoveRange(db.Receptions.Where(recept => recept.No == no).ToList());
                    db.SaveChanges();
                    db.Receptions.AddRange(ChangeReceptionForm.ReceptionList);
                }
            }
            if (_currentTable.Equals(db.Cheks.GetType()))
            {
                int no = Int32.Parse(MainGrid.CurrentRow.Cells[0].Value.ToString());
                AddChek ChangeCheckFrom = new AddChek(this, db.Cheks.Where(item => item.Id == no).ToList());
				changeForm.Add(ChangeCheckFrom);
                ChangeCheckFrom.ShowDialog();
                if (ChangeCheckFrom.flag && ChangeCheckFrom.ChekList != null)
                {
                    db.Cheks.AddRange(ChangeCheckFrom.ChekList);
                }
            }
            try
            {
                db.SaveChanges();
				foreach(Form item in changeForm)
				{
					item.Dispose();
				}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Refresh_Grid();
        }

        private void DeleteBTN_Click(object sender, EventArgs e)
        {
            if (_currentTable.Equals(db.Orders.GetType()))
            {
                if (DialogResult.Yes == MessageBox.Show("Удалить выбранный элемент?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation))
                {
                    db.Orders.Remove(db.Orders.ToList().Find(item => item.Id == (int)MainGrid.CurrentRow.Cells[0].Value));
                }
            }
             if (_currentTable.Equals(db.Chefs.GetType()))
            {
                if (DialogResult.Yes == MessageBox.Show("Удалить выбранный элемент?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation))
                {
                    db.Chefs.Remove(db.Chefs.ToList().Find(item => item.Id == (int)MainGrid.CurrentRow.Cells[0].Value));
                }
            }
             if (_currentTable.Equals(db.Products.GetType()))
            {
                if (DialogResult.Yes == MessageBox.Show("Удалить выбранный элемент?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation))
                {
                    db.Products.Remove(db.Products.ToList().Find(item => item.Id == (int)MainGrid.CurrentRow.Cells[0].Value));
                }
            }
             if (_currentTable.Equals(db.Menu.GetType()))
            {
                if (DialogResult.Yes == MessageBox.Show("Удалить выбранный элемент?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation))
                {
                    db.Menu.Remove(db.Menu.ToList().Find(item => item.Id == (int)MainGrid.CurrentRow.Cells[0].Value));
                }
            }
             if (_currentTable.Equals(db.Receptions.GetType()))
            {
                if (DialogResult.Yes == MessageBox.Show("Удалить выбранный элемент?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation))
                {
                    if (DialogResult.Yes == MessageBox.Show("Удалить весь рецепт?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation))
                    {
                        int CurrentReceptionNo = (int)MainGrid.CurrentRow.Cells[0].Value;
                        db.Receptions.RemoveRange(db.Receptions.Where(currecept => currecept.No == CurrentReceptionNo).ToList());
                    }
                    else
                    {
                        int CurrentReceptionNo = (int)MainGrid.CurrentRow.Cells[0].Value;
						int CurrentProductID =  (int)MainGrid.CurrentRow.Cells[1].Value;
                        db.Receptions.Remove(db.Receptions.ToList().Find(item => item.No == CurrentReceptionNo && item.ProductId == CurrentProductID));
                    }
                }
            }
             if (_currentTable.Equals(db.Cheks.GetType()))
            {
                if (DialogResult.Yes == MessageBox.Show("Удалить выбранный элемент?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation))
                {
                    if (DialogResult.Yes == MessageBox.Show("Удалить весь чек?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation))
                    {
                        int CurrentCheckId = (int)MainGrid.CurrentRow.Cells[0].Value;
                        db.Cheks.RemoveRange(db.Cheks.Where(item => item.Id == CurrentCheckId).ToList());
                    }
                    else
                    {
                        int CurrentCheckId = (int)MainGrid.CurrentRow.Cells[0].Value;
						int CurrentOrderId = (int)MainGrid.CurrentRow.Cells[1].Value;
                        db.Cheks.Remove(db.Cheks.ToList().Find(item => item.Id == CurrentCheckId && item.OrderID == CurrentOrderId));
                    }
                }
            }
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Refresh_Grid();
        }

        #region sort_btn

        private void OrdStateBTN_Click(object sender, EventArgs e)
        {
            MainGrid.DataSource = db.Orders.OrderBy(item => item.State).ToList();
        }

        private void MenCostBTN_Click(object sender, EventArgs e)
        {
            MainGrid.DataSource = db.Menu.OrderBy(item => item.Cost).ToList();
        }

        private void MenTimeBTN_Click(object sender, EventArgs e)
        {
            MainGrid.DataSource = db.Menu.OrderBy(item => item.WaitingTime_Min).ToList();
        }
        private void ProdCountBTN_Click(object sender, EventArgs e)
        {
            MainGrid.DataSource = db.Products.OrderBy(item => item.Count).ToList();
        }
        private void ProdTypeBTN_Click(object sender, EventArgs e)
        {
            MainGrid.DataSource = db.Products.OrderBy(item => item.Type.ToLower()).ToList();
        }
        private void ChefSalBTN_Click(object sender, EventArgs e)
        {
            MainGrid.DataSource = db.Chefs.OrderBy(item => item.Salary).ToList();
        }

        private void ChefBirthBTN_Click(object sender, EventArgs e)
        {
            MainGrid.DataSource = db.Chefs.OrderBy(item => item.Birthday.Value).ToList();
        }


        #endregion

        private void PrintCheck(object sender, EventArgs e)
        {
            SaveChek.Filter = "TXT Text|*.txt";
            SaveChek.Title = "Save a Report File";
            SaveChek.ShowDialog();

            if (SaveChek.FileName != "")
            {
                System.IO.StreamWriter fs = new System.IO.StreamWriter(SaveChek.FileName);
                int no = Int32.Parse(MainGrid.CurrentRow.Cells[0].Value.ToString());
                List<Classes.Menu> dishList = new List<Classes.Menu>();
                foreach (var item in db.Cheks.Where(item => item.Id == no).ToList())
                {
                    Orders d = db.Orders.Single(it => it.Id == item.OrderID);
                    dishList.Add(db.Menu.Single(it => it.Id == d.DishID));
                }
                string chen = "Chek No. " + no + "\r\n";
                chen += DateTime.Now + "\r\n\r\n";
                int cost = 0;
                foreach (var item in dishList)
                {
                    chen += item.DishName + "    " + item.Cost.ToString() + "\r\n";
                    cost += item.Cost.Value;
                }
                chen += "\r\n\r\n";
                chen += "Total cost     " + cost;
                fs.Write(chen);
                fs.Close();
            }
        }

        private void MenuDishNameBNT_Click(object sender, EventArgs e)
        {
            MainGrid.DataSource = null;
            MainGrid.Refresh();
            try
            {
                var c = db.Menu.SqlQuery("SELECT * FROM Menu WHERE DishName LIKE '%" + MenuDishNameTB.Text + "%'");
                MainGrid.DataSource = c.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ProductNameBTN_Click(object sender, EventArgs e)
        {
            MainGrid.DataSource = null;
            MainGrid.Refresh();
            try
            {
                var c = db.Products.SqlQuery("SELECT * FROM Products WHERE ProductName LIKE'%" + ProductNameTB.Text + "%'");
                MainGrid.DataSource = c.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #region filter_btn
        private void OrdStateFiltBTN_Click(object sender, EventArgs e)
        {
            if (!_filterFlag)
            {
                MainGrid.DataSource = db.Orders.Where(item => item.State == true).ToList();
                _filterFlag = true;
            }
            else if (_filterFlag)
            {
                MainGrid.DataSource = db.Orders.Where(item => item.State == false).ToList();
                _filterFlag = false;
            }
        }

        private void ChefPozFilterBTN_Click(object sender, EventArgs e)
        {
            if (!ChefPozFilterTB.Text.Equals(string.Empty))
            {
                MainGrid.DataSource = null;
                MainGrid.Refresh();
                try
                {
                    var c = db.Chefs.SqlQuery("SELECT * FROM Chefs WHERE Pozition_name LIKE '%" + ChefPozFilterTB.Text + "%';");
                    MainGrid.DataSource = c.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }



        #endregion

        private void PrintProducts(object sender, EventArgs e)
        {
            SaveProd.Filter = "TXT Text|*.txt";
            SaveProd.Title = "Save a report file";
            SaveProd.ShowDialog();
            if (SaveProd.FileName != "")
            {
                System.IO.StreamWriter fs = new System.IO.StreamWriter(SaveProd.FileName);
                string chen = "Product report \r\n";
                chen += DateTime.Now + "\r\n\r\n";
                foreach (var item in db.Products.ToList())
                {
                    chen += item.ProductName + "    " + item.Type+"    " + item.Count.ToString() + "\r\n";
                }
                fs.Write(chen);
                fs.Close();
            }
        }

        private void PrintChefSalary(object sender, EventArgs e)
        {
            SaveSalaty.Filter = "TXT Text|*.txt";
            SaveSalaty.Title = "Save a report file";
            SaveSalaty.ShowDialog();
            if (SaveSalaty.FileName != "")
            {
                System.IO.StreamWriter fs = new System.IO.StreamWriter(SaveSalaty.FileName);
                int no = Int32.Parse(MainGrid.CurrentRow.Cells[0].Value.ToString());
                Chef curchef = db.Chefs.Single(item => item.Id == no);
                string chen = "Salary check \r\n";
                chen += DateTime.Now + "\r\n\r\n";
                chen += "Bank requisites                          XXXXXXXXxx\r\n";
                chen += "Cafe requisites                          XXXXXXXXxx\r\n";
                chen += "Name                                     " + curchef.Name + "\r\n";
                chen += "Surname                                  " + curchef.Surname + "\r\n";
                chen += "Salary                                   " + curchef.Salary + "\r\n";
                fs.Write(chen);
                fs.Close();
            }
        }

        private void FreeSqlRequestBTN_Click(object sender, EventArgs e)
        {
            SQLForm d = new SQLForm();
            d.Show();
        }

        private void showPrognozToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dictionary<string, decimal> countOfDish = new Dictionary<string, decimal>();
            foreach(var item in db.Menu.ToList())
            {
                decimal? count = null;
                foreach(var c in db.Receptions.Where(tr => tr.No == item.ReceptionID).ToList())
                {
                    decimal z = db.Products.Find(c.ProductId).Count.Value / c.Count;
                    if (Math.Truncate(z) < count || count == null)
                    {
                        count = Math.Truncate(z);
                    }
                }
                countOfDish.Add(item.DishName, count.Value);
            }
            string Prodvig = "it is recommended to offer: \r\n";
            string StopList = "It's in stop list: \r\n";
            foreach (var item in countOfDish)
            {
                if(item.Value >= 30)
                {
                    Prodvig += item.Key + "\r\n";
                }
                if(item.Value <= 5)
                {
                    StopList += item.Key + "\r\n";
                }
            }
            if(Prodvig.Equals("it is recommended to offer: \r\n"))
            {
                Prodvig += "none\r\n";
            }
            if (StopList.Equals("It's in stop list: \r\n"))
            {
                StopList += "none\r\n";
            }
            MessageBox.Show(Prodvig + StopList);

        }

        private void MenuCostFilterBTN_Click(object sender, EventArgs e)
        {
            int cost;
            if(Int32.TryParse(MenuCostFilterTB.Text, out cost))
            {
                try
                {
                    if (MenuCostFilterCB.Text.Equals(">="))
                    {
                        MainGrid.DataSource = db.Menu.Where(item => item.Cost >= cost).ToList();
                    }
                    if (MenuCostFilterCB.Text.Equals("<="))
                    {
                        MainGrid.DataSource = db.Menu.Where(item => item.Cost <= cost).ToList();

                    }
                    if (MenuCostFilterCB.Text.Equals("="))
                    {
                        MainGrid.DataSource = db.Menu.Where(item => item.Cost == cost).ToList();

                    }
                    if (MenuCostFilterCB.Text.Equals("<>"))
                    {
                        MainGrid.DataSource = db.Menu.Where(item => item.Cost != cost).ToList();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void ChefSalaryFilterBTN_Click(object sender, EventArgs e)
        {
            int salary;
            if (Int32.TryParse(ChefSalaryFilterTB.Text, out salary))
            {
                try
                {
                    if (ChefSalaryFilterCB.Text.Equals(">="))
                    {
                        MainGrid.DataSource = db.Chefs.Where(item => item.Salary >= salary).ToList();
                    }
                    if (ChefSalaryFilterCB.Text.Equals("<="))
                    {
                        MainGrid.DataSource = db.Chefs.Where(item => item.Salary <= salary).ToList();

                    }
                    if (ChefSalaryFilterCB.Text.Equals("="))
                    {
                        MainGrid.DataSource = db.Chefs.Where(item => item.Salary == salary).ToList();

                    }
                    if (ChefSalaryFilterCB.Text.Equals("<>"))
                    {
                        MainGrid.DataSource = db.Chefs.Where(item => item.Salary != salary).ToList();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void BTNHighestPriceMenu_Click(object sender, EventArgs e)
        {
            string ConnectionString =  ConfigurationManager.ConnectionStrings["ChefsDB"].ConnectionString;
            var sqlconn = new SqlConnection(ConnectionString);
            sqlconn.Open();
            var oda = new SqlDataAdapter("SELECT MAX(Cost) FROM Menu ;", sqlconn);
            var dt = new DataTable();
            oda.Fill(dt);
            MainGrid.DataSource = dt;
            sqlconn.Close();
        }
        
    }
}
