//Name: Thomas Robert
//Date: 9/19/16
//File: Program.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Words_to_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            String words;
            int asNum=0;
            int arrayIndex = 0;
            int stringIndex = 0;
            String[] wordsArray = new String[7];
            String[] num = { "", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "tweleve", "thirteen", "fourteen", "fiftenn", "sixteen", "seventeen", "eighteen", "nineteen" };
            String[] numTens = { "", "", "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninty" };

            Console.Write("Enter numbers: ");
            words = Console.ReadLine();

            //Sperates the words string into indivdual words stored in wordsArray
            do
            {
                wordsArray[arrayIndex] = words[stringIndex].ToString();
                stringIndex++;
                while (stringIndex<words.Length && words[stringIndex] != ' ')
                {
                    wordsArray[arrayIndex] += words[stringIndex].ToString();
                    stringIndex++;
                }
                stringIndex++;
                arrayIndex++;
            } while (arrayIndex < 7 && stringIndex<words.Length);

            //Testing words to wordsarray
            /*
            for (int i = 0; i < arrayIndex; i++)
                Console.WriteLine(wordsArray[i]);
            Console.WriteLine(arrayIndex);
            Console.ReadLine();
             */

            //Print number
            /*
            for (int i =0; i<arrayIndex; i++)
            {
                for (int j=0; j<num.Length; j++)
                {
                    if (wordsArray[i] == num[j])
                        Console.Write(j);
                }
                for (int j=0; j<numTens.Length; j++)
                {
                    if (wordsArray[i] == numTens[j])
                        Console.Write(j);
                }
            }

            Console.ReadLine();
             */

            //To int
            for (int i = 0; i < arrayIndex; i++)
            {
                for (int j = 0; j < num.Length; j++)
                {
                    if (wordsArray[i] == num[j])
                    {
                        if (wordsArray[i + 1] == "thousand")
                            asNum += j * 1000;
                        else if (wordsArray[i + 1] == "hundred")
                            asNum += j * 100;
                        else
                            asNum += j;
                    }

                }
                for (int j = 0; j < numTens.Length; j++)
                {
                    if (wordsArray[i] == numTens[j])
                        asNum += j * 10;
                }
                
            }
            Console.WriteLine("{0:C}", asNum);
            Console.ReadLine();

        }
    }
}
