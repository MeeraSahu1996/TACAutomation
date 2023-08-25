using FinanceModule.Utility;
using NUnit.Framework;
using OpenQA.Selenium;
using TrinityAirMedical.Pages;
using TrinityAirMedical.Utility;

namespace TrinityAirMedical.StepDefinitions
{
    [Binding]
    public sealed class ServiceRequestAutomationStepDefinition
    {
        private IWebDriver driver;
        ServiceRequestAutomationPage serviceRequestAutomationPage;
        public ServiceRequestAutomationStepDefinition(IWebDriver driver)
        {
            this.driver = driver;
        }
        [Given(@"launch the application")]
        //public void GivenLaunchTheApplication()
        //{
        //    //FirstBeforeScenario
        //    //throw new PendingStepException();

        //}

        [When(@"enter the email (.*)")]
        public void WhenEnterTheEmail(String email)
        {

            serviceRequestAutomationPage = new ServiceRequestAutomationPage(driver);
            serviceRequestAutomationPage.enterEmail(email);
        }

        [When(@"enter the password (.*)")]
        public void WhenEnterThePasswordXoALPftM(string password)
        {
            serviceRequestAutomationPage.enterPassword(password);
        }

        [When(@"click on submit button")]
        public void WhenClickOnSubmitButton()
        {
            serviceRequestAutomationPage.clickSubmit();
        }

        [When(@"enter email (.*)")]
        public void WhenEnterEmail(string email)
        {
            serviceRequestAutomationPage.verifyImage();
            serviceRequestAutomationPage.enterSecondEmail(email);

        }

        [When(@"enter password (.*)")]
        public void WhenEnterPassword(String password)
        {
            serviceRequestAutomationPage.clickNextButton();
            serviceRequestAutomationPage.enterSecondPassword(password);
            serviceRequestAutomationPage.clickVerifyButton();
        }

        [When(@"verify Home page")]
        public void WhenVerifyHomePage()
        {
            serviceRequestAutomationPage.verifyLogoforHomePage();
        }

        [When(@"Click on Service Request option")]
        public void WhenClickOnServiceRequestOption()
        {
            serviceRequestAutomationPage.clickServiceRequest();
        }

        [Then(@"Service Request Page should open\.")]
        public void ThenServiceRequestPageShouldOpen_()
        {
            serviceRequestAutomationPage.verifyServiceRequestPage();
        }

        [Then(@"Click on Service Type dropdown")]
        public void ThenClickOnServiceTypeDropdown()
        {
            serviceRequestAutomationPage.ClickServiceTypeFilter();

        }

        [Then(@"Click on status dropdown")]
        public void ThenClickOnStatusDropdown()
        {
            serviceRequestAutomationPage.ClickStatusFilter();

        }

        [Then(@"Verify the Options present in Service Type filter")]
        public void ThenVerifyTheOptionsPresentInServiceTypeFilter()
        {
            By wListofServiceTypes = By.XPath("//label[contains(text(),'Service Type')]/parent::div/descendant::ul[@class='item2']");
            List<string> serviceTypes = new List<string>() { "Equipment", "Internal", "Next Flight Out", "Organ", "Specimen", "Team" };
            WaitHelper.cExplicitWait(driver, wListofServiceTypes, 40);

            List<string> getServiceType = new List<string>();
            for (int i = 0, j = 1; i < getServiceType.Count || j <= serviceTypes.Count; i++)
            {
                string a = driver.FindElement(By.XPath($"//label[contains(text(),'Service Type')]/parent::div/descendant::ul[@class='item2']/descendant::div[{j}]")).GetAttribute("textContent");
                getServiceType.Add(a);
                Console.WriteLine($"\n\n {a}");

                j++;
            }
            Assert.AreEqual(serviceTypes, getServiceType, "Service Type filter data is not same as expected");
        }

        [Then(@"Verify that on Selecting Equipment types Service Request from Service Type Filter it should filter only Selected one")]
        public void ThenVerifyThatOnSelectingEquipmentTypesServiceRequestFromServiceTypeFilterItShouldFilterOnlySelectedOne()
        {
            serviceRequestAutomationPage.CheckEquipmentType();
            serviceRequestAutomationPage.ClearOverlapping();
            serviceRequestAutomationPage.SelectFromAndToDate();
            serviceRequestAutomationPage.Apply();
            WaitHelper.cWaitForLoader(driver, 20);
            serviceRequestAutomationPage.Show25Entries();
            serviceRequestAutomationPage.GetDataFromTypeColAndCompareWithSelectedServiceTypeEquipment();

        }

        [Then(@"Verify that on Selecting Internal types Service Request from Service Type Filter it should filter only Selected one")]
        public void ThenVerifyThatOnSelectingInternalTypesServiceRequestFromServiceTypeFilterItShouldFilterOnlySelectedOne()
        {
            serviceRequestAutomationPage.CheckInternalType();
            serviceRequestAutomationPage.ClearOverlapping();
            serviceRequestAutomationPage.SelectFromAndToDate();
            serviceRequestAutomationPage.Apply();
            WaitHelper.cWaitForLoader(driver, 20);
            serviceRequestAutomationPage.Show25Entries();
            serviceRequestAutomationPage.GetDataFromTypeColAndCompareWithSelectedServiceTypeInternal();
        }

        [Then(@"Verify that on Selecting Next Flight Out types Service Request from Service Type Filter it should filter only Selected one")]
        public void ThenVerifyThatOnSelectingNextFlightOutTypesServiceRequestFromServiceTypeFilterItShouldFilterOnlySelectedOne()
        {
            serviceRequestAutomationPage.CheckNextFlightOutType();
            serviceRequestAutomationPage.ClearOverlapping();
            serviceRequestAutomationPage.SelectFromAndToDate();
            serviceRequestAutomationPage.Apply();
            WaitHelper.cWaitForLoader(driver, 20);
            serviceRequestAutomationPage.Show25Entries();
            serviceRequestAutomationPage.GetDataFromTypeColAndCompareWithSelectedServiceTypeNextFlightOut();
        }

        [Then(@"Verify that on Selecting Organ types Service Request from Service Type Filter it should filter only Selected one")]
        public void ThenVerifyThatOnSelectingOrganTypesServiceRequestFromServiceTypeFilterItShouldFilterOnlySelectedOne()
        {
            serviceRequestAutomationPage.CheckOrganType();
            serviceRequestAutomationPage.ClearOverlapping();
            serviceRequestAutomationPage.SelectFromAndToDate();
            serviceRequestAutomationPage.Apply();
            WaitHelper.cWaitForLoader(driver, 20);
            serviceRequestAutomationPage.Show25Entries();
            serviceRequestAutomationPage.GetDataFromTypeColAndCompareWithSelectedServiceTypeOrgan();
        }

        [Then(@"Verify that on Selecting Specimen types Service Request from Service Type Filter it should filter only Selected one")]
        public void ThenVerifyThatOnSelectingSpecimenTypesServiceRequestFromServiceTypeFilterItShouldFilterOnlySelectedOne()
        {
            serviceRequestAutomationPage.CheckSpecimenType();
            serviceRequestAutomationPage.ClearOverlapping();
            serviceRequestAutomationPage.SelectFromAndToDate();
            serviceRequestAutomationPage.Apply();
            WaitHelper.cWaitForLoader(driver, 20);
            serviceRequestAutomationPage.Show25Entries();
            serviceRequestAutomationPage.GetDataFromTypeColAndCompareWithSelectedServiceTypeSpecimen();
        }

        [Then(@"Verify that on Selecting Team types Service Request from Service Type Filter it should filter only Selected one")]
        public void ThenVerifyThatOnSelectingTeamTypesServiceRequestFromServiceTypeFilterItShouldFilterOnlySelectedOne()
        {
            serviceRequestAutomationPage.CheckTeamType();
            serviceRequestAutomationPage.ClearOverlapping();
            serviceRequestAutomationPage.ClearDate();
            serviceRequestAutomationPage.Apply();
            WaitHelper.cWaitForLoader(driver, 20);
            serviceRequestAutomationPage.Show25Entries();
            serviceRequestAutomationPage.GetDataFromTypeColAndCompareWithSelectedServiceTypeTeam();
        }

        [Then(@"Verify that on Selecting different Cancelled options from status filter it should filter only the Selected one")]
        public void ThenVerifyThatOnSelectingDifferentCancelledOptionsFromStatusFilterItShouldFilterOnlyTheSelectedOne()
        {
            serviceRequestAutomationPage.CheckCancelled();
            serviceRequestAutomationPage.ClearOverlapping();
            serviceRequestAutomationPage.ClearDate();
            serviceRequestAutomationPage.Apply();
            WaitHelper.cWaitForLoader(driver, 20);
            serviceRequestAutomationPage.Show25Entries();
            serviceRequestAutomationPage.GetDataFromStatusColAndCompareWithSelectedStatusTypeCancelled();
        }

        [Then(@"Verify that on Selecting different Completed options from status filter it should filter only the Selected one")]
        public void ThenVerifyThatOnSelectingDifferentCompletedOptionsFromStatusFilterItShouldFilterOnlyTheSelectedOne()
        {
            serviceRequestAutomationPage.CheckCompleted();
            serviceRequestAutomationPage.ClearOverlapping();
            serviceRequestAutomationPage.ClearDate();
            serviceRequestAutomationPage.Apply();
            WaitHelper.cWaitForLoader(driver, 20);
            serviceRequestAutomationPage.Show25Entries();
            serviceRequestAutomationPage.GetDataFromStatusColAndCompareWithSelectedStatusTypeCompleted();
        }
        [Then(@"Verify that on Selecting different Enroute options from status filter it should filter only the Selected one")]
        public void ThenVerifyThatOnSelectingDifferentEnrouteOptionsFromStatusFilterItShouldFilterOnlyTheSelectedOne()
        {
            serviceRequestAutomationPage.CheckEnroute();
            serviceRequestAutomationPage.ClearOverlapping();
            serviceRequestAutomationPage.ClearDate();
            serviceRequestAutomationPage.Apply();
            WaitHelper.cWaitForLoader(driver, 20);
            serviceRequestAutomationPage.Show25Entries();
            serviceRequestAutomationPage.GetDataFromStatusColAndCompareWithSelectedStatusTypeEnroute();
        }
        [Then(@"Verify that on Selecting different Not Started options from status filter it should filter only the Selected one")]
        public void ThenVerifyThatOnSelectingDifferentNotStartedOptionsFromStatusFilterItShouldFilterOnlyTheSelectedOne()
        {
            serviceRequestAutomationPage.CheckNotStarted();
            serviceRequestAutomationPage.ClearOverlapping();
            serviceRequestAutomationPage.SelectFromAndToDate();
            serviceRequestAutomationPage.Apply();
            WaitHelper.cWaitForLoader(driver, 20);
            serviceRequestAutomationPage.Show25Entries();
            serviceRequestAutomationPage.GetDataFromStatusColAndCompareWithSelectedStatusTypeNotStarted();
        }
        [Then(@"Click on Customer dropdown")]
        public void ThenClickOnCustomerDropdown()
        {

            WaitHelper.cWaitForLoader(driver, 20);
            serviceRequestAutomationPage.ClickOnCustomerDropdown();

        }
        [Then(@"select for Demo Customer available in Dropdown And Verify the output filter result")]
        public void ThenSelectForDemoCustomerAvailableInDropdownAndVerifyTheOutputFilterResult()
        {

            serviceRequestAutomationPage.SelectDemoCustomer();
            serviceRequestAutomationPage.Apply();
            serviceRequestAutomationPage.VerifyTheResultForDemoCustomer();

        }

        [Then(@"Click on View Call Flow Details Button and Verify the title for the same")]
        public void ThenClickOnViewCallFlowDetailsButtonAndVerifyTheTitleForTheSame()
        {
            serviceRequestAutomationPage.ClickOnViewCallFlowDetailsButtonAndVerifyTheTitle();
        }

        [Then(@"Click on View Check List Details Button and Verify the title for the same")]
        public void ThenClickOnViewCheckListDetailsButtonAndVerifyTheTitleForTheSame()
        {
            serviceRequestAutomationPage.ClickOnViewCheckListDetailsButtonAndVerifyTheTitle();
        }


        [Then(@"Click on more button")]
        public void ThenClickOnMoreButton()
        {

            serviceRequestAutomationPage.ClearDate();
            serviceRequestAutomationPage.Apply();
            serviceRequestAutomationPage.ClickOnMoreButton();
        }

        [Then(@"Click on Add files button and Verify the Title of new window")]
        public void ThenClickOnAddFilesButtonAndVerifyTheTitleOfNewWindow()
        {
            serviceRequestAutomationPage.ClickOnAddFilesButtonAndVerifyTheTitleOfNewWindow();
        }

        [Then(@"Attach at file and verify the success message")]
        public void ThenAttachAtFileAndVerifyTheSuccessMessage()
        {
            serviceRequestAutomationPage.AttachAtFileAndVerifyTheSuccessMessage();
        }

        [Then(@"Click on Trip Report button and Verify the Title of new window")]
        public void ThenClickOnTripReportButtonAndVerifyTheTitleOfNewWindow()
        {
            serviceRequestAutomationPage.ClickOnTripReportButtonAndVerifyTheTitleOfNewWindow();
        }

        [Then(@"Click on View File Cancle button")]
        public void ThenClickOnViewFileCancleButton()
        {
            serviceRequestAutomationPage.ClickOnViewFileCancleButton();
        }

        [Then(@"Click on Trip Report Cancle button")]
        public void ThenClickOnTripReportCancleButton()
        {
            serviceRequestAutomationPage.ClickOnTripReportCancleButton();
        }
        [Then(@"Click on Cancle Service Request accept the alert")]
        public void ThenClickOnCancleServiceRequestAcceptTheAlert()
        {
            serviceRequestAutomationPage.ClickOnCancleServiceRequestAcceptTheAlert();
        }

        [Then(@"Verify the success message")]
        public void ThenVerifyTheSuccessMessageforCancleSRq()
        {
            serviceRequestAutomationPage.VerifyTheSuccessMessageforCancleSRq();
        }

        [Then(@"click on Copy Service Request and Verify the Title of new window")]
        public void ThenClickOnCopyServiceRequestAndVerifyTheTitleOfNewWindow()
        {
            serviceRequestAutomationPage.ClickOnCopyServiceRequestAndVerifyTheTitleOfNewWindow();
        }

        [Then(@"Click on Back button")]
        public void ThenClickOnBackButton()
        {
            serviceRequestAutomationPage.ClickOnBackButton();
        }

        [Then(@"Click on Assign Coordinator and Verify the Title of new window")]
        public void ThenClickOnAssignCoordinatorAndVerifyTheTitleOfNewWindow()
        {
            serviceRequestAutomationPage.ClickOnAssignCoordinatorAndVerifyTheTitleOfNewWindow();
        }

        [Then(@"Give input Service Account Coordinator to Assign Coordinator request")]
        public void ThenGiveInputServiceAccountCoordinatorToAssignCoordinatorRequest()
        {
            serviceRequestAutomationPage.GiveInputServiceAccountCoordinatorToAssignCoordinatorRequest();
        }

        [Then(@"Click on Assign Button and Verify the success message")]
        public void ThenClickOnAssignButtonAndVerifyTheSuccessMessage()
        {
            serviceRequestAutomationPage.ClickOnAssignButtonAndVerifyTheSuccessMessage();
        }
        [Then(@"click on Edit Service Request and Verify the Title of new window")]
        public void ThenClickOnEditServiceRequestAndVerifyTheTitleOfNewWindow()
        {
            serviceRequestAutomationPage.ClickOnEditServiceRequestAndVerifyTheTitleOfNewWindow();
        }

        [Then(@"Get the Trip id of the Cancelled Request and Click on Un-Cancel Button")]
        public void ThenGetTheTripIdOfTheCancelledRequestAndClickOnUn_CancelButton()
        {
            serviceRequestAutomationPage.GetTheTripIdOfTheCancelledRequestAndClickOnUn_CancelButton();
        }

        [Then(@"Give input to the search field and verify the result")]
        public void ThenGiveInputToTheSearchFieldAndVerifyTheResult()
        {
            serviceRequestAutomationPage.GiveInputToTheSearchFieldAndVerifyTheResult();
        }


        [Then(@"Apply the filter for the Stored Trip id and check the status of same")]
        public void ThenApplyTheFilterForTheStoredTripIdAndCheckTheStatusOfSame()
        {
            serviceRequestAutomationPage.FilterForTheStoredTripIdAndCheck();
        }

        [Then(@"select for each Customer available in Dropdown And Verify the output filter result")]
        public void ThenSelectForEachCustomerAvailableInDropdownAndVerifyTheOutputFilterResult()
        {
            try
            {
                var CustomerList = serviceRequestAutomationPage.GetCustomerListfromCustomerDropDown();

                serviceRequestAutomationPage.SelectFromAndToDate();
                serviceRequestAutomationPage.Show25Entries();
                //CheckTheFilterOutputForEachCustomer
                foreach (var data in CustomerList)
                {
                    serviceRequestAutomationPage.ToViewOrScroll(data);
                    data.Click();// click on eachcustomer 
                    serviceRequestAutomationPage.Apply();
                    WaitHelper.cWaitForLoader(driver, 20);
                    serviceRequestAutomationPage.GetDataFromCustomerColAndCompareWithSelectedCustomerfromCustomerFilter(data);
                    WaitHelper.cWaitForLoader(driver, 20);
                    serviceRequestAutomationPage.ClearSelectedInputsFromCustomer(data);

                }
            }
            catch (Exception ex)
            {
                try
                {
                    serviceRequestAutomationPage.Reload();

                    WaitHelper.cWaitForLoader(driver, 20);
                    serviceRequestAutomationPage.ClickOnCustomerDropdown();

                    var CustomerList = serviceRequestAutomationPage.GetCustomerListfromCustomerDropDown();

                    serviceRequestAutomationPage.SelectFromAndToDate();
                    serviceRequestAutomationPage.Show25Entries();
                    //CheckTheFilterOutputForEachCustomer
                    foreach (var data in CustomerList)
                    {
                        serviceRequestAutomationPage.ToViewOrScroll(data);
                        data.Click();// click on eachcustomer 
                        serviceRequestAutomationPage.Apply();
                        WaitHelper.cWaitForLoader(driver, 20);
                        serviceRequestAutomationPage.GetDataFromCustomerColAndCompareWithSelectedCustomerfromCustomerFilter(data);
                        WaitHelper.cWaitForLoader(driver, 20);
                        serviceRequestAutomationPage.ClearSelectedInputsFromCustomer(data);

                    }
                }
                catch
                {
                    Console.WriteLine(ex.ToString());

                }


            }
        }
        [Then(@"Click on Trip ID dropdown")]
        public void ThenClickOnTripIDDropdown()
        {
            WaitHelper.cWaitForLoader(driver, 20);
            serviceRequestAutomationPage.CheckTripId();
        }

        [Then(@"Provid (.*) input in search field of UNOSID Dropdown And Verify the output filter result")]
        public void ThenProvidInputInSearchFieldOfUNOSIDDropdownAndVerifyTheOutputFilterResult(string input)
        {
            serviceRequestAutomationPage.InputUNOSID(input);
            serviceRequestAutomationPage.GetDataForUNOSIDColAndVerifyTheResult(input);
        }

        [Then(@"Click on UNOS ID dropdown")]
        public void ThenClickOnUNOSIDDropdown()
        {
            WaitHelper.cWaitForLoader(driver, 20);
            serviceRequestAutomationPage.CheckUNOSID();
        }
        [Then(@"Provid (.*) input in search field of Dropdown And Verify the output filter result")]
        public void ThenProvidInputInSearchFieldOfDropdownAndVerifyTheOutputFilterResult(string input)
        {
            serviceRequestAutomationPage.InputTripId(input);
            serviceRequestAutomationPage.GetDataFromTripDColAndVerifyTheResult(input);

        }

        [Then(@"Select the From and To date")]
        public void ThenSelectTheFromAndToDate()
        {
            WaitHelper.cWaitForLoader(driver, 20);
            serviceRequestAutomationPage.SelectFromAndToDate();
        }


        [Then(@"Click on More Filters")]
        public void ThenClickOnMoreFilters()
        {
            WaitHelper.cWaitForLoader(driver, 20);
            serviceRequestAutomationPage.ClickMoreFilters();
        }

        [Then(@"Click on Origin dropdown")]
        public void ThenClickOnOriginDropdown()
        {
            WaitHelper.cWaitForLoader(driver, 20);
            serviceRequestAutomationPage.ClickOnOriginDropdown();
        }

        [Then(@"Click on Created By dropdown")]
        public void ThenClickOnCreatedByDropdown()
        {
            WaitHelper.cWaitForLoader(driver, 20);
            serviceRequestAutomationPage.ClickOnCreatedByDropdown();
        }


        [Then(@"Provid (.*) input in search field of Origin")]
        public void ThenProvidMagicValleyInputInSearchFieldOfOrigin(string input)
        {
            WaitHelper.cWaitForLoader(driver, 20);
            serviceRequestAutomationPage.InputToOriginFilter(input);
        }

        [Then(@"click on Apply")]
        public void ThenClickOnApply()
        {
            serviceRequestAutomationPage.Apply();

        }

        [Then(@"Verify the output filtered result (.*)")]
        public void ThenVerifyTheOutputFilteredResult(string input)
        {
            serviceRequestAutomationPage.GetRFromOriginColAndVerifyTheResult(input);
        }

        [Then(@"Click on Expand All")]
        public void ThenClickOnExpandAll()
        {
            serviceRequestAutomationPage.ExpandAll();
        }

        [Then(@"Verify the Output filtered result for (.*) input")]
        public void ThenVerifyTheOutputFilteredResultForInput(string input)
        {
            serviceRequestAutomationPage.GetRFromVendorColAndVerifyTheResult(input);
        }



        [Then(@"Clear the From and To date")]
        public void ThenClearTheFromAndToDate()
        {
            serviceRequestAutomationPage.ClearDate();
        }

        [Then(@"Click on Vendor dropdown")]
        public void ThenClickOnVendorDropdown()
        {
            serviceRequestAutomationPage.ClickOnVendorDropDown();
        }
        [Then(@"Provid (.*) input in search field of Vendor")]
        public void ThenProvidInputInSearchFieldOfVendor(string input)
        {
            WaitHelper.cWaitForLoader(driver, 20);
            serviceRequestAutomationPage.InputToVendorFilter(input);
        }

        [Then(@"Click on Driver dropdown")]
        public void ThenClickOnDriverDropdown()
        {
            serviceRequestAutomationPage.ClickOnDriverDropDown();
        }

        [Then(@"Provid (.*) input in search field of Driver")]
        public void ThenProvidInputInSearchFieldOfDriver(string input)
        {
            WaitHelper.cWaitForLoader(driver, 20);
            serviceRequestAutomationPage.InputToDriverFilter(input);
        }

        [Then(@"Verify the Output filtered result for Driver (.*)")]
        public void ThenVerifyTheOutputFilteredResultForDriver(string input)
        {
            serviceRequestAutomationPage.GetRFromDriverColAndVerifyTheResult(input);
        }

        [Then(@"Click on Tissue ID dropdown")]
        public void ThenClickOnTissueIDDropdown()
        {
            serviceRequestAutomationPage.ClickOnTissueIDropdown();
        }

        [Then(@"Provid (.*) input in search field of Tissue ID")]
        public void ThenProvidInputInSearchFieldOfTissueID(string input)
        {
            serviceRequestAutomationPage.InputToTissueIDFilter(input);
        }

        [Then(@"Verify the Output filtered result for Tissue ID (.*)")]
        public void ThenVerifyTheOutputFilteredResultForTissueID(string input)
        {
            serviceRequestAutomationPage.GetRFromTissueIDColAndVerifyTheResult(input);
        }

        [Then(@"Click on Assigned Coordinator dropdown")]
        public void ThenClickOnAssignedCoordinatorDropdown()
        {
            serviceRequestAutomationPage.ClickOnAssignedCoordinatorDropdown();
        }

        [Then(@"Provid (.*) input in search field of Assigned Coordinator")]
        public void ThenProvidInputInSearchFieldOfAssignedCoordinator(string input)
        {
            serviceRequestAutomationPage.InputToAssignedCoordinatorFilter(input);
        }

        [Then(@"Verify the Output filtered result for Assigned Coordinator (.*)")]
        public void ThenVerifyTheOutputFilteredResultForAssignedCoordinator(string input)
        {
            serviceRequestAutomationPage.GetRFromAssignedCoordinatorColAndVerifyTheResult(input);
        }

        [Then(@"Verify the Output filtered result for Created By (.*)")]
        public void ThenVerifyTheOutputFilteredResultForCreatedBy(string input)
        {
            serviceRequestAutomationPage.GetRFromCreatedByColAndVerifyTheResult(input);
        }

        [Then(@"Provid (.*) input in search field of Created By")]
        public void ThenProvidInputInSearchFieldOfCreatedBy(string input)
        {
            serviceRequestAutomationPage.InputToCreatedByFilter(input);
        }


        [Then(@"click on Download SR Report and Verify the success")]
        public void ThenClickOnDownloadSRReportAndVerifyTheSuccess()
        {
            serviceRequestAutomationPage.ClickOnDownloadSRReport();
        }

        [Then(@"Click on Save member preference settings Option")]
        public void ThenClickOnSaveMemberPreferenceSettingsOption()
        {
            serviceRequestAutomationPage.ClickOnSaveMemberPreferenceSettingOption();
        }

        [Then(@"Select the Status option from dropdown and Save")]
        public void ThenSelectTheStatusOptionFromDropdownAndSave()
        {
            serviceRequestAutomationPage.SelectTheStatusOptionFromDropdownAndSave();
        }

        [Then(@"Verify the result according to provided input in setting")]
        public void ThenVerifyTheResultAccordingToProvidedInputInSetting()
        {
            serviceRequestAutomationPage.VerifyTheResult();
        }

        [Then(@"Reset Save member preference settings Option")]
        public void ThenResetSaveMemberPreferenceSettingsOption()
        {
            serviceRequestAutomationPage.ResetSaveMemberPreferenceSettingsOption();
        }
        [Then(@"Click on Create Service Request button")]
        public void ThenClickOnCreateServiceRequestButton()
        {
            serviceRequestAutomationPage.ClickOnCreateServiceRequestButton();
        }

        [Then(@"Verify Create Service Request Page")]
        public void ThenVerifyCreateServiceRequestPage()
        {
            serviceRequestAutomationPage.VerifyCreateServiceRequestPage();
        }

        [Then(@"Click on Show Notifications button")]
        public void ThenClickOnShowNotificationsButton()
        {
            serviceRequestAutomationPage.ClickOnShowNotificationsButton();
        }

        [Then(@"Verify that Notifications Dashboard should open")]
        public void ThenVerifyThatNotificationsDashboardShouldOpen()
        {
            serviceRequestAutomationPage.VerifyNotificationsDashboard();
        }

        [Then(@"Click on Show Messages button")]
        public void ThenClickOnShowMessagesButton()
        {
            serviceRequestAutomationPage.ClickOnShowMessagesButton();
        }

        [Then(@"Verify that Messages Page should open")]
        public void ThenVerifyMessagesPageShouldOpen()
        {
            serviceRequestAutomationPage.VerifyMessagesPage();
        }

        [Then(@"Click on Create Itinerary Button")]
        public void ThenClickOnCreateItineraryButton()
        {
            serviceRequestAutomationPage.ClickOnCreateItineraryButton();
        }

        [Then(@"Verify that Crate Itinerary Page should open")]
        public void ThenVerifyThatCrateItineraryPageShouldOpen()
        {
            serviceRequestAutomationPage.VerifyCrateItineraryPage();
        }

        [Then(@"Click on View Call Flow Details Button and Verify the page")]
        public void ThenClickOnViewCallFlowDetailsButtonAndVerifyThePage()
        {
            serviceRequestAutomationPage.ClickOnViewCallFlowDetailsButton();
            serviceRequestAutomationPage.VerifyTheCallFlowDetailsPage();
        }

        [Then(@"Click on View Checklist Details Button and Verify the page")]
        public void ThenClickOnViewChecklistDetailsButtonAndVerifyThePage()
        {
            serviceRequestAutomationPage.ClickOnViewChecklistDetailsButton();
            serviceRequestAutomationPage.VerifyTheChecklistDetailsPage();
        }

        [Then(@"Click on Assign Coordinator Button and Verify the page")]
        public void ThenClickOnAssignCoordinatorButtonAndVerifyThePage()
        {
            serviceRequestAutomationPage.ClickOnAssignCoordinatorButton();
            serviceRequestAutomationPage.VerifyTheAssignCoordinatorPage();
        }
        [Then(@"Select (.*) from Coordinator List and Assign")]
        public void ThenSelectFromCoordinatorListAndAssign(string input)
        {
            serviceRequestAutomationPage.InputFromCoordinatorList(input);
        }

        [Then(@"Verify the success message for Assign Coordinator flow")]
        public void ThenVerifyTheSuccessMessageForAssignCoordinatorFlow()
        {
            serviceRequestAutomationPage.VerifyTheSuccessMessageForAssignCoordinatorFlow();
        }


        [Then(@"Click on Edit Service Request Button and Verify the page")]
        public void ThenClickOnEditServiceRequestButtonAndVerifyThePage()
        {
            serviceRequestAutomationPage.ClickOnEditServiceRequestButton();
            serviceRequestAutomationPage.VerifyTheEditServiceRequestPage();
        }


        [Then(@"Click on Add Notes Button")]
        public void ThenClickOnAddNotesButton()
        {
            serviceRequestAutomationPage.ClickOnAddNotesButton();
        }

        [Then(@"Verify that Add Notes Page should open")]
        public void ThenVerifyThatAddNotesPageShouldOpen()
        {
            serviceRequestAutomationPage.VerifyAddNotesPage();
        }
        [Then(@"Click on plus Notes")]
        public void ThenClickOnPlusNotes()
        {
            serviceRequestAutomationPage.ClickOnPlusNotes();
        }

        [Then(@"Give input for Note Category and Message")]
        public void ThenGiveInputForNoteCategoryAndMessage()
        {
            serviceRequestAutomationPage.GiveInputForNoteCategoryAndMessage();
        }

        [Then(@"Click on Save Changes And verify the result")]
        public void ThenClickOnSaveChangesAndVerifyTheResult()
        {
            serviceRequestAutomationPage.ClickOnSaveChangesAndVerifyTheResult();
        }

        [Then(@"Click on Add Priority And verify the result")]
        public void ThenClickOnAddPriorityAndVerifyTheResult()
        {
            serviceRequestAutomationPage.ClickOnAddPriorityAndVerifyTheResult();
        }


        [Then(@"Click on Delete Action for the same and verify te result")]
        public void ThenClickOnDeleteActionForTheSameAndVerifyTeResult()
        {
            serviceRequestAutomationPage.ClickOnDeleteActionForTheSameAndVerifyTeResult();
        }



        [Then(@"Fill the Customer Info card")]
        public void ThenFillTheCustomerInfoCard()
        {
            serviceRequestAutomationPage.FillTheCustomerInfoCard();
        }


        [Then(@"Fill the Service Info card for Equipment service request")]
        public void ThenFillTheServiceInfoCardForEquipmentServiceRequest()
        {
            serviceRequestAutomationPage.FillEquipmentServiceRequest();
        }


        [Then(@"Fill the Trip Info card")]
        public void ThenFillTheTripInfoCard()
        {
            serviceRequestAutomationPage.FillTheTripInfoCard();
        }

        [Then(@"click on Save and verify the sucess message")]
        public void ThenClickOnSaveAndVerifyTheSucessMessage()
        {
            throw new PendingStepException();
        }



    }
}
