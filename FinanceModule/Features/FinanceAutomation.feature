Feature: Finance Module feature

Login to the trinity medical solutions application and do tests

//@financeModule


Scenario Outline: Create service request flow for Finance Module
	Given launch the application
	When I choose to enter the email <email>
	And I choose to enter the password <password>
	And I choose to click on submit button
	And I choose to enter email <email>
	And I choose to enter password <password>
	And I choose to verify home page
	And I choose to Click on Service Request option
	And Service Request Page should open.	
	And I choose to Click on Create Service Request button 
	And I choose to Verify Create Service Request Page should open
	And I choose to Fill the Customer Info Section
	And Fill the Service Info Section 
	And Fill the Trip Info section 
	And Click on Save 
	Then Assign Coordinator
	And Check for Success of Assign Coordinator
	And Get the Trip ID No
	And Add The leg info for Outbound
	And Add The leg info for Inbound
	And Assign the legs to internal Driver
	And Go To Service Request page
	And Fill the Trip id in Trip ID Filter for input SRq no
	And Apply the filter

	Examples: 
	| email											| password   |
	| TACExAdministratorTest@trinityairmedical.com  | YQAQ7&*fy! |


Scenario Outline: login to the trinity medical solutions application
	Given launch the application
	When I choose to enter the email <email>
	And I choose to enter the password <password>
	And I choose to click on submit button
	And I choose to enter email <email>
	And I choose to enter password <password>
	Then I choose to verify the login page
	Examples: 
	| email                                      | password   |
	| TACAdministratorTest@trinityairmedical.com | xoAL@pf9tM |
	
Scenario Outline: login to the trinity medical solutions application with wrong creds
	Given launch the application
	When I choose to enter the email <email>
	And I choose to enter the password <password>
	And I choose to click on submit button
	Then I choose to verify the error login
	Examples: 
	| email                                   | password|
	| TACAdministratorTest@trinitymedical.com | xoAL@pf |

Scenario Outline: login to the trinity medical solutions application and launch manage customer tab
	Given launch the application
	When I choose to enter the email <email>
	And I choose to enter the password <password>
	And I choose to click on submit button
	And I choose to enter email <email>
	And I choose to enter password <password>
	Then I choose to verify the login page
	And I choose to click on manage customer
	Then I choose to verify customer page
	Examples: 
	| email                                      | password   |
	| TACAdministratorTest@trinityairmedical.com | xoAL@pf9tM |

Scenario Outline: login and launch manage customer tab and verify total number of transactions present on webpage
	Given launch the application
	When I choose to enter the email <email>
	And I choose to enter the password <password>
	And I choose to click on submit button
	And I choose to enter email <email>
	And I choose to enter password <password>
	Then I choose to verify the login page
	And I choose to click on manage customer
	Then I choose to verify customer page
	Then I choose to verify total number of transactions
	Examples: 
	| email                                      | password   |
	| TACAdministratorTest@trinityairmedical.com | xoAL@pf9tM |

	Scenario Outline: login and launch manage customer tab and search Demo Customer
	Given launch the application
	When I choose to enter the email <email>
	And I choose to enter the password <password>
	And I choose to click on submit button
	And I choose to enter email <email>
	And I choose to enter password <password>
	Then I choose to verify the login page
	And I choose to click on manage customer
	Then I choose to verify customer page
	When I choose to enter search <searchKey>
	Examples: 
	| email                                      | password   | searchKey     |
	| TACAdministratorTest@trinityairmedical.com | xoAL@pf9tM | Demo Customer |

	Scenario Outline: login and launch manage customer tab and launch customer detail page
	Given launch the application
	When I choose to enter the email <email>
	And I choose to enter the password <password>
	And I choose to click on submit button
	And I choose to enter email <email>
	And I choose to enter password <password>
	Then I choose to verify the login page
	And I choose to click on manage customer
	Then I choose to verify customer page
	When I choose to enter search <searchKey>
	Then I choose to click on demo customer
	Examples: 
	| email                                      | password   | searchKey     |
	| TACAdministratorTest@trinityairmedical.com | xoAL@pf9tM | Demo Customer |

	Scenario Outline: Launch customer detail page and do invoice settings
	Given launch the application
	When I choose to enter the email <email>
	And I choose to enter the password <password>
	And I choose to click on submit button
	And I choose to enter email <email>
	And I choose to enter password <password>
	Then I choose to verify the login page
	And I choose to click on manage customer
	Then I choose to verify customer page
	When I choose to enter search <searchKey>
	Then I choose to click on demo customer
	When I choose to get NSCustomerID
	And I choose to click on invoice settings
	And I choose to change invoice settings
	Then I choose to verify invoice settings
	Examples: 
	| email                                      | password   | searchKey     |
	| TACAdministratorTest@trinityairmedical.com | xoAL@pf9tM | Demo Customer |

#	@Priority(0)
	Scenario Outline: Add Rate settings
	Given launch the application
	When I choose to enter the email <email>
	And I choose to enter the password <password>
	And I choose to click on submit button
	And I choose to enter email <email>
	And I choose to enter password <password>
	Then I choose to verify the login page
	And I choose to click on manage customer
	Then I choose to verify customer page
	When I choose to enter search <searchKey>
	Then I choose to click on demo customer
	When I choose to get NSCustomerID
	And I choose to click on Add New Rate Setting
	And I choose to select type <type1>
	And I choose to select transport type <transportType1>
	And I choose to select type <type2>
	And I choose to select transport type <transportType2>
	And I choose to select type <type4>
	And I choose to select transport type <transportType4>
	And I choose to select type <type5>
	And I choose to select transport type <transportType5>
	And I choose to select type <type6>
	And I choose to select transport type <transportType6>
	And I choose to select type <type7>
	And I choose to select transport type <transportType7>
	And I choose to save the record
	And I choose to Verify saved record
	Examples: 
	| email                                      | password   | searchKey     | transportType1 | type1 | type2 | transportType2 | qty | type4 | transportType4 | type5 | transportType5 | type6 | transportType6 | type7 | transportType7 |
	| TACAdministratorTest@trinityairmedical.com | xoAL@pf9tM | Demo Customer |  Ground        | 1     | 2     |  Specimen      | 2   | 4     | Out of town    | 5     | Lights and Sirens  | 6     | External       | 7     | Flat           |


	Scenario Outline: Edit Rate settings
	Given launch the application
	When I choose to enter the email <email>
	And I choose to enter the password <password>
	And I choose to click on submit button
	And I choose to enter email <email>
	And I choose to enter password <password>
	Then I choose to verify the login page
	And I choose to click on manage customer
	Then I choose to verify customer page
	When I choose to enter search <searchKey>
	Then I choose to click on demo customer
	When I choose to get NSCustomerID
	And I choose to click on edit button
	And I choose to select type <type1>
	And I choose to select transport type <transportType1>
	And I choose to select type <type2>
	And I choose to select transport type <transportType2>
	And I choose to select type <type4>
	And I choose to select transport type <transportType4>
	And I choose to select type <type5>
	And I choose to select transport type <transportType5>
	And I choose to select type <type6>
	And I choose to select transport type <transportType6>
	And I choose to select type <type7>
	And I choose to select transport type <transportType7>
	And I choose to save the record
	Examples: 
	| email                                      | password   | searchKey     | transportType1 | type1 | type2 | transportType2 | qty | type4 | transportType4 | type5 | transportType5 | type6 | transportType6 | type7 | transportType7 |
	| TACAdministratorTest@trinityairmedical.com | xoAL@pf9tM | Demo Customer | Auxiliary      | 1     | 2     | Specimen       | 2   | 4     | Out of town    | 5     | Air Ambulance  | 6     | External       | 7     | Flat           |

	Scenario Outline: Delete Rate settings
	Given launch the application
	When I choose to enter the email <email>
	And I choose to enter the password <password>
	And I choose to click on submit button
	And I choose to enter email <email>
	And I choose to enter password <password>
	Then I choose to verify the login page
	And I choose to click on manage customer
	Then I choose to verify customer page
	When I choose to enter search <searchKey>
	Then I choose to click on demo customer
	When I choose to get NSCustomerID
	And I choose to click on remove button
	And I choose to verify remove request
	Examples: 
	| email                                      | password   | searchKey     | transportType1 | type1 | type2 | transportType2 | qty | type4 | transportType4 | type5 | transportType5 | type6 | transportType6 | type7 | transportType7 |
	| TACAdministratorTest@trinityairmedical.com | xoAL@pf9tM | Demo Customer | Auxiliary      | 1     | 2     | Specimen       | 2   | 4     | Out of town    | 5     | Air Ambulance  | 6     | External       | 7     | Flat           |

	Scenario Outline: Edit Rate settings of type2
	Given launch the application
	When I choose to enter the email <email>
	And I choose to enter the password <password>
	And I choose to click on submit button
	And I choose to enter email <email>
	And I choose to enter password <password>
	Then I choose to verify the login page
	And I choose to click on manage customer
	Then I choose to verify customer page
	When I choose to enter search <searchKey>
	Then I choose to click on demo customer
	When I choose to get NSCustomerID
	And I choose to click on edit button
	And I choose to select type <type1>
	And I choose to select transport type <transportType1>
	And I choose to select type <type2>
	And I choose to select transport type <transportType2>
	And I choose to enter quantity <qty>
	And I choose to select type <type4>
	And I choose to select transport type <transportType4>
	And I choose to select type <type5>
	And I choose to select transport type <transportType5>
	And I choose to select type <type6>
	And I choose to select transport type <transportType6>
	And I choose to select type <type7>
	And I choose to select transport type <transportType7>
	And I choose to enter rate <rate>
	And I choose to save the record
	Examples: 
	| email                                      | password   | searchKey     | transportType1 | type1 | type2 | transportType2 | qty | type4 | transportType4 | type5 | transportType5 | type6 | transportType6 | type7 | transportType7 | transportType8 | type8 | unitValue | rate |
	| TACAdministratorTest@trinityairmedical.com | xoAL@pf9tM | Demo Customer | Ground         | 1     | 2     | Specimen       | 2   | 4     | In town        | 5     |  Air Ambulance | 6     | Internal       | 7     | Flat           | Hours          | 8     | 10        | 200  |

	Scenario Outline: service request page validation
	Given launch the application
	When I choose to enter the email <email>
	And I choose to enter the password <password>
	And I choose to click on submit button
	And I choose to enter email <email>
	And I choose to enter password <password>
	Then I choose to verify the login page
	When I choose to click on service request
	Then I choose to verify service page
	Examples:
	| email                                      | password   |
	| TACAdministratorTest@trinityairmedical.com | xoAL@pf9tM |

	Scenario Outline: Date filter entering
	Given launch the application
	When I choose to enter the email <email>
	And I choose to enter the password <password>
	And I choose to click on submit button
	And I choose to enter email <email>
	And I choose to enter password <password>
	Then I choose to verify the login page
	When I choose to click on service request
	Then I choose to verify service page
	When I choose to select from date
	Examples:
	| email                                      | password   |
	| TACAdministratorTest@trinityairmedical.com | xoAL@pf9tM |

	Scenario Outline: Verify Generate Invoice Page
	Given launch the application
	When I choose to enter the email <email>
	And I choose to enter the password <password>
	And I choose to click on submit button
	And I choose to enter email <email>
	And I choose to enter password <password>
	Then I choose to verify the login page
	When I choose to click on service request
	Then I choose to verify service page
	When I choose to select from date
	#When I choose to click on Customer Filter 
	#When I choose to select on <Search Key>
	#And Apply filter 
	And I choose to click on generate invoice
	Then I choose to verify invoice page
	Examples:
	| email                                      | password   | Search Key    |
	| TACAdministratorTest@trinityairmedical.com | xoAL@pf9tM | Demo Customer | 

	Scenario Outline: Generate Invoice and edit all fields
	Given launch the application
	When I choose to enter the email <email>
	And I choose to enter the password <password>
	And I choose to click on submit button
	And I choose to enter email <email>
	And I choose to enter password <password>
	Then I choose to verify the login page
	When I choose to click on service request
	Then I choose to verify service page
	When I choose to select from date
	And I choose to click on generate invoice
	Then I choose to verify invoice page
	When I choose to edit unos <text1>
	And I choose to edit po <text2>
	And I choose to edit vehicle category<vehicle>
	And I choose to edit provider<type>
	Examples:
	| email                                      | password   | text1   | text2  | vehicle | type     |
	| TACAdministratorTest@trinityairmedical.com | xoAL@pf9tM | UNS1001 | PO1001 | Regular | Internal |


	#@Retry(5)
	Scenario Outline: Generate Invoice and Add File
	Given launch the application
	When I choose to enter the email <email>
	And I choose to enter the password <password>
	And I choose to click on submit button
	And I choose to enter email <email>
	And I choose to enter password <password>
	Then I choose to verify the login page
	When I choose to click on service request
	Then I choose to verify service page
	When I choose to select from date
	And I choose to click on generate invoice
	Then I choose to verify invoice page
	Then I choose to upload file <filename>
	And I choose to verify file uploaded
	Examples:
	| email                                      | password   | filename											   |
	| TACAdministratorTest@trinityairmedical.com | xoAL@pf9tM | C:\\Users\\ASUS\\Pictures\\Screenshots\\Screenshot.png |

	#@Retry(5)
	Scenario Outline: Generate Invoice and Delete File
	Given launch the application
	When I choose to enter the email <email>
	And I choose to enter the password <password>
	And I choose to click on submit button
	And I choose to enter email <email>
	And I choose to enter password <password>
	Then I choose to verify the login page
	When I choose to click on service request
	Then I choose to verify service page
	When I choose to select from date
	And I choose to click on generate invoice
	Then I choose to verify invoice page
	And I choose to verify file deleted
	Examples:
	| email                                      | password   | 
	| TACAdministratorTest@trinityairmedical.com | xoAL@pf9tM | 

	Scenario Outline: Generate Invoice and Create Netsuite 
	Given launch the application
	When I choose to enter the email <email>
	And I choose to enter the password <password>
	And I choose to click on submit button
	And I choose to enter email <email>
	And I choose to enter password <password>
	Then I choose to verify the login page
	When I choose to click on service request
	Then I choose to verify service page
	When I choose to select from date
	And I choose to click on generate invoice
	Then I choose to verify invoice page
	When I choose to edit unos <text1>
	And I choose to edit po <text2>
	And I choose to edit vehicle category<vehicle>
	And I choose to edit provider<type>
	Then I choose to click on create netsuite and verify saved successfully
	Examples:
	| email                                      | password   | text1   | text2  | vehicle | type     |
	| TACAdministratorTest@trinityairmedical.com | xoAL@pf9tM | UNS1001 | PO1001 | Regular | Internal |

		Scenario Outline: Edit Rates settings
	Given launch the application
	When I choose to enter the email <email>
	And I choose to enter the password <password>
	And I choose to click on submit button
	And I choose to enter email <email>
	And I choose to enter password <password>
	Then I choose to verify the login page
	And I choose to click on manage customer
	Then I choose to verify customer page
	When I choose to enter search <searchKey>
	Then I choose to click on demo customer
	When I choose to get NSCustomerID
	And I choose to click on edit button
	And I choose to select type <type1>
	And I choose to select transport type <transportType1>
	And I choose to select type <type2>
	And I choose to select transport type <transportType2>
	And I choose to select type <type4>
	And I choose to select transport type <transportType4>
	And I choose to select type <type5>
	And I choose to select transport type <transportType5>
	And I choose to select type <type6>
	And I choose to select transport type <transportType6>
	And I choose to select type <type7>
	And I choose to select transport type <transportType7>
	And I choose to save the record
	Examples: 
	| email                                      | password   | searchKey     | transportType1 | type1 | type2 | transportType2 | qty | type4 | transportType4 | type5 | transportType5 | type6 | transportType6 | type7 | transportType7 |
	| TACAdministratorTest@trinityairmedical.com | xoAL@pf9tM | Demo Customer | Auxiliary      | 1     | 2     | Specimen       | 2   | 4     | Out of town    | 5     | Air Ambulance  | 6     | External       | 7     | Flat           |
