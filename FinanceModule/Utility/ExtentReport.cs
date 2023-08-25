using AventStack.ExtentReports.Reporter.Configuration;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using SharpCompress.Common;

namespace FinanceModule.Utility
{
    public class ExtentReport
    {

        public static ExtentReports _extentReports;
        public static ExtentTest _feature;
        public static ExtentTest _scenario;

        public static String dir = AppDomain.CurrentDomain.BaseDirectory;
        public static String testResultPath = dir.Replace("bin\\Debug\\net6.0", "TestResults");
        public static String screenshotsPath = dir.Replace("bin\\Debug\\net6.0", "Screenshots");

        public static void ExtentReportInit()
        {
            if (Directory.Exists(screenshotsPath))
            {
                Directory.Delete(screenshotsPath, true);
            }

            Directory.CreateDirectory(screenshotsPath);
            var htmlReporter = new ExtentHtmlReporter(testResultPath);
            htmlReporter.Config.ReportName = "Automation Status Report";
            htmlReporter.Config.DocumentTitle = "Automation Status Report";
            htmlReporter.Config.Theme = Theme.Standard;
            htmlReporter.Start();

            _extentReports = new ExtentReports();
            _extentReports.AttachReporter(htmlReporter);
            _extentReports.AddSystemInfo("Application", "TrinityMedicalSolutions");
            _extentReports.AddSystemInfo("Browser", "Chrome");
            _extentReports.AddSystemInfo("OS", "Windows");

        }

        public static void ExtentReportTearDown()
        {



            string timestamp = DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss");
            string reportName = "Automation_Status_Report_" + timestamp;

            _extentReports.Flush();
            // Rename the report file
            string defaultReportFile = Path.Combine(testResultPath, "index.html");
            string renamedReportFile = Path.Combine(testResultPath, reportName + ".html");
            File.Move(defaultReportFile, renamedReportFile);
        }

        //public string addScreenshot(IWebDriver driver, ScenarioContext scenarioContext)
        //{
        //    char[] sap = { '!', '@', '#', '$', '%', '^', '&' , '*', '(',')'};
        //    ITakesScreenshot takesScreenshot = (ITakesScreenshot)driver;
        //    Screenshot screenshot = takesScreenshot.GetScreenshot();
        //    // string screenshotLocation = Path.Combine(testResultPath, scenarioContext.ScenarioInfo.Title + ".png");
        //    string screenshotLocation = Path.Combine(screenshotsPath, scenarioContext.StepContext.StepInfo.Text.Split(sap)[0] + ".png");

        //    screenshot.SaveAsFile(screenshotLocation, ScreenshotImageFormat.Png);

        //    byte[] imageArray = System.IO.File.ReadAllBytes(@screenshotLocation);
        //    string base64ImageRepresentation = Convert.ToBase64String(imageArray);


        //    return base64ImageRepresentation;
        //}

        public MediaEntityModelProvider addScreenshot(IWebDriver driver, string screenshotName)
        {
            ITakesScreenshot takesScreenshot = (ITakesScreenshot)driver;
            var screenshot = takesScreenshot.GetScreenshot().AsBase64EncodedString;
            return MediaEntityBuilder.CreateScreenCaptureFromBase64String(screenshot, screenshotName).Build();
        }
    }
}
