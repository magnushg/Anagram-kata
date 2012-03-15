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
            foreach (var anagramGroup in _anagrams.Where(anagramGroup => anagramGroup.Value.Count >= 2))
            {
                AppendToAnagramsOutput(anagramGroup);
            }
            _anagramsOutput.Append(string.Format("\r\nTotal anagrams groups: {0}", _anagrams.Count()));
            return _anagramsOutput.ToString();
        }

        private void AppendToAnagramsOutput(KeyValuePair<string, List<string>> anagramGroup)
        {
            foreach (var word in anagramGroup.Value)
            {
                _anagramsOutput.Append(string.Format("{0} ", word));
            }
            _anagramsOutput.Append("\r\n");
        }
    }
}