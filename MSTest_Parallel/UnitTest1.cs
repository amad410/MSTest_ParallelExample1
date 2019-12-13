using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

[assembly: Parallelize(Workers =2, Scope =ExecutionScope.MethodLevel)]
namespace MSTest_Parallel
{
    [TestClass]
    public class UnitTest1
    {
        IWebDriver driver;
        [TestMethod]
        public void TestMethod1()
        {
            driver.Navigate().GoToUrl("http://www.espn.com");
        }

        [TestMethod]
        public void TestMethod2()
        {
            driver.Navigate().GoToUrl("http://www.espn.com");
        }

        [TestInitialize]
        public void Setup()
        {
            driver = new ChromeDriver();
        }

        [TestCleanup]
        public void TearDown()
        {
            driver.Close();
        }
    }
}
