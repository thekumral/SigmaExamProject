using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace _6sigmaileProje
    //Soru kontrol sınıfı 
{
    class questionCheckControl
    {
        SqlConnection connection = new SqlConnection("Data Source=THEKUMRAL;Initial Catalog=6Sigma;Integrated Security=True");
        //Sql den cekilip forma yazdırılan trueAnswer değerini chooseAnswer değeriyle karşılaştırıp doğru sayısını(questionNumberOfCorrect) artırma fonksiyonu
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
            //Sqldeki questionNumberOfCorrect sayisi artırılmış haliyle değiştirilir
            SqlCommand CommandUpdate = new SqlCommand("Update questions set questionNumberOfCorrect=@a2  Where questionID like'" + questionEqueu[queryNumber].ToString() + "'", connection);
            CommandUpdate.Parameters.AddWithValue("@a2", updateNumber.ToString());
            CommandUpdate.ExecuteNonQuery();
            connection.Close();
        }
        //Doğru cevap işaretleyince doğru ve yanlış cevap resimlerinin çıkma fonksiyonu
        public void AnswerControl(Panel rightChoose,Panel wrongChoose,Label choosingAnswer,Label trueAnswer)
        {
            if (choosingAnswer.Text == trueAnswer.Text)
            {
                rightChoose.Visible = true;
            }
            if (choosingAnswer.Text != trueAnswer.Text)
            {
                wrongChoose.Visible = true;
            }
        }
    }

}
