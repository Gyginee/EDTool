
using System.Security.Cryptography;
using System.Text;

namespace Encrypt_Decrypt

{
    public partial class tool_form : Form
    {
        bool status;
        public tool_form()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void ComboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void elist_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = elist.Items[elist.SelectedIndex].ToString();
            if (!status)
            {
                switch (selectedItem)
                {
                    case "Ceasar":
                        optionLabel.Text = "Option (Disable)";
                        option_text.Enabled = false;
                        keyLabel.Text = "Key";
                        decrypt_text.Text = "";
                        break;

                    case "Transposition":
                        option_text.Enabled = true;
                        optionLabel.Text = "Character";
                        keyLabel.Text = "Key";
                        decrypt_text.Text = "";
                        break;
                    case "Affine":
                        option_text.Enabled = true;
                        optionLabel.Text = "A";
                        keyLabel.Text = "B";
                        decrypt_text.Text = "";
                        break;
                    case "Vigenere":
                        optionLabel.Text = "Option (Disable)";
                        option_text.Enabled = false;
                        keyLabel.Text = "Key";
                        decrypt_text.Text = "";
                        break;
                    case "Hill":
                        optionLabel.Text = "Option (Disable)";
                        option_text.Enabled = false;
                        decrypt_text.Text = "";
                        break;
                    case "RSA":
                        decrypt_text.Text = "";
                        optionLabel.Text = "Option (Disable)";
                        option_text.Enabled = false;
                        break;
                }
            }
            else if (status)
            {
                switch (selectedItem)
                {
                    case "Ceasar":
                        optionLabel.Text = "Option (Disable)";
                        option_text.Enabled = false;
                        keyLabel.Text = "Key";
                        decrypt_text.Text = "";
                        break;

                    case "Transposition":
                        option_text.Enabled = false;
                        optionLabel.Text = "Character (Disable)";
                        keyLabel.Text = "Key";
                        decrypt_text.Text = "";
                        break;
                    case "Affine":
                        option_text.Enabled = true;
                        optionLabel.Text = "A";
                        keyLabel.Text = "B";
                        decrypt_text.Text = "";
                        break;
                    case "Vigenere":
                        optionLabel.Text = "Option (Disable)";
                        option_text.Enabled = false;
                        decrypt_text.Text = "";
                        keyLabel.Text = "Key";
                        break;
                    case "Hill":
                        MessageBox.Show("Update soon :)))", "UPDATE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        option_text.Enabled = false;
                        decrypt_text.Text = "";
                        break;
                       case "RSA":
                        optionLabel.Text = "Option (Disable)";
                        option_text.Enabled = false;
                        decrypt_text.Text = "";
                        keyLabel.Text = "Option (Disable)";
                        break;

                }
            }
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void tool_form_Load(object sender, EventArgs e)
        {

        }
        private void key_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            
            string encrypt;
            string encryptText = encrypt_text.Text;
            decrypt_text.Text = "";
            int val, val2;
            string keyString;
            keyString = key_text.Text;
            string option = option_text.Text, selectedItem;
            char pchar;
            char[] pcharstr;
            bool result, result2;
            selectedItem = elist.Items[elist.SelectedIndex].ToString();
            UnicodeEncoding ByteConverter = new UnicodeEncoding();
            RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();

            if (encryptText == null)
            {
                MessageBox.Show("Encrypt textbox cannot empty", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!status) {
                switch (selectedItem) {
                    
                case "Ceasar":
                    result = int.TryParse(key_text.Text, out val);
                    if (!result)
                    {
                        MessageBox.Show("Wrong Key, Key must integer!!!","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                        return;
                    }
                    encrypt = Ceasar.Encipher(encryptText, val);
                    decrypt_text.AppendText(encrypt);
                    break;
                case "Transposition":

                    if (option == null || option == "" || (char.Parse(option) == null))
                    {
                        MessageBox.Show("Wrong Char!!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (keyString == "")
                    {
                        MessageBox.Show("Null Key!!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    pchar = char.Parse(option);
                    encrypt = Transposition.Encipher(encryptText, keyString, pchar);
                    decrypt_text.AppendText(encrypt);
                    break;
                case "Affine":
                    if (option == null || keyString == null || option == "" || keyString == "")
                    {
                        MessageBox.Show("Missing A or B!!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    result = int.TryParse(key_text.Text, out val);
                    result2 = int.TryParse(option_text.Text, out val2);

                    if (!result || !result2)
                    {
                        MessageBox.Show("Wrong A or B, it must integer!!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    pcharstr = encrypt_text.Text.ToLower().ToCharArray();
                    encrypt = Affine.Encipher(pcharstr, val2, val);
                    decrypt_text.AppendText(encrypt);
                    break;
                case "Vigenere":
                    encrypt = Vigenere.Encipher(encryptText, keyString);
                    decrypt_text.AppendText(encrypt);
                    break;
                case "Hill":
                    encrypt = Hill.Encipher(encryptText, keyString);
                    decrypt_text.AppendText(encrypt);
                    break;
                case "RSA":
                    encrypt = rsa.Encryption(encryptText);
                    decrypt_text.AppendText(encrypt);
                    break;
                }
            }
            else if (status)
            {

                switch (selectedItem)
                {
                    case "Ceasar":
                        result = int.TryParse(key_text.Text, out val);
                        if (!result)
                        {
                            MessageBox.Show("Wrong Key, Key must integer!!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        encrypt = Ceasar.Decipher(encryptText, val);
                        decrypt_text.AppendText(encrypt);
                        break;
                    case "Transposition":
                    
                        if (keyString == "")
                        {
                            MessageBox.Show("Null Key!!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        pchar = char.Parse(option);
                        encrypt = Transposition.Decipher(encryptText, keyString);
                        decrypt_text.AppendText(encrypt);
                        break;
                        //AFFINE
                    case "Affine":
                        if (option == null || keyString == null || option == "" || keyString == "")
                        {
                            MessageBox.Show("Missing A or B!!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        result = int.TryParse(key_text.Text, out val);
                        result2 = int.TryParse(option_text.Text, out val2);

                        if (!result || !result2)
                        {
                            MessageBox.Show("Wrong A or B, it must integer!!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        
                        pcharstr = encrypt_text.Text.ToLower().ToCharArray();
                        encrypt = Affine.Decipher(pcharstr, val2, val);
                        decrypt_text.AppendText(encrypt);
                        break;
                        //VIGENERE
                    case "Vigenere":
                        
                        encrypt = Vigenere.Decipher(encryptText, keyString);
                        decrypt_text.AppendText(encrypt);
                        break;
                    case "Hill":
                        MessageBox.Show(selectedItem);
                        break;
                    case "RSA":

                        encrypt = rsa.Decryption(encryptText);

                        decrypt_text.AppendText(encrypt);
                        break;
                }
            }
        }
        private void label4_Click_1(object sender, EventArgs e)
        {

        }
        private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            encrypt_text.Text = "";
            decrypt_text.Text = "";

            if (!status)
            {
                status = true;
                label1.Text = "Decrypt Text";
                label1.ForeColor = Color.DeepPink;
                label2.Text = "Encrypt Text";
                label2.ForeColor = Color.DodgerBlue;
                encrypt_btn.Text = "DECRYPT";
                mode_label.Text = "DECRYPT MODE";
                mode_label.ForeColor = Color.DeepPink;
            }
            else if (status)
            {
                status = false;
                label2.Text = "Decrypt Text";
                label2.ForeColor = Color.DeepPink;
                label1.Text = "Encrypt Text";
                label1.ForeColor = Color.DodgerBlue;
                encrypt_btn.Text = "ENCRYPT";
                mode_label.Text = "ENCRYPT MODE";
                mode_label.ForeColor = Color.DodgerBlue;

            }
        }
        private void import_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.InitialDirectory = "C:\\";
            file.Filter = "Text File (*.txt)|*.txt";
            file.FilterIndex = 0;
            file.RestoreDirectory = true;
            if (file.ShowDialog() == DialogResult.OK)
            {
                string fileName = file.FileName;
                string text = System.IO.File.ReadAllText(fileName);
                encrypt_text.Text = text;
            }
        }
        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            option_text.Text = "";
            OpenFileDialog file = new OpenFileDialog();
            file.InitialDirectory = "C:\\";
            file.Filter = "Text File (*.txt)|*.txt";
            file.FilterIndex = 0;
            file.RestoreDirectory = true;
            if (file.ShowDialog() == DialogResult.OK)
            {
                string fileName = file.FileName;
                string text = System.IO.File.ReadAllText(fileName);
                option_text.Text = text;
            }
        }
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            key_text.Text = "";
            OpenFileDialog file = new OpenFileDialog();
            file.InitialDirectory = "C:\\";
            file.Filter = "Text File (*.txt)|*.txt";
            file.FilterIndex = 0;
            file.RestoreDirectory = true;
            if (file.ShowDialog() == DialogResult.OK)
            {
                string fileName = file.FileName;
                string text = System.IO.File.ReadAllText(fileName);
                key_text.Text = text;
            }
        }
    }
}