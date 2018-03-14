using CourseProject2017.Classes;
using CourseProject2017.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using System.Configuration;

namespace CourseProject2017.Forms
{
	public partial class SQLServerSelectionForm : From
	{
		internal protected string connectionString;
		
		public SQLServerSelectionForm()
		{
			InitializeComponent();
		}
		
		private void OkBTN_Click(object sender, EventArgs e)
		{
			connectionString = ServerNameTB.Text;
		}
		
	}
}