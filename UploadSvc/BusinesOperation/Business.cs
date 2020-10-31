using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HoneyWell.Flight.Stream.Core;
using UploadSvc.RepositoryOperation;

namespace UploadSvc.BusinesOperation
{

    /// <summary>
    /// This class will do the business operation of uploading the media in database
    /// </summary>
    public class Business : IBusiness
    {

        private IRepositoryOperation _repositoryOperation;
        public Business(IRepositoryOperation repositoryOperation)
        {
            _repositoryOperation = repositoryOperation ?? throw new ArgumentNullException();
        }

        /// <summary>
        /// This method will check if media is available in flight database or not
        /// </summary>
        /// <param name="guid"></param>
        /// <returns></returns>
        public bool IfAvailable(Flight flight)
        {
            Flight flightOp = _repositoryOperation.GetFlightDetails(flight);
            return _repositoryOperation.GetMediaAvailability(flightOp);

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
