﻿using System.Collections.Specialized;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using AnagramsConsoleApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AnagramsTests
{
    [TestClass]
    public class AnagramsFinderTests
    {
        [TestMethod]
        public void Should_Not_Find_Anagrams_In_Empty_Input()
        {
            AnagramsFinder anagramsFinder = new AnagramsFinder(new StringCollection());

            Dictionary<string, List<string>> anagrams = anagramsFinder.Find();

            Assert.AreEqual(0, anagrams.Count);
        }

        [TestMethod]
        public void Should_Find_One_Anagram_Group_When_Input_Contains_Two_Words_Are_Anagrams()
        {
            AnagramsFinder anagramsFinder = new AnagramsFinder(new StringCollection
                                                                   {
                                                                       "love", "hate", "war", "peace", "raw"
                                                                   });

            var anagrams = anagramsFinder.Find();

            Assert.AreEqual(4, anagrams.Count());
        }

        [TestMethod]
        public void Should_Find_Multiple_Anagram_Groups_When_Input_Contains_Serveral_Words_That_Are_Anagrams()
        {
            AnagramsFinder anagramsFinder = new AnagramsFinder(new StringCollection
                                                                   {
                                                                      "kinship", "pinkish", "enlist", "inlets", "listen", "silent", "boaster", "boaters", "borates", "fresher", "refresh", "sinks", "skins", "knits", "stink", "rots", "sort"
                                                                   });
            var anagrams = anagramsFinder.Find();

            Assert.AreEqual(7, anagrams.Count());

        }
    }
}
