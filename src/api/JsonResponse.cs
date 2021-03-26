using System;
using System.Collections.Generic;

namespace API_Testing_CW.src.api
{
    /*
    This class represents the JSON structure of the returned body in the request.
    The JSON deserialiser uses this to convert the JSON into valid objects which
    the test framework can use to extract data from the JSON.

    Note that there are subclasses below as well which reference nested data.
    */
    public class JsonResponse {
        public int CategoryId { get; set; }
        public String Name { get; set; }
        public String Path { get; set; }
        public Boolean CanListAuctions { get; set; }
        public Boolean CanListClassifieds { get; set; }
        public Boolean CanRelist { get; set; }
        public String LegalNotice { get; set; }
        public int DefaultDuration { get; set; }
        public List<int> AllowedDurations { get; set; }
        public Fees Fees { get; set; }
        public int FreePhotoCount { get; set; }
        public int MaximumPhotoCount { get; set; }
        public Boolean IsFreeToRelist { get; set; }
        public List<Promotions> Promotions { get; set; }
        public List<EmbeddedContentOptions> EmbeddedContentOptions { get; set; }
        public int MaximumTitleLength { get; set; }
        public int AreaOfBusiness { get; set; }
        public int DefaultRelistDuration { get; set; }
    }
}
public class Fees {
    public float Bundle { get; set; }
    public float EndDate { get; set; }
    public float Feature { get; set; }
    public float Gallery { get; set; }
    public float Listing { get; set; }
    public float Reserve { get; set; }
    public float Subtitle { get; set; }
    public float TenDays { get; set; }
    public List<ListingFeeTiers> ListingFeeTiers { get; set;}
    public float SecondCategory { get; set; }
}

public class ListingFeeTiers {
    public float MinimumTierPrice { get; set; }
    public float FixedFee { get; set; }
}

public class Promotions {
    public float Id { get; set; }
    public String Name { get; set; }
    public String Description { get; set; }
    public float Price { get; set; }
    public float OriginalPrice { get; set; }
    public Boolean Recommended { get; set; }
    public float MinimumPhotoCount { get; set; }
}

public class EmbeddedContentOptions {

}