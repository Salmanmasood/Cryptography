using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class AsymmetricEncryptionDemo 
    {
 public  static byte[] EncryptData(string plainText, RSAParameters rsaParameters)
        { 
     
            byte[] plainTextArray = new UnicodeEncoding().GetBytes(plainText); 
            RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
            RSA.ImportParameters(rsaParameters);
            byte[] encryptedData = RSA.Encrypt(plainTextArray, true);
            return encryptedData; 
        }


 public static byte[] DecryptData(byte[] encryptedData, RSAParameters rsaParameters)
        {
            RSACryptoServiceProvider RSA = new RSACryptoServiceProvider(); 
            RSA.ImportParameters(rsaParameters);
            byte[] decryptedData = RSA.Decrypt(encryptedData, true);
            return decryptedData;
        }
    
    }
}
