using GameSellerSimulationProgram.Abstract;
using GameSellerSimulationProgram.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSellerSimulationProgram.Concrete
{
    public class SalesManager : ISalesManager

    {
        public void SalesToGamer(Game game, Gamer gamer)
        {
            Console.WriteLine(game.GameName +" "+ "adli oyun" +" "+ gamer.FirstName +" "+ "ye" +" "+ game.Price +" "+ "fiyattan satilmistir.");
        }
        public void SalesWithCampaign(Game game, Gamer gamer, Campaign campaign)
        {
            Console.WriteLine(game.GameName +" "+ "adli oyun" +" "+ campaign.CampaignName +" "+ "kampanyasi ile " +" "+ gamer.FirstName +" "+ "ye" +" "+ game.Price +" "+ "fiyattan satilmistir.");
        }



    }
}
