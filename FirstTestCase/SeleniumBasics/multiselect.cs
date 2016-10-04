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
    class multiselect
    {
        [Test]
        public void multiselectTest()
        {
            IWebDriver driver = new FirefoxDriver();

            driver.Url = "http://toolsqa.wpengine.com/automation-practice-form/";

            //make a new selectelement called sSelect at the multiselect box
            SelectElement sSelect = new SelectElement(driver.FindElement(By.Name("selenium_commands")));

            //select and then deselect something by index
            sSelect.SelectByIndex(0);
            Thread.Sleep(2000);
            sSelect.DeselectByIndex(0);
            Thread.Sleep(2000);

            //select and then deselect something else by text
            sSelect.SelectByText("Navigation Commands");
            Thread.Sleep(2000);
            sSelect.DeselectByText("Navigation Commands");
            Thread.Sleep(2000);

            //get options in multiselect into a list
            IList<IWebElement> sList = sSelect.Options;
            int sLength = sList.Count;

            //Print all the options in the multiselect
            for (int i = 0; i < sLength; i++)
            {
                String sValue = sList.ElementAt(i).Text;
                Console.WriteLine(sValue);

                //select all options
                sSelect.SelectByIndex(i);

                
            }
            sSelect.DeselectAll();
            Thread.Sleep(2000);

            driver.Close();
        }
    }
}
