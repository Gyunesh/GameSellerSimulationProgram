using GameSellerSimulationProgram.Adapters;
using GameSellerSimulationProgram.Concrete;
using GameSellerSimulationProgram.Entities;
using System;

namespace GameSellerSimulationProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("//////////////////////Oyuncu Kaydi.//////////////////////");
            
            Gamer gamer1 = new Gamer();
            gamer1.Id = 1;
            gamer1.FirstName = "Ali";
            gamer1.LastName = "Veli";
            gamer1.NationalId = 123456789;
            gamer1.DateOfYear = 1978;

            Gamer gamer2 = new Gamer();
            gamer2.Id = 2;
            gamer2.FirstName = "Ayse";
            gamer2.LastName = "Urkmez";
            gamer2.NationalId = 987654321;
            gamer2.DateOfYear = 2001;


            GamerManager gamerManager1 = new GamerManager(new GamerCheckManager());
            gamerManager1.Save(gamer1);
            gamerManager1.Delete(gamer1);
            gamerManager1.Update(gamer1);




            Console.WriteLine("///////////////////////Oyun Kaydi.///////////////////////");
            
            Game game1 = new Game();
            game1.Id = 101;
            game1.GameName = "StarWars";
            game1.GameType = "science_fiction";
            game1.GameStock = 54;
            game1.Price = 75;

            Game game2 = new Game();
            game2.Id = 201;
            game2.GameName = "Boomerang";
            game2.GameType = "Strategy";
            game2.GameStock = 21;
            game2.Price = 95;

            GameManager gameManager1 = new GameManager();
            gameManager1.Delete(game1);
            gameManager1.Sale(game1);
            gameManager1.Update(game1);



            Console.WriteLine("////////////////////Kampanya Girisi.////////////////////");

            Campaign campaign1 = new Campaign();
            campaign1.CampaignName = "WinterBreak";
            campaign1.Specification = "%20 discount for every game.";
            campaign1.ValidationDate = "21 Nisan 2021";

            Campaign campaign2 = new Campaign();
            campaign2.CampaignName = "StudentDiscount";
            campaign2.Specification = "%35 discount for Students ";
            campaign2.ValidationDate = "15 Haziran 2021";

            CampaignManager campaignManager1 = new CampaignManager();
            campaignManager1.Enter(campaign1);
            campaignManager1.Delete(campaign1);
            campaignManager1.Update(campaign1);



            Console.WriteLine("////////////////////Satis Islemi.////////////////////");
            SalesManager salesManager1 = new SalesManager();
            salesManager1.SalesToGamer(game2, gamer1);
            Console.WriteLine("////////////////////Kampanyali Satis Islemi.////////////////////");
            SalesManager salesManager2 = new SalesManager();
            salesManager2.SalesWithCampaign(game1, gamer2, campaign1);











        }
    }
}
