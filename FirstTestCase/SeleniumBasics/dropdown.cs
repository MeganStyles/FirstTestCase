using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace FirstTestCase.SeleniumBasics
{
    class dropdown
    {
        [Test]
        public void DropdownMultiselect()
        {
            IWebDriver driver = new FirefoxDriver();

            //Put an implicit wait, this means that a search for an element will throw an exception 
            //  if it takes longer then the specified time
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));

            driver.Url = "http://toolsqa.wpengine.com/automation-practice-form/";

            //make a select element and set to the continents dropdown web element
            SelectElement cSelect = new SelectElement(driver.FindElement(By.Id("continents")));

            //Select a couple of options
            cSelect.SelectByIndex(1);
            //Using sleep command so that changes can be noticed
            Thread.Sleep(2000);
            cSelect.SelectByText("Africa");
            Thread.Sleep(2000);

            //make a list of the dropdowns
            IList<IWebElement> cList = cSelect.Options;

            int cLength = cList.Count;

            //loop through the list and print them
            for (int i = 0; i < cLength; i++)
            {
                String cValue = cList.ElementAt(i).Text;
                Console.WriteLine(cValue);

                if (cValue.Equals("Antartica"))
                {
                    cSelect.SelectByIndex(i);
                    break;
                }
            }
            Thread.Sleep(2000);

            driver.Close();
            
        }
    }
}
