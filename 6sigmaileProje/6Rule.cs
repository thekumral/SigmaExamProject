using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace _6sigmaileProje
{
    class _6Rule
    {
        //sigma kuralını uygulama fonksiyonu
        SqlConnection connection = new SqlConnection("Data Source=THEKUMRAL;Initial Catalog=6Sigma;Integrated Security=True");
        //Formdan alınan trueAnswer ve chooseAnswer değerlerini karşılaştırıp sorunun doğru cevaplanma sayısını(questionNumberOfCorrect) artırma 
        //Eğer 6 olursa görüntülenme değerini değiştirir
        public void questionAddTrue(int[] questionEqueu, int queryNumber, Label trueAnswer, Label chooseAnswer)
        {
            int trueAnswerNumber = 0;
            connection.Open();
            SqlCommand command = new SqlCommand("Select questionNumberOfCorrect From questions Where questionID like'" + questionEqueu[queryNumber].ToString() + "'", connection);
            SqlDataReader read = command.ExecuteReader();
            if (chooseAnswer.Text == trueAnswer.Text)
            {
                while (read.Read())
                {
                    trueAnswerNumber = Convert.ToInt32(read["questionNumberOfCorrect"]);
                }
                read.Close();
                if (trueAnswerNumber > 5)
                {
                    SqlCommand CommandUpdate = new SqlCommand("Update questions set questionNumberOfCorrect=@a1,questionView=@a2  Where questionID like'" + questionEqueu[queryNumber].ToString() + "'", connection);
                    CommandUpdate.Parameters.AddWithValue("@a2", 1.ToString());
                    CommandUpdate.Parameters.AddWithValue("@a1", 0.ToString());
                    CommandUpdate.ExecuteNonQuery();
                }
            }
            connection.Close();
            
        }
        }
}
