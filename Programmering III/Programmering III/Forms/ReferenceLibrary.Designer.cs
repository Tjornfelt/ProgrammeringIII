namespace Programmering_III.Forms
{
    partial class ReferenceLibrary
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
            this.btn_doMath = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_doMath
            // 
            this.btn_doMath.Location = new System.Drawing.Point(13, 13);
            this.btn_doMath.Name = "btn_doMath";
            this.btn_doMath.Size = new System.Drawing.Size(259, 23);
            this.btn_doMath.TabIndex = 0;
            this.btn_doMath.Text = "Do Math!";
            this.btn_doMath.UseVisualStyleBackColor = true;
            this.btn_doMath.Click += new System.EventHandler(this.btn_doMath_Click);
            // 
            // ReferenceLibrary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 54);
            this.Controls.Add(this.btn_doMath);
            this.Name = "ReferenceLibrary";
            this.Text = "ReferenceLibrary";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_doMath;
    }
}