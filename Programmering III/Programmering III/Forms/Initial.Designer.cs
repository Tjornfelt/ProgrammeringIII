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
            this.btn_resetUserConfig = new System.Windows.Forms.Button();
            this.btn_restart = new System.Windows.Forms.Button();
            this.btn_showStats = new System.Windows.Forms.Button();
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
            this.btn_resetUserConfig.Location = new System.Drawing.Point(365, 226);
            this.btn_resetUserConfig.Name = "btn_resetUserConfig";
            this.btn_resetUserConfig.Size = new System.Drawing.Size(96, 23);
            this.btn_resetUserConfig.TabIndex = 3;
            this.btn_resetUserConfig.Text = "Reset Config";
            this.btn_resetUserConfig.UseVisualStyleBackColor = true;
            this.btn_resetUserConfig.Click += new System.EventHandler(this.btn_resetUserConfig_Click);
            // 
            // btn_restart
            // 
            this.btn_restart.Location = new System.Drawing.Point(249, 226);
            this.btn_restart.Name = "btn_restart";
            this.btn_restart.Size = new System.Drawing.Size(110, 23);
            this.btn_restart.TabIndex = 4;
            this.btn_restart.Text = "Restart application";
            this.btn_restart.UseVisualStyleBackColor = true;
            this.btn_restart.Click += new System.EventHandler(this.btn_restart_Click);
            // 
            // btn_showStats
            // 
            this.btn_showStats.Location = new System.Drawing.Point(106, 226);
            this.btn_showStats.Name = "btn_showStats";
            this.btn_showStats.Size = new System.Drawing.Size(137, 23);
            this.btn_showStats.TabIndex = 5;
            this.btn_showStats.Text = "Show Stats";
            this.btn_showStats.UseVisualStyleBackColor = true;
            this.btn_showStats.Click += new System.EventHandler(this.btn_showStats_Click);
            // 
            // Initial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 261);
            this.Controls.Add(this.btn_showStats);
            this.Controls.Add(this.btn_restart);
            this.Controls.Add(this.btn_resetUserConfig);
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
        private System.Windows.Forms.Button btn_resetUserConfig;
        private System.Windows.Forms.Button btn_restart;
        private System.Windows.Forms.Button btn_showStats;
    }
}