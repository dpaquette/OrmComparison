using Dapper;
using Dapper.Contrib.Extensions;
using System;
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




        static DapperExample()
        {
            //Override default table name convention for Dapper.Contrib
            SqlMapperExtensions.TableNameMapper = (Type type) =>
            {
                return type.Name;
            };
        }

        public static Campaign GetByIdWithoutSql(int id)
        {
            using (SqlConnection connection = new SqlConnection(Settings.ConnectionString))
            {
                connection.Open();
                return connection.Get<Campaign>(id);
            }
        }

        public static void UpdateCampaign(Campaign campaign)
        {

            using (SqlConnection connection = new SqlConnection(Settings.ConnectionString))
            {
                connection.Open();
                connection.Update(campaign);
            }
        }

    }
}
