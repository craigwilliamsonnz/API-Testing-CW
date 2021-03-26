Feature: Get details from API call

    # AC1 Name = "Carbon credits"
    cenario: Check the contents of the Name field
        When the API is called
        Then the returned status is 200 OK
        And the Name field in the response is Carbon credits
    
    # AC2 CanRelist = true 
    Scenario: The auction can be relisted
        When the API is called
        Then the returned status is 200 OK
        And the CanRelist field in the response is true
    
    # AC3 The Promotions element with Name = "Gallery" has a Description that contains the text "2x larger image"
    # At the time of writing this test, the test will currently fail due to different data being returned
    Scenario: The promotion Gallery description
        When the API is called
        Then the returned status is 200 OK
        And the description for the promotion Gallery is 2x larger image