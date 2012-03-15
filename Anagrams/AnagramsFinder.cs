using System;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace Anagrams
{
    public class AnagramsFinder
    {
        private readonly List<string> _stringCollection;
        private Dictionary<string, List<string>> _anagrams;

        public AnagramsFinder(List<string> stringCollection)
        {
            _stringCollection = stringCollection;
            _anagrams = new Dictionary<string, List<string>>();
        }

        public Dictionary<string, List<string>> Find()
        {
          _stringCollection.ForEach(UpdateAnagramsCollection);
          return _anagrams;
        }

        private void UpdateAnagramsCollection(string word)
        {
            var sortedWord = SortCharactersAlphabetically(word);
            if (AnagramsKeyExists(sortedWord))
            {
                _anagrams.Add(sortedWord, new List<string> {word});
                return;
            }
            _anagrams[sortedWord].Add(word);
        }

        private bool AnagramsKeyExists(string sortedWord)
        {
            return !_anagrams.ContainsKey(sortedWord);
        }

        private static string SortCharactersAlphabetically(string word)
        {
            char[] wordInChars = word.ToCharArray();
            Array.Sort(wordInChars);
            string sortedWord = new string(wordInChars);
            return sortedWord;
        }
    }
}