using System;
using System.Collections.Generic;
using System.Text;

namespace Bluefragments
{
    public static class PotatoCounter
    {
        public static int Counter(string text)
        {
            if(text != null)
            {
                int counter;
                string lowerText = text.ToLower();
                string[] potatoes = lowerText.Split("potato");

                counter = potatoes.Length - 1;
                return counter;
            }
            else
            {
                return 0;
            }

        }
    }
}
