using System;
using System.IO;
using System.Text;
using CleanCodeLabs.Codelab04;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CleanCodeLabs.Tests
{
    [TestClass]
    public class Codelab04Tests
    {
        private const string _expectedResult =
            @"Doing some hard work, but I do get tired
Working like a true working horse
DOING SO MUCH WORK, BEEP
Eating my 'bokes'
Eating some jummy hay!
RECHARGING BATTERIES, BEEP
";

        private StringBuilder _fakeOutput;

        [TestInitialize]
        public void Initialize()
        {
            _fakeOutput = new StringBuilder();
            Console.SetOut(new StringWriter(_fakeOutput));
        }

        [TestMethod]
        public void TestFactory()
        {
            FactoryApp.Run();
            var output = _fakeOutput.ToString();
            Assert.AreEqual(_expectedResult, output);
        }
    }
}