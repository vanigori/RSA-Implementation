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
            //make all letters uppercase and remove spaces
            plaintext = plaintext.ToUpper();
            plaintext = plaintext.Replace(" ", "");

            //Sort key in alphabetical order
            char[] brokenKey = key.ToArray();
            Array.Sort(brokenKey);
            string sortedKey = new string(brokenKey);
            
            //Calculate the number of rows needed in the matrix
            int rows = (int)Math.Ceiling((double)plaintext.Length / key.Length);

            //create the matrix
            string[,] plainTextMatrix = new string[rows, key.Length];
            int ptIndex = 0;
            //Fill matrix with data and padding
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
            
            //Map sorted key indices to original key indices
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
            //Fill cipherText with columns selected according to previous mapping
            for (int col = 0; col < key.Length; col++)
            {
                for (int row = 0; row < rows; row++)
                {
                    cipherText += plainTextMatrix[row, alphaToKeyMap[col]];
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
            

            //get amount of rows the plain text matrix has
            int rows = (int) Math.Ceiling((double)ciphertext.Length / key.Length);

            string[,] cipherTextMatrix = new string[rows, key.Length];

            //reconstruct the key-sorted plaintext matrix
            int index = 0;
            //Fill matrix with encrypted data
            for (int col = 0; col<key.Length; col++)
            {
                for(int row = 0; row<rows; row++)
                {
                    cipherTextMatrix[row, col] = Convert.ToString(ciphertext[index++]);
                }
            }

            //Map sorted key indices to original key indices
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

            //fill output variable with decrypted data 
            string plainText = "";
            for(int row = 0; row<rows; row++)
            {
                for(int col=0; col<key.Length; col++)
                {
                    plainText += cipherTextMatrix[row, alphaToKeyMap[col]];
                }
            }
            //Remove padding added by encryption
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
            //index of the first character (in the sorted key) in the original key
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
            //Read bytes from plaintext file
            byte[] cipherText = File.ReadAllBytes(fileName);
            byte paddingStartIndex = cipherText[cipherText.Length - 1];
           
            
            //Sort key in alphabetical order
            char[] brokenKey = key.ToArray();
            Array.Sort(brokenKey);
            string sortedKey = new string(brokenKey);

            //calculate number of rows each column in the matrix will have
            int rows = (int)Math.Floor((double)(cipherText.Length) / key.Length);
            //create matrix object
            byte[,] cipherTextMatrix = new byte[rows, key.Length];

            //reconstruct the key-sorted ciphertext matrix
            int index = 0;
            for (int col = 0; col < key.Length; col++)
            {
                for (int row = 0; row < rows; row++)
                {
                    //Fill matrix with file data
                    cipherTextMatrix[row, col] = cipherText[index++];
                }
            }

            //create an array that maps the sorted key to the original key. This will be used to 
            //select matrix columns in the correct order for encryption
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

            //create output byte array and fill byte array with columns in the order corresponding to
            //the mapping made in the previous block. Thus the first column to be selected is the 
            //index of the first character (in the original key) in the sorted key
            byte[] plainText = new byte[cipherTextMatrix.LongLength];
            int index2 = 0;
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < key.Length; col++)
                {
                    plainText[index2++] = cipherTextMatrix[row, alphaToKeyMap[col]];
                }
            }
                        
            //remove paddings bytes
            Array.Resize(ref plainText, plainText.Length-(key.Length - paddingStartIndex));

            fileName = fileName.Replace(".transposition", "");
            string fileExtension = fileName.Substring(fileName.LastIndexOf('.'));
            //Write the byte array to disk
            ByteArrayToFile(fileName+".decrypted"+fileExtension, plainText);
            return true;
        }

        //Method for writing byte array to file using filestream
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
