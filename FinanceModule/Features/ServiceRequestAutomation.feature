Feature: ServiceRequest

A short summary of the feature

@ServiceRequest
Scenario Outline: To verify that Service Request dashboard should open after clicking on Side Navigation bar.
	Given launch the application 
	When enter the email <email>
	And enter the password <password>
	And click on submit button
	And enter email <email>
	And enter password <password>
	And verify Home page
	And Click on Service Request option
	Then Service Request Page should open.
	 
Examples:
	| email                                        | password   |
	| TACExAdministratorTest@trinityairmedical.com | YQAQ7&*fy! |


Scenario Outline: To Verify the Options in Service Type filter from Service Request Filters.
	Given launch the application
	When enter the email <email>
	And enter the password <password>
	And click on submit button
	And enter email <email>
	And enter password <password>
	And verify Home page
	And Click on Service Request option
	Then Service Request Page should open.
	And Click on Service Type dropdown
	Then Verify the Options present in Service Type filter
	 
Examples:
	| email                                        | password   |
	| TACExAdministratorTest@trinityairmedical.com | YQAQ7&*fy! |

	
Scenario Outline: To Verify the Service type filter by selecting different service Request Filters
	Given launch the application
	When enter the email <email>
	And enter the password <password>
	And click on submit button
	And enter email <email>
	And enter password <password>
	And verify Home page
	And Click on Service Request option
	Then Service Request Page should open.
	And Click on Service Type dropdown
	Then Verify that on Selecting <service> types Service Request from Service Type Filter it should filter only Selected one
	 
Examples:
	| email                                        | password   | service         |
	| TACExAdministratorTest@trinityairmedical.com | YQAQ7&*fy! | Equipment       |
	| TACExAdministratorTest@trinityairmedical.com | YQAQ7&*fy! | Internal        |
	| TACExAdministratorTest@trinityairmedical.com | YQAQ7&*fy! | Next Flight Out |
	| TACExAdministratorTest@trinityairmedical.com | YQAQ7&*fy! | Organ           |
	| TACExAdministratorTest@trinityairmedical.com | YQAQ7&*fy! | Specimen        |
	| TACExAdministratorTest@trinityairmedical.com | YQAQ7&*fy! | Team            |


	@retry(3)
Scenario Outline: To Verify the Status filter by selecting different status input available in filter
	Given launch the application
	When enter the email <email>
	And enter the password <password>
	And click on submit button
	And enter email <email>
	And enter password <password>
	And verify Home page
	And Click on Service Request option
	Then Service Request Page should open.
	And Click on status dropdown
	Then Verify that on Selecting different <status> options from status filter it should filter only the Selected one

Examples:
	| email                                        | password   | status      |
	| TACExAdministratorTest@trinityairmedical.com | YQAQ7&*fy! | Cancelled   |
	| TACExAdministratorTest@trinityairmedical.com | YQAQ7&*fy! | Completed   |
	| TACExAdministratorTest@trinityairmedical.com | YQAQ7&*fy! | Enroute     |
	| TACExAdministratorTest@trinityairmedical.com | YQAQ7&*fy! | Not Started |

@retry(3)
Scenario Outline: To Verify the Customer filter by selecting different Customer input available in filter and also monitoring the output for the same
	Given launch the application
	When enter the email <email>
	And enter the password <password>
	And click on submit button
	And enter email <email>
	And enter password <password>
	And verify Home page
	And Click on Service Request option
	Then Service Request Page should open.
	And Click on Customer dropdown
	And select for each Customer available in Dropdown And Verify the output filter result
Examples:
	| email                                        | password   |
	| TACExAdministratorTest@trinityairmedical.com | YQAQ7&*fy! |

@retry(3)
Scenario Outline: To verify the Trip ID filter enter the input in the search section and validate the filtered output
	Given launch the application
	When enter the email <email>
	And enter the password <password>
	And click on submit button
	And enter email <email>
	And enter password <password>
	And verify Home page
	And Click on Service Request option
	Then Service Request Page should open.
	And Click on Trip ID dropdown
	And Provid <TripID> input in search field of Dropdown And Verify the output filter result
Examples:
	| email                                        | password   | TripID   |
	| TACExAdministratorTest@trinityairmedical.com | YQAQ7&*fy! | 230705AC |
	| TACExAdministratorTest@trinityairmedical.com | YQAQ7&*fy! | 210322AN |

Scenario Outline: To verify UNOS ID filter enter the input in the search section and validate the filtered output
	Given launch the application
	When enter the email <email>
	And enter the password <password>
	And click on submit button
	And enter email <email>
	And enter password <password>
	And verify Home page
	And Click on Service Request option
	Then Service Request Page should open.
	And Click on UNOS ID dropdown
	And Provid <UNOSID> input in search field of UNOSID Dropdown And Verify the output filter result
Examples:
	| email                                        | password   | UNOSID  |
	| TACExAdministratorTest@trinityairmedical.com | YQAQ7&*fy! | 3242342 |
	| TACExAdministratorTest@trinityairmedical.com | YQAQ7&*fy! | UN10298 |

@retry(5)
Scenario Outline: To Verify the Origin filter by providing different input in search section of filter and validate the filtered output
	Given launch the application
	When enter the email <email>
	And enter the password <password>
	And click on submit button
	And enter email <email>
	And enter password <password>
	And verify Home page
	And Click on Service Request option
	Then Service Request Page should open.
	And Select the From and To date
	And Click on More Filters
	And Click on Origin dropdown
	And Provid <Origin> input in search field of Origin
	And click on Apply
	Then Verify the output filtered result <Origin>
Examples:
	| email                                        | password   | Origin       |
	| TACExAdministratorTest@trinityairmedical.com | YQAQ7&*fy! | Trinity Air Medical |

				
Scenario Outline: To Verify the Vendor filter by providing different input in search section of filter and validate the filtered output
	When enter the email <email>
	And enter the password <password>
	And click on submit button
	And enter email <email>
	And enter password <password>
	And verify Home page
	And Click on Service Request option
	Then Service Request Page should open.
	And Clear the From and To date
	And Click on More Filters
	And Click on Vendor dropdown
	And Provid <Vendor> input in search field of Vendor
	And click on Apply
	And Click on Expand All
	Then Verify the Output filtered result for <Vendor> input
Examples:
	| email                                        | password   | Vendor          |
	| TACExAdministratorTest@trinityairmedical.com | YQAQ7&*fy! | Test Vendor     |
	| TACExAdministratorTest@trinityairmedical.com | YQAQ7&*fy! | MedCenter Air   |
	| TACExAdministratorTest@trinityairmedical.com | YQAQ7&*fy! | iCare Ambulance |



Scenario Outline: To Verify the Driver filter by providing different input in search section of filter and validate the filtered output
	When enter the email <email>
	And enter the password <password>
	And click on submit button
	And enter email <email>
	And enter password <password>
	And verify Home page
	And Click on Service Request option
	Then Service Request Page should open.
	And Clear the From and To date
	And Click on More Filters
	And Click on Driver dropdown
	And Provid <input> input in search field of Driver
	And click on Apply
	And Click on Expand All
	Then Verify the Output filtered result for Driver <input>
Examples:
	| email                                        | password   | input                  |
	| TACExAdministratorTest@trinityairmedical.com | YQAQ7&*fy! |Joshua  Burleson|
	| TACExAdministratorTest@trinityairmedical.com | YQAQ7&*fy! |Tom  Shaffer|
	| TACExAdministratorTest@trinityairmedical.com | YQAQ7&*fy! |Kathy  Daly|

Scenario Outline: To Verify the Tissue ID filter by providing different input in search section of filter and validate the filtered output
	When enter the email <email>
	And enter the password <password>
	And click on submit button
	And enter email <email>
	And enter password <password>
	And verify Home page
	And Click on Service Request option
	Then Service Request Page should open.
	And Clear the From and To date
	And Click on More Filters
	And Click on Tissue ID dropdown
	And Provid <input> input in search field of Tissue ID
	And click on Apply
	Then Verify the Output filtered result for Tissue ID <input>
Examples:
	| email                                        | password   | input      |
	| TACExAdministratorTest@trinityairmedical.com | YQAQ7&*fy! | 090721-051 |
	| TACExAdministratorTest@trinityairmedical.com | YQAQ7&*fy! | 080721-005 |
	| TACExAdministratorTest@trinityairmedical.com | YQAQ7&*fy! | T100001    |


	@retry(3)
Scenario Outline: To Verify the Assigned Coordinator filter by providing different input in search section of filter and validate the filtered output
	When enter the email <email>
	And enter the password <password>
	And click on submit button
	And enter email <email>
	And enter password <password>
	And verify Home page
	And Click on Service Request option
	Then Service Request Page should open.
	And Clear the From and To date
	And Click on More Filters
	And Click on Assigned Coordinator dropdown
	And Provid <input> input in search field of Assigned Coordinator
	And click on Apply
	Then Verify the Output filtered result for Assigned Coordinator <input>
Examples:
	| email                                        | password   | input                        |
	| TACExAdministratorTest@trinityairmedical.com | YQAQ7&*fy! | Service Account  Coordinator |
	| TACExAdministratorTest@trinityairmedical.com | YQAQ7&*fy! | Marcio  Moreno               |
	| TACExAdministratorTest@trinityairmedical.com | YQAQ7&*fy! | Michael  branham             |


Scenario Outline: To Verify the Created By filter by providing different input in search section of filter and validate the filtered output
	When enter the email <email>
	And enter the password <password>
	And click on submit button
	And enter email <email>
	And enter password <password>
	And verify Home page
	And Click on Service Request option
	Then Service Request Page should open.
	And Clear the From and To date
	And Click on More Filters
	And Click on Created By dropdown
	And Provid <input> input in search field of Created By
	And click on Apply
	Then Verify the Output filtered result for Created By <input>
Examples:
	| email                                        | password   | input               |
	| TACExAdministratorTest@trinityairmedical.com | YQAQ7&*fy! | Alfredo  Fabrega    |
	| TACExAdministratorTest@trinityairmedical.com | YQAQ7&*fy! | Brian  Smith        |
	| TACExAdministratorTest@trinityairmedical.com | YQAQ7&*fy! | Trinity Air Medical |


Scenario Outline: To Verify the Download SR Report Button in Service Request Page
	When enter the email <email>
	And enter the password <password>
	And click on submit button
	And enter email <email>
	And enter password <password>
	And verify Home page
	And Click on Service Request option
	Then Service Request Page should open.
	And click on Download SR Report and Verify the success
Examples:
	| email                                        | password   |
	| TACExAdministratorTest@trinityairmedical.com | YQAQ7&*fy! |

Scenario Outline: To Verify the Save member preference settings in Service Request page
	When enter the email <email>
	And enter the password <password>
	And click on submit button
	And enter email <email>
	And enter password <password>
	And verify Home page
	And Click on Service Request option
	Then Service Request Page should open.
	And Click on Save member preference settings Option
	And Select the Status option from dropdown and Save
	Then Verify the result according to provided input in setting
	And Reset Save member preference settings Option

Examples:
	| email                                        | password   |
	| TACExAdministratorTest@trinityairmedical.com | YQAQ7&*fy! |

Scenario Outline: To Verify the Create Service Request Button in Service Request Page
	When enter the email <email>
	And enter the password <password>
	And click on submit button
	And enter email <email>
	And enter password <password>
	And verify Home page
	And Click on Service Request option
	Then Service Request Page should open.
	And Click on Create Service Request button
	Then Verify Create Service Request Page

Examples:
	| email                                        | password   |
	| TACExAdministratorTest@trinityairmedical.com | YQAQ7&*fy! |

Scenario Outline: To Verify the Show Notifications Button in Service Request Page 
	When enter the email <email>
	And enter the password <password>
	And click on submit button
	And enter email <email>
	And enter password <password>
	And verify Home page
	And Click on Service Request option
	Then Service Request Page should open.
	And Click on Show Notifications button
	Then Verify that Notifications Dashboard should open

Examples:
	| email                                        | password   |
	| TACExAdministratorTest@trinityairmedical.com | YQAQ7&*fy! |

Scenario Outline:To Verify the Show Messages Button in Service Request Page 
	When enter the email <email>
	And enter the password <password>
	And click on submit button
	And enter email <email>
	And enter password <password>
	And verify Home page
	And Click on Service Request option
	Then Service Request Page should open.
	And Click on Show Messages button
	Then Verify that Messages Page should open

Examples:
	| email                                        | password   |
	| TACExAdministratorTest@trinityairmedical.com | YQAQ7&*fy! |

Scenario Outline:To Verify the Create Itinerary Button for a Service Request in Service Request Page 
	Given launch the application
	When enter the email <email>
	And enter the password <password>
	And click on submit button
	And enter email <email>
	And enter password <password>
	And verify Home page
	And Click on Service Request option
	Then Service Request Page should open.
	And Click on status dropdown
	Then Verify that on Selecting different <status> options from status filter it should filter only the Selected one
	And Click on Customer dropdown
	And select for Demo Customer available in Dropdown And Verify the output filter result
	And Click on Create Itinerary Button 
	Then Verify that Crate Itinerary Page should open

Examples:
	| email                                        | password   | status      |
	| TACExAdministratorTest@trinityairmedical.com | YQAQ7&*fy! | Enroute     |
	| TACExAdministratorTest@trinityairmedical.com | YQAQ7&*fy! | Not Started |

Scenario Outline:To Verify the View Call Flow Details button in Create Itinerary Page
	Given launch the application
	When enter the email <email>
	And enter the password <password>
	And click on submit button
	And enter email <email>
	And enter password <password>
	And verify Home page
	And Click on Service Request option
	Then Service Request Page should open.
	And Click on status dropdown
	Then Verify that on Selecting different <status> options from status filter it should filter only the Selected one
	And Click on Customer dropdown
	And select for Demo Customer available in Dropdown And Verify the output filter result
	And Click on Create Itinerary Button 
	Then Verify that Crate Itinerary Page should open
	Then Click on View Call Flow Details Button and Verify the page 

Examples:
	| email                                        | password   | status      |
	| TACExAdministratorTest@trinityairmedical.com | YQAQ7&*fy! | Enroute     |
	| TACExAdministratorTest@trinityairmedical.com | YQAQ7&*fy! | Not Started |



Scenario Outline: To Verify the View Checklist Details button in Create Itinerary Page
	Given launch the application
	When enter the email <email>
	And enter the password <password>
	And click on submit button
	And enter email <email>
	And enter password <password>
	And verify Home page
	And Click on Service Request option
	Then Service Request Page should open.
	And Click on status dropdown
	Then Verify that on Selecting different <status> options from status filter it should filter only the Selected one
	And Click on Customer dropdown
	And select for Demo Customer available in Dropdown And Verify the output filter result
	And Click on Create Itinerary Button 
	Then Verify that Crate Itinerary Page should open
	Then Click on View Checklist Details Button and Verify the page 

Examples:
	| email                                        | password   | status      |
	| TACExAdministratorTest@trinityairmedical.com | YQAQ7&*fy! | Enroute     |
	| TACExAdministratorTest@trinityairmedical.com | YQAQ7&*fy! | Not Started |


	
Scenario Outline:To Verify the Assign Coordinator button in Create Itinerary Page 
	Given launch the application
	When enter the email <email>
	And enter the password <password>
	And click on submit button
	And enter email <email>
	And enter password <password>
	And verify Home page
	And Click on Service Request option
	Then Service Request Page should open.
	And Click on status dropdown
	Then Verify that on Selecting different <status> options from status filter it should filter only the Selected one
	And Click on Customer dropdown
	And select for Demo Customer available in Dropdown And Verify the output filter result
	And Click on Create Itinerary Button 
	Then Verify that Crate Itinerary Page should open
	Then Click on Assign Coordinator Button and Verify the page 
	And Select <input> from Coordinator List and Assign
	Then Verify the success message for Assign Coordinator flow

Examples:
	| email                                        | password   | status      | input                        |
	| TACExAdministratorTest@trinityairmedical.com | YQAQ7&*fy! | Enroute     | Service Account  Coordinator|
	| TACExAdministratorTest@trinityairmedical.com | YQAQ7&*fy! | Not Started | Service Account  Coordinator |


	
Scenario Outline:To Verify the Edit Service Request button in Create Itinerary Page
	Given launch the application
	When enter the email <email>
	And enter the password <password>
	And click on submit button
	And enter email <email>
	And enter password <password>
	And verify Home page
	And Click on Service Request option
	Then Service Request Page should open.
	And Click on status dropdown
	Then Verify that on Selecting different <status> options from status filter it should filter only the Selected one
	And Click on Customer dropdown
	And select for Demo Customer available in Dropdown And Verify the output filter result
	And Click on Create Itinerary Button 
	Then Verify that Crate Itinerary Page should open
	Then Click on Edit Service Request Button and Verify the page 

Examples:
	| email                                        | password   | status      |
	| TACExAdministratorTest@trinityairmedical.com | YQAQ7&*fy! | Enroute     |
	| TACExAdministratorTest@trinityairmedical.com | YQAQ7&*fy! | Not Started |



Scenario Outline: To Verify Add Notes Button for a Service Request in Service Request Page 
	Given launch the application
	When enter the email <email>
	And enter the password <password>
	And click on submit button
	And enter email <email>
	And enter password <password>
	And verify Home page
	And Click on Service Request option
	Then Service Request Page should open.
	And Click on status dropdown
	Then Verify that on Selecting different <status> options from status filter it should filter only the Selected one
	And Click on Customer dropdown
	And select for Demo Customer available in Dropdown And Verify the output filter result
	And Click on Add Notes Button 
	Then Verify that Add Notes Page should open
	And Click on plus Notes
	And Give input for Note Category and Message
	Then Click on Save Changes And verify the result 
	Then Click on Add Priority And verify the result 
	Then Click on Delete Action for the same and verify te result



Examples:
	| email                                        | password   | status      |
	| TACExAdministratorTest@trinityairmedical.com | YQAQ7&*fy! | Completed   |
	| TACExAdministratorTest@trinityairmedical.com | YQAQ7&*fy! | Enroute     |
	| TACExAdministratorTest@trinityairmedical.com | YQAQ7&*fy! | Not Started |


Scenario Outline:To Verify The Options in More Button for a Service Request in Service Request Page 
	Given launch the application
	When enter the email <email>
	And enter the password <password>
	And click on submit button
	And enter email <email>
	And enter password <password>
	And verify Home page
	And Click on Service Request option
	Then Service Request Page should open.
	And Click on status dropdown
	Then Verify that on Selecting different <status> options from status filter it should filter only the Selected one
	And Click on Customer dropdown
	And select for Demo Customer available in Dropdown And Verify the output filter result
	And Click on more button 
	And Click on Add files button and Verify the Title of new window
	And Attach at file and verify the success message 
	And Click on more button 
	And Click on Trip Report button and Verify the Title of new window
	Then Click on Trip Report Cancle button 
	And Click on more button 
	And Click on Cancle Service Request accept the alert 
	And Verify the success message 
	And Click on more button 
	And click on Copy Service Request and Verify the Title of new window
	And Click on Back button 
	And Click on more button 
	And Click on Assign Coordinator and Verify the Title of new window
	And Give input Service Account Coordinator to Assign Coordinator request
	And Click on Assign Button and Verify the success message
	And Click on more button 
	And click on Edit Service Request and Verify the Title of new window
	And Click on Back button 

Examples:
	| email                                        | password   | status      |
	| TACExAdministratorTest@trinityairmedical.com | YQAQ7&*fy! | Not Started   |


Scenario Outline:To Verify View Call Flow Details Button for a Service Request in Service Request Page 
	Given launch the application
	When enter the email <email>
	And enter the password <password>
	And click on submit button
	And enter email <email>
	And enter password <password>
	And verify Home page
	And Click on Service Request option
	Then Service Request Page should open.
	And Click on status dropdown
	Then Verify that on Selecting different <status> options from status filter it should filter only the Selected one
	And Click on Customer dropdown
	And select for Demo Customer available in Dropdown And Verify the output filter result
	And Click on View Call Flow Details Button and Verify the title for the same
	

Examples:
	| email                                        | password   | status      |
	| TACExAdministratorTest@trinityairmedical.com | YQAQ7&*fy! | Not Started   |

Scenario Outline:To Verify View Check List Details Button for a Service Request in Service Request Page 
	Given launch the application
	When enter the email <email>
	And enter the password <password>
	And click on submit button
	And enter email <email>
	And enter password <password>
	And verify Home page
	And Click on Service Request option
	Then Service Request Page should open.
	And Click on status dropdown
	Then Verify that on Selecting different <status> options from status filter it should filter only the Selected one
	And Click on Customer dropdown
	And select for Demo Customer available in Dropdown And Verify the output filter result
	And Click on View Check List Details Button and Verify the title for the same
	

Examples:
	| email                                        | password   | status      |
	| TACExAdministratorTest@trinityairmedical.com | YQAQ7&*fy! | Not Started   |

Scenario Outline:To Verify Un-Cancel Service Request Button for a Service Request in Service Request Page 								
	Given launch the application
	When enter the email <email>
	And enter the password <password>
	And click on submit button
	And enter email <email>
	And enter password <password>
	And verify Home page
	And Click on Service Request option
	Then Service Request Page should open.
	And Click on status dropdown
	Then Verify that on Selecting different <status> options from status filter it should filter only the Selected one
	And Click on Customer dropdown
	And select for Demo Customer available in Dropdown And Verify the output filter result
	And Get the Trip id of the Cancelled Request and Click on Un-Cancel Button 
	Then Apply the filter for the Stored Trip id and check the status of same 

Examples:
	| email                                        | password   | status      |
	| TACExAdministratorTest@trinityairmedical.com | YQAQ7&*fy! | Cancelled   |



Scenario Outline:(defect)To Verify the functionlity of Search Box in service Request Page								
	Given launch the application
	When enter the email <email>
	And enter the password <password>
	And click on submit button
	And enter email <email>
	And enter password <password>
	And verify Home page
	And Click on Service Request option
	Then Service Request Page should open.
	And Click on status dropdown
	Then Verify that on Selecting different <status> options from status filter it should filter only the Selected one
	And Click on Customer dropdown
	And select for Demo Customer available in Dropdown And Verify the output filter result
	And Get the Trip id of the Cancelled Request and Click on Un-Cancel Button 
	Then Give input to the search field and verify the result

Examples:
	| email                                        | password   | status      |
	| TACExAdministratorTest@trinityairmedical.com | YQAQ7&*fy! | Cancelled   |



#	Scenario Outline: The Create Service Request in Service Request Page
#	When enter the email <email>
#	And enter the password <password>
#	And click on submit button
#	And enter email <email>
#	And enter password <password>
#	And verify Home page
#	And Click on Service Request option
#	Then Service Request Page should open.
#	And Click on Create Service Request button
#	Then Verify Create Service Request Page
#	And Fill the Customer Info card
#	And Fill the Service Info card for <service> service request
#	And Fill the Trip Info card
#	And click on Save and verify the sucess message 
#
#Examples:
#	| email                                        | password   | service         |
#	| TACExAdministratorTest@trinityairmedical.com | YQAQ7&*fy! | Equipment       |
#	| TACExAdministratorTest@trinityairmedical.com | YQAQ7&*fy! | Internal        |
#	| TACExAdministratorTest@trinityairmedical.com | YQAQ7&*fy! | Next Flight Out |
#	| TACExAdministratorTest@trinityairmedical.com | YQAQ7&*fy! | Organ           |
#	| TACExAdministratorTest@trinityairmedical.com | YQAQ7&*fy! | Specimen        |
#	| TACExAdministratorTest@trinityairmedical.com | YQAQ7&*fy! | Team            |