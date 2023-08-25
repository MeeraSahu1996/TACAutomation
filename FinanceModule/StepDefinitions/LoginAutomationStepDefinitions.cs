//using OpenQA.Selenium;
//using OpenQA.Selenium.Chrome;

//namespace FinanceModule.StepDefinitions
//{
//    [Binding]
//    public sealed class FeatureStepDefinitions
//    {
//        private IWebDriver driver;

//        public FeatureStepDefinitions(IWebDriver driver)
//        {
//            this.driver = driver;
//        }

//        [Given (@"I choose to launch the application")]
//        public void GivenIChooseToLaunchTheApplication()
//        {
//            /*driver = new ChromeDriver();
//            driver.Manage().Window.Maximize();
//            driver.Url = "https://test.trinityairmedical.com/";
//            Thread.Sleep(5000);*/
//        }
//        [When (@"I choose to enter the correct credentials")]
//        public void WhenIChooseToEnterTheCorrectCredentials()
//        {
//            driver.FindElement(By.XPath("//input[@name='Email Address']")).SendKeys("TACAdministratorTest@trinityairmedical.com");
//            driver.FindElement(By.XPath("//input[@name='Password']")).SendKeys("xoAL@pf9tM");
//            driver.FindElement(By.XPath("//button[@type='submit']")).Click();
//            Thread.Sleep (3000);
//            Boolean flag = driver.FindElement(By.XPath("//img[contains(@alt,'Trinity Medical Solutions')]")).Displayed;
//        }
//        [When (@"I choose to click on sign in button")]
//        public void WhenIChooseToClickOnSignInButton()
//        {
//            driver.FindElement(By.XPath("//input[@autocomplete='username']")).SendKeys("TACAdministratorTest@trinityairmedical.com");
//            driver.FindElement(By.XPath("//input[@value='Next']")).Click();
//            Thread.Sleep(5000);
//            driver.FindElement(By.XPath("//input[@type='password']")).SendKeys("xoAL@pf9tM");
//            driver.FindElement(By.XPath("//input[@value='Verify']")).Click();
//            Thread.Sleep(10000);
//        }
        
//    }
//}