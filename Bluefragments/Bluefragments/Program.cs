using System;

namespace Bluefragments
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 19;
            PrimeChecker primeChecker = new PrimeChecker();
            Console.WriteLine("Is " + num + " a prime number? " + primeChecker.IsPrime(num));

            Console.WriteLine("--------------------------------");

            string potatoString = "potato Potato potayto PoTaTopOtAtO";
            Console.WriteLine("Number of potatoes: " + PotatoCounter.Counter(potatoString));

            Console.WriteLine("--------------------------------");

            int[] encryptedText = SpyTools.Encrypt("Hello, my name is Daniel");

            Console.Write("Encrypted: " + string.Join(", ", encryptedText));
            Console.WriteLine();
            Console.WriteLine("Decrypted: " + SpyTools.Decrypt(encryptedText));

            Console.ReadKey();
        }
    }
}
