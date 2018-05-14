using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;
using System.Security.Cryptography;


namespace Cryptography
{
    public static class VernamClass
    {
        
        private static string plainText { get; set; }
        private static string cipherText { get; set; }
        private static int[] key { get; set; }
        private static Random keyGen { get; set; } = new Random();

        //encryption of plaintext using keyGen
        public static CipherClass encrypt(string plaintext)
        {
            cipherText = "";
            //key = generateKey(plaintext.Length);
            key = generateKey(plaintext.Length);
            for (int i = 0; i < plaintext.Length; i++)
            {
                int character = plaintext[i];
                cipherText += Convert.ToString(Convert.ToChar((character + (key[i]) % 26)));
            }
            //rewrite van voor tot agter :(
            CipherClass cipher = new CipherClass(cipherText, key);
            return cipher;
        }

        //Encrypt a file
        public static CipherClass encrypt(string fileName, bool isFile)
        {
            DateTime start = DateTime.Now;
            byte[] plainText = File.ReadAllBytes(fileName);
            byte[] key = generateKey(plainText.Length, true);
            byte[] cipher = new byte[plainText.Length];
            cipher = exclusiveOR(plainText, key);
            CipherClass cipherObj = new CipherClass(cipher, key);
            ByteArrayToFile(fileName + ".vernam", cipher);
            DateTime end = DateTime.Now;
            Console.WriteLine(end - start);
            Console.WriteLine("Encryption complete");
            return cipherObj;

        }

        //decryption of text using Cipher datatype
        public static string decrypt(CipherClass cipher)
        {
            if(cipher.cipher.GetType() == typeof(string))
            {
                cipherText = (string)cipher.cipher;
                key = cipher.key;
                plainText = "";
                for (int i = 0; i < cipherText.Length; i++)
                {
                    int character = cipherText[i];
                    plainText += Convert.ToString(Convert.ToChar(character - (key[i] % 26)));
                }
                return plainText;
            }
            return "Error";
            
        }

        public static bool decrypt(string fileName, byte[] key)
        {
            byte[] cipherText = File.ReadAllBytes(fileName);
            byte[] plainText = new byte[cipherText.Length];
            plainText = exclusiveOR(cipherText, key);
            fileName = fileName.Replace(".vernam", "");
            string fileExtension = fileName.Substring(fileName.LastIndexOf('.'));
            ByteArrayToFile(fileName + ".decrypted" + fileExtension, plainText);
            Console.WriteLine("Decryption Done");
            return true;
        }

        //generates valid keys based on the length of the plaintext
        private static int[] generateKey(int length)
        {    
            key = new int[length];
            for (int i = 0; i < length; i++)
            {
                key[i] = keyGen.Next(0, 26);
            }

            return key;
        }

        public static byte[] generateKey(int length, bool isFile)
        {
            byte[] key = new byte[length];
            keyGen.NextBytes(key);
            return key;
        }

        public static bool ByteArrayToFile(string fileName, byte[] byteArray)
        {
            try
            {
                using (var fs = new FileStream(fileName, FileMode.Create, FileAccess.Write))
                {
                    fs.Write(byteArray, 0, byteArray.Length);
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception caught in process: {0}", ex);
                return false;
            }
        }

        public static byte[] exclusiveOR(byte[] data, byte[] key)
        {
            byte[] result = new byte[data.Length];
            for (int i = 0; i < data.Length; i++)
                result[i] = (byte)(data[i] ^ key[i]);
            return result;
        }

    }
}
