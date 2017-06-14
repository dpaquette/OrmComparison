using System;
using System.Collections.Generic;
using ConsoleTables.Core;

//change this for different providers
using static FSharpTypeProviderExample;
//using static OrmComparison.DapperExample;
//using static OrmComparison.AutoMapperExample;
//using static OrmComparison.EntityFrameworkExample;
//using static OrmComparison.PetaPocoExample;

namespace OrmComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            var campaign = GetById(1);

            DisplayAsTable(campaign);

            Console.WriteLine("Enter a new description");
            campaign.Description = Console.ReadLine();

            UpdateCampaign(campaign);

            Console.WriteLine("");
            DisplayAsTable(GetById(1));
            

            Console.ReadLine();
        }

        static void DisplayAsTable(IEnumerable<Campaign> campaigns)
        {
            var table = new ConsoleTable("Id", "Name", "TimeZoneId", "Description");
            foreach (var campaign in campaigns)
            {
                table.AddRow(campaign.Id, campaign.Name, campaign.TimeZoneId, campaign.Description);
            }
            table.Write();
        }

        static void DisplayAsTable(Campaign campaign)
        {
            DisplayAsTable(new[] { campaign });
        }
    }
}
