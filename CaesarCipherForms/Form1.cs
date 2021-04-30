using System;
using System.Windows.Forms;

namespace CaesarCipherForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static char Cipher(char ch, int key)
        {
            if (!char.IsLetter(ch))
            {
                return ch;
            }

            char d = char.IsUpper(ch) ? 'A' : 'a';

            return (char)(((ch + key - d) % 26) + d);


        }
        public static string Encipher(string input, int key)
        {
            string output = string.Empty;

            foreach (char ch in input)
                output += Cipher(ch, key);

            return output;

            int a = 12;
        }
        public static string Decipher(string input, int key)
        {
            return Encipher(input, 26 - key);
            
        }

        private void BtnEncipher_Click(object sender, EventArgs e)
        {
            if (!(TxtInput.Text == ""))
            {
                TxtOutput.Text = Encipher(TxtInput.Text, Convert.ToInt32(NupCodeValue.Value.ToString()));
            }
        }

        private void BtnDecipher_Click(object sender, EventArgs e)
        {
            TxtOutput.Text = Decipher(TxtInput.Text, Convert.ToInt32(NupCodeValue.Value.ToString()));
        }

        private void BtnTryAll_Click(object sender, EventArgs e)
        {
            TxtOutput.Clear();
            for (int a = 0; a < 26; a++)
            {
                TxtOutput.AppendText(a.ToString() + " " + Decipher(TxtInput.Text, a) + System.Environment.NewLine);
            }
            TxtOutput.ScrollToCaret();
        }
    }
}
