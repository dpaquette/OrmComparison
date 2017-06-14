using Dapper;
using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace OrmComparison
{
    public static class DapperExample
    {

        public static IEnumerable<Campaign> GetAll()
        {

            using (SqlConnection connection = new SqlConnection(Settings.ConnectionString))
            {
                return connection.Query<Campaign>(Settings.CampaignsQuery);
            }
        }

        public static Campaign GetById(int id)
        {
            using (var connection = new SqlConnection(Settings.ConnectionString))
            {
               
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
