using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace AnagramsConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var fileName = @"input/wordlist.txt";
            WordFileReader fileReader = new WordFileReader(fileName);
            AnagramsFinder anagramsFinder = new AnagramsFinder(fileReader.Read());
            AnagramsOutput anagramsOutput = new AnagramsOutput(anagramsFinder.Find());
            Console.WriteLine(anagramsOutput.Output());
            Console.ReadLine();
        }
    }
}
