using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using GlWebApi.Models;

namespace GlWebApi.Controllers
{
    public class SHTController : ApiController
    {
        [HttpPost]
        public bool AddHumTempDetails(SHT7xValue p)
        {
            p.DBEkle();           
            return true;
            //write insert logic  

        }
    }
}
