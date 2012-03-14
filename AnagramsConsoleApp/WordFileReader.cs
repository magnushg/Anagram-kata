using System.Collections.Specialized;
using System.IO;

namespace AnagramsConsoleApp
{
    public class WordFileReader
    {
        private readonly string _wordlistFileName;

        public WordFileReader(string wordlistFileName)
        {
            _wordlistFileName = wordlistFileName;
        }

        public StringCollection Read()
        {
            StringCollection words = new StringCollection();
            using (StreamReader reader = new StreamReader(_wordlistFileName))
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