using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class VigenereCipher
{
    private string key;
    private char[,] table;

    public VigenereCipher(string key)
    {
        if (key != null && key.Length > 2)
            this.key = key.ToUpper();
        else
            this.key = ("VigenereCipherTestKey").ToUpper();
        removeDuplicatesFromKey();
        updateTable();
    }

    public string encrypt(string toEncrypt)
    {
        padKeyIfTooShort(toEncrypt);
        key = key.ToUpper();
        char[] keyChar = key.ToCharArray();
        char[] messageChar = toEncrypt.ToUpper().ToCharArray();
        char[] encryptedText = new char[keyChar.Length];
        for(int a = 0; a < messageChar.Length; a++)
        {
            int keyInt = mapCharToInt(keyChar[a]);
            int messageInt = mapCharToInt(messageChar[a]);
            encryptedText[a] = table[keyInt, messageInt];
        }
        StringBuilder sb = new StringBuilder();
        sb.Append(encryptedText);
        return sb.ToString();
    }

    private int mapCharToInt(char letter)
    {
        return letter - 65;
    }

    private char mapIntToChar(int number)
    {
        return (char)(number + 65);
    }

    public string decrypt(string toDecrypt)
    {
        padKeyIfTooShort(toDecrypt);
        char[] keyChar = key.ToUpper().ToCharArray();
        char[] messageChar = toDecrypt.ToUpper().ToCharArray();
        char[] decryptedText = new char[keyChar.Length];
        for (int a = 0; a < messageChar.Length; a++)
        {
            int keyInt = mapCharToInt(keyChar[a]);
            for(int b = 0; b < 26; b++)
            {
                if(table[keyInt, b] == messageChar[a])
                    decryptedText[a] = mapIntToChar(b);
            }
        }
        StringBuilder sb = new StringBuilder();
        sb.Append(decryptedText);
        return sb.ToString();
    }

    private void padKeyIfTooShort(string message)
    {
        //Message: HelloWorld
        //Key:     Lemon
        //Padded:  LemonLemon
        if(key.Length < message.Length)
        {
            //We need to pad the key
            int amountToAdd = message.Length - key.Length;
            for(int a = 0; a < amountToAdd; a++)
            {
                key += key.ToCharArray().ElementAt(a).ToString();
            }
        }
    }

    private void removeDuplicatesFromKey()
    {
        char[] listOfUniqueCharacters = new char[key.Length];
        int count = 0;
        for(int a = key.Length; a > 0; a--)
        {
            if (listOfUniqueCharacters.Contains(key.ToCharArray()[a - 1]))
                //Already in the list, remove the duplicate
                key.Remove(a - 1, 1);
            else
            {
                listOfUniqueCharacters[count] = key.ToCharArray()[a - 1];
                count++;
            }
        }
        StringBuilder sb = new StringBuilder();
        Console.WriteLine(sb.Append(listOfUniqueCharacters).ToString());
        sb.Clear();
        Array.Resize(ref listOfUniqueCharacters, count);
        Console.WriteLine(sb.Append(listOfUniqueCharacters).ToString());
        sb.Clear();
        Array.Reverse(listOfUniqueCharacters);
        Console.WriteLine(sb.Append(listOfUniqueCharacters).ToString());
        sb.Clear();
        sb.Append(listOfUniqueCharacters);
        key = sb.ToString();
    }

    private void updateTable()
    {
        table = new char[26, 26];
        for(int a = 0; a < 26; a++)
        {
            for(int b = 0; b < 26; b++)
            {
                if (a + b > 25)
                    table[a, b] = (char)((a + b) + 65 - 26);
                else
                    table[a, b] = (char)((a + b) + 65);
            }
        }
    }
}