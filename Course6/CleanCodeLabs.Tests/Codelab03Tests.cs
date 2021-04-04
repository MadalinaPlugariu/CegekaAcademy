using System;
using System.IO;
using System.Text;
using CleanCodeLabs.Codelab03;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CleanCodeLabs.Tests
{
    [TestClass]
    public class Codelab03Tests
    {
        private const string _expectedResult =
            @"Quack...
Quack Quack... (in a robot voice)
Swim...
";

        private StringBuilder _fakeOutput;

        [TestInitialize]
        public void Initialize()
        {
            _fakeOutput = new StringBuilder();
            Console.SetOut(new StringWriter(_fakeOutput));
        }

        [TestMethod]
        public void TestDuckApplication()
        {
            DuckApplication.Start();
            Assert.AreEqual(_expectedResult, _fakeOutput.ToString());
        }
    }
}