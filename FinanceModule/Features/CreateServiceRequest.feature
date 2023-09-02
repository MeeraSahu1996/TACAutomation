Feature: CreateServiceRequest

Login to trinity medical solutions application and do tests

//@createServiceRequest
Scenario Outline: 1. Verify Create Service Request page is displayed or not
	Given launch the application
	When I choose to enter the email <email>
	And I choose to enter the password <password>
	And I choose to click on submit button
	And I choose to enter email <email>
	And I choose to enter password <password>
	And I choose to verify home page
	And I choose to Click on Service Request
	And I choose to Click on Service Request button
	Then I choose to verify Create Service Request Page should be displayed	
Examples: 
	| email											| password   |
	| TACExAdministratorTest@trinityairmedical.com  | YQAQ7&*fy! |

Scenario Outline:2. Verify Service Request page is displayed or not
	Given launch the application
	When I choose to enter the email <email>
	And I choose to enter the password <password>
	And I choose to click on submit button
	And I choose to enter email <email>
	And I choose to enter password <password>
	And I choose to verify home page
	And I choose to Click on Service Request
	Then I choose to verify Service Request Page should be displayed
Examples: 
	| email											| password   |
	| TACExAdministratorTest@trinityairmedical.com  | YQAQ7&*fy! |
Scenario Outline:3. Create Service Request enter customer info
	Given launch the application
	When I choose to enter the email <email>
	And I choose to enter the password <password>
	And I choose to click on submit button
	And I choose to enter email <email>
	And I choose to enter password <password>
	And I choose to verify home page
	And I choose to Click on Service Request
	And I choose to Click on Service Request button
	And I choose to select customer details <customer>
	And I choose to select contact details <contact>
	Then I choose to verify phone number populated automatically
Examples: 
	| email                                        | password   | customer     | contact    |
	| TACExAdministratorTest@trinityairmedical.com | YQAQ7&*fy! | Test_Customer| Anish Dasi |
Scenario Outline:4. Create Contact verification in service request page
	Given launch the application
	When I choose to enter the email <email>
	And I choose to enter the password <password>
	And I choose to click on submit button
	And I choose to enter email <email>
	And I choose to enter password <password>
	And I choose to verify home page
	And I choose to Click on Service Request
	And I choose to Click on Service Request button
	And I choose to select customer details <customer>
	And I choose to click on Add Contact button
	Then I choose to verify Add Contact popup
Examples: 
	| email                                        | password   | customer     |
	| TACExAdministratorTest@trinityairmedical.com | YQAQ7&*fy! | Test_Customer| 
Scenario Outline:5. Warning verification without adding customer try to create new contact
	Given launch the application
	When I choose to enter the email <email>
	And I choose to enter the password <password>
	And I choose to click on submit button
	And I choose to enter email <email>
	And I choose to enter password <password>
	And I choose to verify home page
	And I choose to Click on Service Request
	And I choose to Click on Service Request button
	And I choose to click on Add Contact button
	Then I choose to verify warning popup
Examples: 
	| email                                        | password   | customer     |
	| TACExAdministratorTest@trinityairmedical.com | YQAQ7&*fy! | Test_Customer| 
Scenario Outline:6. Create new Contact in service request page
	Given launch the application
	When I choose to enter the email <email>
	And I choose to enter the password <password>
	And I choose to click on submit button
	And I choose to enter email <email>
	And I choose to enter password <password>
	And I choose to verify home page
	And I choose to Click on Service Request
	And I choose to Click on Service Request button
	And I choose to select customer details <customer>
	And I choose to click on Add Contact button
	And I choose to enter firstName <firstName>
	And I choose to enter lastName <lastName>
	And I choose to enter phoneNumber <phoneNumber>
	And I choose to enter inputs as a New member
	Then I choose to verify new contact added successfully
Examples: 
	| email                                        | password   | customer      | firstName | lastName | phoneNumber |
	| TACExAdministratorTest@trinityairmedical.com | YQAQ7&*fy! | Test_Customer | Anish     | Dasi     | 9700082455  |

#@retry(3)
Scenario Outline:07. Create new Contact by selecting one of the Add new member from list in service request page
	Given launch the application
	When I choose to enter the email <email>
	And I choose to enter the password <password>
	And I choose to click on submit button
	And I choose to enter email <email>
	And I choose to enter password <password>
	And I choose to verify home page
	And I choose to Click on Service Request
	And I choose to Click on Service Request button
	And I choose to select customer details <customer>
	And I choose to click on Add Contact button
	And I choose to select from existing contact
	And I choose to enter inputs as a New member
	Then I choose to verify new contact added successfully
Examples: 
	| email                                        | password   | customer      |
	| TACExAdministratorTest@trinityairmedical.com | YQAQ7&*fy! | Test_Customer | 

	#Different Service Types
Scenario Outline: 8.(Equipment-Immediate-Public)Create Service Request entering Service info and Service type as "Equipment" and entering Trip Info
	Given launch the application
	When I choose to enter the email <email>
	And I choose to enter the password <password>
	And I choose to click on submit button
	And I choose to enter email <email>
	And I choose to enter password <password>
	And I choose to verify home page
	And I choose to Click on Service Request
	And I choose to Click on Service Request button
	And I choose to select customer details <customer>
	And I choose to select contact details <contact>
	And I choose to select service type <service>
	And I choose to select equipment type <equipment>
	And I choose to select pickup type <type>
	And I choose to select priority type <priority>
	And I choose to enter unosid <unos>
	And I choose to enter tissueid <tissue>
	And I choose to enter matchid <match>
	And I choose to select trip origin transport mode <mode>
	And I choose to create location click and verify
	And I choose to select location name <locationname>
	And I choose to select address type <addresstype>
	And I choose to select address mode <addressmode>
	And I choose to enter street address <street>
	And I choose to enter zipcode <zipcode>
	And I choose to select state <state>
	And I choose to select city <city>
	And I choose to save the location
	And I choose to select trip destinatio transport mode <destmode>
	And I choose to create destination location click and verify
	And I choose to select location name <locationname>
	And I choose to select address type <addresstype>
	And I choose to select address mode <addressmode>
	And I choose to enter destination street address <street>
	And I choose to enter zipcode <zipcode>
	And I choose to select state <state>
	And I choose to select city <city>
	And I choose to save the location
	And I choose to select category <category>
	And I choose to enter instruction <instruction>
	And I choose to save the transaction
	Then I choose to verify the transaction
Examples: 
	| email                                        | password   | customer      | contact    | service   | equipment         | type      | priority | unos    | tissue   | match   | mode          | locationname | addresstype | addressmode | code | street | zipcode | state    | city     | destmode      | category | instruction | template |
	| TACExAdministratorTest@trinityairmedical.com | YQAQ7&*fy! | Test_Customer | Anish Dasi | Equipment | Medical Equipment | Immediate | Yes      | 6007748 | 79898978 | 7886089 | publicAddress | New York     | Residential | Public      | 6N5  | French | 6773800 | New York | New York | publicAddress | Aircraft | NA          | New York |

Scenario Outline: 9.(Internal-Future-Private) Create Service Request entering Service info and Service type as "Internal"
	Given launch the application
	When I choose to enter the email <email>
	And I choose to enter the password <password>
	And I choose to click on submit button
	And I choose to enter email <email>
	And I choose to enter password <password>
	And I choose to verify home page
	And I choose to Click on Service Request
	And I choose to Click on Service Request button
	And I choose to select customer details <customer>
	And I choose to select contact details <contact>
	And I choose to select service type <service>
	And I choose to select personnel service <personnelservice>
	And I choose to select pickup type <type>
	And I choose to select pickup time
	And I choose to select priority type <priority>
	And I choose to enter unosid <unos>
	And I choose to enter tissueid <tissue>
	And I choose to enter matchid <match>
	And I choose to select trip origin transport mode <mode>
	And I choose to create location click and verify
	And I choose to select location name <locationname>
	And I choose to select address type <addresstype>
	And I choose to select address mode <addressmode>
	And I choose to enter street address <street>
	And I choose to enter zipcode <zipcode>
	And I choose to select state <state>
	And I choose to select city <city>
	And I choose to save the location
	And I choose to select trip destinatio transport mode <destmode>
	And I choose to create destination location click and verify
	And I choose to select location name <locationname>
	And I choose to select address type <addresstype>
	And I choose to select address mode <addressmode>
	And I choose to enter destination street address <street>
	And I choose to enter zipcode <zipcode>
	And I choose to select state <state>
	And I choose to select city <city>
	And I choose to save the location
	And I choose to select category <category>
	And I choose to enter instruction <instruction>
	And I choose to save the transaction
	Then I choose to verify the transaction
Examples: 
	| email                                        | password   | customer      | contact    | service  | type   | priority | unos    | tissue  | match  | personnelservice | mode          | locationname | addresstype | addressmode | code | street | zipcode | state    | city     | destmode       | category | instruction | template |
	| TACExAdministratorTest@trinityairmedical.com | YQAQ7&*fy! | Test_Customer | Anish Dasi | Internal | Future | No       | 6747748 | 6789776 | 877679 | Auto Body Repair | privateAddress | New York     | Residential | Private     | 6N5  | French | 6773800 | New York | New York | privateAddress | Aircraft | NA          | New York |
Scenario Outline: 10.(Next Flight Out-Immediate-Airport)Create Service Request entering Service info and Service type as "Next flight out"
	Given launch the application
	When I choose to enter the email <email>
	And I choose to enter the password <password>
	And I choose to click on submit button
	And I choose to enter email <email>
	And I choose to enter password <password>
	And I choose to verify home page
	And I choose to Click on Service Request
	And I choose to Click on Service Request button
	And I choose to select customer details <customer>
	And I choose to select contact details <contact>
	And I choose to select service type <service>
	And I choose to select next flight <nextflight>
	And I choose to select pickup type <type>
	And I choose to select priority type <priority>
	And I choose to enter unosid <unos>
	And I choose to enter tissueid <tissue>
	And I choose to enter medigo <medigo>
	And I choose to enter jobid <jobid>
	And I choose to enter trackingid <trackingid>
	And I choose to select trip origin transport mode <mode>
	And I choose to select tripinfo airport code <code>
	And I choose to create location click and verify
	And I choose to select location name <locationname>
	And I choose to select address type <addresstype>
	And I choose to select address mode <addressmode>
	And I choose to select airport code <code>
	And I choose to enter street address <street>
	And I choose to enter zipcode <zipcode>
	And I choose to select state <state>
	And I choose to select city <city>
	And I choose to save the location
	And I choose to select trip destinatio transport mode <destmode>
	And I choose to create destination location click and verify
	And I choose to select location name <locationname>
	And I choose to select address type <addresstype>
	And I choose to select address mode <addressmode>
	And I choose to select airport code <code>
	And I choose to enter destination street address <street>
	And I choose to enter zipcode <zipcode>
	And I choose to select state <state>
	And I choose to select city <city>
	And I choose to save the location
	And I choose to select category <category>
	And I choose to enter instruction <instruction>
	And I choose to save the transaction
	Then I choose to verify the transaction
Examples: 
	| email                                        | password   | customer      | contact    | service         | type      | priority | unos    | tissue   | medigo | jobid     | trackingid | nextflight   | mode          | locationname | addresstype | addressmode | code | street | zipcode | state    | city     | destmode       | category | instruction | template |
	| TACExAdministratorTest@trinityairmedical.com | YQAQ7&*fy! | Test_Customer | Anish Dasi | Next Flight Out | Immediate | Yes      | 6712748 | 76289752 | 764579 | 674889894 | 646822     | Blood Sample | airportAddress | New York     | Residential | Airport     | 6N5  | French | 6773800 | New York | New York | privateAddress | Aircraft | NA          | New York |
Scenario Outline:11. (Organ) Create Service Request entering Service info and Service type as "Organ"
	Given launch the application
	When I choose to enter the email <email>
	And I choose to enter the password <password>
	And I choose to click on submit button
	And I choose to enter email <email>
	And I choose to enter password <password>
	And I choose to verify home page
	And I choose to Click on Service Request
	And I choose to Click on Service Request button
	And I choose to select customer details <customer>
	And I choose to select contact details <contact>
	And I choose to select service type <service>
	And I choose to select organ type <organType>
	And I choose to select ortime and sirens <sirens>
	And I choose to select pickup type <type>
	And I choose to select priority type <priority>
	And I choose to enter unosid <unos>
	And I choose to enter tissueid <tissue>
	And I choose to enter matchid <match>
	And I choose to select trip origin transport mode <mode>
	And I choose to create location click and verify
	And I choose to select location name <locationname>
	And I choose to select address type <addresstype>
	And I choose to select address mode <addressmode>
	And I choose to enter street address <street>
	And I choose to enter zipcode <zipcode>
	And I choose to select state <state>
	And I choose to select city <city>
	And I choose to save the location
	And I choose to select trip destinatio transport mode <destmode>
	And I choose to create destination location click and verify
	And I choose to select location name <locationname>
	And I choose to select address type <addresstype>
	And I choose to select address mode <addressmode>
	And I choose to enter destination street address <street>
	And I choose to enter zipcode <zipcode>
	And I choose to select state <state>
	And I choose to select city <city>
	And I choose to save the location
	And I choose to select category <category>
	And I choose to enter instruction <instruction>
	And I choose to save the transaction
	Then I choose to verify the transaction
Examples: 
	| email                                        | password   | customer      | contact    | service | type      | priority | unos    | tissue | match  | organType   | sirens | mode          | locationname | addresstype | addressmode | code | street | zipcode | state    | city     | destmode       | category | instruction | template |
	| TACExAdministratorTest@trinityairmedical.com | YQAQ7&*fy! | Test_Customer | Anish Dasi | Organ   | Immediate | Yes      | 6712998 | 746619 | 378192 | Kidney Left | Yes    | publicAddress | New York     | Residential | Private     | 6N5  | French | 6773800 | New York | New York | privateAddress | Aircraft | NA          | New York |
Scenario Outline:12. (Specimen-Single) Create Service Request entering Service info and Service type as "Specimen"
	Given launch the application
	When I choose to enter the email <email>
	And I choose to enter the password <password>
	And I choose to click on submit button
	And I choose to enter email <email>
	And I choose to enter password <password>
	And I choose to verify home page
	And I choose to Click on Service Request
	And I choose to Click on Service Request button
	And I choose to select customer details <customer>
	And I choose to select contact details <contact>
	And I choose to select service type <service>
	And I choose to select specimen type <specimenType>
	And I choose to select drop location <droplocation>
	And I choose to select drop category <dropcategory>
	And I choose to select pickup type <type>
	And I choose to select priority type <priority>
	And I choose to enter unosid <unos>
	And I choose to enter tissueid <tissue>
	And I choose to enter matchid <match>
	And I choose to select trip origin transport mode <mode>
	And I choose to create location click and verify
	And I choose to select location name <locationname>
	And I choose to select address type <addresstype>
	And I choose to select address mode <addressmode>
	And I choose to enter street address <street>
	And I choose to enter zipcode <zipcode>
	And I choose to select state <state>
	And I choose to select city <city>
	And I choose to save the location
	And I choose to select trip destinatio transport mode <destmode>
	And I choose to create destination location click and verify
	And I choose to select location name <locationname>
	And I choose to select address type <addresstype>
	And I choose to select address mode <addressmode>
	And I choose to enter destination street address <street>
	And I choose to enter zipcode <zipcode>
	And I choose to select state <state>
	And I choose to select city <city>
	And I choose to save the location
	And I choose to select category <category>
	And I choose to enter instruction <instruction>
	And I choose to save the transaction
	Then I choose to verify the transaction
Examples: 
	| email                                        | password   | customer      | contact    | service  | type      | priority | unos    | tissue  | match  | specimenType | droplocation | dropcategory | mode          | locationname | addresstype | addressmode | code | street | zipcode | state    | city     | destmode       | category | instruction | template |
	| TACExAdministratorTest@trinityairmedical.com | YQAQ7&*fy! | Test_Customer | Anish Dasi | Specimen | Immediate | Yes      | 6712998 | 7638373 | 867483 | Blood Sample | Single       | In town      | publicAddress | New York     | Residential | Private     | 6N5  | French | 6773800 | New York | New York | privateAddress | Aircraft | NA          | New York |
Scenario Outline:13. (Specimen-Multiple) Create Service Request entering Service info and Service type as "Specimen"
	Given launch the application
	When I choose to enter the email <email>
	And I choose to enter the password <password>
	And I choose to click on submit button
	And I choose to enter email <email>
	And I choose to enter password <password>
	And I choose to verify home page
	And I choose to Click on Service Request
	And I choose to Click on Service Request button
	And I choose to select customer details <customer>
	And I choose to select contact details <contact>
	And I choose to select service type <service>
	And I choose to select specimen type <specimenType>
	And I choose to select drop location <droplocation>
	And I choose to select drop category <dropcategory>
	And I choose to select pickup type <type>
	And I choose to select priority type <priority>
	And I choose to enter unosid <unos>
	And I choose to enter tissueid <tissue>
	And I choose to enter matchid <match>
	And I choose to select trip origin transport mode <mode>
	And I choose to create location click and verify
	And I choose to select location name <locationname>
	And I choose to select address type <addresstype>
	And I choose to select address mode <addressmode>
	And I choose to enter street address <street>
	And I choose to enter zipcode <zipcode>
	And I choose to select state <state>
	And I choose to select city <city>
	And I choose to save the location
	And I choose to select trip destinatio transport mode <destmode>
	And I choose to select category <category>
	And I choose to enter instruction <instruction>
	And I choose to select destinations mode <destinationsmode>
	And I choose to save the transaction
	Then I choose to verify the transaction
Examples: 
	| email                                        | password   | customer      | contact    | service  | type      | priority | unos    | tissue  | match    | specimenType | droplocation | dropcategory | mode          | locationname | addresstype | addressmode | code | street | zipcode | state    | city     | destmode       | category | instruction | template | destinationsmode |
	| TACExAdministratorTest@trinityairmedical.com | YQAQ7&*fy! | Test_Customer | Anish Dasi | Specimen | Immediate | Yes      | 6712998 | 8798900 | 67188293 | Blood Sample | Multiple     | In town      | publicAddress | New York     | Residential | Public     | 6N5  | French | 6773800 | New York | New York | privateAddress | Aircraft | NA          | New York | public           |

Scenario Outline: 14.Create Service Request entering Service info and Service type as "Team" and entering Trip Info
	Given launch the application
	When I choose to enter the email <email>
	And I choose to enter the password <password>
	And I choose to click on submit button
	And I choose to enter email <email>
	And I choose to enter password <password>
	And I choose to verify home page
	And I choose to Click on Service Request
	And I choose to Click on Service Request button
	And I choose to select customer details <customer>
	And I choose to select contact details <contact>
	And I choose to select service type <service>
	And I choose to select team type <team>
	And I choose to select additional equipment <addequipment>
	And I choose to select additional types <addequiptype>
	And I choose to select pickup type <type>
	And I choose to select priority type <priority>
	And I choose to enter unosid <unos>
	And I choose to select ortime and sirens <sirens>
	And I choose to enter tissueid <tissue>
	And I choose to enter matchid <match>
	And I choose to select trip origin transport mode <mode>
	And I choose to create location click and verify
	And I choose to select location name <locationname>
	And I choose to select address type <addresstype>
	And I choose to select address mode <addressmode>
	And I choose to enter street address <street>
	And I choose to enter zipcode <zipcode>
	And I choose to select state <state>
	And I choose to select city <city>
	And I choose to save the location
	And I choose to select trip destinatio transport mode <destmode>
	And I choose to create destination location click and verify
	And I choose to select location name <locationname>
	And I choose to select address type <addresstype>
	And I choose to select address mode <addressmode>
	And I choose to enter destination street address <street>
	And I choose to enter zipcode <zipcode>
	And I choose to select state <state>
	And I choose to select city <city>
	And I choose to save the location
	And I choose to select category <category>
	And I choose to enter instruction <instruction>
	And I choose to save the transaction
	Then I choose to verify the transaction
Examples: 
	| email                                        | password   | customer      | contact    | service | team  | type      | priority | unos    | sirens | tissue  | match     | mode          | locationname | addresstype | addressmode | code | street | zipcode | state    | city     | destmode       | category | instruction | template | addequipment | addequiptype    |
	| TACExAdministratorTest@trinityairmedical.com | YQAQ7&*fy! | Test_Customer | Anish Dasi | Team    | Heart | Immediate | Yes      | 6007748 | Yes    | 8723859 | 871982193 | publicAddress | New York     | Residential | Private     | 6N5  | French | 6773800 | New York | New York | privateAddress | Aircraft | NA          | New York | Yes          | Additional Bags |

#@retry(3)
Scenario Outline:15. Verifying warning message while entering Trip Info
	Given launch the application
	When I choose to enter the email <email>
	And I choose to enter the password <password>
	And I choose to click on submit button
	And I choose to enter email <email>
	And I choose to enter password <password>
	And I choose to verify home page
	And I choose to Click on Service Request
	And I choose to Click on Service Request button
	And I choose to select customer details <customer>
	And I choose to select contact details <contact>
	And I choose to select service type <service>
	And I choose to select equipment type <equipment>
	And I choose to select pickup type <type>
	And I choose to select priority type <priority>
	And I choose to enter unosid <unos>
	And I choose to select trip origin transport mode <mode>
	And I choose to create location click and verify
	And I choose to select location name <locationname>
	And I choose to select address type <addresstype>
	And I choose to select address mode <addressmode>
	And I choose to enter same street address <street>
	And I choose to enter zipcode <zipcode>
	And I choose to select state <state>
	And I choose to select city <city>
	And I choose to save the location
	Then I choose to verify warning popup for same address
	Then I choose to verify warning popup of same address
Examples: 
	| email                                        | password   | customer      | contact    | service   | equipment         | type      | priority | unos    | mode          | locationname | addresstype | addressmode | code | street | zipcode | state | city     | destmode       | category | instruction | template |
	| TACExAdministratorTest@trinityairmedical.com | YQAQ7&*fy! | Test_Customer | Anish Dasi | Equipment | Medical Equipment | Immediate | Yes      | 6007748 | publicAddress | New York     | Residential | Private     | 6N5  | French | 6773800 | New York | New York | privateAddress | Aircraft | NA       | New York |
Scenario Outline:16. Create Service Request entering Service info and Service type as "Equipment" and entering Trip Info using existing items
	Given launch the application
	When I choose to enter the email <email>
	And I choose to enter the password <password>
	And I choose to click on submit button
	And I choose to enter email <email>
	And I choose to enter password <password>
	And I choose to verify home page
	And I choose to Click on Service Request
	And I choose to Click on Service Request button
	And I choose to select customer details <customer>
	And I choose to select contact details <contact>
	And I choose to select service type <service>
	And I choose to select equipment type <equipment>
	And I choose to select pickup type <type>
	And I choose to select priority type <priority>
	And I choose to enter unosid <unos>
	And I choose to select trip origin transport mode <mode>
	And I choose to select trip destinatio transport mode <destmode>
	And I choose to selectOrigin and destination
	And I choose to select category <category>
	And I choose to enter instruction <instruction>
	And I choose to save the transaction
	Then I choose to verify the transaction
Examples: 
	| email                                        | password   | customer      | contact    | service   | equipment         | type      | priority | unos    | mode          | locationname | addresstype | addressmode | code | street | zipcode | state | city     | destmode       | category | instruction | template |
	| TACExAdministratorTest@trinityairmedical.com | YQAQ7&*fy! | Test_Customer | Anish Dasi | Equipment | Medical Equipment | Immediate | Yes      | 6007748 | publicAddress | New York     | Residential | Private     | 6N5  | French | 6773800 | New York | New York | privateAddress | Aircraft | NA       | New York |
Scenario Outline:17(defect). Create Service Request and add template and save the transaction
	Given launch the application
	When I choose to enter the email <email>
	And I choose to enter the password <password>
	And I choose to click on submit button
	And I choose to enter email <email>
	And I choose to enter password <password>
	And I choose to verify home page
	And I choose to Click on Service Request
	And I choose to Click on Service Request button
	And I choose to select customer details <customer>
	And I choose to select contact details <contact>
	And I choose to select service type <service>
	And I choose to select equipment type <equipment>
	And I choose to select pickup type <type>
	And I choose to select priority type <priority>
	And I choose to enter unosid <unos>
	And I choose to select trip origin transport mode <mode>
	And I choose to select trip destinatio transport mode <destmode>
	And I choose to selectOrigin and destination
	And I choose to select category <category>
	And I choose to enter instruction <instruction>
	And T choose to enter template name <template>
	And I choose to save the transaction with Save Temp Option
	Then I choose to verify the transaction
Examples: 
	| email                                        | password   | customer      | contact    | service   | equipment         | type      | priority | unos    | mode          | locationname | addresstype | addressmode | code | street | zipcode | state | city     | destmode       | category | instruction | template |
	| TACExAdministratorTest@trinityairmedical.com | YQAQ7&*fy! | Test_Customer | Anish Dasi | Equipment | Medical Equipment | Immediate | Yes      | 6007748 | publicAddress | New York     | Residential | Private     | 6N5  | French | 6773800 | New York | New York | privateAddress | Aircraft | NA       | New York |
Scenario Outline:18(defect). Create Service Request using template flow
	Given launch the application
	When I choose to enter the email <email>
	And I choose to enter the password <password>
	And I choose to click on submit button
	And I choose to enter email <email>
	And I choose to enter password <password>
	And I choose to verify home page
	And I choose to Click on Service Request
	And I choose to Click on Service Request button
	And I choose to create service request using template <templatecreate>
	And I choose to save the transaction
	Then I choose to verify the transaction
Examples: 
	| email                                        | password   | customer      | contact    | service   | equipment         | type      | priority | unos    | mode          | locationname | addresstype | addressmode | code | street | zipcode | state    | city     | destmode       | category | instruction | template | templatecreate |
	| TACExAdministratorTest@trinityairmedical.com | YQAQ7&*fy! | Test_Customer | Anish Dasi | Equipment | Medical Equipment | Immediate | Yes      | 6007748 | publicAddress | New York     | Residential | Private     | 6N5  | French | 6773800 | New York | New York | privateAddress | Aircraft | NA          | New York | Arizona        |
Scenario Outline:19. Create Service Request by adding existing items and while adding notes and files
	Given launch the application
	When I choose to enter the email <email>
	And I choose to enter the password <password>
	And I choose to click on submit button
	And I choose to enter email <email>
	And I choose to enter password <password>
	And I choose to verify home page
	And I choose to Click on Service Request
	And I choose to Click on Service Request button
	And I choose to select customer details <customer>
	And I choose to select contact details <contact>
	And I choose to select service type <service>
	And I choose to select equipment type <equipment>
	And I choose to select pickup type <type>
	And I choose to select priority type <priority>
	And I choose to enter unosid <unos>
	And I choose to select trip origin transport mode <mode>
	And I choose to select trip destinatio transport mode <destmode>
	And I choose to selectOrigin and destination
	And I choose to select category <category>
	And I choose to enter instruction <instruction>
	And I choose to add notes <notes>
	And I choose to add file
	And I choose to save the transaction
	Then I choose to verify the transaction
Examples: 
	| email                                        | password   | customer      | contact    | service   | equipment         | type      | priority | unos    | mode          | locationname | addresstype | addressmode | code | street | zipcode | state    | city     | destmode       | category | instruction | template | notes   |
	| TACExAdministratorTest@trinityairmedical.com | YQAQ7&*fy! | Test_Customer | Anish Dasi | Equipment | Medical Equipment | Immediate | Yes      | 6007748 | publicAddress | New York     | Residential | Private     | 6N5  | French | 6773800 | New York | New York | privateAddress | Aircraft | NA          | New York | Pick up |

Scenario Outline: 20.Create Service Request entering Service info and Service type as "Internal" and while adding notes and file
	Given launch the application
	When I choose to enter the email <email>
	And I choose to enter the password <password>
	And I choose to click on submit button
	And I choose to enter email <email>
	And I choose to enter password <password>
	And I choose to verify home page
	And I choose to Click on Service Request
	And I choose to Click on Service Request button
	And I choose to select customer details <customer>
	And I choose to select contact details <contact>
	And I choose to select service type <service>
	And I choose to select personnel service <personnelservice>
	And I choose to select pickup type <type>
	And I choose to select pickup time
	And I choose to select priority type <priority>
	And I choose to enter unosid <unos>
	And I choose to enter tissueid <tissue>
	And I choose to enter matchid <match>
	And I choose to select trip origin transport mode <mode>
	And I choose to create location click and verify
	And I choose to select location name <locationname>
	And I choose to select address type <addresstype>
	And I choose to select address mode <addressmode>
	And I choose to enter street address <street>
	And I choose to enter zipcode <zipcode>
	And I choose to select state <state>
	And I choose to select city <city>
	And I choose to save the location
	And I choose to select trip destinatio transport mode <destmode>
	And I choose to create destination location click and verify
	And I choose to select location name <locationname>
	And I choose to select address type <addresstype>
	And I choose to select address mode <addressmode>
	And I choose to enter destination street address <street>
	And I choose to enter zipcode <zipcode>
	And I choose to select state <state>
	And I choose to select city <city>
	And I choose to save the location
	And I choose to select category <category>
	And I choose to enter instruction <instruction>
	And I choose to add notes <notes>
	And I choose to add file
	And I choose to save the transaction
	Then I choose to verify the transaction
Examples: 
	| email                                        | password   | customer      | contact    | service  | type   | priority | unos    | tissue  | match  | personnelservice | mode           | locationname | addresstype | addressmode | code | street | zipcode | state    | city     | destmode       | category | instruction | template | notes   |
	| TACExAdministratorTest@trinityairmedical.com | YQAQ7&*fy! | Test_Customer | Anish Dasi | Internal | Future | No       | 6747748 | 6789776 | 877679 | Auto Body Repair | privateAddress | New York     | Residential | Private     | 6N5  | French | 6773800 | New York | New York | privateAddress | Aircraft | NA          | New York | Weather |
#Different Job Types
Scenario Outline: 21.(Equipment-Immediate-Public-Air Only)Create Service Request entering Service info and Service type as "Equipment" and entering Trip Info and jobtype as Air Only
	Given launch the application
	When I choose to enter the email <email>
	And I choose to enter the password <password>
	And I choose to click on submit button
	And I choose to enter email <email>
	And I choose to enter password <password>
	And I choose to verify home page
	And I choose to Click on Service Request
	And I choose to Click on Service Request button
	And I choose to select customer details <customer>
	And I choose to select contact details <contact>
	And I choose to select service type <service>
	And I choose to select equipment type <equipment>
	And I choose to select pickup type <type>
	And I choose to select priority type <priority>
	And I choose to enter unosid <unos>
	And I choose to enter tissueid <tissue>
	And I choose to enter matchid <match>
	And I choose to select jobtype <job>
	And I choose to select trip origin transport mode <mode>
	And I choose to create location click and verify
	And I choose to select location name <locationname>
	And I choose to select address type <addresstype>
	And I choose to select address mode <addressmode>
	And I choose to enter street address <street>
	And I choose to enter zipcode <zipcode>
	And I choose to select state <state>
	And I choose to select city <city>
	And I choose to save the location
	And I choose to select trip destinatio transport mode <destmode>
	And I choose to create destination location click and verify
	And I choose to select location name <locationname>
	And I choose to select address type <addresstype>
	And I choose to select address mode <addressmode>
	And I choose to enter destination street address <street>
	And I choose to enter zipcode <zipcode>
	And I choose to select state <state>
	And I choose to select city <city>
	And I choose to save the location
	And I choose to select category <category>
	And I choose to enter instruction <instruction>
	And I choose to save the transaction
	Then I choose to verify the transaction
Examples: 
	| email                                        | password   | customer      | contact    | service   | equipment         | type      | priority | unos    | tissue   | match   | mode          | locationname | addresstype | addressmode | code | street | zipcode | state    | city     | destmode      | category | instruction | template | job      |
	| TACExAdministratorTest@trinityairmedical.com | YQAQ7&*fy! | Test_Customer | Anish Dasi | Equipment | Medical Equipment | Immediate | Yes      | 6007748 | 79898978 | 7886089 | publicAddress | New York     | Residential | Public      | 6N5  | French | 6773800 | New York | New York | publicAddress | Aircraft | NA          | New York | Air Only |

Scenario Outline: 22.(Internal-Future-Private-Combo) Create Service Request entering Service info and Service type as "Internal" and Jobtype as Combo
	Given launch the application
	When I choose to enter the email <email>
	And I choose to enter the password <password>
	And I choose to click on submit button
	And I choose to enter email <email>
	And I choose to enter password <password>
	And I choose to verify home page
	And I choose to Click on Service Request
	And I choose to Click on Service Request button
	And I choose to select customer details <customer>
	And I choose to select contact details <contact>
	And I choose to select service type <service>
	And I choose to select personnel service <personnelservice>
	And I choose to select pickup type <type>
	And I choose to select pickup time
	And I choose to select priority type <priority>
	And I choose to enter unosid <unos>
	And I choose to enter tissueid <tissue>
	And I choose to enter matchid <match>
	And I choose to select jobtype <job>
	And I choose to select trip origin transport mode <mode>
	And I choose to create location click and verify
	And I choose to select location name <locationname>
	And I choose to select address type <addresstype>
	And I choose to select address mode <addressmode>
	And I choose to enter street address <street>
	And I choose to enter zipcode <zipcode>
	And I choose to select state <state>
	And I choose to select city <city>
	And I choose to save the location
	And I choose to select trip destinatio transport mode <destmode>
	And I choose to create destination location click and verify
	And I choose to select location name <locationname>
	And I choose to select address type <addresstype>
	And I choose to select address mode <addressmode>
	And I choose to enter destination street address <street>
	And I choose to enter zipcode <zipcode>
	And I choose to select state <state>
	And I choose to select city <city>
	And I choose to save the location
	And I choose to select category <category>
	And I choose to enter instruction <instruction>
	And I choose to save the transaction
	Then I choose to verify the transaction
Examples: 
	| email                                        | password   | customer      | contact    | service  | type   | priority | unos    | tissue  | match  | personnelservice | mode           | locationname | addresstype | addressmode | code | street | zipcode | state    | city     | destmode       | category | instruction | template | job   |
	| TACExAdministratorTest@trinityairmedical.com | YQAQ7&*fy! | Test_Customer | Anish Dasi | Internal | Future | No       | 6747748 | 6789776 | 877679 | Auto Body Repair | privateAddress | New York     | Residential | Private     | 6N5  | French | 6773800 | New York | New York | privateAddress | Aircraft | NA          | New York | Combo |
Scenario Outline: 23.(Next Flight Out-Immediate-Airport-Ground Only)Create Service Request entering Service info and Service type as "Next flight out" and jobtype as Ground Only
	Given launch the application
	When I choose to enter the email <email>
	And I choose to enter the password <password>
	And I choose to click on submit button
	And I choose to enter email <email>
	And I choose to enter password <password>
	And I choose to verify home page
	And I choose to Click on Service Request
	And I choose to Click on Service Request button
	And I choose to select customer details <customer>
	And I choose to select contact details <contact>
	And I choose to select service type <service>
	And I choose to select next flight <nextflight>
	And I choose to select pickup type <type>
	And I choose to select priority type <priority>
	And I choose to enter unosid <unos>
	And I choose to enter tissueid <tissue>
	And I choose to enter medigo <medigo>
	And I choose to enter jobid <jobid>
	And I choose to enter trackingid <trackingid>
	And I choose to select jobtype <job>
	And I choose to select trip origin transport mode <mode>
	And I choose to select tripinfo airport code <code>
	And I choose to create location click and verify
	And I choose to select location name <locationname>
	And I choose to select address type <addresstype>
	And I choose to select address mode <addressmode>
	And I choose to select airport code <code>
	And I choose to enter street address <street>
	And I choose to enter zipcode <zipcode>
	And I choose to select state <state>
	And I choose to select city <city>
	And I choose to save the location
	And I choose to select trip destinatio transport mode <destmode>
	And I choose to create destination location click and verify
	And I choose to select location name <locationname>
	And I choose to select address type <addresstype>
	And I choose to select address mode <addressmode>
	And I choose to select airport code <code>
	And I choose to enter destination street address <street>
	And I choose to enter zipcode <zipcode>
	And I choose to select state <state>
	And I choose to select city <city>
	And I choose to save the location
	And I choose to select category <category>
	And I choose to enter instruction <instruction>
	And I choose to save the transaction
	Then I choose to verify the transaction
Examples: 
	| email                                        | password   | customer      | contact    | service         | type      | priority | unos    | tissue   | medigo | jobid     | trackingid | nextflight   | mode           | locationname | addresstype | addressmode | code | street | zipcode | state    | city     | destmode       | category | instruction | template | job         |
	| TACExAdministratorTest@trinityairmedical.com | YQAQ7&*fy! | Test_Customer | Anish Dasi | Next Flight Out | Immediate | Yes      | 6712748 | 76289752 | 764579 | 674889894 | 646822     | Blood Sample | airportAddress | New York     | Residential | Airport     | 6N5  | French | 6773800 | New York | New York | privateAddress | Aircraft | NA          | New York | Ground Only |
	
Scenario Outline: 24.Create Service Request using copy service request button
	Given launch the application
	When I choose to enter the email <email>
	And I choose to enter the password <password>
	And I choose to click on submit button
	And I choose to enter email <email>
	And I choose to enter password <password>
	And I choose to verify home page
	And I choose to Click on Service Request
	And I choose to click on copy service request
	And I choose to save the transaction
	Then I choose to verify the transaction 
	Examples: 
	| email											| password   |
	| TACExAdministratorTest@trinityairmedical.com  | YQAQ7&*fy! |


#############################################################################################################
Scenario Outline: 25.Verify Create Service Request page is displayed or not for Customer Admin
	Given launch the application
	When I choose to enter the email <email>
	And I choose to enter the password <password>
	And I choose to click on submit button
	And I choose to enter email <email>
	And I choose to enter password <password>
	And I choose to verify home page
	And I choose to Click on Service Request
	And I choose to Click on Service Request button
	Then I choose to verify Create Service Request Page should be displayed	
Examples: 
	| email									 | password   |
	| TACCustAdminTest@trinityairmedical.com | w4@3oNfrE7 |

Scenario Outline: 26.Verify Service Request page is displayed or not for customer admin
	Given launch the application
	When I choose to enter the email <email>
	And I choose to enter the password <password>
	And I choose to click on submit button
	And I choose to enter email <email>
	And I choose to enter password <password>
	And I choose to verify home page
	And I choose to Click on Service Request
	Then I choose to verify Service Request Page should be displayed
Examples: 
	| email									  | password   |
	| TACCustAdminTest@trinityairmedical.com  | w4@3oNfrE7 |
#Different Service Types
Scenario Outline: 27.(Equipment-Immediate-Public)Create Service Request entering Service info and Service type as "Equipment" and entering Trip Info as customer admin
	Given launch the application
	When I choose to enter the email <email>
	And I choose to enter the password <password>
	And I choose to click on submit button
	And I choose to enter email <email>
	And I choose to enter password <password>
	And I choose to verify home page
	And I choose to Click on Service Request
	And I choose to Click on Service Request button
	And I choose to select service type <service>
	And I choose to select equipment type <equipment>
	And I choose to select pickup type <type>
	And I choose to enter unosid <unos>
	And I choose to enter tissueid <tissue>
	And I choose to enter matchid <match>
	And I choose to select trip origin transport mode <mode>
	And I choose to create location click and verify
	And I choose to select location name <locationname>
	And I choose to select address type <addresstype>
	And I choose to select address mode <addressmode>
	And I choose to enter street address <street>
	And I choose to enter zipcode <zipcode>
	And I choose to select state <state>
	And I choose to select city <city>
	And I choose to save the location
	And I choose to select trip destinatio transport mode <destmode>
	And I choose to create destination location click and verify
	And I choose to select location name <locationname>
	And I choose to select address type <addresstype>
	And I choose to select address mode <addressmode>
	And I choose to enter destination street address <street>
	And I choose to enter zipcode <zipcode>
	And I choose to select state <state>
	And I choose to select city <city>
	And I choose to save the location
	And I choose to select category <category>
	And I choose to enter instruction <instruction>
	And I choose to save the transaction
	Then I choose to verify the transaction
Examples: 
	| email                                  | password   | customer      | contact    | service   | equipment         | type      | priority | unos    | tissue   | match   | mode          | locationname | addresstype | addressmode | code | street | zipcode | state    | city     | destmode      | category | instruction | template |
	| TACCustAdminTest@trinityairmedical.com | w4@3oNfrE7 | Test_Customer | Anish Dasi | Equipment | Medical Equipment | Immediate | Yes      | 6007748 | 79898978 | 7886089 | publicAddress | New York     | Residential | Public      | 6N5  | French | 6773800 | New York | New York | publicAddress | Aircraft | NA          | New York |

Scenario Outline: 28.(Next Flight Out-Immediate-Airport)Create Service Request entering Service info and Service type as "Next flight out" as customer admin
	Given launch the application
	When I choose to enter the email <email>
	And I choose to enter the password <password>
	And I choose to click on submit button
	And I choose to enter email <email>
	And I choose to enter password <password>
	And I choose to verify home page
	And I choose to Click on Service Request
	And I choose to Click on Service Request button
	And I choose to select service type <service>
	And I choose to select next flight <nextflight>
	And I choose to select pickup type <type>
	And I choose to enter unosid <unos>
	And I choose to enter tissueid <tissue>
	And I choose to select trip origin transport mode <mode>
	And I choose to select tripinfo airport code <code>
	And I choose to create location click and verify
	And I choose to select location name <locationname>
	And I choose to select address type <addresstype>
	And I choose to select address mode <addressmode>
	And I choose to select airport code <code>
	And I choose to enter street address <street>
	And I choose to enter zipcode <zipcode>
	And I choose to select state <state>
	And I choose to select city <city>
	And I choose to save the location
	And I choose to select trip destinatio transport mode <destmode>
	And I choose to create destination location click and verify
	And I choose to select location name <locationname>
	And I choose to select address type <addresstype>
	And I choose to select address mode <addressmode>
	And I choose to select airport code <code>
	And I choose to enter destination street address <street>
	And I choose to enter zipcode <zipcode>
	And I choose to select state <state>
	And I choose to select city <city>
	And I choose to save the location
	And I choose to select category <category>
	And I choose to enter instruction <instruction>
	And I choose to save the transaction
	Then I choose to verify the transaction
Examples: 
	| email                                  | password   | customer      | contact    | service         | type      | priority | unos    | tissue   | medigo | jobid     | trackingid | nextflight   | mode          | locationname | addresstype | addressmode | code | street | zipcode | state    | city     | destmode       | category | instruction | template |
	| TACCustAdminTest@trinityairmedical.com | w4@3oNfrE7 | Test_Customer | Anish Dasi | Next Flight Out | Immediate | Yes      | 6712748 | 76289752 | 764579 | 674889894 | 646822     | Blood Sample | airportAddress | New York     | Residential | Airport     | 6N5  | French | 6773800 | New York | New York | privateAddress | Aircraft | NA          | New York |
Scenario Outline:29. (Organ) Create Service Request entering Service info and Service type as "Organ" as customer admin
	Given launch the application
	When I choose to enter the email <email>
	And I choose to enter the password <password>
	And I choose to click on submit button
	And I choose to enter email <email>
	And I choose to enter password <password>
	And I choose to verify home page
	And I choose to Click on Service Request
	And I choose to Click on Service Request button
	And I choose to select service type <service>
	And I choose to select organ type <organType>
	And I choose to select ortime and sirens <sirens>
	And I choose to select pickup type <type>
	And I choose to enter unosid <unos>
	And I choose to enter tissueid <tissue>
	And I choose to enter matchid <match>
	And I choose to select trip origin transport mode <mode>
	And I choose to create location click and verify
	And I choose to select location name <locationname>
	And I choose to select address type <addresstype>
	And I choose to select address mode <addressmode>
	And I choose to enter street address <street>
	And I choose to enter zipcode <zipcode>
	And I choose to select state <state>
	And I choose to select city <city>
	And I choose to save the location
	And I choose to select trip destinatio transport mode <destmode>
	And I choose to create destination location click and verify
	And I choose to select location name <locationname>
	And I choose to select address type <addresstype>
	And I choose to select address mode <addressmode>
	And I choose to enter destination street address <street>
	And I choose to enter zipcode <zipcode>
	And I choose to select state <state>
	And I choose to select city <city>
	And I choose to save the location
	And I choose to select category <category>
	And I choose to enter instruction <instruction>
	And I choose to save the transaction
	Then I choose to verify the transaction
Examples: 
	| email                                  | password   | customer      | contact    | service | type      | priority | unos    | tissue | match  | organType   | sirens | mode          | locationname | addresstype | addressmode | code | street | zipcode | state    | city     | destmode       | category | instruction | template |
	| TACCustAdminTest@trinityairmedical.com |  w4@3oNfrE7| Test_Customer | Anish Dasi | Organ   | Immediate | Yes      | 6712998 | 746619 | 378192 | Kidney Left | Yes    | publicAddress | New York     | Residential | Private     | 6N5  | French | 6773800 | New York | New York | privateAddress | Aircraft | NA          | New York |
Scenario Outline:30. (Specimen-Single) Create Service Request entering Service info and Service type as "Specimen" as customer admin
	Given launch the application
	When I choose to enter the email <email>
	And I choose to enter the password <password>
	And I choose to click on submit button
	And I choose to enter email <email>
	And I choose to enter password <password>
	And I choose to verify home page
	And I choose to Click on Service Request
	And I choose to Click on Service Request button
	And I choose to select service type <service>
	And I choose to select specimen type <specimenType>
	And I choose to select drop location <droplocation>
	And I choose to select pickup type <type>
	And I choose to enter unosid <unos>
	And I choose to enter tissueid <tissue>
	And I choose to enter matchid <match>
	And I choose to select trip origin transport mode <mode>
	And I choose to create location click and verify
	And I choose to select location name <locationname>
	And I choose to select address type <addresstype>
	And I choose to select address mode <addressmode>
	And I choose to enter street address <street>
	And I choose to enter zipcode <zipcode>
	And I choose to select state <state>
	And I choose to select city <city>
	And I choose to save the location
	And I choose to select trip destinatio transport mode <destmode>
	And I choose to create destination location click and verify
	And I choose to select location name <locationname>
	And I choose to select address type <addresstype>
	And I choose to select address mode <addressmode>
	And I choose to enter destination street address <street>
	And I choose to enter zipcode <zipcode>
	And I choose to select state <state>
	And I choose to select city <city>
	And I choose to save the location
	And I choose to select category <category>
	And I choose to enter instruction <instruction>
	And I choose to save the transaction
	Then I choose to verify the transaction
Examples: 
	| email                                  | password   | customer      | contact    | service  | type      | priority | unos    | tissue  | match  | specimenType | droplocation | dropcategory | mode          | locationname | addresstype | addressmode | code | street | zipcode | state    | city     | destmode       | category | instruction | template |
	| TACCustAdminTest@trinityairmedical.com | w4@3oNfrE7 | Test_Customer | Anish Dasi | Specimen | Immediate | Yes      | 6712998 | 7638373 | 867483 | Blood Sample | Single       | In town      | publicAddress | New York     | Residential | Private     | 6N5  | French | 6773800 | New York | New York | privateAddress | Aircraft | NA          | New York |
Scenario Outline:31. (Specimen-Multiple) Create Service Request entering Service info and Service type as "Specimen" as customer admin
	Given launch the application
	When I choose to enter the email <email>
	And I choose to enter the password <password>
	And I choose to click on submit button
	And I choose to enter email <email>
	And I choose to enter password <password>
	And I choose to verify home page
	And I choose to Click on Service Request
	And I choose to Click on Service Request button
	And I choose to select service type <service>
	And I choose to select specimen type <specimenType>
	And I choose to select drop location <droplocation>
	And I choose to select pickup type <type>
	And I choose to enter unosid <unos>
	And I choose to enter tissueid <tissue>
	And I choose to enter matchid <match>
	And I choose to select trip origin transport mode <mode>
	And I choose to create location click and verify
	And I choose to select location name <locationname>
	And I choose to select address type <addresstype>
	And I choose to select address mode <addressmode>
	And I choose to enter street address <street>
	And I choose to enter zipcode <zipcode>
	And I choose to select state <state>
	And I choose to select city <city>
	And I choose to save the location
	And I choose to select trip destinatio transport mode <destmode>
	And I choose to select category <category>
	And I choose to enter instruction <instruction>
	And I choose to select destinations mode <destinationsmode>
	And I choose to save the transaction
	Then I choose to verify the transaction
Examples: 
	| email                                  | password   | customer      | contact    | service  | type      | priority | unos    | tissue  | match    | specimenType | droplocation | dropcategory | mode          | locationname | addresstype | addressmode | code | street | zipcode | state    | city     | destmode       | category | instruction | template | destinationsmode |
	| TACCustAdminTest@trinityairmedical.com | w4@3oNfrE7 | Test_Customer | Anish Dasi | Specimen | Immediate | Yes      | 6712998 | 8798900 | 67188293 | Blood Sample | Multiple     | In town      | publicAddress | New York     | Residential | Private     | 6N5  | French | 6773800 | New York | New York | privateAddress | Aircraft | NA          | New York | public           |

Scenario Outline: 32.Create Service Request entering Service info and Service type as "Team" and entering Trip Info as customer admin
	Given launch the application
	When I choose to enter the email <email>
	And I choose to enter the password <password>
	And I choose to click on submit button
	And I choose to enter email <email>
	And I choose to enter password <password>
	And I choose to verify home page
	And I choose to Click on Service Request
	And I choose to Click on Service Request button
	And I choose to select service type <service>
	And I choose to select team type <team>
	And I choose to select additional equipment <addequipment>
	And I choose to select additional types <addequiptype>
	And I choose to select pickup type <type>
	And I choose to enter unosid <unos>
	And I choose to select ortime and sirens <sirens>
	And I choose to enter tissueid <tissue>
	And I choose to enter matchid <match>
	And I choose to select trip origin transport mode <mode>
	And I choose to create location click and verify
	And I choose to select location name <locationname>
	And I choose to select address type <addresstype>
	And I choose to select address mode <addressmode>
	And I choose to enter street address <street>
	And I choose to enter zipcode <zipcode>
	And I choose to select state <state>
	And I choose to select city <city>
	And I choose to save the location
	And I choose to select trip destinatio transport mode <destmode>
	And I choose to create destination location click and verify
	And I choose to select location name <locationname>
	And I choose to select address type <addresstype>
	And I choose to select address mode <addressmode>
	And I choose to enter destination street address <street>
	And I choose to enter zipcode <zipcode>
	And I choose to select state <state>
	And I choose to select city <city>
	And I choose to save the location
	And I choose to select category <category>
	And I choose to enter instruction <instruction>
	And I choose to save the transaction
	Then I choose to verify the transaction
Examples: 
	| email                                  | password   | customer      | contact    | service | team  | type      | priority | unos    | sirens | tissue  | match     | mode          | locationname | addresstype | addressmode | code | street | zipcode | state    | city     | destmode       | category | instruction | template | addequipment | addequiptype    |
	| TACCustAdminTest@trinityairmedical.com | w4@3oNfrE7 | Test_Customer | Anish Dasi | Team    | Heart | Immediate | Yes      | 6007748 | Yes    | 8723859 | 871982193 | publicAddress | New York     | Residential | Private     | 6N5  | French | 6773800 | New York | New York | privateAddress | Aircraft | NA          | New York | Yes          | Additional Bags |

Scenario Outline: 33.Verifying warning message while entering Trip Info for customer Admin
	Given launch the application
	When I choose to enter the email <email>
	And I choose to enter the password <password>
	And I choose to click on submit button
	And I choose to enter email <email>
	And I choose to enter password <password>
	And I choose to verify home page
	And I choose to Click on Service Request
	And I choose to Click on Service Request button
	And I choose to select service type <service>
	And I choose to select equipment type <equipment>
	And I choose to select pickup type <type>
	And I choose to enter unosid <unos>
	And I choose to select trip origin transport mode <mode>
	And I choose to create location click and verify
	And I choose to select location name <locationname>
	And I choose to select address type <addresstype>
	And I choose to select address mode <addressmode>
	And I choose to enter same street address <street>
	And I choose to enter zipcode <zipcode>
	And I choose to select state <state>
	And I choose to select city <city>
	And I choose to save the location
	Then I choose to verify warning popup of same address
Examples: 
	| email                                  | password   | customer      | contact    | service   | equipment         | type      | priority | unos    | mode          | locationname | addresstype | addressmode | code | street | zipcode | state | city     | destmode       | category | instruction | template |
	| TACCustAdminTest@trinityairmedical.com | w4@3oNfrE7 | Test_Customer | Anish Dasi | Equipment | Medical Equipment | Immediate | Yes      | 6007748 | publicAddress | New York     | Residential | Private     | 6N5  | French | 6773800 | New York | New York | privateAddress | Aircraft | NA       | New York |
Scenario Outline:34. Create Service Request entering Service info and Service type as "Equipment" and entering Trip Info using existing items for customer Admin
	Given launch the application
	When I choose to enter the email <email>
	And I choose to enter the password <password>
	And I choose to click on submit button
	And I choose to enter email <email>
	And I choose to enter password <password>
	And I choose to verify home page
	And I choose to Click on Service Request
	And I choose to Click on Service Request button
	And I choose to select service type <service>
	And I choose to select equipment type <equipment>
	And I choose to select pickup type <type>
	And I choose to enter unosid <unos>
	And I choose to select trip origin transport mode <mode>
	And I choose to select trip destinatio transport mode <destmode>
	And I choose to selectOrigin and destination
	And I choose to select category <category>
	And I choose to enter instruction <instruction>
	And I choose to save the transaction
	Then I choose to verify the transaction
Examples: 
	| email                                  | password   | customer      | contact    | service   | equipment         | type      | priority | unos    | mode          | locationname | addresstype | addressmode | code | street | zipcode | state | city     | destmode       | category | instruction | template |
	| TACCustAdminTest@trinityairmedical.com | w4@3oNfrE7 | Test_Customer | Anish Dasi | Equipment | Medical Equipment | Immediate | Yes      | 6007748 | publicAddress | New York     | Residential | Private     | 6N5  | French | 6773800 | New York | New York | privateAddress | Aircraft | NA       | New York |

#Scenario Outline:35(defect). Create Service Request and add template and save the transaction (Defect due to template field is not available)
#	Given launch the application
#	When I choose to enter the email <email>
#	And I choose to enter the password <password>
#	And I choose to click on submit button
#	And I choose to enter email <email>
#	And I choose to enter password <password>
#	And I choose to verify home page
#	And I choose to Click on Service Request
#	And I choose to Click on Service Request button
#	And I choose to select service type <service>
#	And I choose to select equipment type <equipment>
#	And I choose to select pickup type <type>
#	And I choose to enter unosid <unos>
#	And I choose to select trip origin transport mode <mode>
#	And I choose to select trip destinatio transport mode <destmode>
#	And I choose to selectOrigin and destination
#	And I choose to select category <category>
#	And I choose to enter instruction <instruction>
#	And T choose to enter template name <template>
#	And I choose to save the transaction
#	Then I choose to verify the transaction
#Examples: 
#	| email                                  | password   | customer      | contact    | service   | equipment         | type      | priority | unos    | mode          | locationname | addresstype | addressmode | code | street | zipcode | state | city     | destmode       | category | instruction | template |
#	| TACCustAdminTest@trinityairmedical.com | w4@3oNfrE7 | Test_Customer | Anish Dasi | Equipment | Medical Equipment | Immediate | Yes      | 6007748 | publicAddress | New York     | Residential | Private     | 6N5  | French | 6773800 | New York | New York | privateAddress | Aircraft | NA       | New York |

#Scenario Outline:36(defect, template button is not available). Create Service Request using template flow as customer admin 
#	Given launch the application
#	When I choose to enter the email <email>
#	And I choose to enter the password <password>
#	And I choose to click on submit button
#	And I choose to enter email <email>
#	And I choose to enter password <password>
#	And I choose to verify home page
#	And I choose to Click on Service Request
#	And I choose to Click on Service Request button
#	And I choose to create service request using template <templatecreate>
#	And I choose to save the transaction
#	Then I choose to verify the transaction
#Examples: 
#	| email                                   | password   | customer      | contact    | service   | equipment         | type      | priority | unos    | mode          | locationname | addresstype | addressmode | code | street | zipcode | state    | city     | destmode       | category | instruction | template | templatecreate |
#	|  TACCustAdminTest@trinityairmedical.com | w4@3oNfrE7 | Test_Customer | Anish Dasi | Equipment | Medical Equipment | Immediate | Yes      | 6007748 | publicAddress | New York     | Residential | Private     | 6N5  | French | 6773800 | New York | New York | privateAddress | Aircraft | NA          | New York | Arizona        |
	
Scenario Outline:37. Create Service Request by adding existing items and while adding notes and files as customer admin
	Given launch the application
	When I choose to enter the email <email>
	And I choose to enter the password <password>
	And I choose to click on submit button
	And I choose to enter email <email>
	And I choose to enter password <password>
	And I choose to verify home page
	And I choose to Click on Service Request
	And I choose to Click on Service Request button
	And I choose to select service type <service>
	And I choose to select equipment type <equipment>
	And I choose to select pickup type <type>
	And I choose to enter unosid <unos>
	And I choose to select trip origin transport mode <mode>
	And I choose to select trip destinatio transport mode <destmode>
	And I choose to selectOrigin and destination
	And I choose to select category <category>
	And I choose to enter instruction <instruction>
	And I choose to add notes <notes>
	And I choose to add file
	And I choose to save the transaction
	Then I choose to verify the transaction
Examples: 
	| email                                   | password   | customer      | contact    | service   | equipment         | type      | priority | unos    | mode          | locationname | addresstype | addressmode | code | street | zipcode | state    | city     | destmode       | category | instruction | template | notes   |
	|  TACCustAdminTest@trinityairmedical.com | w4@3oNfrE7 | Test_Customer | Anish Dasi | Equipment | Medical Equipment | Immediate | Yes      | 6007748 | publicAddress | New York     | Residential | Private     | 6N5  | French | 6773800 | New York | New York | privateAddress | Aircraft | NA          | New York | Pick up |
#Different Job Types
Scenario Outline: 38.(Equipment-Immediate-Public)Create Service Request entering Service info and Service type as "Equipment" and entering Trip Info and jobtype as Air Only
	Given launch the application
	When I choose to enter the email <email>
	And I choose to enter the password <password>
	And I choose to click on submit button
	And I choose to enter email <email>
	And I choose to enter password <password>
	And I choose to verify home page
	And I choose to Click on Service Request
	And I choose to Click on Service Request button
	And I choose to select service type <service>
	And I choose to select equipment type <equipment>
	And I choose to select pickup type <type>
	And I choose to enter unosid <unos>
	And I choose to enter tissueid <tissue>
	And I choose to enter matchid <match>
	And I choose to select jobtype <job>
	And I choose to select trip origin transport mode <mode>
	And I choose to create location click and verify
	And I choose to select location name <locationname>
	And I choose to select address type <addresstype>
	And I choose to select address mode <addressmode>
	And I choose to enter street address <street>
	And I choose to enter zipcode <zipcode>
	And I choose to select state <state>
	And I choose to select city <city>
	And I choose to save the location
	And I choose to select trip destinatio transport mode <destmode>
	And I choose to create destination location click and verify
	And I choose to select location name <locationname>
	And I choose to select address type <addresstype>
	And I choose to select address mode <addressmode>
	And I choose to enter destination street address <street>
	And I choose to enter zipcode <zipcode>
	And I choose to select state <state>
	And I choose to select city <city>
	And I choose to save the location
	And I choose to select category <category>
	And I choose to enter instruction <instruction>
	And I choose to save the transaction
	Then I choose to verify the transaction
Examples: 
	| email                                  | password   | customer      | contact    | service   | equipment         | type      | priority | unos    | tissue   | match   | mode          | locationname | addresstype | addressmode | code | street | zipcode | state    | city     | destmode      | category | instruction | template | job      |
	| TACCustAdminTest@trinityairmedical.com | w4@3oNfrE7 | Test_Customer | Anish Dasi | Equipment | Medical Equipment | Immediate | Yes      | 6007748 | 79898978 | 7886089 | publicAddress | New York     | Residential | Public      | 6N5  | French | 6773800 | New York | New York | publicAddress | Aircraft | NA          | New York | Air Only |

Scenario Outline: 39.(Next Flight Out-Immediate-Airport)Create Service Request entering Service info and Service type as "Next flight out" and jobtype as Ground Only
	Given launch the application
	When I choose to enter the email <email>
	And I choose to enter the password <password>
	And I choose to click on submit button
	And I choose to enter email <email>
	And I choose to enter password <password>
	And I choose to verify home page
	And I choose to Click on Service Request
	And I choose to Click on Service Request button
	And I choose to select service type <service>
	And I choose to select next flight <nextflight>
	And I choose to select pickup type <type>
	And I choose to enter unosid <unos>
	And I choose to enter tissueid <tissue>
	And I choose to select jobtype <job>
	And I choose to select trip origin transport mode <mode>
	And I choose to select tripinfo airport code <code>
	And I choose to create location click and verify
	And I choose to select location name <locationname>
	And I choose to select address type <addresstype>
	And I choose to select address mode <addressmode>
	And I choose to select airport code <code>
	And I choose to enter street address <street>
	And I choose to enter zipcode <zipcode>
	And I choose to select state <state>
	And I choose to select city <city>
	And I choose to save the location
	And I choose to select trip destinatio transport mode <destmode>
	And I choose to create destination location click and verify
	And I choose to select location name <locationname>
	And I choose to select address type <addresstype>
	And I choose to select address mode <addressmode>
	And I choose to select airport code <code>
	And I choose to enter destination street address <street>
	And I choose to enter zipcode <zipcode>
	And I choose to select state <state>
	And I choose to select city <city>
	And I choose to save the location
	And I choose to select category <category>
	And I choose to enter instruction <instruction>
	And I choose to save the transaction
	Then I choose to verify the transaction
Examples: 
	| email                                  | password   | customer      | contact    | service         | type      | priority | unos    | tissue   | medigo | jobid     | trackingid | nextflight   | mode           | locationname | addresstype | addressmode | code | street | zipcode | state    | city     | destmode       | category | instruction | template | job         |
	| TACCustAdminTest@trinityairmedical.com | w4@3oNfrE7 | Test_Customer | Anish Dasi | Next Flight Out | Immediate | Yes      | 6712748 | 76289752 | 764579 | 674889894 | 646822     | Blood Sample | airportAddress | New York     | Residential | Airport     | 6N5  | French | 6773800 | New York | New York | privateAddress | Aircraft | NA          | New York | Ground Only |

##############################################################################################################################################
#Coordinator role
Scenario Outline: 40.(Equipment-Immediate-Public)Create Service Request entering Service info and Service type as "Equipment" and entering Trip Info as coordinator role
	Given launch the application
	When I choose to enter the email <email>
	And I choose to enter the password <password>
	And I choose to click on submit button
	And I choose to enter email <email>
	And I choose to enter password <password>
	And I choose to verify home page
	And I choose to Click on Service Request
	And I choose to Click on Service Request button
	And I choose to select customer details <customer>
	And I choose to select contact details <contact>
	And I choose to select service type <service>
	And I choose to select equipment type <equipment>
	And I choose to select pickup type <type>
	And I choose to select priority type <priority>
	And I choose to enter unosid <unos>
	And I choose to enter tissueid <tissue>
	And I choose to enter matchid <match>
	And I choose to select trip origin transport mode <mode>
	And I choose to create location click and verify
	And I choose to select location name <locationname>
	And I choose to select address type <addresstype>
	And I choose to select address mode <addressmode>
	And I choose to enter street address <street>
	And I choose to enter zipcode <zipcode>
	And I choose to select state <state>
	And I choose to select city <city>
	And I choose to save the location
	And I choose to select trip destinatio transport mode <destmode>
	And I choose to create destination location click and verify
	And I choose to select location name <locationname>
	And I choose to select address type <addresstype>
	And I choose to select address mode <addressmode>
	And I choose to enter destination street address <street>
	And I choose to enter zipcode <zipcode>
	And I choose to select state <state>
	And I choose to select city <city>
	And I choose to save the location
	And I choose to select category <category>
	And I choose to enter instruction <instruction>
	And I choose to save the transaction
	Then I choose to verify the transaction
Examples:  
	| email                                    | password    | customer      | contact    | service   | equipment         | type      | priority | unos    | tissue   | match   | mode          | locationname | addresstype | addressmode | code | street | zipcode | state    | city     | destmode      | category | instruction | template |
	| TACCoordinatorTest@trinityairmedical.com | Yp@3tAHwB!k | Test_Customer | Anish Dasi | Equipment | Medical Equipment | Immediate | Yes      | 6007748 | 79898978 | 7886089 | publicAddress | New York     | Residential | Public      | 6N5  | French | 6773800 | New York | New York | publicAddress | Aircraft | NA          | New York |
#custcoordinator 
Scenario Outline: 41.(Next Flight Out-Immediate-Airport)Create Service Request entering Service info and Service type as "Next flight out" as customer coordinator role
	Given launch the application
	When I choose to enter the email <email>
	And I choose to enter the password <password>
	And I choose to click on submit button
	And I choose to enter email <email>
	And I choose to enter password <password>
	And I choose to verify home page
	And I choose to Click on Service Request
	And I choose to Click on Service Request button
	And I choose to select service type <service>
	And I choose to select next flight <nextflight>
	And I choose to select pickup type <type>
	And I choose to enter unosid <unos>
	And I choose to enter tissueid <tissue>
	And I choose to select trip origin transport mode <mode>
	And I choose to select tripinfo airport code <code>
	And I choose to create location click and verify
	And I choose to select location name <locationname>
	And I choose to select address type <addresstype>
	And I choose to select address mode <addressmode>
	And I choose to select airport code <code>
	And I choose to enter street address <street>
	And I choose to enter zipcode <zipcode>
	And I choose to select state <state>
	And I choose to select city <city>
	And I choose to save the location
	And I choose to select trip destinatio transport mode <destmode>
	And I choose to create destination location click and verify
	And I choose to select location name <locationname>
	And I choose to select address type <addresstype>
	And I choose to select address mode <addressmode>
	And I choose to select airport code <code>
	And I choose to enter destination street address <street>
	And I choose to enter zipcode <zipcode>
	And I choose to select state <state>
	And I choose to select city <city>
	And I choose to save the location
	And I choose to select category <category>
	And I choose to enter instruction <instruction>
	And I choose to save the transaction
	Then I choose to verify the transaction
Examples: 
	| email                                        | password   | customer      | contact    | service         | type      | priority | unos    | tissue   | medigo | jobid     | trackingid | nextflight   | mode          | locationname | addresstype | addressmode | code | street | zipcode | state    | city     | destmode       | category | instruction | template |
	| TACCustCoordinatorTest@trinityairmedical.com | pF4dGYoZmi | Test_Customer | Anish Dasi | Next Flight Out | Immediate | Yes      | 6712748 | 76289752 | 764579 | 674889894 | 646822     | Blood Sample | airportAddress | New York     | Residential | Airport     | 6N5  | French | 6773800 | New York | New York | privateAddress | Aircraft | NA          | New York |

	
##################################################################################################################################################################
#Add Leg information
	Scenario Outline: 42.To Verify the success of the Coordinator assignment 
	Given launch the application
	When I choose to enter the email <email>
	And I choose to enter the password <password>
	And I choose to click on submit button
	And I choose to enter email <email>
	And I choose to enter password <password>
	And I choose to verify home page
	And I choose to Click on Service Request
	And I choose to Click on Service Request button
	And I choose to select customer details <customer>
	And I choose to select contact details <contact>
	And I choose to select service type <service>
	And I choose to select equipment type <equipment>
	And I choose to select pickup type <type>
	And I choose to select priority type <priority>
	And I choose to enter unosid <unos>
	And I choose to enter tissueid <tissue>
	And I choose to enter matchid <match>
	And I choose to select trip origin transport mode <mode>
	And I choose to Enter Origin loction <Origin>
	And I choose to select trip destinatio transport mode <destmode>
	And I choose to Enter Desti loction <Desti>
	And I choose to select category <category>
	And I choose to enter instruction <instruction>
	And I choose to save the transaction
	Then I choose to verify the transaction
	And I choose to Select Coordinator <coordinator>
	Then I choose to verify the success message for Assign Coordinator 
Examples: 
	| email                                        | password   | customer      | contact    | service   | equipment         | type      | priority | unos    | tissue   | match   | mode          | addresstype | addressmode | destmode      | category | instruction | Origin                        | Desti          | coordinator     |
	| TACExAdministratorTest@trinityairmedical.com | YQAQ7&*fy! | Test_Customer | Anish Dasi | Equipment | Medical Equipment | Immediate | Yes      | 6007748 | 79898978 | 7886089 | publicAddress | Residential | Public      | publicAddress | Aircraft | NA          | Idaho Regional Medical Center | St Lukes Boise | service account |

Scenario Outline: 43.(Equipment-Immediate-Public) To validate the functionality of the add leg button after the Service Request has been created.
	Given launch the application
	When I choose to enter the email <email>
	And I choose to enter the password <password>
	And I choose to click on submit button
	And I choose to enter email <email>
	And I choose to enter password <password>
	And I choose to verify home page
	And I choose to Click on Service Request
	And I choose to Click on Service Request button
	And I choose to select customer details <customer>
	And I choose to select contact details <contact>
	And I choose to select service type <service>
	And I choose to select equipment type <equipment>
	And I choose to select pickup type <type>
	And I choose to select priority type <priority>
	And I choose to enter unosid <unos>
	And I choose to enter tissueid <tissue>
	And I choose to enter matchid <match>
	And I choose to select trip origin transport mode <mode>
	And I choose to Enter Origin loction <Origin>
	And I choose to select trip destinatio transport mode <destmode>
	And I choose to Enter Desti loction <Desti>
	And I choose to select category <category>
	And I choose to enter instruction <instruction>
	And I choose to save the transaction
	Then I choose to verify the transaction
	And I choose to Select Coordinator <coordinator>
	Then I choose to verify the success message for Assign Coordinator 
	And I choose to Click on Add leg 
	And I choose to Select Transport Type <Transport>
	And I choose to Select Direction <Direction>
	#And I choose to select Origin Address type <OriginAddType>
	And I choose to select Destination Address type<DestinationAddType>
	#And I choose to Enter Origin location <OriginLeg1>
	And I choose to Enter Desti location <DestiLeg1>
	And I choose to Click on Add button
	Then I choose to verify the transaction

Examples: 
	| email                                        | password   | customer      | contact    | service   | equipment         | type      | priority | unos    | tissue   | match   | mode          | addresstype | addressmode | destmode      | category | instruction | Origin                        | Desti          | coordinator     | Transport | Direction | OriginAddType | DestinationAddType | DestiLeg1                     |
	| TACExAdministratorTest@trinityairmedical.com | YQAQ7&*fy! | Test_Customer | Anish Dasi | Equipment | Medical Equipment | Immediate | Yes      | 6007748 | 79898978 | 7886089 | publicAddress | Residential | public      | publicAddress | Aircraft | NA          | Idaho Regional Medical Center | St Lukes Boise | service account | Ground    | Outbound  | Public        | Public             | Idaho Falls Regional Airport  |


Scenario Outline: 44.(Internal-Immediate-Public) To validate the functionality of the add leg button after the Service Request has been created.
	Given launch the application
	When I choose to enter the email <email>
	And I choose to enter the password <password>
	And I choose to click on submit button
	And I choose to enter email <email>
	And I choose to enter password <password>
	And I choose to verify home page
	And I choose to Click on Service Request
	And I choose to Click on Service Request button
	And I choose to select customer details <customer>
	And I choose to select contact details <contact>
	And I choose to select service type <service>
	And I choose to select personnel service <personnelservice>
	And I choose to select pickup type <type>
	And I choose to select pickup time
	And I choose to select priority type <priority>
	And I choose to enter unosid <unos>
	And I choose to enter tissueid <tissue>
	And I choose to enter matchid <match>
	And I choose to select trip origin transport mode <mode>
	And I choose to create location click and verify
	And I choose to select location name <locationname>
	And I choose to select address type <addresstype>
	And I choose to select address mode <addressmode>
	And I choose to enter street address <street>
	And I choose to enter zipcode <zipcode>
	And I choose to select state <state>
	And I choose to select city <city>
	And I choose to save the location
	And I choose to select trip destinatio transport mode <destmode>
	And I choose to create destination location click and verify
	And I choose to select location name <locationname>
	And I choose to select address type <addresstype>
	And I choose to select address mode <addressmode>
	And I choose to enter destination street address <street>
	And I choose to enter zipcode <zipcode>
	And I choose to select state <state>
	And I choose to select city <city>
	And I choose to save the location
	And I choose to select category <category>
	And I choose to enter instruction <instruction>
	And I choose to save the transaction
	Then I choose to verify the transaction for add leg
	And I choose to Select Coordinator <coordinator>
	Then I choose to verify the success message for Assign Coordinator 
	And I choose to Click on Add leg 
	And I choose to Select Transport Type <Transport>
	And I choose to Select Direction <Direction>
	And I choose to select Destination Address type<DestinationAddType>
	And I choose to Enter Desti location <DestiLeg1>
	And I choose to Click on Add button
	Then I choose to verify the transaction for add leg
Examples: 
	| email                                        | password   | customer      | contact    | service  | type   | priority | unos    | tissue  | match  | personnelservice | mode          | locationname | addresstype | addressmode | code | street | zipcode | state    | city     | destmode       | category | instruction | template | coordinator     | Transport | Direction | OriginAddType | DestinationAddType | DestiLeg1                     |
	| TACExAdministratorTest@trinityairmedical.com | YQAQ7&*fy! | Test_Customer | Anish Dasi | Internal | Future | No       | 6747748 | 6789776 | 877679 | Auto Body Repair | privateAddress | New York     | Residential | Private     | 6N5  | French | 6773800 | New York | New York | privateAddress | Aircraft | NA          | New York |service account | Ground    | Outbound  | Public        | Public             | Idaho Falls Regional Airport  |
#@CreateSRflow
Scenario Outline: 45.(Internal-Immediate-Public) To validate the functionality of the add leg button after the Service Request has been created.
	Given launch the application
	When I choose to enter the email <email>
	And I choose to enter the password <password>
	And I choose to click on submit button
	And I choose to enter email <email>
	And I choose to enter password <password>
	And I choose to verify home page
	And I choose to Click on Service Request
	And I choose to Click on Service Request button
	And I choose to select customer details <customer>
	And I choose to select contact details <contact>
	And I choose to select service type <service>
	And I choose to select personnel service <personnelservice>
	And I choose to select pickup type <type>
	And I choose to select pickup time
	And I choose to select priority type <priority>
	And I choose to enter unosid <unos>
	And I choose to enter tissueid <tissue>
	And I choose to enter matchid <match>
	And I choose to select trip origin transport mode <mode>
	And I choose to create location click and verify
	And I choose to select location name <locationname>
	And I choose to select address type <addresstype>
	And I choose to select address mode <addressmode>
	And I choose to enter street address <street>
	And I choose to enter zipcode <zipcode>
	And I choose to select state <state>
	And I choose to select city <city>
	And I choose to save the location
	And I choose to select trip destinatio transport mode <destmode>
	And I choose to create destination location click and verify
	And I choose to select location name <locationname>
	And I choose to select address type <addresstype>
	And I choose to select address mode <addressmode>
	And I choose to enter destination street address <street>
	And I choose to enter zipcode <zipcode>
	And I choose to select state <state>
	And I choose to select city <city>
	And I choose to save the location
	And I choose to select category <category>
	And I choose to enter instruction <instruction>
	And I choose to save the transaction
	Then I choose to verify the transaction
	And I choose to Select Coordinator <coordinator>
	Then I choose to verify the success message for Assign Coordinator 
	And I choose to Click on Add leg 
	And I choose to Select Transport Type <Transport>
	And I choose to Select Direction <Direction>
	And I choose to select Destination Address type<DestinationAddType>
	And I choose to Enter Desti location <DestiLeg1>
	And I choose to Click on Add button
	Then  I choose to verify the transaction for add leg
	And I choose to Click on Add leg 
	And I choose to Select Transport Type <Transport>
	And I choose to Select Direction <Direction>
	And I choose to select Destination Address type<DestinationAddType>
	And I choose to Enter Desti location <DestiLeg2>
	And I choose to Click on Add button
	Then I choose to verify the transaction for add leg
Examples: 
	| email                                        | password   | customer      | contact    | service  | type   | priority | unos    | tissue  | match  | personnelservice | mode           | locationname | addresstype | addressmode | code | street | zipcode | state    | city     | destmode       | category | instruction | template | coordinator     | Transport | Direction | OriginAddType | DestinationAddType | DestiLeg1                    | DestiLeg2 |
	| TACExAdministratorTest@trinityairmedical.com | YQAQ7&*fy! | Test_Customer | Anish Dasi | Internal | Future | No       | 6747748 | 6789776 | 877679 | Auto Body Repair | privateAddress | New York     | Residential | Private     | 6N5  | French | 6773800 | New York | New York | privateAddress | Aircraft | NA          | New York | service account | Ground    | Outbound  | Public        | Public             | Idaho Falls Regional Airport | Trinity   |

@CreateSRflow
	Scenario Outline: 46.(400error)(Specimen-Multiple)After the Service Request has been created, validate the functionality of adding multiple legs and then assign the legs to the internal driver.
	Given launch the application
	When I choose to enter the email <email>
	And I choose to enter the password <password>
	And I choose to click on submit button
	And I choose to enter email <email>
	And I choose to enter password <password>
	And I choose to verify home page
	And I choose to Click on Service Request
	And I choose to Click on Service Request button
	And I choose to select customer details <customer>
	And I choose to select contact details <contact>
	And I choose to select service type <service>
	And I choose to select specimen type <specimenType>
	And I choose to select drop location <droplocation>
	And I choose to select drop category <dropcategory>
	And I choose to select pickup type <type>
	And I choose to select priority type <priority>
	And I choose to enter unosid <unos>
	And I choose to enter tissueid <tissue>
	And I choose to enter matchid <match>
	And I choose to select trip origin transport mode <mode>
	And I choose to create location click and verify
	And I choose to select location name <locationname>
	And I choose to select address type <addresstype>
	And I choose to select address mode <addressmode>
	And I choose to enter street address <street>
	And I choose to enter zipcode <zipcode>
	And I choose to select state <state>
	And I choose to select city <city>
	And I choose to save the location
	And I choose to select trip destinatio transport mode <destmode>
	And I choose to select category <category>
	And I choose to enter instruction <instruction>
	And I choose to select destinations mode <destinationsmode>
	And I choose to save that transaction
	Then I choose to verify the transaction
	And I choose to Select Coordinator <coordinator>
	Then I choose to verify the success message for Assign Coordinator 
	And I choose to Click on Add leg 
	And I choose to Select Transport Type <Transport>
	And I choose to Select Direction <Direction>
	And I choose to select Destination Address type<DestinationAddType>
	And I choose to Enter Desti location <DestiLeg1>
	And I choose to Click on Add leg 
	Then I choose to verify the transaction for add leg
	And I choose to Select Transport Type <Transport>
	And I choose to Select Direction <Direction>
	And I choose to select Destination Address type<DestinationAddType>
	And I choose to Enter Desti location <DestiLeg2>
	And I choose to Click on Add leg 
	Then I choose to verify the transaction for add leg
	Then I choose to select the legs and Assign to Internal Driver
	Then I choose to verify the success message for Leg Assignment 

Examples: 
	| email                                        | password   | customer      | contact    | service  | type      | priority | unos    | tissue  | match    | specimenType | droplocation | dropcategory | mode          | locationname | addresstype | addressmode | code | street | zipcode | state    | city     | destmode       | category | instruction | template | destinationsmode | coordinator     | Transport | Direction | OriginAddType | DestinationAddType | DestiLeg1                    | DestiLeg2 |
	| TACExAdministratorTest@trinityairmedical.com | YQAQ7&*fy! | Test_Customer | Anish Dasi | Specimen | Immediate | Yes      | 6712998 | 8798900 | 67188293 | Blood Sample | Multiple     | In town      | publicAddress | New York     | Residential | Public      | 6N5  | French | 6773800 | New York | New York | privateAddress | Aircraft | NA          | New York | public           | service account | Ground    | Outbound  | Public        | Public             | Idaho Falls Regional Airport | Trinity   |

@CreateSRflow
Scenario Outline: 47.	(Equipment-Immediate-Public)After the Service Request has been created, validate the functionality of adding multiple legs and then assign the legs to the internal driver.
	Given launch the application 
	When I choose to enter the email <email>
	And I choose to enter the password <password>
	And I choose to click on submit button
	And I choose to enter email <email>
	And I choose to enter password <password>
	And I choose to verify home page
	And I choose to Click on Service Request
	And I choose to Click on Service Request button
	And I choose to select customer details <customer>
	And I choose to select contact details <contact>
	And I choose to select service type <service>
	And I choose to select equipment type <equipment>
	And I choose to select pickup type <type>
	And I choose to select priority type <priority>
	And I choose to enter unosid <unos>
	And I choose to enter tissueid <tissue>
	And I choose to enter matchid <match>
	And I choose to select trip origin transport mode <mode>
	And I choose to Enter Origin loction <Origin>
	And I choose to select trip destinatio transport mode <destmode>
	And I choose to Enter Desti loction <Desti>
	And I choose to select category <category>
	And I choose to enter instruction <instruction>
	And I choose to save the transaction
	Then I choose to verify the transaction
	And I choose to Select Coordinator <coordinator>
	Then I choose to verify the success message for Assign Coordinator 
	And I choose to Click on Add leg 
	And I choose to Select Transport Type <Transport>
	And I choose to Select Direction <Direction>
	And I choose to select Destination Address type<DestinationAddType>
	And I choose to Enter Desti location <DestiLeg1>
	And I choose to Click on Add button
	Then I choose to verify the transaction for add leg
	And I choose to Click on Add leg 
	And I choose to Select Transport Type <Transport>
	And I choose to Select Direction <Direction>
	And I choose to select Destination Address type<DestinationAddType>
	And I choose to Enter Desti location <DestiLeg2>
	And I choose to Click on Add button
	Then I choose to verify the transaction for add leg
	Then I choose to select the legs and Assign to Internal Driver
	Then I choose to verify the success message for Leg Assignment 


Examples: 
	| email                                        | password   | customer      | contact    | service   | equipment         | type      | priority | unos    | tissue   | match   | mode          | addresstype | addressmode | destmode      | category | instruction | Origin                        | Desti          | coordinator     | Transport | Direction | OriginAddType | DestinationAddType | DestiLeg1                    | DestiLeg2 |
	| TACExAdministratorTest@trinityairmedical.com | YQAQ7&*fy! | Test_Customer | Anish Dasi | Equipment | Medical Equipment | Immediate | Yes      | 6007748 | 79898978 | 7886089 | publicAddress | Residential | public      | publicAddress | Aircraft | NA          | Idaho Regional Medical Center | St Lukes Boise | service account | Ground    | Outbound  | Public        | Public             | Idaho Falls Regional Airport | Trinity   |

@CreateSRflow
	Scenario Outline: 48.(Internal-Immediate-Public)After the Service Request has been created, validate the functionality of adding multiple legs and then assign the legs to the internal driver.
	Given launch the application
	When I choose to enter the email <email>
	And I choose to enter the password <password>
	And I choose to click on submit button
	And I choose to enter email <email>
	And I choose to enter password <password>
	And I choose to verify home page
	And I choose to Click on Service Request
	And I choose to Click on Service Request button
	And I choose to select customer details <customer>
	And I choose to select contact details <contact>
	And I choose to select service type <service>
	And I choose to select personnel service <personnelservice>
	And I choose to select pickup type <type>
	And I choose to select pickup time
	And I choose to select priority type <priority>
	And I choose to enter unosid <unos>
	And I choose to enter tissueid <tissue>
	And I choose to enter matchid <match>
	And I choose to select trip origin transport mode <mode>
	And I choose to create location click and verify
	And I choose to select location name <locationname>
	And I choose to select address type <addresstype>
	And I choose to select address mode <addressmode>
	And I choose to enter street address <street>
	And I choose to enter zipcode <zipcode>
	And I choose to select state <state>
	And I choose to select city <city>
	And I choose to save the location
	And I choose to select trip destinatio transport mode <destmode>
	And I choose to create destination location click and verify
	And I choose to select location name <locationname>
	And I choose to select address type <addresstype>
	And I choose to select address mode <addressmode>
	And I choose to enter destination street address <street>
	And I choose to enter zipcode <zipcode>
	And I choose to select state <state>
	And I choose to select city <city>
	And I choose to save the location
	And I choose to select category <category>
	And I choose to enter instruction <instruction>
	And I choose to save the transaction
	Then I choose to verify the transaction
	And I choose to Select Coordinator <coordinator>
	Then I choose to verify the success message for Assign Coordinator 
	And I choose to Click on Add leg 
	And I choose to Select Transport Type <Transport>
	And I choose to Select Direction <Direction>
	And I choose to select Destination Address type<DestinationAddType>
	And I choose to Enter Desti location <DestiLeg1>
	And I choose to Click on Add button
	Then  I choose to verify the transaction for add leg
	And I choose to Click on Add leg 
	And I choose to Select Transport Type <Transport>
	And I choose to Select Direction <Direction>
	And I choose to select Destination Address type<DestinationAddType>
	And I choose to Enter Desti location <DestiLeg2>
	And I choose to Click on Add button
	Then I choose to verify the transaction for add leg
	Then I choose to select the legs and Assign to Internal Driver
	Then I choose to verify the success message for Leg Assignment 

Examples: 
	| email                                        | password   | customer      | contact    | service  | type   | priority | unos    | tissue  | match  | personnelservice | mode           | locationname | addresstype | addressmode | code | street | zipcode | state    | city     | destmode       | category | instruction | template | coordinator     | Transport | Direction | OriginAddType | DestinationAddType | DestiLeg1                    | DestiLeg2 |
	| TACExAdministratorTest@trinityairmedical.com | YQAQ7&*fy! | Test_Customer | Anish Dasi | Internal | Future | No       | 6747748 | 6789776 | 877679 | Auto Body Repair | privateAddress | New York     | Residential | Private     | 6N5  | French | 6773800 | New York | New York | privateAddress | Aircraft | NA          | New York | service account | Ground    | Outbound  | Public        | Public             | Idaho Falls Regional Airport | Trinity   |

@CreateSRflow
	Scenario Outline: 49.(Next Flight Out-Immediate-Airport)After the Service Request has been created, validate the functionality of adding multiple legs and then assign the legs to the internal driver.
	Given launch the application
	When I choose to enter the email <email>
	And I choose to enter the password <password>
	And I choose to click on submit button
	And I choose to enter email <email>
	And I choose to enter password <password>
	And I choose to verify home page
	And I choose to Click on Service Request
	And I choose to Click on Service Request button
	And I choose to select customer details <customer>
	And I choose to select contact details <contact>
	And I choose to select service type <service>
	And I choose to select next flight <nextflight>
	And I choose to select pickup type <type>
	And I choose to select priority type <priority>
	And I choose to enter unosid <unos>
	And I choose to enter tissueid <tissue>
	And I choose to enter medigo <medigo>
	And I choose to enter jobid <jobid>
	And I choose to enter trackingid <trackingid>
	And I choose to select trip origin transport mode <mode>
	And I choose to select tripinfo airport code <code>
	And I choose to create location click and verify
	And I choose to select location name <locationname>
	And I choose to select address type <addresstype>
	And I choose to select address mode <addressmode>
	And I choose to select airport code <code>
	And I choose to enter street address <street>
	And I choose to enter zipcode <zipcode>
	And I choose to select state <state>
	And I choose to select city <city>
	And I choose to save the location
	And I choose to select trip destinatio transport mode <destmode>
	And I choose to create destination location click and verify
	And I choose to select location name <locationname>
	And I choose to select address type <addresstype>
	And I choose to select address mode <addressmode>
	And I choose to select airport code <code>
	And I choose to enter destination street address <street>
	And I choose to enter zipcode <zipcode>
	And I choose to select state <state>
	And I choose to select city <city>
	And I choose to save the location
	And I choose to select category <category>
	And I choose to enter instruction <instruction>
	And I choose to save the transaction
	Then I choose to verify the transaction
	And I choose to Select Coordinator <coordinator>
	Then I choose to verify the success message for Assign Coordinator 
	And I choose to Click on Add leg 
	And I choose to Select Transport Type <Transport>
	And I choose to Select Direction <Direction>
	And I choose to select Destination Address type<DestinationAddType>
	And I choose to Enter Desti location <DestiLeg1>
	And I choose to Click on Add button
	Then  I choose to verify the transaction for add leg
	And I choose to Click on Add leg 
	And I choose to Select Transport Type <Transport>
	And I choose to Select Direction <Direction>
	And I choose to select Destination Address type<DestinationAddType>
	And I choose to Enter Desti location <DestiLeg2>
	And I choose to Click on Add button
	Then I choose to verify the transaction for add leg
	Then I choose to select the legs and Assign to Internal Driver
	Then I choose to verify the success message for Leg Assignment 

Examples: 
	| email                                        | password   | customer      | contact    | service         | type      | priority | unos    | tissue   | medigo | jobid     | trackingid | nextflight   | mode          | locationname | addresstype | addressmode | code | street | zipcode | state    | city     | destmode       | category | instruction | template |coordinator     | Transport | Direction | OriginAddType | DestinationAddType | DestiLeg1                    | DestiLeg2 |
	| TACExAdministratorTest@trinityairmedical.com | YQAQ7&*fy! | Test_Customer | Anish Dasi | Next Flight Out | Immediate | Yes      | 6712748 | 76289752 | 764579 | 674889894 | 646822     | Blood Sample | airportAddress | New York     | Residential | Airport     | 6N5  | French | 6773800 | New York | New York | privateAddress | Aircraft | NA          | New York |service account | Ground    | Outbound  | Public        | Public             | Idaho Falls Regional Airport | Trinity   |

@CreateSRflow
Scenario Outline:50. (Organ) After the Service Request has been created, validate the functionality of adding multiple legs and then assign the legs to the internal driver.
	Given launch the application
	When I choose to enter the email <email>
	And I choose to enter the password <password>
	And I choose to click on submit button
	And I choose to enter email <email>
	And I choose to enter password <password>
	And I choose to verify home page
	And I choose to Click on Service Request
	And I choose to Click on Service Request button
	And I choose to select customer details <customer>
	And I choose to select contact details <contact>
	And I choose to select service type <service>
	And I choose to select organ type <organType>
	And I choose to select ortime and sirens <sirens>
	And I choose to select pickup type <type>
	And I choose to select priority type <priority>
	And I choose to enter unosid <unos>
	And I choose to enter tissueid <tissue>
	And I choose to enter matchid <match>
	And I choose to select trip origin transport mode <mode>
	And I choose to create location click and verify
	And I choose to select location name <locationname>
	And I choose to select address type <addresstype>
	And I choose to select address mode <addressmode>
	And I choose to enter street address <street>
	And I choose to enter zipcode <zipcode>
	And I choose to select state <state>
	And I choose to select city <city>
	And I choose to save the location
	And I choose to select trip destinatio transport mode <destmode>
	And I choose to create destination location click and verify
	And I choose to select location name <locationname>
	And I choose to select address type <addresstype>
	And I choose to select address mode <addressmode>
	And I choose to enter destination street address <street>
	And I choose to enter zipcode <zipcode>
	And I choose to select state <state>
	And I choose to select city <city>
	And I choose to save the location
	And I choose to select category <category>
	And I choose to enter instruction <instruction>
	And I choose to save the transaction
	Then I choose to verify the transaction
	And I choose to Select Coordinator <coordinator>
	Then I choose to verify the success message for Assign Coordinator 
	And I choose to Click on Add leg 
	And I choose to Select Transport Type <Transport>
	And I choose to Select Direction <Direction>
	And I choose to select Destination Address type<DestinationAddType>
	And I choose to Enter Desti location <DestiLeg1>
	And I choose to Click on Add button
	Then  I choose to verify the transaction for add leg
	And I choose to Click on Add leg 
	And I choose to Select Transport Type <Transport>
	And I choose to Select Direction <Direction>
	And I choose to select Destination Address type<DestinationAddType>
	And I choose to Enter Desti location <DestiLeg2>
	And I choose to Click on Add button
	Then I choose to verify the transaction for add leg
	Then I choose to select the legs and Assign to Internal Driver
	Then I choose to verify the success message for Leg Assignment 

Examples: 
	| email                                        | password   | customer      | contact    | service | type      | priority | unos    | tissue | match  | organType   | sirens | mode          | locationname | addresstype | addressmode | code | street | zipcode | state    | city     | destmode       | category | instruction | template |coordinator     | Transport | Direction | OriginAddType | DestinationAddType | DestiLeg1                    | DestiLeg2 |
	| TACExAdministratorTest@trinityairmedical.com | YQAQ7&*fy! | Test_Customer | Anish Dasi | Organ   | Immediate | Yes      | 6712998 | 746619 | 378192 | Kidney Left | Yes    | publicAddress | New York     | Residential | Private     | 6N5  | French | 6773800 | New York | New York | privateAddress | Aircraft | NA          | New York |service account | Ground    | Outbound  | Public        | Public             | Idaho Falls Regional Airport | Trinity   |
@CreateSRflow
Scenario Outline:51. (Team) After the Service Request has been created, validate the functionality of adding multiple legs and then assign the legs to the internal driver.
	Given launch the application
	When I choose to enter the email <email>
	And I choose to enter the password <password>
	And I choose to click on submit button
	And I choose to enter email <email>
	And I choose to enter password <password>
	And I choose to verify home page
	And I choose to Click on Service Request
	And I choose to Click on Service Request button
	And I choose to select customer details <customer>
	And I choose to select contact details <contact>
	And I choose to select service type <service>
	And I choose to select team type <team>
	And I choose to select additional equipment <addequipment>
	And I choose to select additional types <addequiptype>
	And I choose to select pickup type <type>
	And I choose to enter unosid <unos>
	And I choose to select ortime and sirens <sirens>
	And I choose to enter tissueid <tissue>
	And I choose to enter matchid <match>
	And I choose to select trip origin transport mode <mode>
	And I choose to create location click and verify
	And I choose to select location name <locationname>
	And I choose to select address type <addresstype>
	And I choose to select address mode <addressmode>
	And I choose to enter street address <street>
	And I choose to enter zipcode <zipcode>
	And I choose to select state <state>
	And I choose to select city <city>
	And I choose to save the location
	And I choose to select trip destinatio transport mode <destmode>
	And I choose to create destination location click and verify
	And I choose to select location name <locationname>
	And I choose to select address type <addresstype>
	And I choose to select address mode <addressmode>
	And I choose to enter destination street address <street>
	And I choose to enter zipcode <zipcode>
	And I choose to select state <state>
	And I choose to select city <city>
	And I choose to save the location
	And I choose to select category <category>
	And I choose to enter instruction <instruction>
	And I choose to save the transaction
	Then I choose to verify the transaction
	And I choose to Select Coordinator <coordinator>
	Then I choose to verify the success message for Assign Coordinator 
	And I choose to Click on Add leg 
	And I choose to Select Transport Type <Transport>
	And I choose to Select Direction <Direction>
	And I choose to select Destination Address type<DestinationAddType>
	And I choose to Enter Desti location <DestiLeg1>
	And I choose to Click on Add button
	Then  I choose to verify the transaction for add leg
	And I choose to Click on Add leg 
	And I choose to Select Transport Type <Transport>
	And I choose to Select Direction <Direction>
	And I choose to select Destination Address type<DestinationAddType>
	And I choose to Enter Desti location <DestiLeg2>
	And I choose to Click on Add button
	Then I choose to verify the transaction for add leg
	Then I choose to select the legs and Assign to Internal Driver
	Then I choose to verify the success message for Leg Assignment 

Examples: 
	| email                                        | password   | customer      | contact    | service | team  | type      | priority | unos    | sirens | tissue  | match     | mode          | locationname | addresstype | addressmode | code | street | zipcode | state    | city     | destmode       | category | instruction | template | addequipment | addequiptype    | coordinator     | Transport | Direction | OriginAddType | DestinationAddType | DestiLeg1                    | DestiLeg2 |
	| TACExAdministratorTest@trinityairmedical.com | YQAQ7&*fy! | Test_Customer | Anish Dasi | Team    | Heart | Immediate | Yes      | 6007748 | Yes    | 8723859 | 871982193 | publicAddress | New York     | Residential | Private     | 6N5  | French | 6773800 | New York | New York | privateAddress | Aircraft | NA          | New York | Yes          | Additional Bags | service account | Ground    | Outbound  | Public        | Public             | Idaho Falls Regional Airport | Trinity   |

Scenario Outline:52. (Team) After the Service Request has been created, validate the functionality of adding multiple legs and then send assignment request to Vendor.
	Given launch the application
	When I choose to enter the email <email>
	And I choose to enter the password <password>
	And I choose to click on submit button
	And I choose to enter email <email>
	And I choose to enter password <password>
	And I choose to verify home page
	And I choose to Click on Service Request
	And I choose to Click on Service Request button
	And I choose to select customer details <customer>
	And I choose to select contact details <contact>
	And I choose to select service type <service>
	And I choose to select team type <team>
	And I choose to select additional equipment <addequipment>
	And I choose to select additional types <addequiptype>
	And I choose to select pickup type <type>
	And I choose to enter unosid <unos>
	And I choose to select ortime and sirens <sirens>
	And I choose to enter tissueid <tissue>
	And I choose to enter matchid <match>
	And I choose to select trip origin transport mode <mode>
	And I choose to create location click and verify
	And I choose to select location name <locationname>
	And I choose to select address type <addresstype>
	And I choose to select address mode <addressmode>
	And I choose to enter street address <street>
	And I choose to enter zipcode <zipcode>
	And I choose to select state <state>
	And I choose to select city <city>
	And I choose to save the location
	And I choose to select trip destinatio transport mode <destmode>
	And I choose to create destination location click and verify
	And I choose to select location name <locationname>
	And I choose to select address type <addresstype>
	And I choose to select address mode <addressmode>
	And I choose to enter destination street address <street>
	And I choose to enter zipcode <zipcode>
	And I choose to select state <state>
	And I choose to select city <city>
	And I choose to save the location
	And I choose to select category <category>
	And I choose to enter instruction <instruction>
	And I choose to save the transaction
	Then I choose to verify the transaction
	And I choose to Select Coordinator <coordinator>
	Then I choose to verify the success message for Assign Coordinator 
	And I choose to Click on Add leg 
	And I choose to Select Transport Type <Transport>
	And I choose to Select Direction <Direction>
	And I choose to select Destination Address type<DestinationAddType>
	And I choose to Enter Desti location <DestiLeg1>
	And I choose to Click on Add button
	Then  I choose to verify the transaction for add leg
	And I choose to Click on Add leg 
	And I choose to Select Transport Type <Transport>
	And I choose to Select Direction <Direction>
	And I choose to select Destination Address type<DestinationAddType>
	And I choose to Enter Desti location <DestiLeg2>
	And I choose to Click on Add button
	Then I choose to verify the transaction for add leg
	Then I choose to select the legs and Assign to External Driver Or Vendor
	Then I choose to verify the success message for Leg Assignment 

Examples: 
	| email                                        | password   | customer      | contact    | service | team  | type      | priority | unos    | sirens | tissue  | match     | mode          | locationname | addresstype | addressmode | code | street | zipcode | state    | city     | destmode       | category | instruction | template | addequipment | addequiptype    | coordinator     | Transport | Direction | OriginAddType | DestinationAddType | DestiLeg1                    | DestiLeg2 |
	| TACExAdministratorTest@trinityairmedical.com | YQAQ7&*fy! | Test_Customer | Anish Dasi | Team    | Heart | Immediate | Yes      | 6007748 | Yes    | 8723859 | 871982193 | publicAddress | New York     | Residential | Private     | 6N5  | French | 6773800 | New York | New York | privateAddress | Aircraft | NA          | New York | Yes          | Additional Bags | service account | Ground    | Outbound  | Public        | Public             | Idaho Falls Regional Airport | Trinity   |

Scenario Outline:58.(Team)After the Service Request has been created, validate the functionality of adding multiple legs and then send assignment request to Vendor.
	Given launch the application
	When I choose to enter the email <email>
	And I choose to enter the password <password>
	And I choose to click on submit button
	And I choose to enter email <email>
	And I choose to enter password <password>
	And I choose to verify home page
	And I choose to Click on Service Request
	And I choose to Click on Service Request button
	And I choose to select customer details <customer>
	And I choose to select contact details <contact>
	And I choose to select service type <service>
	And I choose to select team type <team>
	And I choose to select additional equipment <addequipment>
	And I choose to select additional types <addequiptype>
	And I choose to select pickup type <type>
	And I choose to enter unosid <unos>
	And I choose to select ortime and sirens <sirens>
	And I choose to enter tissueid <tissue>
	And I choose to enter matchid <match>
	And I choose to select trip origin transport mode <mode>
	And I choose to create location click and verify
	And I choose to select location name <locationname>
	And I choose to select address type <addresstype>
	And I choose to select address mode <addressmode>
	And I choose to enter street address <street>
	And I choose to enter zipcode <zipcode>
	And I choose to select state <state>
	And I choose to select city <city>
	And I choose to save the location
	And I choose to select trip destinatio transport mode <destmode>
	And I choose to create destination location click and verify
	And I choose to select location name <locationname>
	And I choose to select address type <addresstype>
	And I choose to select address mode <addressmode>
	And I choose to enter destination street address <street>
	And I choose to enter zipcode <zipcode>
	And I choose to select state <state>
	And I choose to select city <city>
	And I choose to save the location
	And I choose to select category <category>
	And I choose to enter instruction <instruction>
	And I choose to save the transaction
	Then I choose to verify the transaction
	And I choose to Select Coordinator <coordinator>
	Then I choose to verify the success message for Assign Coordinator 
	And I choose to Click on Add leg 
	And I choose to Select Transport Type <Transport>
	And I choose to Select Direction <Direction>
	And I choose to select Destination Address type<DestinationAddType>
	And I choose to Enter Desti location <DestiLeg1>
	And I choose to Click on Add button
	Then  I choose to verify the transaction for add leg
	And I choose to Click on Add leg 
	And I choose to Select Transport Type <Transport>
	And I choose to Select Direction <Direction>
	And I choose to select Destination Address type<DestinationAddType>
	And I choose to Enter Desti location <DestiLeg2>
	And I choose to Click on Add button
	Then I choose to verify the transaction for add leg
	Then I choose to select the legs and Send Assignment Request
	Then I choose to verify the success message for Leg Assignment 

Examples: 
	| email                                        | password   | customer      | contact    | service | team  | type      | priority | unos    | sirens | tissue  | match     | mode          | locationname | addresstype | addressmode | code | street | zipcode | state    | city     | destmode       | category | instruction | template | addequipment | addequiptype    | coordinator     | Transport | Direction | OriginAddType | DestinationAddType | DestiLeg1                    | DestiLeg2 |
	| TACExAdministratorTest@trinityairmedical.com | YQAQ7&*fy! | Test_Customer | Anish Dasi | Team    | Heart | Immediate | Yes      | 6007748 | Yes    | 8723859 | 871982193 | publicAddress | New York     | Residential | Private     | 6N5  | French | 6773800 | New York | New York | privateAddress | Aircraft | NA          | New York | Yes          | Additional Bags | service account | Ground    | Outbound  | Public        | Public             | Idaho Falls Regional Airport | Trinity   |

