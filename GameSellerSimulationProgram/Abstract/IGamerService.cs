using GameSellerSimulationProgram.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSellerSimulationProgram.Abstract
{
    public interface IGamerService
    {
        void Save(Gamer gamer);
        void Update(Gamer gamer);
        void Delete(Gamer gamer);


    }
}
