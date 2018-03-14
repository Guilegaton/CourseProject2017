using CourseProject2017.Classes;
using System;
using System.Windows.Forms;

namespace CourseProject2017.Forms
{
    public partial class AddChef : Form
    {
        internal protected string name;
        internal protected string surname;
        internal protected int salary;
        internal protected DateTime birthday;
        internal protected string pozition;
        internal protected bool flag;

        public AddChef() // create new record
        {
            InitializeComponent();
            flag = false;
        }

        public AddChef(Chef CurrentChef) // change the current record
        {
            InitializeComponent();
            NameTB.Text = CurrentChef.Name;
            SurnameTB.Text = CurrentChef.Surname;
            SalaryTB.Text = CurrentChef.Salary.ToString();
            BirthdayTP.Value = CurrentChef.Birthday.Value;
            PozitionTB.Text = CurrentChef.Pozition_name;
            flag = false;
            AddBTN.Text = "Change";
        }

        public AddChef(Chef currentChef, bool point) // see the current chef
        {
            InitializeComponent();
            NameTB.Text = currentChef.Name;
            SurnameTB.Text = currentChef.Surname;
            SalaryTB.Text = currentChef.Salary.ToString();
            BirthdayTP.Value = currentChef.Birthday.Value;
            PozitionTB.Text = currentChef.Pozition_name;
            AddBTN.Visible = false;
            NameTB.ReadOnly = true;
            SurnameTB.ReadOnly = true;
            SalaryTB.ReadOnly = true;
            BirthdayTP.Enabled = false;
            PozitionTB.ReadOnly = true;
        }

        private void AddBTN_Click(object sender, EventArgs e)
        {
            int salr;
            if(!NameTB.Text.Equals(string.Empty) &&
               !SurnameTB.Text.Equals(string.Empty)&&
               !SalaryTB.Text.Equals(string.Empty)&&
               !PozitionTB.Text.Equals(string.Empty)&
               Int32.TryParse(SalaryTB.Text,out salr) &
               salr>0)
            try
            {
                name = NameTB.Text;
                surname = SurnameTB.Text;
                salary = salr;
                birthday = BirthdayTP.Value;
                pozition = PozitionTB.Text;
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
