using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http.Cors;

namespace EpicPMS.Controllers
{
    [ApiController]
    [Route("[controller]")]
    
    public class ApartmentsController : ControllerBase
    {
       

        [HttpGet]
        [Route("~/api/apartments/onebeds")]
        public List<Apartment> GetOneBeds()
        {
            var dataAccess = DataAccess.Instance;
            return dataAccess.GetApartments(1);

        }

        
        [HttpGet]
        [Route("~/api/apartments/twobeds")]
        public List<Apartment> GetTwoBeds()
        {
            var dataAccess = DataAccess.Instance;
            return dataAccess.GetApartments(2);

        }

        [HttpGet]
        [Route("~/api/apartments/threebeds")]
        public List<Apartment> GetThreeBeds()
        {
            var dataAccess = DataAccess.Instance;
            return dataAccess.GetApartments(3);

        }

       // [HttpPost]
       // [Route("~/api/assignTenent")]
       // public HttpResponseMessage AssignTenent([FromBody] Tenent tenent)
       // {
       //     HttpResponseMessage m = new HttpResponseMessage(System.Net.HttpStatusCode.OK);
       //     var dataAccess = DataAccess.Instance;
       //     dataAccess.AssignTennet(tenent); 
       //     return m;

       //}




    }
}
