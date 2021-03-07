using GameSellerSimulationProgram.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSellerSimulationProgram.Entities
{
    public class Gamer:IEntitiy
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int DateOfYear { get; set; }
        public long NationalId { get; set; }


    }
}
