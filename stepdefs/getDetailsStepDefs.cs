using TechTalk.SpecFlow;
using System;
using NUnit.Framework;
using API_Testing_CW.src.api;

namespace API_Testing_CW.src.steps
{
    /*
    This class takes each line in the feature files and converts them
    into executable code.
    */
    [Binding]
    public class getDetailsStepDefs
    {
        apiTests api;
        public getDetailsStepDefs ()
        {
            api = new apiTests();
        }
        /* ====== GIVEN ====== */

        /* ====== WHEN ====== */
        [When(@"the API is called")]
        public void theAPIIsCalled(){
            api.callAPI();
        }

        /* ====== THEN ====== */

        [Then(@"the returned status is (.+) (.+)")]
        public void theReturnedStatusCodeIs (int statusCode, String statusDescription)
        {
            Assert.AreEqual(statusCode, api.getStatusCode(), "Returned status code is not correct");
            Assert.AreEqual(statusDescription, api.getStatusDescription(), "Returned status description is not correct");
        }

        [Then(@"the Name field in the response is (.+)")]
        public void theNameFieldInTheResponseIs(String expectedValue)
        {
            Assert.AreEqual(expectedValue, api.returnName(), "The expected value is not what was returned");
        }

        [Then(@"the CanRelist field in the response is true")]
        public void theCanRelistFieldInTheResponseIs()
        {
            Assert.IsTrue(api.returnCanRelist(), "The expected value is not what was returned");
        }

        [Then(@"the description for the promotion (.+) is (.+)")]
        public void theDescriptionForThePromotionIs (String promotion, String expectedValue) {
            Assert.AreEqual(expectedValue, api.returnPromotionDescription(promotion));
        }
    }
}