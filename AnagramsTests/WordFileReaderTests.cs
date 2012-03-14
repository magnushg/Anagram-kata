using System;
using System.Collections.Specialized;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using AnagramsConsoleApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AnagramsTests
{
    [TestClass]
    public class WordFileReaderTests
    {
        [TestMethod]
        [DeploymentItem("input/wordlist.txt")]
        public void Should_Read_Word_List_From_File_And_Output_Collection_Of_Strings()
        {
            WordFileReader reader = new WordFileReader("wordlist.txt");

            StringCollection words = reader.Read();
        }
    }
}
