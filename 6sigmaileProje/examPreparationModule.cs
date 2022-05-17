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
    public partial class examPreparationModule : Form
    {
        public examPreparationModule()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            
        }
        questionSave questionSave = new questionSave();
        private void btnAddQuestion_Click(object sender, EventArgs e)
        {
            //Sql ile Soruları Kaydetme fonksiyonu
            questionSave.questionSaves(rTextTitleForQuestion, rTextboxImageFilePath, rTextbxMainQuestion, rTextbxAnwerA, rTextbxAnwerB, rTextbxAnwerC, rTextbxAnwerD, rTextbxTrueAnswer);

        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            //seçilen resimin picture box da kontrol edilmesi
            pictureBoxModule.SizeMode = PictureBoxSizeMode.StretchImage;
            openFileDialogModule.ShowDialog();
            pictureBoxModule.ImageLocation = openFileDialogModule.FileName;
            rTextboxImageFilePath.Text = openFileDialogModule.FileName;
        }

        private void examPreparationModule_Load(object sender, EventArgs e)
        {

        }

        

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            Login f1 = new Login();
            f1.Show();
            this.Hide();
        }

        
    }
}
