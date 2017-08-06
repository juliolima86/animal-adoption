using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using andreaejulio.animaladoption.core;
using Newtonsoft.Json;

namespace andreaejulio.animaladoption.awswebapi.Controllers
{
    [Route("api/[controller]")]
    public class OngInformationController : Controller
    {
        private readonly IOngInformationRepository _ongInformationRepository;

        public OngInformationController(IOngInformationRepository ongInformationRepository)
        {
            _ongInformationRepository = ongInformationRepository;
        }

        // GET api/values
        [HttpGet]
        public string Get()
        {
            return JsonConvert.SerializeObject(_ongInformationRepository.GetDefault());
        }
    }
}
