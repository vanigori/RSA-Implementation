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
                        plainTextMatrix[row, col] = "|";
                    }
                }
            }
            Console.WriteLine("Plaintext");
            printMatrix(plainTextMatrix);

            int[] alphaToKeyMap = new int[key.Length];
            char[] tempKey = key.ToCharArray();
            for(int i =0; i<alphaToKeyMap.Length; i++)
            {
                int index = -1;
                for(int charEl = 0; charEl<alphaToKeyMap.Length; charEl++)
                {
                    if (sortedKey[i] == tempKey[charEl])
                    {
                        index = charEl;
                        tempKey[charEl] = '#';
                        break;
                    }
                }
                alphaToKeyMap[i] = index;
            }
                      
            string cipherText = "";

            for (int col = 0; col < key.Length; col++)
            {
                for (int row = 0; row < rows; row++)
                {
                
                    cipherText += plainTextMatrix[row, alphaToKeyMap[col]];
                }
            }
            Console.WriteLine("Ciphertext: " + cipherText);
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
            Console.WriteLine("Imported Ciphertext");
            printMatrix(plainTextMatrix);

            int[] alphaToKeyMap = new int[key.Length];
            char[] tempKey = sortedKey.ToCharArray();
            for (int i = 0; i < alphaToKeyMap.Length; i++)
            {
                int index3 = -1;
                for (int charEl = 0; charEl < alphaToKeyMap.Length; charEl++)
                {
                    if (key[i] == tempKey[charEl])
                    {
                        index3 = charEl;
                        tempKey[charEl] = '#';
                        break;
                    }
                }
                alphaToKeyMap[i] = index3;
            }

            string plainText = "";
            for(int row = 0; row<rows; row++)
            {
                for(int col=0; col<key.Length; col++)
                {
                    plainText += plainTextMatrix[row, alphaToKeyMap[col]];
                }
            }
            
            return plainText.Trim(new char[] { '|'});


        }

        public static bool encryptFile(string fileName, string key)
        {
            //Read bytes from plaintext file
            byte[] plainText = File.ReadAllBytes(fileName);
            
            //Sort key in alphabetical order
            char[] brokenKey = key.ToArray();
            Array.Sort(brokenKey);
            string sortedKey = new string(brokenKey);

            //calculate number of rows each column in the matrix will have
            int rows = (int)Math.Ceiling((double)plainText.Length / key.Length);

            //create matrix object
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
                        //fill matrix with bytes until there are not any bytes left
                        plainTextMatrix[row, col] = plainText[ptIndex++];
                    }
                    else
                    {
                        //after all bytes are read start adding padding to the remainder of the last row
                        //Save the index of this padding to be added to cipher file
                        if (!paddingHasStarted)
                        {
                            paddingHasStarted = true;
                            paddingStartIndex = Convert.ToByte(col);
                        }
                        plainTextMatrix[row, col] = 0;
                    }
                }
            }
            
            //create an array that maps the original key to the sorted key. This will be used to 
            //select matrix columns in the correct order for encryption            
            int[] alphaToKeyMap = new int[key.Length];
            char[] tempKey = key.ToCharArray();
            for (int i = 0; i < alphaToKeyMap.Length; i++)
            {
                int index = -1;
                for (int charEl = 0; charEl < alphaToKeyMap.Length; charEl++)
                {
                    if (sortedKey[i] == tempKey[charEl])
                    {
                        index = charEl;
                        tempKey[charEl] = '#';
                        break;
                    }
                }
                alphaToKeyMap[i] = index;
            }

            //create output byte array and fill byte array with columns in the order corresponding to
            //the mapping made in the previous block. Thus the first column to be selected is the 
            //index of the first character (in the sorted list) in the original key
            byte[] cipherText = new byte[plainTextMatrix.LongLength + 1];
            int index2 = 0;
            for (int col = 0; col < key.Length; col++)
            {
                for (int row = 0; row < rows; row++)
                {
                    cipherText[index2++] += plainTextMatrix[row, alphaToKeyMap[col]];
                }
            }

            //Save padding index to the byte array
            cipherText[cipherText.Length - 1] = paddingStartIndex;
            //Write the byte array to disk
            ByteArrayToFile(fileName + ".transposition", cipherText);

            return true;

        }

        public static bool decryptFile(string fileName, string key)
        {
            byte[] cipherText = File.ReadAllBytes(fileName);
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

            int[] alphaToKeyMap = new int[key.Length];
            char[] tempKey = sortedKey.ToCharArray();
            for (int i = 0; i < alphaToKeyMap.Length; i++)
            {
                int index3 = -1;
                for (int charEl = 0; charEl < alphaToKeyMap.Length; charEl++)
                {
                    if (key[i] == tempKey[charEl])
                    {
                        index3 = charEl;
                        tempKey[charEl] = '#';
                        break;
                    }
                }
                alphaToKeyMap[i] = index3;
            }

            byte[] plainText = new byte[plainTextMatrix.LongLength];
            int index2 = 0;
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < key.Length; col++)
                {
                    plainText[index2++] = plainTextMatrix[row, alphaToKeyMap[col]];
                }
            }
                        
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

        public static void printMatrix(string[,] matrix)
        {
            for(int row =0; row<matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + "\t");
                }
                Console.WriteLine("\r\n");
            }
        }

        public static void printMatrix(byte[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + "\t");
                }
                Console.WriteLine("\r\n");
            }
        }


    }
}
