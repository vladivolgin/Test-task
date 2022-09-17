using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace WCounter
{
    class WordInfo
    {
        public string Word { get; set; }
        public int CountOfRepeat { get; set; }

        public WordInfo(string word)
        {
            Word = word;
        }

    }

    class WCounter
    {
        static string[] GetDistinctWords(string text)
        {
            text = string.Join(" ", text.Split(' ').Distinct());
            return text.Split(' ');
        }

        static int CountOfEncounters(string[] splText, string word)
        {
            int countEnc = 0;
            foreach (var wrd in splText)
                if (wrd.Equals(word))
                    countEnc++;

            return countEnc;
        }

        static string DeleteNonWords(string text)
        {
            Regex regex = new Regex(@"[A-Za-zА-ЯЁа-яё]\w+");
            MatchCollection matches = regex.Matches(text);
            return string.Join(" ", matches);
        }

        static string GetStringToWriteInFile(WordInfo word)
        {
            return word.Word + '\t' + Convert.ToString(word.CountOfRepeat) + '\n';
        }

        static void Main(string[] args)
        {
            string pathToReadText = "..\\test.txt";
            string text = File.ReadAllText(pathToReadText);

            text = text.ToLower();
            text = DeleteNonWords(text);

            string[] distWords = GetDistinctWords(text);

            string[] splitText = text.Split(' ');
            List<WordInfo> words = new List<WordInfo>();

            foreach (var word in distWords)
            {
                words.Add(new WordInfo(word));
                words.Last().CountOfRepeat = CountOfEncounters(splitText, word);
            }

            words = words.OrderByDescending(x => x.CountOfRepeat).ToList();


            string pathToWriteText = "..\\output.txt";
            File.WriteAllText(pathToWriteText, "");

            for (int i = 0; i < words.Count; i++)
            {
                string str2Write = GetStringToWriteInFile(words[i]);
                File.AppendAllText(pathToWriteText, str2Write);
            }
        }
    }
}
