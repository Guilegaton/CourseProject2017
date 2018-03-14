using CourseProject2017.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace CourseProject2017.Forms
{
    public partial class AddReception : Form
    {
        internal protected List<Reception> ReceptionList;
        internal protected bool flag;
        private List<string> _ProductInfo;
        private List<string> _ChosenIngredient;


        public AddReception(MainForm form)
        {
            InitializeComponent();
            if (form.db.Receptions.Count() != 0)
            {
                NoTB.Text = (form.db.Receptions.ToList().Last().No + 1).ToString();
            }
            else
            {
                NoTB.Text = 1.ToString();
            }
            ReceptionList = new List<Reception>();
            ProductList(form);

            ProdIDCB.DataSource = _ProductInfo;
            flag = false;
        }

        public AddReception(List<Reception> currentReceprion, MainForm form)
        {
            InitializeComponent();
            ProductList(form);
            foreach (var item in currentReceprion)
            {
                _ChosenIngredient.Add(_ProductInfo.ToList().Find(curingr => curingr.Contains(item.ProductId + " ")) + " (" + item.Count.ToString() + "); ");
            }
            RewriteIngr();
            NoTB.Text = currentReceprion[0].No.ToString();
            NoTB.ReadOnly = true;
            ReceptionList = currentReceprion;
            AddBTN.Text = "Change";

            ProdIDCB.DataSource = _ProductInfo;
            flag = false;
        }

        public AddReception(List<Reception> currentReception, MainForm form , bool point)
        {
            InitializeComponent();
            ProductList(form);
            foreach (var item in currentReception)
            {
                _ChosenIngredient.Add(_ProductInfo.ToList().Find(curingr => curingr.Contains(item.ProductId + " ")) + " (" + item.Count.ToString() + "); ");
            }
            
            RewriteIngr();
            NoTB.Text = currentReception[0].No.ToString();
            NoTB.ReadOnly = true;
            ReceptionList = currentReception;
            ProdIDCB.Visible = false;
            AddIngrBTN.Visible = false;
            DeleteBTN.Visible = false;
            CountTB.Visible = false;
            AddBTN.Visible = false;
            CountLB.Visible = false;
            ProdIDLB.Visible = false;
            
            this.Height -= 100;
        }

        private void ProductList(MainForm form)
        {
            _ProductInfo = new List<string>();
            _ChosenIngredient = new List<string>();
            foreach (var item in form.db.Products)
            {
                _ProductInfo.Add(item.Id + " " + item.ProductName);
            }
        }

        private void AddBTN_Click(object sender, EventArgs e)
        {
            flag = true;
            Close();
        }

        private void AddIngrBTN_Click(object sender, EventArgs e)
        {
            NoTB.ReadOnly = true;
            try
            {
                int cont;
                if (!ProdIDCB.Text.Equals(string.Empty) 
                    & !CountTB.Text.Equals(string.Empty) 
                    & !NoTB.Text.Equals(string.Empty)
                    & Int32.TryParse(CountTB.Text, out cont)
                    & cont>0)
                {

                    ReceptionList.Add(new Reception {
                        No = Int32.Parse(NoTB.Text),
                        ProductId = Int32.Parse(ProdIDCB.Text.Split(' ')[0]),
                        Count = Int32.Parse(CountTB.Text) });
                    _ChosenIngredient.Add(ProdIDCB.Text + " (" + CountTB.Text + "); ");
                    RewriteIngr();
                }
                else
                {
                    MessageBox.Show("Change your input");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RewriteIngr()
        {
            IngrListLB.Text = string.Empty;
            foreach (var item in _ChosenIngredient)
            {
                IngrListLB.Text += item;
            }
        }

        private void DeleteBTN_Click(object sender, EventArgs e)
        {
            _ChosenIngredient.RemoveAt(_ChosenIngredient.Count - 1);
            ReceptionList.RemoveAt(ReceptionList.Count - 1);
            RewriteIngr();
        }
    }
}
