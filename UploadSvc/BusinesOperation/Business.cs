using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HoneyWell.Flight.Stream.Core.Entities;

namespace UploadSvc.BusinesOperation
{

    /// <summary>
    /// This class will do the business operation of uploading the media in database
    /// </summary>
    public class Business : IBusiness
    {

        /// <summary>
        /// This method will check if media is available in flight database or not
        /// </summary>
        /// <param name="guid"></param>
        /// <returns></returns>
        public bool IfAvailable(Guid guid)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Based on the check from IfAvailable Method It will upload/insert the media in databse
        /// </summary>
        /// <param name="flight"></param>
        /// <returns></returns>
        public bool UploadMediaStream(Flight flight)
        {
            throw new NotImplementedException();
        }
    }
}
