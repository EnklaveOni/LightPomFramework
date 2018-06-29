using System;
using System.IO;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;

namespace TDDPractice
{
    [TestClass]
    [TestCategory("TDDPractice")]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var driver = GetChromeDriver();
            var complicatedPage = new ComplicatedPage(driver);
            complicatedPage.Open();
        }

        private IWebDriver GetInternetExplorerDriver()
        {
            var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            return new InternetExplorerDriver(outPutDirectory);
        }

        private IWebDriver GetFireFoxDriver()
        {
            var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            return new FirefoxDriver(outPutDirectory);
        }

        private IWebDriver GetChromeDriver()
        {
            var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            return new ChromeDriver(outPutDirectory);
        }
    }
}
