using System;

namespace PigLatin
{
    class Program
    {
        static void Main(string[] args)
        {
            // Take Sentance From User
            bool keepTranslating = true;


            while (keepTranslating)
            {
                // Ask user the word to translate
                Console.WriteLine("Please type what you would like to translate");
                string thingToTranslate = Console.ReadLine().ToLower();

                // Check if user entered text
                if (thingToTranslate.Length <= 0)
                {
                    Console.WriteLine("Please enter a valid word");
                    continue;
                }

                // Pick apart word
                string firstLetter = thingToTranslate.Substring(0, 1);
                string restOfWord = thingToTranslate.Substring(1, thingToTranslate.Length - 1);

                string translatedSen = string.Empty;



                // Check if word starts with number or a symbol
                for (int i = 0; i < thingToTranslate.Length; i++)
                {
                    if(Char.IsNumber(thingToTranslate, i) || Char.IsSymbol(thingToTranslate, i))
                    {
                        Console.WriteLine("Your input contains invalid character(s) sorry.");
                        keepTranslating = false;
                    }
                }

                // Check if word starts with vowel or not.
                if (keepTranslating)
                {
                    if (firstLetter == "a" || firstLetter == "e" || firstLetter == "i" || firstLetter == "o" || firstLetter == "u" || firstLetter == "y")
                    {
                        translatedSen = thingToTranslate + "ay";
                    }
                    else
                    {
                        translatedSen = restOfWord + firstLetter + "ay";
                    }
                    // Output translated word
                    Console.WriteLine(translatedSen);
                    Console.WriteLine();
                    Console.WriteLine();
                }

                // Ask if they want to translate another word
                Console.WriteLine("Would you like to translate another word?");
                string userInput = Console.ReadLine();

                // Continue or not based on user input
                if (userInput.Equals("yes", StringComparison.OrdinalIgnoreCase) || userInput.Equals("y", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Okay! Starting again");
                    keepTranslating = true;
                }
                else
                {
                    Console.WriteLine("Thanks for playing!");
                    keepTranslating = false;
                }
            }

        }
    }
}
