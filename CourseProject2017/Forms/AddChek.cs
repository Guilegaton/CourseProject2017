using CourseProject2017.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace CourseProject2017.Forms
{
    public partial class AddChek : Form
    {
        internal protected List<Chek> ChekList;
        internal protected List<Classes.Menu> ChosenDish;
        internal protected List<Orders> ChosenOrder;
        internal protected bool flag;
        private List<string> _orderInfo;
        private List<string> _orderList;
        List<Classes.Menu> _dish;
        List<Orders> _state;


        public AddChek(MainForm form) // crate new check record
        {
            InitializeComponent();
            if (form.db.Cheks.Count() != 0)
            {
                NoTB.Text = (form.db.Cheks.ToList().Last().Id + 1).ToString();
            }
            else
            {
                NoTB.Text = 1.ToString();
            }
            ChosenDish = new List<Classes.Menu>();
            ChosenOrder = new List<Orders>();
            _orderInfo = new List<string>();
            ChekList = new List<Classes.Chek>();
            _state = new List<Classes.Orders>();
            _dish = new List<Classes.Menu>();
            OrderAndDishInfo(form);
            if (_orderInfo.ToList().Count != 0)
            {
                OrderCB.Items.AddRange(_orderInfo.ToArray());
                OrderCB.SelectedIndex = 0;
            }
            flag = false;
            _orderList = new List<string>();
            
        }

        public AddChek(MainForm form, List<Chek> currentCheck) // change the current check (we can only add new order)
        {
            InitializeComponent();
            _orderInfo = new List<string>();
            _orderList = new List<string>();
            ChosenDish = new List<Classes.Menu>();
            ChosenOrder = new List<Orders>();
            ChekList = new List<Chek>();
            _state = new List<Orders>();
            _dish = new List<Classes.Menu>();
            OrderAndDishInfo(form);
            for (int i = 0; i < _state.Count; i++)
            {
                _orderList.Add(_state[i].Id.ToString() + " '" + _dish[i].DishName + "' " + _dish[i].Cost.ToString());
                CostTB.Text = (Int32.Parse(CostTB.Text) + _dish[i].Cost).ToString();
            }
            NoTB.Text = currentCheck[0].Id.ToString();
            RewriteOrderList();
            OrderCB.Items.AddRange(_orderInfo.ToArray());
            OrderCB.SelectedIndex = 0;
            flag = false;
            AddBTN.Text = "Change";
        }

        private void OrderAndDishInfo(MainForm form)
        {

            _state = form.db.Orders.Where(item => item.State == false).ToList();
            _dish  = new List<Classes.Menu>();
            foreach (var item in _state)
            {
                _dish.Add(form.db.Menu.Single(curdish => curdish.Id == item.DishID));
            }
            for (int i = 0; i < _state.Count; i++)
            {
                _orderInfo.Add(_state[i].Id.ToString() + " '" + _dish[i].DishName + "' " + _dish[i].Cost.ToString());
            }
        }

        private void AddBTN_Click(object sender, EventArgs e)
        {
            flag = true;
            Close();
        }

        private void AddOrderBTN_Click(object sender, EventArgs e)
        {
            if (OrderCB.Items.Count > 0)
            {
                var li = OrderCB.Text.Split(' ');
                string dishname = OrderCB.Text.Split('\'')[1];
                Classes.Menu c = _dish.Where(item =>
                item.DishName.Equals(dishname)).ToList()[0];
                ChosenOrder.Add(_state.Single(item => item.Id == Int32.Parse(li[0])));
                ChosenDish.Add(c);
                ChekList.Add(new Classes.Chek { Id = Int32.Parse(NoTB.Text), OrderID = Int32.Parse(li[0]), Cost = Int32.Parse(li[li.Count() - 1]) });
                _orderList.Add(OrderCB.Text);
                CostTB.Text = (Int32.Parse(CostTB.Text) + Int32.Parse(li[li.Count() - 1])).ToString();
                RewriteOrderList();
                OrderCB.Items.Remove(OrderCB.Text);
                if (OrderCB.Items.Count != 0)
                {
                    OrderCB.SelectedIndex = 0;
                }
               
                
            }
        }

        private void RewriteOrderList()
        {
            OrderListLB.Text = " ";
            foreach (var item in _orderList)
            {
                OrderListLB.Text += item + "; ";
            }
        }

        private void DeleteBTN_Click(object sender, EventArgs e) //remove last added order
        {
            if (ChekList.Count!=0)
            {
                ChosenDish.Remove(ChosenDish.Last());
                ChosenOrder.Remove(ChosenOrder.Last());
                OrderCB.Items.Add(_orderList.Last());
                OrderCB.SelectedIndex = 0;
                CostTB.Text = (Int32.Parse(CostTB.Text) - ChekList.Last().Cost).ToString();
                ChekList.Remove(ChekList.Last());
                _orderList.RemoveAt(_orderList.Count - 1);
                RewriteOrderList();
            }
        }
    }
}
