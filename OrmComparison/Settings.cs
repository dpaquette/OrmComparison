namespace OrmComparison
{
    public static class Settings
    {
        public static string ConnectionString = "Server=(localdb)\\MSSQLLocalDB;Database=AllReady;Integrated Security=true;MultipleActiveResultsets=true;";

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
