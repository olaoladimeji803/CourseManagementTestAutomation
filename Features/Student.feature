Feature: Student
As a course management system (CMS) user
I should be able to create, modify , view and delete 
A student record

#Prerequisite: A student record Eric Tadar should be deleted
Scenario: Student_01_Verify that a user can create a new student record
	Given that the CMS application is loaded
	When a user clicks on students link
	And a user click on create new link
	And a user fills-in FamilyName field with Eric
	And a user fills-in FirstName field with Tadar
	And a user fills-in EnrollmentDate field with 04/07/2020
	And a user clicks on create button
  #  Then a new student record Eric must be created 

Scenario: Student_02_TableFormat_Verify that a user can create a new student record
	Given that the CMS application is loaded
	When a user clicks on students link
	And a user click on create new link
	And a user fills-in new student record form page with the data below
	| FamilyName | FirstName | EnrollmentDate |
	| Tadar      | Eric      | 04/07/2020     |
	And a user clicks on create button
  # Then a new student record Eric must be created 

