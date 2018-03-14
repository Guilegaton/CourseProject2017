using CourseProject2017.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace CourseProject2017
{
    public partial class AddOrder : Form
    {
        internal protected int DishID;
        internal protected int Chef;
        internal protected DateTime time;
        internal protected bool state;
        internal protected bool flag;
        List<string> _ChefInfo;
        List<string> _DishInfo;

        public AddOrder(MainForm form )
        {
            InitializeComponent();
            Inf(form);
            ChefCB.DataSource = _ChefInfo;
            DishNameCB.DataSource = _DishInfo;
        }

        public AddOrder(Orders currentOrder, MainForm form)
        {
            InitializeComponent();
            Inf(form);
            DishNameCB.DataSource = _DishInfo;
            ChefCB.DataSource = _ChefInfo;
            DishNameCB.Text = _DishInfo.ToList().Find(currentDish => currentDish.Contains(currentOrder.DishID.ToString() + " "));
            ChefCB.Text = _ChefInfo.ToList().Find(currentChef => currentChef.Contains(currentOrder.ChefId.ToString() + " "));
            TimePCK.Value = currentOrder.Time.Value;
            TimePCK.Enabled = false;
            AddBTN.Text = "Change";
        }

        public AddOrder(Orders currentOrder, MainForm form, bool point)
        {
            InitializeComponent();
            Inf(form);
            DishNameCB.Items.Add(_DishInfo.Single(item => item.Contains(currentOrder.DishID.ToString() + " ")));
            DishNameCB.SelectedIndex = 0;
            ChefCB.Items.Add(_ChefInfo.Single(item => item.Contains(currentOrder.ChefId.ToString() + " ")));
            ChefCB.SelectedIndex = 0;
            TimePCK.Value = currentOrder.Time.Value;
            TimePCK.Enabled = false;
            AddBTN.Visible = false;
        }

        private void Inf(MainForm t)
        {
            _ChefInfo = new List<string>();
            foreach (var item in t.db.Chefs)
            {
                _ChefInfo.Add(item.Id + " " + item.Name + " " + item.Surname + " " + item.Pozition_name);
            }
            _DishInfo = new List<string>();
            foreach (var item in t.db.Menu)
            {
                _DishInfo.Add(item.Id + " " + item.DishName);
            }
            flag = false;
        }

        private void AddBTN_Click(object sender, EventArgs e)
        {
            
            try
            {
                DishID = Int32.Parse(DishNameCB.Text.Split(' ')[0]);
                Chef = Int32.Parse(ChefCB.Text.Split(' ')[0]);
                time = TimePCK.Value;
                state = false;
                flag = true;
                Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
