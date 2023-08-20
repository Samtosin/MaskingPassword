Feature: TestLogin

A short summary of the feature

@tag1
Scenario: validate user can login
	Given i navigate to website "https://practicetestautomation.com/practice-test-login/"
	When i enter username
	And i enter password
	And i click submit
	Then i should login successfully
