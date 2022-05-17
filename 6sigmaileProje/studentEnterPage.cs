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

       
    }
}
