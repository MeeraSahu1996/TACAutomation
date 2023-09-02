using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using BoDi;
using FinanceModule.Utility;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using TechTalk.SpecFlow;

namespace FinanceModule.Hooks
{
    [Binding]
    public sealed class Hooks : ExtentReport
    {
        private readonly IObjectContainer _container;
        public static DateTime Time = DateTime.Now;
        public static String Filename = "Screenshot_" + Time.ToString("h_mm_ss") + ".png";

        public Hooks(IObjectContainer container)
        {
            _container = container;
        }
        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            Console.WriteLine("Running before test run...");
            ExtentReportInit();
        }

        [AfterTestRun]
        public static void AfterTestRun()
        {
            Console.WriteLine("Running after test run...");
            ExtentReportTearDown();
        }

        [BeforeFeature]
        public static void BeforeFeature(FeatureContext featureContext)
        {
            Console.WriteLine("Running before feature...");
            _feature = _extentReports.CreateTest<Feature>(featureContext.FeatureInfo.Title);
        }

        [AfterFeature]
        public static void AfterFeature()
        {
            Console.WriteLine("Running after feature...");
        }
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        [BeforeScenario("@finance")]
        public void BeforeScenarioWithTag()
        {
            // Example of filtering hooks using tags. (in this case, this 'before scenario' hook will execute if the feature/scenario contains the tag '@tag1')
            // See https://docs.specflow.org/projects/specflow/en/latest/Bindings/Hooks.html?highlight=hooks#tag-scoping

            //TODO: implement logic that has to run before executing each scenario
            Console.WriteLine("Running inside tagged hooks specflow");
        }

        [BeforeScenario(Order = 1)]
        public void FirstBeforeScenario(ScenarioContext scenarioContext)
        {
            // Example of ordering the execution of hooks
            // See https://docs.specflow.org/projects/specflow/en/latest/Bindings/Hooks.html?highlight=order#hook-execution-order

            //TODO: implement logic that has to run before executing each scenario
            IWebDriver driver = new ChromeDriver();
            //IWebDriver driver = new FirefoxDriver();
            //IWebDriver driver = new EdgeDriver();

            driver.Manage().Window.Maximize();
            _container.RegisterInstanceAs<IWebDriver>(driver);
            driver.Url = "https://test.trinityairmedical.com/";
            Thread.Sleep(5000);
            _scenario = _feature.CreateNode<Scenario>(scenarioContext.ScenarioInfo.Title);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            //TODO: implement logic that has to run after executing each scenario
            var driver = _container.Resolve<IWebDriver>();
            if (driver != null)
            {
                //driver.Quit();
            }
        }

        [AfterStep]
        public void AfterStep(ScenarioContext scenarioContext)
        {
            Console.WriteLine("Running after step....");
            string stepType = scenarioContext.StepContext.StepInfo.StepDefinitionType.ToString();
            string stepName = scenarioContext.StepContext.StepInfo.Text;

            var driver = _container.Resolve<IWebDriver>();

            //When scenario passed
            //if (scenarioContext.TestError == null)
            //{
            //    if (stepType == "Given")
            //    {
            //        _scenario.CreateNode<Given>(stepName).Pass(scenarioContext.StepContext.StepInfo.Text.ToString(),
            //            MediaEntityBuilder.CreateScreenCaptureFromBase64String(addScreenshot(driver, scenarioContext)).Build());
            //        //_feature.Log(Status.Pass, addScreenshot(driver, scenarioContext));
            //    }
            //    else if (stepType == "When")
            //    {
            //        _scenario.CreateNode<When>(stepName).Pass(scenarioContext.StepContext.StepInfo.Text.ToString(),
            //            MediaEntityBuilder.CreateScreenCaptureFromBase64String(addScreenshot(driver, scenarioContext)).Build());
            //        //_feature.Log(Status.Pass, addScreenshot(driver, scenarioContext));
            //    }
            //    else if (stepType == "Then")
            //    {
            //        _scenario.CreateNode<Then>(stepName).Pass(scenarioContext.StepContext.StepInfo.Text.ToString(),
            //            MediaEntityBuilder.CreateScreenCaptureFromBase64String(addScreenshot(driver, scenarioContext)).Build());
            //        //_feature.Log(Status.Pass, addScreenshot(driver, scenarioContext));
            //    }
            //    else if (stepType == "And")
            //    {
            //        _scenario.CreateNode<And>(stepName).Pass(scenarioContext.StepContext.StepInfo.Text.ToString(),
            //            MediaEntityBuilder.CreateScreenCaptureFromBase64String(addScreenshot(driver, scenarioContext)).Build());
            //        //_feature.Log(Status.Pass, addScreenshot(driver, scenarioContext));
            //    }
            //}
            if (scenarioContext.TestError == null)
            {
                if (stepType == "Given")
                {
                    _scenario.CreateNode<Given>(stepName).Pass(scenarioContext.StepContext.StepInfo.Text.ToString(), addScreenshot(driver, Filename));
                }
                else if (stepType == "When")
                {
                    _scenario.CreateNode<When>(stepName).Pass(scenarioContext.StepContext.StepInfo.Text.ToString(), addScreenshot(driver, Filename));
                }
                else if (stepType == "Then")
                {
                    _scenario.CreateNode<Then>(stepName).Pass(scenarioContext.StepContext.StepInfo.Text.ToString(), addScreenshot(driver, Filename));
                }
                else if (stepType == "And")
                {
                    _scenario.CreateNode<And>(stepName).Pass(scenarioContext.StepContext.StepInfo.Text.ToString(), addScreenshot(driver, Filename));
                }
            }
            //When scenario fails
            //if (scenarioContext.TestError != null)
            //{

            //    if (stepType == "Given")
            //    {
            //        _scenario.CreateNode<Given>(stepName).Fail(scenarioContext.TestError.Message,
            //        MediaEntityBuilder.CreateScreenCaptureFromBase64String(addScreenshot(driver, scenarioContext)).Build());
            //    }
            //    else if (stepType == "When")
            //    {
            //        _scenario.CreateNode<When>(stepName).Fail(scenarioContext.TestError.Message,
            //        MediaEntityBuilder.CreateScreenCaptureFromBase64String(addScreenshot(driver, scenarioContext)).Build());
            //    }
            //    else if (stepType == "Then")
            //    {
            //        _scenario.CreateNode<Then>(stepName).Fail(scenarioContext.TestError.Message,
            //        MediaEntityBuilder.CreateScreenCaptureFromBase64String(addScreenshot(driver, scenarioContext)).Build());
            //    }
            //    else if (stepType == "And")
            //    {
            //        _scenario.CreateNode<And>(stepName).Fail(scenarioContext.TestError.Message,
            //        MediaEntityBuilder.CreateScreenCaptureFromBase64String(addScreenshot(driver, scenarioContext)).Build());
            //    }
            //}
            if (scenarioContext.TestError != null)
            {

                if (stepType == "Given")
                {
                    _scenario.CreateNode<Given>(stepName).Fail(scenarioContext.TestError.Message, addScreenshot(driver, Filename));
                }
                else if (stepType == "When")
                {
                    _scenario.CreateNode<When>(stepName).Fail(scenarioContext.TestError.Message, addScreenshot(driver, Filename));
                }
                else if (stepType == "Then")
                {
                    _scenario.CreateNode<Then>(stepName).Fail(scenarioContext.TestError.Message, addScreenshot(driver, Filename));
                }
                else if (stepType == "And")
                {
                    _scenario.CreateNode<And>(stepName).Fail(scenarioContext.TestError.Message, addScreenshot(driver, Filename));
                }
            }
        }
    }
}