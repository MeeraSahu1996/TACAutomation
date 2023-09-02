using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using FinanceModule.Hooks;
using OpenQA.Selenium;
using TrinityAirMedical.Pages;

namespace TrinityAirMedical.StepDefinitions
{
    [Binding]
    public sealed class CreateServiceRequestStepDefinitions
    {
        private IWebDriver driver;
        CreateServiceRequestPage createServiceRequestPage;

        public CreateServiceRequestStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
        }
        [Given(@"launch the application")]
        public void GivenLaunchTheApplication()
        {
            //FirstBeforeScenario
            //throw new PendingStepException();
            //Hooks._feature.Log();

        }

        [When(@"I choose to Click on Service Request")]
        public void IChooseToClickOnServiceRequest()
        {
            //Hooks._feature.Log(Status.Info, "Entering email: TEST");
            createServiceRequestPage = new CreateServiceRequestPage(driver);
            createServiceRequestPage.clickServiceRequest();
        }
        
        [Then(@"I choose to verify Service Request Page should be displayed")]
        public void IChooseToVerifyServiceRequestPageShouldBeDisplayed()
        {
            createServiceRequestPage.verifyServiceRequestPage();
        }
        [When(@"I choose to Click on Service Request button")]
        public void IChooseToClickOnServiceRequestButton()
        {
            createServiceRequestPage.createServiceRequestButton();
        }
        [When(@"I choose to accept the Alert if any")]
        public void WhenIChooseToAcceptTheAlertIfAny()
        {
            createServiceRequestPage.AcceptAlert();
        }

        [When(@"I choose to click on copy service request")]
        public void IChooseToClickOnCopyServiceRequest()
        {
            createServiceRequestPage.createServiceRequest();
        }
        [Then(@"I choose to verify Create Service Request Page should be displayed")]
        public void IChooseToVerifyCreateServiceRequestPageShouldBeDisplayed()
        {
            createServiceRequestPage.verifyCreateServiceRequestButton();
        }
        [When(@"I choose to select customer details (.*)")]
        public void IChooseToSelectCustomerDetails(String customer)
        {
            createServiceRequestPage.selectCustomerDetails(customer);
        }
        [When(@"I choose to select jobtype (.*)")]
        public void IChooseToSelectJobtype(String job)
        {
            createServiceRequestPage.jobType(job);
        }
        [When(@"I choose to select contact details (.*)")]
        public void IChooseToSelectContactDetails(String contact)
        {
            createServiceRequestPage.selectContactDetails(contact);
        }
        [Then(@"I choose to verify phone number populated automatically")]
        public void IChooseToVerifyPhoneNumberPopulatedAutomatically()
        {
            createServiceRequestPage.phonePopulated();
        }
        [When(@"I choose to click on Add Contact button")]
        public void IChooseToClickOnAddContactButton()
        {
            createServiceRequestPage.clickAddContactButton();
        }
        [When(@"I choose to select team type (.*)")]
        public void WhenIChooseToSelectTeamType(String team)
        {
            createServiceRequestPage.selectTeam(team);
        }
        [When(@"I choose to select additional equipment (.*)")]
        public void WhenIChooseToSelectAdditionalEquipment(String addequipment)
        {
            createServiceRequestPage.additionalEquipments(addequipment);
        }
        [When(@"I choose to select additional types (.*)")]
        public void WhenIChooseToSelectAdditionalTypes(String addequipmenttype)
        {
            createServiceRequestPage.addEquipmentsTypes(addequipmenttype);
        }
        [Then(@"I choose to verify Add Contact popup")]
        public void IChooseToVerifyAddContactPopup()
        {
            createServiceRequestPage.verifyAddContactPopup();
        }
        [When(@"I choose to selectOrigin and destination")]
        public void IChooseToSelectOriginAndDestination()
        {
            createServiceRequestPage.selectOriginAndDest();
        }
        [When(@"I choose to save that transaction")]
        public void WhenIChooseToSaveThatTransaction()
        {
            createServiceRequestPage.savethattransaction();
        }

        [When(@"I choose to save the transaction")]
        public void IChooseToSaveTheTransaction()
        {
            createServiceRequestPage.savetransaction();
        }
        [Then(@"I choose to verify the transaction for add leg")]
        public void ThenIChooseToVerifyTheTransactionForAddLeg()
        {
            //createServiceRequestPage.VerifyTheTransactionForAddLeg();
        }

        [When(@"I choose to add notes (.*)")]
        public void IChooseToAddNotes(String notes)
        {
            createServiceRequestPage.writeNotes(notes);
        }
        [When(@"I choose to add file")]
        public void IChooseToAddFile()
        {
            createServiceRequestPage.uploadingFile();
        }
        [When(@"I choose to create service request using template (.*)")]
        public void IChooseToCreateServiceRequestUsingTemplate(String template)
        {
            createServiceRequestPage.selectTemplates(template);
        }

        
        [Then(@"I choose to verify the transaction")]
        public void IChooseToVerifyTheTransaction()
        {
            createServiceRequestPage.verifySuccessRequest();
        }

        [Then(@"I choose to verify warning popup")]
        public void IChooseToVerifyWarningPopup()
        {
            createServiceRequestPage.verifyWarning();
        }
        
        [Then(@"I choose to verify warning popup of same address")]
        public void IChooseToVerifyWarningPopupOfSameAddress()
        {
            createServiceRequestPage.verifyWarningOfSameAddress();
        }
        [Then(@"I choose to verify warning popup for same address")]
        public void ThenIChooseToVerifyWarningPopupForSameAddress()
        {
            createServiceRequestPage.verifyWarningPopUpOfSameAddress();
        }

        [When(@"I choose to enter firstName (.*)")]
        public void IChooseToEnterfirstName(String firstName)
        {
            createServiceRequestPage.firstName(firstName);
        }
        [When(@"I choose to enter lastName (.*)")]
        public void IChooseToEnterLastName(String lastName)
        {
            createServiceRequestPage.lastName(lastName);
        }
        [When(@"I choose to enter phoneNumber (.*)")]
        public void IChooseToEnterPhoneNumber(String phoneNumber)
        {
            createServiceRequestPage.phoneNumber(phoneNumber);
        }

        [When(@"I choose to enter inputs as a New member")]
        public void IChooseToEnterInputsAsANewMember()
        {
            createServiceRequestPage.addNewMember();
        }
        
        [Then(@"I choose to verify new contact added successfully")]
        public void IChooseToVerifyNewContactAddedSuccessfully()
        {
            createServiceRequestPage.verifyContactAdded();
        }
        
        [When(@"I choose to select from existing contact")]
        public void IChooseToSelectFromExistingContact()
        {
            createServiceRequestPage.selectExistingMember();
        }
        
        [When(@"I choose to select service type (.*)")]
        public void IChooseToSelectServiceType(String selectService)
        {
            createServiceRequestPage.selectServiceType(selectService);
        }
        
        [When(@"I choose to select equipment type (.*)")]
        public void IChooseToSelectEquipmentType(String selectEquipment)
        {
            createServiceRequestPage.selectEquipmentType(selectEquipment);
        }
        
        [When(@"I choose to select personnel service (.*)")]
        public void IChooseToSelectPersonnelService(String personnelService)
        {
            createServiceRequestPage.selectPersonnelService(personnelService);
        }
        
        [When(@"I choose to select next flight (.*)")]
        public void IChooseToSelectNextFlight(String nextFlight)
        {
            createServiceRequestPage.selectNextFlightOut(nextFlight);
        }
        [When(@"I choose to select organ type (.*)")]
        public void IChooseToSelectOrganType(String organType)
        {
            createServiceRequestPage.selectOrganType(organType);
        }
        [When(@"I choose to select ortime and sirens (.*)")]
        public void IChooseToSelectOrtimeAndSirens(String sirens)
        {
            createServiceRequestPage.selectSirensAndOrtime(sirens);
        }
        
        [When(@"I choose to select pickup type (.*)")]
        public void IChooseToSelectPickupType(String type)
        {
            createServiceRequestPage.pickUpType(type);
        }
        [When(@"I choose to select pickup time")]
        public void IChooseToSelectPickupTime()
        {
            createServiceRequestPage.pickUpTime();
        }
        [When(@"I choose to select priority type (.*)")]
        public void IChooseToSelectPriorityType(String priority)
        {
            Thread.Sleep(3000);
            createServiceRequestPage.priorityType(priority);
        }
        
        [When(@"I choose to enter tissueid (.*)")]
        public void IChooseToEnterTissueId(String tissue)
        {
            createServiceRequestPage.tissueID(tissue);
        }
        [When(@"I choose to enter matchid (.*)")]
        public void IChooseToEnterMatchId(String match)
        {
            createServiceRequestPage.matchID(match);
        }
        [When(@"I choose to enter medigo (.*)")]
        public void IChooseToEnterMedigo(String medigo)
        {
            createServiceRequestPage.medigo(medigo);
        }
        [When(@"I choose to enter jobid (.*)")]
        public void IChooseToEnterJobid(String jobid)
        {
            createServiceRequestPage.jobID(jobid);
        }
        [When(@"I choose to enter trackingid (.*)")]
        public void IChooseToEnterTrackingid(String trackingid)
        {
            createServiceRequestPage.trackingID(trackingid);
        }
        [When(@"I choose to enter unosid (.*)")]
        public void IChooseToEnterUnosId(String unos)
        {
            createServiceRequestPage.unosID(unos);
        }
        [When(@"I choose to select specimen type (.*)")]
        public void IChooseToSelectSpecimenType(String specimenType)
        {
            createServiceRequestPage.specimenType(specimenType);
        }
        [When(@"I choose to select drop location (.*)")]
        public void IChooseToSelectDropLocation(String droplocation)
        {
            createServiceRequestPage.dropOffLocation(droplocation);
        }
        [When(@"I choose to select drop category (.*)")]
        public void IChooseToSelectDropCategory(String dropcategroy)
        {
            createServiceRequestPage.dropOffCategory(dropcategroy);
        }
        [When(@"I choose to select trip origin transport mode (.*)")]
        public void WhenIChooseToSelectTripOriginTransportMode(String mode)
        {
            createServiceRequestPage.selectModeTransport(mode);
        }

        [When(@"I choose to create location click and verify")]
        public void WhenIChooseToCreateLocationClickAndVerify()
        {
            createServiceRequestPage.createLocationClick();
        }

        [When(@"I choose to select location name (.*)")]
        public void WhenIChooseToSelectLocationName(String locationName)
        {
            createServiceRequestPage.location(locationName);
        }

        [When(@"I choose to select address type (.*)")]
        public void WhenIChooseToSelectAddressType(String addressType)
        {
            createServiceRequestPage.selectAddressType(addressType);
        }

        [When(@"I choose to select address mode (.*)")]
        public void WhenIChooseToSelectAddressMode(String addressmode)
        {
            createServiceRequestPage.AddressMode(addressmode);
        }

        [When(@"I choose to select airport code (.*)")]
        public void WhenIChooseToSelectAirportCode(String code)
        {
            createServiceRequestPage.selectAirpportCode(code);
        }
        [When(@"I choose to select tripinfo airport code (.*)")]
        public void WhenIChooseToSelectTripInfoAirportCode(String code)
        {
            createServiceRequestPage.airportcode(code);
        }

        [When(@"I choose to enter street address (.*)")]
        public void WhenIChooseToEnterStreetAddress(String street)
        {
            createServiceRequestPage.streetAddress(street);
        }
        [When(@"I choose to enter same street address (.*)")]
        public void WhenIChooseToEnterSameStreetAddress(String street)
        {
            createServiceRequestPage.sameStreetAddress(street);
        }
        [When(@"I choose to enter destination street address (.*)")]
        public void WhenIChooseToEnterDestinationStreetAddress(String street)
        {
            createServiceRequestPage.destinationStreetAddress(street);
        }

        [When(@"I choose to enter zipcode (.*)")]
        public void WhenIChooseToEnterZipcode(String zip)
        {
            createServiceRequestPage.zipCode(zip);
        }

        [When(@"I choose to select state (.*)")]
        public void WhenIChooseToSelectState(String state)
        {
            createServiceRequestPage.state(state);
        }

        [When(@"I choose to select city (.*)")]
        public void WhenIChooseToSelectCity(String city)
        {
            createServiceRequestPage.city(city);
        }

        [When(@"I choose to save the location")]
        public void WhenIChooseToSaveTheLocation()
        {
            createServiceRequestPage.saveChangeslocation();
        }

        [When(@"I choose to select trip destinatio transport mode (.*)")]
        public void WhenIChooseToSelectTripDestinatioTransportMode(String mode)
        {
            createServiceRequestPage.selectModeTransportDest(mode);
        }

        [When(@"I choose to create destination location click and verify")]
        public void WhenIChooseToCreateDestinationLocationClickAndVerify()
        {
            createServiceRequestPage.createDestinationLocation();
        }

        [When(@"I choose to select category (.*)")]
        public void WhenIChooseToSelectCategory(String category)
        {
            createServiceRequestPage.selectCategory(category);
        }

        [When(@"I choose to enter instruction (.*)")]
        public void WhenIChooseToEnterInstruction(String text)
        {
            createServiceRequestPage.enterInstruction(text);
        }

        [When(@"T choose to enter template name (.*)")]
        public void WhenTChooseToEnterTemplateName(String templateName)
        {
            createServiceRequestPage.saveTemplates(templateName);
        }
        [When(@"I choose to save the transaction with Save Temp Option")]
        public void WhenIChooseToSaveTheTransactionWithSaveTempOption()
        {
            createServiceRequestPage.savetransaction();
            createServiceRequestPage.savetransactionWithTempOpt();

        }

        [When(@"I choose to select destinations mode (.*)")]
        public void WhenTChooseToSelectDestinationsMode(String destinationmode)
        {
            createServiceRequestPage.destinationsMode(destinationmode);
        }
        [When(@"I choose to Enter Origin loction (.*)")]
        public void WhenIChooseToEnterOriginLoction(String Origin)
        {
            createServiceRequestPage.EnterOriginLoction(Origin);
        }

        [When(@"I choose to Enter Desti loction (.*)")]
        public void WhenIChooseToEnterDestiLoction(String Desti)
        {
            createServiceRequestPage.EnterDestiLoction(Desti);
        }
        [Then(@"I choose to Select Coordinator (.*)")]
        public void ThenIChooseToSelectCoordinator(string ServiceAccount)
        {
            Thread.Sleep(20000);
            createServiceRequestPage.SelectCoordinator(ServiceAccount);
        }
        [Then(@"I choose to verify the success message for Assign Coordinator")]
        public void ThenIChooseToVerifyTheSuccessMessageForAssignCoordinator()
        {
            createServiceRequestPage.VerifyTheSuccessMessageForAssignCoordinator();
            
        }
        [Then(@"I choose to Click on Add leg")]
        public void ThenIChooseToClickOnAddLeg()
        {
            createServiceRequestPage.ClickOnAddLeg();
        }

        [Then(@"I choose to Select Transport Type (.*)")]
        public void ThenIChooseToSelectTransportType(string TransportType)
        {
            createServiceRequestPage.SelectTransportType(TransportType);
        }

        [Then(@"I choose to Select Direction (.*)")]
        public void ThenIChooseToSelectDirection(string Direction)
        {
            createServiceRequestPage.SelectDirection(Direction);
        }

        [Then(@"I choose to select Origin Address type (.*)")]
        public void ThenIChooseToSelectOriginAddressType(string OriginAddType)
        {
            createServiceRequestPage.SelectOriginAddressType(OriginAddType);
        }

        [Then(@"I choose to select Destination Address type(.*)")]
        public void ThenIChooseToSelectDestinationAddressType(string DestinationAddType)
        {
            createServiceRequestPage.SelectDestinationAddressType(DestinationAddType);
        }

        [Then(@"I choose to Enter Desti location (.*)")]
        public void ThenIChooseToEnterDestiLocation(string Location)
        {
            createServiceRequestPage.DestiLocation(Location);
        }

        [Then(@"I choose to Click on Add button")]
        public void ThenIChooseToClickOnAddButton()
        {
            createServiceRequestPage.ClickOnAddButton();
            
        }
        [Then(@"I choose to select the legs and Assign to Internal Driver")]
        public void ThenIChooseToSelectTheLegsAndAssignToInternalDriver()
        {
            createServiceRequestPage.SelectTheLegsAndAssignToInternalDriver();
        }

        [Then(@"I choose to select the legs and Assign to External Driver Or Vendor")]
        public void ThenIChooseToSelectTheLegsAndAssignToExternalDriverOrVendor()
        {
            createServiceRequestPage.SelectTheLegsAndAssignToExternalDriverOrVendor();
        }
        [Then(@"I choose to select the legs and Send Assignment Request")]
        public void ThenIChooseToSelectTheLegsAndSendAssignmentRequest()
        {
            createServiceRequestPage.SelectTheLegsAndSendAssignmentRequest();
        }

        [Then(@"I choose to verify the success message for Leg Assignment")]
        public void ThenIChooseToVerifyTheSuccessMessageForLegAssignment()
        {
            //createServiceRequestPage.SuccessMessageForLegAssignment();
        }
        [Then(@"I choose to Save the service request number")]
        public void ThenIChooseToSaveTheServiceRequestNumber()
        {
            createServiceRequestPage.SaveTheServiceRequestNumber();
        }
        [Then(@"I choose to complete the status of the all legs for create SR")]
        public void ThenIChooseToCompleteTheStatusOfTheAllLegsForCreateSR()
        {
            createServiceRequestPage.CompleteTheStatusOfTheAllLegs();
        }
        [Then(@"I choose to verify the status for the SR")]
        public void ThenIChooseToVerifyTheStatusForTheSR()
        {
            createServiceRequestPage.StatusForTheSR();
        }



    }
}
