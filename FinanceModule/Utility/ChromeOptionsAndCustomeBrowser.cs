using FinanceModule.Utility;
using NUnit.Framework;
using OpenQA.Selenium;

namespace TrinityAirMedical.Utility
{

    public static class ChromeOptionsAndCustomeBrowser
    {

        public static void AddUserProfilePreference(IWebDriver driver, By downloadLink, string fileName)
        {

            WaitHelper.cExplicitlyWaitForElementToBeClickable(driver, downloadLink, 30);
            driver.FindElement(downloadLink).Click();

            //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            //wait.Until(driver => IsFileDownloaded(fileName));

            Thread.Sleep(3000);
            bool value = IsFileDownloaded(fileName);
            Assert.IsTrue(value, "The downloaded successfully ");
            if (value)
            {
                DeleteDownloadedFile(fileName);
            }
            else
            {
                Assert.Fail("The file was not downloaded or could not be found.");
            }

        }
        private static bool IsFileDownloaded(string fileName)
        {
            
            string downloadPath = @"C:\Users\ASUS\Downloads";
            string filePath = Path.Combine(downloadPath, fileName);
            return File.Exists(filePath);
        }

        private static void DeleteDownloadedFile(string fileName)
        {
            string downloadPath = @"C:\Users\ASUS\Downloads";
            string filePath = Path.Combine(downloadPath, fileName);

            try
            {
                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                    Console.WriteLine($"File {fileName} has been deleted successfully.");
                }
                else
                {
                    Console.WriteLine($"File {fileName} does not exist in the download directory.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while deleting the file: {ex.Message}");
            }
        }

    }
}

