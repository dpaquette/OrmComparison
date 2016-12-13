using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace OrmComparison
{
    public static class DataReaderExample
    {
        public static IList<Campaign> GetAll()
        {
            var results = new List<Campaign>();

            
            using (SqlConnection connection = new SqlConnection(Settings.ConnectionString))
            {
                SqlCommand command = new SqlCommand(Settings.CampaignsQuery, connection);
                connection.Open();
                IDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    results.Add(ReadSingleRow(reader));
                }
                reader.Close();
            }
            return results;
        }

        public static Campaign GetById(int id)
        {
            Campaign result;
            
            using (SqlConnection connection = new SqlConnection(Settings.ConnectionString))
            {
                SqlCommand command = new SqlCommand(Settings.CampaignByIdQuery, connection);
                command.Parameters.AddWithValue("CampaignId", id);
                connection.Open();

                IDataReader reader = command.ExecuteReader();
                reader.Read();
                result = ReadSingleRow(reader);
                reader.Close();
            }
            return result;
        }

        public static Campaign ReadSingleRow(IDataReader dataReader)
        {
            var campaign = new Campaign();


            campaign.Id = dataReader.GetInt32(0);
            campaign.CampaignImpactId = dataReader.IsDBNull(1) ? default(int?) : dataReader.GetInt32(1);
            campaign.Description = dataReader.IsDBNull(2) ? null : dataReader.GetString(2);
            campaign.ExternalUrl = dataReader.IsDBNull(3) ? null : dataReader.GetString(3);
            campaign.ExternalUrlText = dataReader.IsDBNull(4) ? null : dataReader.GetString(4);
            campaign.Featured = dataReader.GetBoolean(5);
            campaign.FullDescription = dataReader.IsDBNull(6) ? null : dataReader.GetString(6);
            campaign.Headline = dataReader.IsDBNull(7) ? null : dataReader.GetString(7);
            campaign.ImageUrl = dataReader.IsDBNull(8) ? null : dataReader.GetString(8);
            campaign.LocationId = dataReader.GetInt32(9);
            campaign.Locked = dataReader.GetBoolean(10);
            campaign.ManagingOrganizationId = dataReader.GetInt32(11);
            campaign.Name = dataReader.GetString(12);
            campaign.OrganizerId = dataReader.IsDBNull(13) ? default(int?) : dataReader.GetInt32(13);
            campaign.TimeZoneId = dataReader.GetString(14);

            return campaign;
        }

        public static void UpdateCampaign(Campaign campaign)
        {

            using (SqlConnection connection = new SqlConnection(Settings.ConnectionString))
            {
                
                SqlCommand command = new SqlCommand(@"UPDATE[Campaign] SET
                              [Description] = @Description,
                              [Name] = @Name,
                              [TimeZoneId] = @TimeZoneId
                          WHERE[Id] = @Id", connection);
                command.Parameters.AddWithValue("Id", campaign.Id);                
                command.Parameters.AddWithValue("Description", campaign.Description);
                command.Parameters.AddWithValue("Name", campaign.Name);
                command.Parameters.AddWithValue("TimeZoneId", campaign.TimeZoneId);
                //All other parameters

                connection.Open();
                command.Transaction = connection.BeginTransaction();

                var affectedRows = command.ExecuteNonQuery();
                if (affectedRows == 1)
                {
                    command.Transaction.Commit();
                }
                else
                {
                    command.Transaction.Rollback();
                    throw new System.Exception("Something has gone horribly wrong");
                }
            }
        }
    }
}
