using OpenQA.Selenium;
namespace vsc_test_project.Pages
{
    class HomePage : Page

    {
        public IWebElement travels_page_button;

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
            this.travels_page_button = this.driver.FindElement(By.XPath(".//a[text()='Путешествия']"));
        }

    }
}
