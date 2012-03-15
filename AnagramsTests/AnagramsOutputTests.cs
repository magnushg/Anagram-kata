using System;
using System.Collections.Generic;
using System.Linq;
using Anagrams;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AnagramsTests
{
    [TestClass]
    public class AnagramsOutputTests
    {
        [TestMethod]
        public void Should_Output_Anagrams_On_One_Line_Per_Group_With_Anagrams_Groups_Count()
        {
            AnagramsOutput anagramsOutput = new AnagramsOutput(CreateAnagramsDictionary());

            string anagrams = anagramsOutput.Output();

            Assert.AreEqual("kinship pinkish \r\nenlist inlets listen silent \r\n\r\nTotal anagrams groups: 2", anagrams);
        }

        private Dictionary<string, List<string>> CreateAnagramsDictionary()
        {
            Dictionary<string, List<string>> anagrams = new Dictionary<string, List<string>>();
            anagrams.Add("1", new List<string> { "kinship", "pinkish" });
            anagrams.Add("2", new List<string> { "enlist", "inlets", "listen", "silent" });
            return anagrams;
        }
    }
}
