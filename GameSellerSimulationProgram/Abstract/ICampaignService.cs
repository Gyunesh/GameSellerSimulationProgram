using GameSellerSimulationProgram.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSellerSimulationProgram.Abstract
{
    public interface ICampaignService
    {
        void Enter(Campaign campaign);
        void Update(Campaign campaign);
        void Delete(Campaign campaign);

    }
}
