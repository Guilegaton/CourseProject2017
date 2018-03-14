using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CourseProject2017.Forms
{
    public partial class AddMenuPoint : Form
    {
        internal protected string DishName;
        internal protected int ReceptionID;
        internal protected int Cost;
        internal protected int WTime;
        internal protected bool flag;
        List<string> _ReceptionInfo;

        public AddMenuPoint(MainForm form)
        {
            InitializeComponent();
            ReceptPoint(form);
            ReceptionCB.DataSource = _ReceptionInfo;
            flag = false;
        }

        public AddMenuPoint(Classes.Menu currentMenuPosition , MainForm form)
        {
            InitializeComponent();
            ReceptPoint(form);
            AddBTN.Text = "Change";
            ReceptionCB.Items.AddRange(_ReceptionInfo.ToArray());
            DishNameTB.Text = currentMenuPosition.DishName;
            ReceptionCB.SelectedIndex = _ReceptionInfo.IndexOf(_ReceptionInfo.Single(item=> item.Contains(currentMenuPosition.ReceptionID.ToString() + " ")));
            CostTB.Text = currentMenuPosition.Cost.ToString();
            WTimeTB.Text = currentMenuPosition.WaitingTime_Min.ToString();
            flag = false;
        }
        public AddMenuPoint(Classes.Menu currentMenuPosition, MainForm form, bool point)
        {
            InitializeComponent();
            ReceptPoint(form);
            DishNameTB.Text = currentMenuPosition.DishName;
            ReceptionCB.Items.Add(_ReceptionInfo.Single(item => item.Contains(currentMenuPosition.ReceptionID.ToString() + " ")));
            ReceptionCB.SelectedIndex = 0;
            CostTB.Text = currentMenuPosition.Cost.ToString();
            WTimeTB.Text = currentMenuPosition.WaitingTime_Min.ToString();
            DishNameTB.ReadOnly = true;
            CostTB.ReadOnly = true;
            WTimeTB.ReadOnly = true;
            AddBTN.Visible = false;
        }

        private void ReceptPoint(MainForm form)
        {
            flag = false;
            _ReceptionInfo = new List<string>();
            var lis = form.db.Products.ToList();
            int? no = null;
            foreach (var item in form.db.Receptions)
            {
                foreach (var z in lis)
                {
                    if (item.No != no && z.Id == item.ProductId)
                    {
                        _ReceptionInfo.Add(item.No + " " + z.ProductName + " ");
                        no = item.No;
                    }
                    else if (item.No == no && z.Id==item.ProductId)
                    {
                        _ReceptionInfo[_ReceptionInfo.Count - 1] += z.ProductName + " ";
                    }
                }
            }
        }

        private void AddBTN_Click(object sender, EventArgs e)
        {
            int cont;
            int tem;
            if (!DishNameTB.Text.Equals(string.Empty) &&
                !CostTB.Text.Equals(string.Empty) &&
                !WTimeTB.Text.Equals(string.Empty) &&
                Int32.TryParse(CostTB.Text, out cont) &
                Int32.TryParse(WTimeTB.Text, out tem) &
                tem > 0 &
                cont > 0)
            {
                try
                {
                    DishName = DishNameTB.Text;
                    ReceptionID = Int32.Parse(ReceptionCB.Text.Split(' ')[0]);
                    Cost = cont;
                    WTime = tem;
                    flag = true;
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
