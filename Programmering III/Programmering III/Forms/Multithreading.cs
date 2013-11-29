using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programmering_III.Forms
{
    public partial class Multithreading : Form
    {
        public Multithreading()
        {
            InitializeComponent();
        }

        #region Worker Process 1
        private void btn_startWorkerProcess1_Click(object sender, EventArgs e)
        {
            if (!workerProcess1.IsBusy)
            {
                rt_workerProcess1.Text = "Counting to 10.000...";
                workerProcess1.RunWorkerAsync();
            }
            else
            {
                MessageBox.Show("The Thread is Busy! Wait until operation completes before trying again.");
            } 
        }

        private void workerProcess1_DoWork(object sender, DoWorkEventArgs e)
        {
            int counter = 0;
            while (counter <= 10000)
            {
                //Remember, reporting the progress to the UI slows everything down to a grinding halt. It it ok for this example, but it would
                //be better to make it only report for instance 10 times, 10% progress each time. Easily done with an if sentence.
                workerProcess1.ReportProgress(counter);
                Thread.Sleep(1); //The reason for the sleep, is to allow other threads to carry out their orders in between, such as updating the UI.
                counter++;
            }
        }

        private void workerProcess1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            int progress = e.ProgressPercentage / 100;
            pBar_workerProcess1.Value = progress;
            rt_workerProcess1.Text = "Counting to 10.000... " + e.ProgressPercentage;
        }
        #endregion

        #region Worker Process 2
        private void btn_startWorkerProcess2_Click(object sender, EventArgs e)
        {
            if (!workerProcess2.IsBusy)
            {
                rt_workerProcess2.Text = "Counting to 10.000";
                workerProcess2.RunWorkerAsync();
            }
            else
            {
                MessageBox.Show("The Thread is Busy! Wait until operation completes before trying again.");
            }
        }

        private void workerProcess2_DoWork(object sender, DoWorkEventArgs e)
        {
            int counter = 0;
            while (counter <= 10000)
            {
                //Remember, reporting the progress to the UI slows everything down to a grinding halt. It it ok for this example, but it would
                //be better to make it only report for instance 10 times, 10% progress each time. Easily done with an if sentence.
                workerProcess2.ReportProgress(counter);
                Thread.Sleep(1); //The reason for the sleep, is to allow other threads to carry out their orders in between, such as updating the UI.
                counter++;
            }
        }

        private void workerProcess2_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            int progress = e.ProgressPercentage / 100;
            pBar_workerProcess2.Value = progress;
            rt_workerProcess2.Text = "Counting to 10.000... " + e.ProgressPercentage;
        }
        #endregion


    }
}
