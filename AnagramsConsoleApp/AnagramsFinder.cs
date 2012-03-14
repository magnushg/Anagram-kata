using System;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace AnagramsConsoleApp
{
    public class AnagramsFinder
    {
        private readonly StringCollection _stringCollection;

        public AnagramsFinder(StringCollection stringCollection)
        {
            _stringCollection = stringCollection;
        }

        public Dictionary<string, List<string>> Find()
        {
            Dictionary<string, List<string>> anagrams = new Dictionary<string, List<string>>();
            foreach (var word in _stringCollection)
            {
                char[] wordInChars = word.ToCharArray();
                Array.Sort(wordInChars);
                string sortedWord = new string(wordInChars);
                if(!anagrams.ContainsKey(sortedWord))
                {
                    anagrams.Add(sortedWord, new List<string>{word});
                    continue;
                }
                anagrams[sortedWord].Add(word);
            }
            return anagrams;
        }
    }
}