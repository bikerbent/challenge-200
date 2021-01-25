using System;
using System.Collections.Generic;
using System.Text;

namespace Bluefragments
{
    public static class SpyTools
    {
        public static int[] Encrypt(string message)
        {
            byte[] letterValues = Encoding.ASCII.GetBytes(message);
            int[] codedMessage = new int[message.Length];
            int lastLetterValue = 0;

            for(int i = 0; i < letterValues.Length; i++)
            {
                codedMessage[i] = letterValues[i] - lastLetterValue;
                lastLetterValue = letterValues[i];
            }
           
            return codedMessage;
        }

        public static string Decrypt(int[] ints)
        {
            string message = "";
            int[] letterValues = new int[ints.Length];
            int lastLetterValue = 0;

            for (int i = 0; i < letterValues.Length; i++)
            {
                letterValues[i] = ints[i] + lastLetterValue;
                lastLetterValue = letterValues[i];
            }


            foreach (int x in letterValues)
            {
                message = message.Insert(message.Length, Convert.ToChar(x).ToString());
            }
            
            return message;
        }

    }
}
