using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace WindowsFormsApp1
{
    public partial class Lab_1 : Form
    {
        public Lab_1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            if (rB_encrypt.Checked)
            {
                richTextBox1.ReadOnly = false;
                richTextBox2.ReadOnly = true;
            }
            else
            {
                richTextBox1.ReadOnly = true;  
                richTextBox2.ReadOnly = false;
            }
            textBox_key.AsciiOnly = true;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private bool checkFields()
        {
            bool isValid = false;
            String msg = null;
            if (rB_encrypt.Checked)
                msg = richTextBox1.Text.ToUpper();
            else
                msg = richTextBox2.Text.ToUpper();

            String key = textBox_key.Text.ToUpper();

            if (rB_vinegar.Checked)
            {
                char[] russianAlphabet = { 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'И', 'Й', 'К', 'Л', 'М',
                                           'Н', 'О', 'П', 'Р', 'С', 'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ъ',
                                           'Ы', 'Ь', 'Э', 'Ю', 'Я' };

                for (int i = 0; i < russianAlphabet.Length; ++i)
                    for (int j = 0; j < key.Length; ++j)
                        if (russianAlphabet[i] == key[j])
                        {
                            isValid = true;
                            i = russianAlphabet.Length - 1;
                        }

                if (isValid)
                for (int i = 0; i < russianAlphabet.Length; ++i)
                    for (int j = 0; j < msg.Length; ++j)
                        if (russianAlphabet[i] == msg[j])
                            return true;

                MessageBox.Show("Error: data invalid! Please, enter russian Alphabet.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                String englishAlphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                String sequenceDigits = "0123456789";

                if (rB_columnMethod.Checked)
                {
                    for (int i = 0; i < englishAlphabet.Length; ++i)
                        for (int j = 0; j < key.Length; ++j)
                            if (englishAlphabet[i] == key[j])
                            {
                                isValid = true;
                                i = englishAlphabet.Length - 1;
                            }
                }
                else
                {
                    for (int i = 0; i < sequenceDigits.Length; ++i)
                        for (int j = 0; j < key.Length; ++j)
                            if (sequenceDigits[i] == key[j])
                            {
                                isValid = true;
                                i = sequenceDigits.Length -1 ;
                            }
                }

                    if (isValid)
                        for (int i = 0; i < englishAlphabet.Length; ++i)
                            for (int j = 0; j < msg.Length; ++j)
                                if (englishAlphabet[i] == msg[j])
                                    return true;
                
                            
                MessageBox.Show("Error: data invalid! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            return false;
        }

        private string parseToDigitString(string key)
        {
            string result = "";
            String sequenceDigits = "0123456789";

            for (int i = 0; i < sequenceDigits.Length; ++i)
            {
                for (int j = 0; j < key.Length; ++j)
                {
                    if (sequenceDigits[i] == key[j])
                    {
                        result += key[j];
                    }
                }
            }
            return result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String Key = textBox_key.Text.ToUpper();
          if (checkFields())
             if (rB_encrypt.Checked )
            {
                if (richTextBox1.Text != "")
                    if (textBox_key.Text != "")
                    {
                            Key = parseToDigitString(Key);
                        DataEncryption dataEncryption = new DataEncryption(richTextBox1.Text, Key);
                        String answerLine = null;
                        //RUN encrypt
                        if (rB_railFence.Checked)
                        { 
                            int number = 0;
                                
                            if (int.TryParse(Key, out number))
                            {
                                if (number > 1 && number < 99999)
                                answerLine = dataEncryption.encrypt_methodRailFence();
                                else
                                    MessageBox.Show("Error key! Key is need to be > 0 and < 999999.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                            }
                            else
                                MessageBox.Show("Error key! Key is need consist of digits.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else if (rB_columnMethod.Checked)
                        {
                            answerLine = dataEncryption.encrypt_methodColumn();
                        }
                        else if (rB_vinegar.Checked)
                        {
                            answerLine = dataEncryption.encrypt_methodVinegar();
                        }
                        richTextBox2.Text = answerLine;
                    }
                    else
                        MessageBox.Show("Please enter key!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    MessageBox.Show("Please enter original text!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {   
                if (richTextBox2.Text != "")
                {
                    if (textBox_key.Text != "")
                    {
                            Key = parseToDigitString(Key);
                            DataEncryption dataEncryption = new DataEncryption(richTextBox2.Text, Key);
                        String answerLine = null;
                        //RUN decipher
                        if (rB_railFence.Checked)
                        {
                            int number;
                            if (int.TryParse(Key, out number))
                            answerLine = dataEncryption.decipher_methodRailFence();
                            else
                                MessageBox.Show("Error key! Key is need consist of digits.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else if (rB_columnMethod.Checked)
                        {
                            answerLine = dataEncryption.decipher_methodColumn();
                        }
                        else if (rB_vinegar.Checked)
                        {
                            answerLine = dataEncryption.decipher_methodVinegar();
                        }
                        richTextBox1.Text = answerLine;
                    }
                    else
                        MessageBox.Show("Please enter key!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                    MessageBox.Show("Please encrypted text!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string fileName = openFileDialog1.FileName;
            if (fileName.Contains(".txt"))
            {
                string text = File.ReadAllText(fileName);
                if (rB_encrypt.Checked)
                {
                    richTextBox1.Text = text;
                }
                else
                {
                    richTextBox2.Text = text;
                }
            }
            else
            {
                MessageBox.Show("Error: format of file is do't valid!");
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox_main_Enter(object sender, EventArgs e)
        {


        }

        private void rB_decipher_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox2.Clear();
            if (rB_encrypt.Checked)
            {
                
                richTextBox1.ReadOnly = false;
                richTextBox2.ReadOnly = true;
            }
            else
            {
                richTextBox1.ReadOnly = true;
                richTextBox2.ReadOnly = false;
            }
        }

        private void rB_encrypt_CheckedChanged(object sender, EventArgs e)
        {
            
            richTextBox1.Clear();
            richTextBox2.Clear();
            if (rB_encrypt.Checked)
            { 
                richTextBox1.ReadOnly = false;
                richTextBox2.ReadOnly = true;
            }
            else
            {
                richTextBox1.ReadOnly = true;
                richTextBox2.ReadOnly = false;
            }
        }

        private void rd_vinegar_CheckedChanged(object sender, EventArgs e)
        {
            textBox_key.AsciiOnly = false;
        }

        private void rB_columnMethod_CheckedChanged(object sender, EventArgs e)
        {
            textBox_key.AsciiOnly = true;
        }

        private void rB_railFence_CheckedChanged(object sender, EventArgs e)
        {
            textBox_key.AsciiOnly = true;
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
           
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Problem
            saveFileDialog1.ShowDialog();
            string fileName = saveFileDialog1.FileName;
     
                if (rB_encrypt.Checked && richTextBox2.Text != "")
                {
                    File.WriteAllText(fileName, richTextBox2.Text);
                } 
                else if (richTextBox1.Text != "")
                {
                    File.WriteAllText(fileName, richTextBox1.Text);
                }
                else
                {
                    MessageBox.Show("Please click button!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

        }

        private void aboutProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Eugene Shadura, group 951007, 2021 y.", "About developer", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
            

        private void aboutProgramToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cipher/Decipher, method: Vineger (straight key), Rail fence, Columnar.", "About program", MessageBoxButtons.OK, MessageBoxIcon.Information);
        
        }
    }
}
