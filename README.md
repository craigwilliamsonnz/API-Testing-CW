# API-Testing-CW
API testing example using SpecFlow, RestSharp, and dotNet Core

# Prerequisites
This small project was written with dotNet Core SDK 5.0.4.  So use that version as a base line.  I wrote the tests under Linux with VS Code but running it under Windows should be fine as well.  Previous versions of dotNet core might work but haven't been tested.

# Running the application
1. In a terminal, navigate to the root folder of the application.
2. Use the following command to run the tests: ```dotnet test```
3. The dependencies for the application should download initally before the tests are run.
4. Wait until the application has finished executing.

# Results
Once the application has finished running then in the terminal check the results.  If all three tests passed then you should see something like the following:

```
Passed!  - Failed:     0, Passed:     3, Skipped:     0, Total:     3, Duration: 755 ms
```

At the time of writing AC3 will fail as an incorrect message is being returned in the JSON.  So if the test fails you should see:

```
Passed!  - Failed:     1, Passed:     2, Skipped:     0, Total:     3, Duration: 752 ms
```

The failing test should show exactly what the failing test was and what was expected vs what was returned.  For example if AC3 fails then you should see something similar to:

```
Failed ThePromotionGalleryDescription [149 ms]
  Error Message:
     Expected string length 15 but was 25. Strings differ at index 0.
  Expected: "2x larger image"
  But was:  "Good position in category"
  -----------^

  Stack Trace:
     at API_Testing_CW.src.steps.getDetailsStepDefs.theDescriptionForThePromotionIs(String promotion, String expectedValue) in /home/craigw/dev/API-Testing-CW/stepdefs/getDetailsStepDefs.cs:line 51
   at TechTalk.SpecFlow.Bindings.BindingInvoker.InvokeBinding(IBinding binding, IContextManager contextManager, Object[] arguments, ITestTracer testTracer, TimeSpan& duration)
   at TechTalk.SpecFlow.Infrastructure.TestExecutionEngine.ExecuteStepMatch(BindingMatch match, Object[] arguments, TimeSpan& duration)
   at TechTalk.SpecFlow.Infrastructure.TestExecutionEngine.ExecuteStep(IContextManager contextManager, StepInstance stepInstance)
   at TechTalk.SpecFlow.Infrastructure.TestExecutionEngine.OnAfterLastStep()
   at TechTalk.SpecFlow.TestRunner.CollectScenarioErrors()
   at API_Testing_CW.Features.GetDetailsFromAPICallFeature.ScenarioCleanup()
   at API_Testing_CW.Features.GetDetailsFromAPICallFeature.ThePromotionGalleryDescription() in /home/craigw/dev/API-Testing-CW/features/getDetails.feature:line 20

  Standard Output Messages:
 When the API is called
 -> done: getDetailsStepDefs.theAPIIsCalled() (0.1s)
 Then the returned status is 200 OK
 -> done: getDetailsStepDefs.theReturnedStatusCodeIs(200, "OK") (0.0s)
 And the description for the promotion Gallery is 2x larger image
 -> error:   Expected string length 15 but was 25. Strings differ at index 0.
   Expected: "2x larger image"
   But was:  "Good position in category"
   -----------^
  (0.0s)
```
