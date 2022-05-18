using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace _6sigmaileProje
{
    class reportWrite
    {

        SqlConnection connection = new SqlConnection("Data Source=THEKUMRAL;Initial Catalog=6Sigma;Integrated Security=True");
        

        public void repPageWrite(DataGridView dataGridView)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("Select * From questions", connection);
            SqlDataAdapter sqlDa = new SqlDataAdapter("Select * from questions",connection);
            _6SigmaDataSet2 ds = new _6SigmaDataSet2();
            
            sqlDa.Fill(ds);
            dataGridView.DataSource = ds.Tables[0];
            connection.Close();
        }
    }
}
