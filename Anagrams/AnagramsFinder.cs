using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;

namespace Anagrams
{
    public class AnagramsFinder : IAnagramsFinder
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
          _stringCollection.Distinct()
               .GroupBy(str => String.Concat(str.ToLower().Trim().OrderBy(c => c)))
               .Where(g => g.Count() > 1).ToList()
               .ForEach(g => _anagrams.Add(g.Key, g.ToList()));
            return _anagrams;
        }
    }
}