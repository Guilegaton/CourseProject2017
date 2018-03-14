using System;
using System.Configuration;
using System.Windows.Forms;

namespace CourseProject2017.Forms
{
    public partial class SQLServerSelectionForm : Form
    {
        internal string ServerName;

        public SQLServerSelectionForm()
        {
            InitializeComponent();
        }

        private void OkBTN_Click(object sender, EventArgs e)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.ConnectionStrings.ConnectionStrings["ChefsDB"].ConnectionString = "data source="+ServerNameTB.Text +";Initial Catalog=cafedb;Integrated Security=True;";
            config.Save(ConfigurationSaveMode.Modified, true);
            ConfigurationManager.RefreshSection("connectionStrings");
            Close();
        }
    }
}
