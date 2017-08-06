using andreaejulio.animaladoption.core;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace andreaejulio.animaladoption.repositoryfake
{
    public class OngInformationRepositoryFake : IOngInformationRepository
    {
        OngInformation IOngInformationRepository.GetDefault()
        {
            string jsonPath = Path.Combine(AppContext.BaseDirectory, "FakeData.json");
            OngInformation ong = JsonConvert.DeserializeObject<OngInformation>(File.ReadAllText(jsonPath));
            
            return ong;
        }
    }
}
