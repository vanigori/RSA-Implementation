using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cryptography
{
    public static class TranspositionClass
    {

        public static string encrypt(string plaintext, string key)
        {
            //make all letters uppercase
            plaintext = plaintext.ToUpper();
            plaintext = plaintext.Replace(" ", "");

            //Sort key in alphabetical order
            char[] brokenKey = key.ToArray();
            Array.Sort(brokenKey);
            string sortedKey = new string(brokenKey);
            Console.WriteLine(sortedKey);
            
            int rows = (int)Math.Ceiling((double)plaintext.Length / key.Length);
            string[,] plainTextMatrix = new string[rows, key.Length];
            int ptIndex = 0;
            for(int row = 0; row<rows; row++)
            {
                for(int col = 0; col<key.Length; col++)
                {
                    if (ptIndex < plaintext.Length)
                    {
                        plainTextMatrix[row,col] = plaintext.Substring(ptIndex++, 1);
                    }else
                    {
                        plainTextMatrix[row, col] = "l";
                    }
                }
            }
            
            string cipherText = "";
            for(int colIndex = 0; colIndex < key.Length; colIndex++)
            {
                int col = key.IndexOf(sortedKey[colIndex]);
                for(int row = 0; row<rows; row++)
                {
                    cipherText += plainTextMatrix[row, col];
                }
            }

            return cipherText;
            
        }

        public static string decrypt(string ciphertext, string key)
        {
            //Sort key in alphabetical order
            char[] brokenKey = key.ToArray();
            Array.Sort(brokenKey);
            string sortedKey = new string(brokenKey);
            Console.WriteLine(sortedKey);

            //get amount of rows the plain text matrix has
            int rows = (int) Math.Ceiling((double)ciphertext.Length / key.Length);

            string[,] plainTextMatrix = new string[rows, key.Length];

            //reconstruct the key-sorted plaintext matrix
            int index = 0;
            for(int col = 0; col<key.Length; col++)
            {
                for(int row = 0; row<rows; row++)
                {
                    plainTextMatrix[row, col] = Convert.ToString(ciphertext[index++]);
                }
            }

            int[] keyColIndexes = new int[key.Length];

            for(int i =0; i<key.Length; i++)
            {
                keyColIndexes[i] = key.IndexOf(sortedKey[i]);
            }

            string plainText = "";
            for(int row = 0; row<rows; row++)
            {
                for(int col=0; col<key.Length; col++)
                {
                    plainText += plainTextMatrix[row, keyColIndexes[col]];
                }
            }

            return plainText.Trim(new char[] { 'l'});


        }

        public static bool encryptFile(string fileName, string key)
        {
            byte[] plainText = File.ReadAllBytes(fileName);
            key = string.Join(" ", key.ToCharArray().Distinct()).Replace(" ","").ToLower();
            //Sort key in alphabetical order
            char[] brokenKey = key.ToArray();
            Array.Sort(brokenKey);
            string sortedKey = new string(brokenKey);
            Console.WriteLine(sortedKey);

            int rows = (int)Math.Ceiling((double)plainText.Length / key.Length);
            byte[,] plainTextMatrix = new byte[rows, key.Length];
            int ptIndex = 0;
            byte paddingStartIndex = 0;
            bool paddingHasStarted = false;
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < key.Length; col++)
                {
                    if (ptIndex < plainText.Length)
                    {
                        plainTextMatrix[row, col] = plainText[ptIndex++];
                    }
                    else
                    {
                        if (!paddingHasStarted)
                        {
                            paddingHasStarted = true;
                            paddingStartIndex = Convert.ToByte(col);
                        }
                        plainTextMatrix[row, col] = 0;
                    }
                }
            }
            
            byte[] cipherText = new byte[plainTextMatrix.LongLength+1];
            int index = 0;
            for (int colIndex = 0; colIndex < key.Length; colIndex++)
            {
                int col = key.IndexOf(sortedKey[colIndex]);
                for (int row = 0; row < rows; row++)
                {
                    cipherText[index++] = plainTextMatrix[row, col];
                }
            }
            cipherText[cipherText.Length - 1] = paddingStartIndex;

            ByteArrayToFile(fileName + ".transposition", cipherText);

            return true;

        }

        public static bool decryptFile(string fileName, string key)
        {
            byte[] cipherText = File.ReadAllBytes(fileName);
            key = string.Join(" ", key.ToCharArray().Distinct()).Replace(" ", "").ToLower();
            byte paddingStartIndex = cipherText[cipherText.Length - 1];
            Console.WriteLine(paddingStartIndex);
            //Sort key in alphabetical order
            char[] brokenKey = key.ToArray();
            Array.Sort(brokenKey);
            string sortedKey = new string(brokenKey);

            //get amount of rows the plain text matrix has
            int rows = (int)Math.Floor((double)(cipherText.Length) / key.Length);

            byte[,] plainTextMatrix = new byte[rows, key.Length];

            //reconstruct the key-sorted plaintext matrix
            int index = 0;
            for (int col = 0; col < key.Length; col++)
            {
                for (int row = 0; row < rows; row++)
                {
                    plainTextMatrix[row, col] = cipherText[index++];
                }
            }
            
            int[] keyColIndexes = new int[key.Length];

            for (int i = 0; i < key.Length; i++)
            {
                keyColIndexes[i] = key.IndexOf(sortedKey[i]);
            }
            int index2 = 0;

            byte[] plainText = new byte[plainTextMatrix.LongLength];
            
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < key.Length; col++)
                {
                    
                    plainText[index2++] = plainTextMatrix[row, keyColIndexes[col]];
                }
            }
            Console.WriteLine("\r\nThis is the decrypt method plaintext");
            
            //remove paddings bytes
            Array.Resize(ref plainText, plainText.Length-(key.Length - paddingStartIndex));
            fileName = fileName.Replace(".transposition", "");
            string fileExtension = fileName.Substring(fileName.LastIndexOf('.'));
            ByteArrayToFile(fileName+".decrypted"+fileExtension, plainText);
            return true;
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

        


    }
}
