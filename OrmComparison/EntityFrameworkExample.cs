using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace OrmComparison
{
    public class CampaignContext : DbContext
    {
        public CampaignContext(string connectionString)
            :base(connectionString)
        {

        }
        public DbSet<Campaign> Campaigns { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Campaign>().ToTable("Campaign");
        }
    }

    public static class EntityFrameworkExample
    {
        public static IEnumerable<Campaign> GetAll()
        {
            using (var context = new CampaignContext(Settings.ConnectionString))
            {
                return context.Campaigns.ToList();
            }
        }

        public static Campaign GetById(int id)
        {
            using (var context = new CampaignContext(Settings.ConnectionString))
            {
                return context.Campaigns.Find(id);
            }
        }

        public static Campaign GetByIdUsingSql(int campaignId)
        {
            using (var context = new CampaignContext(Settings.ConnectionString))
            {
                return context.Database.SqlQuery<Campaign>(@"SELECT [Id]
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
                          FROM [dbo].[Campaign]  WHERE [Id] = @p0", campaignId).Single();
            }
        }

        public static void UpdateCampaign(Campaign campaign)
        {
            using (var context = new CampaignContext(Settings.ConnectionString))
            {
                context.Entry(campaign).State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
