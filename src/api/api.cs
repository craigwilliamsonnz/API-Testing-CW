using System;
using RestSharp;
using Newtonsoft.Json;


namespace API_Testing_CW.src.api
{
    public class apiTests {
        RestClient client = new RestClient("https://api.tmsandbox.co.nz/v1/Categories/");
        IRestResponse response;

        // This function calls the API and gets its response
        public void callAPI()
        {
            RestRequest request = new RestRequest("6327/Details.json", DataFormat.Json);
            this.response = client.Get(request);
        }

        // This function returns the status code number of the response
        public int getStatusCode()
        {
            return (int)this.response.StatusCode;
        }

        // This function returns the status code description of the response
        public String getStatusDescription()
        {
            return this.response.StatusDescription;
        }

        // This function deserialises the body of the response into a valid JSON object
        public JsonResponse getJsonBody()
        {
            return JsonConvert.DeserializeObject<JsonResponse>(response.Content);
        }

        // This function returns the string contents of the Name field in the response
        public string returnName()
        {
            return getJsonBody().Name;
        }

        // This function returns the boolean of the CanRelist field in the response
        public Boolean returnCanRelist()
        {
            return getJsonBody().CanRelist;
        }
        
        /*
        This function goes through all the Promotions entries searching for a
        particular promotion and then returns the description for that promotion.
        If the desired promotion isn't found then it returns "Promotion not found"
        */
        public String returnPromotionDescription(String Promotion)
        {
            for (int i = 0; i < getJsonBody().Promotions.Count; i++) {
                if (getJsonBody().Promotions[i].Name == Promotion) {
                    return getJsonBody().Promotions[i].Description;
                }
            }
            return "Promotion not found";
        }
    }
}