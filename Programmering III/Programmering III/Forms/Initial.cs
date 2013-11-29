using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Programmering_III.Helpers;

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
            string firstTimeSetup = ConfigHelpers.ReadConfig("FirstTimeSetup", ConfigHelpers.GetConfigFile());

            if (firstTimeSetup == "0")
            {
                FirstTimeSetup fts = new FirstTimeSetup();

                DialogResult dResult = fts.ShowDialog();

                if (DialogResult.OK == dResult)
                {
                    ConfigHelpers.UpdateConfig("UserName", fts.Name, ConfigHelpers.GetConfigFile());
                    ConfigHelpers.UpdateConfig("FirstTimeSetup", "1", ConfigHelpers.GetConfigFile());
                    firstTimeSetup = ConfigHelpers.ReadConfig("FirstTimeSetup", ConfigHelpers.GetConfigFile());
                }
                else
                {
                    MessageBox.Show("First Time Setup not completed! Restart the program to try again.");
                }
            }

            if (firstTimeSetup == "1")
            {
                this.Text = "Welcome, " + ConfigHelpers.ReadConfig("UserName", ConfigHelpers.GetConfigFile());
            }
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

        private void btn_resetUserConfig_Click(object sender, EventArgs e)
        {
            ConfigHelpers.UpdateConfig("FirstTimeSetup", "0", ConfigHelpers.GetConfigFile());
            ConfigHelpers.UpdateConfig("NumberOfRestarts", "0", ConfigHelpers.GetConfigFile());
        }

        private void btn_restart_Click(object sender, EventArgs e)
        {
            var numberOfRestarts = Convert.ToInt32(ConfigHelpers.ReadConfig("NumberOfRestarts", ConfigHelpers.GetConfigFile()));
            ConfigHelpers.UpdateConfig("NumberOfRestarts", (numberOfRestarts + 1).ToString(), ConfigHelpers.GetConfigFile());
            Application.Restart();
        }

        private void btn_showStats_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Number of restarts: " + ConfigHelpers.ReadConfig("NumberOfRestarts", ConfigHelpers.GetConfigFile()));
        }

        private void btn_debug_Click(object sender, EventArgs e)
        {
            DebuggingAndTracing dat = new DebuggingAndTracing();

            dat.ShowDialog();
        }

        private void btn_sendMail_Click(object sender, EventArgs e)
        {
            SendEmail se = new SendEmail();

            se.ShowDialog();
        }

        private void btn_xmlSerialize_Click(object sender, EventArgs e)
        {
            XMLSerialization xmls = new XMLSerialization();

            xmls.ShowDialog();
        }

        private void btn_encryption_Click(object sender, EventArgs e)
        {
            Encryption enc = new Encryption();
            enc.ShowDialog();
        }

        private void btn_cas_Click(object sender, EventArgs e)
        {
            CodeAccessSecurity cas = new CodeAccessSecurity();

            cas.ShowDialog();
        }

        private void btn_referenceLibrary_Click(object sender, EventArgs e)
        {
            ReferenceLibrary refl = new ReferenceLibrary();

            refl.ShowDialog();
        }
    }
}
