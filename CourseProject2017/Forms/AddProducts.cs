using CourseProject2017.Classes;
using System;
using System.Windows.Forms;

namespace CourseProject2017.Forms
{
    public partial class AddProducts : Form
    {
        internal protected string ProdName;
        internal protected decimal Count;
        internal protected string Type;
        internal protected bool flag;

        public AddProducts()
        {
            InitializeComponent();
            flag = false;
        }

        public AddProducts(Products currentProduct)
        {
            InitializeComponent();
            flag = false;
            ProdNameTB.Text = currentProduct.ProductName;
            CountTB.Text = currentProduct.Count.ToString();
            TypeTB.Text = currentProduct.Type;
            AddBTN.Text = "Change";
        }
        public AddProducts(Products currentProduct, bool point)
        {
            InitializeComponent();
            ProdNameTB.Text = currentProduct.ProductName;
            CountTB.Text = currentProduct.Count.ToString();
            TypeTB.Text = currentProduct.Type;
            ProdNameTB.ReadOnly = true;
            CountTB.ReadOnly = true;
            TypeTB.ReadOnly = true;
            AddBTN.Visible = false;
        }

        private void AddBTN_Click(object sender, EventArgs e)
        {
            int cont;
            if (!ProdNameTB.Text.Equals(string.Empty) &&
                !CountTB.Text.Equals(string.Empty) &&
                !TypeTB.Text.Equals(string.Empty) &&
                Int32.TryParse(CountTB.Text, out cont) &
                cont>0)
            {
                try
                {
                    ProdName = ProdNameTB.Text;
                    Count = cont;
                    Type = TypeTB.Text;
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
