using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace _6sigmaileProje
{
    
    class UserControl
    {
        SqlConnection sqlConnection = new SqlConnection("Data Source=THEKUMRAL;Initial Catalog=6Sigma;Integrated Security=True");
        SqlCommand sqlCommand;
        SqlDataReader reader;
        public SqlDataReader user(Guna.UI2.WinForms.Guna2TextBox userName, Guna.UI2.WinForms.Guna2TextBox password)
        {
            sqlConnection.Open();
            sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText = "select*from users where name='" + userName.Text + "'";
            reader = sqlCommand.ExecuteReader();
            if (reader.Read() == true)
            {
                if (password.Text == reader["password"].ToString())
                {
                    if (reader["userTypeID"].ToString()=="1")
                    {
                        examPreparationModule expreModule = new examPreparationModule();
                        expreModule.Show();
                    }
                    else if (reader["userTypeID"].ToString()=="2")
                    {
                        studentEnterPage enterStudent = new studentEnterPage();
                        enterStudent.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Şifrenizi kontrol ediniz", "Hata1",MessageBoxButtons.OK);
                    Login log = new Login();
                    log.Show();

                }
            }
            else
            {
                MessageBox.Show("Bilgilerinizi konrol ediniz ", "Hata2");
                Login log = new Login();
                log.Show();
            }
            sqlConnection.Close();
            return reader;

        }
    }
}
