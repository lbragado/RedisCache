using AzureRedisDemo.Data;
using AzureRedisDemo.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace AzureRedisDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        [Route("getcountries")]
        public ActionResult<IEnumerable<CountryBE>> GetCountries()
        {
            return DB.GetListCountries().ToList();
        }

        [HttpGet]
        [Route("getuserinfo")]
        public ActionResult<UserInfo> GetUserInfo()
        {
            return DB.GetUserInfo();
        }

    }
}
