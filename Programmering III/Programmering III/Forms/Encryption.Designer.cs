namespace Programmering_III.Forms
{
    partial class Encryption
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
            this.btn_encrypt = new System.Windows.Forms.Button();
            this.btn_decrypt = new System.Windows.Forms.Button();
            this.txt_textToEncrypt = new System.Windows.Forms.RichTextBox();
            this.txt_encryptedText = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_hashString = new System.Windows.Forms.Button();
            this.txt_hashText = new System.Windows.Forms.TextBox();
            this.btn_validate = new System.Windows.Forms.Button();
            this.txt_hashedValue = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_encrypt
            // 
            this.btn_encrypt.Location = new System.Drawing.Point(6, 6);
            this.btn_encrypt.Name = "btn_encrypt";
            this.btn_encrypt.Size = new System.Drawing.Size(94, 23);
            this.btn_encrypt.TabIndex = 0;
            this.btn_encrypt.Text = "Encrypt";
            this.btn_encrypt.UseVisualStyleBackColor = true;
            this.btn_encrypt.Click += new System.EventHandler(this.btn_encrypt_Click);
            // 
            // btn_decrypt
            // 
            this.btn_decrypt.Location = new System.Drawing.Point(6, 35);
            this.btn_decrypt.Name = "btn_decrypt";
            this.btn_decrypt.Size = new System.Drawing.Size(94, 23);
            this.btn_decrypt.TabIndex = 1;
            this.btn_decrypt.Text = "Decrypt";
            this.btn_decrypt.UseVisualStyleBackColor = true;
            this.btn_decrypt.Click += new System.EventHandler(this.btn_decrypt_Click);
            // 
            // txt_textToEncrypt
            // 
            this.txt_textToEncrypt.Location = new System.Drawing.Point(106, 6);
            this.txt_textToEncrypt.Name = "txt_textToEncrypt";
            this.txt_textToEncrypt.Size = new System.Drawing.Size(174, 114);
            this.txt_textToEncrypt.TabIndex = 2;
            this.txt_textToEncrypt.Text = "";
            // 
            // txt_encryptedText
            // 
            this.txt_encryptedText.Location = new System.Drawing.Point(293, 6);
            this.txt_encryptedText.Name = "txt_encryptedText";
            this.txt_encryptedText.Size = new System.Drawing.Size(183, 114);
            this.txt_encryptedText.TabIndex = 3;
            this.txt_encryptedText.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Text to encrypt / Result shown here";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(332, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "The encrypted text";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(491, 297);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txt_textToEncrypt);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.btn_encrypt);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btn_decrypt);
            this.tabPage1.Controls.Add(this.txt_encryptedText);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(483, 271);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Encryption";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txt_hashedValue);
            this.tabPage2.Controls.Add(this.btn_validate);
            this.tabPage2.Controls.Add(this.txt_hashText);
            this.tabPage2.Controls.Add(this.btn_hashString);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(483, 271);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Hashing";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_hashString
            // 
            this.btn_hashString.Location = new System.Drawing.Point(7, 7);
            this.btn_hashString.Name = "btn_hashString";
            this.btn_hashString.Size = new System.Drawing.Size(75, 23);
            this.btn_hashString.TabIndex = 0;
            this.btn_hashString.Text = "Hash text";
            this.btn_hashString.UseVisualStyleBackColor = true;
            this.btn_hashString.Click += new System.EventHandler(this.btn_hashString_Click);
            // 
            // txt_hashText
            // 
            this.txt_hashText.Location = new System.Drawing.Point(89, 9);
            this.txt_hashText.Name = "txt_hashText";
            this.txt_hashText.Size = new System.Drawing.Size(388, 20);
            this.txt_hashText.TabIndex = 1;
            // 
            // btn_validate
            // 
            this.btn_validate.Location = new System.Drawing.Point(7, 37);
            this.btn_validate.Name = "btn_validate";
            this.btn_validate.Size = new System.Drawing.Size(75, 23);
            this.btn_validate.TabIndex = 2;
            this.btn_validate.Text = "Validate";
            this.btn_validate.UseVisualStyleBackColor = true;
            this.btn_validate.Click += new System.EventHandler(this.btn_validate_Click);
            // 
            // txt_hashedValue
            // 
            this.txt_hashedValue.Location = new System.Drawing.Point(89, 39);
            this.txt_hashedValue.Name = "txt_hashedValue";
            this.txt_hashedValue.Size = new System.Drawing.Size(388, 20);
            this.txt_hashedValue.TabIndex = 3;
            // 
            // Encryption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 321);
            this.Controls.Add(this.tabControl1);
            this.Name = "Encryption";
            this.Text = "Encryption";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_encrypt;
        private System.Windows.Forms.Button btn_decrypt;
        private System.Windows.Forms.RichTextBox txt_textToEncrypt;
        private System.Windows.Forms.RichTextBox txt_encryptedText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txt_hashedValue;
        private System.Windows.Forms.Button btn_validate;
        private System.Windows.Forms.TextBox txt_hashText;
        private System.Windows.Forms.Button btn_hashString;
    }
}