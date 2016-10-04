using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace FirstTestCase.SeleniumBasics
{
    class elementcommands2
    {
        [Test]
        public void ElementCommands2()
        {
            IWebDriver driver = new FirefoxDriver();

            //new website open
            driver.Url = "http://toolsqa.wpengine.com/automation-practice-form/";

            //Use a partial link locator search with word "partial" and click on it
            driver.FindElement(By.PartialLinkText("Partial")).Click();
            Console.WriteLine("partial link test pass");

            //find submit button using it's tagname and convert it to a string
            string button = driver.FindElement(By.TagName("Button")).ToString();

            //print the button string to console
            Console.WriteLine(button);

            //click on "linkTest"
            driver.FindElement(By.LinkText("Link Test")).Click();
            Console.WriteLine("link text past");

            //close browser
            driver.Quit();



        }
    }
}
