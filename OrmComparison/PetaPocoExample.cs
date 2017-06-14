using PetaPoco;
using System.Collections.Generic;

namespace OrmComparison
{
    public static class PetaPocoExample
    {

        public static IEnumerable<Campaign> GetAll()
        {
            using (IDatabase db = new PetaPoco.Database(Settings.ConnectionString, providerName: "SqlServer"))
            {
                return db.Query<Campaign>(Settings.CampaignsQuery);
            }
        }

        public static Campaign GetById(int id)
        {
            using (IDatabase db = new PetaPoco.Database(Settings.ConnectionString, providerName: "SqlServer"))
            {
                return db.Single<Campaign>("WHERE Id = @0", id);               
            }
        }

        public static void UpdateCampaign(Campaign campaign)
        {

            using (IDatabase db = new PetaPoco.Database(Settings.ConnectionString, providerName: "SqlServer"))
            {
                db.Update(campaign);
            }
        }
    }
}
