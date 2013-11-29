using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programmering_III.Forms
{
    public partial class SendEmail : Form
    {
        public SendEmail()
        {
            InitializeComponent();
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            string name = txt_name.Text;
            string email = txt_email.Text;
            string message = txt_message.Text;

            string fromAddress = "madstjornfelt@gmail.com";
            string fromName = "Mads";

            string toAddress = "madstjornfelt@gmail.com";
            string toName = "Mads";

            //Define a "to" address
            MailAddress to = new MailAddress(toAddress, toName);

            //Define a "from" address
            MailAddress from = new MailAddress(fromAddress, fromName);

            //Create the mail object
            MailMessage mail = new MailMessage(from, to);

            //Mail subject
            mail.Subject = "Programmering III Test Email";

            //Allow HTML
            mail.IsBodyHtml = true;

            //Mail bodytext
            mail.Body = message;

            //Configure SMTP server
            SmtpClient smtp = new SmtpClient();

            smtp.UseDefaultCredentials = false;
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;

            smtp.Credentials = new NetworkCredential("madstjornfelt@gmail.com", "");
            smtp.EnableSsl = true;

            //Send the mail
            smtp.Send(mail);
        }
    }
}
