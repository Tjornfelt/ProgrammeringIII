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
        AppDomain domain;

        public ApplicationDomains()
        {
            InitializeComponent();

            //Create an application domain upon opening the form
            domain = AppDomain.CreateDomain("MyDomain");
        }

        private void btn_openAssembly_Click(object sender, EventArgs e)
        {
            if (!application1Worker.IsBusy)
            {
                application1Worker.RunWorkerAsync();
            }
        }

        private void btn_openConsoleApplication_Click(object sender, EventArgs e)
        {
            if (!application2Worker.IsBusy)
            {
                application2Worker.RunWorkerAsync();
            }
        }

        private void application1Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            //Run an assembly in the domain created earlier. It doesnt matter which kind of program is executed, as shown by opening "ApplicationDomainsConsole" through the Windows Forms program.
            domain.ExecuteAssembly(@"C:\Users\Mads\Documents\GitHub\ProgrammeringIII\Programmering III\ApplicationDomains\bin\Debug\ApplicationDomains.exe");
        }

        private void application2Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            domain.ExecuteAssembly(@"C:\Users\Mads\Documents\GitHub\ProgrammeringIII\Programmering III\ApplicationDomainsConsole\bin\Debug\ApplicationDomainsConsole.exe");
        }
    }
}
