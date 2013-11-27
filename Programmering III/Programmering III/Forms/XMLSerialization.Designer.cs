namespace Programmering_III.Forms
{
    partial class XMLSerialization
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_age = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.btn_serialize = new System.Windows.Forms.Button();
            this.btn_deserialize = new System.Windows.Forms.Button();
            this.rt_deserializedResult = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Age";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(76, 12);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(196, 20);
            this.txt_name.TabIndex = 3;
            // 
            // txt_age
            // 
            this.txt_age.Location = new System.Drawing.Point(76, 38);
            this.txt_age.Name = "txt_age";
            this.txt_age.Size = new System.Drawing.Size(196, 20);
            this.txt_age.TabIndex = 4;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(76, 64);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(196, 20);
            this.txt_email.TabIndex = 5;
            this.txt_email.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // btn_serialize
            // 
            this.btn_serialize.Location = new System.Drawing.Point(76, 90);
            this.btn_serialize.Name = "btn_serialize";
            this.btn_serialize.Size = new System.Drawing.Size(196, 23);
            this.btn_serialize.TabIndex = 6;
            this.btn_serialize.Text = "Serialize Credentials to XML";
            this.btn_serialize.UseVisualStyleBackColor = true;
            this.btn_serialize.Click += new System.EventHandler(this.btn_serialize_Click);
            // 
            // btn_deserialize
            // 
            this.btn_deserialize.Location = new System.Drawing.Point(76, 120);
            this.btn_deserialize.Name = "btn_deserialize";
            this.btn_deserialize.Size = new System.Drawing.Size(196, 23);
            this.btn_deserialize.TabIndex = 7;
            this.btn_deserialize.Text = "Deserialize Credentials";
            this.btn_deserialize.UseVisualStyleBackColor = true;
            this.btn_deserialize.Click += new System.EventHandler(this.btn_deserialize_Click);
            // 
            // rt_deserializedResult
            // 
            this.rt_deserializedResult.Location = new System.Drawing.Point(76, 150);
            this.rt_deserializedResult.Name = "rt_deserializedResult";
            this.rt_deserializedResult.Size = new System.Drawing.Size(195, 96);
            this.rt_deserializedResult.TabIndex = 8;
            this.rt_deserializedResult.Text = "";
            // 
            // XMLSerialization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.rt_deserializedResult);
            this.Controls.Add(this.btn_deserialize);
            this.Controls.Add(this.btn_serialize);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_age);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "XMLSerialization";
            this.Text = "XMLSerialization";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_age;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Button btn_serialize;
        private System.Windows.Forms.Button btn_deserialize;
        private System.Windows.Forms.RichTextBox rt_deserializedResult;
    }
}