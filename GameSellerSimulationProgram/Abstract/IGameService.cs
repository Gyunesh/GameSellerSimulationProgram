using GameSellerSimulationProgram.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSellerSimulationProgram.Abstract
{
    public interface IGameService
    {
        void Sale(Game game);
        void Update(Game game);
        void Delete(Game game);


    }
}
