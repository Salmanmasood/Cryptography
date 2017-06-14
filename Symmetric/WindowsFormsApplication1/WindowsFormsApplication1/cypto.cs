using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WindowsFormsApplication1
{
    class crypto
    {

        public  string EncryptData(String plainText, RijndaelManaged algo,string filename)
        {
            string s ;
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\salman\"+filename+".txt";
            
            byte[] plainDataArray = ASCIIEncoding.ASCII.GetBytes(plainText);
            
            ICryptoTransform transform = algo.CreateEncryptor();
            using (var fileStream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write))
            {
                using (var cryptoStream = new CryptoStream(fileStream, transform, CryptoStreamMode.Write))
                {
                    cryptoStream.Write(plainDataArray, 0, plainDataArray.GetLength(0));
                   
                    s = path;
                }
            }
            return s;
        } //method end










      




        
















       
    }
}
