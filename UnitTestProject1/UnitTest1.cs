using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MvcDuckDuck.Controllers;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Threading.Tasks;
using NSubstitute;
using MvcDuckDuck;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void chetTest() {
            var mocParser = Substitute.For<IParser>();
            List<string> testList = new List<string>();
            List<string> resultList = new List<string>();

            for (int i = 0; i < 15; i++) { testList.Add("String"); }
            resultList=mocParser.getChet(testList);
            Assert.AreEqual(8, resultList.Count());
        }
        [TestMethod]
        public void neChetTest() {
            var mocParser = Substitute.For<IParser>();
            List<string> testList = new List<string>();
            List<string> resultList = new List<string>();

            for (int i = 0; i < 15; i++) { testList.Add("String"); }
            resultList = mocParser.getChet(testList);
            Assert.AreEqual(8, resultList.Count());
        }
        
    }
}
