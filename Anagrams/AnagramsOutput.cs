using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anagrams
{
    public class AnagramsOutput
    {
        private readonly Dictionary<string, List<string>> _anagrams;
        private StringBuilder _anagramsOutput;

        public AnagramsOutput(Dictionary<string, List<string>> anagrams)
        {
            _anagrams = anagrams;
            _anagramsOutput = new StringBuilder();
        }

        public string Output()
        {
            _anagrams.Values.ToList().ForEach(word => _anagramsOutput.AppendLine(string.Join(" ", word)));
            _anagramsOutput.Append(string.Format("\r\nTotal anagrams groups: {0}", _anagrams.Count()));
            return _anagramsOutput.ToString();
        }
    }
}