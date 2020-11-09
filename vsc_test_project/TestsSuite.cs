using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Threading;
using vsc_test_project.Pages;

namespace vsc_test_project
{
    public class TestsSuite
    {
        protected IWebDriver driver;
        protected string country;

        [SetUp]
        public void Setup()
        {
            driver = Utils.goToUrl();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://shop.vsk.ru/");
            this.country = "Египет";
        }

        [Test]
        public void GetPolisTest()
        {
            HomePage home_page = new HomePage(driver);
            home_page.travels_page_button.Click();
            Thread.Sleep(TimeSpan.FromSeconds(3.0));
            Assert.AreEqual("https://shop.vsk.ru/travel", driver.Url);

            TravelsPage travelers_page = new TravelsPage(driver);
            travelers_page.buy_polis_button.Click();
            Thread.Sleep(TimeSpan.FromSeconds(3.0));

            Calculator_page calculator_page = new Calculator_page(driver);
            calculator_page.where_want_to_go_input.SendKeys(this.country + Keys.Enter);

            DateTime date_from = DateTime.Today.Date.AddDays(5);
            DateTime date_to = date_from.AddDays(10);

            calculator_page.period_from.Clear();
            calculator_page.period_from.SendKeys(date_from.ToString() + Keys.Tab);

            calculator_page.period_to.Clear();
            calculator_page.period_to.SendKeys(date_to.ToString() + Keys.Tab + Keys.End);

            calculator_page.next_step_button.Click();
        }
        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}