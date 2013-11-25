namespace Programmering_III.Forms
{
    partial class Multithreading
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_startWorkerProcess1 = new System.Windows.Forms.Button();
            this.btn_startWorkerProcess2 = new System.Windows.Forms.Button();
            this.rt_workerProcess1 = new System.Windows.Forms.RichTextBox();
            this.rt_workerProcess2 = new System.Windows.Forms.RichTextBox();
            this.pBar_workerProcess1 = new System.Windows.Forms.ProgressBar();
            this.pBar_workerProcess2 = new System.Windows.Forms.ProgressBar();
            this.workerProcess1 = new System.ComponentModel.BackgroundWorker();
            this.workerProcess2 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // btn_startWorkerProcess1
            // 
            this.btn_startWorkerProcess1.Location = new System.Drawing.Point(13, 13);
            this.btn_startWorkerProcess1.Name = "btn_startWorkerProcess1";
            this.btn_startWorkerProcess1.Size = new System.Drawing.Size(130, 23);
            this.btn_startWorkerProcess1.TabIndex = 0;
            this.btn_startWorkerProcess1.Text = "Start Worker Process 1";
            this.btn_startWorkerProcess1.UseVisualStyleBackColor = true;
            this.btn_startWorkerProcess1.Click += new System.EventHandler(this.btn_startWorkerProcess1_Click);
            // 
            // btn_startWorkerProcess2
            // 
            this.btn_startWorkerProcess2.Location = new System.Drawing.Point(149, 13);
            this.btn_startWorkerProcess2.Name = "btn_startWorkerProcess2";
            this.btn_startWorkerProcess2.Size = new System.Drawing.Size(130, 23);
            this.btn_startWorkerProcess2.TabIndex = 1;
            this.btn_startWorkerProcess2.Text = "Start Worker Process 2";
            this.btn_startWorkerProcess2.UseVisualStyleBackColor = true;
            this.btn_startWorkerProcess2.Click += new System.EventHandler(this.btn_startWorkerProcess2_Click);
            // 
            // rt_workerProcess1
            // 
            this.rt_workerProcess1.Location = new System.Drawing.Point(13, 72);
            this.rt_workerProcess1.Name = "rt_workerProcess1";
            this.rt_workerProcess1.Size = new System.Drawing.Size(130, 177);
            this.rt_workerProcess1.TabIndex = 2;
            this.rt_workerProcess1.Text = "";
            // 
            // rt_workerProcess2
            // 
            this.rt_workerProcess2.Location = new System.Drawing.Point(150, 72);
            this.rt_workerProcess2.Name = "rt_workerProcess2";
            this.rt_workerProcess2.Size = new System.Drawing.Size(129, 177);
            this.rt_workerProcess2.TabIndex = 3;
            this.rt_workerProcess2.Text = "";
            // 
            // pBar_workerProcess1
            // 
            this.pBar_workerProcess1.Location = new System.Drawing.Point(13, 43);
            this.pBar_workerProcess1.Name = "pBar_workerProcess1";
            this.pBar_workerProcess1.Size = new System.Drawing.Size(130, 23);
            this.pBar_workerProcess1.TabIndex = 4;
            // 
            // pBar_workerProcess2
            // 
            this.pBar_workerProcess2.Location = new System.Drawing.Point(150, 43);
            this.pBar_workerProcess2.Name = "pBar_workerProcess2";
            this.pBar_workerProcess2.Size = new System.Drawing.Size(129, 23);
            this.pBar_workerProcess2.TabIndex = 5;
            // 
            // workerProcess1
            // 
            this.workerProcess1.WorkerReportsProgress = true;
            this.workerProcess1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.workerProcess1_DoWork);
            this.workerProcess1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.workerProcess1_ProgressChanged);
            // 
            // workerProcess2
            // 
            this.workerProcess2.WorkerReportsProgress = true;
            this.workerProcess2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.workerProcess2_DoWork);
            this.workerProcess2.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.workerProcess2_ProgressChanged);
            // 
            // Multithreading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 261);
            this.Controls.Add(this.pBar_workerProcess2);
            this.Controls.Add(this.pBar_workerProcess1);
            this.Controls.Add(this.rt_workerProcess2);
            this.Controls.Add(this.rt_workerProcess1);
            this.Controls.Add(this.btn_startWorkerProcess2);
            this.Controls.Add(this.btn_startWorkerProcess1);
            this.Name = "Multithreading";
            this.Text = "Multithreading";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_startWorkerProcess1;
        private System.Windows.Forms.Button btn_startWorkerProcess2;
        private System.Windows.Forms.RichTextBox rt_workerProcess1;
        private System.Windows.Forms.RichTextBox rt_workerProcess2;
        private System.Windows.Forms.ProgressBar pBar_workerProcess1;
        private System.Windows.Forms.ProgressBar pBar_workerProcess2;
        private System.ComponentModel.BackgroundWorker workerProcess1;
        private System.ComponentModel.BackgroundWorker workerProcess2;
    }
}