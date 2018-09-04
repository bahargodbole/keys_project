Feature: Tenant_MyRentals1
	In order to check "send request" functionality of first rental property on "Your Rental Properties" page
	As a tenant
	I want to send message to property owner of the selected property

@mytag
Scenario: Send message to property owner
	Given I have logged in as a tenant
	And I have clicked on "Tenant" dropdown and I have selected "My Rentals" option from "Tenant" dropdown
	And I have clicked on list box icon of the first record and selected "Send Request" option from the list
	And I have fetched test data("description added") from excel file into the "Message" box on "Rental Request Form"
	When I clicked on "Submit" button
	Then the data is saved in "My Requests" page of Tenant account
        
        
       
