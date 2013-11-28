using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programmering_III.Forms
{
    public partial class CodeAccessSecurity : Form
    {
        public CodeAccessSecurity()
        {
            InitializeComponent();
        }

        private void CodeAccessSecurity_Load(object sender, EventArgs e)
        {
            // Add a link to the LinkLabel.
            LinkLabel.Link link = new LinkLabel.Link();
            link.LinkData = "http://www.dotnetperls.com/";
            linkLabel1.Links.Add(link);

            LinkLabel.Link link2 = new LinkLabel.Link();
            link2.LinkData = "http://blogs.msdn.com/b/shawnfa/archive/2009/05/21/security-policy-in-the-v4-clr.aspx";
            linkLabel2.Links.Add(link2);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Send the URL to the operating system.
            Process.Start(e.Link.LinkData as string);
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(e.Link.LinkData as string);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        
    }
}
