﻿namespace ReservationProject.CQRS.Results.GuideResults
{
    public class GetAllGuideQueryResult
    {
        public int GuideID { get; set; }
        public string? GuideName { get; set; }
        public string? GuideDescription { get; set; }
        public string? GuideImage { get; set; }
    }
}
