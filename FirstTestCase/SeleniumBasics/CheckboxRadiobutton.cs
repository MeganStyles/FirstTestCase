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
    class CheckboxRadiobutton
    {
        [Test]
        public void CheckBoxRadioButton()
        {
            IWebDriver driver = new FirefoxDriver();

            //open new website in firefox
            driver.Url = "http://toolsqa.wpengine.com/automation-practice-form/";

            //put radio buttons for sex in a list
            IList <IWebElement> sexList = driver.FindElements(By.Name("sex"));

            //store size of sexlist in int
            int sexSize = sexList.Count;

            

            //loop through list using size
            for (int i = 0; i < sexSize; i++)
            {
                //store the value as a string
                string sexValue = sexList.ElementAt(i).GetAttribute("value");

                //if value is female
                if (sexValue.Equals("Female"))
                {
                    //then check the box
                    sexList.ElementAt(i).Click();
                    break;
                }
                //create a boolean and assign to false
                Boolean bValue = false;

                //boolean is now true because element 0 is selected (we just did it)
                bValue = sexList.ElementAt(0).Selected;
                
                //if boolean is true
                if (bValue == true)
                {
                    //then click the other button
                    sexList.ElementAt(1).Click();
                } else
                {
                    //if the first is not selected then select the first
                    sexList.ElementAt(0).Click();
                }

            }

            //select third radio button in experience
            driver.FindElement(By.Id("exp-2")).Click();

            //find the checkboxes for proffession and store in list
            IList<IWebElement> proffessionList = driver.FindElements(By.Name("profession"));

            //get the length of the list and store in int
            int proffessionLength = proffessionList.Count;

            //loop through list using length
            for (int i = 0; i < proffessionLength; i++)
            {
                //get value and store as string
                string proffessionValue = proffessionList.ElementAt(i).GetAttribute("value");

                //if value = automation tester
                if (proffessionValue.Equals("Automation Tester")) {
                    //then click checkbox
                    proffessionList.ElementAt(i).Click();
                    break;
                }
            }

            driver.FindElement(By.CssSelector("input[value = 'Selenium IDE']")).Click();

            driver.Close();


        }
    }
}
