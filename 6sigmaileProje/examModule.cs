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
            //Random olarak bir diziye değer atama fonksiyonu
            setAQuestion.questionSetRandom(questionEqueu);
            qWrite.questionsWrite(questionEqueu,questionEqueueNumber,lblQuestionNumber, txtbxTitleQuestion, txtbxImagePath, txtbxMainQuestionSentence, txtAnswerA, txtAnswerB, txtAnswerC, txtAnswerD, lblTureAnswer, pictureBoxExamModule);
            pictureBoxExamModule.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxExamModule.ImageLocation = txtbxImagePath.Text;
            btnStart.Visible = false;
            lblQuestionEqueNumber.Text = (Convert.ToInt32(lblQuestionEqueNumber.Text) + 1).ToString();
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
            //questionCheckControl checkControl = new questionCheckControl();
            checkControl.AnswerControl(panelRightChoose,panelWrongChoose,lblChooseAnswer,lblTureAnswer,txtAnswerA,txtAnswerB,txtAnswerC,txtAnswerD,panelAnswerA,panelAnswerB,panelAnswerC,panelAnswerD);
            checkControl.questionAddTrue(questionEqueu,questionEqueueNumber,lblTureAnswer,lblChooseAnswer);
            //_6Rule rule6 = new _6Rule();
            rule6.questionAddTrue(questionEqueu, questionEqueueNumber, lblTureAnswer, lblChooseAnswer);
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
            int questionEqueueNumber = Convert.ToInt32(lblQuestionEqueNumber.Text);
            //questionCheckControl qCheckControl = new questionCheckControl();
            //questionWrite qWrite = new questionWrite();
            checkControl.AnswerControl(panelRightChoose, panelWrongChoose, lblChooseAnswer, lblTureAnswer, txtAnswerA, txtAnswerB, txtAnswerC, txtAnswerD, panelAnswerA, panelAnswerB, panelAnswerC, panelAnswerD);
            checkControl.questionAddTrue(questionEqueu, questionEqueueNumber, lblTureAnswer, lblChooseAnswer);
            lblQuestionEqueNumber.Text= (Convert.ToInt32(lblQuestionEqueNumber.Text) + 1).ToString();
            qWrite.questionsWrite(questionEqueu,questionEqueueNumber,lblQuestionNumber, txtbxTitleQuestion, txtbxImagePath, txtbxMainQuestionSentence, txtAnswerA, txtAnswerB, txtAnswerC, txtAnswerD, lblTureAnswer, pictureBoxExamModule);
            pictureBoxExamModule.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxExamModule.ImageLocation = txtbxImagePath.Text;
            panelShow();
        }
        int minute = 10;
        int second = 60;
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
    }
}
