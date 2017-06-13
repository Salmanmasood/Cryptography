using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter text to encrypt:");
            String inputText = Console.ReadLine();
            RSACryptoServiceProvider RSA = new RSACryptoServiceProvider(); 
            RSAParameters RSAParam=RSA.ExportParameters(false); 
            byte[] encryptedData =AsymmetricEncryptionDemo.EncryptData(inputText, RSAParam);
            string encryptedString = Encoding.Default.GetString(encryptedData); 
            Console.WriteLine("\nEncrypted data \n{0}",encryptedString);
            byte[] decryptedData = AsymmetricEncryptionDemo.DecryptData(encryptedData, RSA.ExportParameters(true)); 
            String decryptedString = new UnicodeEncoding().GetString(decryptedData);
            Console.WriteLine("\nDecrypted data \n{0}", decryptedString);

            Console.ReadLine();
        }
    }
}
