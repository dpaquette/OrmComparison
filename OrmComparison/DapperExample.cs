using Dapper;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace OrmComparison
{
    public static class DapperExample
    {

        public static IList<Campaign> GetAll()
        {
            var results = new List<Campaign>();

            using (SqlConnection connection = new SqlConnection(Settings.ConnectionString))
            {
                connection.Open();
                results.AddRange(connection.Query<Campaign>(Settings.CampaignsQuery));
            }
            return results;
        }

        public static Campaign GetById(int id)
        {
            using (SqlConnection connection = new SqlConnection(Settings.ConnectionString))
            {
                connection.Open();
                return connection.QuerySingle<Campaign>(Settings.CampaignByIdQuery, 
                                                new { CampaignId = id });
            }
        }
    }
}
