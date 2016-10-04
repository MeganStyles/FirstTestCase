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
    class PracticeTest2
    {
        [Test]
        public void TestPractice2()
        {
            IWebDriver driver = new FirefoxDriver();

            //open the url
            driver.Url = "http://demoqa.com/frames-and-windows/";

            //click on the "new window" button
            driver.FindElement(By.XPath(".//*[@id='tabs-1']/div/p/a")).Click();

            //close the window
            driver.Quit();

        }
        
    }
}
