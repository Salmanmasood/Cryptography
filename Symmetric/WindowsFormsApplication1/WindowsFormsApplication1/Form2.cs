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

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RijndaelManaged symAlgo = new RijndaelManaged();
            symAlgo.GenerateKey();
            symAlgo.GenerateIV();
            byte[] generatedKey = symAlgo.Key;
            byte[] generatedIV = symAlgo.IV;


            textBox1.Text = Encoding.Default.GetString(generatedKey);
            textBox2.Text = Encoding.Default.GetString(generatedIV);

        }
    }
}
