using GameSellerSimulationProgram.Abstract;
using GameSellerSimulationProgram.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSellerSimulationProgram.Concrete
{
    public class CampaignManager : ICampaignService

    {
        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Kampanya Silindi." +" " + campaign.CampaignName);
        }

        public void Enter(Campaign campaign)
        {
            Console.WriteLine("Kampanya girisi yapildi." +" " + campaign.CampaignName);
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Kampanya Guncellendi." +" "+ campaign.CampaignName);
        }
    }
}
