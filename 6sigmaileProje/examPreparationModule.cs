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
        private void guna2Button2_Click(object sender, EventArgs e)
        {

            questionSave.questionSaves(rTextTitleForQuestion, rTextboxImageFilePath, rTextbxMainQuestion, rTextbxAnwerA, rTextbxAnwerB, rTextbxAnwerC, rTextbxAnwerD, rTextbxTrueAnswer);

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            pictureBoxModule.SizeMode = PictureBoxSizeMode.StretchImage;
            openFileDialogModule.ShowDialog();
            pictureBoxModule.ImageLocation = openFileDialogModule.FileName;
            rTextboxImageFilePath.Text = openFileDialogModule.FileName;
        }

        private void examPreparationModule_Load(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            Login f1 = new Login();
            f1.Show();
            this.Hide();
        }
    }
}
