using System;

namespace OrmComparison
{
    public class Campaign
    {
        public int Id { get; set; }
        public int? CampaignImpactId { get; set; }
        public string Description { get; set; }
        public string ExternalUrl { get; set; }
        public string ExternalUrlText { get; set; }
        public bool Featured { get; set; }
        public string FullDescription { get; set; }

        public string Headline { get; set; }
        public string ImageUrl { get; set; }
        public int LocationId { get; set; }
        public bool Locked { get; set; }
        
        public int ManagingOrganizationId { get; set; }

        public string Name { get; set; }
        public int? OrganizerId { get; set; }
        public string TimeZoneId { get; set; }
    }
}
