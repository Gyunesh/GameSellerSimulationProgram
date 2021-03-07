using GameSellerSimulationProgram.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSellerSimulationProgram.Entities
{
    public class Game:IEntitiy
    {
        public int Id { get; set; }
        public string GameName { get; set; }
        public string GameType { get; set; }
        public int GameStock { get; set; }
        public double Price { get; set; }



    }
}
