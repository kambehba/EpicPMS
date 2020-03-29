using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http.Cors;

namespace EpicPMS.Controllers
{
    [ApiController]
    [Route("[controller]")]
    
    public class ApartmentsController : ControllerBase
    {
        [HttpGet]
        public List<Apartment> GetApartments()
        {
            var dataAccess = DataAccess.Instance;
           
            //var f = new List<Apartment>();
            //f.Add(new Apartment() { Bath = 2, Bed = 8, sqf = 785 });
            return dataAccess.GetApartments();
          
        }

     //   [EnableCors(origins: "*", headers: "*", methods: "*")]
        [HttpGet]
        [Route("~/api/onebeds")]
        public List<Apartment> GetOneBeds()
        {
            var dataAccess = DataAccess.Instance;
            return dataAccess.GetApartments(1);

        }

        [HttpGet]
        [Route("~/api/twobeds")]
        public List<Apartment> GetTwoBeds()
        {
            var dataAccess = DataAccess.Instance;
            return dataAccess.GetApartments(2);

        }

        [HttpGet]
        [Route("~/api/threebeds")]
        public List<Apartment> GetThreeBeds()
        {
            var dataAccess = DataAccess.Instance;
            return dataAccess.GetApartments(3);

        }
    }
}
