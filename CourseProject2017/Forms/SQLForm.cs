using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CourseProject2017.Forms
{
    public partial class SQLForm : Form
    {
        private string ConnectionString;

        public SQLForm()
        {
            InitializeComponent();
            ConnectionString =  ConfigurationManager.ConnectionStrings["ChefsDB"].ConnectionString;
        }

        private void do_sql_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(ConnectionString);
                sqlConnection.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(TestInput.Text, sqlConnection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                resultsDataGridView.DataSource = dataTable;
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error: " + ex.Message);
            }

        }
    }
}
