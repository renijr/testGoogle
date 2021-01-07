using NUnit.Framework;
using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestGoogle
{
    public class Tests
    {

        IWebDriver driver;
        string textSearch = "Concert Technologies";
        string urlBase = "https://www.google.com/";

        [SetUp]
        public void Setup()
        {
            var options = new ChromeOptions();
            options.AddArgument("no-sandbox");
            //options.AddArgument("--headless");
            driver = new ChromeDriver(options);
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(urlBase);
        }

        [Test]
        public void Test1()
        {
            Thread.Sleep(5000);
            IWebElement linkGmail = driver.FindElement(By.CssSelector("div.gb_h:nth-child(1) > a:nth-child(1)"));

           // linkGmail.Click();
           // Thread.Sleep(8000);

            //IWebElement gmailCheck = driver.FindElement(By.CssSelector("body > div.hercules-header.h-c-header.h-c-header--product-marketing-one-tier.header--desktop > div.h-c-header__bar > div.h-c-header__lockup > div.h-c-header__product-logo > div > span"));
            //Console.WriteLine(gmailCheck.Text);
            Console.WriteLine(linkGmail.Text);
            Assert.IsTrue(linkGmail.Text == "Gmail");
        }

        [TearDown]
        public void Close()
        {
            Thread.Sleep(3000);
            driver.Close();
        }
    }
}