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
    public partial class Initial : Form
    {
        public Initial()
        {
            InitializeComponent();
        }

        private void Initial_Load(object sender, EventArgs e)
        {

        }

        private void btn_openAssigment4_Click(object sender, EventArgs e)
        {
            Multithreading multiThreading = new Multithreading();

            multiThreading.ShowDialog();
        }

        private void btn_isolatedUnit_Click(object sender, EventArgs e)
        {
            ApplicationDomains applicationDomains = new ApplicationDomains();
            applicationDomains.ShowDialog();
        }
    }
}
