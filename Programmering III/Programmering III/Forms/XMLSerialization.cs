using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Programmering_III.Helpers;
using Programmering_III.Models;

namespace Programmering_III.Forms
{
    public partial class XMLSerialization : Form
    {
        public XMLSerialization()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_serialize_Click(object sender, EventArgs e)
        {
            string name = txt_name.Text;
            string age = txt_age.Text;
            string email = txt_email.Text;

            Credentials c = new Credentials() {
                Name = name,
                Age = age,
                Email = email
            };

            XMLHelpers.SaveCredentialsAsXml(c);
        }

        private void btn_deserialize_Click(object sender, EventArgs e)
        {
            Credentials c = XMLHelpers.ReadCredentialsFromXml();

            rt_deserializedResult.Text = string.Empty;
            rt_deserializedResult.Text = "Name: " + c.Name + Environment.NewLine + "Age: " + c.Age + Environment.NewLine + "Email: " + c.Email;
        }
    }
}