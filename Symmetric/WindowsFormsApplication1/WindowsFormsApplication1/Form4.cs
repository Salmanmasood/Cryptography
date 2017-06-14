using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form4 : Form
    {
        public string passPhrase = "Pas5pr@se";        // can be any string
        public string saltValue = "s@1tValue";        // can be any string
        public string hashAlgorithm = "SHA1";             // can be "MD5"
        public int passwordIterations = 2;                // can be any number
        public string initVector = "@1B2c3D4e5F6g7H8"; // must be 16 bytes
        public int keySize = 256;                // can be 192 or 128
      public  string cipherText;
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string plainText = textBox1.Text;
            cipherText = RijndaelSimple.Encrypt
        (
            plainText,
            passPhrase,
            saltValue,
            hashAlgorithm,
            passwordIterations,
            initVector,
            keySize
        );

            richTextBox1.Text = cipherText;




        }

        private void button2_Click(object sender, EventArgs e)
        {

         string   plainText = RijndaelSimple.Decrypt
       (
           richTextBox1.Text,
           passPhrase,
           saltValue,
           hashAlgorithm,
           passwordIterations,
           initVector,
           keySize
       );
         richTextBox2.Text = plainText;



        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            richTextBox1.Text = textBox1.Text;


        }//event
    }
}
