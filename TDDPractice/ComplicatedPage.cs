using OpenQA.Selenium;
using System;

namespace TDDPractice
{
    internal class ComplicatedPage
    {
        public ComplicatedPage(IWebDriver driver)
        {
            Driver = driver;
        }

        public IWebDriver Driver { get; }

        internal void Open()
        {
            Driver.Navigate().GoToUrl("https://www.ultimateqa.com/complicated-page/");
        }
    }
}