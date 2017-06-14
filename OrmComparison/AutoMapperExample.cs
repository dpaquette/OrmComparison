using AutoMapper;
using AutoMapper.Data;
using AutoMapper.Mappers;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace OrmComparison
{
    public static class AutoMapperExample
    {
        static AutoMapperExample()
        {
            Mapper.Initialize(cfg => {
                MapperRegistry.Mappers.Add(new DataReaderMapper());
                cfg.CreateMap<IDataReader, Campaign>();
            });
        }

        public static IEnumerable<Campaign> GetAll()
        {
            var results = new List<Campaign>();

            using (SqlConnection connection = new SqlConnection(Settings.ConnectionString))
            {
                SqlCommand command = new SqlCommand(Settings.CampaignsQuery, connection);
                IDataReader reader = command.ExecuteReader();
                results.AddRange(Mapper.Map<IDataReader, IEnumerable<Campaign>>(reader));
            }
            return results;
        }
    }
}
