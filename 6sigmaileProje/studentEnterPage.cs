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
    public partial class studentEnterPage : Form
    {
        public studentEnterPage()
        {
            InitializeComponent();
        }
        private void btnGoExamModule_Click(object sender, EventArgs e)
        {
            examModule exModule = new examModule();
            exModule.Show();
            this.Hide();
        }

       

        private void studentEnterPage_Load(object sender, EventArgs e)
        {

        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            Report reportPage = new Report();
            reportPage.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }
    }
}
