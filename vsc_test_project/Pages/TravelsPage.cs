using OpenQA.Selenium;

namespace vsc_test_project.Pages
{
    internal class TravelsPage : Page
    {
        public IWebElement buy_polis_button;

        public TravelsPage(IWebDriver driver)
        {
            this.driver = driver;
            this.buy_polis_button = this.driver.FindElement(By.XPath(".//button[@id='travel_banner_button_buy']"));
        }
    }
}
