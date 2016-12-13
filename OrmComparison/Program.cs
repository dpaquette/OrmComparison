using System;
using System.Collections.Generic;
using ConsoleTables.Core;

namespace OrmComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            var campaign = DataReaderExample.GetById(1);

            DisplayAsTable(campaign);

            Console.WriteLine("Enter a new description");
            campaign.Description = Console.ReadLine();

            DataReaderExample.UpdateCampaign(campaign);

            Console.WriteLine("");
            DisplayAsTable(DataReaderExample.GetById(1));
            

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
