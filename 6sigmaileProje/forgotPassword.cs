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
using System.Net.Mail;
using System.Net;

namespace _6sigmaileProje
{
    public partial class forgotPassword : Form
    {
        public forgotPassword()
        {
            InitializeComponent();
        }

        private void forgotPassword_Load(object sender, EventArgs e)
        {

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source = THEKUMRAL; Initial Catalog = 6Sigma; Integrated Security = True");
            connection.Open();
            SqlCommand command = new SqlCommand("select *from users where name='" +
                txtUserName.Text.ToString() + "'and mail='" + txtMail.Text.ToString() +
                "'", connection);

            SqlDataReader reader = command.ExecuteReader();
            
            while (reader.Read())
            {
                try
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                    }
                    SmtpClient smtpserver = new SmtpClient();
                    MailMessage mail = new MailMessage();
                    String date = DateTime.Now.ToLongDateString();
                    String mailadress = ("ruveydakisla34@gmail.com");
                    String password = ("ruveyda32.");
                    String smtpServer = "smtp.gmail.com";
                    String toWho = (reader["mail"].ToString());
                    String subject = ("Password Reminder Email");
                    String write = ("Dear" + reader["name"].ToString() + reader["surname"].ToString() + ",\n" + "you requested a password reminder from us on " + date + "\n" +
                            "password:" + reader["password"].ToString() + "\n" + "Have a good day :)");
                    smtpserver.Credentials = new NetworkCredential(mailadress, password);
                    smtpserver.Port = 587;
                    smtpserver.Host = smtpServer;
                    smtpserver.EnableSsl = true;
                    mail.From = new MailAddress(mailadress);
                    mail.To.Add(toWho);
                    mail.Body = write;
                    mail.Subject = subject;
                    smtpserver.Send(mail);
                    DialogResult dialog = new DialogResult();
                    dialog = MessageBox.Show("The information you entered matches.Your Password has been sent to your e-mail adress.");
                    this.Close();
                }
                catch(Exception error)
                {
                    MessageBox.Show("Mail Sending Error!", error.Message);
                }
                }
        }
    }
}
