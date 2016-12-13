using PetaPoco;
using System.Collections.Generic;

namespace OrmComparison
{
    public static class PetaPocoExample
    {

        public static IList<Campaign> GetAll()
        {
            var results = new List<Campaign>();
            using (IDatabase db = new Database(Settings.ConnectionString, providerName: "SqlServer"))
            {
                results.AddRange(db.Query<Campaign>(Settings.CampaignsQuery));
            }
            return results;
        }

        public static Campaign GetById(int id)
        {
            using (IDatabase db = new Database(Settings.ConnectionString, providerName: "SqlServer"))
            {
                return db.Single<Campaign>("WHERE Id = @0", id);
            }
        }
    }
}
