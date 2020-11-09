using OpenQA.Selenium;

namespace vsc_test_project.Pages
{
    class Calculator_page : Page
    {
        public IWebElement where_want_to_go_input;
        public IWebElement period_from;
        public IWebElement period_to;
        public IWebElement next_step_button;
        public Calculator_page(IWebDriver driver)
        {
            this.driver = driver;
            this.where_want_to_go_input = this.driver.FindElement(By.XPath(".//input[@id='something']"));
            this.period_from = this.driver.FindElement(By.XPath(".//p[.='Дата начала']/ancestor::div/ctrl-dpicker/div/input"));
            this.period_to = this.driver.FindElement(By.XPath(".//p[.='Дата окончания']/ancestor::div/ctrl-dpicker/div/input"));
            this.next_step_button = this.driver.FindElement(By.XPath(".//button[@id='next_step']"));
        }
        
    }
}
