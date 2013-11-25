using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programmering_III.Forms
{
    public partial class ApplicationDomains : Form
    {
        public ApplicationDomains()
        {
            InitializeComponent();

            //Create an application domain upon opening the form
            AppDomain domain = AppDomain.CreateDomain("MyDomain");

            MessageBox.Show("Host domain: " + AppDomain.CurrentDomain.FriendlyName);/*

            Console.WriteLine("Host domain: " + AppDomain.CurrentDomain.FriendlyName);
            Console.WriteLine("child domain: " + domain.FriendlyName);*/
        }
    }
}
