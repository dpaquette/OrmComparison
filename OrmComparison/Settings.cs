namespace OrmComparison
{
    public static class Settings
    {
        public static string ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;

        public static string CampaignsQuery = @"SELECT [Id]
                              ,[CampaignImpactId]
                              ,[Description]
                              ,[ExternalUrl]
                              ,[ExternalUrlText]
                              ,[Featured]
                              ,[FullDescription]
                              ,[Headline]
                              ,[ImageUrl]
                              ,[LocationId]
                              ,[Locked]
                              ,[ManagingOrganizationId]
                              ,[Name]
                              ,[OrganizerId]
                              ,[TimeZoneId]
                          FROM [dbo].[Campaign]";


        public static string CampaignByIdQuery = @"SELECT [Id]
                              ,[CampaignImpactId]
                              ,[Description]
                              ,[ExternalUrl]
                              ,[ExternalUrlText]
                              ,[Featured]
                              ,[FullDescription]
                              ,[Headline]
                              ,[ImageUrl]
                              ,[LocationId]
                              ,[Locked]
                              ,[ManagingOrganizationId]
                              ,[Name]
                              ,[OrganizerId]
                              ,[TimeZoneId]
                          FROM [dbo].[Campaign]  WHERE [Id] = @CampaignId";

    }
}
