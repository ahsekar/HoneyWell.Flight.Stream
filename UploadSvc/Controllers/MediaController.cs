using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HoneyWell.Flight.Stream.Core.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UploadSvc.BusinesOperation;

namespace UploadSvc.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MediaController : ControllerBase
    {

        private IBusiness _business;
        public MediaController(IBusiness business)
        {
            _business = business;
        }

        // GET: api/Media
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET: api/Media/5
        //[HttpGet("{id}", Name = "Get")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST: api/Media
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        // PUT: api/Media/5
        [HttpPut("{flighdata}")]
        public void Put([FromBody] Flight flighdata)
        {
            //todo call repo method

        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{guid}")]
        public void Delete(Guid guid)
        {
            //to delete the media file from flight database
        }
    }
}
