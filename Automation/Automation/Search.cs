using NUnit;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Automation
{
    [TestClass]
    public class Search
    {
        [TestMethod]
        public void TestSearch()
        {
            IWebDriver driver = new ChromeDriver("D:/Automation/Automation/ChromeDriver/chromedriver.exe");


        }
    }
}
