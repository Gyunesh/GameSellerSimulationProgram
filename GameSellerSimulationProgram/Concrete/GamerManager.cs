using GameSellerSimulationProgram.Abstract;
using GameSellerSimulationProgram.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSellerSimulationProgram.Concrete
{
    public class GamerManager : IGamerService

    {
        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Oyuncu bilgileri silindi." +" "+ gamer.FirstName);
        }

        IGamerCheckService _gamerCheckService;

        public GamerManager(IGamerCheckService gamerCheckService)
        {
            _gamerCheckService = gamerCheckService;
        
        }



        public void Save(Gamer gamer)
        {
            if (_gamerCheckService.CheckIfRealPerson(gamer))
            {
                Console.WriteLine("Oyuncu bilgileri kaydedildi." +" "+ gamer.FirstName);
            }
            else
            {
                throw new Exception("Kisi bilgileri gecerli degildir.");
            }
            
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Oyuncu bilgileri guncellendi." +" "+ gamer.FirstName);
        }
    }
}
