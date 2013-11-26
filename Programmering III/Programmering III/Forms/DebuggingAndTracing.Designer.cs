namespace Programmering_III.Forms
{
    partial class DebuggingAndTracing
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
            this.btn_nullReference = new System.Windows.Forms.Button();
            this.btn_populateList = new System.Windows.Forms.Button();
            this.btn_newModelInstance = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_nullReference
            // 
            this.btn_nullReference.Location = new System.Drawing.Point(13, 13);
            this.btn_nullReference.Name = "btn_nullReference";
            this.btn_nullReference.Size = new System.Drawing.Size(130, 23);
            this.btn_nullReference.TabIndex = 0;
            this.btn_nullReference.Text = "Loop through the list";
            this.btn_nullReference.UseVisualStyleBackColor = true;
            this.btn_nullReference.Click += new System.EventHandler(this.btn_nullReference_Click);
            // 
            // btn_populateList
            // 
            this.btn_populateList.Location = new System.Drawing.Point(13, 42);
            this.btn_populateList.Name = "btn_populateList";
            this.btn_populateList.Size = new System.Drawing.Size(130, 23);
            this.btn_populateList.TabIndex = 1;
            this.btn_populateList.Text = "Populate the  list";
            this.btn_populateList.UseVisualStyleBackColor = true;
            this.btn_populateList.Click += new System.EventHandler(this.btn_populateList_Click);
            // 
            // btn_newModelInstance
            // 
            this.btn_newModelInstance.Location = new System.Drawing.Point(13, 71);
            this.btn_newModelInstance.Name = "btn_newModelInstance";
            this.btn_newModelInstance.Size = new System.Drawing.Size(130, 23);
            this.btn_newModelInstance.TabIndex = 2;
            this.btn_newModelInstance.Text = "Create new model instance";
            this.btn_newModelInstance.UseVisualStyleBackColor = true;
            this.btn_newModelInstance.Click += new System.EventHandler(this.btn_newModelInstance_Click);
            // 
            // DebuggingAndTracing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 261);
            this.Controls.Add(this.btn_newModelInstance);
            this.Controls.Add(this.btn_populateList);
            this.Controls.Add(this.btn_nullReference);
            this.Name = "DebuggingAndTracing";
            this.Text = "DebuggingAndTracing";
            this.Load += new System.EventHandler(this.DebuggingAndTracing_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_nullReference;
        private System.Windows.Forms.Button btn_populateList;
        private System.Windows.Forms.Button btn_newModelInstance;
    }
}