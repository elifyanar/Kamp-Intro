using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo
{
    interface ICampaignService
    {
       void add(Campaign campaign);
       void delete(Campaign campaign);
    }
}
