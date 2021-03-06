﻿namespace Programmering_III.Forms
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
            this.btn_resetUserConfig = new System.Windows.Forms.Button();
            this.btn_restart = new System.Windows.Forms.Button();
            this.btn_showStats = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_debug = new System.Windows.Forms.Button();
            this.btn_sendMail = new System.Windows.Forms.Button();
            this.btn_xmlSerialize = new System.Windows.Forms.Button();
            this.btn_encryption = new System.Windows.Forms.Button();
            this.btn_cas = new System.Windows.Forms.Button();
            this.btn_referenceLibrary = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
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
            // btn_resetUserConfig
            // 
            this.btn_resetUserConfig.Location = new System.Drawing.Point(3, 61);
            this.btn_resetUserConfig.Name = "btn_resetUserConfig";
            this.btn_resetUserConfig.Size = new System.Drawing.Size(137, 23);
            this.btn_resetUserConfig.TabIndex = 3;
            this.btn_resetUserConfig.Text = "Reset Config";
            this.btn_resetUserConfig.UseVisualStyleBackColor = true;
            this.btn_resetUserConfig.Click += new System.EventHandler(this.btn_resetUserConfig_Click);
            // 
            // btn_restart
            // 
            this.btn_restart.Location = new System.Drawing.Point(3, 32);
            this.btn_restart.Name = "btn_restart";
            this.btn_restart.Size = new System.Drawing.Size(137, 23);
            this.btn_restart.TabIndex = 4;
            this.btn_restart.Text = "Restart application";
            this.btn_restart.UseVisualStyleBackColor = true;
            this.btn_restart.Click += new System.EventHandler(this.btn_restart_Click);
            // 
            // btn_showStats
            // 
            this.btn_showStats.Location = new System.Drawing.Point(3, 3);
            this.btn_showStats.Name = "btn_showStats";
            this.btn_showStats.Size = new System.Drawing.Size(137, 23);
            this.btn_showStats.TabIndex = 5;
            this.btn_showStats.Text = "Show Stats";
            this.btn_showStats.UseVisualStyleBackColor = true;
            this.btn_showStats.Click += new System.EventHandler(this.btn_showStats_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.btn_showStats);
            this.panel1.Controls.Add(this.btn_resetUserConfig);
            this.panel1.Controls.Add(this.btn_restart);
            this.panel1.Location = new System.Drawing.Point(317, 169);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(143, 87);
            this.panel1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(339, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "7) Config and stats";
            // 
            // btn_debug
            // 
            this.btn_debug.Location = new System.Drawing.Point(16, 90);
            this.btn_debug.Name = "btn_debug";
            this.btn_debug.Size = new System.Drawing.Size(138, 23);
            this.btn_debug.TabIndex = 8;
            this.btn_debug.Text = "9) Debugging and tracing";
            this.btn_debug.UseVisualStyleBackColor = true;
            this.btn_debug.Click += new System.EventHandler(this.btn_debug_Click);
            // 
            // btn_sendMail
            // 
            this.btn_sendMail.Location = new System.Drawing.Point(16, 234);
            this.btn_sendMail.Name = "btn_sendMail";
            this.btn_sendMail.Size = new System.Drawing.Size(138, 23);
            this.btn_sendMail.TabIndex = 9;
            this.btn_sendMail.Text = "16) Send an email";
            this.btn_sendMail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sendMail.UseVisualStyleBackColor = true;
            this.btn_sendMail.Click += new System.EventHandler(this.btn_sendMail_Click);
            // 
            // btn_xmlSerialize
            // 
            this.btn_xmlSerialize.Location = new System.Drawing.Point(16, 119);
            this.btn_xmlSerialize.Name = "btn_xmlSerialize";
            this.btn_xmlSerialize.Size = new System.Drawing.Size(138, 23);
            this.btn_xmlSerialize.TabIndex = 10;
            this.btn_xmlSerialize.Text = "11) XML serialization";
            this.btn_xmlSerialize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_xmlSerialize.UseVisualStyleBackColor = true;
            this.btn_xmlSerialize.Click += new System.EventHandler(this.btn_xmlSerialize_Click);
            // 
            // btn_encryption
            // 
            this.btn_encryption.Location = new System.Drawing.Point(16, 176);
            this.btn_encryption.Name = "btn_encryption";
            this.btn_encryption.Size = new System.Drawing.Size(138, 23);
            this.btn_encryption.TabIndex = 11;
            this.btn_encryption.Text = "14) Encryption";
            this.btn_encryption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_encryption.UseVisualStyleBackColor = true;
            this.btn_encryption.Click += new System.EventHandler(this.btn_encryption_Click);
            // 
            // btn_cas
            // 
            this.btn_cas.Location = new System.Drawing.Point(16, 148);
            this.btn_cas.Name = "btn_cas";
            this.btn_cas.Size = new System.Drawing.Size(138, 23);
            this.btn_cas.TabIndex = 12;
            this.btn_cas.Text = "13) Code Access Security";
            this.btn_cas.UseVisualStyleBackColor = true;
            this.btn_cas.Click += new System.EventHandler(this.btn_cas_Click);
            // 
            // btn_referenceLibrary
            // 
            this.btn_referenceLibrary.Location = new System.Drawing.Point(16, 205);
            this.btn_referenceLibrary.Name = "btn_referenceLibrary";
            this.btn_referenceLibrary.Size = new System.Drawing.Size(138, 23);
            this.btn_referenceLibrary.TabIndex = 13;
            this.btn_referenceLibrary.Text = "15) Reference Library";
            this.btn_referenceLibrary.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_referenceLibrary.UseVisualStyleBackColor = true;
            this.btn_referenceLibrary.Click += new System.EventHandler(this.btn_referenceLibrary_Click);
            // 
            // Initial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 269);
            this.Controls.Add(this.btn_referenceLibrary);
            this.Controls.Add(this.btn_cas);
            this.Controls.Add(this.btn_encryption);
            this.Controls.Add(this.btn_xmlSerialize);
            this.Controls.Add(this.btn_sendMail);
            this.Controls.Add(this.btn_debug);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_isolatedUnit);
            this.Controls.Add(this.btn_openAssigment4);
            this.Controls.Add(this.label1);
            this.Name = "Initial";
            this.Text = "Initial";
            this.Load += new System.EventHandler(this.Initial_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_openAssigment4;
        private System.Windows.Forms.Button btn_isolatedUnit;
        private System.Windows.Forms.Button btn_resetUserConfig;
        private System.Windows.Forms.Button btn_restart;
        private System.Windows.Forms.Button btn_showStats;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_debug;
        private System.Windows.Forms.Button btn_sendMail;
        private System.Windows.Forms.Button btn_xmlSerialize;
        private System.Windows.Forms.Button btn_encryption;
        private System.Windows.Forms.Button btn_cas;
        private System.Windows.Forms.Button btn_referenceLibrary;
    }
}