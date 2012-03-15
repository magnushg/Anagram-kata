using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;

namespace Anagrams
{
    public class WordFileReader
    {
        private readonly string _wordlistFileName;

        public WordFileReader(string wordlistFileName)
        {
            _wordlistFileName = wordlistFileName;
        }

        public List<string> Read()
        {
            List<string> words = new List<string>();
            using (var reader = new StreamReader(_wordlistFileName))
            {
                string word;
                while ((word = reader.ReadLine()) != null)
                {
                    words.Add(word);
                }
            }
            return words;
        }
    }
}