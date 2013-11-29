using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;

namespace Programmering_III.Forms
{
    public partial class ReferenceLibrary : Form
    {
        public ReferenceLibrary()
        {
            InitializeComponent();
        }

        private void btn_doMath_Click(object sender, EventArgs e)
        {
            BusinessLogic.Math m = new BusinessLogic.Math();

            MessageBox.Show("1+1=" + m.AdvancedMath(1, 1).ToString());
        }
    }
}
