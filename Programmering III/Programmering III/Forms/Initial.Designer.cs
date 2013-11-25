namespace Programmering_III.Forms
{
    partial class Initial
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_openAssigment4 = new System.Windows.Forms.Button();
            this.btn_isolatedUnit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select an assignment to showcase:";
            // 
            // btn_openAssigment4
            // 
            this.btn_openAssigment4.Location = new System.Drawing.Point(16, 30);
            this.btn_openAssigment4.Name = "btn_openAssigment4";
            this.btn_openAssigment4.Size = new System.Drawing.Size(138, 23);
            this.btn_openAssigment4.TabIndex = 1;
            this.btn_openAssigment4.Text = "4) Multithreading";
            this.btn_openAssigment4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_openAssigment4.UseVisualStyleBackColor = true;
            this.btn_openAssigment4.Click += new System.EventHandler(this.btn_openAssigment4_Click);
            // 
            // btn_isolatedUnit
            // 
            this.btn_isolatedUnit.Location = new System.Drawing.Point(16, 60);
            this.btn_isolatedUnit.Name = "btn_isolatedUnit";
            this.btn_isolatedUnit.Size = new System.Drawing.Size(138, 23);
            this.btn_isolatedUnit.TabIndex = 2;
            this.btn_isolatedUnit.Text = "5) Application Domains";
            this.btn_isolatedUnit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_isolatedUnit.UseVisualStyleBackColor = true;
            this.btn_isolatedUnit.Click += new System.EventHandler(this.btn_isolatedUnit_Click);
            // 
            // Initial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 261);
            this.Controls.Add(this.btn_isolatedUnit);
            this.Controls.Add(this.btn_openAssigment4);
            this.Controls.Add(this.label1);
            this.Name = "Initial";
            this.Text = "Initial";
            this.Load += new System.EventHandler(this.Initial_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_openAssigment4;
        private System.Windows.Forms.Button btn_isolatedUnit;
    }
}