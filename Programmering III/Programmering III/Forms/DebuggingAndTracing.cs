using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Programmering_III.Models;
using System.Diagnostics;

namespace Programmering_III.Forms
{
    public partial class DebuggingAndTracing : Form
    {
        TestModel tm = new TestModel();

        public DebuggingAndTracing()
        {
            InitializeComponent();

            Trace.Listeners.Add(new TextWriterTraceListener("errors.log"));
            Trace.AutoFlush = true;
            
        }

        private void DebuggingAndTracing_Load(object sender, EventArgs e)
        {

        }

        private void btn_nullReference_Click(object sender, EventArgs e)
        {
            //If the list has not been populated, show the stack trace. Everything in the Debug class will be removed when building for release!
            //It is only used in a production environment.
            Debug.Assert(tm.StringList != null);

            try
            {
                foreach (var item in tm.StringList)
                {
                }
            }
            catch (Exception ex)
            {
                //The Trace class will be used in release builds also. It is typically used to create entries in a log file, so a user
                //can more easily report errors.
                Trace.Indent();
                Trace.WriteLine(DateTime.Now.ToShortTimeString());
                Trace.WriteLine(ex, "Debugging And Tracing");
                Trace.Unindent();
            }
        }

        private void btn_newModelInstance_Click(object sender, EventArgs e)
        {
            tm = new TestModel();
        }

        private void btn_populateList_Click(object sender, EventArgs e)
        {
            List<string> lString = new List<string>();

            lString.Add("string1");
            lString.Add("string2");

            tm.StringList = lString;
        }

        
    }
}
