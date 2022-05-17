using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace _6sigmaileProje
{
    public partial class examModule : Form
    {
        int[] questionEqueu = new int[20];
        public examModule()
        {
            InitializeComponent();
        }
        questionCheckControl checkControl = new questionCheckControl();
        _6Rule rule6 = new _6Rule();
        questionWrite qWrite = new questionWrite();
        setAQuestion setAQuestion = new setAQuestion();
        private void txtAnswerA_TextChanged(object sender, EventArgs e)
        {

        }

        
        private void btnStart_Click(object sender, EventArgs e)
        {
            int questionEqueueNumber = Convert.ToInt32(lblQuestionEqueNumber.Text);
            //Soru belirleme sınıfından Random olarak bir diziye değer atama fonksiyonu
            setAQuestion.questionSetRandom(questionEqueu);
            //Soru Yazma sınıfından Sql ile yazdırma fonksiyonu
            qWrite.questionsWrite(questionEqueu,questionEqueueNumber,lblQuestionNumber, txtbxTitleQuestion, txtbxImagePath, txtbxMainQuestionSentence, txtAnswerA, txtAnswerB, txtAnswerC, txtAnswerD, lblTureAnswer, pictureBoxExamModule);
           
            pictureBoxExamModule.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxExamModule.ImageLocation = txtbxImagePath.Text;
            
            //lblQuestionEqueNumber.Text = (Convert.ToInt32(lblQuestionEqueNumber.Text) + 1).ToString();
            btnStart.Visible = false;
            timer.Start();
        }

        private void examModule_Load(object sender, EventArgs e)
        {
            
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Login f1 = new Login();
            f1.Show();
            this.Hide();
        }
        private void btnAccept_Click(object sender, EventArgs e)
        {
            int questionEqueueNumber = Convert.ToInt32(lblQuestionEqueNumber.Text);
            //Kontrol sınıfından cevap kontrol fonksiyonu 
            checkControl.AnswerControl(panelRightChoose, panelWrongChoose, lblChooseAnswer, lblTureAnswer);
            //Kontrol sınıfından soru doğruluğunu kontrol etme fonksiyonu
            checkControl.questionAddTrue(questionEqueu,questionEqueueNumber,lblTureAnswer,lblChooseAnswer);
            //Kural sınıfından soruların 6 sigma prensibine göre gelme fonksiyonu 
            rule6.questionAddTrue(questionEqueu, questionEqueueNumber, lblTureAnswer, lblChooseAnswer);
            //Click olayi ile panel renklerini ayarlama fonksiyonu
            panelBackColor();
        }
        private void panelAnswerA_Click(object sender, EventArgs e)
        {
            lblChooseAnswer.Text = "A";
            panelAnswerA.BackColor = Color.Yellow;
        }

        private void panelAnswerB_Click(object sender, EventArgs e)
        {
            lblChooseAnswer.Text = "B";
            panelAnswerB.BackColor = Color.Yellow;
        }

        private void panelAnswerC_Click(object sender, EventArgs e)
        {
            lblChooseAnswer.Text = "C";
            panelAnswerC.BackColor = Color.Yellow;
        }

        private void panelAnswerD_Click(object sender, EventArgs e)
        {
            lblChooseAnswer.Text = "D";
            panelAnswerD.BackColor = Color.Yellow;
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {

            lblQuestionEqueNumber.Text= (Convert.ToInt32(lblQuestionEqueNumber.Text) + 1).ToString();

            int questionEqueueNumber = Convert.ToInt32(lblQuestionEqueNumber.Text);
            finishExam(questionEqueueNumber);
            //Soru yazma sınıfından forma soru yazma fonskiyonu
            qWrite.questionsWrite(questionEqueu,questionEqueueNumber,lblQuestionNumber, txtbxTitleQuestion, txtbxImagePath, txtbxMainQuestionSentence, txtAnswerA, txtAnswerB, txtAnswerC, txtAnswerD, lblTureAnswer, pictureBoxExamModule);
            
            pictureBoxExamModule.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxExamModule.ImageLocation = txtbxImagePath.Text;
            //formda gösterdiğimiz doğru-yanlış cevap image sonraki soruya geçerken kapatma fonksiyonu
            panelShow();
        }
        int minute = 10;
        int second = 60;
        //10 dakika geri sayım fonksiyonu
        private void timer_Tick(object sender, EventArgs e)
        {
            second = second - 1;
            lblSecond.Text = second.ToString();
            lblMinute.Text = "0" + (minute - 1).ToString();
            if (second == 0)
            {
                minute = minute - 1;
                lblMinute.Text = minute.ToString();
                second = 60;
            }
            if (lblMinute.Text == "00" && lblSecond.Text == "1")
            {
                lblSecond.Text = "00";
                timer.Stop();
                MessageBox.Show("Exam Finish");
                studentEnterPage studenEnter = new studentEnterPage();
                studenEnter.Show();
                this.Hide();
            }
        }
        public void panelShow()
        {
            panelRightChoose.Visible = false;
            panelWrongChoose.Visible = false;
        }
        public void panelBackColor()
        {
            panelAnswerA.BackColor = Color.FromArgb(115, 119, 123);
            panelAnswerB.BackColor = Color.FromArgb(115, 119, 123);
            panelAnswerC.BackColor = Color.FromArgb(115, 119, 123);
            panelAnswerD.BackColor = Color.FromArgb(115, 119, 123);

        }
        //sınav bitme fonksiyonu
        public void finishExam(int questionEqueueNumber)
        {
            if (questionEqueueNumber == 18)
            {
                panelExamOver.Visible = true;
                btnGoStudentPage.Visible = true;
                btnAccept.Visible = false;
                btnNextQuestion.Visible = false;
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            studentEnterPage enterPage = new studentEnterPage();
            enterPage.Show();
            this.Hide();
        }
    }
}
