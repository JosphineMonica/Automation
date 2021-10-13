Feature: SugarProduct

@SampleTest
Scenario: Login to Sugar
	Given I am a User
	And I login to Sugar Application
	Then I take screenshot
	And I close Sugar Application