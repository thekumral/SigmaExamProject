using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using System.Data;
using System.Drawing;

namespace _6sigmaileProje
{
    class questionWrite
    {
        SqlConnection connection = new SqlConnection("Data Source=THEKUMRAL;Initial Catalog=6Sigma;Integrated Security=True");
        
        public void SuccesfulySave()
        {
            MessageBox.Show("Başarıyla Kaydedildi !!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //Sql ile rastgele belirlenen diziye göre formdan alınan bilgiler ile soru yazdırma fonksiyonu
        public void questionsWrite(int[] questionEqueu,int queryNumber,Label questionNumber,Guna.UI2.WinForms.Guna2TextBox titleQuestion,Guna.UI2.WinForms.Guna2TextBox imagePictureBox,Guna.UI2.WinForms.Guna2TextBox mainQuestionSentence,Guna.UI2.WinForms.Guna2TextBox answerA,Guna.UI2.WinForms.Guna2TextBox answerB,Guna.UI2.WinForms.Guna2TextBox answerC,Guna.UI2.WinForms.Guna2TextBox answerD,Label trueAnswer,Guna.UI2.WinForms.Guna2PictureBox picturebox)
            {
            
            connection.Open();
            al:
            SqlCommand command = new SqlCommand("Select * From questions Where questionID like'" + questionEqueu[queryNumber++].ToString()+ "'", connection);
            SqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                if (0.ToString() == read["questionView"].ToString())
                {
                    questionNumber.Text = read["questionID"].ToString();
                    titleQuestion.Text = read["questionTitle"].ToString();
                    if (read["quetionImagePath"].ToString() == "")
                    {
                        picturebox.Visible = false;
                    }
                    else
                    {
                        picturebox.Visible = true;
                        imagePictureBox.Text = read["quetionImagePath"].ToString();
                    }
                    mainQuestionSentence.Text = read["questionMainSentence"].ToString();
                    answerA.Text = read["questionAnswerA"].ToString();
                    answerB.Text = read["questionAnswerB"].ToString();
                    answerC.Text = read["questionAnswerC"].ToString();
                    answerD.Text = read["questionAnswerD"].ToString();
                    trueAnswer.Text = read["questionTrueAnswer"].ToString();
                }
                if (0.ToString() != read["questionView"].ToString())
                {
                    read.Close();
                    goto al;
                }

            }
            connection.Close();
            read.Close();
        }
        }
}
