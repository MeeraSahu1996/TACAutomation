using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TrinityAirMedical.Utility
{
    public static class Toast
    {
        public static void SuccessToast(IWebDriver driver)
        {
            By eleIdentifier = By.XPath("//div[@class='toast-title ng-star-inserted']");
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
                wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(eleIdentifier));
                bool flag = driver.FindElement(eleIdentifier).Text.Contains("Success");
                Assert.IsTrue(flag, "Success toastTitle is not displayed");
            }
            catch (Exception e)
            { 
                Console.WriteLine("Report-wait timeout!! Couldn't find element-" + e.Message);
                throw new Exception(e.Message);
            }           

        }
        public static void WarningToast(IWebDriver driver)
        {
            By eleIdentifier = By.XPath("//div[@class='toast-title ng-star-inserted']");
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(90));
                wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(eleIdentifier));
                bool flag = driver.FindElement(eleIdentifier).Text.Contains("Warning");
                Assert.IsTrue(flag, "Warning toastTitle is not displayed");
            }
            catch (Exception e)
            {
                Console.WriteLine("Report-wait timeout!! Couldn't find element-" + e.Message);

                throw new Exception(e.Message);
            }

        }
        public static void InformationToast(IWebDriver driver)
        {
            By eleIdentifier = By.XPath("//div[@class='toast-title ng-star-inserted']");
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(90));
                wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(eleIdentifier));
                bool flag = driver.FindElement(eleIdentifier).Text.Contains("Information");
                Assert.IsTrue(flag, "Information toastTitle is not displayed");
            }
            catch (Exception e)
            {
                Console.WriteLine("Report-wait timeout!! Couldn't find element-" + e.Message);

                throw new Exception(e.Message);
            }

        }
    }
}
