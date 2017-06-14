using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        RijndaelManaged symAlgo = new RijndaelManaged();
        crypto ob = new crypto();
        private void button1_Click(object sender, EventArgs e)
        {

            RijndaelManaged symAlgo = new RijndaelManaged();

            string dataToEncrypt = textBox1.Text;
          
            label2.Text = ob.EncryptData(dataToEncrypt, symAlgo,textBox2.Text);

            using (StreamReader sr = new StreamReader(label2.Text))
            {
                string line;

                // Read and display lines from the file until 
                // the end of the file is reached. 
                while ((line = sr.ReadLine()) != null)
                {
                    richTextBox1.Text = line;
                }
            }

            

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            richTextBox1.Text = textBox1.Text;
        }


       
    }
}
