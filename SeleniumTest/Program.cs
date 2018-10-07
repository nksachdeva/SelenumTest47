using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using NUnit.Framework;

namespace SeleniumTest
{
    class Program
    {
        //Initialize driver
        IWebDriver driver = new InternetExplorerDriver();

        static void Main(string[] args)
        {
            
        }

        [SetUp]
        public void Initialize()
        {
            driver.Navigate().GoToUrl("https://www.google.com/");
            Console.WriteLine("Goto URL");
        }

        [Test]
        public void Execute()
        {
            //Perform Operations
            driver.FindElement(By.Name("q")).SendKeys("Selenium");
            Console.WriteLine("Do a search");
        }

        [TearDown]
        public void EndTest()
        {
            //Exit browser
            driver.Close();
            Console.WriteLine("Close Browser");

        }
    }
}
