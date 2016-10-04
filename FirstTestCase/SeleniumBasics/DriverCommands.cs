using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FirstTestCase.SeleniumBasics;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace FirstTestCase.SeleniumBasics
{
    class DriverCommands
    {
        [Test]
        public void Test()
        {
            IWebDriver driver = new FirefoxDriver();

            //Launch the website
            driver.Url = "http://store.demoqa.com/";

            //Store Title name in a string
            string pageTitle = driver.Title;

            //store length of title in an int
            int titleLength = driver.Title.Length;

            //print out the title and the length
            Console.WriteLine("Page Title: " + pageTitle + " \n of length =" + titleLength);

            //save Url in a string
            string pageUrl = driver.Url;

            //save length of url in an int
            int urlLength = pageUrl.Length;

            //print out the url and the length
            Console.WriteLine("Page Url: " + pageUrl + " \n of length =" + urlLength);

            //save the page source in a string
            string pageSource = driver.PageSource;

            //save the length of the pagesource in an int
            int sourceLength = pageSource.Length;

            //print the page source and the length in console
            Console.WriteLine("Page Source: Is fricken long!" + " \n of length =" + sourceLength);

            //pause and wait for user to hit enter
            Console.ReadLine();

            //Close the browser
            driver.Quit();
        }
       

      

        
       
    }
}
