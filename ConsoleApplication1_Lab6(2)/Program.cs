using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1_Lab6_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            // validate user input http://www.c-sharpcorner.com/UploadFile/87b416/validating-user-input-with-regular-expressions/
            Console.WriteLine("Welcome to the Pig Latin Translator!" + Environment.NewLine);

            bool answer = true;
            while (answer)

            {
                Console.WriteLine("Please enter a sentance to be translated.");
                string sentence = Console.ReadLine();
                //string word = englishWord.ToLower();
                string[] wordsInSentence = sentence.Split();

                string pigLatin;
                string extraLetters;
                char[] vowel = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
                int firstVowel = sentence.IndexOfAny(vowel);
                char[] numbersSymbols = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '@', '#', '$', '%', '_' };

                foreach (string word in wordsInSentence)
                {

                    if (word == "")
                    {
                        Console.WriteLine("Error. Please enter a word to be translated.");
                    }

                    if (word.IndexOfAny(numbersSymbols) >= 0)
                    {
                        Console.Write(word);
                    }

                    else if (vowel.Contains(word[0]))
                    {
                        string newWord = word + "way" + " ";
                        Console.Write(newWord);
                    }
                    else
                    {
                        extraLetters = word.Substring(firstVowel);
                        pigLatin = extraLetters + sentence.Substring(0, firstVowel);
                        Console.Write(pigLatin + "ay" + " ");
                    }

                    if (firstVowel == -1)
                    {
                        string newWord = word + "ay" + " ";
                        Console.Write(newWord);
                    }
                }
                {
                    Console.WriteLine();
                    Console.WriteLine("Do you want to continue? Yes/No");
                    string response = Console.ReadLine();
                    if (!(response.ToLower() == "y" || response.ToLower() == "yes"))
                    {
                        answer = false;
                        Console.WriteLine("You may press enter to exit.");
                        Console.ReadKey();
                    }
                }
            }
        }
    }
}

