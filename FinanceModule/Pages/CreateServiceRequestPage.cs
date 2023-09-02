using AventStack.ExtentReports.Gherkin.Model;
using Dynamitey;
using FinanceModule.Utility;
using Gherkin.CucumberMessages.Types;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using NUnit.Framework;
using NUnit.Framework.Internal;
using OfficeOpenXml.Packaging.Ionic.Zlib;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using SharpCompress.Compressors.Xz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow.Assist;
using TrinityAirMedical.Utility;

namespace TrinityAirMedical.Pages
{
    public class CreateServiceRequestPage
    {
        private IWebDriver driver;
        public CreateServiceRequestPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public static string newTripID;

        By wserviceRequest = By.XPath("//span[text()='Service Request']");
        By wVerifyServiceRequest = By.XPath("//strong[text()='Service Request']");
        By wVerifyServiceRequests = By.XPath("//strong[contains(text(),'Service Requests')]");
        By wServiceRequestButton = By.XPath("//button//span[text()='Service Request']");
        By wCreateServiceRequest = By.XPath("//strong[text()='Create Service Request']");
        By selectCustomer = By.XPath("//span[text()='Select Customer ']/..//span[@class='nsdicon-angle-down']");
        By searchText = By.XPath("//input[@name='search-text']");
        By search = By.XPath("//input[@aria-label='multiselect-search']");
        By search2 = By.XPath("(//input[@aria-label='multiselect-search'])[2]");
        By pickuptime = By.XPath("//input[@placeholder='Pickup Time']");
        By addEquipTypes = By.XPath("//span[text()='Select Additional Equipment']");
        By equpSearch = By.XPath("(//input[@placeholder='Search'])[2]");
        By dropLocations = By.XPath("//select[@name='dropLocations']");
        By oRTime = By.XPath("//input[@placeholder='OR Time']");
        By selectOneCustomer = By.XPath("//ul[@class='available-items']//li");
        By selectContact = By.XPath("//span[text()='Select Contact ']/../span[@class='nsdicon-angle-down']");
        By selectOneContact = By.XPath("//ul[@class='available-items']//li");
        By phone = By.XPath("//div[@class='form-group']/label[text()='Phone']");
        By addContactButton = By.XPath("//button[@title='Create Contact']/i");
        By addContactPopup = By.XPath("//h4[text()='Add Contact']");
        By warning = By.XPath("//div[@role='alertdialog']");
        By WarningToastHead = By.XPath("//div[@aria-label='Warning']");
        By WarningToastMsg = By.XPath("//div[@aria-label='Address already exist']");
        By selectMember = By.XPath("//span[text()='Add New Member ']/..//span[@class='nsdicon-angle-down']");
        By firstMember = By.XPath("//ul[@class='available-items']/li[1]");
        By fName = By.XPath("//input[@name='firstName']");
        By lName = By.XPath("//input[@name='lName']");
        By wNumber = By.XPath("//input[@name='workNumber']");
        By designation = By.XPath("//select[@name='Designation']");
        By option1 = By.XPath("//option[text()='Administrator']");
        By addressType = By.XPath("//select[@name='addressType']");
        By option2 = By.XPath("//option[@value='Residential']");
        By privateRadio = By.XPath("//label[text()='Private']/input");
        By publicRadio = By.XPath("//label[text()='Public']/input");
        By saveChanges = By.XPath("(//button[text()='Save Changes'])[2]");
        By serviceType = By.XPath("//select[@name='servicetype']");
        By selectEquipment=By.XPath("//span[text()='Select Equipment ']/..");
        By selectPersonnel = By.XPath("//select[@name='selectedPersonalService']");
        By selectNextFlight = By.XPath("//span[text()='Select']/..//span[@class='dropdown-down']/..");
        By airportCode = By.XPath("//span[text()='Select Airport Code']");
        By specimen = By.XPath("//select[@name='specimenTye']");
        By origin = By.XPath("//label[text()='Origin']/..//button[@title='Create Location']");
        By verifyCreateLocation = By.XPath("//h4[text()='Create Location']");
        By destination = By.XPath("//label[text()='Destination']/..//button[@title='Create Location']");
        By locationName = By.XPath("//input[@name='addressName']");
        By addresstype = By.XPath("//select[@name='addressType']");
        By selectairportCode = By.XPath("//select[@name='airportCode']");
        By streetAdd = By.XPath("//input[@name='streetAddress']");
        By zipcode = By.XPath("//input[@name='Zipcode']");
        By selectState = By.XPath("//select[@name='state']");
        By selectCity = By.XPath("//select[@name='city']");
        By saveChangesLocation = By.XPath("(//button[text()='Save Changes'])[3]");
        By notesSave = By.XPath("(//button[text()='Save Changes'])[1]");
        By category = By.XPath("//select[@id='category0']");
        By instruction = By.XPath("//button[@title='Add Special Instruction']");
        By saveTemplate = By.XPath("//input[@title='Save Template']");
        By saveName = By.XPath("//input[@name='saveAsTemplate']");
        By saveButton = By.XPath("//input[@name='saveAsTemplate']/..//button[@type='submit']");
        By firstOrigin = By.XPath("//ul[@class='available-items']/li[1]");
        By secondOrigin = By.XPath("//ul[@class='available-items']/li[3]");//
        By secondDestination =  By.XPath("//span[text()='Select Destination ']");//
        By firstDestination = By.XPath("//ul[@class='available-items']/li[1]");
        By originButton = By.XPath("//span[text()='Select Origin ']/..");
        By destinationButton = By.XPath("//span[text()='Select Destination ']/..");
        By saveTransaction = By.XPath("//button[text()=' Save ']");
        By saveTransactionWithTempOption = By.XPath("//button[text()=' Cancel ']/parent::div/following-sibling::div/button");
        By destplus = By.XPath("//span[text()='Destination(s)']/../..//button[@class='plus-icon']");
        By firstDest = By.XPath("(//div[@class='row_container destination']//span[text()='Select Destination '])[1]");
        By firstCon = By.XPath("(//div[@class='row_container destination']//span[text()='Select Contact '])[1]");
        By selectTemplate = By.XPath("//span[text()='Select Template  ']/..");
        By addNote = By.XPath("//span[@data-target='#addNote']/..");
        By addFile = By.XPath("//span[@data-target='#UploadedFileView1']/..");
        By noteCategory = By.XPath("//select[@name='category']");
        By noteText = By.XPath("//textarea[@placeholder='Note']");
        By fileTab = By.XPath("//a[@data-toggle='tab']/b[contains(text(),'File')]");
        By viewFile = By.XPath("(//h4[text()='View File'])[1]");
        By uploadFile = By.XPath("(//input[@type='file'])[1]");
        By fileSave = By.XPath("//a[text()='Save']");
        By selectJobType = By.XPath("//span[text()='Select Job Type ']/..");
        By moreBUtton = By.XPath("(//div[@class='card-body-tab']//tbody/tr/td//button[@title='More'])[1]");
        By copyRequest = By.XPath("(//span[text()='Copy Service Request'])[1]/..");
        By xToast = By.XPath("//div[@class='toast-title ng-star-inserted']");
        By wSelectDestination = By.XPath("//span[contains(text(),'Select Destination')]");
        By wSelectVehicle = By.XPath("//select[@id = 'vehicleId']");
        By wSearchField = By.XPath("//input[@name = 'search-text']");
        By wSelectOrigin = By.XPath("//span[contains(text(),'Select Origin')]");
        By wSelectMember = By.XPath("//descendant::span[contains(text(),'Select Member ')][2]");
        By wSelectVendor = By.XPath("//descendant::span[contains(text(),'Select Vendor ')][2]");
        By wSelectVendorMember = By.XPath("//descendant::span[contains(text(),'Select Member ')][2]");
        By wFirstSearch = By.XPath("//ul[@class='available-items']/li[1]");
        By wSelectCoordinator = By.XPath("//span[contains(text(),'Select Coordinator ')]");
        By wAssignButton = By.XPath("//div[@class='modal-footer']/button[contains(text(),'Assign')]");
        By wAddLeg = By.XPath("//button[@name='addBtn']");
        By wAddLegforSR = By.XPath("//button[@id='add-leg-butt']");
        By wLegCheckInputs = By.XPath("//descendant::table[@id='leg_tableId']/preceding::input");
        By LegAssignB = By.XPath("//button[@id='proceed-assign-butt']");
        By SendAssignReqB = By.XPath("//button[@title='Send Assignment request']");
        By wInternal = By.XPath("//input[@value = 'TAM Internal']");
        By wExternal = By.XPath("//input[@value = 'External']");
        By wVehicleOption = By.XPath("//option[contains(text(),'test (Lights and Sirens)')]");
        By wVendorVehicleOption = By.XPath("//option[contains(text(),'Test Vehicle (Regular)')]");
        By wAssignLeg = By.XPath("//descendant::button[text()='Assign'][2]");
        By length =  By.XPath("//div[@class='row_container']//descendant::input[@type='checkbox']");
        By wCreatedTripID = By.XPath("//label[contains(text(),'Service Request No:')]/following-sibling::div/span");
        By wTripIDFilter = By.XPath("//label[contains(text(),'Trip ID')]/following-sibling::div");
        By wSearch = By.XPath("//label[contains(text(),'Trip ID')]/following-sibling::div/descendant::input[2]");
        By wSearchResult = By.XPath("//descendant::div[@class='dropdown-list'][4]/ul[@class='item2']/li");
        By wClearDate = By.XPath("//label[contains(text(),'From Date')]/following-sibling::button");
        By wApply = By.XPath("//button[contains(text(),'Apply')][1]");
        By wExpand = By.XPath("//b[contains(text(),'Expand All')]");
        By wStatusDD0 = By.XPath("//select[@id='selectedValue0']");
        By wStatusDD1 = By.XPath("//select[@id='selectedValue1']");
        By wStatusColumn = By.XPath("//td/div[@id='main_row_id']/div[7]/div[2]/div/span");
        public static String fileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "apple.pdf");
       
        public void clickServiceRequest()
      
        {
            WaitHelper.cExplicitWait(driver, wserviceRequest,10);
            driver.FindElement(wserviceRequest).Click();
        }

        public void verifyServiceRequestPage()
        {
            try
            {
                WaitHelper.cExplicitWait(driver, wVerifyServiceRequest, 30);
                Boolean flag = driver.FindElement(wVerifyServiceRequest).Displayed;
                Assert.IsTrue(flag, "The Doctor image is not displayed as per expectation.");
                WaitHelper.cWaitForLoader(driver, 30);
                WaitHelper.CHighlightElement(driver, wVerifyServiceRequest);
            }catch(Exception ex)
            {
                WaitHelper.cExplicitWait(driver, wVerifyServiceRequests, 30);
                Boolean flag = driver.FindElement(wVerifyServiceRequests).Displayed;
                Assert.IsTrue(flag, "The Doctor image is not displayed as per expectation.");
                WaitHelper.cWaitForLoader(driver, 30);
                WaitHelper.CHighlightElement(driver, wVerifyServiceRequests);

            }
        }
        public void createServiceRequestButton()
        {
            WaitHelper.cWaitForLoader(driver, 30);
            WaitHelper.CHighlightElement(driver, wServiceRequestButton);
            driver.FindElement(wServiceRequestButton).Click();
            WaitHelper.cWaitForLoader(driver, 30);
        }
        public void AcceptAlert()
        {
            try
            {
                driver.SwitchTo().Alert().Accept();
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString);
            }

        }
        

        public void verifyCreateServiceRequestButton()
        {
            WaitHelper.cExplicitWait(driver, wCreateServiceRequest, 20);
            Boolean flag = driver.FindElement(wCreateServiceRequest).Displayed;
            Assert.IsTrue(flag, "The Create Service Request Page is not displayed as per expectation.");
        }
        public void selectCustomerDetails(String customer)
        {
            driver.FindElement(selectCustomer).Click();
            WaitHelper.CHighlightElement(driver, selectCustomer);
            driver.FindElement(searchText).SendKeys(customer);
            WaitHelper.CHighlightElement(driver, searchText);
            WaitHelper.cExplicitWait(driver, selectOneCustomer, 20);
            WaitHelper.CHighlightElement(driver, selectOneCustomer);
            driver.FindElement(selectOneCustomer).Click();   
        }
        public void selectContactDetails(String contact)
        {
            WaitHelper.cExplicitlyWaitForElementToBeClickable(driver, selectContact, 30);
            driver.FindElement(selectContact).Click();
            WaitHelper.CHighlightElement(driver, selectContact);
            driver.FindElement(searchText).SendKeys(contact);
            WaitHelper.CHighlightElement(driver, searchText);
            Thread.Sleep(5000);
            WaitHelper.CHighlightElement(driver, selectOneContact);
            driver.FindElement(selectOneContact).Click();
            
        }
        public void phonePopulated()
        {
            Thread.Sleep(3000);
            WaitHelper.cExplicitWait(driver, phone, 20);
            Boolean flag = driver.FindElement(phone).Displayed;
            Assert.IsTrue(flag, "Phone number is not displayed as per expectation.");
        }
        public void clickAddContactButton()
        {
            driver.FindElement(addContactButton).Click();
            WaitHelper.CHighlightElement(driver, addContactButton);
            Thread.Sleep(3000);
        }
        public void verifyAddContactPopup()
        {
            Boolean flag = driver.FindElement(addContactPopup).Displayed;
            Assert.IsTrue(flag, "Add Contact popup is not displayed as per expectation.");
        }
        public void verifyWarning()
        {
            Thread.Sleep(2000);
            Console.WriteLine(driver.FindElement(warning).Text);
            Boolean flag = driver.FindElement(warning).Text.Equals("Please select customer first.", StringComparison.OrdinalIgnoreCase);
            Assert.IsTrue(flag, "Warning is not displayed as per expectation.");
        }
        public void verifyWarningOfSameAddress()
        {
            //Thread.Sleep(7000);
            //WaitHelper.WaitForElementPresent(driver, warning);
            //Boolean flag = driver.FindElement(warning).Text.Equals("Address already exist", StringComparison.OrdinalIgnoreCase);
            //Assert.IsTrue(flag, "Warning is not displayed as per expectation.");
            Toast.WarningToast(driver);//

        }
        public void verifyWarningPopUpOfSameAddress()
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(90));
                wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(xToast));
                bool flag = driver.FindElement(xToast).Text.Contains("Warning");
                Assert.IsTrue(flag, "Warning toastTitle is not displayed");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

        }
        public void addNewMember()
        {
            driver.FindElement(designation).Click();
            driver.FindElement(option1).Click();
            WaitHelper.cScrollIntoViewUsingJavaScriptExecutor(driver, privateRadio);
            driver.FindElement(addressType).Click();
            driver.FindElement(option2).Click();
            driver.FindElement(privateRadio).Click();
            WaitHelper.cScrollIntoViewUsingJavaScriptExecutor(driver, saveChanges);
            driver.FindElement(saveChanges).Click();
        }
        public void firstName(String firstName)
        {
            WaitHelper.CHighlightElement(driver, fName);
            driver.FindElement(fName).SendKeys(firstName);
        }
        public void lastName(String lastName)
        {
            WaitHelper.CHighlightElement(driver, lName);
            driver.FindElement(lName).SendKeys(lastName);
        }
        public void phoneNumber(String phoneNumber)
        {
            WaitHelper.CHighlightElement(driver, wNumber);
            driver.FindElement(wNumber).SendKeys(phoneNumber);
        }
        public void verifyContactAdded()
        {
            //Thread.Sleep(2000);
            //WaitHelper.WaitForElementPresent(driver, warning);
            //Boolean flag = driver.FindElement(warning).Text.Equals("Contact Added Successfully!", StringComparison.OrdinalIgnoreCase);
            //Assert.IsTrue(flag, "Warning is not displayed as per expectation.");
            Toast.SuccessToast(driver);
        }
        public void selectExistingMember()
        {
            WaitHelper.CHighlightElement(driver, selectMember);
            driver.FindElement(selectMember).Click();
            Thread.Sleep(2000);
            WaitHelper.WaitForElementPresent(driver, firstMember);
            WaitHelper.CHighlightElement(driver, firstMember);
            driver.FindElement(firstMember).Click();
        }
        public void selectServiceType(String serviceTypeButton)
        {
            WaitHelper.CHighlightElement(driver, serviceType);
            driver.FindElement(serviceType).Click();
            Thread.Sleep(4000);
            WaitHelper.WaitForElementPresent(driver, By.XPath("//option[@value='"+serviceTypeButton+"']"));
            IWebElement option = driver.FindElement(By.XPath("//option[@value='"+serviceTypeButton+"']"));
            option.Click();
        }
        public void selectEquipmentType(String equipment)
        {
            WaitHelper.CHighlightElement(driver, selectEquipment);
            driver.FindElement(selectEquipment).Click();
            WaitHelper.CHighlightElement(driver, searchText);
            driver.FindElement(searchText).SendKeys(equipment);
            Thread.Sleep(4000);
            IWebElement option = driver.FindElement(By.XPath("//li[contains(text(),'"+equipment+"')]"));
            option.Click();
        }

        public void selectPersonnelService(String personnelService)
        {
            WaitHelper.CHighlightElement(driver, selectPersonnel);
            driver.FindElement(selectPersonnel).Click();
            Thread.Sleep(2000);
            IWebElement option = driver.FindElement(By.XPath("//option[@value='"+personnelService+"']"));
            option.Click();
        }
        public void selectNextFlightOut(String nextFlight)
        {
            WaitHelper.CHighlightElement(driver, selectNextFlight);
            driver.FindElement(selectNextFlight).Click();
            Thread.Sleep(4000);
            WaitHelper.CHighlightElement(driver, search);
            driver.FindElement(search).SendKeys(nextFlight);
            Thread.Sleep(4000);
            IWebElement option = driver.FindElement(By.XPath("//div[text()='"+nextFlight+"']"));
            option.Click();
        }
       
        public void selectTeam(String team)
        {
            WaitHelper.CHighlightElement(driver, selectNextFlight);
            driver.FindElement(selectNextFlight).Click();
            WaitHelper.CHighlightElement(driver, search);
            driver.FindElement(search).SendKeys(team);
            //Thread.Sleep(4000);
            WaitHelper.WaitForElementPresent(driver, By.XPath("//div[text()='" + team + "']"));
            IWebElement option = driver.FindElement(By.XPath("//div[text()='"+team+"']"));
            option.Click();
        }
        public void pickupTime()
        {
            driver.FindElement(pickuptime).Click();
        }
        public void additionalEquipments(String addequipments)
        {
            driver.FindElement(By.XPath("//label[text()='Additional Equipments']/..//label[text()='"+addequipments+"']/input")).Click();
        }
        public void addEquipmentsTypes(String addEquipType)
        {
            WaitHelper.CHighlightElement(driver, addEquipTypes);
            driver.FindElement(addEquipTypes).Click();
            WaitHelper.WaitForElementPresent(driver, equpSearch);
            Thread.Sleep(3000);
            driver.FindElement(equpSearch).SendKeys(addEquipType);
            Thread.Sleep(3000);
            WaitHelper.WaitForElementPresent(driver, By.XPath("//div[text()='"+addEquipType+"']"));
            IWebElement option = driver.FindElement(By.XPath("//div[text()='"+addEquipType+"']"));
            option.Click();
        }
        public void selectOrganType(String organType)
        {
            WaitHelper.CHighlightElement(driver, selectNextFlight);
            driver.FindElement(selectNextFlight).Click();
            WaitHelper.CHighlightElement(driver, search);
            driver.FindElement(search).SendKeys(organType);
            Thread.Sleep(4000);
            IWebElement option = driver.FindElement(By.XPath("//div[text()='" + organType + "']"));
            option.Click();
        }
        public void specimenType(String specimenType)
        {
            WaitHelper.CHighlightElement(driver, specimen);
            driver.FindElement(specimen).Click();
            Thread.Sleep(2000);
            IWebElement option = driver.FindElement(By.XPath("//option[@value='"+specimenType+"']"));
            option.Click();
        }
        public void orTime()
        {
            TimeZoneInfo istTimeZone = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
            DateTime currentDateTime = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, istTimeZone);
            DateTime futureDateTime = currentDateTime.AddDays(1);
            string formattedFutureTimestamp = futureDateTime.ToString("MM/dd/yyyy HH:mm");
            driver.FindElement(oRTime).SendKeys(formattedFutureTimestamp);
        }
        public void pickUpTime()
        {
            driver.FindElement(By.XPath("//input[@placeholder='Pickup Time']")).Clear();
            TimeZoneInfo istTimeZone = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
            DateTime currentDateTime = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, istTimeZone);
            DateTime futureDateTime = currentDateTime.AddDays(3);
            string formattedFutureTimestamp = futureDateTime.ToString("MM/dd/yyyy HH:mm");
            driver.FindElement(By.XPath("//input[@placeholder='Pickup Time']")).SendKeys(formattedFutureTimestamp);
        }
        public void selectSirensAndOrtime(String siren)
        {
            orTime();
            IWebElement sirens = driver.FindElement(By.XPath("//label[text()='Lights and Sirens']/..//label[contains(text(),'"+siren+"')]/input"));
            sirens.Click();
        }
        public void pickUpType(String type)
        {
            IWebElement pick = driver.FindElement(By.XPath("//input[@value='"+type+"']"));
            pick.Click();
        }
        public void priorityType(String priority)
        {
            IWebElement priorityType = driver.FindElement(By.XPath("//label[text()='"+priority+"']/input"));
            priorityType.Click();
        }
        public void unosID(String id)
        {
            WaitHelper.CHighlightElement(driver, By.XPath("//label[text()='UNOS ID']/../input"));
            IWebElement unos = driver.FindElement(By.XPath("//label[text()='UNOS ID']/../input"));
            unos.Click();
            unos.SendKeys(id);
        }
        public void tissueID(String id)
        {
            WaitHelper.CHighlightElement(driver, By.XPath("//input[@placeholder='Tissue ID']"));
            IWebElement unos = driver.FindElement(By.XPath("//input[@placeholder='Tissue ID']"));
            unos.Click();
            unos.SendKeys(id);
        }
        public void matchID(String id)
        {
            WaitHelper.CHighlightElement(driver, By.XPath("//input[@placeholder='Match ID']"));
            IWebElement unos = driver.FindElement(By.XPath("//input[@placeholder='Match ID']"));
            unos.Click();
            unos.SendKeys(id);
        }
        public void medigo(String id)
        {
            WaitHelper.CHighlightElement(driver, By.XPath("//input[@placeholder='MediGO Tracker Number']"));
            IWebElement unos = driver.FindElement(By.XPath("//input[@placeholder='MediGO Tracker Number']"));
            unos.Click();
            unos.SendKeys(id);
        }
        public void jobID(String id)
        {
            WaitHelper.CHighlightElement(driver, By.XPath("//input[@placeholder='Air Space Job ID']"));
            IWebElement unos = driver.FindElement(By.XPath("//input[@placeholder='Air Space Job ID']"));
            unos.Click();
            unos.SendKeys(id);
        }
        public void trackingID(String id)
        {
            WaitHelper.CHighlightElement(driver, By.XPath("//input[@placeholder='Air Space Tracking ID']"));
            IWebElement unos = driver.FindElement(By.XPath("//input[@placeholder='Air Space Tracking ID']"));
            unos.Click();
            unos.SendKeys(id);
        }
        public void dropOffLocation(String location)
        {
            driver.FindElement(dropLocations).Click();
            IWebElement dropLocation = driver.FindElement(By.XPath("//label[text()='Drop Off Location ']/..//option[@value='" + location + "']"));
            dropLocation.Click();
        }
        public void dropOffCategory(String dropOffCategory)
        {
            driver.FindElement(By.XPath("//label[text()='"+dropOffCategory+"']//input[@name='optDropOffCategory']")).Click();
        }
        public void selectModeTransport(String mode)
        {
            WaitHelper.cScrollIntoViewUsingJavaScriptExecutor(driver, origin);
            IWebElement modeEle = driver.FindElement(By.XPath("//label[@id='"+mode+"']/input"));
            modeEle.Click();
            //publicAddress
            //airportAddress
            //privateAddress 
        }
        public void createLocationClick()
        {
            Thread.Sleep(3000);
            WaitHelper.CHighlightElement(driver, origin);
            driver.FindElement(origin).Click();
            Thread.Sleep(2000);
            Boolean flag = driver.FindElement(verifyCreateLocation).Displayed;
            Assert.IsTrue(flag, "Create location is not displayed as per expectation.");
        }
        public void location(String location)
        {
            WaitHelper.CHighlightElement(driver, locationName);
            driver.FindElement(locationName).SendKeys(location);//New York

        }
        public void selectAddressType(String addressType)
        {
            WaitHelper.CHighlightElement(driver, addresstype);
            driver.FindElement(addresstype).Click();
            IWebElement addTypeEle = driver.FindElement(By.XPath("//option[@value='"+addressType+"']"));
            addTypeEle.Click();
            //Residential,Hospital,Other
        }
        public void AddressMode(String addressMode)
        {
            IWebElement modeEle = driver.FindElement(By.XPath("//label[contains(text(),'"+addressMode+"')]/input"));
            modeEle.Click();
            //Private,Public,Airport
        }
        public void selectAirpportCode(String airpportCode)
        {
            WaitHelper.CHighlightElement(driver, selectairportCode);
            driver.FindElement(selectairportCode).Click();
            IWebElement codeEle = driver.FindElement(By.XPath("//option[@value='"+airpportCode+"']"));
            codeEle.Click();
            //6N5
        }
        public void airportcode(String code)
        {
            WaitHelper.CHighlightElement(driver, airportCode);
            driver.FindElement(airportCode).Click();
            WaitHelper.CHighlightElement(driver, search2);
            driver.FindElement(search2).SendKeys(code);
            Thread.Sleep(4000);
            IWebElement option = driver.FindElement(By.XPath("//div[text()='"+code+"']"));
            option.Click();
            driver.FindElement(category).Click();
        }
        public void streetAddress(String streetAddress)
        {
            TimeZoneInfo istTimeZone = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
            DateTime currentDateTime = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, istTimeZone);
            DateTime futureDateTime = currentDateTime.AddDays(1);
            string formattedFutureTimestamp = futureDateTime.ToString("MM/dd/yyyy HH:mm");
            WaitHelper.CHighlightElement(driver, streetAdd);
            driver.FindElement(streetAdd).SendKeys(streetAddress+" "+ formattedFutureTimestamp);
        }
        public void sameStreetAddress(String streetAddress)
        {
            WaitHelper.CHighlightElement(driver, streetAdd);
            driver.FindElement(streetAdd).SendKeys(streetAddress);
        }
        public void destinationStreetAddress(String streetAddress)
        {
            TimeZoneInfo istTimeZone = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
            DateTime currentDateTime = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, istTimeZone);
            DateTime futureDateTime = currentDateTime.AddDays(2);
            string formattedFutureTimestamp = futureDateTime.ToString("MM/dd/yyyy HH:mm");
            WaitHelper.CHighlightElement(driver, streetAdd);
            driver.FindElement(streetAdd).SendKeys(streetAddress + " " + formattedFutureTimestamp);
        }
        public void zipCode(String zipCode)
        {
            WaitHelper.CHighlightElement(driver, zipcode);
            driver.FindElement(zipcode).SendKeys(zipCode);
        }
        public void state(String state)
        {
            WaitHelper.CHighlightElement(driver, selectState);
            driver.FindElement(selectState).Click();
            WaitHelper.cScrollIntoViewUsingJavaScriptExecutor(driver, By.XPath("//option[contains(text(),'"+state+"')]"));
            IWebElement stateEle = driver.FindElement(By.XPath("//option[contains(text(),'"+state+"')]"));//New York
            stateEle.Click();
        }
        public void city(String city)
        {
            WaitHelper.CHighlightElement(driver, selectCity);
            driver.FindElement(selectCity).Click();
            WaitHelper.cScrollIntoViewUsingJavaScriptExecutor(driver, By.XPath("//option[text()='" + city + "']"));
            IWebElement cityEle = driver.FindElement(By.XPath("//option[text()='"+city+"']"));//New York
            cityEle.Click();
        }
        public void saveChangeslocation()
        {
            WaitHelper.CHighlightElement(driver, saveChangesLocation);
            driver.FindElement(saveChangesLocation).Click();
            WaitHelper.cWaitForLoader(driver, 40);
        }
        public void selectModeTransportDest(String mode)
        {
            IWebElement modeEle = driver.FindElement(By.XPath("(//label[@id='"+mode+"']/input)[2]"));
            modeEle.Click();
        }
        public void createDestinationLocation()
        {
            WaitHelper.CHighlightElement(driver, destination);
            driver.FindElement(destination).Click();
            Thread.Sleep(2000);
            Boolean flag = driver.FindElement(verifyCreateLocation).Displayed;
            Assert.IsTrue(flag, "Create location is not displayed as per expectation.");
        }
        public void selectCategory(String categoryText)
        {
            driver.FindElement(category).Click();
            IWebElement catEle = driver.FindElement(By.XPath("//option[contains(text(),'"+categoryText+"')]"));//Aircraft
            catEle.Click();
        }
        public void enterInstruction(String instructionText)
        {
            driver.FindElement(instruction).SendKeys(instructionText);
        }
        public void saveTemplates(String template)
        {
            TimeZoneInfo istTimeZone = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
            DateTime currentDateTime = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, istTimeZone);
            DateTime futureDateTime = currentDateTime.AddDays(2);
            string formattedFutureTimestamp = futureDateTime.ToString("MM/dd/yyyy HH:mm");
            WaitHelper.CHighlightElement(driver, saveTemplate);
            driver.FindElement(saveTemplate).Click();
            driver.FindElement(saveName).SendKeys(template+" "+ formattedFutureTimestamp);
            WaitHelper.CHighlightElement(driver, saveButton);
            driver.FindElement(saveButton).Click();
            Toast.SuccessToast(driver);//

        }
        public void selectOriginAndDest()
        {
            driver.FindElement(originButton).Click();
            driver.FindElement(firstOrigin).Click();
            WaitHelper.WaitForElementPresent(driver, destinationButton);
            driver.FindElement(destinationButton).Click();
            Thread.Sleep(2000);
            WaitHelper.WaitForElementPresent(driver, firstDestination);
            driver.FindElement(firstDestination).Click();
        }
        public void savetransactionWithAlert()
        {
            Thread.Sleep(5000);
            WaitHelper.cScrollIntoViewUsingJavaScriptExecutor(driver, saveTransaction);
            driver.FindElement(saveTransaction).Click();
            AcceptAlert();
            verifySuccessRequest();
        }
        public void savetransaction()
        {
            Thread.Sleep(5000);
            WaitHelper.cScrollIntoViewUsingJavaScriptExecutor(driver, saveTransaction);
            driver.FindElement(saveTransaction).Click();
        }
        

        public void savetransactionWithTempOpt()
        {
            Thread.Sleep(5000);
            WaitHelper.cScrollIntoViewUsingJavaScriptExecutor(driver, saveTransactionWithTempOption);
            driver.FindElement(saveTransactionWithTempOption).Click();
        }
        public void VerifyTheTransactionForAddLeg()
        {
            WaitHelper.cWaitForLoader(driver, 30);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(xToast));
            bool flag = driver.FindElement(xToast).Text.Contains("Success!");
            Assert.IsTrue(flag, "Success toastTitle is not displayed");
            Thread.Sleep(2000);
        }

        public void verifySuccessRequest()
        {

            //Thread.Sleep(1000);
            //WaitHelper.WaitForElementPresent(driver, warning);
            //Console.WriteLine(driver.FindElement(warning).Text);
            //Boolean flag = driver.FindElement(warning).Text.Equals("Service Request Added Successfully!", StringComparison.OrdinalIgnoreCase);
            ////Assert.IsTrue(flag, "Success message is not displayed as per expectation.");   
            //WaitHelper.cWaitForLoader(driver, 30);
            //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            //wait.Until(ExpectedConditions.ElementIsVisible(xToast));//
            //bool flag = driver.FindElement(xToast).Text.Contains(" Success! ");
            //Assert.IsTrue(flag, "Success toastTitle is not displayed");
            
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(xToast));
            bool flag = driver.FindElement(xToast).Text.Contains("Success!");
            Assert.IsTrue(flag, "Success toastTitle is not displayed");
            WaitHelper.cWaitForLoader(driver, 30);
            Thread.Sleep(2000);
        }
        public void destinationsMode(String destinationsmode)
        {
            driver.FindElement(By.XPath("//span[text()='Destination(s)']/../..//input[@value='"+destinationsmode+ "']")).Click();
            driver.FindElement(destplus).Click();
            driver.FindElement(firstDest).Click();
            driver.FindElement(firstOrigin).Click();
            //driver.FindElement(firstCon).Click();
            // driver.FindElement(firstOrigin).Click();
            Thread.Sleep(500);
            driver.FindElement(secondDestination).Click();//
            driver.FindElement(secondOrigin).Click();//
            //driver.FindElement(firstDest).Click();
            //driver.FindElement(firstOrigin).Click();
            //driver.FindElement(firstCon).Click();
            //driver.FindElement(firstOrigin).Click();
        }
        public void selectTemplates(String text)
        {
            driver.FindElement(selectTemplate).Click();
            //WaitHelper.WaitForElementPresent(driver, firstMember);
            //driver.FindElement(firstMember).Click();
            WaitHelper.cWaitForLoader(driver, 30);
            WaitHelper.WaitForElementPresent(driver, searchText);
            driver.FindElement(searchText).SendKeys(text);
            WaitHelper.WaitForElementPresent(driver, firstMember);
            driver.FindElement(firstMember).Click();
            WaitHelper.cWaitForLoader(driver, 30);
        }

        public void writeNotes(String text)
        {
            WaitHelper.cScrollIntoViewUsingJavaScriptExecutor(driver, addNote);
            WaitHelper.CHighlightElement(driver, addNote);
            driver.FindElement(addNote).Click();
            WaitHelper.WaitForElementPresent(driver, noteCategory);
            WaitHelper.CHighlightElement(driver, noteCategory);            
            driver.FindElement(noteCategory).Click();
            driver.FindElement(By.XPath("//option[contains(text(),'"+text+"')]")).Click();
            driver.FindElement(noteText).SendKeys("Due to " + text);
            driver.FindElement(notesSave).Click();
        }
        public void uploadingFile()
        {
            Thread.Sleep(5000);
            WaitHelper.cWaitForLoader(driver, 30);
            WaitHelper.cScrollIntoViewUsingJavaScriptExecutor(driver, addNote);
            WaitHelper.CHighlightElement(driver, fileTab);
            driver.FindElement(fileTab).Click();
            WaitHelper.CHighlightElement(driver, addFile);
            driver.FindElement(addFile).Click();
            WaitHelper.WaitForElementPresent(driver, viewFile);
            Thread.Sleep(5000);
            driver.FindElement(uploadFile).SendKeys(fileName);
            WaitHelper.cWaitForLoader(driver, 40);
            driver.FindElement(fileSave).Click();
        }
        public void jobType(String job)
        {
            WaitHelper.CHighlightElement(driver, selectJobType);
            driver.FindElement(selectJobType).Click();
            WaitHelper.CHighlightElement(driver, searchText);
            driver.FindElement(searchText).SendKeys(job);
            WaitHelper.WaitForElementPresent(driver, By.XPath("//ul[@class='available-items']/li[contains(text(),'"+job+"')]"));
            driver.FindElement(By.XPath("//ul[@class='available-items']/li[contains(text(),'"+job+"')]")).Click();
        }
        public void createServiceRequest()
        {
            WaitHelper.cWaitForLoader(driver, 40);
            WaitHelper.WaitForElementPresent(driver, moreBUtton);
            WaitHelper.cScrollIntoViewUsingJavaScriptExecutor(driver, moreBUtton);
            driver.FindElement(moreBUtton).Click();
            WaitHelper.WaitForElementPresent(driver, copyRequest);
            WaitHelper.CHighlightElement(driver,copyRequest); 
            driver.FindElement(copyRequest).Click();
        }
        public void EnterOriginLoction(string input)
        {
            WaitHelper.CHighlightElement(driver, wSelectOrigin);
            driver.FindElement(wSelectOrigin).Click();
            WaitHelper.CHighlightElement(driver, wSearchField);
            driver.FindElement(wSearchField).SendKeys(input);
            driver.FindElement(wFirstSearch).Click();

        }
        public void EnterDestiLoction(string input)
        {
            WaitHelper.CHighlightElement(driver, wSelectDestination);
            driver.FindElement(wSelectDestination).Click();
            WaitHelper.CHighlightElement(driver, wSearchField);
            driver.FindElement(wSearchField).SendKeys(input);
            driver.FindElement(wFirstSearch).Click();
        }
        public void SelectCoordinator(string input)
        {

            WaitHelper.WaitForElementPresent(driver, wSelectCoordinator);
            //Thread.Sleep(2000);
            //Toast.InformationToast(driver);
            
            WaitHelper.CHighlightElement(driver, wSelectCoordinator);
            driver.FindElement(wSelectCoordinator).Click();
            WaitHelper.CHighlightElement(driver, wSearchField);
            driver.FindElement(wSearchField).SendKeys(input);
            WaitHelper.cWaitForSpinner(driver, 60);
            driver.FindElement(wFirstSearch).Click();
            WaitHelper.cExplicitlyWaitForElementToBeClickable(driver, wAssignButton,10);
            driver.FindElement(wAssignButton).Click();
        }
        public void VerifyTheSuccessMessageForAssignCoordinator()
        {
            
            Toast.SuccessToast(driver);
        }
        public void ClickOnAddLeg()
        {


            WaitHelper.cWaitForLoader(driver,90);
            WaitHelper.cWaitForSpinner(driver, 80);
            driver.FindElement(wAddLegforSR).Click();
            WaitHelper.cWaitForLoader(driver, 90);
            WaitHelper.cWaitForSpinner(driver, 80);

        }
        public void SelectTransportType(string TransportType)
        {
            By wTransportType = By.XPath("//input[@value='"+TransportType+"']");
            driver.FindElement(wTransportType).Click();

        }
        public void SelectDirection(string Direction)
        {
            By wDirectionType = By.XPath("//input[@value='"+Direction+"']");

            driver.FindElement(wDirectionType).Click();

        }
        public void SelectOriginAddressType(string OriginAddType)
        {

            By wAddressType = By.XPath("//input[@name='originAddressType' and @value='public']");
            driver.FindElement(wAddressType).Click();

        }
        public void SelectDestinationAddressType(string DestinationAddType)
        {

            By wAddressType = By.XPath("//input[@name='destinationAddressType' and @value='public']");
            driver.FindElement(wAddressType).Click();

        }
        public void DestiLocation(string DestiLocation)
        {

            By wAddressType = By.XPath("//span[contains(text(),'Select Destination')]");
            driver.FindElement(wAddressType).Click();
            driver.FindElement(wSearchField).SendKeys(DestiLocation);
            Thread.Sleep(1500);
            driver.FindElement(wFirstSearch).Click();
        }
        public void ClickOnAddButton()
        {
            Thread.Sleep(5000);
            WaitHelper.cScrollIntoViewUsingJavaScriptExecutor(driver, wAddLeg);
            WaitHelper.CHighlightElement(driver, wAddLeg);
            try
            {
                driver.FindElement(wAddLeg).Click();
            }
            catch (Exception e)
            {
                driver.FindElement(wAddLeg).Click();
                Console.WriteLine(e.ToString);
            }
        }
        public void SelectTheLegsAndAssignToInternalDriver()
        {
            WaitHelper.cWaitForLoader(driver, 50);
            driver.FindElement(By.XPath("//input[@id = 'leg-chk-0']")).Click();
            driver.FindElement(By.XPath("//input[@id = 'leg-chk-1']")).Click();

            try
            {
                //IList<IWebElement> wLegs = driver.FindElements(wLegCheckInputs);

                //for (int i = 1; i < 3; i++)
                //{
                //    //WaitHelper.CHighlightElement(driver, wLegCheckInputs);
                //    wLegs[i].Click();
                //}
                WaitHelper.cExplicitlyWaitForElementToBeClickable(driver, LegAssignB, 10);
                driver.FindElement(LegAssignB).Click();
                WaitHelper.cWaitForLoader(driver, 60);
                WaitHelper.cWaitForSpinner(driver, 50);
                Thread.Sleep(2000);
                //driver.FindElement(wInternal).Click();//Default takes internal, 
                //WaitHelper.cWaitForSpinner(driver, 120);
                WaitHelper.cExplicitlyWaitForElementToBeClickable(driver, wSelectMember, 120);
                driver.FindElement(wSelectMember).Click();
                driver.FindElement(wSearchField).SendKeys("Manikant");
                WaitHelper.cExplicitWaitForElementIsVisible(driver, wFirstSearch, 120);
                driver.FindElement(wFirstSearch).Click();

                WaitHelper.cWaitForSpinner(driver, 50);
                WaitHelper.cExplicitlyWaitForElementToBeClickable(driver, wSelectVehicle, 120);
                driver.FindElement(wSelectVehicle).Click();
                WaitHelper.cExplicitWaitForElementIsVisible(driver, wVehicleOption, 120);
                driver.FindElement(wVehicleOption).Click();
                WaitHelper.cExplicitlyWaitForElementToBeClickable(driver, wAssignLeg, 120);
                WaitHelper.cExplicitlyWaitForElementToBeClickable(driver, wAssignLeg, 120);
                driver.FindElement(wAssignLeg).Click();

            }
            catch (Exception e)
            {
                Console.WriteLine(" Catch error message " + e.Message);
                throw new Exception(e.Message);
            }
        }

        public void SelectTheLegsAndAssignToExternalDriverOrVendor()
        {
            WaitHelper.cWaitForLoader(driver, 50);
            driver.FindElement(By.XPath("//input[@id = 'leg-chk-0']")).Click();
            driver.FindElement(By.XPath("//input[@id = 'leg-chk-1']")).Click();

            try
            {
                driver.FindElement(LegAssignB).Click();
                WaitHelper.cWaitForLoader(driver, 60);
                //WaitHelper.cWaitForSpinner(driver, 60);
                Thread.Sleep(2000);
                driver.FindElement(wExternal).Click();//External, 
                WaitHelper.cWaitForSpinner(driver, 120);
                Thread.Sleep(5000);
                WaitHelper.cExplicitlyWaitForElementToBeClickable(driver, wSelectVendor, 120);
                driver.FindElement(wSelectVendor).Click();
                driver.FindElement(wSearchField).SendKeys("Training");
                WaitHelper.cExplicitWaitForElementIsVisible(driver, wFirstSearch, 120);
                driver.FindElement(wFirstSearch).Click();

                WaitHelper.cExplicitlyWaitForElementToBeClickable(driver, wSelectVendorMember, 120);
                driver.FindElement(wSelectVendorMember).Click();
                Thread.Sleep(15000);
                driver.FindElement(wSearchField).SendKeys("Test");
                WaitHelper.cExplicitWaitForElementIsVisible(driver, wFirstSearch, 120);
                driver.FindElement(wFirstSearch).Click();

                WaitHelper.cExplicitlyWaitForElementToBeClickable(driver, wSelectVehicle, 120);
                driver.FindElement(wSelectVehicle).Click();
                Thread.Sleep(15000);
                WaitHelper.cExplicitWaitForElementIsVisible(driver, wVendorVehicleOption, 120);
                driver.FindElement(wVendorVehicleOption).Click();
                WaitHelper.cExplicitlyWaitForElementToBeClickable(driver, wAssignLeg, 120);
                driver.FindElement(wAssignLeg).Click();

            }
            catch (Exception e)
            {
                Console.WriteLine(" Catch error message " + e.Message);
                throw new Exception(e.Message);
            }
        }

        public void SelectTheLegsAndSendAssignmentRequest()
        {
            WaitHelper.cWaitForLoader(driver, 50);
            driver.FindElement(By.XPath("//input[@id = 'leg-chk-0']")).Click();
            driver.FindElement(By.XPath("//input[@id = 'leg-chk-1']")).Click();

            try
            {
                driver.FindElement(SendAssignReqB).Click();
                WaitHelper.cWaitForLoader(driver, 60);
                WaitHelper.cWaitForSpinner(driver, 60);
                Thread.Sleep(2000);

                WaitHelper.cExplicitlyWaitForElementToBeClickable(driver, wSelectVendor, 120);
                driver.FindElement(wSelectVendor).Click();
                driver.FindElement(wSearchField).SendKeys("Test Vendor");
                WaitHelper.cExplicitWaitForElementIsVisible(driver, wFirstSearch, 120);
                driver.FindElement(wFirstSearch).Click();

                //WaitHelper.cExplicitlyWaitForElementToBeClickable(driver, wSelectVendorMember, 120);
                //driver.FindElement(wSelectVendorMember).Click();
                //driver.FindElement(wSearchField).SendKeys("Meera");
                //WaitHelper.cExplicitWaitForElementIsVisible(driver, wFirstSearch, 120);
                //driver.FindElement(wFirstSearch).Click();

                //WaitHelper.cExplicitlyWaitForElementToBeClickable(driver, wSelectVehicle, 120);
                //driver.FindElement(wSelectVehicle).Click();
                //WaitHelper.cExplicitWaitForElementIsVisible(driver, wVehicleOption, 120);
                //driver.FindElement(wVehicleOption).Click();
                //WaitHelper.cExplicitlyWaitForElementToBeClickable(driver, wAssignLeg, 120);
                //driver.FindElement(wAssignLeg).Click();

            }
            catch (Exception e)
            {
                Console.WriteLine(" Catch error message " + e.Message);
                throw new Exception(e.Message);
            }
        }

        public void SuccessMessageForLegAssignment()
        {
            //WaitHelper.cWaitForLoader(driver,60);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
                wait.Until(ExpectedConditions.ElementIsVisible(xToast));
                bool flag = driver.FindElement(xToast).Text.Contains("Success");
                Assert.IsTrue(flag, "Success toastTitle is not displayed");
        }
        public void SaveTheServiceRequestNumber()
        {
            WaitHelper.cWaitForLoader(driver, 30);
            newTripID =  driver.FindElement(wCreatedTripID).Text.Trim();
            Console.WriteLine(newTripID);
        }
        public void CompleteTheStatusOfTheAllLegs()
        {
            WaitHelper.cExplicitlyWaitForElementToBeClickable(driver, wserviceRequest, 20);
            driver.FindElement(wserviceRequest).Click();
            WaitHelper.cWaitForLoader(driver, 60);
            driver.FindElement(wTripIDFilter).Click();
            driver.FindElement(wSearch).SendKeys(newTripID);
            Thread.Sleep(2000);
            driver.FindElement(wSearchResult).Click();
            driver.FindElement(wClearDate).Click();
            driver.FindElement(wApply).Click();
            WaitHelper.cWaitForLoader(driver, 60);
            driver.FindElement(wExpand).Click();

            try
            {
                
                WaitHelper.cExplicitlyWaitForElementToBeClickable(driver, wStatusDD0, 30);
                WaitHelper.selectDDLByValue(driver, wStatusDD0, "Enroute");
                Thread.Sleep(10000);
                WaitHelper.cExplicitlyWaitForElementToBeClickable(driver, wStatusDD0, 30);
                WaitHelper.selectDDLByValue(driver, wStatusDD0, "On-Scene");
                driver.SwitchTo().Alert().Accept(); //need to remove after fix
                Thread.Sleep(10000);
                WaitHelper.cExplicitlyWaitForElementToBeClickable(driver, wStatusDD0, 30);
                WaitHelper.selectDDLByValue(driver, wStatusDD0, "Picked up");
                Thread.Sleep(10000);
                WaitHelper.cExplicitlyWaitForElementToBeClickable(driver, wStatusDD0, 30);
                WaitHelper.selectDDLByValue(driver, wStatusDD0, "Dropped Off");
                Thread.Sleep(10000);
                WaitHelper.cExplicitlyWaitForElementToBeClickable(driver, wStatusDD0, 30);
                WaitHelper.selectDDLByValue(driver, wStatusDD0, "Driver Done");
                Thread.Sleep(10000);
                WaitHelper.cExplicitlyWaitForElementToBeClickable(driver, wStatusDD0, 30);
                WaitHelper.selectDDLByValue(driver, wStatusDD0, "Job Done");
                Thread.Sleep(10000);

            }
            catch (Exception ex)
            {
                WaitHelper.cExplicitlyWaitForElementToBeClickable(driver, wStatusDD0, 30);
                WaitHelper.selectDDLByValue(driver, wStatusDD0, "Picked up");
                Thread.Sleep(10000);
                WaitHelper.cExplicitlyWaitForElementToBeClickable(driver, wStatusDD0, 30);
                WaitHelper.selectDDLByValue(driver, wStatusDD0, "Dropped Off");
                Thread.Sleep(10000);
                WaitHelper.cExplicitlyWaitForElementToBeClickable(driver, wStatusDD0, 30);
                WaitHelper.selectDDLByValue(driver, wStatusDD0, "Driver Done");
                Thread.Sleep(10000);
                WaitHelper.cExplicitlyWaitForElementToBeClickable(driver, wStatusDD0, 30);
                WaitHelper.selectDDLByValue(driver, wStatusDD0, "Job Done");
            }
            try
            {
                Thread.Sleep(10000);
                WaitHelper.cExplicitlyWaitForElementToBeClickable(driver, wStatusDD1, 30);
                WaitHelper.selectDDLByValue(driver, wStatusDD1, "Enroute");
                driver.SwitchTo().Alert().Accept();
                Thread.Sleep(10000);
                WaitHelper.cExplicitlyWaitForElementToBeClickable(driver, wStatusDD1, 30);
                WaitHelper.selectDDLByValue(driver, wStatusDD1, "On-Scene");
                driver.SwitchTo().Alert().Accept();
                Thread.Sleep(10000);
                WaitHelper.cExplicitlyWaitForElementToBeClickable(driver, wStatusDD1, 30);
                WaitHelper.selectDDLByValue(driver, wStatusDD1, "Picked up");
                //driver.SwitchTo().Alert().Accept(); //need to remove after fix
                Thread.Sleep(10000);
                WaitHelper.cExplicitlyWaitForElementToBeClickable(driver, wStatusDD1, 30);
                WaitHelper.selectDDLByValue(driver, wStatusDD1, "Dropped Off");
                Thread.Sleep(10000);
                WaitHelper.cExplicitlyWaitForElementToBeClickable(driver, wStatusDD1, 30);
                WaitHelper.selectDDLByValue(driver, wStatusDD1, "Driver Done");
                Thread.Sleep(10000);
                WaitHelper.cExplicitlyWaitForElementToBeClickable(driver, wStatusDD1, 30);
                WaitHelper.selectDDLByValue(driver, wStatusDD1, "Job Done");
                Thread.Sleep(10000);
            }
            catch (Exception ex)
            {
                try {
                    Thread.Sleep(7000);
                    WaitHelper.cExplicitlyWaitForElementToBeClickable(driver, wStatusDD1, 30);
                    WaitHelper.selectDDLByValue(driver, wStatusDD1, "On-Scene");
                    driver.SwitchTo().Alert().Accept();
                    Thread.Sleep(7000);
                    WaitHelper.cExplicitlyWaitForElementToBeClickable(driver, wStatusDD1, 30);
                    WaitHelper.selectDDLByValue(driver, wStatusDD1, "Picked up");
                    //driver.SwitchTo().Alert().Accept(); //need to remove after fix
                    Thread.Sleep(7000);
                    WaitHelper.cExplicitlyWaitForElementToBeClickable(driver, wStatusDD1, 30);
                    WaitHelper.selectDDLByValue(driver, wStatusDD1, "Dropped Off");
                    Thread.Sleep(7000);
                    WaitHelper.cExplicitlyWaitForElementToBeClickable(driver, wStatusDD1, 30);
                    WaitHelper.selectDDLByValue(driver, wStatusDD1, "Driver Done");
                    Thread.Sleep(7000);
                    WaitHelper.cExplicitlyWaitForElementToBeClickable(driver, wStatusDD1, 30);
                    WaitHelper.selectDDLByValue(driver, wStatusDD1, "Job Done");
                    Thread.Sleep(7000);
                }
                catch (Exception e)
                {
                    Thread.Sleep(7000);
                    WaitHelper.cExplicitlyWaitForElementToBeClickable(driver, wStatusDD1, 30);
                    WaitHelper.selectDDLByValue(driver, wStatusDD1, "Picked up");
                    //driver.SwitchTo().Alert().Accept(); //need to remove after fix
                    Thread.Sleep(7000);
                    WaitHelper.cExplicitlyWaitForElementToBeClickable(driver, wStatusDD1, 30);
                    WaitHelper.selectDDLByValue(driver, wStatusDD1, "Dropped Off");
                    Thread.Sleep(7000);
                    WaitHelper.cExplicitlyWaitForElementToBeClickable(driver, wStatusDD1, 30);
                    WaitHelper.selectDDLByValue(driver, wStatusDD1, "Driver Done");
                    Thread.Sleep(7000);
                    WaitHelper.cExplicitlyWaitForElementToBeClickable(driver, wStatusDD1, 30);
                    WaitHelper.selectDDLByValue(driver, wStatusDD1, "Job Done");
                    Thread.Sleep(7000);
                }
            }
        

        }
        public void StatusForTheSR()
        {
            
            Thread.Sleep(5000);
            bool flag = driver.FindElement(wStatusColumn).Text.Contains("Completed");
            Assert.IsTrue(flag, "SR is not completed yet");
        }
        

    }
}
