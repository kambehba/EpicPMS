using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EpicPMS.Controllers
{
    [EnableCors("*","*","*")]
    [Route("api/[controller]")]
    [ApiController]
    public class TenentsController : ControllerBase
    {
        // GET: api/Tenents
        [HttpGet]
        [Route("~/api/Tenents/Tenents")]
        public List<string> Get()
        {
            return new List<string>() { "value1", "value2" };
        }

        // GET: api/Tenents/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Tenents
        //[EnableCors(origins: "*", headers: "*", methods: "*")]
      
        [HttpPost]
        [Route("~/api/Tenents/AssignTenent")]
        public HttpResponseMessage Post([FromBody] Tenent tenent)
        {
            var g = new HttpResponseMessage();
            var dataAccess = DataAccess.Instance;
            dataAccess.AssignTenent(tenent);
            return g;
        }

        // PUT: api/Tenents/5
        [HttpPut]
        public void AssignTenent([FromBody] Tenent tenent)
        {
           
            
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
