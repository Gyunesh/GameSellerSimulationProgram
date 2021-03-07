using GameSellerSimulationProgram.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSellerSimulationProgram.Abstract
{
    public interface ISalesManager
    {
        void SalesToGamer(Game game,Gamer gamer);
        void SalesWithCampaign(Game game, Gamer gamer, Campaign campaign);
    }
}
