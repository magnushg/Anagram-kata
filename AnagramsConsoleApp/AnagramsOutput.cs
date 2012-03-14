using System.Collections.Generic;
using System.Text;

namespace AnagramsConsoleApp
{
    public class AnagramsOutput
    {
        private readonly Dictionary<string, List<string>> _anagrams;

        public AnagramsOutput(Dictionary<string, List<string>> anagrams)
        {
            _anagrams = anagrams;
        }

        public string Output()
        {
            StringBuilder anagramsOutput = new StringBuilder();
            foreach (var anagramGroup in _anagrams)
            {
                if (anagramGroup.Value.Count >= 2)
                {
                    foreach (var word in anagramGroup.Value)
                    {
                        anagramsOutput.Append(string.Format("{0} ", word));
                    }
                    anagramsOutput.Append("\r\n");
                }
            }
            return anagramsOutput.ToString();
        }
    }
}