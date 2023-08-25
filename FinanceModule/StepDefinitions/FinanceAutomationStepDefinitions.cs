using FinanceModule.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Net;

namespace FinanceModule.StepDefinitions
{
    [Binding]
    public sealed class FinanceAutomationStepDefinitions
    {
        private IWebDriver driver;
        FinanceAutomationPage financeAutomationPage;
        public FinanceAutomationStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
        }
        [Given(@"I choose to launch the application")]
        public void GivenIChooseToLaunchTheApplication()
        {
            //throw new PendingStepException();
        }


        [When(@"I choose to enter the email (.*)")]
        public void WhenIChooseToEnterTheEmail(String email)
        {
            financeAutomationPage = new FinanceAutomationPage(driver);
            financeAutomationPage.enterEmail(email);
        }

        [When(@"I choose to enter the password(.*)")]
        public void WhenIChooseToEnterThePassword(String password)
        {
            financeAutomationPage.enterPassword(password);
        }
        [When (@"I choose to click on submit button")]
        public void WhenIChooseToClickOnSubmitButton()
        {
            financeAutomationPage.clickSubmit();
        }
        [When(@"I choose to enter email (.*)")]
        public void WhenIChooseToEnterEmail(String email)
        {
            financeAutomationPage.verifyImage();
            financeAutomationPage.enterSecondEmail(email);
            Thread.Sleep(2000);
        }
        [When(@"I choose to enter password (.*)")]
        public void WhenIChooseToEnterPassword(String password)
        {
            financeAutomationPage.clickNextButton();
            financeAutomationPage.enterSecondPassword(password);
            financeAutomationPage.clickVerifyButton();
        }
        [Then(@"I choose to verify the login page")]
        public void ThenIChooseToVerifyTheLoginPage()
        {
            financeAutomationPage.verifyLogo();
        }
        [Then(@"I choose to verify the error login")]
        public void ThenIChooseToVerifyTheErrorLogin()
        {
            financeAutomationPage.verifyLogin();
        }
        [Then(@"I choose to click on manage customer")]
        public void ThenIChooseToClickOnManageCustomer()
        {
            financeAutomationPage.clickManageCustomer();
        }
        [Then(@"I choose to verify customer page")]
        public void ThenIChooseToVerifyCustomerPage()
        {
            financeAutomationPage.verifyManageCustomerPage();
        }
        [Then(@"I choose to verify total number of transactions")]
        public void ThenIChooseToVerifyTotalNumberOfTransactions()
        {
            financeAutomationPage.countEntries();
        }
        [When(@"I choose to enter search (.*)")]
        public void WhenIChooseToEnterSearchKey(String searchKey)
        {
            financeAutomationPage.enterSearchKey(searchKey);
        }
        [Then(@"I choose to click on demo customer")]
        public void ThenIChooseToClickOnDemoCustomer()
        {
            financeAutomationPage.clickDemoCustomer();
        }
        [When(@"I choose to get NSCustomerID")]
        public void WhenIChooseToGetNSCustomerID()
        {
            financeAutomationPage.getNSCusId();
        }
        [When(@"I choose to click on invoice settings")]
        public void WhenIChooseToClickOnInvoiceSettings()
        {
            financeAutomationPage.clickInvoiceSettings();
        }

        [When(@"I choose to change invoice settings")]
        public void WhenIChooseToChangeInvoiceSettings()
        {
            financeAutomationPage.changeInvoiceSettings();
        }

        [Then(@"I choose to verify invoice settings")]
        public void ThenIChooseToVerifyInvoiceSettings()
        {
            financeAutomationPage.verifyInvoiceSetting();
        }

        [When(@"I choose to click on edit button")]
        public void WhenIChooseToClickOnEditButton()
        {
           financeAutomationPage.clickEdit();
            //financeAutomationPage.clickAddNewRateEdit();
        }
        [When(@"I choose to click on remove button")]
        public void WhenIChooseToClickOnRemoveButton()
        {
            financeAutomationPage.clickRemove();
        }
        [When(@"I choose to verify remove request")]
        public void WhenIChooseToVerifyRemoveRequest()
        {
            financeAutomationPage.VerifyRemoveRequest();
        }

        [When(@"I choose to click on Add New Rate Setting")]
        public void WhenIChooseToClickOnAddNewRateSetting()
        {
            financeAutomationPage.clickAddNewRateEdit();
        }


        [When(@"I choose to select type(.*)")]
        public void WhenIChooseToSelectType(String type)
        {
            financeAutomationPage.selectType(type);
        }


        [When(@"I choose to select transport type(.*)")]
        public void WhenIChooseToSelectTransportType(String transportType)
        {
            financeAutomationPage.selectTransportType(transportType);
        }
        [When(@"I choose to enter quantity(.*)")]
        public void WhenIChooseToEnterQuantity(String quantity)
        {
            financeAutomationPage.enterQuantity(quantity);
        }
        [When(@"I choose to save the record")]
        public void WhenIChooseToSaveTheRecord()
        {
            financeAutomationPage.saveEdit();
        }
        [When(@"I choose to enter unitvalue(.*)")]
        public void WhenIChooseToEnterUnitValue(String unit)
        {
            financeAutomationPage.enterUnitValue(unit);
        }
        [When(@"I choose to enter rate(.*)")]
        public void WhenIChooseToEnterRate(String rate)
        {
            financeAutomationPage.enterRate(rate);
        }
        [When(@"I choose to click on service request")]
        public void ThenIChooseToClickOnServiceRequest()
        {
            financeAutomationPage.clickServiceRequest();
        }
        [Then(@"I choose to verify service page")]
        public void ThenIChooseToVerifyServicePage()
        {
            financeAutomationPage.verifyServicePage();
        }
        [When(@"I choose to select from date")]
        public void WhenIChooseToSelectFromDate()
        {
            financeAutomationPage.enterFromDate();
        }
        [When(@"I choose to click on generate invoice")]
        public void WhenIChooseToClickOnGenerateInvoice()
        {
            financeAutomationPage.generateInvoice();
        }
        [When(@"I choose to select on Demo Customer")]
        public void WhenIChooseToSelectOnDemoCustomer()
        {
            throw new PendingStepException();
        }

        [When(@"Apply filter")]
        public void WhenApplyFilter()
        {
            throw new PendingStepException();
        }


        [Then(@"I choose to verify invoice page")]
        public void ThenIChooseToVerifyInvoicePage()
        {
            financeAutomationPage.verifyInvoice();
        }
        [When(@"I choose to Verify saved record")]
        public void WhenIChooseToVerifySavedRecord()
        {
            financeAutomationPage.VerifySavedRecord();
        }

        [Then(@"I choose to upload file(.*)")]
        public void ThenIChooseToUploadFile(String filename)
        {
            financeAutomationPage.uploadFile(filename);
        }
        [When(@"I choose to edit unos(.*)")]
        public void WhenIChooseToEditUnos(String text)
        {
            financeAutomationPage.editUnosID(text);
        }

        [When(@"I choose to edit po(.*)")]
        public void WhenIChooseToEditPo(String text)
        {
            financeAutomationPage.editPo(text);
        }
        [When(@"I choose to edit vehicle category(.*)")]
        public void WhenIChooseToEditVehicleCategory(String vehicle)
        {
            financeAutomationPage.selectVehicle(vehicle);
        }

        [When(@"I choose to edit provider(.*)")]
        public void WhenIChooseToEditProvider(String type)
        {
            financeAutomationPage.selectProvider(type);
        }
        [Then(@"I choose to verify file uploaded")]
        public void ThenIChooseToVerifyFileUploaded()
        {
            financeAutomationPage.verifyUpload();
        }
        [Then(@"I choose to verify file deleted")]
        public void ThenIChooseToVerifyFileDeleted()
        {
            financeAutomationPage.delete();
            financeAutomationPage.verifyDeleted();
        }
        [Then(@"I choose to click on create netsuite and verify saved successfully")]
        public void ThenIChooseToClickOnCreateNetsuiteAndVerifySavedSuccessfully()
        {
            financeAutomationPage.clickSaveButton();
        }
        [When(@"I choose to verify home page")]
        public void WhenIChooseToVerifyHomePage()
        {
            financeAutomationPage.verifyLogoforHomePage();
        }

        [When(@"I choose to Click on Service Request option")]
        public void WhenIChooseToClickOnServiceRequestOption()
        {
            throw new PendingStepException();
        }

        [When(@"Service Request Page should open\.")]
        public void WhenServiceRequestPageShouldOpen_()
        {
            throw new PendingStepException();
        }

        [When(@"I choose to Click on Create Service Request button")]
        public void WhenIChooseToClickOnCreateServiceRequestButton()
        {
            throw new PendingStepException();
        }

        [When(@"I choose to Verify Create Service Request Page should open")]
        public void WhenIChooseToVerifyCreateServiceRequestPageShouldOpen()
        {
            throw new PendingStepException();
        }

        [When(@"I choose to Fill the Customer Info Section")]
        public void WhenIChooseToFillTheCustomerInfoSection()
        {
            throw new PendingStepException();
        }

        [When(@"Fill the Service Info Section")]
        public void WhenFillTheServiceInfoSection()
        {
            throw new PendingStepException();
        }

        [When(@"Fill the Trip Info section")]
        public void WhenFillTheTripInfoSection()
        {
            throw new PendingStepException();
        }

        [When(@"Click on Save")]
        public void WhenClickOnSave()
        {
            throw new PendingStepException();
        }

        [Then(@"Assign Coordinator")]
        public void ThenAssignCoordinator()
        {
            throw new PendingStepException();
        }

        [Then(@"Check for Success of Assign Coordinator")]
        public void ThenCheckForSuccessOfAssignCoordinator()
        {
            throw new PendingStepException();
        }

        [Then(@"Get the Trip ID No")]
        public void ThenGetTheTripIDNo()
        {
            throw new PendingStepException();
        }

        [Then(@"Add The leg info for Outbound")]
        public void ThenAddTheLegInfoForOutbound()
        {
            throw new PendingStepException();
        }

        [Then(@"Add The leg info for Inbound")]
        public void ThenAddTheLegInfoForInbound()
        {
            throw new PendingStepException();
        }

        [Then(@"Assign the legs to internal Driver")]
        public void ThenAssignTheLegsToInternalDriver()
        {
            throw new PendingStepException();
        }

        [Then(@"Go To Service Request page")]
        public void ThenGoToServiceRequestPage()
        {
            throw new PendingStepException();
        }

        [Then(@"Fill the Trip id in Trip ID Filter for input SRq no")]
        public void ThenFillTheTripIdInTripIDFilterForInputSRqNo()
        {
            throw new PendingStepException();
        }

        [Then(@"Apply the filter")]
        public void ThenApplyTheFilter()
        {
            throw new PendingStepException();
        }





    }
}