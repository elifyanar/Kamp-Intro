using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo
{
   interface ISaleService
    {
        void add(Campaign campaign);
        void update(Campaign campaign);
        void delete(Campaign campaign);


    }
}
