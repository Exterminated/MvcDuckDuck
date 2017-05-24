using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using NSubstitute;
using MvcDuckDuck;

namespace UnitTest_MVCDuckDuck
{
    [TestClass]
    public class UnitTest_MVCDuckDuck
    {
        [TestMethod]
        public void chetTest() {
            var mocParser = Substitute.For<IParser>();
            List<string> testList = new List<string>();
            List<string> resultList = new List<string>();
            int count = 0;

            for (int i = 0; i < 5; i++) { testList.Add("String"); }

            resultList.AddRange(testList.GetRange(0, 3));

            mocParser.getChet(testList).Returns(resultList);

            count = mocParser.getChet(testList).Count;

            Assert.AreEqual(3, count);

        }
        [TestMethod]
        public void neChetTest() {
            var mocParser = Substitute.For<IParser>();
            List<string> testList = new List<string>();
            List<string> resultList = new List<string>();
            int count = 0;

            for (int i = 0; i < 5; i++) { testList.Add("String"); }

            resultList.AddRange(testList.GetRange(0, 2));

            mocParser.getNeChet(testList).Returns(resultList);

            count = mocParser.getNeChet(testList).Count;

            Assert.AreEqual(2, count);
        }
        
    }
}
