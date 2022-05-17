using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace _6sigmaileProje
{
    public partial class SignIn : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=THEKUMRAL;Initial Catalog=6Sigma;Integrated Security=True");
        public void SuccesfulySave()
        {
            MessageBox.Show("Başarıyla Kaydedildi !!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //kullanısı kayıt fonksiyonu
        public void saveUser()
        {
            conn.Open();
            SqlCommand command = new SqlCommand("insert into users (userName,password,name,surname,mail) values (@userName,@password,@name,@surname,@mail)", conn);
            command.Parameters.AddWithValue("@userName",txtUserName.Text );
            command.Parameters.AddWithValue("@password", txtPassword.Text);
            command.Parameters.AddWithValue("@name", txtName.Text);
            command.Parameters.AddWithValue("@surname", txtSurname.Text);
            command.Parameters.AddWithValue("@mail", txtMail.Text);
            command.ExecuteNonQuery();
            conn.Close();
            
        }
        
        public SignIn()
        {
            InitializeComponent();
        }

        

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            saveUser();
            SuccesfulySave();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        
    }
}
