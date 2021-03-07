using GameSellerSimulationProgram.Abstract;
using GameSellerSimulationProgram.Entities;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSellerSimulationProgram.Adapters
{
    public class MernisServiceAdapters : IGamerCheckService
    {
        public bool CheckIfRealPerson(Gamer gamer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody(gamer.NationalId, gamer.FirstName.ToUpper(), gamer.LastName.ToUpper(), gamer.DateOfYear))).Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
