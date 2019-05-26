Feature: MyApiSteps
	A simple test

Scenario: Request a single user - User is found
	When I send a GET request to api/users/2
	Then StatusCode should be 200
	And property data.id should be the number 2
	And property data.email should be 'janet.weaver@reqres.in'

Scenario: Create a user - User is created and fields are returned
	Given property name equals to 'Mario'
	And property job equals to 'Manager'
	When I send a POST request to api/users
	Then StatusCode should be 201
	And property name should be 'Mario'
	And property job should be 'Manager'
	