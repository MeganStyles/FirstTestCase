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
    class navigation
    {
        [Test]
        public void Test3()
        {
            //create a new driver for firefox
            IWebDriver driver = new FirefoxDriver();

            //open the website
            driver.Url = "http://demoqa.com/";

            //click registration link
            driver.FindElement(By.XPath(".//*[@id='menu-item-374']/a")).Click();

            //return to homepage
            driver.Navigate().Back();

            //trial the forward button
            driver.Navigate().Forward();

            //trial the "to" command
            driver.Navigate().GoToUrl("http://demoqa.com/");

            //Trail the refresh command
            driver.Navigate().Refresh();

            //quit the browser
            driver.Quit();





        }
    }
}
