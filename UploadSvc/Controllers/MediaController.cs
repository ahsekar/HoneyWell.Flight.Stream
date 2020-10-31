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

       
        [HttpPut("{flighdata}")]
        public void UploadMedia([FromBody] Flight flighdata)
        {
            if (flighdata.Id <= 0)
                throw new ArgumentNullException();

            if (_business.IfAvailable(flighdata))
            {
                _business.UploadMediaStream(flighdata);
            }
            else
                throw new Exception("Flight Media Upload is not available now");


        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{guid}")]
        public void Delete(Guid guid)
        {
            //to delete the media file from flight database
        }
    }
}
