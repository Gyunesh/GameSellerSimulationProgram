using GameSellerSimulationProgram.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSellerSimulationProgram.Entities
{
    public class Campaign:IEntitiy
    {
        public string CampaignName { get; set; }
        public string ValidationDate { get; set; }
        public string Specification { get; set; }

    }
}
