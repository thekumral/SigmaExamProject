using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace _6sigmaileProje
{
    class questionSave
    {
        public void SuccesfulySave()
        {
            MessageBox.Show("Başarılı !!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //Formdan alınan soru bilgilerini Sql'e kayıt fonksiyonu 
        public void questionSaves(RichTextBox titleQuestion,RichTextBox imagePath,RichTextBox mainQuestionSentence ,  RichTextBox answerA, RichTextBox answerB,RichTextBox answerC,RichTextBox answerD,RichTextBox rTextBoxTrueAnswer)
        {
            SqlConnection connection = new SqlConnection("Data Source=THEKUMRAL;Initial Catalog=6Sigma;Integrated Security=True");
            SqlCommand command;
            examPreparationModule expremodule = new examPreparationModule();
            connection.Open();
            command = new SqlCommand();
            command.Connection = connection;
            command.CommandText= "insert into questions values('"+titleQuestion.Text+ "','" + imagePath.Text + "','" + mainQuestionSentence.Text + "','" +answerA.Text+"','"+answerB.Text+"','"+answerC.Text+"','"+answerD.Text+"','"+ rTextBoxTrueAnswer.Text+ "','" + 0 + "')";
            command.ExecuteNonQuery();
            connection.Close();
            SuccesfulySave();
        }
    }
}
