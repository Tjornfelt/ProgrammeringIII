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
    public partial class FirstTimeSetup : Form
    {
        public string Name { get; set; }

        public FirstTimeSetup()
        {
            InitializeComponent();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            Name = txt_name.Text;
        }
    }
}
