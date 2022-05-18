using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _6sigmaileProje
{
    public partial class Report : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=THEKUMRAL;Initial Catalog=6Sigma;Integrated Security=True");
        public Report()
        {
            InitializeComponent();
        }
        private void Report_Load(object sender, EventArgs e)
        {
            connection.Open();
            Reportss("Select * From questions");
            connection.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void Reportss(string veriler)
        {
            SqlDataAdapter sqlDa = new SqlDataAdapter(veriler, connection);
            DataSet ds = new DataSet();
            sqlDa.Fill(ds);

            questionDataGrid.DataSource = ds.Tables[0];
            questionDataGrid.Columns[1].Visible = false;
            questionDataGrid.Columns[2].Visible = false;
            questionDataGrid.Columns[3].Visible = false;
            questionDataGrid.Columns[4].Visible = false;
            questionDataGrid.Columns[5].Visible = false;
            questionDataGrid.Columns[6].Visible = false;
            questionDataGrid.Columns[7].Visible = false;
            questionDataGrid.Columns[8].Visible = false;
            questionDataGrid.Columns[10].Visible = false;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            studentEnterPage enterPage = new studentEnterPage();
            enterPage.Show();
            this.Hide();
        }
    }


    
}
