using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace _6sigmaileProje
{
    class questionCheckControl
    {
        SqlConnection connection = new SqlConnection("Data Source=THEKUMRAL;Initial Catalog=6Sigma;Integrated Security=True");
        public void questionAddTrue(int[] questionEqueu, int queryNumber,Label trueAnswer,Label chooseAnswer)
        {
            int beforeNumber=0;
            int updateNumber=0;
            connection.Open();
            SqlCommand command = new SqlCommand("Select questionNumberOfCorrect From questions Where questionID like'" + questionEqueu[queryNumber].ToString() + "'", connection);
            SqlDataReader read = command.ExecuteReader();
            if (chooseAnswer.Text == trueAnswer.Text)
            {
                while (read.Read())
                {
                    beforeNumber = Convert.ToInt32(read["questionNumberOfCorrect"]);
                    updateNumber=++beforeNumber;
                }
                
            }
            read.Close();

            SqlCommand CommandUpdate = new SqlCommand("Update questions set questionNumberOfCorrect=@a2  Where questionID like'" + questionEqueu[queryNumber].ToString() + "'", connection);
            CommandUpdate.Parameters.AddWithValue("@a2", updateNumber.ToString());
            CommandUpdate.ExecuteNonQuery();
            connection.Close();
        }
        public void AnswerControl(Panel rightChoose,Panel wrongChoose,Label choosingAnswer,Label trueAnswer,Guna.UI2.WinForms.Guna2TextBox txtboxA, Guna.UI2.WinForms.Guna2TextBox txtboxB, Guna.UI2.WinForms.Guna2TextBox txtboxC, Guna.UI2.WinForms.Guna2TextBox txtboxD,Guna.UI2.WinForms.Guna2Panel panelA, Guna.UI2.WinForms.Guna2Panel panelB, Guna.UI2.WinForms.Guna2Panel panelC, Guna.UI2.WinForms.Guna2Panel panelD)
        {
            
            if (choosingAnswer.Text == trueAnswer.Text)
            {
                rightChoose.Visible = true;
                /*panelD.BackColor = System.Drawing.Color.White;
                txtboxD.FillColor = System.Drawing.Color.White;
                panelC.BackColor = System.Drawing.Color.White;
                txtboxC.FillColor = System.Drawing.Color.White;
                panelB.BackColor = System.Drawing.Color.White;
                txtboxB.FillColor = System.Drawing.Color.White;
                panelA.BackColor = System.Drawing.Color.White;
                txtboxA.FillColor = System.Drawing.Color.White;*/

            }
            if (choosingAnswer.Text != trueAnswer.Text)
            {
                wrongChoose.Visible = true;
                //panelD.BackColor = System.Drawing.Color.White;
                //txtboxD.FillColor = System.Drawing.Color.White;
                //panelC.BackColor = System.Drawing.Color.White;
                //txtboxC.FillColor = System.Drawing.Color.White;
                //panelB.BackColor = System.Drawing.Color.White;
                //txtboxB.FillColor = System.Drawing.Color.White;
                //panelA.BackColor = System.Drawing.Color.White;
                //txtboxA.FillColor = System.Drawing.Color.White;
            }
        }
    }

}
