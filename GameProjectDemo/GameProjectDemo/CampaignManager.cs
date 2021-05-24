using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo
{
    class CampaignManager : ICampaignService
    {
        public void add(Campaign campaign)
        {
            Console.WriteLine(campaign.campaignName + " added.");
        }

        public void delete(Campaign campaign)
        {
            Console.WriteLine(campaign.campaignName + " deleted.");
        }
    }
}
