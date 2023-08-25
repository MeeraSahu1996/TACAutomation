using FinanceModule.Utility;
using FluentAssertions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TechTalk.SpecFlow;
using Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http2.HPack;
using OpenQA.Selenium.Chrome;
using System.Linq.Expressions;



namespace FinanceModule.Pages
{
    public class FinanceAutomationPage
    {
        private IWebDriver driver;
        public FinanceAutomationPage(IWebDriver driver) 
        { 
            this.driver = driver;
        }
        By wEmail = By.XPath("//input[@name='Email Address']");
        By wPassword = By.XPath("//input[@name='Password']");
        By wSubmit = By.XPath("//button[@type='submit']");
        By wDoctorImage = By.XPath("//img[contains(@alt,'Trinity Medical Solutions')]");
        By wSecondEmail = By.XPath("//input[@autocomplete='username']");
        By wSecondPassword = By.XPath("//input[@type='password']");
        By wNext = By.XPath("//input[@value='Next']");
        By wVerifyButton = By.XPath("//input[@value='Verify']");
        By wVerifyLogo = By.XPath("//a[contains(@class,'logo lobo-padding')]");
        By errorLogin = By.XPath("//div[@class='error pageLevel']");
        By manageCustomer = By.XPath("//span[text()='Manage Customer']");
        By serviceRequest = By.XPath("//span[text()='Service Request']");
        By loader = By.XPath("//div[@class='loader']");
        By search = By.XPath("//input[@type='search']");
        By verifyManageCustomer = By.XPath("//strong[text()='Manage Customer']");
        By verifyService = By.XPath("//strong[text()='Service Request']");
        By entries = By.XPath("//div[contains(text(),'Showing 1 to 10')]");
        By demoCustomer = By.XPath("(//*[@class='cursorPointer text-color'])[1]");
        By customerDetail = By.XPath("//span[text()='Customer Detail']");
        By NSCustomerID = By.XPath("//div[text()=' NSCustomer ID :']/../div[2]");
        By invoiceSettigs = By.XPath("//button[@data-target='#invoiceDescriptionSetting']");
        By invoiceDescriptionSetting = By.XPath("//h4[text()='Invoice Description Setting']");
        By checkbox = By.XPath("//div[contains(text(),'Remove UnosId in description')]/..//input");
        By saveBtn = By.XPath("//button[text()='Save']");
        By saveBtnn = By.XPath("//button[text()='Save ']");
        By netsuite = By.XPath("//button[text()='Create in NetSuite']");
        By toastmsg = By.XPath("//div[@class='toast-message ng-star-inserted']");
        By toastTitle = By.XPath("//div[@class='toast-title ng-star-inserted']");

        By createSRqButton = By.XPath("//button[@title='Create Service Request']");
        By verifyCreateServiceRequest = By.XPath("//h1/strong[text()='Create Service Request']");
        By toast = By.Id("toast-container");
        By RemoveRateSetting = By.XPath("//button[@title='Remove']");

        By editRateSetting = By.XPath("//button[@title='Edit Rate Setting']");
        By addNewRateSetting = By.XPath("//button[@title='Add New Rate Setting']");
        By quantity = By.XPath("//input[@type='number' and @id='qty0']");
        By unitValue = By.XPath("//input[@type='number' and @id='airUnitValue0']");
        By rateValue = By.XPath("//input[@type='number' and @id='airRate0']");
        By calenderIcon = By.XPath("//i[@class='fa fa-calendar calendar-icon']");
        By fromDate = By.XPath("//input[@name='fromdate']");
        By completed = By.XPath("//span[text()=' Completed ']");
        By apply = By.XPath("//button[text()=' Apply ']");
        By moreButton = By.XPath("(//div[text()='Customer']/following-sibling::div[text()=' Demo Customer ']/../following-sibling::div[@id='action-buttons']//button[@title='More'])[1]");
        By generateInvoiceButton = By.XPath("(//div[text()='Customer']/following-sibling::div[text()=' Demo Customer ']/../following-sibling::div[@id='action-buttons']//button[@title='More']/following-sibling::div//button[@title='Generate Invoice'])[1]");
        By verifyInvoicePage = By.XPath("//strong[text()='Generate Invoice ']");
        By editUnos = By.XPath("//button[@title='Edit UNOS ID']");
        By UnosId = By.XPath("//input[@placeholder='UNOS ID']");
        By titleSave = By.XPath("//button[@title='Save']");
        By editPO = By.XPath("//button[@title='Edit PO#']");
        By PO = By.XPath("//*[@placeholder='PO Box']");
        By vehicleId = By.XPath("//select[@id='inputvehicleCategory0']");
        By selectId = By.XPath("//select[@id='providerSelection0']");
        By allowBilling = By.XPath("//div[text()='Allow Billing: ']/..//input");
        By isWaitReturn = By.XPath("//div[text()='Is Wait & Return: ']/..//input");
        By combinedLeg = By.XPath("//div[text()='Combined Leg: ']/..//input");
        By addFile = By.XPath("(//input[@type='file'])[1]");
        By removeFile = By.XPath("//a[contains(text(),' Screenshot.png ')]/../../..//div[4]//button[2]");
        By uploadingFile = By.XPath(" (//a[text()=' Add File '])[1]");







        public static String netSuiteCusID;
        public void enterEmail(string email) 
        {
            WaitHelper.CHighlightElement(driver, wEmail);
            driver.FindElement(wEmail).SendKeys(email);
            Thread.Sleep(1000);
        }
        public void enterPassword(string password)
        {
            WaitHelper.CHighlightElement(driver, wPassword);
            driver.FindElement(wPassword).SendKeys(password);
            Thread.Sleep(1000);
        }
        public void clickSubmit()
        {
            WaitHelper.CHighlightElement(driver, wSubmit);
            driver.FindElement(wSubmit).Click();   
        }
        public void verifyImage()
        {
            WaitHelper.CHighlightElement(driver, wDoctorImage);
            WaitHelper.cExplicitWait(driver, wDoctorImage, 30);
            Boolean flag = driver.FindElement(wDoctorImage).Displayed;
            Assert.IsTrue(flag, "The Doctor image is not displayed as per expectation.");
        }
        public void enterSecondEmail(String email)
        {
            WaitHelper.cExplicitWait(driver, wSecondEmail, 20);
            WaitHelper.CHighlightElement(driver, wSecondEmail);
            driver.FindElement(wSecondEmail).SendKeys(email);
            WaitHelper.cExplicitWait(driver, wNext, 10);
        }
        public void clickNextButton()
        {
            WaitHelper.CHighlightElement(driver, wNext);
            driver.FindElement(wNext).Click();
            Thread.Sleep(2000);
        }
        public void enterSecondPassword(String password)
        {
            WaitHelper.cExplicitWait(driver, wSecondPassword, 10);
            WaitHelper.CHighlightElement(driver, wSecondPassword);
            driver.FindElement(wSecondPassword).SendKeys(password);
            Thread.Sleep(1000);
        }
        public void clickVerifyButton()
        {
            WaitHelper.CHighlightElement(driver, wVerifyButton);
            driver.FindElement(wVerifyButton).Click();
            WaitHelper.cWaitForLoader(driver, 60);
            WaitHelper.cExplicitWait(driver, wVerifyLogo, 60);
        }
        public void verifyLogo()
        {
            Boolean flag =driver.FindElement(wVerifyLogo).Displayed;
            Assert.IsTrue(flag,"Logo is not displayed as per expectation.");
        }
        public void verifyLogin()
        {
            WaitHelper.cExplicitWait(driver, errorLogin, 40);
            String text = driver.FindElement(errorLogin).Text;
            bool flag = text.Equals("Login Failed - incorrect username or password.");
            Assert.IsTrue(flag,"The "+text+ " is not equals to expected text Login Failed - incorrect username or password.");
        }
        public void clickManageCustomer()
        {
            WaitHelper.cExplicitWait(driver, manageCustomer, 50);
            WaitHelper.CHighlightElement(driver, manageCustomer);
            driver.FindElement(manageCustomer).Click();
            WaitHelper.cWaitForLoader(driver, 20);
        }
        public void verifyManageCustomerPage()
        {
            WaitHelper.cExplicitWait(driver, verifyManageCustomer, 20);
            bool flag= driver.FindElement(verifyManageCustomer).Displayed;
            Assert.IsTrue(flag, "Manage Customer page is not opened");
            WaitHelper.CHighlightElement(driver, verifyManageCustomer);
        }
        
        public void countEntries()
        {
            WaitHelper.cScrollIntoViewUsingJavaScriptExecutor(driver, entries);
            int noOfTransactionEntries = int.Parse(driver.FindElement(entries).Text.Replace("Showing 1 to 10 of ","").Replace("entries","").Trim());
            IReadOnlyCollection<IWebElement> elements;
            elements= driver.FindElements(By.XPath("//*[@class='cursorPointer text-color']"));
            List<String> names = new List<String>();
            foreach (IWebElement namesElement in elements)
            {
                names.Add(namesElement.Text);
            }
            try
            {
                string nextButton = "//li[@class='pagination-next']";
                IWebElement nextButtonClass = driver.FindElement(By.XPath(nextButton));
                string nextButtonClassName = nextButtonClass.GetAttribute("class");
                while (!nextButtonClassName.Contains("disabled"))
                {
                    nextButtonClass.Click();
                    elements = driver.FindElements(By.XPath("//*[@class='cursorPointer text-color']"));
                    foreach (IWebElement namesElement in elements)
                    {
                        names.Add(namesElement.Text);
                        Thread.Sleep(2000);
                    }
                    nextButtonClassName = nextButtonClass.GetAttribute("class");
                }
            }
            catch(Exception e) { }
            bool flag = (names.Count.Equals(noOfTransactionEntries));
            Assert.IsTrue(flag,"The transaction entries text "+ noOfTransactionEntries+" is not to the transactions present in the list.");
        }

        public void enterSearchKey(string searchKey)
        {
            driver.FindElement(search).SendKeys(searchKey);
            IReadOnlyCollection<IWebElement> elements;
            elements = driver.FindElements(By.XPath("//*[@class='cursorPointer text-color']"));
            List<String> names = new List<String>();
            foreach (IWebElement namesElement in elements)
            {
                String text = namesElement.Text;
                bool flag = text.Contains(searchKey);
                Assert.IsTrue(flag, "Search functionality is not working as expected");
            }

        }
        public void clickDemoCustomer()
        {
            WaitHelper.cExplicitWait(driver, demoCustomer, 20);
            driver.FindElement(demoCustomer).Click();
            WaitHelper.CHighlightElement(driver, demoCustomer);
            WaitHelper.cExplicitWait(driver,customerDetail,20);
            bool flag = driver.FindElement(customerDetail).Displayed;
            Assert.IsTrue(flag, "Customer Detail page is not launched successfully");
        }
        public void getNSCusId()
        {
            WaitHelper.cExplicitWait(driver, NSCustomerID, 20);
            netSuiteCusID= driver.FindElement(NSCustomerID).Text;
            WaitHelper.CHighlightElement(driver, NSCustomerID);
        }
        public void clickInvoiceSettings()
        {
            Thread.Sleep(10000);
            WaitHelper.cExplicitWait(driver, invoiceSettigs, 20);
            WaitHelper.cScrollIntoViewUsingJavaScriptExecutor(driver, invoiceSettigs);
            driver.FindElement(invoiceSettigs).Click();
            WaitHelper.CHighlightElement(driver, invoiceSettigs);
            WaitHelper.cExplicitWait(driver, invoiceDescriptionSetting, 20);
            bool flag = driver.FindElement(invoiceDescriptionSetting).Displayed;
            Assert.IsTrue(flag, "Invoice Description Settings are not opened");
        }
        public void changeInvoiceSettings()
        {
            driver.FindElement(checkbox).Click();
            WaitHelper.CHighlightElement(driver, checkbox);
            driver.FindElement(saveBtn).Click();
            WaitHelper.CHighlightElement(driver, saveBtn);
            WaitHelper.cWaitForLoader(driver, 20);
        }
        public void verifyInvoiceSetting()
        {
            WaitHelper.cExplicitWaitForElementIsVisible(driver, toastTitle, 60);
            bool flag = driver.FindElement(toastTitle).Text.Equals("Success");
            Assert.IsTrue(flag, "Success message is not displayed");
            bool flag2 = driver.FindElement(toastmsg).Text.Equals("Invoice description setting successfully");
            Assert.IsTrue(flag2, "Success message is not displayed");
        }

        public void VerifyRemoveRequest()
        {
            bool flag = driver.FindElement(toastTitle).Text.Equals("Record Deleted");
            Assert.IsTrue(flag, "Success message is not displayed");
            bool flag2 = driver.FindElement(toastmsg).Text.Trim().Equals("Record Deleted Successfully");
            Assert.IsTrue(flag2, "Success message is not displayed");
        }

        public void clickEdit()
        {
            WaitHelper.cWaitForSpinner(driver, 40);
            driver.FindElement(editRateSetting).Click();
            WaitHelper.CHighlightElement(driver, editRateSetting);
            Thread.Sleep(2000);
        }
        public void clickRemove()
        {
            WaitHelper.cWaitForSpinner(driver, 40);
            driver.FindElement(RemoveRateSetting).Click();
            WaitHelper.CHighlightElement(driver, RemoveRateSetting);
            Thread.Sleep(2000);
        }
        public void clickAddNewRateEdit()
        {
            WaitHelper.cWaitForSpinner(driver, 40);
            driver.FindElement(addNewRateSetting).Click();
            WaitHelper.CHighlightElement(driver, addNewRateSetting);
            Thread.Sleep(2000);
        }
        public void selectType(String i)
        {
            WaitHelper.cWaitForSpinner(driver, 40);
            IWebElement element1 = driver.FindElement(By.XPath("(//div[@class='row_title']/../div[2])["+i+"]"));
            element1.Click();
            Thread.Sleep(2000);
        }

        public void selectTransportType(String transport)
        {
            try
            {
                IWebElement element = driver.FindElement(By.XPath("(//option[text()='" + transport + " '])[1]"));
                element.Click();
            }
            catch (Exception e) { Console.WriteLine("No pre-existing rate setting is available to edit"); }
        }

        public void enterQuantity(String qty)
        {
            driver.FindElement(quantity).Click();
            WaitHelper.CHighlightElement(driver, quantity);
            driver.FindElement(quantity).Clear();
            driver.FindElement(quantity).SendKeys(qty);
        }
        public void enterUnitValue(String unit)
        {
            driver.FindElement(unitValue).Click();
            WaitHelper.CHighlightElement(driver, unitValue);
            driver.FindElement(unitValue).Clear();
            driver.FindElement(unitValue).SendKeys(unit);
        }
        public void enterRate(String rate)
        {
            driver.FindElement(rateValue).Click();
            WaitHelper.CHighlightElement(driver, rateValue);
            driver.FindElement(rateValue).Clear();
            driver.FindElement(rateValue).SendKeys(rate);
        }
        public void saveEdit()
        {
            WaitHelper.cScrollIntoViewUsingJavaScriptExecutor(driver, saveBtnn);
            driver.FindElement(saveBtnn).Click();
            WaitHelper.CHighlightElement(driver, saveBtnn);
            WaitHelper.cWaitForLoader(driver, 100);
        }
        public void clickServiceRequest()
        {
            WaitHelper.cExplicitWait(driver, serviceRequest, 50);
            driver.FindElement(serviceRequest).Click();
            WaitHelper.CHighlightElement(driver, serviceRequest);
            WaitHelper.cWaitForLoader(driver, 20);
        }
        public void verifyServicePage()
        {
            WaitHelper.cExplicitWait(driver, verifyService, 20);
            bool flag = driver.FindElement(verifyService).Displayed;
            Assert.IsTrue(flag, "Service Reuest page is not opened");
        }

        public void enterFromDate()
        {
            driver.FindElement(fromDate).Clear();
            Thread.Sleep(1000);
            driver.FindElement(fromDate).SendKeys("01/22/2023");
            WaitHelper.CHighlightElement(driver, fromDate);
            Thread.Sleep(1000);
            driver.FindElement(completed).Click();
            WaitHelper.CHighlightElement(driver, completed);
            WaitHelper.cWaitForLoader(driver, 30);
            driver.FindElement(apply).Click();
            WaitHelper.CHighlightElement(driver, apply);
            WaitHelper.cWaitForLoader(driver, 40);
        }
        public void generateInvoice()
        {
            driver.FindElement(moreButton).Click();
            WaitHelper.CHighlightElement(driver, moreButton);
            driver.FindElement(generateInvoiceButton).Click();
            WaitHelper.CHighlightElement(driver, generateInvoiceButton);
            WaitHelper.cWaitForLoader(driver, 40);
        }
        public void verifyInvoice()
        {
            WaitHelper.cExplicitWait(driver, verifyInvoicePage, 20);
            bool flag = driver.FindElement(verifyInvoicePage).Displayed;
            Assert.IsTrue(flag, "Generate Invoice page is not opened");
        }

        public void VerifySavedRecord()
        {

            WaitHelper.cExplicitWaitForElementIsVisible(driver, toastmsg, 90);
            bool flag2 = driver.FindElement(toastmsg).Text.Trim().Equals("Record updated Successfully");
            Assert.IsTrue(flag2, "Record Not Save.");
        }

        public void uploadFile(string fileName)
        {
            Thread.Sleep(5000);
            WaitHelper.cScrollIntoViewUsingJavaScriptExecutor(driver, uploadingFile);
            driver.FindElement(addFile).SendKeys(fileName);
            WaitHelper.cWaitForLoader(driver, 40);
        }

        public void editUnosID(String text)
        {
            driver.FindElement(editUnos).Click();
            WaitHelper.CHighlightElement(driver, editUnos);
            driver.FindElement(UnosId).Clear();
            driver.FindElement(UnosId).SendKeys(text);
            WaitHelper.CHighlightElement(driver, UnosId);
            driver.FindElement(titleSave).Click();
            WaitHelper.CHighlightElement(driver, titleSave);
        }
        public void editPo(String text)
        {
            driver.FindElement(editPO).Click();
            WaitHelper.CHighlightElement(driver, editPO);
            driver.FindElement(PO).Clear();
            driver.FindElement(PO).SendKeys(text);
            WaitHelper.CHighlightElement(driver, PO);
            driver.FindElement(titleSave).Click();
        }

        public void selectVehicle(String vehicle)
        {
            try
            {
                driver.FindElement(selectId).Click();
                IWebElement ele = driver.FindElement(By.XPath("//option[text()='" + vehicle + "']"));
                ele.Click();
            }
            catch (Exception e) { Console.WriteLine("no leg availabe to edit"); }

        }

        public void selectProvider(String type)
        {
            driver.FindElement(selectId).Click();
            IWebElement ele = driver.FindElement(By.XPath("//option[text()='"+type+"']"));
            ele.Click();
        }

        public void verifyUpload()
        {
            Thread.Sleep(2000);
            bool flag = driver.FindElement(toastTitle).Text.Equals("Record Saved");
            Assert.IsTrue(flag, "Success message is not displayed");
            bool flag2 = driver.FindElement(toastmsg).Text.Equals("File Saved Successfully");
            Assert.IsTrue(flag2, "Success message is not displayed");
        }

        public void delete()
        {
            WaitHelper.cScrollIntoViewUsingJavaScriptExecutor(driver, removeFile);
            driver.FindElement(removeFile).Click();
            WaitHelper.CHighlightElement(driver, removeFile);
        }

        public void verifyDeleted()
        {
            Thread.Sleep(2000);
            WaitHelper.cExplicitWait(driver, toastTitle, 40);
            bool flag = driver.FindElement(toastTitle).Text.Equals("Success!");
            WaitHelper.CHighlightElement(driver, toastTitle);
            Assert.IsTrue(flag, "Success message is not displayed");
            bool flag2 = driver.FindElement(toastmsg).Text.Equals("Record Deleted Successfully");
            Assert.IsTrue(flag2, "Success message is not displayed");
        }

        public void clickSaveButton()
        {
            WaitHelper.cWaitForLoader(driver, 40);
            WaitHelper.cScrollIntoViewUsingJavaScriptExecutor(driver, saveBtn);
            driver.FindElement(netsuite).Click();
            WaitHelper.CHighlightElement(driver, netsuite
                );
            //Thread.Sleep(3000);
            //WaitHelper.cExplicitWait(driver, toast, 90);
            //bool flag = driver.FindElement(toast).Text.Equals("Success!");
            //Assert.IsTrue(flag, "Success message should display");
            bool flag = driver.FindElement(toastmsg).Text.Trim().Equals("Record Save Successfully.");
            if (flag == false)
            {
                string msg = driver.FindElement(toastmsg).Text;
                Assert.True(false, msg);
            }
            WaitHelper.cExplicitWaitForElementIsVisible(driver, toastmsg, 90);
            bool flag2 = driver.FindElement(toastmsg).Text.Trim().Equals("Record Save Successfully.");
            Assert.IsTrue(flag2, "'Record Save Successfully.' message should display");

            Thread.Sleep(2000);
            WaitHelper.cExplicitWaitForElementIsVisible(driver, toastmsg, 90);
            bool flag3 = driver.FindElement(toastmsg).Text.Equals("NS Invoice Created Successfully");
            Assert.IsTrue(flag3, "'NS Invoice Created Successfully' message should display");
        }
        public void verifyLogoforHomePage()
        {
            WaitHelper.cWaitForLoader(driver, 30);
            WaitHelper.cExplicitWait(driver, wVerifyLogo, 40);
            Boolean flag = driver.FindElement(wVerifyLogo).Displayed;
            Assert.IsTrue(flag, "Logo is not displayed as per expectation.");
        }
        public void ClickOnCreateServiceRequestButton()
        {
            WaitHelper.cExplicitlyWaitForElementToBeClickable(driver, createSRqButton, 90);
            driver.FindElement(createSRqButton).Click();
            WaitHelper.cWaitForLoader(driver, 90);
        }
        
        public void VerifyCreateServiceRequestPageOpened()
        {
            WaitHelper.cExplicitWait(driver, verifyCreateServiceRequest, 20);
            bool flag = driver.FindElement(verifyCreateServiceRequest).Displayed;
            Assert.IsTrue(flag, "Create Service Request page is not opened");
        }


    }
}
