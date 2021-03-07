using GameSellerSimulationProgram.Abstract;
using GameSellerSimulationProgram.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSellerSimulationProgram.Concrete
{
    public class GamerCheckManager : IGamerCheckService

    {
        public bool CheckIfRealPerson(Gamer gamer)
        {
            return true;
        }
    }
}
