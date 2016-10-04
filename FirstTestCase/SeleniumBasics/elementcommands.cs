using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using NUnit.Framework;

namespace FirstTestCase.SeleniumBasics
{
    class elementcommands
    {
        [Test]
        public void ElementComands()
        {
            IWebDriver driver = new FirefoxDriver();

            //open webpage in firefox
            driver.Url = "http://toolsqa.wpengine.com/automation-practice-form/";

            //fill in first name
            IWebElement firstName = driver.FindElement(By.Name("firstname"));
            firstName.SendKeys("Megan");

            //Fill in last name
            IWebElement lastName = driver.FindElement(By.Name("lastname"));
            lastName.SendKeys("Styles");

            //Click submit
            IWebElement submit = driver.FindElement(By.Id("submit"));
            submit.Click();

            //Close Browser
            driver.Close();

        }
    }
}
