using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Programmering_III.Helpers;

namespace Programmering_III.Forms
{
    public partial class Encryption : Form
    {
        string encryptedString;
        string decryptedString;

        string hashTextInput;

        public Encryption()
        {
            InitializeComponent();
        }

        private void btn_encrypt_Click(object sender, EventArgs e)
        {
            EncryptKeyDialog ekd = new EncryptKeyDialog();
            DialogResult dResult = ekd.ShowDialog();

            if (DialogResult.OK == dResult)
            {
                encryptedString = EncryptionHelpers.Encrypt(txt_textToEncrypt.Text, ekd.Password);
                txt_encryptedText.Text = encryptedString;
            }
        }

        private void btn_decrypt_Click(object sender, EventArgs e)
        {
            EncryptKeyDialog ekd = new EncryptKeyDialog();
            DialogResult dResult = ekd.ShowDialog();

            if (DialogResult.OK == dResult)
            {
                decryptedString = EncryptionHelpers.Decrypt(txt_encryptedText.Text, ekd.Password);
                txt_textToEncrypt.Text = decryptedString;
            }
        }

        private void btn_hashString_Click(object sender, EventArgs e)
        {
            hashTextInput = txt_hashText.Text;

            //Do a one-way hash of the text. We can never recover the text again. We can however compare hashed values against eachother, 
            //and thereby verify for instance a user password.
            txt_hashedValue.Text = EncryptionHelpers.GetMD5HashData(hashTextInput);
        }

        private void btn_validate_Click(object sender, EventArgs e)
        {
            //Generate a hash from the textbox to compare to the original hash.
            string validateHash = EncryptionHelpers.GetMD5HashData(txt_hashText.Text);

            if (validateHash == txt_hashedValue.Text)
            {
                MessageBox.Show("You guessed the sentence!");
            }
        }
    }
}
