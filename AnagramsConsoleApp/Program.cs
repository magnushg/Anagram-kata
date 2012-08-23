using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using Anagrams;

namespace AnagramsConsoleApp
{
    class Program
    {
        private static WordFileReader _fileReader;
        private static IAnagramsFinder _anagramsFinder;
        private static AnagramsOutput _anagramsOutput;
        private static long _elapsedTime;

        static void Main(string[] args)
        {
            var stopWatch = Stopwatch.StartNew();

            FindAnagrams();

            stopWatch.Stop();
            _elapsedTime = stopWatch.ElapsedMilliseconds;

            OutputResults();
        }

        private static void OutputResults()
        {
            var output = _anagramsOutput.Output();
            WriteOutputToFile(output);
            Console.WriteLine(output);
            Console.WriteLine(string.Format("\r\nElapsed time with file read: {0} ms", _elapsedTime.ToString()));
            Console.ReadLine();
        }

        private static void FindAnagrams()
        {
            var fileName = @"input/wordlist.txt";
            _fileReader = new WordFileReader(fileName);
            _anagramsFinder = new AnagramsFinder(_fileReader.Read());
            _anagramsOutput = new AnagramsOutput(_anagramsFinder.Find());
        }

        private static void WriteOutputToFile(string output)
        {
            using (var writer = new StreamWriter("anagrams.txt"))
            {
                writer.Write(output);
            }
        }
    }
}
