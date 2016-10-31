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
                Console.WriteLine("Please enter a word to be translated.");
                string word = Console.ReadLine();
                //string word = englishWord.ToLower();
                string[] array = word.Split();

                string pigLatin;
                string extraLetters;
                char[] vowel = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
                int firstVowel = word.IndexOfAny(vowel);

                foreach (string value in array)
                {

                    if (value == "")
                    {
                        Console.WriteLine("Error. Please enter a word to be translated.");
                    }

                    if (vowel.Contains(value[0]))
                    {
                        string newWord = value + "way" + " ";
                        Console.Write(newWord);
                    }
                    else
                    {
                        extraLetters = value.Substring(firstVowel);
                        pigLatin = extraLetters + word.Substring(0, firstVowel);
                        Console.Write(pigLatin + "ay" + " ");
                    }

                    if (firstVowel == -1)
                    {
                        string newWord = value + "ay" + " ";
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

