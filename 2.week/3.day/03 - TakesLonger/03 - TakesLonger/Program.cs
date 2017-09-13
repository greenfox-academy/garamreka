﻿using System;
using System.Text;

namespace _03___TakesLonger
{
    class Program
    {
        static void Main(string[] args)
        {
            string quote = "Hofstadter's Law: It you expect, even when you take into account Hofstadter's Law.";

            // When saving this quote a disk error has occured. Please fix it.
            // Add "always takes longer than" to the StringBuilder (quote) between the words "It" and "you"
            // Using pieces of the quote variable (instead of just redefining the string)

            StringBuilder missingPart = new StringBuilder();
            missingPart.Append("always takes longer than ");

            StringBuilder newQuote = new StringBuilder();
            newQuote.Append(quote.Substring(0, 21) + missingPart + quote.Substring(21, 60));

            Console.WriteLine(newQuote);
            Console.ReadLine();
        }
    }
}
