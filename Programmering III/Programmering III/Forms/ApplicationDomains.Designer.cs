namespace Programmering_III.Forms
{
    partial class ApplicationDomains
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
            this.btn_openAssembly = new System.Windows.Forms.Button();
            this.btn_openConsoleApplication = new System.Windows.Forms.Button();
            this.application1Worker = new System.ComponentModel.BackgroundWorker();
            this.application2Worker = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_openAssembly
            // 
            this.btn_openAssembly.Location = new System.Drawing.Point(12, 29);
            this.btn_openAssembly.Name = "btn_openAssembly";
            this.btn_openAssembly.Size = new System.Drawing.Size(259, 23);
            this.btn_openAssembly.TabIndex = 0;
            this.btn_openAssembly.Text = "Open Assembly in this Application Domain";
            this.btn_openAssembly.UseVisualStyleBackColor = true;
            this.btn_openAssembly.Click += new System.EventHandler(this.btn_openAssembly_Click);
            // 
            // btn_openConsoleApplication
            // 
            this.btn_openConsoleApplication.Location = new System.Drawing.Point(277, 29);
            this.btn_openConsoleApplication.Name = "btn_openConsoleApplication";
            this.btn_openConsoleApplication.Size = new System.Drawing.Size(259, 23);
            this.btn_openConsoleApplication.TabIndex = 1;
            this.btn_openConsoleApplication.Text = "Open Console Application";
            this.btn_openConsoleApplication.UseVisualStyleBackColor = true;
            this.btn_openConsoleApplication.Click += new System.EventHandler(this.btn_openConsoleApplication_Click);
            // 
            // application1Worker
            // 
            this.application1Worker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.application1Worker_DoWork);
            // 
            // application2Worker
            // 
            this.application2Worker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.application2Worker_DoWork);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(449, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Open a program within this application domain. Make sure each program runs in a n" +
    "ew thread!";
            // 
            // ApplicationDomains
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 74);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_openConsoleApplication);
            this.Controls.Add(this.btn_openAssembly);
            this.Name = "ApplicationDomains";
            this.Text = "ApplicationDomains";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_openAssembly;
        private System.Windows.Forms.Button btn_openConsoleApplication;
        private System.ComponentModel.BackgroundWorker application1Worker;
        private System.ComponentModel.BackgroundWorker application2Worker;
        private System.Windows.Forms.Label label1;
    }
}