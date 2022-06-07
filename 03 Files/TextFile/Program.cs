using System;
using System.IO;
using System.Collections.Generic;

namespace TextFile
{
    public class Program
    {
        public static Dictionary<string, int> CountWords(string pathToFile, 
            char hyphenSymbol='-')
        {
            Dictionary<string, int> wordsCount = new Dictionary<string, int>();
            StreamReader streamReader = new StreamReader(pathToFile);
            string line = string.Empty;

            while (streamReader.Peek() != -1)
            {
                line += streamReader.ReadLine();

                if (line.EndsWith(hyphenSymbol))
                    line = line.Remove(line.Length - 1);
                else
                    line += " ";
            }

            string[] allWords = line.Split(new char[] { '.', '?', '!', ' ', ';',
                ':', ',', '(', ')', '{', '}', '\\', '/', '"', '$', '_', '=', '<',
                '>'}, StringSplitOptions.RemoveEmptyEntries);
            foreach (string word in allWords)
            {
                if (wordsCount.ContainsKey(word))
                {
                    wordsCount[word]++;
                }
                else
                {
                    wordsCount.Add(word, 1);
                }
            }
            return wordsCount;
        }

        static void Main()
        {
            Console.WriteLine("Введите путь к файлу");
            string pathToFile = Console.ReadLine();

            Console.WriteLine($"Результат подсчёта слов:");
            foreach (KeyValuePair<string, int> keyValuePair in CountWords(pathToFile))
            {
                Console.WriteLine($"{keyValuePair}");
            }

        }
    }
}