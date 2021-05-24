using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo
{
    class SaleManager : ISaleService
    {
        
            public void add(Campaign campaign)
            {
                Console.WriteLine(campaign.campaignName + " Kampanyası Eklendi");
            }

            public void delete(Campaign campaign)
            {
                Console.WriteLine(campaign.campaignName+ " Kampanyası Silindi");
            }

            public void update(Campaign campaign)
            {
                Console.WriteLine(campaign.campaignName + " Kampanyası Güncellendi");
            }
        }
    
}
