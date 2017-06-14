using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
    
        static void EncryptData(String plainText, RijndaelManaged algo)
        {   
            
            string enc = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\salman\encryptedfile.txt";
            byte[] plainDataArray = ASCIIEncoding.ASCII.GetBytes(plainText);
            ICryptoTransform transform = algo.CreateEncryptor();
            using (var fileStream = new FileStream(enc, FileMode.OpenOrCreate, FileAccess.Write))
            {
                using (var cryptoStream = new CryptoStream(fileStream, transform, CryptoStreamMode.Write))
                {
                    cryptoStream.Write(plainDataArray, 0, plainDataArray.GetLength(0));
                    Console.WriteLine("Encrypted data written to:@\\salman\\encryptedfile.txt");
                }
            }
        } //method end
             
             
         static void DecryptData(RijndaelManaged algo) 
         {
             string enc = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\salman\encryptedfile.txt"; 
             ICryptoTransform transform = algo.CreateDecryptor();
            
      using (var fileStream = new FileStream(enc, FileMode.Open, FileAccess.Read))
       {
           using (CryptoStream cryptoStream = new CryptoStream(fileStream, transform, CryptoStreamMode.Read))
           {
               using (var streamReader = new StreamReader(cryptoStream))
               {
                   string decryptedData = streamReader.ReadToEnd();
                   Console.WriteLine("Decrypted data: \n{0}", decryptedData); 
               }
           }
       }


         } //method end.................. 


        static void Main(string[] args)
        {

            /*
            RijndaelManaged symAlgo = new RijndaelManaged(); 
            Console.WriteLine("Generated key: {0}, \nGenerated IV: {1}", Encoding.Default. GetString(symAlgo.Key), Encoding.Default.GetString(symAlgo.IV));
           ........................................................................
            RijndaelManaged symAlgo = new RijndaelManaged(); 
           symAlgo.GenerateKey();
           symAlgo.GenerateIV();
            byte[] generatedKey = symAlgo.Key; 
            byte[] generatedIV =symAlgo.IV; 
            Console.WriteLine("Generated key through GenerateKey(): {0}, \nGenerated IV through GenerateIV(): {1}", Encoding.Default.GetString(generatedKey), Encoding.Default.GetString(generatedIV));
             

            ........................................................................................


            RijndaelManaged symAlgo = new RijndaelManaged();
            Console.WriteLine("Enter data to encrypt.");
            string dataToEncrypt = Console.ReadLine();
            EncryptData(dataToEncrypt, symAlgo);

            */


            RijndaelManaged symAlgo = new RijndaelManaged();
            Console.WriteLine("Enter data to encrypt."); 
            string dataToEncrypt = Console.ReadLine(); 
            EncryptData(dataToEncrypt, symAlgo);
            DecryptData(symAlgo);













            Console.ReadLine();
            

        }
    }
}
