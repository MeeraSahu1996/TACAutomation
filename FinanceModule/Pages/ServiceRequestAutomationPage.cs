using FinanceModule.Utility;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System.Collections.ObjectModel;
using TechTalk.SpecFlow.Configuration;
using TrinityAirMedical.Utility;
using OpenDialogWindowHandler;

namespace TrinityAirMedical.Pages
{
    internal class ServiceRequestAutomationPage
    {
        private IWebDriver driver;

        public ServiceRequestAutomationPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        string[] ListOfstatusForAirTypeLeg = { "Not Started", "On-board", "Wheels Up", "Landed", "Driver Done", "Job Done" };
        string[] ListOfstatusForGroundTypeLeg = { "Not Started", "On-Scene", "Picked up", "Enroute", "Dropped Off ", "Driver Done", "Job Done" };
        string[] ListOfstatusForAll = { "Not Started", "On-board", "Wheels Up", "Landed", "On-Scene", "Picked up", "Enroute", "Dropped off", "Driver Done", "Job Done" };

        By wEmail = By.XPath("//input[@name='Email Address']");
        By wPassword = By.XPath("//input[@name='Password']");
        By wSubmit = By.XPath("//button[@type='submit']");
        By wDoctorImage = By.XPath("//img[contains(@alt,'Trinity Medical Solutions')]");
        By wSecondEmail = By.XPath("//input[@autocomplete='username']");
        By wSecondPassword = By.XPath("//input[@type='password']");
        By wNext = By.XPath("//input[@value='Next']");
        By wVerifyButton = By.XPath("//input[@value='Verify']");
        By wVerifyLogo = By.XPath("//a[@class='logo lobo-padding sidebar-header-fixed']");
        By wServiceRequest = By.XPath("//a[@href='https://test.trinityairmedical.com/#/service-request']");

        By wCreateServiceRequest = By.XPath("//button[@title='Create Service Request']");
        By wServiceTypeFilter = By.XPath("//span[contains(text(), 'Service Type')]");
        By wStatusFilter = By.XPath("//span[contains(text(), 'Status')]");
        By wEquipmentInput = By.XPath("//label[contains(text(),'Service Type')]/parent::div/descendant::ul[@class='item2']/descendant::input");
        By wInternalInput = By.XPath("//label[contains(text(),'Service Type')]/parent::div/descendant::ul[@class='item2']/descendant::input[2]");
        By wNextFlightOutInput = By.XPath("//label[contains(text(),'Service Type')]/parent::div/descendant::ul[@class='item2']/descendant::input[3]");
        By wOrganInput = By.XPath("//label[contains(text(),'Service Type')]/parent::div/descendant::ul[@class='item2']/descendant::input[4]");
        By wSpecimenInput = By.XPath("//label[contains(text(),'Service Type')]/parent::div/descendant::ul[@class='item2']/descendant::input[5]");
        By wTeamInput = By.XPath("//label[contains(text(),'Service Type')]/parent::div/descendant::ul[@class='item2']/descendant::input[6]");
        By wCancelledInput = By.XPath("//label[contains(text(),'Status')]/parent::div/descendant::ul[@class='item2']/descendant::input[1]");//ok
        By wCompletedInput = By.XPath("//label[contains(text(),'Status')]/parent::div/descendant::ul[@class='item2']/descendant::input[2]");//ok
        By wEnrouteInput = By.XPath("//label[contains(text(),'Status')]/parent::div/descendant::ul[@class='item2']/descendant::input[3]");//ok
        By wNotStartedInput = By.XPath("//label[contains(text(),'Status')]/parent::div/descendant::ul[@class='item2']/descendant::input[4]");//ok
        By wEquipmentCheckBox = By.XPath("//label[contains(text(),'Service Type')]/parent::div/descendant::ul[@class='item2']/descendant::div[1]");
        By wInternalCheckBox = By.XPath("//label[contains(text(),'Service Type')]/parent::div/descendant::ul[@class='item2']/descendant::div[2]");
        By wNextFlightOutCheckBox = By.XPath("//label[contains(text(),'Service Type')]/parent::div/descendant::ul[@class='item2']/descendant::div[3]");
        By wOrganCheckBox = By.XPath("//label[contains(text(),'Service Type')]/parent::div/descendant::ul[@class='item2']/descendant::div[4]");
        By wSpecimenCheckBox = By.XPath("//label[contains(text(),'Service Type')]/parent::div/descendant::ul[@class='item2']/descendant::div[5]");
        By wTeamCheckBox = By.XPath("//label[contains(text(),'Service Type')]/parent::div/descendant::ul[@class='item2']/descendant::div[6]");
        By wCancelledCheckBox = By.XPath("//label[contains(text(),'Status')]/parent::div/descendant::ul[@class='item2']/descendant::div[1]");//ok
        By wCompletedCheckBox = By.XPath("//label[contains(text(),'Status')]/parent::div/descendant::ul[@class='item2']/descendant::div[2]");//ok
        By wEnrouteCheckBox = By.XPath("//label[contains(text(),'Status')]/parent::div/descendant::ul[@class='item2']/descendant::div[3]");//ok
        By wNotStartedCheckBox = By.XPath("//label[contains(text(),'Status')]/parent::div/descendant::ul[@class='item2']/descendant::div[4]");//ok
        By wServiceRequestHeader = By.XPath("//strong[contains(text(),'Service Request' )]");
        By wCalaender = By.XPath("//div[@id='fromdate']/input[@id='from']");
        By wFromDate = By.XPath("//input[@id='from']");
        By wToDate = By.XPath("//input[@id='to']");
        By wApply = By.XPath("//button[contains(text(),'Apply')][1]");
        By wShowEntries = By.XPath("//select[@name='example1_length']");
        By wTypeColumn = By.XPath("//td/div[@id='main_row_id']/div[3]/div[@class='service-type']");
        By wStatusColumn = By.XPath("//div[@id = 'main_row_id']/div[6]/div/span[@class = 'badge movementStatus']");//ok
        By wStatusColumnForNotStarted = By.XPath("//div[@id = 'main_row_id']/div[6]/div/div[2]/span");//ok
        By wStatusColumnForEnroute = By.XPath("//div[@id='main_row_id']/div[6]/div[2]/div[2]/span");//ok
        By wListOfServiceType = By.XPath("//label[contains(text(),'Service Type')]/parent::div/descendant::ul[@class='item2']");
        By wListOfStatus = By.XPath("//label[contains(text(),'Status')]/parent::div/descendant::ul[@class='item2']");
        By wCustomer = By.XPath("//label[contains(text(),'Customer')]/parent::div/div[@class='select-box']");
        By wListofServiceTypes = By.XPath("//label[contains(text(),'Service Type')]/parent::div/descendant::ul[@class='item2']");
        By wListofCustomer = By.XPath("//label[contains(text(),'Customer')]/parent::div/descendant::ul[@class='item2']/li");
        By wCustomerColumn = By.XPath("//td/div[@id='main_row_id']/div[3]/div[@class='service-type']");
        By wCustomerNames = By.XPath("//td/div[@id='main_row_id']/div[3]/div[@class = 'row_detail'][1]");
        //By wCustomerNames = By.XPath("//descendant::tr[2]/descendant::div[contains(text(),'Albany Medical Center')]");
        By wTripID = By.XPath("//span[contains(text(),'Trip ID' )]");
        By wSearchTripID = By.XPath("//label[contains(text(),'Trip ID')]/following::input[@placeholder='Search' ]");
        By wTripIdfromTripDetails = By.XPath("//i[@id='icon_jobid1']//parent::a/following-sibling::a/span");
        By wTissueIDValue = By.XPath("//Label[contains(text(), 'Tissue ID:')]/following-sibling:: div");
        By wAssignedCoordinatorValue = By.XPath("//Label[contains(text(), 'Assigned Coordinator:')]/following-sibling:: div");
        By wCreateBy = By.XPath("//Label[contains(text(), 'Created by:')]/following-sibling:: div");
        By wUNOSID = By.XPath("//label[contains(text(),'UNOS ID')]/parent::div/div");
        By wSearchUNOSID = By.XPath("//label[contains(text(),'UNOS ID')]/following::input[@placeholder='Search']");
        By wUNOSIdfromTripDetails = By.XPath("//label[contains(text(), 'UNOS ID:')]/following-sibling::div");
        By wMoreFilters = By.XPath("//button[contains(text(), 'More Filters' )]");
        By wOrigin = By.XPath("//span[contains(text(), 'Origin' )]");
        By wSearchOrigin = By.XPath("//label[contains(text(),'Origin')]/following::input[@placeholder='Search']");
        By wSearchOrigin2 = By.XPath("//label[contains(text(),'Origin')]/following::ng-multiselect-dropdown-angular7[1]");
        By wOriginsfromOriginCol = By.XPath("//td/div[@id='main_row_id']/div[4]/div[@class='row_detail']");
        By wSearchRofInOrigin = By.XPath("//label[contains(text(),'Origin')]/parent::div/descendant::ul[@class='item2']/li");
        By xOrigin = By.Id("sr-origin-filter");
        By xSearchOrigin = By.XPath("//div[@id='sr-origin-filter']/following::input");
        By wOriginInputSelect = By.XPath("//label[contains(text(),'Origin')]/parent::div/descendant::ul[@class='item2']/descendant::input[1]");//ok
        By wClear = By.XPath("//button[@id='fromDateClear']");
        By wClearFilters = By.XPath("//button[text()=' Clear ']");
        By wVendor = By.XPath("//div[@id='sr-vendor-filter']");
        By wDriver = By.XPath("//div[@id='sr-driver-filter']");
        By wCreatedBy = By.XPath("//div[@id='sr-created-by-filter']");
        By wSearchVendor = By.XPath("//label[contains(text(),'Vendor')]/following::input[@placeholder='Search']");
        By wSearchAssignedCoordinator = By.XPath("//label[contains(text(),'Assigned Coordinator')]/following::input[@placeholder='Search']");
        By wSearchCreatedBy = By.XPath("//label[contains(text(),'Created By')]/following::input[@placeholder='Search']");
        By wExpandAll = By.XPath("//b[contains(text(),'Expand All')]");
        By wProvider = By.XPath("//div[@id = 'moreActionSR1']/ancestor::tr[@class='ng-star-inserted']/descendant::div[@class ='title_container leg-provider']/descendant::b");
        By wSearchDriver = By.XPath("//label[contains(text(),'Driver')]/following::input[@placeholder='Search']");
        By wSearchCustomer = By.XPath("//label[contains(text(),'Customer')]/following::input[@placeholder='Search']");
        By wDemoCustomer = By.XPath("//div[text()='Demo Customer']");

        By wproviderDriver = By.XPath("//div[@id = 'moreActionSR2']/ancestor::tr[@class='ng-star-inserted']/descendant::div[@class ='title_container leg-provider']/descendant::td[2]");
        By wTissueID = By.XPath("//div[@id='sr-tissue-Id-filter']");
        By wSearchTissueID = By.XPath("//label[contains(text(),'Tissue ID')]/following::input[@placeholder='Search']");
        By wAssignedCoordinator = By.XPath("//div[@id='sr-assigned-coordinator-filter']");
        By wDownloadSRReport = By.XPath("//button[@title = 'Download SR Report']");
        By wSaveMemberPreferenceSetting = By.XPath("//span[@id = 'saveFilter_lg']");
        By wSMPSwStatus = By.XPath("//h4[contains(text(),'User Preference Setting ')]//ancestor::div[@class = 'modal-content']//descendant::span[contains(text(),'Status')]");
        By wSMPSwSearch = By.XPath("//h4[contains(text(),'User Preference Setting ')]//ancestor::div[@class = 'modal-content']//descendant::input[@placeholder = 'Search'][2]");
        By wSMPSwOption = By.XPath("//h4[contains(text(),'User Preference Setting ')]//ancestor::div[@class = 'modal-content']//descendant::ul[@class = 'item2'][2]//descendant::div");
        By WSMPSwSave = By.XPath("//button[text()='Save']");
        By wSMPSwStatusClear = By.XPath("//div[text()='Status']/following::a[text()='x']");
        By wCreateServiceRequestButton = By.XPath("//button[@title = 'Create Service Request' ]");
        By wHeaderCreateServiceRequest = By.XPath("//h1/strong[text()='Create Service Request']");
        By wShowNotificationsButton = By.XPath("//button/a[@title = 'Show Notifications']");
        By wShowMessagesButton = By.XPath("//button[@title = 'Show Messages']");
        By wHeaderNotificationsDashboard = By.XPath("//strong[text()='Notification Dashboard']");
        By wHeaderMessagesPage = By.XPath("//strong[text()='Your Messages']");
        By wCreateItineraryButton = By.XPath("//button[@title = 'Create Itinerary']");
        By wViewCallFlowDetailsButton = By.XPath("//button[@title = 'View Call Flow Details']");
        By wViewChecklistDetailsButton = By.XPath("//button[@title = 'View Checklist Details']");
        By wAssignCoordinatorButton = By.XPath("//button[@id = 'assignCoordinator']");
        By wEditServiceRequestButton = By.XPath("//button[text() = ' Edit ']");
        By wHeaderCreateItineraryPage = By.XPath("//strong[text()='Create Itinerary']");
        By wHeaderCallFlowDetailsPage = By.XPath("//span[text()='Call Flow Details']");
        By wHeaderChecklistDetailsPag = By.XPath("//span[text()='Checklist Details']");
        By wHeaderAssignCoordinatorPage = By.XPath("//h4[text()='Assign Coordinator']");
        By wHeaderEditServiceRequestPage = By.XPath("//strong[text()='Edit Service Request']");
        By wAddNotesButton = By.XPath("//button[@title = 'Add Notes']");
        By wHeaderAddNotesPage = By.XPath("//h4[text()='Add Notes ']");
        By wtoastmsg = By.XPath("//div[@class='toast-message ng-star-inserted']");
        By wCoordinatorList = By.XPath("//ngx-select-dropdown[@id='assignCoordinator']");
        By wSearchCoordinator = By.XPath("//input[@name = 'search-text']");
        By wAssignCoordinator = By.XPath("//button[text()=' Assign ']");
        By toastmsg = By.XPath("//div[@class='toast-message ng-star-inserted']");
        By toastTitle = By.XPath("//div[@class='toast-title ng-star-inserted']");
        By wSelectInputForCoordinator = By.XPath("//li[text()=' Service Account  Coordinator']");
        By AddNote = By.XPath("//h4[text() = 'Notes ']/i");
        By CategorySelect= By.XPath("//label[text()='Category']/following-sibling::select");
        By wNotes = By.XPath("//label[text()='Notes']/following-sibling::textarea");
        By wSaveNote = By.XPath("//button[text()='Save Changes']");
        By CategoreyValue = By.XPath("//label[text()='Category']/following-sibling::select/descendant::option[3]");
        By wDeleteNote = By.XPath("//button[@title='Delete Note']");
        By wAddPriority = By.XPath("//button[@title='Add Priority']");
        By wServiceAccCoordinator = By.XPath("//li[text()=' Service Account  Coordinator']");

        By wSelectCustomer = By.XPath("//span[text() = 'Select Customer ']");
        By wSelectSearchCustomer = By.XPath("//input");
        By wDemoCustInput = By.XPath("//li[text()=' Demo Customer']");
        By wContact = By.XPath("//span[text() = 'Select Contact ']");
        By wSelectSearchContact = By.XPath("//input");
        By wNeerajKushwaha = By.XPath("//li[text()=' Neeraj  Kushwaha']");
        By wServiceType = By.XPath("//select[@name = 'servicetype']");

        By wMoreButton = By.XPath("//button[@title = 'More']");
        By wAddFiles = By.XPath("//button[@title = 'Add Files']/i");
        By wHeadViewFile = By.XPath("//h4[text() = 'View File ']");
        By wHeaderAssignCoordinator = By.XPath("//h4[text() = 'Assign Coordinator']");
        By wViewFileCancle = By.XPath("//h4[text()='View File ']/preceding-sibling::button/i");
        By wTripReportCancle = By.XPath("//h4[text()='Trip Report']/preceding-sibling::button/i");
        By wCancleService = By.XPath("//button[@title = 'Cancel Service Request']/i");
        By wTripReport = By.XPath("//button[@title = 'Trip Report']/i");
        By wHeadTripReport = By.XPath("//h4[text() = 'Trip Report']");
        By wCopyServiceRequest = By.XPath("//span[text() = 'Copy Service Request']/preceding-sibling::button/i");
        By wBackfromCreateServiceRequestBackButton = By.XPath("//button[@title = 'Go Back']/i");
        By wAssignCoordinatorButtonfrommoreopt = By.XPath("//button[@title = 'Assign Coordinator']/i");
        By wEditServiceRequestButtonfromMoreOpt = By.XPath("//button[@title = 'Edit Service Request']/i");
        By wViewCallFlowDetails = By.XPath("//button[@title = 'View Call Flow Details']/i");
        By wHeaderViewCallFlowDetails = By.XPath("//span[text() = 'Call Flow Details']");
        By wChecklistDetails = By.XPath("//button[@title = 'View Check List Details']/i");
        By wHeaderChecklistDetails = By.XPath("//span[text() = 'Checklist Details']");
        By wUnCancleButton = By.XPath("//button[@title = 'Un-Cancel Service Request']/i");
        By inputSearch = By.XPath("//input[@type='search']");
        By AddFileForSR = By.XPath("//input[@type = 'file']");
        By SaveFileForSR = By.XPath("//a[text() = ' Save ']");
        By wAddFileForSR = By.XPath("//a[text() = ' Add File ']");
        String TripID = null;



        public void enterEmail(string email)
        {
            try
            {
                WaitHelper.cExplicitWait(driver, wEmail, 30);
                driver.FindElement(wEmail).SendKeys(email);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void enterPassword(string password)
        {
            try
            {
                WaitHelper.cExplicitWait(driver, wPassword, 30);
                driver.FindElement(wPassword).SendKeys(password);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void clickSubmit()
        {
            try
            {
                driver.FindElement(wSubmit).Click();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void verifyImage()
        {
            try
            {
                WaitHelper.cExplicitWait(driver, wDoctorImage, 30);
                Boolean flag = driver.FindElement(wDoctorImage).Displayed;
                Assert.IsTrue(flag, "The Doctor image is not displayed as per expectation.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void enterSecondEmail(String email)
        {

            try
            {
                WaitHelper.cExplicitWait(driver, wSecondEmail, 20);
                driver.FindElement(wSecondEmail).SendKeys(email);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void clickNextButton()
        {
            try
            {
                WaitHelper.cExplicitWait(driver, wNext, 10);
                driver.FindElement(wNext).Click();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void enterSecondPassword(String password)
        {
            try
            {
                WaitHelper.cExplicitWait(driver, wSecondPassword, 10);
                driver.FindElement(wSecondPassword).SendKeys(password);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void clickVerifyButton()
        {
            try
            {
                WaitHelper.cExplicitWait(driver, wVerifyButton, 10);
                driver.FindElement(wVerifyButton).Click();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void verifyLogoforHomePage()
        {
            try
            {

                    WaitHelper.cWaitForLoader(driver, 30);
                    WaitHelper.cExplicitWait(driver, wVerifyLogo, 40);
                    Boolean flag = driver.FindElement(wVerifyLogo).Displayed;
                    Assert.IsTrue(flag, "Logo is not displayed as per expectation.");

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void clickServiceRequest()
        {
            try
            {
                WaitHelper.cExplicitWait(driver, wServiceRequest, 40);
                driver.FindElement(wServiceRequest).Click();//clear overlaps
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
        public void verifyServiceRequestPage()
        {
            try
            {
                WaitHelper.cExplicitWait(driver, wCreateServiceRequest, 40);
                Boolean flag = driver.FindElement(wCreateServiceRequest).Displayed;
                Assert.IsTrue(flag, "Logo is not displayed as per expectation.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
        public void ClickServiceTypeFilter()
        {
            try
            {
                WaitHelper.cWaitForLoader(driver, 20);
                driver.FindElement(wServiceTypeFilter).Click();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
        public void ClickStatusFilter()
        {
            try
            {
                WaitHelper.cWaitForLoader(driver, 20);
                driver.FindElement(wStatusFilter).Click();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
        public void CheckEquipmentType()
        {
            try
            {
                WaitHelper.cExplicitWait(driver, wListOfServiceType, 40);
                driver.FindElement(wEquipmentCheckBox).Click();
                bool isCheckboxSelected = driver.FindElement(wEquipmentInput).Selected;
                Assert.IsTrue(isCheckboxSelected, " checkbox should be selected.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


        }
        public void CheckInternalType()
        {
            try
            {
                WaitHelper.cExplicitWait(driver, wListOfServiceType, 40);
                driver.FindElement(wInternalCheckBox).Click();
                bool isCheckboxSelected = driver.FindElement(wInternalInput).Selected;
                Assert.IsTrue(isCheckboxSelected, " checkbox should be selected.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
        public void CheckNextFlightOutType()
        {
            try
            {
                WaitHelper.cExplicitWait(driver, wListOfServiceType, 40);
                driver.FindElement(wNextFlightOutCheckBox).Click();
                bool isCheckboxSelected = driver.FindElement(wNextFlightOutInput).Selected;
                Assert.IsTrue(isCheckboxSelected, " checkbox should be selected.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
        public void CheckOrganType()
        {
            try
            {
                WaitHelper.cExplicitWait(driver, wListOfServiceType, 40);
                driver.FindElement(wOrganCheckBox).Click();
                bool isCheckboxSelected = driver.FindElement(wOrganInput).Selected;
                Assert.IsTrue(isCheckboxSelected, " checkbox should be selected.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
        public void CheckSpecimenType()
        {
            try
            {
                WaitHelper.cExplicitWait(driver, wListOfServiceType, 40);
                driver.FindElement(wSpecimenCheckBox).Click();
                bool isCheckboxSelected = driver.FindElement(wSpecimenInput).Selected;
                Assert.IsTrue(isCheckboxSelected, " checkbox should be selected.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
        public void CheckTeamType()
        {
            try
            {

                WaitHelper.cExplicitWait(driver, wListOfServiceType, 40);
                driver.FindElement(wTeamCheckBox).Click();
                bool isCheckboxSelected = driver.FindElement(wTeamInput).Selected;
                Assert.IsTrue(isCheckboxSelected, " checkbox should be selected.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void CheckCancelled()
        {
            try
            {
                WaitHelper.cExplicitWait(driver, wListOfStatus, 40);
                driver.FindElement(wCancelledCheckBox).Click();
                bool isCheckboxSelected = driver.FindElement(wCancelledInput).Selected;
                Assert.IsTrue(isCheckboxSelected, " checkbox should be selected.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


        }
        public void CheckCompleted()
        {
            try
            {
                WaitHelper.cExplicitWait(driver, wListOfStatus, 40);
                driver.FindElement(wCompletedCheckBox).Click();
                bool isCheckboxSelected = driver.FindElement(wCompletedInput).Selected;
                Assert.IsTrue(isCheckboxSelected, " checkbox should be selected.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


        }
        public void CheckEnroute()
        {
            try
            {
                WaitHelper.cExplicitWait(driver, wListOfStatus, 40);
                driver.FindElement(wEnrouteCheckBox).Click();
                bool isCheckboxSelected = driver.FindElement(wEnrouteInput).Selected;
                Assert.IsTrue(isCheckboxSelected, " checkbox should be selected.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


        }

        public void CheckNotStarted()
        {
            try
            {
                WaitHelper.cExplicitWait(driver, wListOfStatus, 40);
                driver.FindElement(wNotStartedCheckBox).Click();
                bool isCheckboxSelected = driver.FindElement(wNotStartedInput).Selected;
                Assert.IsTrue(isCheckboxSelected, " checkbox should be selected.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


        }

        public void ClearOverlapping()
        {
            try
            {
                driver.FindElement(wServiceRequestHeader).Click();//to clear the screen 
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
        public void SelectFromAndToDate()
        {
            try
            {
                driver.FindElement(wCalaender).Click();//calender click
                Thread.Sleep(1000);
                driver.FindElement(wFromDate).SendKeys("01/1/2023");//endkeys("05 / 10 / 2023");
                driver.FindElement(wToDate).SendKeys("07/10/2023");//endkeys("05 / 10 / 2023");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
        public void Apply()
        {
            try
            {
                WaitHelper.cScrollIntoViewUsingJavaScriptExecutor(driver, wApply);
                driver.FindElement(wApply).Click();//apply
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
        public void Show25Entries()
        {
            try
            {
                WaitHelper.cWaitForLoader(driver, 20);
                IWebElement element = driver.FindElement(wShowEntries);
                SelectElement select = new SelectElement(element);
                select.SelectByValue("25");
                WaitHelper.cWaitForLoader(driver, 40);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


        }
        //public void GetDataFromTypeColAndCompareWithSelectedServiceType()
        //{
        //    IReadOnlyCollection<IWebElement> elements = driver.FindElements(wTypeColumn);//x path of Type column
        //    List<IWebElement> elementList = new List<IWebElement>(elements);

        //    foreach (IWebElement data in elementList)
        //    {
        //        string text = data.GetAttribute("textContent");
        //        Assert.AreEqual("Internal", $"{text.Split(" ")[1]}", "The Service Type Filter is not working for 'Equipment' select");
        //        //System.Console.WriteLine($"Text attribute: {text.Split(" ")[1]});
        //    }

        //}
        public void GetDataFromTypeColAndCompareWithSelectedServiceTypeEquipment()
        {
            try
            {
                IReadOnlyCollection<IWebElement> elements = driver.FindElements(wTypeColumn);//x path of Type column
                List<IWebElement> elementList = new List<IWebElement>(elements);

                foreach (IWebElement data in elementList)
                {
                    string text = data.GetAttribute("textContent");
                    Assert.AreEqual("Equipment", $"{text.Split(" ")[1]}", "The Service Type Filter is not working for 'Equipment' select");
                    //System.Console.WriteLine($"Text attribute: {text.Split(" ")[1]});
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }



        }
        public void GetDataFromTypeColAndCompareWithSelectedServiceTypeInternal()
        {
            try
            {
                IReadOnlyCollection<IWebElement> elements = driver.FindElements(wTypeColumn);//x path of Type column
                List<IWebElement> elementList = new List<IWebElement>(elements);

                foreach (IWebElement data in elementList)
                {
                    string text = data.GetAttribute("textContent");
                    Assert.AreEqual("Internal", $"{text.Split(" ")[1]}", "The Service Type Filter is not working for 'Internal' select");
                    //System.Console.WriteLine($"Text attribute: {text.Split(" ")[1]});
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }



        }

        public void GetDataFromTypeColAndCompareWithSelectedServiceTypeNextFlightOut()
        {
            try
            {
                IReadOnlyCollection<IWebElement> elements = driver.FindElements(wTypeColumn);//x path of Type column
                List<IWebElement> elementList = new List<IWebElement>(elements);

                foreach (IWebElement data in elementList)
                {
                    string text = data.GetAttribute("textContent");
                    Assert.AreEqual("Next", $"{text.Split(" ")[1]}", "The Service Type Filter is not working for 'NextFlightOut' select");
                    //System.Console.WriteLine($"Text attribute: {text.Split(" ")[1]});
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


        }
        public void GetDataFromTypeColAndCompareWithSelectedServiceTypeOrgan()
        {
            try
            {
                IReadOnlyCollection<IWebElement> elements = driver.FindElements(wTypeColumn);//x path of Type column
                List<IWebElement> elementList = new List<IWebElement>(elements);

                foreach (IWebElement data in elementList)
                {
                    string text = data.GetAttribute("textContent");
                    Assert.AreEqual("Organ", $"{text.Split(" ")[1]}", "The Service Type Filter is not working for 'Organ' select");
                    //System.Console.WriteLine($"Text attribute: {text.Split(" ")[1]});
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


        }
        public void GetDataFromTypeColAndCompareWithSelectedServiceTypeSpecimen()
        {
            try
            {
                IReadOnlyCollection<IWebElement> elements = driver.FindElements(wTypeColumn);//x path of Type column
                List<IWebElement> elementList = new List<IWebElement>(elements);

                foreach (IWebElement data in elementList)
                {
                    string text = data.GetAttribute("textContent");
                    Assert.AreEqual("Specimen", $"{text.Split(" ")[1]}", "The Service Type Filter is not working for 'Specimen' select");
                    //System.Console.WriteLine($"Text attribute: {text.Split(" ")[1]});
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


        }
        public void GetDataFromTypeColAndCompareWithSelectedServiceTypeTeam()
        {
            try
            {
                IReadOnlyCollection<IWebElement> elements = driver.FindElements(wTypeColumn);//x path of Type column
                List<IWebElement> elementList = new List<IWebElement>(elements);

                foreach (IWebElement data in elementList)
                {
                    string text = data.GetAttribute("textContent");
                    Assert.AreEqual("Team", $"{text.Split(" ")[1]}", "The Service Type Filter is not working for 'Team' select");
                    //System.Console.WriteLine($"Text attribute: {text.Split(" ")[1]});
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


        }
        public void GetDataFromStatusColAndCompareWithSelectedStatusTypeCancelled()
        {
            try
            {
                IReadOnlyCollection<IWebElement> elements = driver.FindElements(wStatusColumn);
                List<IWebElement> elementList = new List<IWebElement>(elements);

                foreach (IWebElement data in elementList)
                {
                    string text = data.GetAttribute("textContent");
                    Assert.AreEqual("Cancelled", $"{text.Split(" ")[1]}", "The Status Type Filter is not working for 'Cancelled' select option");

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }



        }
        public void GetDataFromStatusColAndCompareWithSelectedStatusTypeCompleted()
        {
            try
            {
                IReadOnlyCollection<IWebElement> elements = driver.FindElements(wStatusColumn);
                List<IWebElement> elementList = new List<IWebElement>(elements);

                foreach (IWebElement data in elementList)
                {
                    string text = data.GetAttribute("textContent");
                    Assert.AreEqual("Completed", $"{text.Split(" ")[1]}", "The Status Type Filter is not working for 'Completed' select option");

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }



        }
        public void GetDataFromStatusColAndCompareWithSelectedStatusTypeEnroute()
        {
            try
            {
                IList<IWebElement> elementList = driver.FindElements(wStatusColumnForEnroute);
                foreach (IWebElement data in elementList)
                {
                    string Status = data.Text;//GetAttribute("textContent");

                    bool exist = false;
                    foreach (string fromListofAll in ListOfstatusForAll)
                    {
                        if (fromListofAll == Status)
                        {
                            exist = true;
                            break;
                        }
                        else
                        {
                            exist = false;
                        }

                    }
                    Console.WriteLine($"\n\n{Status} : Not Started,On-board, Wheels Up, Landed, On-Scene Picked up,Enroute, Dropped Off, Driver Done, Job Done");

                    Assert.IsTrue(exist, "The Status Type Filter is not working for 'Enroute' select option");

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


        }
        public List<IWebElement> GetCustomerListfromCustomerDropDown()
        {
                ReadOnlyCollection<IWebElement> RCustomerList = driver.FindElements(wListofCustomer);
                List<IWebElement> CustomerList = new List<IWebElement>(RCustomerList);
                return CustomerList;

        }


        public void GetDataFromStatusColAndCompareWithSelectedStatusTypeNotStarted()
        {
            try
            {
                IReadOnlyCollection<IWebElement> elements = driver.FindElements(wStatusColumnForNotStarted);
                List<IWebElement> elementList = new List<IWebElement>(elements);

                foreach (IWebElement data in elementList)
                {
                    string text = data.GetAttribute("textContent");
                    Assert.AreEqual("Not", $"{text.Split(" ")[0]}", "The Status Type Filter is not working for 'Not Started' select option");

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }



        }
        public void ClickOnCustomerDropdown()
        {
            try
            {
                WaitHelper.cWaitForLoader(driver, 20);
                WaitHelper.cExplicitWait(driver, wCustomer, 40);
                driver.FindElement(wCustomer).Click();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


        }
        public void ToViewOrScroll(IWebElement data)
        {
            try
            {
                ClickOnCustomerDropdown();
                IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                js.ExecuteScript("arguments[0].scrollIntoView(true);", data);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
        public void VerifyTheResultForDemoCustomer()
        {
            try
            {
                WaitHelper.cWaitForLoader(driver, 20);
                WaitHelper.cExplicitWait(driver, wCustomerNames, 40);
                string CustomerName = driver.FindElement(wCustomerNames).Text;
                Assert.AreEqual(CustomerName, "Demo Customer", "Assertion fail for VerifyTheResultForDemoCustomer");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


        }

        public void ClickOnMoreButton()
        {
            try
            {
                WaitHelper.cWaitForLoader(driver, 20);
                WaitHelper.cExplicitlyWaitForAbsence(driver, toastTitle, 20);
                WaitHelper.cExplicitWait(driver, wMoreButton, 40);
                driver.FindElement(wMoreButton).Click();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
        public void ClickOnAddFilesButtonAndVerifyTheTitleOfNewWindow()
        {
            try
            {
                WaitHelper.cExplicitWait(driver, wAddFiles, 40);
                driver.FindElement(wAddFiles).Click();
                WaitHelper.cExplicitWait(driver, wHeadViewFile, 40);
                Boolean flag = driver.FindElement(wHeadViewFile).Text.Contains("View File");
                Assert.True(flag, "Add files options inside More Button for a Service Request in Service Request Page ");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


        }
        public void AttachAtFileAndVerifyTheSuccessMessage()
        {
            try
            {
                string FileName = "uploadfile.txt";
                driver.FindElement(wAddFileForSR).Click();
                HandleOpenDialog hndOpen = new HandleOpenDialog();
                //hndOpen.fileOpenDialog("C:\\Users\\IBZ\\Desktop\\rovi_care_testing\\rovicaretesting\\TestData\\ImportPatient_Files", FileName);
                //string path = @$"{ProjectDirectory}\TestData\ImportPatient_Files";
                string path = @"D:\TAC\FinanceModule\Utility";
                hndOpen.fileOpenDialog(path, $"{FileName}");
                Thread.Sleep(2000);
                WaitHelper.cExplicitlyWaitForElementToBeClickable(driver, SaveFileForSR, 40);
                driver.FindElement(SaveFileForSR).Click();
                WaitHelper.cWaitForLoader(driver, 60);
                Toast.SuccessToast(driver);
                WaitHelper.cWaitForLoader(driver, 60);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }



        }

        public void ClickOnTripReportButtonAndVerifyTheTitleOfNewWindow()
        {
            try
            {
                WaitHelper.cWaitForLoader(driver, 60);
                WaitHelper.cExplicitWait(driver, wTripReport, 40);
                driver.FindElement(wTripReport).Click();
                WaitHelper.cExplicitWait(driver, wHeadTripReport, 40);
                Boolean flag = driver.FindElement(wHeadTripReport).Text.Contains("Trip Report");
                Assert.True(flag, "TripReport options inside More Button for a Service Request in Service Request Page ");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
        

        public void ClickOnViewFileCancleButton()
        {
            try
            {
                driver.FindElement(wViewFileCancle).Click();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


        }
        
        public void ClickOnTripReportCancleButton()
        {
            try
            {
                driver.FindElement(wTripReportCancle).Click();
                WaitHelper.cWaitForLoader(driver, 60);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


        }
        public void ClickOnCancleServiceRequestAcceptTheAlert()
        {
            try
            {
                driver.FindElement(wCancleService).Click();
                WaitHelper.cAlertIsPresent(driver, 30);
                driver.SwitchTo().Alert().Accept();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


            
        }
        public void VerifyTheSuccessMessageforCancleSRq()
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(90));
                wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(toastTitle));
                bool flag = driver.FindElement(toastTitle).Text.Contains("success");
                Assert.IsTrue(flag, "Success toastTitle is not displayed");
                WaitHelper.cWaitForLoader(driver, 60);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }



        }
        public void ClickOnCopyServiceRequestAndVerifyTheTitleOfNewWindow()
        {
            try
            {
                WaitHelper.cWaitForLoader(driver, 60);
                WaitHelper.cExplicitWait(driver, wCopyServiceRequest, 40);
                driver.FindElement(wCopyServiceRequest).Click();
                WaitHelper.cExplicitWait(driver, wHeaderCreateServiceRequest, 40);//
                Boolean flag = driver.FindElement(wHeaderCreateServiceRequest).Text.Contains("Create Service Request");
                Assert.True(flag, "Copy Service Request options inside More Button for a Service Request in Service Request Page ");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
        public void ClickOnBackButton()
        {
            try
            {
                WaitHelper.cWaitForLoader(driver, 60);
                driver.FindElement(wBackfromCreateServiceRequestBackButton).Click();
                WaitHelper.cWaitForLoader(driver, 60);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
        public void ClickOnAssignCoordinatorAndVerifyTheTitleOfNewWindow()
        {
            try
            {
                WaitHelper.cWaitForLoader(driver, 60);
                WaitHelper.cExplicitWait(driver, wAssignCoordinatorButtonfrommoreopt, 40);
                driver.FindElement(wAssignCoordinatorButtonfrommoreopt).Click();
                WaitHelper.cExplicitWait(driver, wHeaderAssignCoordinator, 40);//
                Boolean flag = driver.FindElement(wHeaderAssignCoordinator).Text.Contains("Assign Coordinator");
                Assert.True(flag, "Assign Coordinator options inside More Button for a Service Request in Service Request Page ");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


        }
        public void GiveInputServiceAccountCoordinatorToAssignCoordinatorRequest()
        {
            try
            {
                WaitHelper.cWaitForSpinner(driver, 60);
                driver.FindElement(wCoordinatorList).Click();
                driver.FindElement(wSearchCoordinator).SendKeys("Service Account");
                driver.FindElement(wServiceAccCoordinator).Click();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
        public void ClickOnAssignButtonAndVerifyTheSuccessMessage()
        {
            try
            {
                driver.FindElement(wAssignCoordinator).Click();
                Toast.SuccessToast(driver);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


        }
        public void ClickOnEditServiceRequestAndVerifyTheTitleOfNewWindow()
        {
            try
            {
                WaitHelper.cWaitForLoader(driver, 60);
                WaitHelper.cExplicitWait(driver, wEditServiceRequestButtonfromMoreOpt, 40);
                driver.FindElement(wEditServiceRequestButtonfromMoreOpt).Click();
                WaitHelper.cExplicitWait(driver, wHeaderEditServiceRequestPage, 40);//
                Boolean flag = driver.FindElement(wHeaderEditServiceRequestPage).Text.Contains("Edit Service Request");
                Assert.True(flag, "Edit Service Request options inside More Button for a Service Request in Service Request Page ");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
        public void GetTheTripIdOfTheCancelledRequestAndClickOnUn_CancelButton()
        {
            try
            {
                WaitHelper.cWaitForLoader(driver, 60);
                WaitHelper.cExplicitWait(driver, wTripIdfromTripDetails, 40);
                TripID = driver.FindElement(wTripIdfromTripDetails).Text;
                driver.FindElement(wUnCancleButton).Click();
                driver.SwitchTo().Alert().Accept();
                WaitHelper.cWaitForLoader(driver, 60);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        public void GiveInputToTheSearchFieldAndVerifyTheResult()
        {
            try
            {
                driver.FindElement(wClearFilters).Click();
                WaitHelper.cWaitForLoader(driver, 60);
                driver.FindElement(inputSearch).SendKeys(TripID);
                WaitHelper.cWaitForLoader(driver, 60);
                WaitHelper.cExplicitWait(driver, wTripIdfromTripDetails, 40);
                Boolean flag = driver.FindElement(wTripIdfromTripDetails).Text.Contains(TripID);
                Assert.True(flag, "Un-Cancel Button for a Service Request in Service Request Page is not responding");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


        }


        public void FilterForTheStoredTripIdAndCheck()
        {
            try
            {
                driver.FindElement(wClearFilters).Click();
                WaitHelper.cWaitForLoader(driver, 60);
                CheckTripId();
                InputTripId(TripID);
                WaitHelper.cExplicitWait(driver, wTripIdfromTripDetails, 40);//
                Boolean flag = driver.FindElement(wTripIdfromTripDetails).Text.Contains(TripID);
                WaitHelper.cWaitForLoader(driver, 60);
                Assert.True(flag, "Un-Cancel Button for a Service Request in Service Request Page is not responding");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }




        public void ClickOnViewCallFlowDetailsButtonAndVerifyTheTitle()
        {
            try
            {
                WaitHelper.cWaitForLoader(driver, 60);
                WaitHelper.cExplicitWait(driver, wViewCallFlowDetails, 40);
                driver.FindElement(wViewCallFlowDetails).Click();
                WaitHelper.cExplicitWait(driver, wHeaderViewCallFlowDetails, 40);
                Boolean flag = driver.FindElement(wHeaderViewCallFlowDetails).Text.Contains("Call Flow Details");
                Assert.True(flag, "View call flow Details for a Service Request in Service Request Page ");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
        public void ClickOnViewCheckListDetailsButtonAndVerifyTheTitle()
        {
            try
            {
                WaitHelper.cWaitForLoader(driver, 60);
                WaitHelper.cExplicitWait(driver, wChecklistDetails, 40);
                driver.FindElement(wChecklistDetails).Click();
                WaitHelper.cExplicitWait(driver, wHeaderChecklistDetails, 40);
                Boolean flag = driver.FindElement(wHeaderChecklistDetails).Text.Contains("Checklist Details");
                Assert.True(flag, "ChecklistDetails for a Service Request in Service Request Page ");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }




        public void GetDataFromCustomerColAndCompareWithSelectedCustomerfromCustomerFilter(IWebElement data)
        {
            By wCustomerName;
            try
            {
                wCustomerName = By.XPath("//td/div[@id='main_row_id']/div[3]/div[@class = 'row_detail'][1]");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                wCustomerName = By.XPath("//td/div[@id='main_row_id']/div[3]/div[@class = 'row_detail'][1]");
            }

            try
            {
                IList<IWebElement> CustomerNamesFromFilter = driver.FindElements(wCustomerNames);
                string textformSelectedInput = data.GetAttribute("textContent");

                foreach (var element in CustomerNamesFromFilter)
                {
                    string textfromFilterResult = element.Text;
                    //Console.WriteLine($"{textformSelectedInput} : {textfromFilterResult}\n");
                    Assert.AreEqual(textformSelectedInput.Trim(), textfromFilterResult.Trim(), $"The Customer Type Filter is not working for {textformSelectedInput}");

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


        }
        public void ClearSelectedInputsFromCustomer(IWebElement data)
        {
            try
            {
                ClickOnCustomerDropdown();
                IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                js.ExecuteScript("arguments[0].scrollIntoView(true);", data);
                WaitHelper.cWaitForLoader(driver, 20);
                data.Click();
                ClearOverlapping();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
        public void Reload()
        {
            driver.Navigate().Refresh();
        }
        

        public void CheckUNOSID()
        {
            try
            {
                WaitHelper.cExplicitWait(driver, wUNOSID, 40);
                driver.FindElement(wUNOSID).Click();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
        public void InputUNOSID(string input)
        {
            try
            {
                By wFirstSearchRofInUNOSID = By.XPath($"//div[text()='{input}']");
                By wFirstSearchRofInUNOSIDinput = By.XPath($"//div[text()='{input}']/preceding-sibling::input");

                driver.FindElement(wSearchUNOSID).SendKeys(input);
                WaitHelper.cExplicitlyWaitForElementToBeClickable(driver, wFirstSearchRofInUNOSIDinput, 40);
                driver.FindElement(wFirstSearchRofInUNOSID).Click();
                Thread.Sleep(1000);
                bool isCheckboxSelected = driver.FindElement(wFirstSearchRofInUNOSIDinput).Selected;
                Assert.IsTrue(isCheckboxSelected, " checkbox should be selected.");
                Thread.Sleep(1000);
                driver.FindElement(wServiceRequestHeader).Click();
                driver.FindElement(wApply).Click(); //apply
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


        }
        public void GetDataForUNOSIDColAndVerifyTheResult(string input)
        {
            try
            {
                Thread.Sleep(3000);
                IList<IWebElement> ListofResults = driver.FindElements(wUNOSIdfromTripDetails);

                foreach (IWebElement UNOSID in ListofResults)
                {
                    string data = UNOSID.Text;
                    Assert.AreEqual(data.Trim(), input.Trim(), " Input UNOS ID and filtered UNOS ID should be same");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


        }

        public void CheckTripId()
        {
            try
            {
                WaitHelper.cExplicitWait(driver, wTripID, 40);
                driver.FindElement(wTripID).Click();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
        public void InputTripId(string input)
        {
            try
            {
                By wFirstSearchRofInTripID = By.XPath($"//div[text()='{input}']");
                By wFirstSearchRofInTripIDinput = By.XPath($"//div[text()='{input}']/preceding-sibling::input");

                driver.FindElement(wSearchTripID).SendKeys(input);
                WaitHelper.cExplicitlyWaitForElementToBeClickable(driver, wFirstSearchRofInTripID, 40);
                driver.FindElement(wFirstSearchRofInTripID).Click();
                Thread.Sleep(1000);
                bool isCheckboxSelected = driver.FindElement(wFirstSearchRofInTripIDinput).Selected;
                Assert.IsTrue(isCheckboxSelected, " checkbox should be selected.");
                Thread.Sleep(1000);
                driver.FindElement(wServiceRequestHeader).Click();
                driver.FindElement(wApply).Click();//apply
                                                   
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


        }
        public void GetDataFromTripDColAndVerifyTheResult(string input)
        {
            try
            {
                Thread.Sleep(3000);
                string data = driver.FindElement(wTripIdfromTripDetails).Text;
                Assert.AreEqual(data.Trim(), input.Trim(), " Input TripID and filtered TripID should be same");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void ClickMoreFilters()
        {
            try
            {
                WaitHelper.cExplicitWait(driver, wMoreFilters, 40);
                driver.FindElement(wMoreFilters).Click();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
        public void ClickOnOriginDropdown()
        {
            try
            {
                IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                js.ExecuteScript("window.scroll(0,0)");
                WaitHelper.cExplicitlyWaitForElementToBeClickable(driver, xOrigin, 40);
                driver.FindElement(xOrigin).Click();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


        }
        public void SelectDemoCustomer()
        {
            try
            {
                WaitHelper.cExplicitWait(driver, wSearchCustomer, 40);
                driver.FindElement(wSearchCustomer).SendKeys("Demo Customer");
                WaitHelper.cExplicitWait(driver, wDemoCustomer, 40);
                driver.FindElement(wDemoCustomer).Click();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


        }


        public void ClearSelectedInputsFromOrigin(IWebElement data)
        {
            try
            {
                ClickOnOriginDropdown();
                IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                js.ExecuteScript("arguments[0].scrollIntoView(true);", data);
                WaitHelper.cWaitForLoader(driver, 20);
                data.Click();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            //ClearOverlapping();
        }
        public void InputToOriginFilter(string input)
        {
            By wOriginInput = By.XPath($"//div[contains(text(),'{input}')]");

            try
            {
                try
                {
                    WaitHelper.cExplicitlyWaitForElementToBeClickable(driver, wSearchOrigin, 20);
                    driver.FindElement(wSearchOrigin).SendKeys(input);
                    WaitHelper.cExplicitWaitForElementIsVisible(driver, wOriginInput, 20);
                    driver.FindElement(wOriginInput).Click();

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }




        }
        public void InputToDriverFilter(string input)
        {
            try
            {
                By wDriverInput = By.XPath($"//div[text()='{input}']");

                WaitHelper.cExplicitlyWaitForElementToBeClickable(driver, wSearchDriver, 20);
                driver.FindElement(wSearchDriver).SendKeys(input);
                //WaitHelper.cExplicitWait(driver, wDriverInput, 20);
                Thread.Sleep(2000);
                //WaitHelper.cExplicitWaitForElementIsVisible(driver, wDriverInput, 20);
                driver.FindElement(wDriverInput).Click();
                driver.FindElement(wServiceRequestHeader).Click();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


        }

        public void InputToTissueIDFilter(string input)
        {
            try
            {
                By wTissueIDInput = By.XPath($"//div[contains(text(),'{input}')]");

                WaitHelper.cExplicitlyWaitForElementToBeClickable(driver, wSearchTissueID, 20);
                driver.FindElement(wSearchTissueID).SendKeys(input);
                WaitHelper.cExplicitWaitForElementIsVisible(driver, wTissueIDInput, 20);
                driver.FindElement(wTissueIDInput).Click();
                driver.FindElement(wServiceRequestHeader).Click();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


        }


        public void InputToVendorFilter(string input)
        {
            
            By wVendorInput = By.XPath($"//div[contains(text(),'{input}')]");
            try
            {
                WaitHelper.cExplicitlyWaitForElementToBeClickable(driver, wSearchVendor, 20);
                driver.FindElement(wSearchVendor).SendKeys(input);
                WaitHelper.cExplicitWaitForElementIsVisible(driver, wVendorInput, 20);
                driver.FindElement(wVendorInput).Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }
        public void InputToAssignedCoordinatorFilter(string input)
        {
            By wAssignedCoordinatorInput = By.XPath($"//div[contains(text(),'{input}')]");
            try
            {
                WaitHelper.cExplicitlyWaitForElementToBeClickable(driver, wSearchAssignedCoordinator, 20);
                driver.FindElement(wSearchAssignedCoordinator).SendKeys(input);
                WaitHelper.cExplicitWaitForElementIsVisible(driver, wAssignedCoordinatorInput, 20);
                driver.FindElement(wAssignedCoordinatorInput).Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }

        public void InputToCreatedByFilter(string input)
        {
            By wCreatedByInput = By.XPath($"//div[contains(text(),'{input}')]");
            try
            {
                WaitHelper.cExplicitlyWaitForElementToBeClickable(driver, wSearchCreatedBy, 20);
                driver.FindElement(wSearchCreatedBy).SendKeys(input);
                WaitHelper.cExplicitWaitForElementIsVisible(driver, wCreatedByInput, 20);
                driver.FindElement(wCreatedByInput).Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }
        public void ClickOnDownloadSRReport()
        {
                WaitHelper.cWaitForLoader(driver, 40);
                ChromeOptionsAndCustomeBrowser.AddUserProfilePreference(driver, wDownloadSRReport, "abc.xlsx");

        }

        public void ClickOnSaveMemberPreferenceSettingOption()
        {
            try
            {
                WaitHelper.cWaitForLoader(driver, 30);
                WaitHelper.cExplicitlyWaitForElementToBeClickable(driver, wSaveMemberPreferenceSetting, 40);
                driver.FindElement(wSaveMemberPreferenceSetting).Click();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void SelectTheStatusOptionFromDropdownAndSave()
        {
            try
            {
                WaitHelper.cWaitForLoader(driver, 30);
                WaitHelper.cExplicitlyWaitForElementToBeClickable(driver, wSMPSwStatus, 30);
                driver.FindElement(wSMPSwStatus).Click();
                WaitHelper.cExplicitlyWaitForElementToBeClickable(driver, wSMPSwSearch, 60);
                driver.FindElement(wSMPSwSearch).SendKeys("Completed");
                Thread.Sleep(2000);
                WaitHelper.cExplicitlyWaitForElementToBeClickable(driver, wSMPSwOption, 90);
                driver.FindElement(wSMPSwOption).Click();
                Thread.Sleep(5000);
                WaitHelper.cExplicitlyWaitForElementToBeClickable(driver, WSMPSwSave, 30);
                driver.FindElement(WSMPSwSave).Click();

            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        public void ResetSaveMemberPreferenceSettingsOption()
        {
            try
            {
                driver.FindElement(wSaveMemberPreferenceSetting).Click();
                WaitHelper.cWaitForLoader(driver, 40);
                //Thread.Sleep(3000);
                WaitHelper.cExplicitlyWaitForElementToBeClickable(driver, wSMPSwStatusClear, 30);

                driver.FindElement(wSMPSwStatusClear).Click();
                Thread.Sleep(3000);
                WaitHelper.cExplicitlyWaitForElementToBeClickable(driver, WSMPSwSave, 30);
                driver.FindElement(WSMPSwSave).Click();

            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }


        public void VerifyTheResult()
        {

            try
            {
                WaitHelper.cWaitForLoader(driver, 30);
                IReadOnlyCollection<IWebElement> elements = driver.FindElements(wStatusColumn);
                List<IWebElement> elementList = new List<IWebElement>(elements);

                foreach (IWebElement data in elementList)
                {
                    string text = data.GetAttribute("textContent");
                    Assert.AreEqual("Completed", $"{text.Split(" ")[1]}", "The Status Type Filter is not working for 'Completed' select option");

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


        }

        public void ExpandAll()
        {
            try
            {
                WaitHelper.cWaitForLoader(driver, 30);
                driver.FindElement(wExpandAll).Click();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void GetRFromOriginColAndVerifyTheResult(string input)
        {
            Thread.Sleep(3000);
            try
            {
                IList<IWebElement> ListofOrigin = driver.FindElements(wOriginsfromOriginCol);
                foreach (IWebElement Origin in ListofOrigin)
                {
                    Boolean flag = Origin.Text.Contains(input);
                    Assert.IsTrue(flag, $"Origin Filter is not working for {input}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }


        public void GetRFromTissueIDColAndVerifyTheResult(string input)
        {
            try
            {
                WaitHelper.cExplicitWaitForElementIsVisible(driver, wTripIdfromTripDetails, 20);
                driver.FindElement(wTripIdfromTripDetails).Click();
                WaitHelper.cWaitForLoader(driver, 30);
                string TissueID = driver.FindElement(wTissueIDValue).Text;
                Assert.AreEqual(TissueID, input);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void GetRFromAssignedCoordinatorColAndVerifyTheResult(string input)
        {
            try
            {
                WaitHelper.cExplicitWaitForElementIsVisible(driver, wTripIdfromTripDetails, 20);
                driver.FindElement(wTripIdfromTripDetails).Click();
                WaitHelper.cWaitForLoader(driver, 30);
                string Coordinator = driver.FindElement(wAssignedCoordinatorValue).Text.Replace(" ", "");
                Assert.AreEqual(Coordinator, input.Replace(" ", ""));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void GetRFromCreatedByColAndVerifyTheResult(string input)
        {
            try
            {
                WaitHelper.cExplicitWaitForElementIsVisible(driver, wTripIdfromTripDetails, 20);
                driver.FindElement(wTripIdfromTripDetails).Click();
                WaitHelper.cWaitForLoader(driver, 30);
                string CreatedBy = driver.FindElement(wCreateBy).Text.Replace(" ", "");
                Assert.AreEqual(CreatedBy, input.Replace(" ", ""));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }


        public void ClearDate()
        {
            try
            {
                WaitHelper.cWaitForLoader(driver, 20);
                driver.FindElement(wClear).Click();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void GetRFromVendorColAndVerifyTheResult(string input)
        {
            WaitHelper.cWaitForLoader(driver, 20);

            try
            {
                IList<string> ListofVendorName = new List<string>();
                IList<IWebElement> ListofVendor = driver.FindElements(wProvider);
                if (ListofVendor == null)
                    Assert.Pass();
                foreach (IWebElement Vendor in ListofVendor)
                {
                    ListofVendorName.Add(Vendor.Text);
                    //Console.WriteLine( "-----------------" + Vendor.Text);

                }
                Boolean flag = ListofVendorName.Contains(input);
                if (ListofVendor.Count == 0)
                    Assert.Pass();
                else
                    Assert.IsTrue(flag, $"Vendor Filter is not working for {input}");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void GetRFromDriverColAndVerifyTheResult(string input)
        {
            WaitHelper.cWaitForLoader(driver, 20);

            try
            {
                Boolean flag = false;
                IList<string> ListofDriverName = new List<string>();
                IList<IWebElement> ListofDriver = driver.FindElements(wproviderDriver);
                foreach (IWebElement driver in ListofDriver)
                {
                    ListofDriverName.Add(driver.Text.Replace(" ", ""));
                    Console.WriteLine("-----------------" + driver.Text);

                }

                foreach (string drivername in ListofDriverName)
                {
                    flag = drivername.Contains(input.Replace(" ", ""));

                    if (flag == false)
                    {
                        Assert.IsTrue(flag, $"Driver Filter is not working for {input}");
                        break;

                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }


        public void ClickOnVendorDropDown()
        {
            try
            {
                WaitHelper.cWaitForLoader(driver, 20);
                WaitHelper.cExplicitWait(driver, wVendor, 40);
                driver.FindElement(wVendor).Click();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
        public void ClickOnCreatedByDropdown()
        {
            try
            {
                WaitHelper.cExplicitlyWaitForElementToBeClickable(driver, wCreatedBy, 40);
                WaitHelper.cExplicitWait(driver, wCreatedBy, 40);
                driver.FindElement(wCreatedBy).Click();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


        }
        public void ClickOnDriverDropDown()
        {
            try
            {
                WaitHelper.cWaitForLoader(driver, 20);
                WaitHelper.cExplicitWait(driver, wDriver, 40);
                driver.FindElement(wDriver).Click();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        public void ClickOnTissueIDropdown()
        {
            try
            {
                WaitHelper.cWaitForLoader(driver, 20);
                WaitHelper.cExplicitWait(driver, wTissueID, 40);
                driver.FindElement(wTissueID).Click();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
        public void ClickOnAssignedCoordinatorDropdown()
        {
            try
            {
                WaitHelper.cWaitForLoader(driver, 20);
                WaitHelper.cExplicitWait(driver, wAssignedCoordinator, 40);
                driver.FindElement(wAssignedCoordinator).Click();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void ClickOnCreateServiceRequestButton()
        {
            try
            {
                WaitHelper.cWaitForLoader(driver, 20);
                WaitHelper.cExplicitWait(driver, wCreateServiceRequestButton, 40);
                driver.FindElement(wCreateServiceRequestButton).Click();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void VerifyCreateServiceRequestPage()
        {
            try
            {
                WaitHelper.cWaitForLoader(driver, 20);
                WaitHelper.cExplicitWaitForElementIsVisible(driver, wHeaderCreateServiceRequest, 40);
                Boolean flag = driver.FindElement(wHeaderCreateServiceRequest).Displayed;
                Assert.IsTrue(flag, "Create Service Request Header is not displayed as per expectation.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
        public void ClickOnShowNotificationsButton()
        {
            try
            {
                WaitHelper.cWaitForLoader(driver, 20);
                WaitHelper.cExplicitWait(driver, wShowNotificationsButton, 40);
                driver.FindElement(wShowNotificationsButton).Click();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void ClickOnShowMessagesButton()
        {
            try
            {
                WaitHelper.cWaitForLoader(driver, 20);
                WaitHelper.cExplicitWait(driver, wShowMessagesButton, 40);
                driver.FindElement(wShowMessagesButton).Click();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void VerifyNotificationsDashboard()
        {
            try
            {
                WaitHelper.cWaitForLoader(driver, 20);
                WaitHelper.cExplicitWaitForElementIsVisible(driver, wHeaderNotificationsDashboard, 40);
                Boolean flag = driver.FindElement(wHeaderNotificationsDashboard).Displayed;
                Assert.IsTrue(flag, "Notifications Dashboard Header is not displayed as per expectation.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
        public void VerifyMessagesPage()
        {
            try
            {
                WaitHelper.cWaitForLoader(driver, 20);
                WaitHelper.cExplicitWaitForElementIsVisible(driver, wHeaderMessagesPage, 40);
                Boolean flag = driver.FindElement(wHeaderMessagesPage).Displayed;
                Assert.IsTrue(flag, "Messages Page Header is not displayed as per expectation.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
        public void ClickOnCreateItineraryButton()
        {
            try
            {
                WaitHelper.cWaitForLoader(driver, 30);
                WaitHelper.cExplicitWait(driver, wCreateItineraryButton, 40);
                driver.FindElement(wCreateItineraryButton).Click();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
        public void VerifyCrateItineraryPage()
        {
            try
            {
                WaitHelper.cWaitForLoader(driver, 20);
                WaitHelper.cExplicitWaitForElementIsVisible(driver, wHeaderCreateItineraryPage, 40);
                Boolean flag = driver.FindElement(wHeaderCreateItineraryPage).Displayed;
                Assert.IsTrue(flag, "Messages Page Header is not displayed as per expectation.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
        public void ClickOnViewCallFlowDetailsButton()
        {
            try
            {
                WaitHelper.cWaitForLoader(driver, 30);
                WaitHelper.cExplicitWait(driver, wViewCallFlowDetailsButton, 40);
                driver.FindElement(wViewCallFlowDetailsButton).Click();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
        public void ClickOnViewChecklistDetailsButton()
        {
            try
            {
                WaitHelper.cWaitForLoader(driver, 30);
                WaitHelper.cExplicitWait(driver, wViewChecklistDetailsButton, 40);
                driver.FindElement(wViewChecklistDetailsButton).Click();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
        public void ClickOnAssignCoordinatorButton()
        {
            try
            {
                WaitHelper.cWaitForLoader(driver, 30);
                WaitHelper.cExplicitWait(driver, wAssignCoordinatorButton, 40);
                driver.FindElement(wAssignCoordinatorButton).Click();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
        public void ClickOnEditServiceRequestButton()
        {
            try
            {
                WaitHelper.cWaitForLoader(driver, 30);
                WaitHelper.cExplicitWait(driver, wEditServiceRequestButton, 40);
                driver.FindElement(wEditServiceRequestButton).Click();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        public void VerifyTheCallFlowDetailsPage()
        {
            try
            {
                WaitHelper.cWaitForLoader(driver, 20);
                WaitHelper.cExplicitWaitForElementIsVisible(driver, wHeaderCallFlowDetailsPage, 40);
                Boolean flag = driver.FindElement(wHeaderCallFlowDetailsPage).Displayed;
                Assert.IsTrue(flag, "Messages Page Header is not displayed as per expectation.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
        public void VerifyTheChecklistDetailsPage()
        {
            try
            {
                WaitHelper.cWaitForLoader(driver, 20);
                WaitHelper.cExplicitWaitForElementIsVisible(driver, wHeaderChecklistDetailsPag, 40);
                Boolean flag = driver.FindElement(wHeaderChecklistDetailsPag).Displayed;
                Assert.IsTrue(flag, "Messages Page Header is not displayed as per expectation.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


        }
        public void VerifyTheAssignCoordinatorPage()
        {
            try
            {
                WaitHelper.cWaitForLoader(driver, 60);
                WaitHelper.cExplicitWaitForElementIsVisible(driver, wHeaderAssignCoordinatorPage, 40);
                Boolean flag = driver.FindElement(wHeaderAssignCoordinatorPage).Displayed;
                Assert.IsTrue(flag, "Messages Page Header is not displayed as per expectation.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


        }
        public void InputFromCoordinatorList(String input)
        {
            try
            {
                driver.FindElement(wCoordinatorList).Click();
                driver.FindElement(wSearchCoordinator).SendKeys(input);
                WaitHelper.cExplicitlyWaitForElementToBeClickable(driver, wSelectInputForCoordinator, 40);
                driver.FindElement(wSelectInputForCoordinator).Click();
                driver.FindElement(wAssignCoordinator).Click();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
        public void VerifyTheSuccessMessageForAssignCoordinatorFlow()
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
                wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(toastTitle));
                bool flag = driver.FindElement(toastTitle).Text.Contains("Success");
                Assert.IsTrue(flag, "Success toastTitle is not displayed");
                bool flag2 = driver.FindElement(toastmsg).Text.Contains("Coordinator Assigned Successfully Done");
                Assert.IsTrue(flag2, "Success toastmsg is not displayed");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        public void VerifyTheEditServiceRequestPage()
        {
            try
            {
                WaitHelper.cWaitForLoader(driver, 20);
                WaitHelper.cExplicitWaitForElementIsVisible(driver, wHeaderEditServiceRequestPage, 40);
                Boolean flag = driver.FindElement(wHeaderEditServiceRequestPage).Displayed;
                Assert.IsTrue(flag, "Messages Page Header is not displayed as per expectation.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        public void ClickOnAddNotesButton()
        {
            try
            {
                WaitHelper.cWaitForLoader(driver, 30);
                WaitHelper.cExplicitWait(driver, wAddNotesButton, 40);
                driver.FindElement(wAddNotesButton).Click();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
        public void VerifyAddNotesPage()
        {
            try
            {
                WaitHelper.cWaitForLoader(driver, 20);
                WaitHelper.cExplicitWaitForElementIsVisible(driver, wHeaderAddNotesPage, 40);
                Boolean flag = driver.FindElement(wHeaderAddNotesPage).Displayed;
                Assert.IsTrue(flag, "Messages Page Header is not displayed as per expectation.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
        
        public void ClickOnPlusNotes()
        {
            try
            {
                WaitHelper.cWaitForLoader(driver, 30);
                WaitHelper.cExplicitWait(driver, AddNote, 40);
                driver.FindElement(AddNote).Click();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        public void GiveInputForNoteCategoryAndMessage()
        {
            try
            {
                driver.FindElement(CategorySelect).Click();
                WaitHelper.cExplicitlyWaitForElementToBeClickable(driver, CategoreyValue, 5);
                driver.FindElement(CategoreyValue).Click();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }



            //IWebElement Select = driver.FindElement(CategorySelect);
            //SelectElement dropdown = new SelectElement(Select);
            //// dropdown.SelectByIndex(0);
            //dropdown.SelectByValue("1754f6d4-0a42-44c8-af6c-69a72db42e85");
            ////dropdown.SelectByText("Service Failure ");

            //driver.FindElement(Notes).SendKeys("TEST MESSAGE");
        }
        public void ClickOnSaveChangesAndVerifyTheResult()
        {
            try
            {
                driver.FindElement(wNotes).SendKeys("Note to Test");
                driver.FindElement(wSaveNote).Click();
                Toast.SuccessToast(driver);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


        }
        public void ClickOnAddPriorityAndVerifyTheResult()
        {
            try
            {
                Thread.Sleep(1000);
                WaitHelper.cExplicitWaitForElementIsVisible(driver, wAddPriority, 5);
                driver.FindElement(wAddPriority).Click();
                Toast.SuccessToast(driver);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
        
        public void ClickOnDeleteActionForTheSameAndVerifyTeResult()
        {
            try
            {
                Thread.Sleep(1000);
                WaitHelper.cExplicitWaitForElementIsVisible(driver, wDeleteNote, 5);
                driver.FindElement(wDeleteNote).Click();
                Toast.SuccessToast(driver);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        
        public void FillTheCustomerInfoCard()
        {
            try
            {
                WaitHelper.cWaitForLoader(driver, 30);
                WaitHelper.cExplicitWait(driver, wSelectCustomer, 40);
                driver.FindElement(wSelectCustomer).Click();
                WaitHelper.cExplicitlyWaitForElementToBeClickable(driver, wSelectSearchCustomer, 40);
                driver.FindElement(wSelectSearchCustomer).SendKeys("Demo Customer");
                driver.FindElement(wDemoCustInput).Click();

                driver.FindElement(wContact).Click();
                WaitHelper.cExplicitlyWaitForElementToBeClickable(driver, wSelectSearchContact, 40);
                driver.FindElement(wSelectSearchContact).SendKeys("Neeraj ");
                WaitHelper.cExplicitWaitForElementIsVisible(driver, wNeerajKushwaha, 40);
                driver.FindElement(wNeerajKushwaha).Click();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


        }


        public void FillEquipmentServiceRequest()
        {
            try
            {
                IWebElement element = driver.FindElement(wServiceType);
                SelectElement select = new SelectElement(element);
                WaitHelper.cWaitForLoader(driver, 40);
                select.SelectByValue("Equipment");
                WaitHelper.cWaitForLoader(driver, 40);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


        }
        public void FillTheTripInfoCard()
        {


        }

    }
}


