using GameSellerSimulationProgram.Abstract;
using GameSellerSimulationProgram.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSellerSimulationProgram.Concrete
{
    public class GameManager : IGameService
    {
        public void Delete(Game game)
        {
            Console.WriteLine("Oyun bilgileri silindi." +" "+ game.GameName);
        }

        public void Sale(Game game)
        {
            Console.WriteLine("Oyun satisi gerceklesti." +" "+ game.GameName);
        }

        public void Update(Game game)
        {
            Console.WriteLine("Oyun bilgileri guncellendi." +" "+ game.GameName);
        }
    }
}
